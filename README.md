# Cypress .NET SDK

## Installing the SDK

### Option 1: DLL
 - Copy **cypress-dotnet-sdk.dll** and **cypress-dotnet-sdk.dll.config** to a known location
 - Add the DLL as a reference to your project


### Option 2: Import project
 - Copy the whole repository, and import the **cypress-dotnet-sdk.csproj** as an existing project

### Option 3: Re-generate code
 - Using the RAML Tools for .NET extension (https://visualstudiogallery.msdn.microsoft.com/cadcb820-762c-4514-9817-884b7558aaa9) you can re-generate the code yourself and make changes if desired
 - Use the **cypress.raml** file to generate code

### Required libraries:
Nuget:
 - Newtonsoft.Json
 - RAML.Api.Core (v0.10.1)
 - Microsoft ASP.NET Web API 2.2 Client Libraries (Microsoft.AspNet.WebApi.Client)

Assemblies references:
  - System.Net.Http
  - System.Net.Http.Formatting


## Using the SDK
## Sample Code

### Connecting to the Server

```csharp
System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
httpClient.BaseAddress = new Uri("http://cypress-location.url/");
var auth = System.Text.Encoding.ASCII.GetBytes("username:password");
httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(auth));
httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

CypressClient client = new CypressClient(httpClient);
```

### Getting the Cypress Version (Endpoint now available in Cypress 6.2)

```csharp
var cypress_version = await client.CypressVersion.Get();
Console.WriteLine(cypress_version.Content.Version);
```

### Validating a QRDA file (Endpoint now available in Cypress 6.2)

```csharp
string year = "2022";
string qrda_type = "qrdaIII";
string implementation_guide = "hl7";

var postContent = new MultipartFormDataContent();

var fileContent = File.ReadAllBytes("C:\\Users\\jsmith\\Desktop\\Sample_QRDA_III.xml");
postContent.Add(new ByteArrayContent(fileContent), "file", "Sample_QRDA_III.xml");

var submitQrdaValidationRequest =
	new QrdaValidationsPostRequest(new QrdaValidationsUriParameters { Year = year, Qrda_type = qrda_type, Implementation_guide = implementation_guide },
		postContent);

var validationResults = await client.QrdaValidations.Post(submitQrdaValidationRequest);
var errorlist = validationResults.Content.QrdaValidationsPostCreatedResponseContent.Execution_errors;

foreach (ExecutionErrors error in errorlist)
{
	Console.WriteLine(error.Message);
}
```

### Creating a Vendor

```csharp
var vendorCreateResponse =
	await client.Vendors.Post(new VendorsPostRequestContent { Name = "Vendor Name" });

if (vendorCreateResponse.StatusCode == HttpStatusCode.Created)
{
	// vendor created successfully
	string vendorID = vendorCreateResponse.RawHeaders.Location.Segments.Last();
} else if ((int) vendorCreateResponse.StatusCode == 422)
{
    var errors = vendorCreateResponse.Content.VendorsPost422ResponseContent;
    foreach (var error in errors.Errors)
    {
        Console.WriteLine("{0}: {1}", error.Field, string.Join(", ", error.Messages));
    }
}
```

### Creating a Product

```csharp
var bundles = client.Bundles.Get().Result.Content;

// assume for now there's only 1 bundle

string bundleID = bundles[0].Links.First(link => link.Rel == "self").Href.Split('/').Last();

var measures = client.Bundles.Measures.Get(bundleID).Result.Content;

IList<string> measureIDs = new List<string>();
measureIDs.Add(measures[2].Hqmf_id);
measureIDs.Add(measures[3].Hqmf_id);
measureIDs.Add(measures[5].Hqmf_id);

string newProductName = "Example Product Name";

var product = new VendorsIdProductsPostRequestContent { Name = newProductName, C1_test = true, Bundle_id = bundleID, Measure_ids = measureIDs };

var productCreateResponse = await client.Vendors.Products.Post(product, vendorID);
if (productCreateResponse.StatusCode == HttpStatusCode.Created)
{
	// product created successfully
	string productID = productCreateResponse.RawHeaders.Location.Segments.Last();
} else if ((int) productCreateResponse.StatusCode == 422)
{
    var errors = productCreateResponse.Content.VendorsIdProductsPost422ResponseContent;
    foreach (var error in errors.Errors)
    {
        Console.WriteLine("{0}: {1}", error.Field, string.Join(", ",error.Messages));
    }
    return;
}
```

### Getting Patients for a Product Test
```csharp
var allProductTests = client.ProductsProductIdProductTests.Get(productID).Result.Content;

foreach (var pTest in allProductTests)
{
	string productTestID = pTest.Links.First(link => link.Rel == "self").Href.Split('/').Last();

	var prodTest = client.ProductsProductIdProductTests.GetById(productTestID, productID).Result.Content; ;

	while (prodTest.State != "ready")
	{
		Thread.Sleep(10000);

		prodTest = client.ProductsProductIdProductTests.GetById(productTestID, productID).Result.Content;
	}

	string patientsURL = prodTest.Links.First(link => link.Rel == "patients").Href;

	string patientsFile = "C:\\<location_to_save_file>";

	using (var wc = new WebClient())
	{
		wc.BaseAddress = httpClient.BaseAddress.ToString();
		wc.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", Convert.ToBase64String(auth));
		wc.DownloadFile(patientsURL, patientsFile);
	}

```


### Uploading Results Files

```csharp
var tasks = client.ProductTestsProductTestIdTasks.Get(productTestID).Result.Content;

foreach (var t in tasks)
{
	string taskID = t.Links.First(link => link.Rel == "self").Href.Split('/').Last(); ;

	var task = client.ProductTestsProductTestIdTasks.GetById(taskID, productTestID).Result.Content;

	var postContent = new MultipartFormDataContent();

	var fileContent = File.ReadAllBytes("C:\\Users\\jsmith\\Desktop\\Sample_QRDA_III.xml");
	postContent.Add(new ByteArrayContent(fileContent), "results", "Sample_QRDA_III.xml");

	var submitTestExecutionRequest =
		new TasksTaskIdTestExecutionsPostRequest(new TasksTaskIdTestExecutionsUriParameters { Task_id = taskID },
			postContent);

	var testExecution = await client.TasksTaskIdTestExecutions.Post(submitTestExecutionRequest);
	var testExecutionID = testExecution.RawHeaders.Location.Segments.Last();
```

### Viewing Test Execution Status

```csharp
var testEx = await client.TasksTaskIdTestExecutions.GetById(testExecutionID, taskID);

var testExResult = testEx.Content;

while (testExResult.State != "passed" && testExResult.State != "failed")
{
	Console.WriteLine(testExResult.State);
	Thread.Sleep(10000);
	var res = client.TasksTaskIdTestExecutions.GetById(testExecutionID, taskID).Result;
	testExResult = res.Content;
}

if (testExResult.Execution_errors != null)
{
	foreach (var error in testExResult.Execution_errors)
	{
		Console.WriteLine(error.Message);
	}
}
```

License
-------

Copyright 2016 The MITRE Corporation

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

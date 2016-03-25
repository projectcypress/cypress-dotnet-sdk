// Template: Client Proxy T4 Template (RAMLClient.t4) version 4.1

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RAML.Api.Core;
using Raml.Common;
using cypress_dotnet_sdk.Cypress.Models;

namespace cypress_dotnet_sdk.Cypress
{
    /// <summary>
    /// A vendor&apos;s products
    /// </summary>
    public partial class Products
    {
        private readonly CypressClient proxy;

        internal Products(CypressClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// A vendor&apos;s products. View a list of the vendor&apos;s products undergoing certification - Product
		/// </summary>
		/// <param name="id"></param>
        public virtual async Task<ApiResponse> Get(string id)
        {

            var url = "vendors/{id}/products";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// A vendor&apos;s products. View a list of the vendor&apos;s products undergoing certification - Product
		/// </summary>
		/// <param name="request">Models.ProductsGetRequest</param>
        public virtual async Task<ApiResponse> Get(Models.ProductsGetRequest request)
        {

            var url = "vendors/{id}/products";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// A vendor&apos;s products. Create a new product for this vendor - Product
		/// </summary>
		/// <param name="content"></param>
		/// <param name="id"></param>
        public virtual async Task<ApiResponse> Post(string content, string id)
        {

            var url = "vendors/{id}/products";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url);
            req.Content = new StringContent(content);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// A vendor&apos;s products. Create a new product for this vendor - Product
		/// </summary>
		/// <param name="request">Models.ProductsPostRequest</param>
        public virtual async Task<ApiResponse> Post(Models.ProductsPostRequest request)
        {

            var url = "vendors/{id}/products";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
            req.Content = request.Content;
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// Product undergoing certification testing. View information about a Product - Product
		/// </summary>
		/// <param name="id"></param>
        public virtual async Task<ApiResponse> GetById(int id)
        {

            var url = "vendors/{id}/products/{id}";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Product undergoing certification testing. View information about a Product - Product
		/// </summary>
		/// <param name="request">Models.ProductsGetByIdRequest</param>
        public virtual async Task<ApiResponse> GetById(Models.ProductsGetByIdRequest request)
        {

            var url = "vendors/{id}/products/{id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// Product undergoing certification testing. Delete a product - Product
		/// </summary>
		/// <param name="id"></param>
        public virtual async Task<ApiResponse> Delete(int id)
        {

            var url = "vendors/{id}/products/{id}";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Delete, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Product undergoing certification testing. Delete a product - Product
		/// </summary>
		/// <param name="request">Models.ProductsDeleteRequest</param>
        public virtual async Task<ApiResponse> Delete(Models.ProductsDeleteRequest request)
        {

            var url = "vendors/{id}/products/{id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Delete, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    /// <summary>
    /// A list of vendors undergoing certification
    /// </summary>
    public partial class Vendors
    {
        private readonly CypressClient proxy;

        internal Vendors(CypressClient proxy)
        {
            this.proxy = proxy;
        }

        public virtual Products Products
        {
            get { return new Products(proxy); }
        }


        /// <summary>
		/// A list of vendors undergoing certification. View a list of vendors - Vendors
		/// </summary>
        public virtual async Task<ApiResponse> Get()
        {

            var url = "vendors";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// A list of vendors undergoing certification. View a list of vendors - Vendors
		/// </summary>
		/// <param name="request">ApiRequest</param>
        public virtual async Task<ApiResponse> Get(ApiRequest request)
        {

            var url = "vendors";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// A list of vendors undergoing certification. Create a new vendor - Vendors
		/// </summary>
		/// <param name="content"></param>
        public virtual async Task<ApiResponse> Post(string content)
        {

            var url = "vendors";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url);
            req.Content = new StringContent(content);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// A list of vendors undergoing certification. Create a new vendor - Vendors
		/// </summary>
		/// <param name="request">Models.VendorsPostRequest</param>
        public virtual async Task<ApiResponse> Post(Models.VendorsPostRequest request)
        {

            var url = "vendors";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
            req.Content = request.Content;
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// A Vendor undergoing certification. View information about a vendor - Vendor
		/// </summary>
		/// <param name="id"></param>
        public virtual async Task<ApiResponse> GetById(string id)
        {

            var url = "vendors/{id}";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// A Vendor undergoing certification. View information about a vendor - Vendor
		/// </summary>
		/// <param name="request">Models.VendorsGetByIdRequest</param>
        public virtual async Task<ApiResponse> GetById(Models.VendorsGetByIdRequest request)
        {

            var url = "vendors/{id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// A Vendor undergoing certification. Update information about a vendor - Vendor
		/// </summary>
		/// <param name="content"></param>
		/// <param name="id"></param>
        public virtual async Task<ApiResponse> Put(string content, string id)
        {

            var url = "vendors/{id}";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Put, url);
            req.Content = new StringContent(content);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// A Vendor undergoing certification. Update information about a vendor - Vendor
		/// </summary>
		/// <param name="request">Models.VendorsPutRequest</param>
        public virtual async Task<ApiResponse> Put(Models.VendorsPutRequest request)
        {

            var url = "vendors/{id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Put, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
            req.Content = request.Content;
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// A Vendor undergoing certification. Delete a vendor - Vendor
		/// </summary>
		/// <param name="id"></param>
        public virtual async Task<ApiResponse> Delete(string id)
        {

            var url = "vendors/{id}";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Delete, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// A Vendor undergoing certification. Delete a vendor - Vendor
		/// </summary>
		/// <param name="request">Models.VendorsDeleteRequest</param>
        public virtual async Task<ApiResponse> Delete(Models.VendorsDeleteRequest request)
        {

            var url = "vendors/{id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Delete, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    public partial class ProductProductIdProductTests
    {
        private readonly CypressClient proxy;

        internal ProductProductIdProductTests(CypressClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// View list of a product&apos;s tests (One per measure for C1/C2, One for each C4 Filter) - Product Tests (Single Measure Testing and Filter Tests)
		/// </summary>
		/// <param name="product_id"></param>
        public virtual async Task<ApiResponse> Get(string product_id)
        {

            var url = "product/{product_id}/product_tests";
            url = url.Replace("{product_id}", product_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// View list of a product&apos;s tests (One per measure for C1/C2, One for each C4 Filter) - Product Tests (Single Measure Testing and Filter Tests)
		/// </summary>
		/// <param name="request">Models.ProductProductIdProductTestsGetRequest</param>
        public virtual async Task<ApiResponse> Get(Models.ProductProductIdProductTestsGetRequest request)
        {

            var url = "product/{product_id}/product_tests";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Product_id == null)
				throw new InvalidOperationException("Uri Parameter Product_id cannot be null");

            url = url.Replace("{product_id}", request.UriParameters.Product_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// View a product test (such as a Single Measure Test or a C4 Filter)
		/// </summary>
		/// <param name="id"></param>
		/// <param name="product_id"></param>
        public virtual async Task<ApiResponse> GetById(string id, string product_id)
        {

            var url = "product/{product_id}/product_tests/{id}";
            url = url.Replace("{id}", id.ToString());
            url = url.Replace("{product_id}", product_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// View a product test (such as a Single Measure Test or a C4 Filter)
		/// </summary>
		/// <param name="request">Models.ProductProductIdProductTestsGetByIdRequest</param>
        public virtual async Task<ApiResponse> GetById(Models.ProductProductIdProductTestsGetByIdRequest request)
        {

            var url = "product/{product_id}/product_tests/{id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

			if(request.UriParameters.Product_id == null)
				throw new InvalidOperationException("Uri Parameter Product_id cannot be null");

            url = url.Replace("{product_id}", request.UriParameters.Product_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    public partial class ProductTestsProductTestIdTasks
    {
        private readonly CypressClient proxy;

        internal ProductTestsProductTestIdTasks(CypressClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// List of testing tasks for a product ID
		/// </summary>
		/// <param name="product_test_id"></param>
        public virtual async Task<ApiResponse> Get(string product_test_id)
        {

            var url = "product_tests/{product_test_id}/tasks";
            url = url.Replace("{product_test_id}", product_test_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// List of testing tasks for a product ID
		/// </summary>
		/// <param name="request">Models.ProductTestsProductTestIdTasksGetRequest</param>
        public virtual async Task<ApiResponse> Get(Models.ProductTestsProductTestIdTasksGetRequest request)
        {

            var url = "product_tests/{product_test_id}/tasks";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Product_test_id == null)
				throw new InvalidOperationException("Uri Parameter Product_test_id cannot be null");

            url = url.Replace("{product_test_id}", request.UriParameters.Product_test_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// A single task for a product test such as a single C1 measure task or a Filter task
		/// </summary>
		/// <param name="id"></param>
		/// <param name="product_test_id"></param>
        public virtual async Task<ApiResponse> GetById(string id, string product_test_id)
        {

            var url = "product_tests/{product_test_id}/tasks/{id}";
            url = url.Replace("{id}", id.ToString());
            url = url.Replace("{product_test_id}", product_test_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// A single task for a product test such as a single C1 measure task or a Filter task
		/// </summary>
		/// <param name="request">Models.ProductTestsProductTestIdTasksGetByIdRequest</param>
        public virtual async Task<ApiResponse> GetById(Models.ProductTestsProductTestIdTasksGetByIdRequest request)
        {

            var url = "product_tests/{product_test_id}/tasks/{id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

			if(request.UriParameters.Product_test_id == null)
				throw new InvalidOperationException("Uri Parameter Product_test_id cannot be null");

            url = url.Replace("{product_test_id}", request.UriParameters.Product_test_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    public partial class TasksTaskIdTestExecutions
    {
        private readonly CypressClient proxy;

        internal TasksTaskIdTestExecutions(CypressClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// View a list of test executions - Task
		/// </summary>
		/// <param name="task_id"></param>
        public virtual async Task<ApiResponse> Get(string task_id)
        {

            var url = "tasks/{task_id}/test_executions";
            url = url.Replace("{task_id}", task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// View a list of test executions - Task
		/// </summary>
		/// <param name="request">Models.TasksTaskIdTestExecutionsGetRequest</param>
        public virtual async Task<ApiResponse> Get(Models.TasksTaskIdTestExecutionsGetRequest request)
        {

            var url = "tasks/{task_id}/test_executions";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Task_id == null)
				throw new InvalidOperationException("Uri Parameter Task_id cannot be null");

            url = url.Replace("{task_id}", request.UriParameters.Task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// Upload a new test artifact - Task
		/// </summary>
		/// <param name="content"></param>
		/// <param name="task_id"></param>
        public virtual async Task<ApiResponse> Post(string content, string task_id)
        {

            var url = "tasks/{task_id}/test_executions";
            url = url.Replace("{task_id}", task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url);
            req.Content = new StringContent(content);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Upload a new test artifact - Task
		/// </summary>
		/// <param name="request">Models.TasksTaskIdTestExecutionsPostRequest</param>
        public virtual async Task<ApiResponse> Post(Models.TasksTaskIdTestExecutionsPostRequest request)
        {

            var url = "tasks/{task_id}/test_executions";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Task_id == null)
				throw new InvalidOperationException("Uri Parameter Task_id cannot be null");

            url = url.Replace("{task_id}", request.UriParameters.Task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
            req.Content = request.Content;
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// View information about a test execution
		/// </summary>
		/// <param name="id"></param>
		/// <param name="task_id"></param>
        public virtual async Task<ApiResponse> GetById(string id, string task_id)
        {

            var url = "tasks/{task_id}/test_executions/{id}";
            url = url.Replace("{id}", id.ToString());
            url = url.Replace("{task_id}", task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// View information about a test execution
		/// </summary>
		/// <param name="request">Models.TasksTaskIdTestExecutionsGetByIdRequest</param>
        public virtual async Task<ApiResponse> GetById(Models.TasksTaskIdTestExecutionsGetByIdRequest request)
        {

            var url = "tasks/{task_id}/test_executions/{id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

			if(request.UriParameters.Task_id == null)
				throw new InvalidOperationException("Uri Parameter Task_id cannot be null");

            url = url.Replace("{task_id}", request.UriParameters.Task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// Delete a test execution
		/// </summary>
		/// <param name="id"></param>
		/// <param name="task_id"></param>
        public virtual async Task<ApiResponse> Delete(string id, string task_id)
        {

            var url = "tasks/{task_id}/test_executions/{id}";
            url = url.Replace("{id}", id.ToString());
            url = url.Replace("{task_id}", task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Delete, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Delete a test execution
		/// </summary>
		/// <param name="request">Models.TasksTaskIdTestExecutionsDeleteRequest</param>
        public virtual async Task<ApiResponse> Delete(Models.TasksTaskIdTestExecutionsDeleteRequest request)
        {

            var url = "tasks/{task_id}/test_executions/{id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

			if(request.UriParameters.Task_id == null)
				throw new InvalidOperationException("Uri Parameter Task_id cannot be null");

            url = url.Replace("{task_id}", request.UriParameters.Task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Delete, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    public partial class Measures
    {
        private readonly CypressClient proxy;

        internal Measures(CypressClient proxy)
        {
            this.proxy = proxy;
        }

    }

    public partial class Bundles
    {
        private readonly CypressClient proxy;

        internal Bundles(CypressClient proxy)
        {
            this.proxy = proxy;
        }

        public virtual Measures Measures
        {
            get { return new Measures(proxy); }
        }


        /// <summary>
		/// View a list of all installed bundles - Annual Updates Measure Bundle
		/// </summary>
        public virtual async Task<ApiResponse> Get()
        {

            var url = "bundles";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// View a list of all installed bundles - Annual Updates Measure Bundle
		/// </summary>
		/// <param name="request">ApiRequest</param>
        public virtual async Task<ApiResponse> Get(ApiRequest request)
        {

            var url = "bundles";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }


        /// <summary>
		/// View a list of all installed bundles - Annual Update Bundle
		/// </summary>
		/// <param name="id"></param>
        public virtual async Task<ApiResponse> GetById(string id)
        {

            var url = "bundles/{id}";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);

            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// View a list of all installed bundles - Annual Update Bundle
		/// </summary>
		/// <param name="request">Models.BundlesGetByIdRequest</param>
        public virtual async Task<ApiResponse> GetById(Models.BundlesGetByIdRequest request)
        {

            var url = "bundles/{id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Id == null)
				throw new InvalidOperationException("Uri Parameter Id cannot be null");

            url = url.Replace("{id}", request.UriParameters.Id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ApiResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    /// <summary>
    /// Main class for grouping root resources. Nested resources are defined as properties. The constructor can optionally receive an URL and HttpClient instance to override the default ones.
    /// </summary>
    public partial class CypressClient
    {

		public SchemaValidationSettings SchemaValidation { get; private set; } 

        protected readonly HttpClient client;
        public const string BaseUri = "https://{domain}/";

        internal HttpClient Client { get { return client; } }




        public CypressClient(string endpointUrl)
        {
            SchemaValidation = new SchemaValidationSettings
			{
				Enabled = true,
				RaiseExceptions = true
			};

			if(string.IsNullOrWhiteSpace(endpointUrl))
                throw new ArgumentException("You must specify the endpoint URL", "endpointUrl");

			if (endpointUrl.Contains("{"))
			{
				var regex = new Regex(@"\{([^\}]+)\}");
				var matches = regex.Matches(endpointUrl);
				var parameters = new List<string>();
				foreach (Match match in matches)
				{
					parameters.Add(match.Groups[1].Value);
				}
				throw new InvalidOperationException("Please replace parameter/s " + string.Join(", ", parameters) + " in the URL before passing it to the constructor ");
			}

            client = new HttpClient {BaseAddress = new Uri(endpointUrl)};
        }

        public CypressClient(HttpClient httpClient)
        {
            if(httpClient.BaseAddress == null)
                throw new InvalidOperationException("You must set the BaseAddress property of the HttpClient instance");

            client = httpClient;

			SchemaValidation = new SchemaValidationSettings
			{
				Enabled = true,
				RaiseExceptions = true
			};
        }

        

        public virtual Vendors Vendors
        {
            get { return new Vendors(this); }
        }
                

        public virtual ProductProductIdProductTests ProductProductIdProductTests
        {
            get { return new ProductProductIdProductTests(this); }
        }
                

        public virtual ProductTestsProductTestIdTasks ProductTestsProductTestIdTasks
        {
            get { return new ProductTestsProductTestIdTasks(this); }
        }
                

        public virtual TasksTaskIdTestExecutions TasksTaskIdTestExecutions
        {
            get { return new TasksTaskIdTestExecutions(this); }
        }
                

        public virtual Bundles Bundles
        {
            get { return new Bundles(this); }
        }
                


		public void AddDefaultRequestHeader(string name, string value)
		{
			client.DefaultRequestHeaders.Add(name, value);
		}

		public void AddDefaultRequestHeader(string name, IEnumerable<string> values)
		{
			client.DefaultRequestHeaders.Add(name, values);
		}


    }

} // end namespace









namespace cypress_dotnet_sdk.Cypress.Models
{
    /// <summary>
    /// Uri Parameters for resource /{id}
    /// </summary>
    public partial class  VendorsIdUriParameters 
    {

		[JsonProperty("id")]
        public string Id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /products
    /// </summary>
    public partial class  VendorsIdProductsUriParameters 
    {

		[JsonProperty("id")]
        public string Id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /{id}
    /// </summary>
    public partial class  VendorsIdProductsIdUriParameters 
    {

		[JsonProperty("id")]
        public int Id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /product/{product_id}/product_tests
    /// </summary>
    public partial class  ProductProductIdProductTestsUriParameters 
    {

		[JsonProperty("product_id")]
        public string Product_id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /{id}
    /// </summary>
    public partial class  ProductProductIdProductTestsIdUriParameters 
    {

		[JsonProperty("id")]
        public string Id { get; set; }


		[JsonProperty("product_id")]
        public string Product_id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /product_tests/{product_test_id}/tasks
    /// </summary>
    public partial class  ProductTestsProductTestIdTasksUriParameters 
    {

		[JsonProperty("product_test_id")]
        public string Product_test_id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /{id}
    /// </summary>
    public partial class  ProductTestsProductTestIdTasksIdUriParameters 
    {

		[JsonProperty("id")]
        public string Id { get; set; }


		[JsonProperty("product_test_id")]
        public string Product_test_id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /tasks/{task_id}/test_executions
    /// </summary>
    public partial class  TasksTaskIdTestExecutionsUriParameters 
    {

		[JsonProperty("task_id")]
        public string Task_id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /{id}
    /// </summary>
    public partial class  TasksTaskIdTestExecutionsIdUriParameters 
    {

		[JsonProperty("id")]
        public string Id { get; set; }


		[JsonProperty("task_id")]
        public string Task_id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /{id}
    /// </summary>
    public partial class  BundlesIdUriParameters 
    {

		[JsonProperty("id")]
        public string Id { get; set; }


    } // end class

    /// <summary>
    /// Request object for method Get of class Products
    /// </summary>
    public partial class ProductsGetRequest : ApiRequest
    {
        public ProductsGetRequest(VendorsIdProductsUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public VendorsIdProductsUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Post of class Products
    /// </summary>
    public partial class ProductsPostRequest : ApiRequest
    {
        public ProductsPostRequest(VendorsIdProductsUriParameters UriParameters, HttpContent Content = null, MediaTypeFormatter Formatter = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public HttpContent Content { get; set; }

        /// <summary>
        /// Request formatter
        /// </summary>
        public MediaTypeFormatter Formatter { get; set; }

        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public VendorsIdProductsUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method GetById of class Products
    /// </summary>
    public partial class ProductsGetByIdRequest : ApiRequest
    {
        public ProductsGetByIdRequest(VendorsIdProductsIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public VendorsIdProductsIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Delete of class Products
    /// </summary>
    public partial class ProductsDeleteRequest : ApiRequest
    {
        public ProductsDeleteRequest(VendorsIdProductsIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public VendorsIdProductsIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Post of class Vendors
    /// </summary>
    public partial class VendorsPostRequest : ApiRequest
    {
        public VendorsPostRequest(HttpContent Content = null, MediaTypeFormatter Formatter = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public HttpContent Content { get; set; }

        /// <summary>
        /// Request formatter
        /// </summary>
        public MediaTypeFormatter Formatter { get; set; }

    } // end class

    /// <summary>
    /// Request object for method GetById of class Vendors
    /// </summary>
    public partial class VendorsGetByIdRequest : ApiRequest
    {
        public VendorsGetByIdRequest(VendorsIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public VendorsIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Put of class Vendors
    /// </summary>
    public partial class VendorsPutRequest : ApiRequest
    {
        public VendorsPutRequest(VendorsIdUriParameters UriParameters, HttpContent Content = null, MediaTypeFormatter Formatter = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public HttpContent Content { get; set; }

        /// <summary>
        /// Request formatter
        /// </summary>
        public MediaTypeFormatter Formatter { get; set; }

        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public VendorsIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Delete of class Vendors
    /// </summary>
    public partial class VendorsDeleteRequest : ApiRequest
    {
        public VendorsDeleteRequest(VendorsIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public VendorsIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Get of class ProductProductIdProductTests
    /// </summary>
    public partial class ProductProductIdProductTestsGetRequest : ApiRequest
    {
        public ProductProductIdProductTestsGetRequest(ProductProductIdProductTestsUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public ProductProductIdProductTestsUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method GetById of class ProductProductIdProductTests
    /// </summary>
    public partial class ProductProductIdProductTestsGetByIdRequest : ApiRequest
    {
        public ProductProductIdProductTestsGetByIdRequest(ProductProductIdProductTestsIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public ProductProductIdProductTestsIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Get of class ProductTestsProductTestIdTasks
    /// </summary>
    public partial class ProductTestsProductTestIdTasksGetRequest : ApiRequest
    {
        public ProductTestsProductTestIdTasksGetRequest(ProductTestsProductTestIdTasksUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public ProductTestsProductTestIdTasksUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method GetById of class ProductTestsProductTestIdTasks
    /// </summary>
    public partial class ProductTestsProductTestIdTasksGetByIdRequest : ApiRequest
    {
        public ProductTestsProductTestIdTasksGetByIdRequest(ProductTestsProductTestIdTasksIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public ProductTestsProductTestIdTasksIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Get of class TasksTaskIdTestExecutions
    /// </summary>
    public partial class TasksTaskIdTestExecutionsGetRequest : ApiRequest
    {
        public TasksTaskIdTestExecutionsGetRequest(TasksTaskIdTestExecutionsUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public TasksTaskIdTestExecutionsUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Post of class TasksTaskIdTestExecutions
    /// </summary>
    public partial class TasksTaskIdTestExecutionsPostRequest : ApiRequest
    {
        public TasksTaskIdTestExecutionsPostRequest(TasksTaskIdTestExecutionsUriParameters UriParameters, HttpContent Content = null, MediaTypeFormatter Formatter = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public HttpContent Content { get; set; }

        /// <summary>
        /// Request formatter
        /// </summary>
        public MediaTypeFormatter Formatter { get; set; }

        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public TasksTaskIdTestExecutionsUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method GetById of class TasksTaskIdTestExecutions
    /// </summary>
    public partial class TasksTaskIdTestExecutionsGetByIdRequest : ApiRequest
    {
        public TasksTaskIdTestExecutionsGetByIdRequest(TasksTaskIdTestExecutionsIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public TasksTaskIdTestExecutionsIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Delete of class TasksTaskIdTestExecutions
    /// </summary>
    public partial class TasksTaskIdTestExecutionsDeleteRequest : ApiRequest
    {
        public TasksTaskIdTestExecutionsDeleteRequest(TasksTaskIdTestExecutionsIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public TasksTaskIdTestExecutionsIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method GetById of class Bundles
    /// </summary>
    public partial class BundlesGetByIdRequest : ApiRequest
    {
        public BundlesGetByIdRequest(BundlesIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public BundlesIdUriParameters UriParameters { get; set; }

    } // end class


} // end Models namespace

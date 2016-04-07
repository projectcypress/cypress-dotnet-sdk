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
        public virtual async Task<Models.ProductsGetResponse> Get(string id)
        {

            var url = "vendors/{id}/products";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Products\",	\"id\": \"http://cypress.healthit.gov/schemas/products.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"version\": {				\"type\": \"string\"			},			\"description\": {				\"type\": \"string\"			},			\"bundle_id\": {				\"type\": \"string\"			},			\"c1_test\": {				\"type\": \"boolean\"			},			\"c2_test\": {				\"type\": \"boolean\"			},			\"c3_test\": {				\"type\": \"boolean\"			},			\"c4_test\": {				\"type\": \"boolean\"			},			\"randomize_records\": {				\"type\": \"boolean\"			},			\"duplicate_records\": {				\"type\": \"boolean\"			},			\"measure_ids\": {				\"type\": \"array\"			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/vendors/{vendor_id}/products/{id}\"		},		{			\"rel\": \"product_tests\",			\"href\": \"/products/{id}/product_tests\"		},		{			\"rel\": \"patients\",			\"href\": \"/vendors/{vendor_id}/products/{id}/patients\"		}]	}}", response.Content);
				}
					
			}

            return new Models.ProductsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Products\",	\"id\": \"http://cypress.healthit.gov/schemas/products.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"version\": {				\"type\": \"string\"			},			\"description\": {				\"type\": \"string\"			},			\"bundle_id\": {				\"type\": \"string\"			},			\"c1_test\": {				\"type\": \"boolean\"			},			\"c2_test\": {				\"type\": \"boolean\"			},			\"c3_test\": {				\"type\": \"boolean\"			},			\"c4_test\": {				\"type\": \"boolean\"			},			\"randomize_records\": {				\"type\": \"boolean\"			},			\"duplicate_records\": {				\"type\": \"boolean\"			},			\"measure_ids\": {				\"type\": \"array\"			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/vendors/{vendor_id}/products/{id}\"		},		{			\"rel\": \"product_tests\",			\"href\": \"/products/{id}/product_tests\"		},		{			\"rel\": \"patients\",			\"href\": \"/vendors/{vendor_id}/products/{id}/patients\"		}]	}}", response.Content), true)
                                            };

        }

        /// <summary>
		/// A vendor&apos;s products. View a list of the vendor&apos;s products undergoing certification - Product
		/// </summary>
		/// <param name="request">Models.ProductsGetRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.ProductsGetResponse> Get(Models.ProductsGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Products\",	\"id\": \"http://cypress.healthit.gov/schemas/products.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"version\": {				\"type\": \"string\"			},			\"description\": {				\"type\": \"string\"			},			\"bundle_id\": {				\"type\": \"string\"			},			\"c1_test\": {				\"type\": \"boolean\"			},			\"c2_test\": {				\"type\": \"boolean\"			},			\"c3_test\": {				\"type\": \"boolean\"			},			\"c4_test\": {				\"type\": \"boolean\"			},			\"randomize_records\": {				\"type\": \"boolean\"			},			\"duplicate_records\": {				\"type\": \"boolean\"			},			\"measure_ids\": {				\"type\": \"array\"			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/vendors/{vendor_id}/products/{id}\"		},		{			\"rel\": \"product_tests\",			\"href\": \"/products/{id}/product_tests\"		},		{			\"rel\": \"patients\",			\"href\": \"/vendors/{vendor_id}/products/{id}/patients\"		}]	}}", response.Content);
				}
				
            }
            return new Models.ProductsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Products\",	\"id\": \"http://cypress.healthit.gov/schemas/products.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"version\": {				\"type\": \"string\"			},			\"description\": {				\"type\": \"string\"			},			\"bundle_id\": {				\"type\": \"string\"			},			\"c1_test\": {				\"type\": \"boolean\"			},			\"c2_test\": {				\"type\": \"boolean\"			},			\"c3_test\": {				\"type\": \"boolean\"			},			\"c4_test\": {				\"type\": \"boolean\"			},			\"randomize_records\": {				\"type\": \"boolean\"			},			\"duplicate_records\": {				\"type\": \"boolean\"			},			\"measure_ids\": {				\"type\": \"array\"			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/vendors/{vendor_id}/products/{id}\"		},		{			\"rel\": \"product_tests\",			\"href\": \"/products/{id}/product_tests\"		},		{			\"rel\": \"patients\",			\"href\": \"/vendors/{vendor_id}/products/{id}/patients\"		}]	}}", response.Content), true)
                                            };
        }


        /// <summary>
		/// A vendor&apos;s products. Create a new product for this vendor - Product
		/// </summary>
		/// <param name="vendorsidproductspostrequestcontent"></param>
		/// <param name="id"></param>
        public virtual async Task<Models.ProductsPostResponse> Post(Models.VendorsIdProductsPostRequestContent vendorsidproductspostrequestcontent, string id)
        {

            var url = "vendors/{id}/products";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url);
            req.Content = new ObjectContent(typeof(Models.VendorsIdProductsPostRequestContent), vendorsidproductspostrequestcontent, new JsonMediaTypeFormatter());                           
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content);
				}
					
			}

            return new Models.ProductsPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content), true)
                                            };

        }

        /// <summary>
		/// A vendor&apos;s products. Create a new product for this vendor - Product
		/// </summary>
		/// <param name="request">Models.ProductsPostRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.ProductsPostResponse> Post(Models.ProductsPostRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
            if(request.Formatter == null)
                request.Formatter = new JsonMediaTypeFormatter();
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content);
				}
				
            }
            return new Models.ProductsPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content), true)
                                            };
        }


        /// <summary>
		/// Product undergoing certification testing. View information about a Product - Product
		/// </summary>
		/// <param name="product_id"></param>
		/// <param name="id"></param>
        public virtual async Task<Models.ProductsGetByProductIdResponse> GetByProductId(string product_id, string id)
        {

            var url = "vendors/{id}/products/{product_id}";
            url = url.Replace("{product_id}", product_id.ToString());
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Product\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"name\": {			\"type\": \"string\"		},		\"version\": {			\"type\": \"string\"		},		\"description\": {			\"type\": \"string\"		},		\"bundle_id\": {			\"type\": \"string\"		},		\"c1_test\": {			\"type\": \"boolean\"		},		\"c2_test\": {			\"type\": \"boolean\"		},		\"c3_test\": {			\"type\": \"boolean\"		},		\"c4_test\": {			\"type\": \"boolean\"		},		\"randomize_records\": {			\"type\": \"boolean\"		},		\"duplicate_records\": {			\"type\": \"boolean\"		},		\"measure_ids\": {			\"type\": \"array\"		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/vendors/{vendor_id}/products/{id}\"	},	{		\"rel\": \"product_tests\",		\"href\": \"/products/{id}/product_tests\"	},	{		\"rel\": \"patients\",		\"href\": \"/vendors/{vendor_id}/products/{id}/patients\"	}]}", response.Content);
				}
					
			}

            return new Models.ProductsGetByProductIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Product\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"name\": {			\"type\": \"string\"		},		\"version\": {			\"type\": \"string\"		},		\"description\": {			\"type\": \"string\"		},		\"bundle_id\": {			\"type\": \"string\"		},		\"c1_test\": {			\"type\": \"boolean\"		},		\"c2_test\": {			\"type\": \"boolean\"		},		\"c3_test\": {			\"type\": \"boolean\"		},		\"c4_test\": {			\"type\": \"boolean\"		},		\"randomize_records\": {			\"type\": \"boolean\"		},		\"duplicate_records\": {			\"type\": \"boolean\"		},		\"measure_ids\": {			\"type\": \"array\"		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/vendors/{vendor_id}/products/{id}\"	},	{		\"rel\": \"product_tests\",		\"href\": \"/products/{id}/product_tests\"	},	{		\"rel\": \"patients\",		\"href\": \"/vendors/{vendor_id}/products/{id}/patients\"	}]}", response.Content), true)
                                            };

        }

        /// <summary>
		/// Product undergoing certification testing. View information about a Product - Product
		/// </summary>
		/// <param name="request">Models.ProductsGetByProductIdRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.ProductsGetByProductIdResponse> GetByProductId(Models.ProductsGetByProductIdRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "vendors/{id}/products/{product_id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Product_id == null)
				throw new InvalidOperationException("Uri Parameter Product_id cannot be null");

            url = url.Replace("{product_id}", request.UriParameters.Product_id.ToString());

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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Product\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"name\": {			\"type\": \"string\"		},		\"version\": {			\"type\": \"string\"		},		\"description\": {			\"type\": \"string\"		},		\"bundle_id\": {			\"type\": \"string\"		},		\"c1_test\": {			\"type\": \"boolean\"		},		\"c2_test\": {			\"type\": \"boolean\"		},		\"c3_test\": {			\"type\": \"boolean\"		},		\"c4_test\": {			\"type\": \"boolean\"		},		\"randomize_records\": {			\"type\": \"boolean\"		},		\"duplicate_records\": {			\"type\": \"boolean\"		},		\"measure_ids\": {			\"type\": \"array\"		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/vendors/{vendor_id}/products/{id}\"	},	{		\"rel\": \"product_tests\",		\"href\": \"/products/{id}/product_tests\"	},	{		\"rel\": \"patients\",		\"href\": \"/vendors/{vendor_id}/products/{id}/patients\"	}]}", response.Content);
				}
				
            }
            return new Models.ProductsGetByProductIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Product\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"name\": {			\"type\": \"string\"		},		\"version\": {			\"type\": \"string\"		},		\"description\": {			\"type\": \"string\"		},		\"bundle_id\": {			\"type\": \"string\"		},		\"c1_test\": {			\"type\": \"boolean\"		},		\"c2_test\": {			\"type\": \"boolean\"		},		\"c3_test\": {			\"type\": \"boolean\"		},		\"c4_test\": {			\"type\": \"boolean\"		},		\"randomize_records\": {			\"type\": \"boolean\"		},		\"duplicate_records\": {			\"type\": \"boolean\"		},		\"measure_ids\": {			\"type\": \"array\"		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/vendors/{vendor_id}/products/{id}\"	},	{		\"rel\": \"product_tests\",		\"href\": \"/products/{id}/product_tests\"	},	{		\"rel\": \"patients\",		\"href\": \"/vendors/{vendor_id}/products/{id}/patients\"	}]}", response.Content), true)
                                            };
        }


        /// <summary>
		/// Product undergoing certification testing. Delete a product - Product
		/// </summary>
		/// <param name="product_id"></param>
		/// <param name="id"></param>
        public virtual async Task<ApiResponse> Delete(string product_id, string id)
        {

            var url = "vendors/{id}/products/{product_id}";
            url = url.Replace("{product_id}", product_id.ToString());
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

            var url = "vendors/{id}/products/{product_id}";
			if(request.UriParameters == null)
				throw new InvalidOperationException("Uri Parameters cannot be null");               

			if(request.UriParameters.Product_id == null)
				throw new InvalidOperationException("Uri Parameter Product_id cannot be null");

            url = url.Replace("{product_id}", request.UriParameters.Product_id.ToString());

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
        public virtual async Task<Models.VendorsGetResponse> Get()
        {

            var url = "vendors";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Vendors\",	\"id\": \"http://cypress.healthit.gov/schemas/vendors.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"vendor_id\": {				\"type\": \"string\"			},			\"name\": {				\"type\": \"string\"			},			\"url\": {				\"type\": \"string\"			},			\"address\": {				\"type\": \"string\"			},			\"zip\": {				\"type\": \"string\"			},			\"state\": {				\"type\": \"string\"			},			\"points_of_contact\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"name\": {							\"type\": \"string\"						},						\"email\": {							\"type\": \"string\"						},						\"phone\": {							\"type\": \"string\"						},						\"contact_type\": {							\"type\": \"string\"						}					}				}			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/vendors/{id}\"		},		{			\"rel\": \"products\",			\"href\": \"/vendors/{id}/products\"		}]	}}", response.Content);
				}
					
			}

            return new Models.VendorsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Vendors\",	\"id\": \"http://cypress.healthit.gov/schemas/vendors.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"vendor_id\": {				\"type\": \"string\"			},			\"name\": {				\"type\": \"string\"			},			\"url\": {				\"type\": \"string\"			},			\"address\": {				\"type\": \"string\"			},			\"zip\": {				\"type\": \"string\"			},			\"state\": {				\"type\": \"string\"			},			\"points_of_contact\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"name\": {							\"type\": \"string\"						},						\"email\": {							\"type\": \"string\"						},						\"phone\": {							\"type\": \"string\"						},						\"contact_type\": {							\"type\": \"string\"						}					}				}			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/vendors/{id}\"		},		{			\"rel\": \"products\",			\"href\": \"/vendors/{id}/products\"		}]	}}", response.Content), true)
                                            };

        }

        /// <summary>
		/// A list of vendors undergoing certification. View a list of vendors - Vendors
		/// </summary>
		/// <param name="request">ApiRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.VendorsGetResponse> Get(ApiRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Vendors\",	\"id\": \"http://cypress.healthit.gov/schemas/vendors.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"vendor_id\": {				\"type\": \"string\"			},			\"name\": {				\"type\": \"string\"			},			\"url\": {				\"type\": \"string\"			},			\"address\": {				\"type\": \"string\"			},			\"zip\": {				\"type\": \"string\"			},			\"state\": {				\"type\": \"string\"			},			\"points_of_contact\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"name\": {							\"type\": \"string\"						},						\"email\": {							\"type\": \"string\"						},						\"phone\": {							\"type\": \"string\"						},						\"contact_type\": {							\"type\": \"string\"						}					}				}			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/vendors/{id}\"		},		{			\"rel\": \"products\",			\"href\": \"/vendors/{id}/products\"		}]	}}", response.Content);
				}
				
            }
            return new Models.VendorsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Vendors\",	\"id\": \"http://cypress.healthit.gov/schemas/vendors.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"vendor_id\": {				\"type\": \"string\"			},			\"name\": {				\"type\": \"string\"			},			\"url\": {				\"type\": \"string\"			},			\"address\": {				\"type\": \"string\"			},			\"zip\": {				\"type\": \"string\"			},			\"state\": {				\"type\": \"string\"			},			\"points_of_contact\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"name\": {							\"type\": \"string\"						},						\"email\": {							\"type\": \"string\"						},						\"phone\": {							\"type\": \"string\"						},						\"contact_type\": {							\"type\": \"string\"						}					}				}			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/vendors/{id}\"		},		{			\"rel\": \"products\",			\"href\": \"/vendors/{id}/products\"		}]	}}", response.Content), true)
                                            };
        }


        /// <summary>
		/// A list of vendors undergoing certification. Create a new vendor - Vendors
		/// </summary>
		/// <param name="vendorspostrequestcontent"></param>
        public virtual async Task<Models.VendorsPostResponse> Post(Models.VendorsPostRequestContent vendorspostrequestcontent)
        {

            var url = "vendors";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url);
            req.Content = new ObjectContent(typeof(Models.VendorsPostRequestContent), vendorspostrequestcontent, new JsonMediaTypeFormatter());                           
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content);
				}
					
			}

            return new Models.VendorsPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content), true)
                                            };

        }

        /// <summary>
		/// A list of vendors undergoing certification. Create a new vendor - Vendors
		/// </summary>
		/// <param name="request">Models.VendorsPostRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.VendorsPostResponse> Post(Models.VendorsPostRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
            if(request.Formatter == null)
                request.Formatter = new JsonMediaTypeFormatter();
	        var response = await proxy.Client.SendAsync(req);
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content);
				}
				
            }
            return new Models.VendorsPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content), true)
                                            };
        }


        /// <summary>
		/// A Vendor undergoing certification. View information about a vendor - Vendor
		/// </summary>
		/// <param name="id"></param>
        public virtual async Task<Models.VendorsGetByIdResponse> GetById(string id)
        {

            var url = "vendors/{id}";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Vendor\",	\"id\": \"http://cypress.healthit.gov/schemas/vendor.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"vendor_id\": {			\"type\": \"string\"		},		\"name\": {			\"type\": \"string\"		},		\"url\": {			\"type\": \"string\"		},		\"address\": {			\"type\": \"string\"		},		\"zip\": {			\"type\": \"string\"		},		\"state\": {			\"type\": \"string\"		},		\"points_of_contact\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"name\": {						\"type\": \"string\"					},					\"email\": {						\"type\": \"string\"					},					\"phone\": {						\"type\": \"string\"					},					\"contact_type\": {						\"type\": \"string\"					}				}			}		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/vendors/{id}\"	},	{		\"rel\": \"products\",		\"href\": \"/vendors/{id}/products\"	}]}", response.Content);
				}
					
			}

            return new Models.VendorsGetByIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Vendor\",	\"id\": \"http://cypress.healthit.gov/schemas/vendor.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"vendor_id\": {			\"type\": \"string\"		},		\"name\": {			\"type\": \"string\"		},		\"url\": {			\"type\": \"string\"		},		\"address\": {			\"type\": \"string\"		},		\"zip\": {			\"type\": \"string\"		},		\"state\": {			\"type\": \"string\"		},		\"points_of_contact\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"name\": {						\"type\": \"string\"					},					\"email\": {						\"type\": \"string\"					},					\"phone\": {						\"type\": \"string\"					},					\"contact_type\": {						\"type\": \"string\"					}				}			}		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/vendors/{id}\"	},	{		\"rel\": \"products\",		\"href\": \"/vendors/{id}/products\"	}]}", response.Content), true)
                                            };

        }

        /// <summary>
		/// A Vendor undergoing certification. View information about a vendor - Vendor
		/// </summary>
		/// <param name="request">Models.VendorsGetByIdRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.VendorsGetByIdResponse> GetById(Models.VendorsGetByIdRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Vendor\",	\"id\": \"http://cypress.healthit.gov/schemas/vendor.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"vendor_id\": {			\"type\": \"string\"		},		\"name\": {			\"type\": \"string\"		},		\"url\": {			\"type\": \"string\"		},		\"address\": {			\"type\": \"string\"		},		\"zip\": {			\"type\": \"string\"		},		\"state\": {			\"type\": \"string\"		},		\"points_of_contact\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"name\": {						\"type\": \"string\"					},					\"email\": {						\"type\": \"string\"					},					\"phone\": {						\"type\": \"string\"					},					\"contact_type\": {						\"type\": \"string\"					}				}			}		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/vendors/{id}\"	},	{		\"rel\": \"products\",		\"href\": \"/vendors/{id}/products\"	}]}", response.Content);
				}
				
            }
            return new Models.VendorsGetByIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Vendor\",	\"id\": \"http://cypress.healthit.gov/schemas/vendor.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"vendor_id\": {			\"type\": \"string\"		},		\"name\": {			\"type\": \"string\"		},		\"url\": {			\"type\": \"string\"		},		\"address\": {			\"type\": \"string\"		},		\"zip\": {			\"type\": \"string\"		},		\"state\": {			\"type\": \"string\"		},		\"points_of_contact\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"name\": {						\"type\": \"string\"					},					\"email\": {						\"type\": \"string\"					},					\"phone\": {						\"type\": \"string\"					},					\"contact_type\": {						\"type\": \"string\"					}				}			}		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/vendors/{id}\"	},	{		\"rel\": \"products\",		\"href\": \"/vendors/{id}/products\"	}]}", response.Content), true)
                                            };
        }


        /// <summary>
		/// A Vendor undergoing certification. Update information about a vendor - Vendor
		/// </summary>
		/// <param name="vendorsidputrequestcontent"></param>
		/// <param name="id"></param>
        public virtual async Task<ApiResponse> Put(Models.VendorsIdPutRequestContent vendorsidputrequestcontent, string id)
        {

            var url = "vendors/{id}";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Put, url);
            req.Content = new ObjectContent(typeof(Models.VendorsIdPutRequestContent), vendorsidputrequestcontent, new JsonMediaTypeFormatter());                           
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
            if(request.Formatter == null)
                request.Formatter = new JsonMediaTypeFormatter();
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

    public partial class ProductsProductIdProductTests
    {
        private readonly CypressClient proxy;

        internal ProductsProductIdProductTests(CypressClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// View list of a product&apos;s tests (One per measure for C1/C2, One for each C4 Filter) - Product Tests (Single Measure Testing and Filter Tests)
		/// </summary>
		/// <param name="product_id"></param>
        public virtual async Task<Models.ProductsProductIdProductTestsGetResponse> Get(string product_id)
        {

            var url = "products/{product_id}/product_tests";
            url = url.Replace("{product_id}", product_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Product Tests\",	\"id\": \"http://cypress.healthit.gov/schemas/product_tests.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"cms_id\": {				\"type\": \"string\"			},			\"measure_id\": {				\"type\": \"string\"			},			\"type\": {				\"type\": \"string\"			},			\"state\": {				\"type\": \"string\"			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		}	}}", response.Content);
				}
					
			}

            return new Models.ProductsProductIdProductTestsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Product Tests\",	\"id\": \"http://cypress.healthit.gov/schemas/product_tests.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"cms_id\": {				\"type\": \"string\"			},			\"measure_id\": {				\"type\": \"string\"			},			\"type\": {				\"type\": \"string\"			},			\"state\": {				\"type\": \"string\"			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		}	}}", response.Content), true)
                                            };

        }

        /// <summary>
		/// View list of a product&apos;s tests (One per measure for C1/C2, One for each C4 Filter) - Product Tests (Single Measure Testing and Filter Tests)
		/// </summary>
		/// <param name="request">Models.ProductsProductIdProductTestsGetRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.ProductsProductIdProductTestsGetResponse> Get(Models.ProductsProductIdProductTestsGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "products/{product_id}/product_tests";
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Product Tests\",	\"id\": \"http://cypress.healthit.gov/schemas/product_tests.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"cms_id\": {				\"type\": \"string\"			},			\"measure_id\": {				\"type\": \"string\"			},			\"type\": {				\"type\": \"string\"			},			\"state\": {				\"type\": \"string\"			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		}	}}", response.Content);
				}
				
            }
            return new Models.ProductsProductIdProductTestsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Product Tests\",	\"id\": \"http://cypress.healthit.gov/schemas/product_tests.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"cms_id\": {				\"type\": \"string\"			},			\"measure_id\": {				\"type\": \"string\"			},			\"type\": {				\"type\": \"string\"			},			\"state\": {				\"type\": \"string\"			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"updated_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		}	}}", response.Content), true)
                                            };
        }


        /// <summary>
		/// View a product test (such as a Single Measure Test or a C4 Filter)
		/// </summary>
		/// <param name="id"></param>
		/// <param name="product_id"></param>
        public virtual async Task<Models.ProductsProductIdProductTestsGetByIdResponse> GetById(string id, string product_id)
        {

            var url = "products/{product_id}/product_tests/{id}";
            url = url.Replace("{id}", id.ToString());
            url = url.Replace("{product_id}", product_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Product Test\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"name\": {			\"type\": \"string\"		},		\"cms_id\": {			\"type\": \"string\"		},		\"measure_id\": {			\"type\": \"string\"		},		\"type\": {			\"type\": \"string\"		},		\"state\": {			\"type\": \"string\"		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/products/{product_id}/product_tests/{id}\"	},	{		\"rel\": \"tasks\",		\"href\": \"/product_tests/{id}/tasks\"	},	{		\"rel\": \"patients\",		\"href\": \"/product_tests/{id}/patients\"	}]}", response.Content);
				}
					
			}

            return new Models.ProductsProductIdProductTestsGetByIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Product Test\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"name\": {			\"type\": \"string\"		},		\"cms_id\": {			\"type\": \"string\"		},		\"measure_id\": {			\"type\": \"string\"		},		\"type\": {			\"type\": \"string\"		},		\"state\": {			\"type\": \"string\"		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/products/{product_id}/product_tests/{id}\"	},	{		\"rel\": \"tasks\",		\"href\": \"/product_tests/{id}/tasks\"	},	{		\"rel\": \"patients\",		\"href\": \"/product_tests/{id}/patients\"	}]}", response.Content), true)
                                            };

        }

        /// <summary>
		/// View a product test (such as a Single Measure Test or a C4 Filter)
		/// </summary>
		/// <param name="request">Models.ProductsProductIdProductTestsGetByIdRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.ProductsProductIdProductTestsGetByIdResponse> GetById(Models.ProductsProductIdProductTestsGetByIdRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "products/{product_id}/product_tests/{id}";
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Product Test\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"name\": {			\"type\": \"string\"		},		\"cms_id\": {			\"type\": \"string\"		},		\"measure_id\": {			\"type\": \"string\"		},		\"type\": {			\"type\": \"string\"		},		\"state\": {			\"type\": \"string\"		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/products/{product_id}/product_tests/{id}\"	},	{		\"rel\": \"tasks\",		\"href\": \"/product_tests/{id}/tasks\"	},	{		\"rel\": \"patients\",		\"href\": \"/product_tests/{id}/patients\"	}]}", response.Content);
				}
				
            }
            return new Models.ProductsProductIdProductTestsGetByIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Product Test\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"name\": {			\"type\": \"string\"		},		\"cms_id\": {			\"type\": \"string\"		},		\"measure_id\": {			\"type\": \"string\"		},		\"type\": {			\"type\": \"string\"		},		\"state\": {			\"type\": \"string\"		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"updated_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/products/{product_id}/product_tests/{id}\"	},	{		\"rel\": \"tasks\",		\"href\": \"/product_tests/{id}/tasks\"	},	{		\"rel\": \"patients\",		\"href\": \"/product_tests/{id}/patients\"	}]}", response.Content), true)
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
        public virtual async Task<Models.ProductTestsProductTestIdTasksGetResponse> Get(string product_test_id)
        {

            var url = "product_tests/{product_test_id}/tasks";
            url = url.Replace("{product_test_id}", product_test_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Tasks\",	\"id\": \"http://cypress.healthit.gov/schemas/tasks.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"type\": {				\"type\": \"string\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/product_tests/{product_test_id}/tasks/{id}\"		},		{			\"rel\": \"executions\",			\"href\": \"/tasks/{task_id}/test_executions\"		}]	}}", response.Content);
				}
					
			}

            return new Models.ProductTestsProductTestIdTasksGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Tasks\",	\"id\": \"http://cypress.healthit.gov/schemas/tasks.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"type\": {				\"type\": \"string\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/product_tests/{product_test_id}/tasks/{id}\"		},		{			\"rel\": \"executions\",			\"href\": \"/tasks/{task_id}/test_executions\"		}]	}}", response.Content), true)
                                            };

        }

        /// <summary>
		/// List of testing tasks for a product ID
		/// </summary>
		/// <param name="request">Models.ProductTestsProductTestIdTasksGetRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.ProductTestsProductTestIdTasksGetResponse> Get(Models.ProductTestsProductTestIdTasksGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Tasks\",	\"id\": \"http://cypress.healthit.gov/schemas/tasks.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"type\": {				\"type\": \"string\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/product_tests/{product_test_id}/tasks/{id}\"		},		{			\"rel\": \"executions\",			\"href\": \"/tasks/{task_id}/test_executions\"		}]	}}", response.Content);
				}
				
            }
            return new Models.ProductTestsProductTestIdTasksGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Tasks\",	\"id\": \"http://cypress.healthit.gov/schemas/tasks.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"type\": {				\"type\": \"string\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/product_tests/{product_test_id}/tasks/{id}\"		},		{			\"rel\": \"executions\",			\"href\": \"/tasks/{task_id}/test_executions\"		}]	}}", response.Content), true)
                                            };
        }


        /// <summary>
		/// A single task for a product test such as a single C1 measure task or a Filter task
		/// </summary>
		/// <param name="id"></param>
		/// <param name="product_test_id"></param>
        public virtual async Task<Models.ProductTestsProductTestIdTasksGetByIdResponse> GetById(string id, string product_test_id)
        {

            var url = "product_tests/{product_test_id}/tasks/{id}";
            url = url.Replace("{id}", id.ToString());
            url = url.Replace("{product_test_id}", product_test_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Task\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"type\": {			\"type\": \"string\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/product_tests/{product_test_id}/tasks/{id}\"	},	{		\"rel\": \"executions\",		\"href\": \"/tasks/{task_id}/test_executions\"	}]}", response.Content);
				}
					
			}

            return new Models.ProductTestsProductTestIdTasksGetByIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Task\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"type\": {			\"type\": \"string\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/product_tests/{product_test_id}/tasks/{id}\"	},	{		\"rel\": \"executions\",		\"href\": \"/tasks/{task_id}/test_executions\"	}]}", response.Content), true)
                                            };

        }

        /// <summary>
		/// A single task for a product test such as a single C1 measure task or a Filter task
		/// </summary>
		/// <param name="request">Models.ProductTestsProductTestIdTasksGetByIdRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.ProductTestsProductTestIdTasksGetByIdResponse> GetById(Models.ProductTestsProductTestIdTasksGetByIdRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Task\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"type\": {			\"type\": \"string\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/product_tests/{product_test_id}/tasks/{id}\"	},	{		\"rel\": \"executions\",		\"href\": \"/tasks/{task_id}/test_executions\"	}]}", response.Content);
				}
				
            }
            return new Models.ProductTestsProductTestIdTasksGetByIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Task\",	\"id\": \"http://cypress.healthit.gov/schemas/product.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"type\": {			\"type\": \"string\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/product_tests/{product_test_id}/tasks/{id}\"	},	{		\"rel\": \"executions\",		\"href\": \"/tasks/{task_id}/test_executions\"	}]}", response.Content), true)
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
        public virtual async Task<Models.TasksTaskIdTestExecutionsGetResponse> Get(string task_id)
        {

            var url = "tasks/{task_id}/test_executions";
            url = url.Replace("{task_id}", task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Test Executions\",	\"id\": \"http://cypress.healthit.gov/schemas/test_executions.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"state\": {				\"type\": \"string\"			},			\"execution_errors\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"message\": {							\"type\": \"string\"						},						\"msg_type\": {							\"type\": \"string\"						},						\"file_name\": {							\"type\": \"string\"						},						\"location\": {							\"type\": \"string\"						},						\"validator\": {							\"type\": \"string\"						}					}				}			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/tasks{task_id}/test_executions/{id}\"		}]	}}", response.Content);
				}
					
			}

            return new Models.TasksTaskIdTestExecutionsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Test Executions\",	\"id\": \"http://cypress.healthit.gov/schemas/test_executions.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"state\": {				\"type\": \"string\"			},			\"execution_errors\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"message\": {							\"type\": \"string\"						},						\"msg_type\": {							\"type\": \"string\"						},						\"file_name\": {							\"type\": \"string\"						},						\"location\": {							\"type\": \"string\"						},						\"validator\": {							\"type\": \"string\"						}					}				}			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/tasks{task_id}/test_executions/{id}\"		}]	}}", response.Content), true)
                                            };

        }

        /// <summary>
		/// View a list of test executions - Task
		/// </summary>
		/// <param name="request">Models.TasksTaskIdTestExecutionsGetRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.TasksTaskIdTestExecutionsGetResponse> Get(Models.TasksTaskIdTestExecutionsGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Test Executions\",	\"id\": \"http://cypress.healthit.gov/schemas/test_executions.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"state\": {				\"type\": \"string\"			},			\"execution_errors\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"message\": {							\"type\": \"string\"						},						\"msg_type\": {							\"type\": \"string\"						},						\"file_name\": {							\"type\": \"string\"						},						\"location\": {							\"type\": \"string\"						},						\"validator\": {							\"type\": \"string\"						}					}				}			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/tasks{task_id}/test_executions/{id}\"		}]	}}", response.Content);
				}
				
            }
            return new Models.TasksTaskIdTestExecutionsGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Test Executions\",	\"id\": \"http://cypress.healthit.gov/schemas/test_executions.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"state\": {				\"type\": \"string\"			},			\"execution_errors\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"message\": {							\"type\": \"string\"						},						\"msg_type\": {							\"type\": \"string\"						},						\"file_name\": {							\"type\": \"string\"						},						\"location\": {							\"type\": \"string\"						},						\"validator\": {							\"type\": \"string\"						}					}				}			},			\"created_at\": {				\"type\": \"string\",				\"format\": \"date-time\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/tasks{task_id}/test_executions/{id}\"		}]	}}", response.Content), true)
                                            };
        }


        /// <summary>
		/// Upload a new test artifact - Task
		/// </summary>
		/// <param name="content"></param>
		/// <param name="task_id"></param>
        public virtual async Task<Models.TasksTaskIdTestExecutionsPostResponse> Post(string content, string task_id)
        {

            var url = "tasks/{task_id}/test_executions";
            url = url.Replace("{task_id}", task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url);
            req.Content = new StringContent(content);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content);
				}
					
			}

            return new Models.TasksTaskIdTestExecutionsPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content), true)
                                            };

        }

        /// <summary>
		/// Upload a new test artifact - Task
		/// </summary>
		/// <param name="request">Models.TasksTaskIdTestExecutionsPostRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.TasksTaskIdTestExecutionsPostResponse> Post(Models.TasksTaskIdTestExecutionsPostRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content);
				}
				
            }
            return new Models.TasksTaskIdTestExecutionsPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{  \"title\": \"Errors\",  \"id\": \"http://cypress.healthit.gov/schemas/errors.json\",  \"$schema\": \"http://json-schema.org/schema#\",  \"type\": \"object\",  \"properties\": {    \"errors\": {      \"type\": \"array\",      \"items\": {        \"type\": \"object\",        \"properties\": {          \"field\": {            \"type\": \"string\"          },          \"messages\": {            \"type\": \"array\",            \"items\": { \"type\" : \"string\" }          }        }      }    }  }}", response.Content), true)
                                            };
        }


        /// <summary>
		/// View information about a test execution
		/// </summary>
		/// <param name="id"></param>
		/// <param name="task_id"></param>
        public virtual async Task<Models.TasksTaskIdTestExecutionsGetByIdResponse> GetById(string id, string task_id)
        {

            var url = "tasks/{task_id}/test_executions/{id}";
            url = url.Replace("{id}", id.ToString());
            url = url.Replace("{task_id}", task_id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Test Execution\",	\"id\": \"http://cypress.healthit.gov/schemas/test_execution.json#\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"state\": {			\"type\": \"string\"		},		\"execution_errors\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"message\": {						\"type\": \"string\"					},					\"msg_type\": {						\"type\": \"string\"					},					\"file_name\": {						\"type\": \"string\"					},					\"location\": {						\"type\": \"string\"					},					\"validator\": {						\"type\": \"string\"					}				}			}		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/tasks{task_id}/test_executions/{id}\"	}]}", response.Content);
				}
					
			}

            return new Models.TasksTaskIdTestExecutionsGetByIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Test Execution\",	\"id\": \"http://cypress.healthit.gov/schemas/test_execution.json#\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"state\": {			\"type\": \"string\"		},		\"execution_errors\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"message\": {						\"type\": \"string\"					},					\"msg_type\": {						\"type\": \"string\"					},					\"file_name\": {						\"type\": \"string\"					},					\"location\": {						\"type\": \"string\"					},					\"validator\": {						\"type\": \"string\"					}				}			}		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/tasks{task_id}/test_executions/{id}\"	}]}", response.Content), true)
                                            };

        }

        /// <summary>
		/// View information about a test execution
		/// </summary>
		/// <param name="request">Models.TasksTaskIdTestExecutionsGetByIdRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.TasksTaskIdTestExecutionsGetByIdResponse> GetById(Models.TasksTaskIdTestExecutionsGetByIdRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Test Execution\",	\"id\": \"http://cypress.healthit.gov/schemas/test_execution.json#\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"state\": {			\"type\": \"string\"		},		\"execution_errors\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"message\": {						\"type\": \"string\"					},					\"msg_type\": {						\"type\": \"string\"					},					\"file_name\": {						\"type\": \"string\"					},					\"location\": {						\"type\": \"string\"					},					\"validator\": {						\"type\": \"string\"					}				}			}		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/tasks{task_id}/test_executions/{id}\"	}]}", response.Content);
				}
				
            }
            return new Models.TasksTaskIdTestExecutionsGetByIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Test Execution\",	\"id\": \"http://cypress.healthit.gov/schemas/test_execution.json#\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"state\": {			\"type\": \"string\"		},		\"execution_errors\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"message\": {						\"type\": \"string\"					},					\"msg_type\": {						\"type\": \"string\"					},					\"file_name\": {						\"type\": \"string\"					},					\"location\": {						\"type\": \"string\"					},					\"validator\": {						\"type\": \"string\"					}				}			}		},		\"created_at\": {			\"type\": \"string\",			\"format\": \"date-time\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/tasks{task_id}/test_executions/{id}\"	}]}", response.Content), true)
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


        /// <summary>
		/// List of measure in the bundle
		/// </summary>
		/// <param name="id"></param>
        public virtual async Task<Models.MeasuresGetResponse> Get(string id)
        {

            var url = "bundles/{id}/measures";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Measures\",	\"id\": \"http://cypress.healthit.gov/schemas/measures.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"cms_id\": {				\"type\": \"string\"			},			\"hqmf_id\": {				\"type\": \"string\"			},			\"type\": {				\"type\": \"string\"			},			\"description\": {				\"type\": \"string\"			},			\"category\": {				\"type\": \"string\"			}		}	}}", response.Content);
				}
					
			}

            return new Models.MeasuresGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Measures\",	\"id\": \"http://cypress.healthit.gov/schemas/measures.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"cms_id\": {				\"type\": \"string\"			},			\"hqmf_id\": {				\"type\": \"string\"			},			\"type\": {				\"type\": \"string\"			},			\"description\": {				\"type\": \"string\"			},			\"category\": {				\"type\": \"string\"			}		}	}}", response.Content), true)
                                            };

        }

        /// <summary>
		/// List of measure in the bundle
		/// </summary>
		/// <param name="request">Models.MeasuresGetRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.MeasuresGetResponse> Get(Models.MeasuresGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "bundles/{id}/measures";
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Measures\",	\"id\": \"http://cypress.healthit.gov/schemas/measures.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"cms_id\": {				\"type\": \"string\"			},			\"hqmf_id\": {				\"type\": \"string\"			},			\"type\": {				\"type\": \"string\"			},			\"description\": {				\"type\": \"string\"			},			\"category\": {				\"type\": \"string\"			}		}	}}", response.Content);
				}
				
            }
            return new Models.MeasuresGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Measures\",	\"id\": \"http://cypress.healthit.gov/schemas/measures.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"name\": {				\"type\": \"string\"			},			\"cms_id\": {				\"type\": \"string\"			},			\"hqmf_id\": {				\"type\": \"string\"			},			\"type\": {				\"type\": \"string\"			},			\"description\": {				\"type\": \"string\"			},			\"category\": {				\"type\": \"string\"			}		}	}}", response.Content), true)
                                            };
        }

    }

    /// <summary>
    /// Bundles installed on the system
    /// </summary>
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
		/// Bundles installed on the system. View a list of all installed bundles
		/// </summary>
        public virtual async Task<Models.BundlesGetResponse> Get()
        {

            var url = "bundles";

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Bundles\",	\"id\": \"http://cypress.healthit.gov/schemas/bundles.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"title\": {				\"type\": \"string\"			},			\"version\": {				\"type\": \"string\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/bundles/{id}\"		},		{			\"rel\": \"measures\",			\"href\": \"/bundles/{id}/measures\"		}]	}}", response.Content);
				}
					
			}

            return new Models.BundlesGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Bundles\",	\"id\": \"http://cypress.healthit.gov/schemas/bundles.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"title\": {				\"type\": \"string\"			},			\"version\": {				\"type\": \"string\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/bundles/{id}\"		},		{			\"rel\": \"measures\",			\"href\": \"/bundles/{id}/measures\"		}]	}}", response.Content), true)
                                            };

        }

        /// <summary>
		/// Bundles installed on the system. View a list of all installed bundles
		/// </summary>
		/// <param name="request">ApiRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.BundlesGetResponse> Get(ApiRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Bundles\",	\"id\": \"http://cypress.healthit.gov/schemas/bundles.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"title\": {				\"type\": \"string\"			},			\"version\": {				\"type\": \"string\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/bundles/{id}\"		},		{			\"rel\": \"measures\",			\"href\": \"/bundles/{id}/measures\"		}]	}}", response.Content);
				}
				
            }
            return new Models.BundlesGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Bundles\",	\"id\": \"http://cypress.healthit.gov/schemas/bundles.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"array\",	\"items\": {		\"type\": \"object\",		\"properties\": {			\"title\": {				\"type\": \"string\"			},			\"version\": {				\"type\": \"string\"			},			\"links\": {				\"type\": \"array\",				\"items\": {					\"type\": \"object\",					\"properties\": {						\"rel\": {							\"type\": \"string\"						},						\"href\": {							\"type\": \"string\"						}					}				}			}		},		\"links\": [{			\"rel\": \"self\",			\"href\": \"/bundles/{id}\"		},		{			\"rel\": \"measures\",			\"href\": \"/bundles/{id}/measures\"		}]	}}", response.Content), true)
                                            };
        }


        /// <summary>
		/// Annual Update Bundle. View a list of all installed bundles
		/// </summary>
		/// <param name="id"></param>
        public virtual async Task<Models.BundlesGetByIdResponse> GetById(string id)
        {

            var url = "bundles/{id}";
            url = url.Replace("{id}", id.ToString());

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url);
	        var response = await proxy.Client.SendAsync(req);
			
			if (proxy.SchemaValidation.Enabled)
		    {
				if(proxy.SchemaValidation.RaiseExceptions) 
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Bundle\",	\"id\": \"http://cypress.healthit.gov/schemas/bundle.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"title\": {			\"type\": \"string\"		},		\"version\": {			\"type\": \"string\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/bundles/{id}\"	},	{		\"rel\": \"measures\",		\"href\": \"/bundles/{id}/measures\"	}]}", response.Content);
				}
					
			}

            return new Models.BundlesGetByIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Bundle\",	\"id\": \"http://cypress.healthit.gov/schemas/bundle.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"title\": {			\"type\": \"string\"		},		\"version\": {			\"type\": \"string\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/bundles/{id}\"	},	{		\"rel\": \"measures\",		\"href\": \"/bundles/{id}/measures\"	}]}", response.Content), true)
                                            };

        }

        /// <summary>
		/// Annual Update Bundle. View a list of all installed bundles
		/// </summary>
		/// <param name="request">Models.BundlesGetByIdRequest</param>
		/// <param name="responseFormatters">response formmaters</param>
        public virtual async Task<Models.BundlesGetByIdResponse> GetById(Models.BundlesGetByIdRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
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
			if (proxy.SchemaValidation.Enabled && proxy.SchemaValidation.RaiseExceptions)
            {
				if(proxy.SchemaValidation.RaiseExceptions)
				{
					await SchemaValidator.ValidateWithExceptionAsync("{	\"title\": \"Bundle\",	\"id\": \"http://cypress.healthit.gov/schemas/bundle.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"title\": {			\"type\": \"string\"		},		\"version\": {			\"type\": \"string\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/bundles/{id}\"	},	{		\"rel\": \"measures\",		\"href\": \"/bundles/{id}/measures\"	}]}", response.Content);
				}
				
            }
            return new Models.BundlesGetByIdResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => SchemaValidator.IsValid("{	\"title\": \"Bundle\",	\"id\": \"http://cypress.healthit.gov/schemas/bundle.json\",	\"$schema\": \"http://json-schema.org/schema#\",	\"type\": \"object\",	\"properties\": {		\"title\": {			\"type\": \"string\"		},		\"version\": {			\"type\": \"string\"		},		\"links\": {			\"type\": \"array\",			\"items\": {				\"type\": \"object\",				\"properties\": {					\"rel\": {						\"type\": \"string\"					},					\"href\": {						\"type\": \"string\"					}				}			}		}	},	\"links\": [{		\"rel\": \"self\",		\"href\": \"/bundles/{id}\"	},	{		\"rel\": \"measures\",		\"href\": \"/bundles/{id}/measures\"	}]}", response.Content), true)
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
                

        public virtual ProductsProductIdProductTests ProductsProductIdProductTests
        {
            get { return new ProductsProductIdProductTests(this); }
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
    public partial class  PointsOfContact 
    {

		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("email")]
        public string Email { get; set; }


		[JsonProperty("phone")]
        public string Phone { get; set; }


		[JsonProperty("contact_type")]
        public string Contact_type { get; set; }


    } // end class

    public partial class  Links 
    {

		[JsonProperty("rel")]
        public string Rel { get; set; }


		[JsonProperty("href")]
        public string Href { get; set; }


    } // end class

    public partial class  VendorsPostRequestContent 
    {

		[JsonProperty("vendor_id")]
        public string Vendor_id { get; set; }


		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("url")]
        public string Url { get; set; }


		[JsonProperty("address")]
        public string Address { get; set; }


		[JsonProperty("zip")]
        public string Zip { get; set; }


		[JsonProperty("state")]
        public string State { get; set; }


		[JsonProperty("points_of_contact")]
        public IList<PointsOfContact> Points_of_contact { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("updated_at")]
        public string Updated_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  VendorsIdPutRequestContent 
    {

		[JsonProperty("vendor_id")]
        public string Vendor_id { get; set; }


		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("url")]
        public string Url { get; set; }


		[JsonProperty("address")]
        public string Address { get; set; }


		[JsonProperty("zip")]
        public string Zip { get; set; }


		[JsonProperty("state")]
        public string State { get; set; }


		[JsonProperty("points_of_contact")]
        public IList<PointsOfContact> Points_of_contact { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("updated_at")]
        public string Updated_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  VendorsIdProductsPostRequestContent 
    {

		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("version")]
        public string Version { get; set; }


		[JsonProperty("description")]
        public string Description { get; set; }


		[JsonProperty("bundle_id")]
        public string Bundle_id { get; set; }


		[JsonProperty("c1_test")]
        public bool? C1_test { get; set; }


		[JsonProperty("c2_test")]
        public bool? C2_test { get; set; }


		[JsonProperty("c3_test")]
        public bool? C3_test { get; set; }


		[JsonProperty("c4_test")]
        public bool? C4_test { get; set; }


		[JsonProperty("randomize_records")]
        public bool? Randomize_records { get; set; }


		[JsonProperty("duplicate_records")]
        public bool? Duplicate_records { get; set; }


		[JsonProperty("measure_ids")]
        public IList<string> Measure_ids { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("updated_at")]
        public string Updated_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  VendorsGetOKResponseContent 
    {

		[JsonProperty("vendor_id")]
        public string Vendor_id { get; set; }


		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("url")]
        public string Url { get; set; }


		[JsonProperty("address")]
        public string Address { get; set; }


		[JsonProperty("zip")]
        public string Zip { get; set; }


		[JsonProperty("state")]
        public string State { get; set; }


		[JsonProperty("points_of_contact")]
        public IList<PointsOfContact> Points_of_contact { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("updated_at")]
        public string Updated_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  Errors 
    {

		[JsonProperty("field")]
        public string Field { get; set; }


		[JsonProperty("messages")]
        public IList<string> Messages { get; set; }


    } // end class

    public partial class  VendorsPost422ResponseContent 
    {

		[JsonProperty("errors")]
        public IList<Errors> Errors { get; set; }


    } // end class

    public partial class  VendorsIdGetOKResponseContent 
    {

		[JsonProperty("vendor_id")]
        public string Vendor_id { get; set; }


		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("url")]
        public string Url { get; set; }


		[JsonProperty("address")]
        public string Address { get; set; }


		[JsonProperty("zip")]
        public string Zip { get; set; }


		[JsonProperty("state")]
        public string State { get; set; }


		[JsonProperty("points_of_contact")]
        public IList<PointsOfContact> Points_of_contact { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("updated_at")]
        public string Updated_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  VendorsIdProductsGetOKResponseContent 
    {

		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("version")]
        public string Version { get; set; }


		[JsonProperty("description")]
        public string Description { get; set; }


		[JsonProperty("bundle_id")]
        public string Bundle_id { get; set; }


		[JsonProperty("c1_test")]
        public bool? C1_test { get; set; }


		[JsonProperty("c2_test")]
        public bool? C2_test { get; set; }


		[JsonProperty("c3_test")]
        public bool? C3_test { get; set; }


		[JsonProperty("c4_test")]
        public bool? C4_test { get; set; }


		[JsonProperty("randomize_records")]
        public bool? Randomize_records { get; set; }


		[JsonProperty("duplicate_records")]
        public bool? Duplicate_records { get; set; }


		[JsonProperty("measure_ids")]
        public IList<string> Measure_ids { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("updated_at")]
        public string Updated_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  VendorsIdProductsPost422ResponseContent 
    {

		[JsonProperty("errors")]
        public IList<Errors> Errors { get; set; }


    } // end class

    public partial class  VendorsIdProductsProductIdGetOKResponseContent 
    {

		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("version")]
        public string Version { get; set; }


		[JsonProperty("description")]
        public string Description { get; set; }


		[JsonProperty("bundle_id")]
        public string Bundle_id { get; set; }


		[JsonProperty("c1_test")]
        public bool? C1_test { get; set; }


		[JsonProperty("c2_test")]
        public bool? C2_test { get; set; }


		[JsonProperty("c3_test")]
        public bool? C3_test { get; set; }


		[JsonProperty("c4_test")]
        public bool? C4_test { get; set; }


		[JsonProperty("randomize_records")]
        public bool? Randomize_records { get; set; }


		[JsonProperty("duplicate_records")]
        public bool? Duplicate_records { get; set; }


		[JsonProperty("measure_ids")]
        public IList<string> Measure_ids { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("updated_at")]
        public string Updated_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  ProductsProductIdProductTestsGetOKResponseContent 
    {

		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("cms_id")]
        public string Cms_id { get; set; }


		[JsonProperty("measure_id")]
        public string Measure_id { get; set; }


		[JsonProperty("type")]
        public string Type { get; set; }


		[JsonProperty("state")]
        public string State { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("updated_at")]
        public string Updated_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  ProductsProductIdProductTestsIdGetOKResponseContent 
    {

		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("cms_id")]
        public string Cms_id { get; set; }


		[JsonProperty("measure_id")]
        public string Measure_id { get; set; }


		[JsonProperty("type")]
        public string Type { get; set; }


		[JsonProperty("state")]
        public string State { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("updated_at")]
        public string Updated_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  ProductTestsProductTestIdTasksGetOKResponseContent 
    {

		[JsonProperty("type")]
        public string Type { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  ProductTestsProductTestIdTasksIdGetOKResponseContent 
    {

		[JsonProperty("type")]
        public string Type { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  ExecutionErrors 
    {

		[JsonProperty("message")]
        public string Message { get; set; }


		[JsonProperty("msg_type")]
        public string Msg_type { get; set; }


		[JsonProperty("file_name")]
        public string File_name { get; set; }


		[JsonProperty("location")]
        public string Location { get; set; }


		[JsonProperty("validator")]
        public string Validator { get; set; }


    } // end class

    public partial class  TasksTaskIdTestExecutionsGetOKResponseContent 
    {

		[JsonProperty("state")]
        public string State { get; set; }


		[JsonProperty("execution_errors")]
        public IList<ExecutionErrors> Execution_errors { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  TasksTaskIdTestExecutionsPost422ResponseContent 
    {

		[JsonProperty("errors")]
        public IList<Errors> Errors { get; set; }


    } // end class

    public partial class  TasksTaskIdTestExecutionsIdGetOKResponseContent 
    {

		[JsonProperty("state")]
        public string State { get; set; }


		[JsonProperty("execution_errors")]
        public IList<ExecutionErrors> Execution_errors { get; set; }


		[JsonProperty("created_at")]
        public string Created_at { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  BundlesGetOKResponseContent 
    {

		[JsonProperty("title")]
        public string Title { get; set; }


		[JsonProperty("version")]
        public string Version { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  BundlesIdGetOKResponseContent 
    {

		[JsonProperty("title")]
        public string Title { get; set; }


		[JsonProperty("version")]
        public string Version { get; set; }


		[JsonProperty("links")]
        public IList<Links> Links { get; set; }


    } // end class

    public partial class  BundlesIdMeasuresGetOKResponseContent 
    {

		[JsonProperty("name")]
        public string Name { get; set; }


		[JsonProperty("cms_id")]
        public string Cms_id { get; set; }


		[JsonProperty("hqmf_id")]
        public string Hqmf_id { get; set; }


		[JsonProperty("type")]
        public string Type { get; set; }


		[JsonProperty("description")]
        public string Description { get; set; }


		[JsonProperty("category")]
        public string Category { get; set; }


    } // end class

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
    /// Uri Parameters for resource /{product_id}
    /// </summary>
    public partial class  VendorsIdProductsProductIdUriParameters 
    {

		[JsonProperty("product_id")]
        public string Product_id { get; set; }


		[JsonProperty("id")]
        public string Id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /products/{product_id}/product_tests
    /// </summary>
    public partial class  ProductsProductIdProductTestsUriParameters 
    {

		[JsonProperty("product_id")]
        public string Product_id { get; set; }


    } // end class

    /// <summary>
    /// Uri Parameters for resource /{id}
    /// </summary>
    public partial class  ProductsProductIdProductTestsIdUriParameters 
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
    /// Uri Parameters for resource /measures
    /// </summary>
    public partial class  BundlesIdMeasuresUriParameters 
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
        public ProductsPostRequest(VendorsIdProductsUriParameters UriParameters, VendorsIdProductsPostRequestContent Content = null, MediaTypeFormatter Formatter = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public VendorsIdProductsPostRequestContent Content { get; set; }

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
    /// Request object for method GetByProductId of class Products
    /// </summary>
    public partial class ProductsGetByProductIdRequest : ApiRequest
    {
        public ProductsGetByProductIdRequest(VendorsIdProductsProductIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public VendorsIdProductsProductIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Delete of class Products
    /// </summary>
    public partial class ProductsDeleteRequest : ApiRequest
    {
        public ProductsDeleteRequest(VendorsIdProductsProductIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public VendorsIdProductsProductIdUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Post of class Vendors
    /// </summary>
    public partial class VendorsPostRequest : ApiRequest
    {
        public VendorsPostRequest(VendorsPostRequestContent Content = null, MediaTypeFormatter Formatter = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public VendorsPostRequestContent Content { get; set; }

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
        public VendorsPutRequest(VendorsIdUriParameters UriParameters, VendorsIdPutRequestContent Content = null, MediaTypeFormatter Formatter = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public VendorsIdPutRequestContent Content { get; set; }

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
    /// Request object for method Get of class ProductsProductIdProductTests
    /// </summary>
    public partial class ProductsProductIdProductTestsGetRequest : ApiRequest
    {
        public ProductsProductIdProductTestsGetRequest(ProductsProductIdProductTestsUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public ProductsProductIdProductTestsUriParameters UriParameters { get; set; }

    } // end class

    /// <summary>
    /// Request object for method GetById of class ProductsProductIdProductTests
    /// </summary>
    public partial class ProductsProductIdProductTestsGetByIdRequest : ApiRequest
    {
        public ProductsProductIdProductTestsGetByIdRequest(ProductsProductIdProductTestsIdUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public ProductsProductIdProductTestsIdUriParameters UriParameters { get; set; }

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
    /// Request object for method Get of class Measures
    /// </summary>
    public partial class MeasuresGetRequest : ApiRequest
    {
        public MeasuresGetRequest(BundlesIdMeasuresUriParameters UriParameters)
        {
            this.UriParameters = UriParameters;
        }


        /// <summary>
        /// Request Uri Parameters
        /// </summary>
        public BundlesIdMeasuresUriParameters UriParameters { get; set; }

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

    /// <summary>
    /// Response object for method Get of class Products
    /// </summary>

    public partial class ProductsGetResponse : ApiResponse
    {


	    private IList<VendorsIdProductsGetOKResponseContent> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<VendorsIdProductsGetOKResponseContent> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<VendorsIdProductsGetOKResponseContent>)new XmlSerializer(typeof(IList<VendorsIdProductsGetOKResponseContent>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<VendorsIdProductsGetOKResponseContent>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<VendorsIdProductsGetOKResponseContent>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Post of class Products
    /// </summary>

    public partial class ProductsPostResponse : ApiResponse
    {


	    private VendorsIdProductsPost422ResponseContent typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public VendorsIdProductsPost422ResponseContent Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (VendorsIdProductsPost422ResponseContent)new XmlSerializer(typeof(VendorsIdProductsPost422ResponseContent)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<VendorsIdProductsPost422ResponseContent>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<VendorsIdProductsPost422ResponseContent>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetByProductId of class Products
    /// </summary>

    public partial class ProductsGetByProductIdResponse : ApiResponse
    {


	    private VendorsIdProductsProductIdGetOKResponseContent typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public VendorsIdProductsProductIdGetOKResponseContent Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (VendorsIdProductsProductIdGetOKResponseContent)new XmlSerializer(typeof(VendorsIdProductsProductIdGetOKResponseContent)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<VendorsIdProductsProductIdGetOKResponseContent>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<VendorsIdProductsProductIdGetOKResponseContent>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class Vendors
    /// </summary>

    public partial class VendorsGetResponse : ApiResponse
    {


	    private IList<VendorsGetOKResponseContent> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<VendorsGetOKResponseContent> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<VendorsGetOKResponseContent>)new XmlSerializer(typeof(IList<VendorsGetOKResponseContent>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<VendorsGetOKResponseContent>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<VendorsGetOKResponseContent>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Post of class Vendors
    /// </summary>

    public partial class VendorsPostResponse : ApiResponse
    {


	    private VendorsPost422ResponseContent typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public VendorsPost422ResponseContent Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (VendorsPost422ResponseContent)new XmlSerializer(typeof(VendorsPost422ResponseContent)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<VendorsPost422ResponseContent>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<VendorsPost422ResponseContent>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetById of class Vendors
    /// </summary>

    public partial class VendorsGetByIdResponse : ApiResponse
    {


	    private VendorsIdGetOKResponseContent typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public VendorsIdGetOKResponseContent Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (VendorsIdGetOKResponseContent)new XmlSerializer(typeof(VendorsIdGetOKResponseContent)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<VendorsIdGetOKResponseContent>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<VendorsIdGetOKResponseContent>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class ProductsProductIdProductTests
    /// </summary>

    public partial class ProductsProductIdProductTestsGetResponse : ApiResponse
    {


	    private IList<ProductsProductIdProductTestsGetOKResponseContent> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<ProductsProductIdProductTestsGetOKResponseContent> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<ProductsProductIdProductTestsGetOKResponseContent>)new XmlSerializer(typeof(IList<ProductsProductIdProductTestsGetOKResponseContent>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<ProductsProductIdProductTestsGetOKResponseContent>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<ProductsProductIdProductTestsGetOKResponseContent>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetById of class ProductsProductIdProductTests
    /// </summary>

    public partial class ProductsProductIdProductTestsGetByIdResponse : ApiResponse
    {


	    private ProductsProductIdProductTestsIdGetOKResponseContent typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public ProductsProductIdProductTestsIdGetOKResponseContent Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (ProductsProductIdProductTestsIdGetOKResponseContent)new XmlSerializer(typeof(ProductsProductIdProductTestsIdGetOKResponseContent)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<ProductsProductIdProductTestsIdGetOKResponseContent>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<ProductsProductIdProductTestsIdGetOKResponseContent>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class ProductTestsProductTestIdTasks
    /// </summary>

    public partial class ProductTestsProductTestIdTasksGetResponse : ApiResponse
    {


	    private IList<ProductTestsProductTestIdTasksGetOKResponseContent> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<ProductTestsProductTestIdTasksGetOKResponseContent> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<ProductTestsProductTestIdTasksGetOKResponseContent>)new XmlSerializer(typeof(IList<ProductTestsProductTestIdTasksGetOKResponseContent>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<ProductTestsProductTestIdTasksGetOKResponseContent>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<ProductTestsProductTestIdTasksGetOKResponseContent>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetById of class ProductTestsProductTestIdTasks
    /// </summary>

    public partial class ProductTestsProductTestIdTasksGetByIdResponse : ApiResponse
    {


	    private ProductTestsProductTestIdTasksIdGetOKResponseContent typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public ProductTestsProductTestIdTasksIdGetOKResponseContent Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (ProductTestsProductTestIdTasksIdGetOKResponseContent)new XmlSerializer(typeof(ProductTestsProductTestIdTasksIdGetOKResponseContent)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<ProductTestsProductTestIdTasksIdGetOKResponseContent>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<ProductTestsProductTestIdTasksIdGetOKResponseContent>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class TasksTaskIdTestExecutions
    /// </summary>

    public partial class TasksTaskIdTestExecutionsGetResponse : ApiResponse
    {


	    private IList<TasksTaskIdTestExecutionsGetOKResponseContent> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<TasksTaskIdTestExecutionsGetOKResponseContent> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<TasksTaskIdTestExecutionsGetOKResponseContent>)new XmlSerializer(typeof(IList<TasksTaskIdTestExecutionsGetOKResponseContent>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<TasksTaskIdTestExecutionsGetOKResponseContent>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<TasksTaskIdTestExecutionsGetOKResponseContent>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Post of class TasksTaskIdTestExecutions
    /// </summary>

    public partial class TasksTaskIdTestExecutionsPostResponse : ApiResponse
    {


	    private TasksTaskIdTestExecutionsPost422ResponseContent typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public TasksTaskIdTestExecutionsPost422ResponseContent Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (TasksTaskIdTestExecutionsPost422ResponseContent)new XmlSerializer(typeof(TasksTaskIdTestExecutionsPost422ResponseContent)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<TasksTaskIdTestExecutionsPost422ResponseContent>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<TasksTaskIdTestExecutionsPost422ResponseContent>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetById of class TasksTaskIdTestExecutions
    /// </summary>

    public partial class TasksTaskIdTestExecutionsGetByIdResponse : ApiResponse
    {


	    private TasksTaskIdTestExecutionsIdGetOKResponseContent typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public TasksTaskIdTestExecutionsIdGetOKResponseContent Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (TasksTaskIdTestExecutionsIdGetOKResponseContent)new XmlSerializer(typeof(TasksTaskIdTestExecutionsIdGetOKResponseContent)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<TasksTaskIdTestExecutionsIdGetOKResponseContent>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<TasksTaskIdTestExecutionsIdGetOKResponseContent>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class Measures
    /// </summary>

    public partial class MeasuresGetResponse : ApiResponse
    {


	    private IList<BundlesIdMeasuresGetOKResponseContent> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<BundlesIdMeasuresGetOKResponseContent> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<BundlesIdMeasuresGetOKResponseContent>)new XmlSerializer(typeof(IList<BundlesIdMeasuresGetOKResponseContent>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<BundlesIdMeasuresGetOKResponseContent>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<BundlesIdMeasuresGetOKResponseContent>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method Get of class Bundles
    /// </summary>

    public partial class BundlesGetResponse : ApiResponse
    {


	    private IList<BundlesGetOKResponseContent> typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public IList<BundlesGetOKResponseContent> Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (IList<BundlesGetOKResponseContent>)new XmlSerializer(typeof(IList<BundlesGetOKResponseContent>)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<IList<BundlesGetOKResponseContent>>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<IList<BundlesGetOKResponseContent>>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class

    /// <summary>
    /// Response object for method GetById of class Bundles
    /// </summary>

    public partial class BundlesGetByIdResponse : ApiResponse
    {


	    private BundlesIdGetOKResponseContent typedContent;
        /// <summary>
        /// Typed Response content
        /// </summary>
        public BundlesIdGetOKResponseContent Content 
    	{
	        get
	        {
		        if (typedContent != null)
			        return typedContent;

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    typedContent = (BundlesIdGetOKResponseContent)new XmlSerializer(typeof(BundlesIdGetOKResponseContent)).Deserialize(xmlStream);
                }
                else
                {
                    var task =  Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync<BundlesIdGetOKResponseContent>(Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync<BundlesIdGetOKResponseContent>().ConfigureAwait(false);
		        
		            typedContent = task.GetAwaiter().GetResult();
                }

		        return typedContent;
	        }
	    }

		


    } // end class


} // end Models namespace

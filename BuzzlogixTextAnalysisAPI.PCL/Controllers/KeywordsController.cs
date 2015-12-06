/*
 * BuzzlogixTextAnalysisAPI.PCL
 *
 * This file was automatically generated for buzzlogix by APIMATIC BETA v2.0 on 12/06/2015
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.buzzlogix.Controllers
{
    public partial class KeywordsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static KeywordsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static KeywordsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new KeywordsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// The text should be provided as text/plain in the body
        /// </summary>
        /// <param name="body">Required parameter: Supply text to be classified.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateReturnEnglishKeywordsTextPlainAsync(
                string body)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/keywords");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                {"user-agent", "APIMATIC 2.0"},
                {"accept", "application/json"}
            };
            _headers.Add("X-Mashape-Key", Configuration.XMashapeKey);

            //append body params
             var _body = body;

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// The text should be provided as multipart/form-data with the key 'text'. Files can be uploaded.
        /// </summary>
        /// <param name="text">Required parameter: Supply text to be classified.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateReturnEnglishKeywordsMultipartFormDataAsync(
                FileStreamInfo text)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/keywords");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                {"user-agent", "APIMATIC 2.0"},
                {"accept", "application/json"}
            };
            _headers.Add("X-Mashape-Key", Configuration.XMashapeKey);

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                {"text", text}
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Supply the text being classified using key 'text' in a form. 
        /// </summary>
        /// <param name="text">Required parameter: Supply the text to be classified.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateReturnEnglishKeywordsXWwwFormUrlencodedAsync(
                string text)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/keywords");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                {"user-agent", "APIMATIC 2.0"},
                {"accept", "application/json"}
            };
            _headers.Add("X-Mashape-Key", Configuration.XMashapeKey);

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                {"text", text}
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 
/*
 * BuzzlogixTextAnalysisAPI.PCL
 *
 * This file was automatically generated for buzzlogix by APIMATIC BETA v2.0 on 11/25/2015
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
    public partial class TwittersentimentController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TwittersentimentController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TwittersentimentController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TwittersentimentController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// The Tweet should be provided as text/plain in the body
        /// </summary>
        /// <param name="body">Required parameter: Supply text to be classified.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateReturnEnglishTwitterSentimentAsync(
                string body)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/twittersentiment");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                {"user-agent", "APIMATIC 2.0"},
                {"accept", "application/json"}
            };
            _headers.Add("apikey", Configuration.Apikey);

            //append body params
             var _body = body;

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"No API Key found in headers, body or querystring", 401);

            else if (_response.StatusCode == 403)
                throw new APIException(@"Invalid authentication credentials", 403);

            else if (_response.StatusCode == 429)
                throw new APIException(@"API rate limit exceeded", 429);

            else if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _response.StatusCode);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, -1);
            }
        }

        /// <summary>
        /// The Tweet should be provided as multipart/form-data with the key 'text'. Files can be uploaded.
        /// </summary>
        /// <param name="body">Required parameter: Supply text to be classified.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateReturnEnglishTwitterSentimentFormAsync(
                string body)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/twittersentiment/form");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                {"user-agent", "APIMATIC 2.0"},
                {"accept", "application/json"}
            };
            _headers.Add("apikey", Configuration.Apikey);

            //append body params
             var _body = body;

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"No API Key found in headers, body or querystring", 401);

            else if (_response.StatusCode == 403)
                throw new APIException(@"Invalid authentication credentials", 403);

            else if (_response.StatusCode == 429)
                throw new APIException(@"API rate limit exceeded", 429);

            else if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _response.StatusCode);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, -1);
            }
        }

    }
} 
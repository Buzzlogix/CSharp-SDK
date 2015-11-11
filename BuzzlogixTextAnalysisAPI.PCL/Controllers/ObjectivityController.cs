/*
 * BuzzlogixTextAnalysisAPI.PCL
 *
 * This file was automatically generated for Buzzlogix by APIMATIC BETA v2.0 on 11/09/2015
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unirest_net.http;
using unirest_net.request;

namespace Buzzlogix.Controllers
{
    public partial class ObjectivityController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ObjectivityController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ObjectivityController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ObjectivityController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Use this endpoint to retrieve whether the provided text is subjective or objective.
        /// </summary>
        /// <param name="body">Required parameter: Supply text to be classified.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateReturnObjectivityAsync(
                string body)
        {
            //the base uri for api requests
            string baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/objectivity");


            //validate and preprocess url
            string queryUrl = APIHelper.CleanUrl(queryBuilder);

            //prepare and invoke the API call request to fetch the response
            HttpRequest request = Unirest.post(queryUrl)
                //append request with appropriate headers and parameters
                .header("user-agent", "APIMATIC 2.0")
                .header("apikey", Configuration.Apikey)
                .body(body);

            //Custom Authentication to be added for authorization
            CustomAuthUtility.AppendCustomAuthParams(request);

            //invoke request and get response
            HttpResponse<String> response = await request.asStringAsync();

            //Error handling using HTTP status codes
            if (response.Code == 401)
                throw new APIException(@"No API Key found in headers, body or querystring", 401);

            else if (response.Code == 403)
                throw new APIException(@"Invalid authentication credentials", 403);

            else if (response.Code == 429)
                throw new APIException(@"API rate limit exceeded", 429);

            else if ((response.Code < 200) || (response.Code > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", response.Code);

        }

    }
} 
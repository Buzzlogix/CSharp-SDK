/*
 * BuzzlogixTextAnalysisAPI.PCL
 *
 * This file was automatically generated for Buzzlogix by APIMATIC BETA v2.0 on 11/09/2015
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using unirest_net.request;

namespace Buzzlogix
{
    internal partial class AuthUtility
    {
        /// <summary>
        /// Appends the necessary Custom Authentication credentials for making this authorized call
        /// </summary>
        /// <param name="request">The out going request to access the resource</param>        
        internal static void AppendCustomAuthParams(HttpRequest request)
        {
            // TODO: Add your custom authentication here
			// The following properties are available to use
			//     Configuration.Apikey
			// 
			// ie. Add a header through:
			//     request.header("Key", "Value");
        }
    }
}

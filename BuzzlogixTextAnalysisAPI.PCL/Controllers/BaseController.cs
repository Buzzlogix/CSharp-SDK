/*
 * BuzzlogixTextAnalysisAPI.PCL
 *
 * This file was automatically generated for Buzzlogix by APIMATIC BETA v2.0 on 11/18/2015
 */
using System;

using com.buzzlogix.Http.Client;

namespace com.buzzlogix.Controllers
{
	public partial class BaseController
    {
        internal IHttpClient ClientInstance = null;

        public BaseController()
        {
            ClientInstance = UnirestClient.SharedClient;
        }

        public BaseController(IHttpClient client)
        {
            ClientInstance = client;
        }

    }
} 
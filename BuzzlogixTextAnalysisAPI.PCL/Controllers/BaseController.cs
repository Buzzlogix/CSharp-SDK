/*
 * BuzzlogixTextAnalysisAPI.PCL
 *
 * This file was automatically generated for buzzlogix by APIMATIC BETA v2.0 on 12/06/2015
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
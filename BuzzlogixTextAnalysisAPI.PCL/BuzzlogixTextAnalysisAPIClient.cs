/*
 * BuzzlogixTextAnalysisAPI.PCL
 *
 * This file was automatically generated for Buzzlogix by APIMATIC BETA v2.0 on 11/09/2015
 */
using System;
using Buzzlogix.Controllers;

namespace Buzzlogix
{
    public partial class BuzzlogixTextAnalysisAPIClient
    {

        /// <summary>
        /// Singleton access to Objectivity controller
        /// </summary>
        public ObjectivityController Objectivity
        {
            get
            {
                return ObjectivityController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Sentiment controller
        /// </summary>
        public SentimentController Sentiment
        {
            get
            {
                return SentimentController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Twittersentiment controller
        /// </summary>
        public TwittersentimentController Twittersentiment
        {
            get
            {
                return TwittersentimentController.Instance;
            }
        }

        /// <summary>
        /// Client constructor
        /// </summary>
        public BuzzlogixTextAnalysisAPIClient(string apikey)
        {
            Configuration.Apikey = apikey;
        }
    }
}
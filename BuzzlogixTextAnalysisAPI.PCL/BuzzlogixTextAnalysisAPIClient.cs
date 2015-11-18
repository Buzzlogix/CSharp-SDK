/*
 * BuzzlogixTextAnalysisAPI.PCL
 *
 * This file was automatically generated for Buzzlogix by APIMATIC BETA v2.0 on 11/18/2015
 */
using System;
using com.buzzlogix.Controllers;

namespace com.buzzlogix
{
    public partial class BuzzlogixTextAnalysisAPIClient
    {

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
        /// Singleton access to Keywords controller
        /// </summary>
        public KeywordsController Keywords
        {
            get
            {
                return KeywordsController.Instance;
            }
        }

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
        /// Client constructor
        /// </summary>
        public BuzzlogixTextAnalysisAPIClient(string apikey)
        {
            Configuration.Apikey = apikey;
        }
    }
}
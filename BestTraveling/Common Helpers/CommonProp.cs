using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace BestTraveling.Common_Helpers
{
    public class CommonProp
    {
        private static string siteUrl = string.Empty;
        public static string SiteUrl
        {
            get
            {
                if(SiteUrl.Equals(string.Empty))
                {
                    string su = ConfigurationManager.AppSettings["SiteUrl"];
                    if (string.IsNullOrEmpty(su))
                    {
                        throw new ArgumentException("Site url is not found in Configuration file");
                    }
                    siteUrl = su;
                }
                return siteUrl;
            }
        }
    }
}
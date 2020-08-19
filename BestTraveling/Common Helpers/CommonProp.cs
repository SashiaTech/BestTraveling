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
                if (siteUrl.Equals(string.Empty))
                {
                    string surl = ConfigurationManager.AppSettings["SiteUrl"];
                    if (string.IsNullOrEmpty(surl))
                    { throw new ArgumentNullException("Site Url not found in configuration."); }
                    siteUrl = surl;
                }
                return siteUrl;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace eShopCMS.Core
{
    public class GlobalSetting
    {
        private static readonly GlobalSetting _instance = new GlobalSetting();

        public const string DefaultEndpoint = "http://13.88.8.119";

        public GlobalSetting()
        {
            AuthToken = "INSERT AUTHENTICATION TOKEN";
            BaseEndpoint = DefaultEndpoint;
        }

        public static GlobalSetting Instance
        {
            get { return _instance; }
        }

        public string ClientId { get { return "xamarin"; } }

        public string ClientSecret { get { return "secret"; } }

        public string AuthToken { get; }
        public string BaseEndpoint { get; }
    }
}

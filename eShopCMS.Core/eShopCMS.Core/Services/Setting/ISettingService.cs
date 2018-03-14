using System;
using System.Collections.Generic;
using System.Text;

namespace eShopCMS.Core.Services.Setting
{
    public interface ISettingService
    {
        string AuthAccessToken { get; set; }
        string AuthIdToken { get; set; }

    }
}

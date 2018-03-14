using eShopCMS.Core.Services.Dependency;

namespace eShopCMS.Core.Services.Setting
{
    public class SettingService : ISettingService
    {
        private readonly ISettingsServiceImplementation _settingsService;
        
        public SettingService(IDependencyService dependencyService)
        {
            _settingsService = dependencyService.Get<ISettingsServiceImplementation>();
        }


        ISettingsServiceImplementation AppSettings
        {
            get { return _settingsService; }
        }

        private const string AccessToken = "access_token";
        private const string IdToken = "id_token";
        private readonly string UrlBaseDefault = GlobalSetting.Instance.BaseEndpoint;
        private readonly string AccessTokenDefault = string.Empty;
        private readonly string IdTokenDefault = string.Empty;

        public string AuthAccessToken
        {
            get => AppSettings.GetValueOrDefault(AccessToken, AccessTokenDefault);
            set => AppSettings.AddOrUpdateValue(AccessToken, value);
        }

        public string AuthIdToken
        {
            get => AppSettings.GetValueOrDefault(IdToken, IdTokenDefault);
            set => AppSettings.AddOrUpdateValue(IdToken, value);
        }

        public bool GetValueOrDefault(string key, bool defaultValue)
        {
            throw new System.NotImplementedException();
        }

        public string GetValueOrDefault(string key, string defaultValue)
        {
            throw new System.NotImplementedException();
        }

        public bool AddOrUpdateValue(string key, bool value)
        {
            throw new System.NotImplementedException();
        }

        public bool AddOrUpdateValue(string key, string value)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new System.NotImplementedException();
        }

        public object GetValueOrDefault(string accessToken, object accessTokenDefault)
        {
            throw new System.NotImplementedException();
        }
    }
}

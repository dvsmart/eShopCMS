namespace eShopCMS.Core.Services.Setting
{
    public interface ISettingsServiceImplementation
    {
        bool GetValueOrDefault(string key, bool defaultValue);
        string GetValueOrDefault(string key, string defaultValue);

        bool AddOrUpdateValue(string key, bool value);
        bool AddOrUpdateValue(string key, string value);

        void Remove(string key);
        object GetValueOrDefault(string accessToken, object accessTokenDefault);
    }
}

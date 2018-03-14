using eShopCMS.Core.Validations;

namespace eShopCMS.Core.ViewModels
{
    internal class IsNotNullOrEmptyRule<T> : IValidationRule<string>
    {
        public string ValidationMessage { get; set; }

        public bool Check(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
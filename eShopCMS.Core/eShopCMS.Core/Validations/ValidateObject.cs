using eShopCMS.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eShopCMS.Core.Validations
{
    public class ValidateObject<T> : ExtendedBindableObject, IValidity
    {
        private readonly List<IValidationRule<T>> _validations;

        private T _value;

        private bool _isValid;
        private readonly List<string> _errors;

        public List<IValidationRule<T>> Validations => _validations;

        public List<string> Errors { get { return _errors; } set { Errors = value; RaisePropertyChanged(() => Errors); } }

        public ValidateObject()
        {
            _isValid = true;
            _errors = new List<string>();
            _validations = new List<IValidationRule<T>>();
        }

        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                RaisePropertyChanged(() => Value);
            }
        }

        public bool IsValid
        {
            get
            {
                return _isValid;
            }
            set
            {
                _isValid = value;
                RaisePropertyChanged(() => IsValid);
            }
        }

        

        public bool Validate()
        {
            Errors.Clear();

            IEnumerable<string> errors = _validations.Where(v => !v.Check(Value))
                .Select(v => v.ValidationMessage);

            Errors = errors.ToList();
            IsValid = !Errors.Any();

            return this.IsValid;
        }

    }

    public interface IValidity
    {
        bool IsValid { get; set; }
    }

    public interface IValidationRule<T>
    {
        string ValidationMessage { get; set; }

        bool Check(T value);
    }
}

using DesignPattern.Creational.Builder.Validation.Interfaces;
using DesignPattern.Creational.Builder.Validation.Result;
using System.Collections.Generic;


namespace DesignPattern.Creational.Builder.Validation
{
    public class Validator<TValidable>
         where TValidable : IValidable
    {
        private readonly List<IValidator<TValidable>> _validators;

        public Validator(List<IValidator<TValidable>> validators)
        {
            _validators = validators;
        }

        public List<ValidationResult> Validate(TValidable @object)
        {
            var result = new List<ValidationResult>();
            
                foreach (var validator in _validators)
                    result.Add(validator.Validate(@object));

            return result;
        }
    }
}

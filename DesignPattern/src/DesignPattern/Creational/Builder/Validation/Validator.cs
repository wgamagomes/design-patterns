using DesignPattern.Creational.Builder.Validation.Interfaces;
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
    }
}

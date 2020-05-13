using DesignPattern.Creational.Builder.Validation.Interfaces;
using System.Collections.Generic;

namespace DesignPattern.Creational.Builder.Validation
{
    public class ValidatorBuilder<TValidable>
        where TValidable: IValidable
    {
        private readonly List<IValidator<TValidable>> _validators;

        public ValidatorBuilder()
        {
            _validators = new List<IValidator<TValidable>>();
        }

        public static ValidatorBuilder<TValidable> Create()
        {
            return new ValidatorBuilder<TValidable>();
        }

        public ValidatorBuilder<TValidable> AddValidator(IValidator<TValidable> validator)
        {
            _validators.Add(validator);

            return this;
        }

        public Validator<TValidable> Build()
        {
            return new Validator<TValidable>(_validators);
        }
    }
}

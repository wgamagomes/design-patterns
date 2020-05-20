using DesignPattern.Creational.Builder.Validation.Result;

namespace DesignPattern.Creational.Builder.Validation.Interfaces
{
    public interface IValidator<TValidable>
         where TValidable : IValidable
    {
        ValidationResult Validate(TValidable @object);
    }
}

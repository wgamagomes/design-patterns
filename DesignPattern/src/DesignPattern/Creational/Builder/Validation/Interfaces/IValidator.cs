namespace DesignPattern.Creational.Builder.Validation.Interfaces
{
    public interface IValidator<TValidable>
         where TValidable : IValidable
    {
        void Validate(TValidable @object);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.Validation.Interfaces
{
    public interface IValidator<TValidable>
    {
        void Validate(TValidable @object);
    }
}

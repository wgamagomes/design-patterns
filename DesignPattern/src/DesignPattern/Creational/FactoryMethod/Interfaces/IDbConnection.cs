using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.FactoryMethod.Interfaces
{
    public interface IDbConnection
    {

        void Close();

        void Open();

        bool IsOpen { get;  }
    }
}

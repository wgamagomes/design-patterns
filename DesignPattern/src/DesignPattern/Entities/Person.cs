using System;

namespace DesignPattern.Entities
{
    public class Person : Entity
    {
        public string Name { get; set; }

        public DateTime Born { get; set; }
    }
}

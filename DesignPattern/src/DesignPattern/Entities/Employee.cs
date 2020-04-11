﻿namespace DesignPattern.Entities
{
    public class Employee : Person
    {
        public string Position { get; set; }
        public virtual double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}, Salary: {Salary}";
        }
    }
}

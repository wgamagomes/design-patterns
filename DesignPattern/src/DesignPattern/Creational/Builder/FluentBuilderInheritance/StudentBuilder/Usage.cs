using DesignPattern.Entities;
using System;

namespace DesignPattern.Creational.Builder.FluentBuilderInheritance.StudentBuilder
{
    public class Usage
    {
        static void Main()
        {
            Student studentSubClass = StudentBuilderDirector
                .NewBuilder()
                .WithHobby("hobby")
                .WithName("Peter")
                .WithBorn(DateTime.Now)
                .WithDegree("undergrad")
                .Build();

            GoldStudent goldStudentSubClass = GoldStudentBuilderDirector
                .NewBuilder()
                .WithHobby("hobby")
                .WithName("Peter")
                .WithBorn(DateTime.Now)
                .WithDegree("undergrad")
                .WithMedia(10.0f)
                .Build();

            Person studentSuperClass = StudentBuilderDirector
                .NewBuilder()
                .WithHobby("hobby")
                .WithName("Peter")
                .WithBorn(DateTime.Now)
                .WithDegree("undergrad")
                .Build();

            Person goldStudentSuperClass = GoldStudentBuilderDirector
                .NewBuilder()
                .WithHobby("hobby")
                .WithName("Peter")
                .WithBorn(DateTime.Now)
                .WithDegree("undergrad")
                .WithMedia(10.0f)
                .Build();

        }
    }
}

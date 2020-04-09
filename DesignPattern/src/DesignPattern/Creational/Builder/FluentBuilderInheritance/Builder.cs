using DesignPattern.Creational.Builder.FluentBuilderInheritance.GenericBuilder;
using DesignPattern.Entities;
using System;

namespace DesignPattern.Creational.Builder.FluentBuilderInheritance
{
    public class PersonBuilder<TBuilder, TEntity> : Builder<TBuilder, TEntity>
        where TBuilder : PersonBuilder<TBuilder, TEntity>, new()
        where TEntity : Person, new()
    {

        public TBuilder WithName(string name)
        {
            Entity.Name = name;
            return (TBuilder)this;
        }

        public TBuilder WithBorn(DateTime born)
        {
            Entity.Born = born;
            return (TBuilder)this;
        }

    }

    public class StudentBuilder<TBuilder, TEntity> : PersonBuilder<TBuilder, TEntity>
        where TBuilder : StudentBuilder<TBuilder, TEntity>, new()
        where TEntity : Student, new()
    {

        public TBuilder WithHobby(string hobby)
        {
            Entity.Hobby = hobby;
            return (TBuilder)this;
        }

        public TBuilder WithDegree(string degree)
        {
            Entity.Degree = degree;
            return (TBuilder)this;
        }
    }

    public class GoldStudentBuilder<TBuilder, TEntity> : StudentBuilder<TBuilder, TEntity>
    where TBuilder : GoldStudentBuilder<TBuilder, TEntity>, new()
    where TEntity : GoldStudent, new()
    {

        public TBuilder WithMedia(double media)
        {
            Entity.Media = media;
            return (TBuilder)this;
        }


    }

    public class StudentBuilderDirector : StudentBuilder<StudentBuilderDirector, Student>
    {

    }

    public class GoldStudentBuilderDirector : GoldStudentBuilder<GoldStudentBuilderDirector, GoldStudent>
    {

    }


    public class Test
    {
        static void Main()
        {
            Student student = StudentBuilderDirector
                .Create()
               .WithHobby("")
               .WithName("")
               .WithBorn(DateTime.Now)
               .WithDegree("")
               .Build();

            GoldStudent goldStudent = GoldStudentBuilderDirector
                .Create()
                .WithHobby("")
               .WithName("")
               .WithBorn(DateTime.Now)
               .WithDegree("")
               .WithMedia(10)
               .Build();

        }
    }
}

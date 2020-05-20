using DesignPattern.Creational.Builder.Validation;
using DesignPattern.Creational.Builder.Validation.Interfaces;
using DesignPattern.Creational.Builder.Validation.Result;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace DesignPattern.Test
{
    public class ValidatorBuilderTest
    {
        private readonly Validator<Validable> _validators;

        public ValidatorBuilderTest()
        {
            _validators = ValidatorBuilder<Validable>
                .Create()
                .AddValidator(new DescriptionIsEmptyValidator())
                .AddValidator(new DescriptionIsNullValidator())
                .AddValidator(new CountIsNullValidator())
                .AddValidator(new CountIsZeroValidator())
                .Build();
        }

        [Fact]
        public void ShouldDescriptionIsEmpty()
        {
            // arrange
            var obj = new Validable { Description = string.Empty, Count = 1 };

            // act 
            var result = _validators.Validate(obj);


            // expected
            var expected = new List<ValidationResult> { ValidationResult.GetFailure("Description is empty"),  ValidationResult.GetSuccess(), ValidationResult.GetSuccess(), ValidationResult.GetSuccess() };
            
            
            // assert
            result.Should().HaveCount(4);
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ShouldDescriptionIsNull()
        {
            //arrange
            var obj = new Validable { Description = null, Count = 1 };

            // act 
            var result = _validators.Validate(obj);


            // expected
            var expected = new List<ValidationResult> { ValidationResult.GetFailure("Description is empty"), ValidationResult.GetSuccess(), ValidationResult.GetSuccess() };


            // assert
            result.Should().HaveCount(4);
            result.Should().BeEquivalentTo(expected);


        }

        [Fact]
        public void ShouldCountIsNull()
        {
            //arrange
            var obj = new Validable { Description = "description", Count = null };

            // act 
            var result = _validators.Validate(obj);


            // expected
            var expected = new List<ValidationResult> { ValidationResult.GetFailure("Description is empty"), ValidationResult.GetSuccess(), ValidationResult.GetSuccess() };


            // assert
            result.Should().HaveCount(4);
            result.Should().BeEquivalentTo(expected);
        }



        [Fact]
        public void ShouldCountIsZero()
        {
            //arrange
            var obj = new Validable { Description = "description", Count = 0 };

            // act 
            var result = _validators.Validate(obj);


            // expected
            var expected = new List<ValidationResult> { ValidationResult.GetFailure("Description is empty"), ValidationResult.GetSuccess(), ValidationResult.GetSuccess() };


            // assert
            result.Should().HaveCount(4);
            result.Should().BeEquivalentTo(expected);

        }
    }


    public class Validable : IValidable
    {
        public string Description { get; set; }
        public int? Count { get; set; }
    }

    public class DescriptionIsEmptyValidator : IValidator<Validable>
    {
        public ValidationResult Validate(Validable @object)
        {
            if (@object.Description == string.Empty)
                return ValidationResult.GetFailure("Description is empty");

            return ValidationResult.GetSuccess();
        }
    }

    public class DescriptionIsNullValidator : IValidator<Validable>
    {
        public ValidationResult Validate(Validable @object)
        {
            if (@object.Description == null)
                return ValidationResult.GetFailure("Description is null");

            return ValidationResult.GetSuccess();
        }
    }

    public class CountIsNullValidator : IValidator<Validable>
    {
        public ValidationResult Validate(Validable @object)
        {
            if (@object.Count == null)
                return ValidationResult.GetFailure("Count is null");

            return ValidationResult.GetSuccess();
        }
    }

    public class CountIsZeroValidator : IValidator<Validable>
    {
        public ValidationResult Validate(Validable @object)
        {
            if (@object.Count == 0)
                return ValidationResult.GetFailure("Count is zero");

            return ValidationResult.GetSuccess();
        }
    }
}
﻿using System;
using UniForm.Core.Attributes;

namespace UniForm.Examples.Wpf.Models
{
    [UniForm("Animal Form", "An example of a UniForm form.", false)]
    public class ExampleConfigurationWithRootAttribute
    {
        [UniFormField("Animal Type", "Your favourite type of animal.")]
        public ExampleEnumOfAnimals AnimalType { get; set; }
        
        public int Count { get; set; } = 4;

        [UniFormField("Magic Number", "A Magic Number that must definitely not be 3.")]
        public int MagicNumber { get; set; } = 23;

        [UniFormField("Cat Name", "The name of your cat.")]
        public string CatName { get; set; } = "Barry";

        [UniFormField("Decimal", "This number must not be an integer.")]
        [UniFormFieldValidationMethod(nameof(EnsureIsDecimal))]
        public double SomeDecimal { get; set; } = 0.2;

        public static bool EnsureIsDecimal(double instanceValue)
        {
            var d = instanceValue;
            return  d - Math.Truncate(d) != 0;
        }

    }
}

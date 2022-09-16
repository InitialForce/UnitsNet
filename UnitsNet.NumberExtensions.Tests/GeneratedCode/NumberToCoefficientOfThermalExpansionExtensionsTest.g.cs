//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/OasysUnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnitsNet.

using OasysUnitsNet.NumberExtensions.NumberToCoefficientOfThermalExpansion;
using Xunit;

namespace OasysUnitsNet.Tests
{
    public class NumberToCoefficientOfThermalExpansionExtensionsTests
    {
        [Fact]
        public void NumberToInverseDegreeCelsiusTest() =>
            Assert.Equal(CoefficientOfThermalExpansion.FromInverseDegreeCelsius(2), 2.InverseDegreeCelsius());

        [Fact]
        public void NumberToInverseDegreeFahrenheitTest() =>
            Assert.Equal(CoefficientOfThermalExpansion.FromInverseDegreeFahrenheit(2), 2.InverseDegreeFahrenheit());

        [Fact]
        public void NumberToInverseKelvinTest() =>
            Assert.Equal(CoefficientOfThermalExpansion.FromInverseKelvin(2), 2.InverseKelvin());

    }
}

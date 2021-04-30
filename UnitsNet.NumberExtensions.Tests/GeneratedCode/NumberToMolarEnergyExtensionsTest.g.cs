﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.NumberExtensions.NumberToMolarEnergy;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToMolarEnergyExtensionsTests
    {
        [Fact]
        public void NumberToBritishThermalUnitsPerMoleTest() =>
            Assert.Equal(MolarEnergy.FromBritishThermalUnitsPerMole(2), 2.BritishThermalUnitsPerMole());

        [Fact]
        public void NumberToBritishThermalUnitsPerPoundMoleTest() =>
            Assert.Equal(MolarEnergy.FromBritishThermalUnitsPerPoundMole(2), 2.BritishThermalUnitsPerPoundMole());

        [Fact]
        public void NumberToBritishThermalUnitThermochemicalsPerMoleTest() =>
            Assert.Equal(MolarEnergy.FromBritishThermalUnitThermochemicalsPerMole(2), 2.BritishThermalUnitThermochemicalsPerMole());

        [Fact]
        public void NumberToBritishThermalUnitThermochemicalsPerPoundMoleTest() =>
            Assert.Equal(MolarEnergy.FromBritishThermalUnitThermochemicalsPerPoundMole(2), 2.BritishThermalUnitThermochemicalsPerPoundMole());

        [Fact]
        public void NumberToCaloriesPerMoleTest() =>
            Assert.Equal(MolarEnergy.FromCaloriesPerMole(2), 2.CaloriesPerMole());

        [Fact]
        public void NumberToCalorieThermochemicalsPerMoleTest() =>
            Assert.Equal(MolarEnergy.FromCalorieThermochemicalsPerMole(2), 2.CalorieThermochemicalsPerMole());

        [Fact]
        public void NumberToJoulesPerMoleTest() =>
            Assert.Equal(MolarEnergy.FromJoulesPerMole(2), 2.JoulesPerMole());

        [Fact]
        public void NumberToKilocaloriesPerMoleTest() =>
            Assert.Equal(MolarEnergy.FromKilocaloriesPerMole(2), 2.KilocaloriesPerMole());

        [Fact]
        public void NumberToKilocalorieThermochemicalsPerMoleTest() =>
            Assert.Equal(MolarEnergy.FromKilocalorieThermochemicalsPerMole(2), 2.KilocalorieThermochemicalsPerMole());

        [Fact]
        public void NumberToKilojoulesPerMoleTest() =>
            Assert.Equal(MolarEnergy.FromKilojoulesPerMole(2), 2.KilojoulesPerMole());

        [Fact]
        public void NumberToMegajoulesPerMoleTest() =>
            Assert.Equal(MolarEnergy.FromMegajoulesPerMole(2), 2.MegajoulesPerMole());

    }
}

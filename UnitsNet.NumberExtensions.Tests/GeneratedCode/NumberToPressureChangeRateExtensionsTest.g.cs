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

using UnitsNet.NumberExtensions.NumberToPressureChangeRate;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToPressureChangeRateExtensionsTests
    {
        [Fact]
        public void NumberToAtmospheresPerSecondTest() =>
            Assert.Equal(PressureChangeRate.FromAtmospheresPerSecond(2), 2.AtmospheresPerSecond());

        [Fact]
        public void NumberToBarsPerMinuteTest() =>
            Assert.Equal(PressureChangeRate.FromBarsPerMinute(2), 2.BarsPerMinute());

        [Fact]
        public void NumberToBarsPerSecondTest() =>
            Assert.Equal(PressureChangeRate.FromBarsPerSecond(2), 2.BarsPerSecond());

        [Fact]
        public void NumberToKilopascalsPerMinuteTest() =>
            Assert.Equal(PressureChangeRate.FromKilopascalsPerMinute(2), 2.KilopascalsPerMinute());

        [Fact]
        public void NumberToKilopascalsPerSecondTest() =>
            Assert.Equal(PressureChangeRate.FromKilopascalsPerSecond(2), 2.KilopascalsPerSecond());

        [Fact]
        public void NumberToMegapascalsPerMinuteTest() =>
            Assert.Equal(PressureChangeRate.FromMegapascalsPerMinute(2), 2.MegapascalsPerMinute());

        [Fact]
        public void NumberToMegapascalsPerSecondTest() =>
            Assert.Equal(PressureChangeRate.FromMegapascalsPerSecond(2), 2.MegapascalsPerSecond());

        [Fact]
        public void NumberToPascalsPerMinuteTest() =>
            Assert.Equal(PressureChangeRate.FromPascalsPerMinute(2), 2.PascalsPerMinute());

        [Fact]
        public void NumberToPascalsPerSecondTest() =>
            Assert.Equal(PressureChangeRate.FromPascalsPerSecond(2), 2.PascalsPerSecond());

        [Fact]
        public void NumberToPoundForcesPerSquareInchPerMinuteTest() =>
            Assert.Equal(PressureChangeRate.FromPoundForcesPerSquareInchPerMinute(2), 2.PoundForcesPerSquareInchPerMinute());

        [Fact]
        public void NumberToPoundForcesPerSquareInchPerSecondTest() =>
            Assert.Equal(PressureChangeRate.FromPoundForcesPerSquareInchPerSecond(2), 2.PoundForcesPerSquareInchPerSecond());

    }
}

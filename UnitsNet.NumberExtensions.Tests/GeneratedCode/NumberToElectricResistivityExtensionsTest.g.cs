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

using UnitsNet.NumberExtensions.NumberToElectricResistivity;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToElectricResistivityExtensionsTests
    {
        [Fact]
        public void NumberToKiloohmsCentimeterTest() =>
            Assert.Equal(ElectricResistivity.FromKiloohmsCentimeter(2), 2.KiloohmsCentimeter());

        [Fact]
        public void NumberToKiloohmMetersTest() =>
            Assert.Equal(ElectricResistivity.FromKiloohmMeters(2), 2.KiloohmMeters());

        [Fact]
        public void NumberToMegaohmsCentimeterTest() =>
            Assert.Equal(ElectricResistivity.FromMegaohmsCentimeter(2), 2.MegaohmsCentimeter());

        [Fact]
        public void NumberToMegaohmMetersTest() =>
            Assert.Equal(ElectricResistivity.FromMegaohmMeters(2), 2.MegaohmMeters());

        [Fact]
        public void NumberToMicroohmsCentimeterTest() =>
            Assert.Equal(ElectricResistivity.FromMicroohmsCentimeter(2), 2.MicroohmsCentimeter());

        [Fact]
        public void NumberToMicroohmMetersTest() =>
            Assert.Equal(ElectricResistivity.FromMicroohmMeters(2), 2.MicroohmMeters());

        [Fact]
        public void NumberToMilliohmsCentimeterTest() =>
            Assert.Equal(ElectricResistivity.FromMilliohmsCentimeter(2), 2.MilliohmsCentimeter());

        [Fact]
        public void NumberToMilliohmMetersTest() =>
            Assert.Equal(ElectricResistivity.FromMilliohmMeters(2), 2.MilliohmMeters());

        [Fact]
        public void NumberToNanoohmsCentimeterTest() =>
            Assert.Equal(ElectricResistivity.FromNanoohmsCentimeter(2), 2.NanoohmsCentimeter());

        [Fact]
        public void NumberToNanoohmMetersTest() =>
            Assert.Equal(ElectricResistivity.FromNanoohmMeters(2), 2.NanoohmMeters());

        [Fact]
        public void NumberToOhmsCentimeterTest() =>
            Assert.Equal(ElectricResistivity.FromOhmsCentimeter(2), 2.OhmsCentimeter());

        [Fact]
        public void NumberToOhmFeetTest() =>
            Assert.Equal(ElectricResistivity.FromOhmFeet(2), 2.OhmFeet());

        [Fact]
        public void NumberToOhmInchesTest() =>
            Assert.Equal(ElectricResistivity.FromOhmInches(2), 2.OhmInches());

        [Fact]
        public void NumberToOhmMetersTest() =>
            Assert.Equal(ElectricResistivity.FromOhmMeters(2), 2.OhmMeters());

        [Fact]
        public void NumberToPicoohmsCentimeterTest() =>
            Assert.Equal(ElectricResistivity.FromPicoohmsCentimeter(2), 2.PicoohmsCentimeter());

        [Fact]
        public void NumberToPicoohmMetersTest() =>
            Assert.Equal(ElectricResistivity.FromPicoohmMeters(2), 2.PicoohmMeters());

    }
}

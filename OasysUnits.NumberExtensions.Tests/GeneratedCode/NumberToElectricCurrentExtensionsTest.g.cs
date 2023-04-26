//------------------------------------------------------------------------------
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

using OasysUnits.NumberExtensions.NumberToElectricCurrent;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToElectricCurrentExtensionsTests
    {
        [Fact]
        public void NumberToAmperesTest() =>
            Assert.Equal(ElectricCurrent.FromAmperes(2), 2.Amperes());

        [Fact]
        public void NumberToCentiamperesTest() =>
            Assert.Equal(ElectricCurrent.FromCentiamperes(2), 2.Centiamperes());

        [Fact]
        public void NumberToFemtoamperesTest() =>
            Assert.Equal(ElectricCurrent.FromFemtoamperes(2), 2.Femtoamperes());

        [Fact]
        public void NumberToKiloamperesTest() =>
            Assert.Equal(ElectricCurrent.FromKiloamperes(2), 2.Kiloamperes());

        [Fact]
        public void NumberToMegaamperesTest() =>
            Assert.Equal(ElectricCurrent.FromMegaamperes(2), 2.Megaamperes());

        [Fact]
        public void NumberToMicroamperesTest() =>
            Assert.Equal(ElectricCurrent.FromMicroamperes(2), 2.Microamperes());

        [Fact]
        public void NumberToMilliamperesTest() =>
            Assert.Equal(ElectricCurrent.FromMilliamperes(2), 2.Milliamperes());

        [Fact]
        public void NumberToNanoamperesTest() =>
            Assert.Equal(ElectricCurrent.FromNanoamperes(2), 2.Nanoamperes());

        [Fact]
        public void NumberToPicoamperesTest() =>
            Assert.Equal(ElectricCurrent.FromPicoamperes(2), 2.Picoamperes());

    }
}

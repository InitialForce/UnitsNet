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

using OasysUnitsNet.NumberExtensions.NumberToMolarMass;
using Xunit;

namespace OasysUnitsNet.Tests
{
    public class NumberToMolarMassExtensionsTests
    {
        [Fact]
        public void NumberToCentigramsPerMoleTest() =>
            Assert.Equal(MolarMass.FromCentigramsPerMole(2), 2.CentigramsPerMole());

        [Fact]
        public void NumberToDecagramsPerMoleTest() =>
            Assert.Equal(MolarMass.FromDecagramsPerMole(2), 2.DecagramsPerMole());

        [Fact]
        public void NumberToDecigramsPerMoleTest() =>
            Assert.Equal(MolarMass.FromDecigramsPerMole(2), 2.DecigramsPerMole());

        [Fact]
        public void NumberToGramsPerMoleTest() =>
            Assert.Equal(MolarMass.FromGramsPerMole(2), 2.GramsPerMole());

        [Fact]
        public void NumberToHectogramsPerMoleTest() =>
            Assert.Equal(MolarMass.FromHectogramsPerMole(2), 2.HectogramsPerMole());

        [Fact]
        public void NumberToKilogramsPerMoleTest() =>
            Assert.Equal(MolarMass.FromKilogramsPerMole(2), 2.KilogramsPerMole());

        [Fact]
        public void NumberToKilopoundsPerMoleTest() =>
            Assert.Equal(MolarMass.FromKilopoundsPerMole(2), 2.KilopoundsPerMole());

        [Fact]
        public void NumberToMegapoundsPerMoleTest() =>
            Assert.Equal(MolarMass.FromMegapoundsPerMole(2), 2.MegapoundsPerMole());

        [Fact]
        public void NumberToMicrogramsPerMoleTest() =>
            Assert.Equal(MolarMass.FromMicrogramsPerMole(2), 2.MicrogramsPerMole());

        [Fact]
        public void NumberToMilligramsPerMoleTest() =>
            Assert.Equal(MolarMass.FromMilligramsPerMole(2), 2.MilligramsPerMole());

        [Fact]
        public void NumberToNanogramsPerMoleTest() =>
            Assert.Equal(MolarMass.FromNanogramsPerMole(2), 2.NanogramsPerMole());

        [Fact]
        public void NumberToPoundsPerMoleTest() =>
            Assert.Equal(MolarMass.FromPoundsPerMole(2), 2.PoundsPerMole());

    }
}

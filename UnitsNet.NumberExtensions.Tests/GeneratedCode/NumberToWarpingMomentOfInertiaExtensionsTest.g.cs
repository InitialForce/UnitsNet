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

using UnitsNet.NumberExtensions.NumberToWarpingMomentOfInertia;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToWarpingMomentOfInertiaExtensionsTests
    {
        [Fact]
        public void NumberToCentimetersToTheSixthTest() =>
            Assert.Equal(WarpingMomentOfInertia.FromCentimetersToTheSixth(2), 2.CentimetersToTheSixth());

        [Fact]
        public void NumberToDecimetersToTheSixthTest() =>
            Assert.Equal(WarpingMomentOfInertia.FromDecimetersToTheSixth(2), 2.DecimetersToTheSixth());

        [Fact]
        public void NumberToFeetToTheSixthTest() =>
            Assert.Equal(WarpingMomentOfInertia.FromFeetToTheSixth(2), 2.FeetToTheSixth());

        [Fact]
        public void NumberToInchesToTheSixthTest() =>
            Assert.Equal(WarpingMomentOfInertia.FromInchesToTheSixth(2), 2.InchesToTheSixth());

        [Fact]
        public void NumberToMetersToTheSixthTest() =>
            Assert.Equal(WarpingMomentOfInertia.FromMetersToTheSixth(2), 2.MetersToTheSixth());

        [Fact]
        public void NumberToMillimetersToTheSixthTest() =>
            Assert.Equal(WarpingMomentOfInertia.FromMillimetersToTheSixth(2), 2.MillimetersToTheSixth());

    }
}

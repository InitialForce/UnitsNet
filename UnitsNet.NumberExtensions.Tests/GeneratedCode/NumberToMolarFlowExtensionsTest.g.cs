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

using UnitsNet.NumberExtensions.NumberToMolarFlow;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToMolarFlowExtensionsTests
    {
        [Fact]
        public void NumberToKilomolesPerHourTest() =>
            Assert.Equal(MolarFlow.FromKilomolesPerHour(2), 2.KilomolesPerHour());

        [Fact]
        public void NumberToKilomolesPerMinuteTest() =>
            Assert.Equal(MolarFlow.FromKilomolesPerMinute(2), 2.KilomolesPerMinute());

        [Fact]
        public void NumberToKilomolesPerSecondTest() =>
            Assert.Equal(MolarFlow.FromKilomolesPerSecond(2), 2.KilomolesPerSecond());

        [Fact]
        public void NumberToPoundsMolePerHourTest() =>
            Assert.Equal(MolarFlow.FromPoundsMolePerHour(2), 2.PoundsMolePerHour());

        [Fact]
        public void NumberToPoundsMolePerMinuteTest() =>
            Assert.Equal(MolarFlow.FromPoundsMolePerMinute(2), 2.PoundsMolePerMinute());

        [Fact]
        public void NumberToPoundsMolePerSecondTest() =>
            Assert.Equal(MolarFlow.FromPoundsMolePerSecond(2), 2.PoundsMolePerSecond());

    }
}

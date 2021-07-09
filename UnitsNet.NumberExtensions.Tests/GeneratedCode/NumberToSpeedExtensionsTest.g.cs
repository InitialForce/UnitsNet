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

using UnitsNet.NumberExtensions.NumberToSpeed;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToSpeedExtensionsTests
    {
        [Fact]
        public void NumberToCentimetersPerHourTest() =>
            Assert.Equal(Speed.FromCentimetersPerHour(2), 2.CentimetersPerHour());

        [Fact]
        public void NumberToCentimetersPerMinutesTest() =>
            Assert.Equal(Speed.FromCentimetersPerMinutes(2), 2.CentimetersPerMinutes());

        [Fact]
        public void NumberToCentimetersPerSecondTest() =>
            Assert.Equal(Speed.FromCentimetersPerSecond(2), 2.CentimetersPerSecond());

        [Fact]
        public void NumberToDecimetersPerMinutesTest() =>
            Assert.Equal(Speed.FromDecimetersPerMinutes(2), 2.DecimetersPerMinutes());

        [Fact]
        public void NumberToDecimetersPerSecondTest() =>
            Assert.Equal(Speed.FromDecimetersPerSecond(2), 2.DecimetersPerSecond());

        [Fact]
        public void NumberToFeetPerHourTest() =>
            Assert.Equal(Speed.FromFeetPerHour(2), 2.FeetPerHour());

        [Fact]
        public void NumberToFeetPerMinuteTest() =>
            Assert.Equal(Speed.FromFeetPerMinute(2), 2.FeetPerMinute());

        [Fact]
        public void NumberToFeetPerSecondTest() =>
            Assert.Equal(Speed.FromFeetPerSecond(2), 2.FeetPerSecond());

        [Fact]
        public void NumberToInchesPerHourTest() =>
            Assert.Equal(Speed.FromInchesPerHour(2), 2.InchesPerHour());

        [Fact]
        public void NumberToInchesPerMinuteTest() =>
            Assert.Equal(Speed.FromInchesPerMinute(2), 2.InchesPerMinute());

        [Fact]
        public void NumberToInchesPerSecondTest() =>
            Assert.Equal(Speed.FromInchesPerSecond(2), 2.InchesPerSecond());

        [Fact]
        public void NumberToKilometersPerHourTest() =>
            Assert.Equal(Speed.FromKilometersPerHour(2), 2.KilometersPerHour());

        [Fact]
        public void NumberToKilometersPerMinutesTest() =>
            Assert.Equal(Speed.FromKilometersPerMinutes(2), 2.KilometersPerMinutes());

        [Fact]
        public void NumberToKilometersPerSecondTest() =>
            Assert.Equal(Speed.FromKilometersPerSecond(2), 2.KilometersPerSecond());

        [Fact]
        public void NumberToKnotsTest() =>
            Assert.Equal(Speed.FromKnots(2), 2.Knots());

        [Fact]
        public void NumberToMetersPerHourTest() =>
            Assert.Equal(Speed.FromMetersPerHour(2), 2.MetersPerHour());

        [Fact]
        public void NumberToMetersPerMinutesTest() =>
            Assert.Equal(Speed.FromMetersPerMinutes(2), 2.MetersPerMinutes());

        [Fact]
        public void NumberToMetersPerSecondTest() =>
            Assert.Equal(Speed.FromMetersPerSecond(2), 2.MetersPerSecond());

        [Fact]
        public void NumberToMicrometersPerMinutesTest() =>
            Assert.Equal(Speed.FromMicrometersPerMinutes(2), 2.MicrometersPerMinutes());

        [Fact]
        public void NumberToMicrometersPerSecondTest() =>
            Assert.Equal(Speed.FromMicrometersPerSecond(2), 2.MicrometersPerSecond());

        [Fact]
        public void NumberToMilesPerHourTest() =>
            Assert.Equal(Speed.FromMilesPerHour(2), 2.MilesPerHour());

        [Fact]
        public void NumberToMillimetersPerHourTest() =>
            Assert.Equal(Speed.FromMillimetersPerHour(2), 2.MillimetersPerHour());

        [Fact]
        public void NumberToMillimetersPerMinutesTest() =>
            Assert.Equal(Speed.FromMillimetersPerMinutes(2), 2.MillimetersPerMinutes());

        [Fact]
        public void NumberToMillimetersPerSecondTest() =>
            Assert.Equal(Speed.FromMillimetersPerSecond(2), 2.MillimetersPerSecond());

        [Fact]
        public void NumberToNanometersPerMinutesTest() =>
            Assert.Equal(Speed.FromNanometersPerMinutes(2), 2.NanometersPerMinutes());

        [Fact]
        public void NumberToNanometersPerSecondTest() =>
            Assert.Equal(Speed.FromNanometersPerSecond(2), 2.NanometersPerSecond());

        [Fact]
        public void NumberToUsSurveyFeetPerHourTest() =>
            Assert.Equal(Speed.FromUsSurveyFeetPerHour(2), 2.UsSurveyFeetPerHour());

        [Fact]
        public void NumberToUsSurveyFeetPerMinuteTest() =>
            Assert.Equal(Speed.FromUsSurveyFeetPerMinute(2), 2.UsSurveyFeetPerMinute());

        [Fact]
        public void NumberToUsSurveyFeetPerSecondTest() =>
            Assert.Equal(Speed.FromUsSurveyFeetPerSecond(2), 2.UsSurveyFeetPerSecond());

        [Fact]
        public void NumberToYardsPerHourTest() =>
            Assert.Equal(Speed.FromYardsPerHour(2), 2.YardsPerHour());

        [Fact]
        public void NumberToYardsPerMinuteTest() =>
            Assert.Equal(Speed.FromYardsPerMinute(2), 2.YardsPerMinute());

        [Fact]
        public void NumberToYardsPerSecondTest() =>
            Assert.Equal(Speed.FromYardsPerSecond(2), 2.YardsPerSecond());

    }
}

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

using UnitsNet.NumberExtensions.NumberToLength;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToLengthExtensionsTests
    {
        [Fact]
        public void NumberToAstronomicalUnitsTest() =>
            Assert.Equal(Length.FromAstronomicalUnits(2), 2.AstronomicalUnits());

        [Fact]
        public void NumberToBillionCubicFeetsPerAcreTest() =>
            Assert.Equal(Length.FromBillionCubicFeetsPerAcre(2), 2.BillionCubicFeetsPerAcre());

        [Fact]
        public void NumberToBillionCubicFeetsPerHundredAcresTest() =>
            Assert.Equal(Length.FromBillionCubicFeetsPerHundredAcres(2), 2.BillionCubicFeetsPerHundredAcres());

        [Fact]
        public void NumberToBillionCubicFeetsPerSectionTest() =>
            Assert.Equal(Length.FromBillionCubicFeetsPerSection(2), 2.BillionCubicFeetsPerSection());

        [Fact]
        public void NumberToBritishChainSearsOne9TwoTwosTest() =>
            Assert.Equal(Length.FromBritishChainSearsOne9TwoTwos(2), 2.BritishChainSearsOne9TwoTwos());

        [Fact]
        public void NumberToBritishChainSearsOne9TwoTwoTruncatedsTest() =>
            Assert.Equal(Length.FromBritishChainSearsOne9TwoTwoTruncateds(2), 2.BritishChainSearsOne9TwoTwoTruncateds());

        [Fact]
        public void NumberToBritishFootSearsOne9TwoTwosTest() =>
            Assert.Equal(Length.FromBritishFootSearsOne9TwoTwos(2), 2.BritishFootSearsOne9TwoTwos());

        [Fact]
        public void NumberToBritishYardSearsOne9TwoTwosTest() =>
            Assert.Equal(Length.FromBritishYardSearsOne9TwoTwos(2), 2.BritishYardSearsOne9TwoTwos());

        [Fact]
        public void NumberToBritishYardSearsOne9TwoTwoTruncatedsTest() =>
            Assert.Equal(Length.FromBritishYardSearsOne9TwoTwoTruncateds(2), 2.BritishYardSearsOne9TwoTwoTruncateds());

        [Fact]
        public void NumberToCentimetersTest() =>
            Assert.Equal(Length.FromCentimeters(2), 2.Centimeters());

        [Fact]
        public void NumberToChainsTest() =>
            Assert.Equal(Length.FromChains(2), 2.Chains());

        [Fact]
        public void NumberToClarkesFeetTest() =>
            Assert.Equal(Length.FromClarkesFeet(2), 2.ClarkesFeet());

        [Fact]
        public void NumberToClarkesLinksTest() =>
            Assert.Equal(Length.FromClarkesLinks(2), 2.ClarkesLinks());

        [Fact]
        public void NumberToClarkesYardsTest() =>
            Assert.Equal(Length.FromClarkesYards(2), 2.ClarkesYards());

        [Fact]
        public void NumberToCubicFeetPerSquareFootTest() =>
            Assert.Equal(Length.FromCubicFeetPerSquareFoot(2), 2.CubicFeetPerSquareFoot());

        [Fact]
        public void NumberToCubicMetersPerSquareMeterTest() =>
            Assert.Equal(Length.FromCubicMetersPerSquareMeter(2), 2.CubicMetersPerSquareMeter());

        [Fact]
        public void NumberToDecimetersTest() =>
            Assert.Equal(Length.FromDecimeters(2), 2.Decimeters());

        [Fact]
        public void NumberToDtpPicasTest() =>
            Assert.Equal(Length.FromDtpPicas(2), 2.DtpPicas());

        [Fact]
        public void NumberToDtpPointsTest() =>
            Assert.Equal(Length.FromDtpPoints(2), 2.DtpPoints());

        [Fact]
        public void NumberToFathomsTest() =>
            Assert.Equal(Length.FromFathoms(2), 2.Fathoms());

        [Fact]
        public void NumberToFeetTest() =>
            Assert.Equal(Length.FromFeet(2), 2.Feet());

        [Fact]
        public void NumberToGermanLegalMetersTest() =>
            Assert.Equal(Length.FromGermanLegalMeters(2), 2.GermanLegalMeters());

        [Fact]
        public void NumberToGoldCoastFeetTest() =>
            Assert.Equal(Length.FromGoldCoastFeet(2), 2.GoldCoastFeet());

        [Fact]
        public void NumberToHandsTest() =>
            Assert.Equal(Length.FromHands(2), 2.Hands());

        [Fact]
        public void NumberToHectometersTest() =>
            Assert.Equal(Length.FromHectometers(2), 2.Hectometers());

        [Fact]
        public void NumberToInchesTest() =>
            Assert.Equal(Length.FromInches(2), 2.Inches());

        [Fact]
        public void NumberToInchBy3TwosTest() =>
            Assert.Equal(Length.FromInchBy3Twos(2), 2.InchBy3Twos());

        [Fact]
        public void NumberToIndianYardsTest() =>
            Assert.Equal(Length.FromIndianYards(2), 2.IndianYards());

        [Fact]
        public void NumberToKilolightYearsTest() =>
            Assert.Equal(Length.FromKilolightYears(2), 2.KilolightYears());

        [Fact]
        public void NumberToKilometersTest() =>
            Assert.Equal(Length.FromKilometers(2), 2.Kilometers());

        [Fact]
        public void NumberToKiloparsecsTest() =>
            Assert.Equal(Length.FromKiloparsecs(2), 2.Kiloparsecs());

        [Fact]
        public void NumberToLightYearsTest() =>
            Assert.Equal(Length.FromLightYears(2), 2.LightYears());

        [Fact]
        public void NumberToLinksTest() =>
            Assert.Equal(Length.FromLinks(2), 2.Links());

        [Fact]
        public void NumberToMegalightYearsTest() =>
            Assert.Equal(Length.FromMegalightYears(2), 2.MegalightYears());

        [Fact]
        public void NumberToMegaparsecsTest() =>
            Assert.Equal(Length.FromMegaparsecs(2), 2.Megaparsecs());

        [Fact]
        public void NumberToMetersTest() =>
            Assert.Equal(Length.FromMeters(2), 2.Meters());

        [Fact]
        public void NumberToMicroinchesTest() =>
            Assert.Equal(Length.FromMicroinches(2), 2.Microinches());

        [Fact]
        public void NumberToMicrometersTest() =>
            Assert.Equal(Length.FromMicrometers(2), 2.Micrometers());

        [Fact]
        public void NumberToMilsTest() =>
            Assert.Equal(Length.FromMils(2), 2.Mils());

        [Fact]
        public void NumberToMilesTest() =>
            Assert.Equal(Length.FromMiles(2), 2.Miles());

        [Fact]
        public void NumberToMillimetersTest() =>
            Assert.Equal(Length.FromMillimeters(2), 2.Millimeters());

        [Fact]
        public void NumberToMillionBarrelsPerAcreTest() =>
            Assert.Equal(Length.FromMillionBarrelsPerAcre(2), 2.MillionBarrelsPerAcre());

        [Fact]
        public void NumberToMillionBarrelsPerSectionTest() =>
            Assert.Equal(Length.FromMillionBarrelsPerSection(2), 2.MillionBarrelsPerSection());

        [Fact]
        public void NumberToMillionBarrelsPerSquareKilometerTest() =>
            Assert.Equal(Length.FromMillionBarrelsPerSquareKilometer(2), 2.MillionBarrelsPerSquareKilometer());

        [Fact]
        public void NumberToMillionCubicFeetsPerAcreTest() =>
            Assert.Equal(Length.FromMillionCubicFeetsPerAcre(2), 2.MillionCubicFeetsPerAcre());

        [Fact]
        public void NumberToMillionCubicFeetsPerSectionTest() =>
            Assert.Equal(Length.FromMillionCubicFeetsPerSection(2), 2.MillionCubicFeetsPerSection());

        [Fact]
        public void NumberToMillionCubicFeetsPerSquareKilometerTest() =>
            Assert.Equal(Length.FromMillionCubicFeetsPerSquareKilometer(2), 2.MillionCubicFeetsPerSquareKilometer());

        [Fact]
        public void NumberToNanometersTest() =>
            Assert.Equal(Length.FromNanometers(2), 2.Nanometers());

        [Fact]
        public void NumberToNauticalMilesTest() =>
            Assert.Equal(Length.FromNauticalMiles(2), 2.NauticalMiles());

        [Fact]
        public void NumberToParsecsTest() =>
            Assert.Equal(Length.FromParsecs(2), 2.Parsecs());

        [Fact]
        public void NumberToPrinterPicasTest() =>
            Assert.Equal(Length.FromPrinterPicas(2), 2.PrinterPicas());

        [Fact]
        public void NumberToPrinterPointsTest() =>
            Assert.Equal(Length.FromPrinterPoints(2), 2.PrinterPoints());

        [Fact]
        public void NumberToShacklesTest() =>
            Assert.Equal(Length.FromShackles(2), 2.Shackles());

        [Fact]
        public void NumberToSolarRadiusesTest() =>
            Assert.Equal(Length.FromSolarRadiuses(2), 2.SolarRadiuses());

        [Fact]
        public void NumberToThousandBarrelsPerAcreTest() =>
            Assert.Equal(Length.FromThousandBarrelsPerAcre(2), 2.ThousandBarrelsPerAcre());

        [Fact]
        public void NumberToThousandBarrelsPerSquareKilometerTest() =>
            Assert.Equal(Length.FromThousandBarrelsPerSquareKilometer(2), 2.ThousandBarrelsPerSquareKilometer());

        [Fact]
        public void NumberToThousandCubicFeetsPerAcreTest() =>
            Assert.Equal(Length.FromThousandCubicFeetsPerAcre(2), 2.ThousandCubicFeetsPerAcre());

        [Fact]
        public void NumberToThousandCubicFeetsPerSquareKilometerTest() =>
            Assert.Equal(Length.FromThousandCubicFeetsPerSquareKilometer(2), 2.ThousandCubicFeetsPerSquareKilometer());

        [Fact]
        public void NumberToTwipsTest() =>
            Assert.Equal(Length.FromTwips(2), 2.Twips());

        [Fact]
        public void NumberToUsSurveyFeetTest() =>
            Assert.Equal(Length.FromUsSurveyFeet(2), 2.UsSurveyFeet());

        [Fact]
        public void NumberToYardsTest() =>
            Assert.Equal(Length.FromYards(2), 2.Yards());

    }
}

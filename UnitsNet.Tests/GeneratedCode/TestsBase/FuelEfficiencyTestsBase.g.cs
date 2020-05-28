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

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of FuelEfficiency.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class FuelEfficiencyTestsBase
    {
        protected abstract double KilometersPerLitersInOneLiterPer100Kilometers { get; }
        protected abstract double LitersPer100KilometersInOneLiterPer100Kilometers { get; }
        protected abstract double MilesPerUkGallonInOneLiterPer100Kilometers { get; }
        protected abstract double MilesPerUsGallonInOneLiterPer100Kilometers { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilometersPerLitersTolerance { get { return 1e-5; } }
        protected virtual double LitersPer100KilometersTolerance { get { return 1e-5; } }
        protected virtual double MilesPerUkGallonTolerance { get { return 1e-5; } }
        protected virtual double MilesPerUsGallonTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new FuelEfficiency((double)0.0, FuelEfficiencyUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new FuelEfficiency();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(FuelEfficiencyUnit.LiterPer100Kilometers, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new FuelEfficiency(double.PositiveInfinity, FuelEfficiencyUnit.LiterPer100Kilometers));
            Assert.Throws<ArgumentException>(() => new FuelEfficiency(double.NegativeInfinity, FuelEfficiencyUnit.LiterPer100Kilometers));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new FuelEfficiency(double.NaN, FuelEfficiencyUnit.LiterPer100Kilometers));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new FuelEfficiency(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void FuelEfficiency_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new FuelEfficiency(1, FuelEfficiencyUnit.LiterPer100Kilometers);

            QuantityInfo<FuelEfficiencyUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(FuelEfficiency.Zero, quantityInfo.Zero);
            Assert.Equal("FuelEfficiency", quantityInfo.Name);
            Assert.Equal(QuantityType.FuelEfficiency, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<FuelEfficiencyUnit>().Except(new[] {FuelEfficiencyUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void LiterPer100KilometersToFuelEfficiencyUnits()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            AssertEx.EqualTolerance(KilometersPerLitersInOneLiterPer100Kilometers, literper100kilometers.KilometersPerLiters, KilometersPerLitersTolerance);
            AssertEx.EqualTolerance(LitersPer100KilometersInOneLiterPer100Kilometers, literper100kilometers.LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(MilesPerUkGallonInOneLiterPer100Kilometers, literper100kilometers.MilesPerUkGallon, MilesPerUkGallonTolerance);
            AssertEx.EqualTolerance(MilesPerUsGallonInOneLiterPer100Kilometers, literper100kilometers.MilesPerUsGallon, MilesPerUsGallonTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = FuelEfficiency.From(1, FuelEfficiencyUnit.KilometerPerLiter);
            AssertEx.EqualTolerance(1, quantity00.KilometersPerLiters, KilometersPerLitersTolerance);
            Assert.Equal(FuelEfficiencyUnit.KilometerPerLiter, quantity00.Unit);

            var quantity01 = FuelEfficiency.From(1, FuelEfficiencyUnit.LiterPer100Kilometers);
            AssertEx.EqualTolerance(1, quantity01.LitersPer100Kilometers, LitersPer100KilometersTolerance);
            Assert.Equal(FuelEfficiencyUnit.LiterPer100Kilometers, quantity01.Unit);

            var quantity02 = FuelEfficiency.From(1, FuelEfficiencyUnit.MilePerUkGallon);
            AssertEx.EqualTolerance(1, quantity02.MilesPerUkGallon, MilesPerUkGallonTolerance);
            Assert.Equal(FuelEfficiencyUnit.MilePerUkGallon, quantity02.Unit);

            var quantity03 = FuelEfficiency.From(1, FuelEfficiencyUnit.MilePerUsGallon);
            AssertEx.EqualTolerance(1, quantity03.MilesPerUsGallon, MilesPerUsGallonTolerance);
            Assert.Equal(FuelEfficiencyUnit.MilePerUsGallon, quantity03.Unit);

        }

        [Fact]
        public void FromLitersPer100Kilometers_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FuelEfficiency.FromLitersPer100Kilometers(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => FuelEfficiency.FromLitersPer100Kilometers(double.NegativeInfinity));
        }

        [Fact]
        public void FromLitersPer100Kilometers_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FuelEfficiency.FromLitersPer100Kilometers(double.NaN));
        }

        [Fact]
        public void As()
        {
            var literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            AssertEx.EqualTolerance(KilometersPerLitersInOneLiterPer100Kilometers, literper100kilometers.As(FuelEfficiencyUnit.KilometerPerLiter), KilometersPerLitersTolerance);
            AssertEx.EqualTolerance(LitersPer100KilometersInOneLiterPer100Kilometers, literper100kilometers.As(FuelEfficiencyUnit.LiterPer100Kilometers), LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(MilesPerUkGallonInOneLiterPer100Kilometers, literper100kilometers.As(FuelEfficiencyUnit.MilePerUkGallon), MilesPerUkGallonTolerance);
            AssertEx.EqualTolerance(MilesPerUsGallonInOneLiterPer100Kilometers, literper100kilometers.As(FuelEfficiencyUnit.MilePerUsGallon), MilesPerUsGallonTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);

            var kilometerperliterQuantity = literper100kilometers.ToUnit(FuelEfficiencyUnit.KilometerPerLiter);
            AssertEx.EqualTolerance(KilometersPerLitersInOneLiterPer100Kilometers, (double)kilometerperliterQuantity.Value, KilometersPerLitersTolerance);
            Assert.Equal(FuelEfficiencyUnit.KilometerPerLiter, kilometerperliterQuantity.Unit);

            var literper100kilometersQuantity = literper100kilometers.ToUnit(FuelEfficiencyUnit.LiterPer100Kilometers);
            AssertEx.EqualTolerance(LitersPer100KilometersInOneLiterPer100Kilometers, (double)literper100kilometersQuantity.Value, LitersPer100KilometersTolerance);
            Assert.Equal(FuelEfficiencyUnit.LiterPer100Kilometers, literper100kilometersQuantity.Unit);

            var mileperukgallonQuantity = literper100kilometers.ToUnit(FuelEfficiencyUnit.MilePerUkGallon);
            AssertEx.EqualTolerance(MilesPerUkGallonInOneLiterPer100Kilometers, (double)mileperukgallonQuantity.Value, MilesPerUkGallonTolerance);
            Assert.Equal(FuelEfficiencyUnit.MilePerUkGallon, mileperukgallonQuantity.Unit);

            var mileperusgallonQuantity = literper100kilometers.ToUnit(FuelEfficiencyUnit.MilePerUsGallon);
            AssertEx.EqualTolerance(MilesPerUsGallonInOneLiterPer100Kilometers, (double)mileperusgallonQuantity.Value, MilesPerUsGallonTolerance);
            Assert.Equal(FuelEfficiencyUnit.MilePerUsGallon, mileperusgallonQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            AssertEx.EqualTolerance(1, FuelEfficiency.FromKilometersPerLiters(literper100kilometers.KilometersPerLiters).LitersPer100Kilometers, KilometersPerLitersTolerance);
            AssertEx.EqualTolerance(1, FuelEfficiency.FromLitersPer100Kilometers(literper100kilometers.LitersPer100Kilometers).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(1, FuelEfficiency.FromMilesPerUkGallon(literper100kilometers.MilesPerUkGallon).LitersPer100Kilometers, MilesPerUkGallonTolerance);
            AssertEx.EqualTolerance(1, FuelEfficiency.FromMilesPerUsGallon(literper100kilometers.MilesPerUsGallon).LitersPer100Kilometers, MilesPerUsGallonTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            FuelEfficiency v = FuelEfficiency.FromLitersPer100Kilometers(1);
            AssertEx.EqualTolerance(-1, -v.LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(2, (FuelEfficiency.FromLitersPer100Kilometers(3)-v).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(2, (v + v).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(10, (v*10).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(10, (10*v).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(2, (FuelEfficiency.FromLitersPer100Kilometers(10)/5).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(2, FuelEfficiency.FromLitersPer100Kilometers(10)/FuelEfficiency.FromLitersPer100Kilometers(5), LitersPer100KilometersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            FuelEfficiency oneLiterPer100Kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            FuelEfficiency twoLitersPer100Kilometers = FuelEfficiency.FromLitersPer100Kilometers(2);

            Assert.True(oneLiterPer100Kilometers < twoLitersPer100Kilometers);
            Assert.True(oneLiterPer100Kilometers <= twoLitersPer100Kilometers);
            Assert.True(twoLitersPer100Kilometers > oneLiterPer100Kilometers);
            Assert.True(twoLitersPer100Kilometers >= oneLiterPer100Kilometers);

            Assert.False(oneLiterPer100Kilometers > twoLitersPer100Kilometers);
            Assert.False(oneLiterPer100Kilometers >= twoLitersPer100Kilometers);
            Assert.False(twoLitersPer100Kilometers < oneLiterPer100Kilometers);
            Assert.False(twoLitersPer100Kilometers <= oneLiterPer100Kilometers);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.Equal(0, literper100kilometers.CompareTo(literper100kilometers));
            Assert.True(literper100kilometers.CompareTo(FuelEfficiency.Zero) > 0);
            Assert.True(FuelEfficiency.Zero.CompareTo(literper100kilometers) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.Throws<ArgumentException>(() => literper100kilometers.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.Throws<ArgumentNullException>(() => literper100kilometers.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = FuelEfficiency.FromLitersPer100Kilometers(1);
            var b = FuelEfficiency.FromLitersPer100Kilometers(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = FuelEfficiency.FromLitersPer100Kilometers(1);
            var b = FuelEfficiency.FromLitersPer100Kilometers(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.True(v.Equals(FuelEfficiency.FromLitersPer100Kilometers(1), LitersPer100KilometersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(FuelEfficiency.Zero, LitersPer100KilometersTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.False(literper100kilometers.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.False(literper100kilometers.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(FuelEfficiencyUnit.Undefined, FuelEfficiency.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(FuelEfficiencyUnit)).Cast<FuelEfficiencyUnit>();
            foreach(var unit in units)
            {
                if(unit == FuelEfficiencyUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(FuelEfficiency.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 km/L", new FuelEfficiency(1, FuelEfficiencyUnit.KilometerPerLiter).ToString());
                Assert.Equal("1 L/100km", new FuelEfficiency(1, FuelEfficiencyUnit.LiterPer100Kilometers).ToString());
                Assert.Equal("1 mpg (imp.)", new FuelEfficiency(1, FuelEfficiencyUnit.MilePerUkGallon).ToString());
                Assert.Equal("1 mpg (U.S.)", new FuelEfficiency(1, FuelEfficiencyUnit.MilePerUsGallon).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 km/L", new FuelEfficiency(1, FuelEfficiencyUnit.KilometerPerLiter).ToString(swedishCulture));
            Assert.Equal("1 L/100km", new FuelEfficiency(1, FuelEfficiencyUnit.LiterPer100Kilometers).ToString(swedishCulture));
            Assert.Equal("1 mpg (imp.)", new FuelEfficiency(1, FuelEfficiencyUnit.MilePerUkGallon).ToString(swedishCulture));
            Assert.Equal("1 mpg (U.S.)", new FuelEfficiency(1, FuelEfficiencyUnit.MilePerUsGallon).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 L/100km", new FuelEfficiency(0.123456, FuelEfficiencyUnit.LiterPer100Kilometers).ToString("s1"));
                Assert.Equal("0.12 L/100km", new FuelEfficiency(0.123456, FuelEfficiencyUnit.LiterPer100Kilometers).ToString("s2"));
                Assert.Equal("0.123 L/100km", new FuelEfficiency(0.123456, FuelEfficiencyUnit.LiterPer100Kilometers).ToString("s3"));
                Assert.Equal("0.1235 L/100km", new FuelEfficiency(0.123456, FuelEfficiencyUnit.LiterPer100Kilometers).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 L/100km", new FuelEfficiency(0.123456, FuelEfficiencyUnit.LiterPer100Kilometers).ToString("s1", culture));
            Assert.Equal("0.12 L/100km", new FuelEfficiency(0.123456, FuelEfficiencyUnit.LiterPer100Kilometers).ToString("s2", culture));
            Assert.Equal("0.123 L/100km", new FuelEfficiency(0.123456, FuelEfficiencyUnit.LiterPer100Kilometers).ToString("s3", culture));
            Assert.Equal("0.1235 L/100km", new FuelEfficiency(0.123456, FuelEfficiencyUnit.LiterPer100Kilometers).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(FuelEfficiency)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(FuelEfficiencyUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal(QuantityType.FuelEfficiency, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Equal(FuelEfficiency.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = FuelEfficiency.FromLitersPer100Kilometers(value);
            Assert.Equal(FuelEfficiency.FromLitersPer100Kilometers(-value), -quantity);
        }

    }
}

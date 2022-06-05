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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of AreaDensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AreaDensityTestsBase : QuantityTestsBase
    {
        protected abstract double KilogramsPerSquareMeterInOneKilogramPerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilogramsPerSquareMeterTolerance { get { return 1E-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(AreaDensityUnit unit)
        {
            return unit switch
            {
                AreaDensityUnit.KilogramPerSquareMeter => (KilogramsPerSquareMeterInOneKilogramPerSquareMeter, KilogramsPerSquareMeterTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { AreaDensityUnit.KilogramPerSquareMeter },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new AreaDensity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(AreaDensityUnit.KilogramPerSquareMeter, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AreaDensity(double.PositiveInfinity, AreaDensityUnit.KilogramPerSquareMeter));
            Assert.Throws<ArgumentException>(() => new AreaDensity(double.NegativeInfinity, AreaDensityUnit.KilogramPerSquareMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AreaDensity(double.NaN, AreaDensityUnit.KilogramPerSquareMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new AreaDensity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new AreaDensity(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (AreaDensity) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void AreaDensity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new AreaDensity(1, AreaDensityUnit.KilogramPerSquareMeter);

            QuantityInfo<AreaDensityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(AreaDensity.Zero, quantityInfo.Zero);
            Assert.Equal("AreaDensity", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<AreaDensityUnit>().ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void KilogramPerSquareMeterToAreaDensityUnits()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            AssertEx.EqualTolerance(KilogramsPerSquareMeterInOneKilogramPerSquareMeter, kilogrampersquaremeter.KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = AreaDensity.From(1, AreaDensityUnit.KilogramPerSquareMeter);
            AssertEx.EqualTolerance(1, quantity00.KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            Assert.Equal(AreaDensityUnit.KilogramPerSquareMeter, quantity00.Unit);

        }

        [Fact]
        public void FromKilogramsPerSquareMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AreaDensity.FromKilogramsPerSquareMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => AreaDensity.FromKilogramsPerSquareMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromKilogramsPerSquareMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AreaDensity.FromKilogramsPerSquareMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            AssertEx.EqualTolerance(KilogramsPerSquareMeterInOneKilogramPerSquareMeter, kilogrampersquaremeter.As(AreaDensityUnit.KilogramPerSquareMeter), KilogramsPerSquareMeterTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new AreaDensity(value: 1, unit: AreaDensity.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = AreaDensity.Parse("1 kg/m²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
                Assert.Equal(AreaDensityUnit.KilogramPerSquareMeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(AreaDensity.TryParse("1 kg/m²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
                Assert.Equal(AreaDensityUnit.KilogramPerSquareMeter, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = AreaDensity.ParseUnit("kg/m²", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(AreaDensityUnit.KilogramPerSquareMeter, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(AreaDensity.TryParseUnit("kg/m²", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(AreaDensityUnit.KilogramPerSquareMeter, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(AreaDensityUnit unit)
        {
            var inBaseUnits = AreaDensity.From(1.0, AreaDensity.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(AreaDensityUnit unit)
        {
            var quantity = AreaDensity.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(AreaDensityUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = AreaDensity.Units.FirstOrDefault(u => u != AreaDensity.BaseUnit);

            var quantity = AreaDensity.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            AssertEx.EqualTolerance(1, AreaDensity.FromKilogramsPerSquareMeter(kilogrampersquaremeter.KilogramsPerSquareMeter).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            AreaDensity v = AreaDensity.FromKilogramsPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (AreaDensity.FromKilogramsPerSquareMeter(3)-v).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (AreaDensity.FromKilogramsPerSquareMeter(10)/5).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, AreaDensity.FromKilogramsPerSquareMeter(10)/AreaDensity.FromKilogramsPerSquareMeter(5), KilogramsPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            AreaDensity oneKilogramPerSquareMeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            AreaDensity twoKilogramsPerSquareMeter = AreaDensity.FromKilogramsPerSquareMeter(2);

            Assert.True(oneKilogramPerSquareMeter < twoKilogramsPerSquareMeter);
            Assert.True(oneKilogramPerSquareMeter <= twoKilogramsPerSquareMeter);
            Assert.True(twoKilogramsPerSquareMeter > oneKilogramPerSquareMeter);
            Assert.True(twoKilogramsPerSquareMeter >= oneKilogramPerSquareMeter);

            Assert.False(oneKilogramPerSquareMeter > twoKilogramsPerSquareMeter);
            Assert.False(oneKilogramPerSquareMeter >= twoKilogramsPerSquareMeter);
            Assert.False(twoKilogramsPerSquareMeter < oneKilogramPerSquareMeter);
            Assert.False(twoKilogramsPerSquareMeter <= oneKilogramPerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.Equal(0, kilogrampersquaremeter.CompareTo(kilogrampersquaremeter));
            Assert.True(kilogrampersquaremeter.CompareTo(AreaDensity.Zero) > 0);
            Assert.True(AreaDensity.Zero.CompareTo(kilogrampersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => kilogrampersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => kilogrampersquaremeter.CompareTo(null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.True(v.Equals(AreaDensity.FromKilogramsPerSquareMeter(1), KilogramsPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(AreaDensity.Zero, KilogramsPerSquareMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(AreaDensity.FromKilogramsPerSquareMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.False(kilogrampersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.False(kilogrampersquaremeter.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AreaDensityUnit)).Cast<AreaDensityUnit>();
            foreach(var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(AreaDensity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 kg/m²", new AreaDensity(1, AreaDensityUnit.KilogramPerSquareMeter).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 kg/m²", new AreaDensity(1, AreaDensityUnit.KilogramPerSquareMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s1"));
                Assert.Equal("0.12 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s2"));
                Assert.Equal("0.123 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s3"));
                Assert.Equal("0.1235 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s1", culture));
            Assert.Equal("0.12 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s2", culture));
            Assert.Equal("0.123 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s3", culture));
            Assert.Equal("0.1235 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(AreaDensity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(AreaDensityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal(AreaDensity.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal(AreaDensity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal(new {AreaDensity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(value);
            Assert.Equal(AreaDensity.FromKilogramsPerSquareMeter(-value), -quantity);
        }
    }
}

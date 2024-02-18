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
    /// Test of SolidAngle.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SolidAngleTestsBase : QuantityTestsBase
    {
        protected abstract double SteradiansInOneSteradian { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double SteradiansTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(SolidAngleUnit unit)
        {
            return unit switch
            {
                SolidAngleUnit.Steradian => (SteradiansInOneSteradian, SteradiansTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { SolidAngleUnit.Steradian },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new SolidAngle();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(SolidAngleUnit.Steradian, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new SolidAngle(double.PositiveInfinity, SolidAngleUnit.Steradian));
            var exception2 = Record.Exception(() => new SolidAngle(double.NegativeInfinity, SolidAngleUnit.Steradian));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new SolidAngle(double.NaN, SolidAngleUnit.Steradian));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new SolidAngle(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new SolidAngle(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (SolidAngle) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void SolidAngle_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new SolidAngle(1, SolidAngleUnit.Steradian);

            QuantityInfo<SolidAngleUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(SolidAngle.Zero, quantityInfo.Zero);
            Assert.Equal("SolidAngle", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<SolidAngleUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void SteradianToSolidAngleUnits()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            AssertEx.EqualTolerance(SteradiansInOneSteradian, steradian.Steradians, SteradiansTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = SolidAngle.From(1, SolidAngleUnit.Steradian);
            AssertEx.EqualTolerance(1, quantity00.Steradians, SteradiansTolerance);
            Assert.Equal(SolidAngleUnit.Steradian, quantity00.Unit);

        }

        [Fact]
        public void FromSteradians_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => SolidAngle.FromSteradians(double.PositiveInfinity));
            var exception2 = Record.Exception(() => SolidAngle.FromSteradians(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromSteradians_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => SolidAngle.FromSteradians(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var steradian = SolidAngle.FromSteradians(1);
            AssertEx.EqualTolerance(SteradiansInOneSteradian, steradian.As(SolidAngleUnit.Steradian), SteradiansTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new SolidAngle(value: 1, unit: SolidAngle.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = Convert.ToDouble(AsWithSIUnitSystem());
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
                var parsed = SolidAngle.Parse("1 sr", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Steradians, SteradiansTolerance);
                Assert.Equal(SolidAngleUnit.Steradian, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(SolidAngle.TryParse("1 sr", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Steradians, SteradiansTolerance);
                Assert.Equal(SolidAngleUnit.Steradian, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = SolidAngle.ParseUnit("sr", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(SolidAngleUnit.Steradian, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(SolidAngle.TryParseUnit("sr", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(SolidAngleUnit.Steradian, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(SolidAngleUnit unit)
        {
            var inBaseUnits = SolidAngle.From(1.0, SolidAngle.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(SolidAngleUnit unit)
        {
            var quantity = SolidAngle.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory(Skip = "Multiple units required")]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(SolidAngleUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = SolidAngle.Units.First(u => u != SolidAngle.BaseUnit);

            var quantity = SolidAngle.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(SolidAngleUnit unit)
        {
            var quantity = default(SolidAngle);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            AssertEx.EqualTolerance(1, SolidAngle.FromSteradians(steradian.Steradians).Steradians, SteradiansTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SolidAngle v = SolidAngle.FromSteradians(1);
            AssertEx.EqualTolerance(-1, -v.Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(2, (SolidAngle.FromSteradians(3)-v).Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(2, (v + v).Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(10, (v*10).Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(10, (10*v).Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(2, (SolidAngle.FromSteradians(10)/5).Steradians, SteradiansTolerance);
            AssertEx.EqualTolerance(2, SolidAngle.FromSteradians(10)/SolidAngle.FromSteradians(5), SteradiansTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SolidAngle oneSteradian = SolidAngle.FromSteradians(1);
            SolidAngle twoSteradians = SolidAngle.FromSteradians(2);

            Assert.True(oneSteradian < twoSteradians);
            Assert.True(oneSteradian <= twoSteradians);
            Assert.True(twoSteradians > oneSteradian);
            Assert.True(twoSteradians >= oneSteradian);

            Assert.False(oneSteradian > twoSteradians);
            Assert.False(oneSteradian >= twoSteradians);
            Assert.False(twoSteradians < oneSteradian);
            Assert.False(twoSteradians <= oneSteradian);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            Assert.Equal(0, steradian.CompareTo(steradian));
            Assert.True(steradian.CompareTo(SolidAngle.Zero) > 0);
            Assert.True(SolidAngle.Zero.CompareTo(steradian) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            Assert.Throws<ArgumentException>(() => steradian.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            Assert.Throws<ArgumentNullException>(() => steradian.CompareTo(null));
        }

        [Theory]
        [InlineData(1, SolidAngleUnit.Steradian, 1, SolidAngleUnit.Steradian, true)]  // Same value and unit.
        [InlineData(1, SolidAngleUnit.Steradian, 2, SolidAngleUnit.Steradian, false)] // Different value.
        [InlineData(2, SolidAngleUnit.Steradian, 1, SolidAngleUnit.Steradian, false)] // Different value and unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, SolidAngleUnit unitA, double valueB, SolidAngleUnit unitB, bool expectEqual)
        {
            var a = new SolidAngle(valueA, unitA);
            var b = new SolidAngle(valueB, unitB);

            // Operator overloads.
            Assert.Equal(expectEqual, a == b);
            Assert.Equal(expectEqual, b == a);
            Assert.Equal(!expectEqual, a != b);
            Assert.Equal(!expectEqual, b != a);

            // IEquatable<T>
            Assert.Equal(expectEqual, a.Equals(b));
            Assert.Equal(expectEqual, b.Equals(a));

            // IEquatable
            Assert.Equal(expectEqual, a.Equals((object)b));
            Assert.Equal(expectEqual, b.Equals((object)a));
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = SolidAngle.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = SolidAngle.FromSteradians(1);
            Assert.True(v.Equals(SolidAngle.FromSteradians(1), SteradiansTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(SolidAngle.Zero, SteradiansTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = SolidAngle.FromSteradians(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(SolidAngle.FromSteradians(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            Assert.False(steradian.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SolidAngle steradian = SolidAngle.FromSteradians(1);
            Assert.False(steradian.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(SolidAngleUnit)).Cast<SolidAngleUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(SolidAngle.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 sr", new SolidAngle(1, SolidAngleUnit.Steradian).ToString());
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

            Assert.Equal("1 sr", new SolidAngle(1, SolidAngleUnit.Steradian).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 sr", new SolidAngle(0.123456, SolidAngleUnit.Steradian).ToString("s1"));
                Assert.Equal("0.12 sr", new SolidAngle(0.123456, SolidAngleUnit.Steradian).ToString("s2"));
                Assert.Equal("0.123 sr", new SolidAngle(0.123456, SolidAngleUnit.Steradian).ToString("s3"));
                Assert.Equal("0.1235 sr", new SolidAngle(0.123456, SolidAngleUnit.Steradian).ToString("s4"));
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
            Assert.Equal("0.1 sr", new SolidAngle(0.123456, SolidAngleUnit.Steradian).ToString("s1", culture));
            Assert.Equal("0.12 sr", new SolidAngle(0.123456, SolidAngleUnit.Steradian).ToString("s2", culture));
            Assert.Equal("0.123 sr", new SolidAngle(0.123456, SolidAngleUnit.Steradian).ToString("s3", culture));
            Assert.Equal("0.1235 sr", new SolidAngle(0.123456, SolidAngleUnit.Steradian).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = SolidAngle.FromSteradians(1.0);
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
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(SolidAngle)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(SolidAngleUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal(SolidAngle.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal(SolidAngle.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = SolidAngle.FromSteradians(1.0);
            Assert.Equal(new {SolidAngle.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = SolidAngle.FromSteradians(value);
            Assert.Equal(SolidAngle.FromSteradians(-value), -quantity);
        }
    }
}

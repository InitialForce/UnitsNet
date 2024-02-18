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
    /// Test of Magnetization.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MagnetizationTestsBase : QuantityTestsBase
    {
        protected abstract double AmperesPerMeterInOneAmperePerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AmperesPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(MagnetizationUnit unit)
        {
            return unit switch
            {
                MagnetizationUnit.AmperePerMeter => (AmperesPerMeterInOneAmperePerMeter, AmperesPerMeterTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { MagnetizationUnit.AmperePerMeter },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Magnetization();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(MagnetizationUnit.AmperePerMeter, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new Magnetization(double.PositiveInfinity, MagnetizationUnit.AmperePerMeter));
            var exception2 = Record.Exception(() => new Magnetization(double.NegativeInfinity, MagnetizationUnit.AmperePerMeter));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new Magnetization(double.NaN, MagnetizationUnit.AmperePerMeter));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Magnetization(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Magnetization(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Magnetization) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Magnetization_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Magnetization(1, MagnetizationUnit.AmperePerMeter);

            QuantityInfo<MagnetizationUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Magnetization.Zero, quantityInfo.Zero);
            Assert.Equal("Magnetization", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<MagnetizationUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void AmperePerMeterToMagnetizationUnits()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            AssertEx.EqualTolerance(AmperesPerMeterInOneAmperePerMeter, amperepermeter.AmperesPerMeter, AmperesPerMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Magnetization.From(1, MagnetizationUnit.AmperePerMeter);
            AssertEx.EqualTolerance(1, quantity00.AmperesPerMeter, AmperesPerMeterTolerance);
            Assert.Equal(MagnetizationUnit.AmperePerMeter, quantity00.Unit);

        }

        [Fact]
        public void FromAmperesPerMeter_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => Magnetization.FromAmperesPerMeter(double.PositiveInfinity));
            var exception2 = Record.Exception(() => Magnetization.FromAmperesPerMeter(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromAmperesPerMeter_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => Magnetization.FromAmperesPerMeter(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var amperepermeter = Magnetization.FromAmperesPerMeter(1);
            AssertEx.EqualTolerance(AmperesPerMeterInOneAmperePerMeter, amperepermeter.As(MagnetizationUnit.AmperePerMeter), AmperesPerMeterTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Magnetization(value: 1, unit: Magnetization.BaseUnit);
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
                var parsed = Magnetization.Parse("1 A/m", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.AmperesPerMeter, AmperesPerMeterTolerance);
                Assert.Equal(MagnetizationUnit.AmperePerMeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(Magnetization.TryParse("1 A/m", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.AmperesPerMeter, AmperesPerMeterTolerance);
                Assert.Equal(MagnetizationUnit.AmperePerMeter, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = Magnetization.ParseUnit("A/m", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(MagnetizationUnit.AmperePerMeter, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(Magnetization.TryParseUnit("A/m", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(MagnetizationUnit.AmperePerMeter, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(MagnetizationUnit unit)
        {
            var inBaseUnits = Magnetization.From(1.0, Magnetization.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(MagnetizationUnit unit)
        {
            var quantity = Magnetization.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory(Skip = "Multiple units required")]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(MagnetizationUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = Magnetization.Units.First(u => u != Magnetization.BaseUnit);

            var quantity = Magnetization.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(MagnetizationUnit unit)
        {
            var quantity = default(Magnetization);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            AssertEx.EqualTolerance(1, Magnetization.FromAmperesPerMeter(amperepermeter.AmperesPerMeter).AmperesPerMeter, AmperesPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Magnetization v = Magnetization.FromAmperesPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(2, (Magnetization.FromAmperesPerMeter(3)-v).AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(2, (Magnetization.FromAmperesPerMeter(10)/5).AmperesPerMeter, AmperesPerMeterTolerance);
            AssertEx.EqualTolerance(2, Magnetization.FromAmperesPerMeter(10)/Magnetization.FromAmperesPerMeter(5), AmperesPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Magnetization oneAmperePerMeter = Magnetization.FromAmperesPerMeter(1);
            Magnetization twoAmperesPerMeter = Magnetization.FromAmperesPerMeter(2);

            Assert.True(oneAmperePerMeter < twoAmperesPerMeter);
            Assert.True(oneAmperePerMeter <= twoAmperesPerMeter);
            Assert.True(twoAmperesPerMeter > oneAmperePerMeter);
            Assert.True(twoAmperesPerMeter >= oneAmperePerMeter);

            Assert.False(oneAmperePerMeter > twoAmperesPerMeter);
            Assert.False(oneAmperePerMeter >= twoAmperesPerMeter);
            Assert.False(twoAmperesPerMeter < oneAmperePerMeter);
            Assert.False(twoAmperesPerMeter <= oneAmperePerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            Assert.Equal(0, amperepermeter.CompareTo(amperepermeter));
            Assert.True(amperepermeter.CompareTo(Magnetization.Zero) > 0);
            Assert.True(Magnetization.Zero.CompareTo(amperepermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            Assert.Throws<ArgumentException>(() => amperepermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => amperepermeter.CompareTo(null));
        }

        [Theory]
        [InlineData(1, MagnetizationUnit.AmperePerMeter, 1, MagnetizationUnit.AmperePerMeter, true)]  // Same value and unit.
        [InlineData(1, MagnetizationUnit.AmperePerMeter, 2, MagnetizationUnit.AmperePerMeter, false)] // Different value.
        [InlineData(2, MagnetizationUnit.AmperePerMeter, 1, MagnetizationUnit.AmperePerMeter, false)] // Different value and unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, MagnetizationUnit unitA, double valueB, MagnetizationUnit unitB, bool expectEqual)
        {
            var a = new Magnetization(valueA, unitA);
            var b = new Magnetization(valueB, unitB);

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
            var a = Magnetization.Zero;

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
            var v = Magnetization.FromAmperesPerMeter(1);
            Assert.True(v.Equals(Magnetization.FromAmperesPerMeter(1), AmperesPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Magnetization.Zero, AmperesPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Magnetization.FromAmperesPerMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Magnetization.FromAmperesPerMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            Assert.False(amperepermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Magnetization amperepermeter = Magnetization.FromAmperesPerMeter(1);
            Assert.False(amperepermeter.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MagnetizationUnit)).Cast<MagnetizationUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Magnetization.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 A/m", new Magnetization(1, MagnetizationUnit.AmperePerMeter).ToString());
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

            Assert.Equal("1 A/m", new Magnetization(1, MagnetizationUnit.AmperePerMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s1"));
                Assert.Equal("0.12 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s2"));
                Assert.Equal("0.123 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s3"));
                Assert.Equal("0.1235 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s4"));
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
            Assert.Equal("0.1 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s1", culture));
            Assert.Equal("0.12 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s2", culture));
            Assert.Equal("0.123 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s3", culture));
            Assert.Equal("0.1235 A/m", new Magnetization(0.123456, MagnetizationUnit.AmperePerMeter).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
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
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Magnetization)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(MagnetizationUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(Magnetization.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(Magnetization.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Magnetization.FromAmperesPerMeter(1.0);
            Assert.Equal(new {Magnetization.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Magnetization.FromAmperesPerMeter(value);
            Assert.Equal(Magnetization.FromAmperesPerMeter(-value), -quantity);
        }
    }
}

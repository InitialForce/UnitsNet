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
    /// Test of ElectricChargeDensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricChargeDensityTestsBase : QuantityTestsBase
    {
        protected abstract double CoulombsPerCubicMeterInOneCoulombPerCubicMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CoulombsPerCubicMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ElectricChargeDensityUnit unit)
        {
            return unit switch
            {
                ElectricChargeDensityUnit.CoulombPerCubicMeter => (CoulombsPerCubicMeterInOneCoulombPerCubicMeter, CoulombsPerCubicMeterTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ElectricChargeDensityUnit.CoulombPerCubicMeter },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricChargeDensity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricChargeDensityUnit.CoulombPerCubicMeter, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new ElectricChargeDensity(double.PositiveInfinity, ElectricChargeDensityUnit.CoulombPerCubicMeter));
            var exception2 = Record.Exception(() => new ElectricChargeDensity(double.NegativeInfinity, ElectricChargeDensityUnit.CoulombPerCubicMeter));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new ElectricChargeDensity(double.NaN, ElectricChargeDensityUnit.CoulombPerCubicMeter));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricChargeDensity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricChargeDensity(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricChargeDensity) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricChargeDensity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricChargeDensity(1, ElectricChargeDensityUnit.CoulombPerCubicMeter);

            QuantityInfo<ElectricChargeDensityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricChargeDensity.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricChargeDensity", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ElectricChargeDensityUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void CoulombPerCubicMeterToElectricChargeDensityUnits()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            AssertEx.EqualTolerance(CoulombsPerCubicMeterInOneCoulombPerCubicMeter, coulombpercubicmeter.CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricChargeDensity.From(1, ElectricChargeDensityUnit.CoulombPerCubicMeter);
            AssertEx.EqualTolerance(1, quantity00.CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            Assert.Equal(ElectricChargeDensityUnit.CoulombPerCubicMeter, quantity00.Unit);

        }

        [Fact]
        public void FromCoulombsPerCubicMeter_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => ElectricChargeDensity.FromCoulombsPerCubicMeter(double.PositiveInfinity));
            var exception2 = Record.Exception(() => ElectricChargeDensity.FromCoulombsPerCubicMeter(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromCoulombsPerCubicMeter_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => ElectricChargeDensity.FromCoulombsPerCubicMeter(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            AssertEx.EqualTolerance(CoulombsPerCubicMeterInOneCoulombPerCubicMeter, coulombpercubicmeter.As(ElectricChargeDensityUnit.CoulombPerCubicMeter), CoulombsPerCubicMeterTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricChargeDensity(value: 1, unit: ElectricChargeDensity.BaseUnit);
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
                var parsed = ElectricChargeDensity.Parse("1 C/m³", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
                Assert.Equal(ElectricChargeDensityUnit.CoulombPerCubicMeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ElectricChargeDensity.TryParse("1 C/m³", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
                Assert.Equal(ElectricChargeDensityUnit.CoulombPerCubicMeter, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = ElectricChargeDensity.ParseUnit("C/m³", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricChargeDensityUnit.CoulombPerCubicMeter, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(ElectricChargeDensity.TryParseUnit("C/m³", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricChargeDensityUnit.CoulombPerCubicMeter, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ElectricChargeDensityUnit unit)
        {
            var inBaseUnits = ElectricChargeDensity.From(1.0, ElectricChargeDensity.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ElectricChargeDensityUnit unit)
        {
            var quantity = ElectricChargeDensity.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory(Skip = "Multiple units required")]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ElectricChargeDensityUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = ElectricChargeDensity.Units.First(u => u != ElectricChargeDensity.BaseUnit);

            var quantity = ElectricChargeDensity.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(ElectricChargeDensityUnit unit)
        {
            var quantity = default(ElectricChargeDensity);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            AssertEx.EqualTolerance(1, ElectricChargeDensity.FromCoulombsPerCubicMeter(coulombpercubicmeter.CoulombsPerCubicMeter).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricChargeDensity v = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            AssertEx.EqualTolerance(-1, -v.CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricChargeDensity.FromCoulombsPerCubicMeter(3)-v).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricChargeDensity.FromCoulombsPerCubicMeter(10)/5).CoulombsPerCubicMeter, CoulombsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, ElectricChargeDensity.FromCoulombsPerCubicMeter(10)/ElectricChargeDensity.FromCoulombsPerCubicMeter(5), CoulombsPerCubicMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricChargeDensity oneCoulombPerCubicMeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            ElectricChargeDensity twoCoulombsPerCubicMeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(2);

            Assert.True(oneCoulombPerCubicMeter < twoCoulombsPerCubicMeter);
            Assert.True(oneCoulombPerCubicMeter <= twoCoulombsPerCubicMeter);
            Assert.True(twoCoulombsPerCubicMeter > oneCoulombPerCubicMeter);
            Assert.True(twoCoulombsPerCubicMeter >= oneCoulombPerCubicMeter);

            Assert.False(oneCoulombPerCubicMeter > twoCoulombsPerCubicMeter);
            Assert.False(oneCoulombPerCubicMeter >= twoCoulombsPerCubicMeter);
            Assert.False(twoCoulombsPerCubicMeter < oneCoulombPerCubicMeter);
            Assert.False(twoCoulombsPerCubicMeter <= oneCoulombPerCubicMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.Equal(0, coulombpercubicmeter.CompareTo(coulombpercubicmeter));
            Assert.True(coulombpercubicmeter.CompareTo(ElectricChargeDensity.Zero) > 0);
            Assert.True(ElectricChargeDensity.Zero.CompareTo(coulombpercubicmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.Throws<ArgumentException>(() => coulombpercubicmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.Throws<ArgumentNullException>(() => coulombpercubicmeter.CompareTo(null));
        }

        [Theory]
        [InlineData(1, ElectricChargeDensityUnit.CoulombPerCubicMeter, 1, ElectricChargeDensityUnit.CoulombPerCubicMeter, true)]  // Same value and unit.
        [InlineData(1, ElectricChargeDensityUnit.CoulombPerCubicMeter, 2, ElectricChargeDensityUnit.CoulombPerCubicMeter, false)] // Different value.
        [InlineData(2, ElectricChargeDensityUnit.CoulombPerCubicMeter, 1, ElectricChargeDensityUnit.CoulombPerCubicMeter, false)] // Different value and unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, ElectricChargeDensityUnit unitA, double valueB, ElectricChargeDensityUnit unitB, bool expectEqual)
        {
            var a = new ElectricChargeDensity(valueA, unitA);
            var b = new ElectricChargeDensity(valueB, unitB);

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
            var a = ElectricChargeDensity.Zero;

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
            var v = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.True(v.Equals(ElectricChargeDensity.FromCoulombsPerCubicMeter(1), CoulombsPerCubicMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricChargeDensity.Zero, CoulombsPerCubicMeterTolerance, ComparisonType.Relative));
            Assert.True(ElectricChargeDensity.FromCoulombsPerCubicMeter(100).Equals(ElectricChargeDensity.FromCoulombsPerCubicMeter(120), 0.3, ComparisonType.Relative));
            Assert.False(ElectricChargeDensity.FromCoulombsPerCubicMeter(100).Equals(ElectricChargeDensity.FromCoulombsPerCubicMeter(120), 0.1, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricChargeDensity.FromCoulombsPerCubicMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.False(coulombpercubicmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricChargeDensity coulombpercubicmeter = ElectricChargeDensity.FromCoulombsPerCubicMeter(1);
            Assert.False(coulombpercubicmeter.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricChargeDensityUnit)).Cast<ElectricChargeDensityUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricChargeDensity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 C/m³", new ElectricChargeDensity(1, ElectricChargeDensityUnit.CoulombPerCubicMeter).ToString());
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

            Assert.Equal("1 C/m³", new ElectricChargeDensity(1, ElectricChargeDensityUnit.CoulombPerCubicMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 C/m³", new ElectricChargeDensity(0.123456, ElectricChargeDensityUnit.CoulombPerCubicMeter).ToString("s1"));
                Assert.Equal("0.12 C/m³", new ElectricChargeDensity(0.123456, ElectricChargeDensityUnit.CoulombPerCubicMeter).ToString("s2"));
                Assert.Equal("0.123 C/m³", new ElectricChargeDensity(0.123456, ElectricChargeDensityUnit.CoulombPerCubicMeter).ToString("s3"));
                Assert.Equal("0.1235 C/m³", new ElectricChargeDensity(0.123456, ElectricChargeDensityUnit.CoulombPerCubicMeter).ToString("s4"));
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
            Assert.Equal("0.1 C/m³", new ElectricChargeDensity(0.123456, ElectricChargeDensityUnit.CoulombPerCubicMeter).ToString("s1", culture));
            Assert.Equal("0.12 C/m³", new ElectricChargeDensity(0.123456, ElectricChargeDensityUnit.CoulombPerCubicMeter).ToString("s2", culture));
            Assert.Equal("0.123 C/m³", new ElectricChargeDensity(0.123456, ElectricChargeDensityUnit.CoulombPerCubicMeter).ToString("s3", culture));
            Assert.Equal("0.1235 C/m³", new ElectricChargeDensity(0.123456, ElectricChargeDensityUnit.CoulombPerCubicMeter).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
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
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricChargeDensity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricChargeDensityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal(ElectricChargeDensity.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal(ElectricChargeDensity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(1.0);
            Assert.Equal(new {ElectricChargeDensity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricChargeDensity.FromCoulombsPerCubicMeter(value);
            Assert.Equal(ElectricChargeDensity.FromCoulombsPerCubicMeter(-value), -quantity);
        }
    }
}

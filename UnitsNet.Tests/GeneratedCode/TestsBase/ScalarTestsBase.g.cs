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
    /// Test of Scalar.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ScalarTestsBase : QuantityTestsBase
    {
        protected abstract double AmountInOneAmount { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AmountTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ScalarUnit unit)
        {
            return unit switch
            {
                ScalarUnit.Amount => (AmountInOneAmount, AmountTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ScalarUnit.Amount },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Scalar();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ScalarUnit.Amount, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Scalar(double.PositiveInfinity, ScalarUnit.Amount));
            Assert.Throws<ArgumentException>(() => new Scalar(double.NegativeInfinity, ScalarUnit.Amount));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Scalar(double.NaN, ScalarUnit.Amount));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Scalar(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Scalar(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Scalar) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Scalar_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Scalar(1, ScalarUnit.Amount);

            QuantityInfo<ScalarUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Scalar.Zero, quantityInfo.Zero);
            Assert.Equal("Scalar", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ScalarUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void AmountToScalarUnits()
        {
            Scalar amount = Scalar.FromAmount(1);
            AssertEx.EqualTolerance(AmountInOneAmount, amount.Amount, AmountTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Scalar.From(1, ScalarUnit.Amount);
            AssertEx.EqualTolerance(1, quantity00.Amount, AmountTolerance);
            Assert.Equal(ScalarUnit.Amount, quantity00.Unit);

        }

        [Fact]
        public void FromAmount_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Scalar.FromAmount(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Scalar.FromAmount(double.NegativeInfinity));
        }

        [Fact]
        public void FromAmount_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Scalar.FromAmount(double.NaN));
        }

        [Fact]
        public void As()
        {
            var amount = Scalar.FromAmount(1);
            AssertEx.EqualTolerance(AmountInOneAmount, amount.As(ScalarUnit.Amount), AmountTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Scalar(value: 1, unit: Scalar.BaseUnit);
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
                var parsed = Scalar.Parse("1 ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Amount, AmountTolerance);
                Assert.Equal(ScalarUnit.Amount, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(Scalar.TryParse("1 ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Amount, AmountTolerance);
                Assert.Equal(ScalarUnit.Amount, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = Scalar.ParseUnit("", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ScalarUnit.Amount, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(Scalar.TryParseUnit("", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ScalarUnit.Amount, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ScalarUnit unit)
        {
            var inBaseUnits = Scalar.From(1.0, Scalar.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ScalarUnit unit)
        {
            var quantity = Scalar.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ScalarUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = Scalar.Units.Where(u => u != Scalar.BaseUnit).DefaultIfEmpty(Scalar.BaseUnit).FirstOrDefault();

            var quantity = Scalar.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(ScalarUnit unit)
        {
            var quantity = default(Scalar);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Scalar amount = Scalar.FromAmount(1);
            AssertEx.EqualTolerance(1, Scalar.FromAmount(amount.Amount).Amount, AmountTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Scalar v = Scalar.FromAmount(1);
            AssertEx.EqualTolerance(-1, -v.Amount, AmountTolerance);
            AssertEx.EqualTolerance(2, (Scalar.FromAmount(3)-v).Amount, AmountTolerance);
            AssertEx.EqualTolerance(2, (v + v).Amount, AmountTolerance);
            AssertEx.EqualTolerance(10, (v*10).Amount, AmountTolerance);
            AssertEx.EqualTolerance(10, (10*v).Amount, AmountTolerance);
            AssertEx.EqualTolerance(2, (Scalar.FromAmount(10)/5).Amount, AmountTolerance);
            AssertEx.EqualTolerance(2, Scalar.FromAmount(10)/Scalar.FromAmount(5), AmountTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Scalar oneAmount = Scalar.FromAmount(1);
            Scalar twoAmount = Scalar.FromAmount(2);

            Assert.True(oneAmount < twoAmount);
            Assert.True(oneAmount <= twoAmount);
            Assert.True(twoAmount > oneAmount);
            Assert.True(twoAmount >= oneAmount);

            Assert.False(oneAmount > twoAmount);
            Assert.False(oneAmount >= twoAmount);
            Assert.False(twoAmount < oneAmount);
            Assert.False(twoAmount <= oneAmount);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Scalar amount = Scalar.FromAmount(1);
            Assert.Equal(0, amount.CompareTo(amount));
            Assert.True(amount.CompareTo(Scalar.Zero) > 0);
            Assert.True(Scalar.Zero.CompareTo(amount) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Scalar amount = Scalar.FromAmount(1);
            Assert.Throws<ArgumentException>(() => amount.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Scalar amount = Scalar.FromAmount(1);
            Assert.Throws<ArgumentNullException>(() => amount.CompareTo(null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Scalar.FromAmount(1);
            Assert.True(v.Equals(Scalar.FromAmount(1), AmountTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Scalar.Zero, AmountTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Scalar.FromAmount(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Scalar.FromAmount(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Scalar amount = Scalar.FromAmount(1);
            Assert.False(amount.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Scalar amount = Scalar.FromAmount(1);
            Assert.False(amount.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ScalarUnit)).Cast<ScalarUnit>();
            foreach(var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Scalar.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1", new Scalar(1, ScalarUnit.Amount).ToString());
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

            Assert.Equal("1", new Scalar(1, ScalarUnit.Amount).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1", new Scalar(0.123456, ScalarUnit.Amount).ToString("s1"));
                Assert.Equal("0.12", new Scalar(0.123456, ScalarUnit.Amount).ToString("s2"));
                Assert.Equal("0.123", new Scalar(0.123456, ScalarUnit.Amount).ToString("s3"));
                Assert.Equal("0.1235", new Scalar(0.123456, ScalarUnit.Amount).ToString("s4"));
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
            Assert.Equal("0.1", new Scalar(0.123456, ScalarUnit.Amount).ToString("s1", culture));
            Assert.Equal("0.12", new Scalar(0.123456, ScalarUnit.Amount).ToString("s2", culture));
            Assert.Equal("0.123", new Scalar(0.123456, ScalarUnit.Amount).ToString("s3", culture));
            Assert.Equal("0.1235", new Scalar(0.123456, ScalarUnit.Amount).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = Scalar.FromAmount(1.0);
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
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Scalar)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ScalarUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal(Scalar.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal(Scalar.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Scalar.FromAmount(1.0);
            Assert.Equal(new {Scalar.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Scalar.FromAmount(value);
            Assert.Equal(Scalar.FromAmount(-value), -quantity);
        }
    }
}

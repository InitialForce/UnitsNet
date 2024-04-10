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
    /// Test of Level.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LevelTestsBase : QuantityTestsBase
    {
        protected abstract double DecibelsInOneDecibel { get; }
        protected abstract double NepersInOneDecibel { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecibelsTolerance { get { return 1e-5; } }
        protected virtual double NepersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(LevelUnit unit)
        {
            return unit switch
            {
                LevelUnit.Decibel => (DecibelsInOneDecibel, DecibelsTolerance),
                LevelUnit.Neper => (NepersInOneDecibel, NepersTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { LevelUnit.Decibel },
            new object[] { LevelUnit.Neper },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Level();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(LevelUnit.Decibel, quantity.Unit);
        }

        [Fact(Skip = "https://github.com/danm-de/Fractions/issues/26")]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new Level(double.PositiveInfinity, LevelUnit.Decibel));
            var exception2 = Record.Exception(() => new Level(double.NegativeInfinity, LevelUnit.Decibel));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact(Skip = "https://github.com/danm-de/Fractions/issues/26")]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new Level(double.NaN, LevelUnit.Decibel));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Level(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Level(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Level) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Level_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Level(1, LevelUnit.Decibel);

            QuantityInfo<LevelUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Level.Zero, quantityInfo.Zero);
            Assert.Equal("Level", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<LevelUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void DecibelToLevelUnits()
        {
            Level decibel = Level.FromDecibels(1);
            AssertEx.EqualTolerance(DecibelsInOneDecibel, decibel.Decibels, DecibelsTolerance);
            AssertEx.EqualTolerance(NepersInOneDecibel, decibel.Nepers, NepersTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Level.From(1, LevelUnit.Decibel);
            AssertEx.EqualTolerance(1, quantity00.Decibels, DecibelsTolerance);
            Assert.Equal(LevelUnit.Decibel, quantity00.Unit);

            var quantity01 = Level.From(1, LevelUnit.Neper);
            AssertEx.EqualTolerance(1, quantity01.Nepers, NepersTolerance);
            Assert.Equal(LevelUnit.Neper, quantity01.Unit);

        }

        [Fact(Skip = "https://github.com/danm-de/Fractions/issues/26")]
        public void FromDecibels_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => Level.FromDecibels(double.PositiveInfinity));
            var exception2 = Record.Exception(() => Level.FromDecibels(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact(Skip = "https://github.com/danm-de/Fractions/issues/26")]
        public void FromDecibels_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => Level.FromDecibels(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var decibel = Level.FromDecibels(1);
            AssertEx.EqualTolerance(DecibelsInOneDecibel, decibel.As(LevelUnit.Decibel), DecibelsTolerance);
            AssertEx.EqualTolerance(NepersInOneDecibel, decibel.As(LevelUnit.Neper), NepersTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Level(value: 1, unit: Level.BaseUnit);
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
                var parsed = Level.Parse("1 dB", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Decibels, DecibelsTolerance);
                Assert.Equal(LevelUnit.Decibel, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Level.Parse("1 Np", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Nepers, NepersTolerance);
                Assert.Equal(LevelUnit.Neper, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(Level.TryParse("1 dB", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Decibels, DecibelsTolerance);
                Assert.Equal(LevelUnit.Decibel, parsed.Unit);
            }

            {
                Assert.True(Level.TryParse("1 Np", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Nepers, NepersTolerance);
                Assert.Equal(LevelUnit.Neper, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = Level.ParseUnit("dB", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(LevelUnit.Decibel, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Level.ParseUnit("Np", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(LevelUnit.Neper, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(Level.TryParseUnit("dB", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(LevelUnit.Decibel, parsedUnit);
            }

            {
                Assert.True(Level.TryParseUnit("Np", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(LevelUnit.Neper, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(LevelUnit unit)
        {
            var inBaseUnits = Level.From(1.0, Level.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(LevelUnit unit)
        {
            var quantity = Level.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(LevelUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = Level.Units.First(u => u != Level.BaseUnit);

            var quantity = Level.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(LevelUnit unit)
        {
            var quantity = default(Level);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Level decibel = Level.FromDecibels(1);
            AssertEx.EqualTolerance(1, Level.FromDecibels(decibel.Decibels).Decibels, DecibelsTolerance);
            AssertEx.EqualTolerance(1, Level.FromNepers(decibel.Nepers).Decibels, NepersTolerance);
        }

        [Fact]
        public void LogarithmicArithmeticOperators()
        {
            Level v = Level.FromDecibels(40);
            AssertEx.EqualTolerance(-40, -v.Decibels, NepersTolerance);
            AssertLogarithmicAddition();
            AssertLogarithmicSubtraction();
            AssertEx.EqualTolerance(50, (v*10).Decibels, NepersTolerance);
            AssertEx.EqualTolerance(50, (10*v).Decibels, NepersTolerance);
            AssertEx.EqualTolerance(35, (v/5).Decibels, NepersTolerance);
            AssertEx.EqualTolerance(35, v/Level.FromDecibels(5), NepersTolerance);
        }

        protected abstract void AssertLogarithmicAddition();

        protected abstract void AssertLogarithmicSubtraction();

        [Fact]
        public void ComparisonOperators()
        {
            Level oneDecibel = Level.FromDecibels(1);
            Level twoDecibels = Level.FromDecibels(2);

            Assert.True(oneDecibel < twoDecibels);
            Assert.True(oneDecibel <= twoDecibels);
            Assert.True(twoDecibels > oneDecibel);
            Assert.True(twoDecibels >= oneDecibel);

            Assert.False(oneDecibel > twoDecibels);
            Assert.False(oneDecibel >= twoDecibels);
            Assert.False(twoDecibels < oneDecibel);
            Assert.False(twoDecibels <= oneDecibel);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Level decibel = Level.FromDecibels(1);
            Assert.Equal(0, decibel.CompareTo(decibel));
            Assert.True(decibel.CompareTo(Level.Zero) > 0);
            Assert.True(Level.Zero.CompareTo(decibel) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Level decibel = Level.FromDecibels(1);
            Assert.Throws<ArgumentException>(() => decibel.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Level decibel = Level.FromDecibels(1);
            Assert.Throws<ArgumentNullException>(() => decibel.CompareTo(null));
        }

        [Theory]
        [InlineData(1, LevelUnit.Decibel, 1, LevelUnit.Decibel, true)]  // Same value and unit.
        [InlineData(1, LevelUnit.Decibel, 2, LevelUnit.Decibel, false)] // Different value.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, LevelUnit unitA, double valueB, LevelUnit unitB, bool expectEqual)
        {
            var a = new Level(valueA, unitA);
            var b = new Level(valueB, unitB);

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
            var a = Level.Zero;

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
            var v = Level.FromDecibels(1);
            Assert.True(v.Equals(Level.FromDecibels(1), DecibelsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Level.Zero, DecibelsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Level.FromDecibels(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Level.FromDecibels(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Level decibel = Level.FromDecibels(1);
            Assert.False(decibel.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Level decibel = Level.FromDecibels(1);
            Assert.False(decibel.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(LevelUnit)).Cast<LevelUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Level.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 dB", new Level(1, LevelUnit.Decibel).ToString());
                Assert.Equal("1 Np", new Level(1, LevelUnit.Neper).ToString());
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

            Assert.Equal("1 dB", new Level(1, LevelUnit.Decibel).ToString(swedishCulture));
            Assert.Equal("1 Np", new Level(1, LevelUnit.Neper).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s1"));
                Assert.Equal("0.12 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s2"));
                Assert.Equal("0.123 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s3"));
                Assert.Equal("0.1235 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s4"));
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
            Assert.Equal("0.1 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s1", culture));
            Assert.Equal("0.12 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s2", culture));
            Assert.Equal("0.123 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s3", culture));
            Assert.Equal("0.1235 dB", new Level(0.123456, LevelUnit.Decibel).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = Level.FromDecibels(1.0);
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
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Level)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(LevelUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(Level.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Equal(Level.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Level.FromDecibels(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Level.FromDecibels(1.0);
            #if NET7_0_OR_GREATER
            var expected = HashCode.Combine(Level.Info.Name, quantity.Decibels);
            #else
            var expected = new {Level.Info.Name, valueInBaseUnit = quantity.Decibels}.GetHashCode();
            #endif
            Assert.Equal(expected, quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Level.FromDecibels(value);
            Assert.Equal(Level.FromDecibels(-value), -quantity);
        }
    }
}

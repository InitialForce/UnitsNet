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
    /// Test of ElectricCurrentDensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricCurrentDensityTestsBase : QuantityTestsBase
    {
        protected abstract double AmperesPerSquareFootInOneAmperePerSquareMeter { get; }
        protected abstract double AmperesPerSquareInchInOneAmperePerSquareMeter { get; }
        protected abstract double AmperesPerSquareMeterInOneAmperePerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AmperesPerSquareFootTolerance { get { return 1e-5; } }
        protected virtual double AmperesPerSquareInchTolerance { get { return 1e-5; } }
        protected virtual double AmperesPerSquareMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ElectricCurrentDensityUnit unit)
        {
            return unit switch
            {
                ElectricCurrentDensityUnit.AmperePerSquareFoot => (AmperesPerSquareFootInOneAmperePerSquareMeter, AmperesPerSquareFootTolerance),
                ElectricCurrentDensityUnit.AmperePerSquareInch => (AmperesPerSquareInchInOneAmperePerSquareMeter, AmperesPerSquareInchTolerance),
                ElectricCurrentDensityUnit.AmperePerSquareMeter => (AmperesPerSquareMeterInOneAmperePerSquareMeter, AmperesPerSquareMeterTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ElectricCurrentDensityUnit.AmperePerSquareFoot },
            new object[] { ElectricCurrentDensityUnit.AmperePerSquareInch },
            new object[] { ElectricCurrentDensityUnit.AmperePerSquareMeter },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricCurrentDensity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareMeter, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new ElectricCurrentDensity(double.PositiveInfinity, ElectricCurrentDensityUnit.AmperePerSquareMeter));
            var exception2 = Record.Exception(() => new ElectricCurrentDensity(double.NegativeInfinity, ElectricCurrentDensityUnit.AmperePerSquareMeter));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new ElectricCurrentDensity(double.NaN, ElectricCurrentDensityUnit.AmperePerSquareMeter));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricCurrentDensity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricCurrentDensity(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricCurrentDensity) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricCurrentDensity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricCurrentDensity(1, ElectricCurrentDensityUnit.AmperePerSquareMeter);

            QuantityInfo<ElectricCurrentDensityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricCurrentDensity.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricCurrentDensity", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ElectricCurrentDensityUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void AmperePerSquareMeterToElectricCurrentDensityUnits()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            AssertEx.EqualTolerance(AmperesPerSquareFootInOneAmperePerSquareMeter, amperepersquaremeter.AmperesPerSquareFoot, AmperesPerSquareFootTolerance);
            AssertEx.EqualTolerance(AmperesPerSquareInchInOneAmperePerSquareMeter, amperepersquaremeter.AmperesPerSquareInch, AmperesPerSquareInchTolerance);
            AssertEx.EqualTolerance(AmperesPerSquareMeterInOneAmperePerSquareMeter, amperepersquaremeter.AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricCurrentDensity.From(1, ElectricCurrentDensityUnit.AmperePerSquareFoot);
            AssertEx.EqualTolerance(1, quantity00.AmperesPerSquareFoot, AmperesPerSquareFootTolerance);
            Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareFoot, quantity00.Unit);

            var quantity01 = ElectricCurrentDensity.From(1, ElectricCurrentDensityUnit.AmperePerSquareInch);
            AssertEx.EqualTolerance(1, quantity01.AmperesPerSquareInch, AmperesPerSquareInchTolerance);
            Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareInch, quantity01.Unit);

            var quantity02 = ElectricCurrentDensity.From(1, ElectricCurrentDensityUnit.AmperePerSquareMeter);
            AssertEx.EqualTolerance(1, quantity02.AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareMeter, quantity02.Unit);

        }

        [Fact]
        public void FromAmperesPerSquareMeter_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => ElectricCurrentDensity.FromAmperesPerSquareMeter(double.PositiveInfinity));
            var exception2 = Record.Exception(() => ElectricCurrentDensity.FromAmperesPerSquareMeter(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromAmperesPerSquareMeter_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => ElectricCurrentDensity.FromAmperesPerSquareMeter(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            AssertEx.EqualTolerance(AmperesPerSquareFootInOneAmperePerSquareMeter, amperepersquaremeter.As(ElectricCurrentDensityUnit.AmperePerSquareFoot), AmperesPerSquareFootTolerance);
            AssertEx.EqualTolerance(AmperesPerSquareInchInOneAmperePerSquareMeter, amperepersquaremeter.As(ElectricCurrentDensityUnit.AmperePerSquareInch), AmperesPerSquareInchTolerance);
            AssertEx.EqualTolerance(AmperesPerSquareMeterInOneAmperePerSquareMeter, amperepersquaremeter.As(ElectricCurrentDensityUnit.AmperePerSquareMeter), AmperesPerSquareMeterTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricCurrentDensity(value: 1, unit: ElectricCurrentDensity.BaseUnit);
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
                var parsed = ElectricCurrentDensity.Parse("1 A/ft²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.AmperesPerSquareFoot, AmperesPerSquareFootTolerance);
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareFoot, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricCurrentDensity.Parse("1 A/in²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.AmperesPerSquareInch, AmperesPerSquareInchTolerance);
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareInch, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricCurrentDensity.Parse("1 A/m²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareMeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ElectricCurrentDensity.TryParse("1 A/ft²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.AmperesPerSquareFoot, AmperesPerSquareFootTolerance);
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareFoot, parsed.Unit);
            }

            {
                Assert.True(ElectricCurrentDensity.TryParse("1 A/in²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.AmperesPerSquareInch, AmperesPerSquareInchTolerance);
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareInch, parsed.Unit);
            }

            {
                Assert.True(ElectricCurrentDensity.TryParse("1 A/m²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareMeter, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = ElectricCurrentDensity.ParseUnit("A/ft²", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareFoot, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricCurrentDensity.ParseUnit("A/in²", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareInch, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricCurrentDensity.ParseUnit("A/m²", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareMeter, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(ElectricCurrentDensity.TryParseUnit("A/ft²", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareFoot, parsedUnit);
            }

            {
                Assert.True(ElectricCurrentDensity.TryParseUnit("A/in²", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareInch, parsedUnit);
            }

            {
                Assert.True(ElectricCurrentDensity.TryParseUnit("A/m²", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareMeter, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ElectricCurrentDensityUnit unit)
        {
            var inBaseUnits = ElectricCurrentDensity.From(1.0, ElectricCurrentDensity.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ElectricCurrentDensityUnit unit)
        {
            var quantity = ElectricCurrentDensity.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ElectricCurrentDensityUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = ElectricCurrentDensity.Units.First(u => u != ElectricCurrentDensity.BaseUnit);

            var quantity = ElectricCurrentDensity.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(ElectricCurrentDensityUnit unit)
        {
            var quantity = default(ElectricCurrentDensity);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            AssertEx.EqualTolerance(1, ElectricCurrentDensity.FromAmperesPerSquareFoot(amperepersquaremeter.AmperesPerSquareFoot).AmperesPerSquareMeter, AmperesPerSquareFootTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrentDensity.FromAmperesPerSquareInch(amperepersquaremeter.AmperesPerSquareInch).AmperesPerSquareMeter, AmperesPerSquareInchTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrentDensity.FromAmperesPerSquareMeter(amperepersquaremeter.AmperesPerSquareMeter).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricCurrentDensity v = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrentDensity.FromAmperesPerSquareMeter(3)-v).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrentDensity.FromAmperesPerSquareMeter(10)/5).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, ElectricCurrentDensity.FromAmperesPerSquareMeter(10)/ElectricCurrentDensity.FromAmperesPerSquareMeter(5), AmperesPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricCurrentDensity oneAmperePerSquareMeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            ElectricCurrentDensity twoAmperesPerSquareMeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(2);

            Assert.True(oneAmperePerSquareMeter < twoAmperesPerSquareMeter);
            Assert.True(oneAmperePerSquareMeter <= twoAmperesPerSquareMeter);
            Assert.True(twoAmperesPerSquareMeter > oneAmperePerSquareMeter);
            Assert.True(twoAmperesPerSquareMeter >= oneAmperePerSquareMeter);

            Assert.False(oneAmperePerSquareMeter > twoAmperesPerSquareMeter);
            Assert.False(oneAmperePerSquareMeter >= twoAmperesPerSquareMeter);
            Assert.False(twoAmperesPerSquareMeter < oneAmperePerSquareMeter);
            Assert.False(twoAmperesPerSquareMeter <= oneAmperePerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.Equal(0, amperepersquaremeter.CompareTo(amperepersquaremeter));
            Assert.True(amperepersquaremeter.CompareTo(ElectricCurrentDensity.Zero) > 0);
            Assert.True(ElectricCurrentDensity.Zero.CompareTo(amperepersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => amperepersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => amperepersquaremeter.CompareTo(null));
        }

        [Theory]
        [InlineData(1, ElectricCurrentDensityUnit.AmperePerSquareMeter, 1, ElectricCurrentDensityUnit.AmperePerSquareMeter, true)]  // Same value and unit.
        [InlineData(1, ElectricCurrentDensityUnit.AmperePerSquareMeter, 2, ElectricCurrentDensityUnit.AmperePerSquareMeter, false)] // Different value.
        [InlineData(2, ElectricCurrentDensityUnit.AmperePerSquareMeter, 1, ElectricCurrentDensityUnit.AmperePerSquareFoot, false)] // Different value and unit.
        [InlineData(1, ElectricCurrentDensityUnit.AmperePerSquareMeter, 1, ElectricCurrentDensityUnit.AmperePerSquareFoot, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, ElectricCurrentDensityUnit unitA, double valueB, ElectricCurrentDensityUnit unitB, bool expectEqual)
        {
            var a = new ElectricCurrentDensity(valueA, unitA);
            var b = new ElectricCurrentDensity(valueB, unitB);

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
            var a = ElectricCurrentDensity.Zero;

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
            var v = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.True(v.Equals(ElectricCurrentDensity.FromAmperesPerSquareMeter(1), AmperesPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricCurrentDensity.Zero, AmperesPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.True(ElectricCurrentDensity.FromAmperesPerSquareMeter(100).Equals(ElectricCurrentDensity.FromAmperesPerSquareMeter(120), 0.3, ComparisonType.Relative));
            Assert.False(ElectricCurrentDensity.FromAmperesPerSquareMeter(100).Equals(ElectricCurrentDensity.FromAmperesPerSquareMeter(120), 0.1, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricCurrentDensity.FromAmperesPerSquareMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.False(amperepersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.False(amperepersquaremeter.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricCurrentDensityUnit)).Cast<ElectricCurrentDensityUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricCurrentDensity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 A/ft²", new ElectricCurrentDensity(1, ElectricCurrentDensityUnit.AmperePerSquareFoot).ToString());
                Assert.Equal("1 A/in²", new ElectricCurrentDensity(1, ElectricCurrentDensityUnit.AmperePerSquareInch).ToString());
                Assert.Equal("1 A/m²", new ElectricCurrentDensity(1, ElectricCurrentDensityUnit.AmperePerSquareMeter).ToString());
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

            Assert.Equal("1 A/ft²", new ElectricCurrentDensity(1, ElectricCurrentDensityUnit.AmperePerSquareFoot).ToString(swedishCulture));
            Assert.Equal("1 A/in²", new ElectricCurrentDensity(1, ElectricCurrentDensityUnit.AmperePerSquareInch).ToString(swedishCulture));
            Assert.Equal("1 A/m²", new ElectricCurrentDensity(1, ElectricCurrentDensityUnit.AmperePerSquareMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 A/m²", new ElectricCurrentDensity(0.123456, ElectricCurrentDensityUnit.AmperePerSquareMeter).ToString("s1"));
                Assert.Equal("0.12 A/m²", new ElectricCurrentDensity(0.123456, ElectricCurrentDensityUnit.AmperePerSquareMeter).ToString("s2"));
                Assert.Equal("0.123 A/m²", new ElectricCurrentDensity(0.123456, ElectricCurrentDensityUnit.AmperePerSquareMeter).ToString("s3"));
                Assert.Equal("0.1235 A/m²", new ElectricCurrentDensity(0.123456, ElectricCurrentDensityUnit.AmperePerSquareMeter).ToString("s4"));
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
            Assert.Equal("0.1 A/m²", new ElectricCurrentDensity(0.123456, ElectricCurrentDensityUnit.AmperePerSquareMeter).ToString("s1", culture));
            Assert.Equal("0.12 A/m²", new ElectricCurrentDensity(0.123456, ElectricCurrentDensityUnit.AmperePerSquareMeter).ToString("s2", culture));
            Assert.Equal("0.123 A/m²", new ElectricCurrentDensity(0.123456, ElectricCurrentDensityUnit.AmperePerSquareMeter).ToString("s3", culture));
            Assert.Equal("0.1235 A/m²", new ElectricCurrentDensity(0.123456, ElectricCurrentDensityUnit.AmperePerSquareMeter).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
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
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricCurrentDensity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricCurrentDensityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal(ElectricCurrentDensity.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal(ElectricCurrentDensity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(1.0);
            Assert.Equal(new {ElectricCurrentDensity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricCurrentDensity.FromAmperesPerSquareMeter(value);
            Assert.Equal(ElectricCurrentDensity.FromAmperesPerSquareMeter(-value), -quantity);
        }
    }
}

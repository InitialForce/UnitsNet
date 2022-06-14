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
    /// Test of VolumeFlowPerArea.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class VolumeFlowPerAreaTestsBase : QuantityTestsBase
    {
        protected abstract double CubicFeetPerMinutePerSquareFootInOneCubicMeterPerSecondPerSquareMeter { get; }
        protected abstract double CubicMetersPerSecondPerSquareMeterInOneCubicMeterPerSecondPerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CubicFeetPerMinutePerSquareFootTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersPerSecondPerSquareMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(VolumeFlowPerAreaUnit unit)
        {
            return unit switch
            {
                VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot => (CubicFeetPerMinutePerSquareFootInOneCubicMeterPerSecondPerSquareMeter, CubicFeetPerMinutePerSquareFootTolerance),
                VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter => (CubicMetersPerSecondPerSquareMeterInOneCubicMeterPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot },
            new object[] { VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new VolumeFlowPerArea();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumeFlowPerArea(double.PositiveInfinity, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter));
            Assert.Throws<ArgumentException>(() => new VolumeFlowPerArea(double.NegativeInfinity, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumeFlowPerArea(double.NaN, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new VolumeFlowPerArea(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new VolumeFlowPerArea(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (VolumeFlowPerArea) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void VolumeFlowPerArea_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new VolumeFlowPerArea(1, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter);

            QuantityInfo<VolumeFlowPerAreaUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(VolumeFlowPerArea.Zero, quantityInfo.Zero);
            Assert.Equal("VolumeFlowPerArea", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<VolumeFlowPerAreaUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void CubicMeterPerSecondPerSquareMeterToVolumeFlowPerAreaUnits()
        {
            VolumeFlowPerArea cubicmeterpersecondpersquaremeter = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(CubicFeetPerMinutePerSquareFootInOneCubicMeterPerSecondPerSquareMeter, cubicmeterpersecondpersquaremeter.CubicFeetPerMinutePerSquareFoot, CubicFeetPerMinutePerSquareFootTolerance);
            AssertEx.EqualTolerance(CubicMetersPerSecondPerSquareMeterInOneCubicMeterPerSecondPerSquareMeter, cubicmeterpersecondpersquaremeter.CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = VolumeFlowPerArea.From(1, VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot);
            AssertEx.EqualTolerance(1, quantity00.CubicFeetPerMinutePerSquareFoot, CubicFeetPerMinutePerSquareFootTolerance);
            Assert.Equal(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, quantity00.Unit);

            var quantity01 = VolumeFlowPerArea.From(1, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter);
            AssertEx.EqualTolerance(1, quantity01.CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
            Assert.Equal(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, quantity01.Unit);

        }

        [Fact]
        public void FromCubicMetersPerSecondPerSquareMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromCubicMetersPerSecondPerSquareMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var cubicmeterpersecondpersquaremeter = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(CubicFeetPerMinutePerSquareFootInOneCubicMeterPerSecondPerSquareMeter, cubicmeterpersecondpersquaremeter.As(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot), CubicFeetPerMinutePerSquareFootTolerance);
            AssertEx.EqualTolerance(CubicMetersPerSecondPerSquareMeterInOneCubicMeterPerSecondPerSquareMeter, cubicmeterpersecondpersquaremeter.As(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter), CubicMetersPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new VolumeFlowPerArea(value: 1, unit: VolumeFlowPerArea.BaseUnit);
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
                var parsed = VolumeFlowPerArea.Parse("1 CFM/ft²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.CubicFeetPerMinutePerSquareFoot, CubicFeetPerMinutePerSquareFootTolerance);
                Assert.Equal(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = VolumeFlowPerArea.Parse("1 m³/(s·m²)", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
                Assert.Equal(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(VolumeFlowPerArea.TryParse("1 CFM/ft²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.CubicFeetPerMinutePerSquareFoot, CubicFeetPerMinutePerSquareFootTolerance);
                Assert.Equal(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, parsed.Unit);
            }

            {
                Assert.True(VolumeFlowPerArea.TryParse("1 m³/(s·m²)", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
                Assert.Equal(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = VolumeFlowPerArea.ParseUnit("CFM/ft²", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = VolumeFlowPerArea.ParseUnit("m³/(s·m²)", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(VolumeFlowPerArea.TryParseUnit("CFM/ft²", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, parsedUnit);
            }

            {
                Assert.True(VolumeFlowPerArea.TryParseUnit("m³/(s·m²)", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(VolumeFlowPerAreaUnit unit)
        {
            var inBaseUnits = VolumeFlowPerArea.From(1.0, VolumeFlowPerArea.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(VolumeFlowPerAreaUnit unit)
        {
            var quantity = VolumeFlowPerArea.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(VolumeFlowPerAreaUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = VolumeFlowPerArea.Units.First(u => u != VolumeFlowPerArea.BaseUnit);

            var quantity = VolumeFlowPerArea.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(VolumeFlowPerAreaUnit unit)
        {
            var quantity = default(VolumeFlowPerArea);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            VolumeFlowPerArea cubicmeterpersecondpersquaremeter = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(1, VolumeFlowPerArea.FromCubicFeetPerMinutePerSquareFoot(cubicmeterpersecondpersquaremeter.CubicFeetPerMinutePerSquareFoot).CubicMetersPerSecondPerSquareMeter, CubicFeetPerMinutePerSquareFootTolerance);
            AssertEx.EqualTolerance(1, VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(cubicmeterpersecondpersquaremeter.CubicMetersPerSecondPerSquareMeter).CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            VolumeFlowPerArea v = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(3)-v).CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(10)/5).CubicMetersPerSecondPerSquareMeter, CubicMetersPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(10)/VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(5), CubicMetersPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            VolumeFlowPerArea oneCubicMeterPerSecondPerSquareMeter = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            VolumeFlowPerArea twoCubicMetersPerSecondPerSquareMeter = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(2);

            Assert.True(oneCubicMeterPerSecondPerSquareMeter < twoCubicMetersPerSecondPerSquareMeter);
            Assert.True(oneCubicMeterPerSecondPerSquareMeter <= twoCubicMetersPerSecondPerSquareMeter);
            Assert.True(twoCubicMetersPerSecondPerSquareMeter > oneCubicMeterPerSecondPerSquareMeter);
            Assert.True(twoCubicMetersPerSecondPerSquareMeter >= oneCubicMeterPerSecondPerSquareMeter);

            Assert.False(oneCubicMeterPerSecondPerSquareMeter > twoCubicMetersPerSecondPerSquareMeter);
            Assert.False(oneCubicMeterPerSecondPerSquareMeter >= twoCubicMetersPerSecondPerSquareMeter);
            Assert.False(twoCubicMetersPerSecondPerSquareMeter < oneCubicMeterPerSecondPerSquareMeter);
            Assert.False(twoCubicMetersPerSecondPerSquareMeter <= oneCubicMeterPerSecondPerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            VolumeFlowPerArea cubicmeterpersecondpersquaremeter = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            Assert.Equal(0, cubicmeterpersecondpersquaremeter.CompareTo(cubicmeterpersecondpersquaremeter));
            Assert.True(cubicmeterpersecondpersquaremeter.CompareTo(VolumeFlowPerArea.Zero) > 0);
            Assert.True(VolumeFlowPerArea.Zero.CompareTo(cubicmeterpersecondpersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            VolumeFlowPerArea cubicmeterpersecondpersquaremeter = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => cubicmeterpersecondpersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            VolumeFlowPerArea cubicmeterpersecondpersquaremeter = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeterpersecondpersquaremeter.CompareTo(null));
        }

        [Theory]
        [InlineData(1, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, 1, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, true)]  // Same value and unit.
        [InlineData(1, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, 2, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, false)] // Different value.
        [InlineData(2, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, 1, VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, false)] // Different value and unit.
        [InlineData(1, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, 1, VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, VolumeFlowPerAreaUnit unitA, double valueB, VolumeFlowPerAreaUnit unitB, bool expectEqual)
        {
            var a = new VolumeFlowPerArea(valueA, unitA);
            var b = new VolumeFlowPerArea(valueB, unitB);

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
            var a = VolumeFlowPerArea.Zero;

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
            var v = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            Assert.True(v.Equals(VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1), CubicMetersPerSecondPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(VolumeFlowPerArea.Zero, CubicMetersPerSecondPerSquareMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            VolumeFlowPerArea cubicmeterpersecondpersquaremeter = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            Assert.False(cubicmeterpersecondpersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            VolumeFlowPerArea cubicmeterpersecondpersquaremeter = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1);
            Assert.False(cubicmeterpersecondpersquaremeter.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(VolumeFlowPerAreaUnit)).Cast<VolumeFlowPerAreaUnit>();
            foreach(var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(VolumeFlowPerArea.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 CFM/ft²", new VolumeFlowPerArea(1, VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot).ToString());
                Assert.Equal("1 m³/(s·m²)", new VolumeFlowPerArea(1, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter).ToString());
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

            Assert.Equal("1 CFM/ft²", new VolumeFlowPerArea(1, VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot).ToString(swedishCulture));
            Assert.Equal("1 m³/(s·m²)", new VolumeFlowPerArea(1, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 m³/(s·m²)", new VolumeFlowPerArea(0.123456, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter).ToString("s1"));
                Assert.Equal("0.12 m³/(s·m²)", new VolumeFlowPerArea(0.123456, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter).ToString("s2"));
                Assert.Equal("0.123 m³/(s·m²)", new VolumeFlowPerArea(0.123456, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter).ToString("s3"));
                Assert.Equal("0.1235 m³/(s·m²)", new VolumeFlowPerArea(0.123456, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter).ToString("s4"));
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
            Assert.Equal("0.1 m³/(s·m²)", new VolumeFlowPerArea(0.123456, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter).ToString("s1", culture));
            Assert.Equal("0.12 m³/(s·m²)", new VolumeFlowPerArea(0.123456, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter).ToString("s2", culture));
            Assert.Equal("0.123 m³/(s·m²)", new VolumeFlowPerArea(0.123456, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter).ToString("s3", culture));
            Assert.Equal("0.1235 m³/(s·m²)", new VolumeFlowPerArea(0.123456, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
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
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(VolumeFlowPerArea)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(VolumeFlowPerAreaUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal(VolumeFlowPerArea.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal(VolumeFlowPerArea.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(1.0);
            Assert.Equal(new {VolumeFlowPerArea.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(value);
            Assert.Equal(VolumeFlowPerArea.FromCubicMetersPerSecondPerSquareMeter(-value), -quantity);
        }
    }
}

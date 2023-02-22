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
    /// Test of CoefficientOfThermalExpansion.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class CoefficientOfThermalExpansionTestsBase : QuantityTestsBase
    {
        protected abstract double InverseDegreeCelsiusInOneInverseKelvin { get; }
        protected abstract double InverseDegreeFahrenheitInOneInverseKelvin { get; }
        protected abstract double InverseKelvinInOneInverseKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double InverseDegreeCelsiusTolerance { get { return 1e-5; } }
        protected virtual double InverseDegreeFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double InverseKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(CoefficientOfThermalExpansionUnit unit)
        {
            return unit switch
            {
                CoefficientOfThermalExpansionUnit.InverseDegreeCelsius => (InverseDegreeCelsiusInOneInverseKelvin, InverseDegreeCelsiusTolerance),
                CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit => (InverseDegreeFahrenheitInOneInverseKelvin, InverseDegreeFahrenheitTolerance),
                CoefficientOfThermalExpansionUnit.InverseKelvin => (InverseKelvinInOneInverseKelvin, InverseKelvinTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { CoefficientOfThermalExpansionUnit.InverseDegreeCelsius },
            new object[] { CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit },
            new object[] { CoefficientOfThermalExpansionUnit.InverseKelvin },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new CoefficientOfThermalExpansion();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CoefficientOfThermalExpansion(double.PositiveInfinity, CoefficientOfThermalExpansionUnit.InverseKelvin));
            Assert.Throws<ArgumentException>(() => new CoefficientOfThermalExpansion(double.NegativeInfinity, CoefficientOfThermalExpansionUnit.InverseKelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CoefficientOfThermalExpansion(double.NaN, CoefficientOfThermalExpansionUnit.InverseKelvin));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new CoefficientOfThermalExpansion(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new CoefficientOfThermalExpansion(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (CoefficientOfThermalExpansion) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void CoefficientOfThermalExpansion_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new CoefficientOfThermalExpansion(1, CoefficientOfThermalExpansionUnit.InverseKelvin);

            QuantityInfo<CoefficientOfThermalExpansionUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(CoefficientOfThermalExpansion.Zero, quantityInfo.Zero);
            Assert.Equal("CoefficientOfThermalExpansion", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<CoefficientOfThermalExpansionUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void InverseKelvinToCoefficientOfThermalExpansionUnits()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            AssertEx.EqualTolerance(InverseDegreeCelsiusInOneInverseKelvin, inversekelvin.InverseDegreeCelsius, InverseDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(InverseDegreeFahrenheitInOneInverseKelvin, inversekelvin.InverseDegreeFahrenheit, InverseDegreeFahrenheitTolerance);
            AssertEx.EqualTolerance(InverseKelvinInOneInverseKelvin, inversekelvin.InverseKelvin, InverseKelvinTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = CoefficientOfThermalExpansion.From(1, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius);
            AssertEx.EqualTolerance(1, quantity00.InverseDegreeCelsius, InverseDegreeCelsiusTolerance);
            Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, quantity00.Unit);

            var quantity01 = CoefficientOfThermalExpansion.From(1, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit);
            AssertEx.EqualTolerance(1, quantity01.InverseDegreeFahrenheit, InverseDegreeFahrenheitTolerance);
            Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, quantity01.Unit);

            var quantity02 = CoefficientOfThermalExpansion.From(1, CoefficientOfThermalExpansionUnit.InverseKelvin);
            AssertEx.EqualTolerance(1, quantity02.InverseKelvin, InverseKelvinTolerance);
            Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, quantity02.Unit);

        }

        [Fact]
        public void FromInverseKelvin_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CoefficientOfThermalExpansion.FromInverseKelvin(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => CoefficientOfThermalExpansion.FromInverseKelvin(double.NegativeInfinity));
        }

        [Fact]
        public void FromInverseKelvin_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => CoefficientOfThermalExpansion.FromInverseKelvin(double.NaN));
        }

        [Fact]
        public void As()
        {
            var inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            AssertEx.EqualTolerance(InverseDegreeCelsiusInOneInverseKelvin, inversekelvin.As(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius), InverseDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(InverseDegreeFahrenheitInOneInverseKelvin, inversekelvin.As(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit), InverseDegreeFahrenheitTolerance);
            AssertEx.EqualTolerance(InverseKelvinInOneInverseKelvin, inversekelvin.As(CoefficientOfThermalExpansionUnit.InverseKelvin), InverseKelvinTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new CoefficientOfThermalExpansion(value: 1, unit: CoefficientOfThermalExpansion.BaseUnit);
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
                var parsed = CoefficientOfThermalExpansion.Parse("1 °C⁻¹", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.InverseDegreeCelsius, InverseDegreeCelsiusTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = CoefficientOfThermalExpansion.Parse("1 1/°C", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.InverseDegreeCelsius, InverseDegreeCelsiusTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = CoefficientOfThermalExpansion.Parse("1 °F⁻¹", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.InverseDegreeFahrenheit, InverseDegreeFahrenheitTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = CoefficientOfThermalExpansion.Parse("1 1/°F", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.InverseDegreeFahrenheit, InverseDegreeFahrenheitTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = CoefficientOfThermalExpansion.Parse("1 K⁻¹", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.InverseKelvin, InverseKelvinTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = CoefficientOfThermalExpansion.Parse("1 1/K", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.InverseKelvin, InverseKelvinTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(CoefficientOfThermalExpansion.TryParse("1 °C⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.InverseDegreeCelsius, InverseDegreeCelsiusTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, parsed.Unit);
            }

            {
                Assert.True(CoefficientOfThermalExpansion.TryParse("1 1/°C", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.InverseDegreeCelsius, InverseDegreeCelsiusTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, parsed.Unit);
            }

            {
                Assert.True(CoefficientOfThermalExpansion.TryParse("1 °F⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.InverseDegreeFahrenheit, InverseDegreeFahrenheitTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, parsed.Unit);
            }

            {
                Assert.True(CoefficientOfThermalExpansion.TryParse("1 1/°F", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.InverseDegreeFahrenheit, InverseDegreeFahrenheitTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, parsed.Unit);
            }

            {
                Assert.True(CoefficientOfThermalExpansion.TryParse("1 K⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.InverseKelvin, InverseKelvinTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, parsed.Unit);
            }

            {
                Assert.True(CoefficientOfThermalExpansion.TryParse("1 1/K", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.InverseKelvin, InverseKelvinTolerance);
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = CoefficientOfThermalExpansion.ParseUnit("°C⁻¹", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = CoefficientOfThermalExpansion.ParseUnit("1/°C", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = CoefficientOfThermalExpansion.ParseUnit("°F⁻¹", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = CoefficientOfThermalExpansion.ParseUnit("1/°F", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = CoefficientOfThermalExpansion.ParseUnit("K⁻¹", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = CoefficientOfThermalExpansion.ParseUnit("1/K", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(CoefficientOfThermalExpansion.TryParseUnit("°C⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, parsedUnit);
            }

            {
                Assert.True(CoefficientOfThermalExpansion.TryParseUnit("1/°C", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, parsedUnit);
            }

            {
                Assert.True(CoefficientOfThermalExpansion.TryParseUnit("°F⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, parsedUnit);
            }

            {
                Assert.True(CoefficientOfThermalExpansion.TryParseUnit("1/°F", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit, parsedUnit);
            }

            {
                Assert.True(CoefficientOfThermalExpansion.TryParseUnit("K⁻¹", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, parsedUnit);
            }

            {
                Assert.True(CoefficientOfThermalExpansion.TryParseUnit("1/K", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CoefficientOfThermalExpansionUnit.InverseKelvin, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(CoefficientOfThermalExpansionUnit unit)
        {
            var inBaseUnits = CoefficientOfThermalExpansion.From(1.0, CoefficientOfThermalExpansion.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(CoefficientOfThermalExpansionUnit unit)
        {
            var quantity = CoefficientOfThermalExpansion.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(CoefficientOfThermalExpansionUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = CoefficientOfThermalExpansion.Units.First(u => u != CoefficientOfThermalExpansion.BaseUnit);

            var quantity = CoefficientOfThermalExpansion.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(CoefficientOfThermalExpansionUnit unit)
        {
            var quantity = default(CoefficientOfThermalExpansion);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            AssertEx.EqualTolerance(1, CoefficientOfThermalExpansion.FromInverseDegreeCelsius(inversekelvin.InverseDegreeCelsius).InverseKelvin, InverseDegreeCelsiusTolerance);
            AssertEx.EqualTolerance(1, CoefficientOfThermalExpansion.FromInverseDegreeFahrenheit(inversekelvin.InverseDegreeFahrenheit).InverseKelvin, InverseDegreeFahrenheitTolerance);
            AssertEx.EqualTolerance(1, CoefficientOfThermalExpansion.FromInverseKelvin(inversekelvin.InverseKelvin).InverseKelvin, InverseKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            CoefficientOfThermalExpansion v = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            AssertEx.EqualTolerance(-1, -v.InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(2, (CoefficientOfThermalExpansion.FromInverseKelvin(3)-v).InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(2, (CoefficientOfThermalExpansion.FromInverseKelvin(10)/5).InverseKelvin, InverseKelvinTolerance);
            AssertEx.EqualTolerance(2, CoefficientOfThermalExpansion.FromInverseKelvin(10)/CoefficientOfThermalExpansion.FromInverseKelvin(5), InverseKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            CoefficientOfThermalExpansion oneInverseKelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            CoefficientOfThermalExpansion twoInverseKelvin = CoefficientOfThermalExpansion.FromInverseKelvin(2);

            Assert.True(oneInverseKelvin < twoInverseKelvin);
            Assert.True(oneInverseKelvin <= twoInverseKelvin);
            Assert.True(twoInverseKelvin > oneInverseKelvin);
            Assert.True(twoInverseKelvin >= oneInverseKelvin);

            Assert.False(oneInverseKelvin > twoInverseKelvin);
            Assert.False(oneInverseKelvin >= twoInverseKelvin);
            Assert.False(twoInverseKelvin < oneInverseKelvin);
            Assert.False(twoInverseKelvin <= oneInverseKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.Equal(0, inversekelvin.CompareTo(inversekelvin));
            Assert.True(inversekelvin.CompareTo(CoefficientOfThermalExpansion.Zero) > 0);
            Assert.True(CoefficientOfThermalExpansion.Zero.CompareTo(inversekelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.Throws<ArgumentException>(() => inversekelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.Throws<ArgumentNullException>(() => inversekelvin.CompareTo(null));
        }

        [Theory]
        [InlineData(1, CoefficientOfThermalExpansionUnit.InverseKelvin, 1, CoefficientOfThermalExpansionUnit.InverseKelvin, true)]  // Same value and unit.
        [InlineData(1, CoefficientOfThermalExpansionUnit.InverseKelvin, 2, CoefficientOfThermalExpansionUnit.InverseKelvin, false)] // Different value.
        [InlineData(2, CoefficientOfThermalExpansionUnit.InverseKelvin, 1, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, false)] // Different value and unit.
        [InlineData(1, CoefficientOfThermalExpansionUnit.InverseKelvin, 1, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, CoefficientOfThermalExpansionUnit unitA, double valueB, CoefficientOfThermalExpansionUnit unitB, bool expectEqual)
        {
            var a = new CoefficientOfThermalExpansion(valueA, unitA);
            var b = new CoefficientOfThermalExpansion(valueB, unitB);

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
            var a = CoefficientOfThermalExpansion.Zero;

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
            var v = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.True(v.Equals(CoefficientOfThermalExpansion.FromInverseKelvin(1), InverseKelvinTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(CoefficientOfThermalExpansion.Zero, InverseKelvinTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(CoefficientOfThermalExpansion.FromInverseKelvin(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.False(inversekelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            CoefficientOfThermalExpansion inversekelvin = CoefficientOfThermalExpansion.FromInverseKelvin(1);
            Assert.False(inversekelvin.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(CoefficientOfThermalExpansionUnit)).Cast<CoefficientOfThermalExpansionUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(CoefficientOfThermalExpansion.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 °C⁻¹", new CoefficientOfThermalExpansion(1, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius).ToString());
                Assert.Equal("1 °F⁻¹", new CoefficientOfThermalExpansion(1, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit).ToString());
                Assert.Equal("1 K⁻¹", new CoefficientOfThermalExpansion(1, CoefficientOfThermalExpansionUnit.InverseKelvin).ToString());
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

            Assert.Equal("1 °C⁻¹", new CoefficientOfThermalExpansion(1, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius).ToString(swedishCulture));
            Assert.Equal("1 °F⁻¹", new CoefficientOfThermalExpansion(1, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit).ToString(swedishCulture));
            Assert.Equal("1 K⁻¹", new CoefficientOfThermalExpansion(1, CoefficientOfThermalExpansionUnit.InverseKelvin).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 K⁻¹", new CoefficientOfThermalExpansion(0.123456, CoefficientOfThermalExpansionUnit.InverseKelvin).ToString("s1"));
                Assert.Equal("0.12 K⁻¹", new CoefficientOfThermalExpansion(0.123456, CoefficientOfThermalExpansionUnit.InverseKelvin).ToString("s2"));
                Assert.Equal("0.123 K⁻¹", new CoefficientOfThermalExpansion(0.123456, CoefficientOfThermalExpansionUnit.InverseKelvin).ToString("s3"));
                Assert.Equal("0.1235 K⁻¹", new CoefficientOfThermalExpansion(0.123456, CoefficientOfThermalExpansionUnit.InverseKelvin).ToString("s4"));
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
            Assert.Equal("0.1 K⁻¹", new CoefficientOfThermalExpansion(0.123456, CoefficientOfThermalExpansionUnit.InverseKelvin).ToString("s1", culture));
            Assert.Equal("0.12 K⁻¹", new CoefficientOfThermalExpansion(0.123456, CoefficientOfThermalExpansionUnit.InverseKelvin).ToString("s2", culture));
            Assert.Equal("0.123 K⁻¹", new CoefficientOfThermalExpansion(0.123456, CoefficientOfThermalExpansionUnit.InverseKelvin).ToString("s3", culture));
            Assert.Equal("0.1235 K⁻¹", new CoefficientOfThermalExpansion(0.123456, CoefficientOfThermalExpansionUnit.InverseKelvin).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("G", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(CoefficientOfThermalExpansion)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(CoefficientOfThermalExpansionUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal(CoefficientOfThermalExpansion.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal(CoefficientOfThermalExpansion.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(1.0);
            Assert.Equal(new {CoefficientOfThermalExpansion.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = CoefficientOfThermalExpansion.FromInverseKelvin(value);
            Assert.Equal(CoefficientOfThermalExpansion.FromInverseKelvin(-value), -quantity);
        }
    }
}

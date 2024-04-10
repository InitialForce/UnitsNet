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
    /// Test of MagneticField.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MagneticFieldTestsBase : QuantityTestsBase
    {
        protected abstract double GaussesInOneTesla { get; }
        protected abstract double MicroteslasInOneTesla { get; }
        protected abstract double MilligaussesInOneTesla { get; }
        protected abstract double MilliteslasInOneTesla { get; }
        protected abstract double NanoteslasInOneTesla { get; }
        protected abstract double TeslasInOneTesla { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GaussesTolerance { get { return 1e-5; } }
        protected virtual double MicroteslasTolerance { get { return 1e-5; } }
        protected virtual double MilligaussesTolerance { get { return 1e-5; } }
        protected virtual double MilliteslasTolerance { get { return 1e-5; } }
        protected virtual double NanoteslasTolerance { get { return 1e-5; } }
        protected virtual double TeslasTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(MagneticFieldUnit unit)
        {
            return unit switch
            {
                MagneticFieldUnit.Gauss => (GaussesInOneTesla, GaussesTolerance),
                MagneticFieldUnit.Microtesla => (MicroteslasInOneTesla, MicroteslasTolerance),
                MagneticFieldUnit.Milligauss => (MilligaussesInOneTesla, MilligaussesTolerance),
                MagneticFieldUnit.Millitesla => (MilliteslasInOneTesla, MilliteslasTolerance),
                MagneticFieldUnit.Nanotesla => (NanoteslasInOneTesla, NanoteslasTolerance),
                MagneticFieldUnit.Tesla => (TeslasInOneTesla, TeslasTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { MagneticFieldUnit.Gauss },
            new object[] { MagneticFieldUnit.Microtesla },
            new object[] { MagneticFieldUnit.Milligauss },
            new object[] { MagneticFieldUnit.Millitesla },
            new object[] { MagneticFieldUnit.Nanotesla },
            new object[] { MagneticFieldUnit.Tesla },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new MagneticField();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(MagneticFieldUnit.Tesla, quantity.Unit);
        }

        [Fact(Skip = "https://github.com/danm-de/Fractions/issues/26")]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new MagneticField(double.PositiveInfinity, MagneticFieldUnit.Tesla));
            var exception2 = Record.Exception(() => new MagneticField(double.NegativeInfinity, MagneticFieldUnit.Tesla));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact(Skip = "https://github.com/danm-de/Fractions/issues/26")]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new MagneticField(double.NaN, MagneticFieldUnit.Tesla));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MagneticField(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new MagneticField(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (MagneticField) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void MagneticField_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new MagneticField(1, MagneticFieldUnit.Tesla);

            QuantityInfo<MagneticFieldUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(MagneticField.Zero, quantityInfo.Zero);
            Assert.Equal("MagneticField", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<MagneticFieldUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void TeslaToMagneticFieldUnits()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(GaussesInOneTesla, tesla.Gausses, GaussesTolerance);
            AssertEx.EqualTolerance(MicroteslasInOneTesla, tesla.Microteslas, MicroteslasTolerance);
            AssertEx.EqualTolerance(MilligaussesInOneTesla, tesla.Milligausses, MilligaussesTolerance);
            AssertEx.EqualTolerance(MilliteslasInOneTesla, tesla.Milliteslas, MilliteslasTolerance);
            AssertEx.EqualTolerance(NanoteslasInOneTesla, tesla.Nanoteslas, NanoteslasTolerance);
            AssertEx.EqualTolerance(TeslasInOneTesla, tesla.Teslas, TeslasTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = MagneticField.From(1, MagneticFieldUnit.Gauss);
            AssertEx.EqualTolerance(1, quantity00.Gausses, GaussesTolerance);
            Assert.Equal(MagneticFieldUnit.Gauss, quantity00.Unit);

            var quantity01 = MagneticField.From(1, MagneticFieldUnit.Microtesla);
            AssertEx.EqualTolerance(1, quantity01.Microteslas, MicroteslasTolerance);
            Assert.Equal(MagneticFieldUnit.Microtesla, quantity01.Unit);

            var quantity02 = MagneticField.From(1, MagneticFieldUnit.Milligauss);
            AssertEx.EqualTolerance(1, quantity02.Milligausses, MilligaussesTolerance);
            Assert.Equal(MagneticFieldUnit.Milligauss, quantity02.Unit);

            var quantity03 = MagneticField.From(1, MagneticFieldUnit.Millitesla);
            AssertEx.EqualTolerance(1, quantity03.Milliteslas, MilliteslasTolerance);
            Assert.Equal(MagneticFieldUnit.Millitesla, quantity03.Unit);

            var quantity04 = MagneticField.From(1, MagneticFieldUnit.Nanotesla);
            AssertEx.EqualTolerance(1, quantity04.Nanoteslas, NanoteslasTolerance);
            Assert.Equal(MagneticFieldUnit.Nanotesla, quantity04.Unit);

            var quantity05 = MagneticField.From(1, MagneticFieldUnit.Tesla);
            AssertEx.EqualTolerance(1, quantity05.Teslas, TeslasTolerance);
            Assert.Equal(MagneticFieldUnit.Tesla, quantity05.Unit);

        }

        [Fact(Skip = "https://github.com/danm-de/Fractions/issues/26")]
        public void FromTeslas_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => MagneticField.FromTeslas(double.PositiveInfinity));
            var exception2 = Record.Exception(() => MagneticField.FromTeslas(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact(Skip = "https://github.com/danm-de/Fractions/issues/26")]
        public void FromTeslas_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => MagneticField.FromTeslas(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var tesla = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(GaussesInOneTesla, tesla.As(MagneticFieldUnit.Gauss), GaussesTolerance);
            AssertEx.EqualTolerance(MicroteslasInOneTesla, tesla.As(MagneticFieldUnit.Microtesla), MicroteslasTolerance);
            AssertEx.EqualTolerance(MilligaussesInOneTesla, tesla.As(MagneticFieldUnit.Milligauss), MilligaussesTolerance);
            AssertEx.EqualTolerance(MilliteslasInOneTesla, tesla.As(MagneticFieldUnit.Millitesla), MilliteslasTolerance);
            AssertEx.EqualTolerance(NanoteslasInOneTesla, tesla.As(MagneticFieldUnit.Nanotesla), NanoteslasTolerance);
            AssertEx.EqualTolerance(TeslasInOneTesla, tesla.As(MagneticFieldUnit.Tesla), TeslasTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new MagneticField(value: 1, unit: MagneticField.BaseUnit);
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
                var parsed = MagneticField.Parse("1 G", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Gausses, GaussesTolerance);
                Assert.Equal(MagneticFieldUnit.Gauss, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = MagneticField.Parse("1 µT", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Microteslas, MicroteslasTolerance);
                Assert.Equal(MagneticFieldUnit.Microtesla, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = MagneticField.Parse("1 mG", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Milligausses, MilligaussesTolerance);
                Assert.Equal(MagneticFieldUnit.Milligauss, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = MagneticField.Parse("1 mT", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Milliteslas, MilliteslasTolerance);
                Assert.Equal(MagneticFieldUnit.Millitesla, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = MagneticField.Parse("1 nT", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Nanoteslas, NanoteslasTolerance);
                Assert.Equal(MagneticFieldUnit.Nanotesla, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = MagneticField.Parse("1 T", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Teslas, TeslasTolerance);
                Assert.Equal(MagneticFieldUnit.Tesla, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(MagneticField.TryParse("1 G", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Gausses, GaussesTolerance);
                Assert.Equal(MagneticFieldUnit.Gauss, parsed.Unit);
            }

            {
                Assert.True(MagneticField.TryParse("1 µT", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Microteslas, MicroteslasTolerance);
                Assert.Equal(MagneticFieldUnit.Microtesla, parsed.Unit);
            }

            {
                Assert.True(MagneticField.TryParse("1 mG", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Milligausses, MilligaussesTolerance);
                Assert.Equal(MagneticFieldUnit.Milligauss, parsed.Unit);
            }

            {
                Assert.True(MagneticField.TryParse("1 mT", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Milliteslas, MilliteslasTolerance);
                Assert.Equal(MagneticFieldUnit.Millitesla, parsed.Unit);
            }

            {
                Assert.True(MagneticField.TryParse("1 nT", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Nanoteslas, NanoteslasTolerance);
                Assert.Equal(MagneticFieldUnit.Nanotesla, parsed.Unit);
            }

            {
                Assert.True(MagneticField.TryParse("1 T", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Teslas, TeslasTolerance);
                Assert.Equal(MagneticFieldUnit.Tesla, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = MagneticField.ParseUnit("G", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(MagneticFieldUnit.Gauss, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = MagneticField.ParseUnit("µT", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(MagneticFieldUnit.Microtesla, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = MagneticField.ParseUnit("mG", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(MagneticFieldUnit.Milligauss, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = MagneticField.ParseUnit("mT", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(MagneticFieldUnit.Millitesla, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = MagneticField.ParseUnit("nT", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(MagneticFieldUnit.Nanotesla, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = MagneticField.ParseUnit("T", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(MagneticFieldUnit.Tesla, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(MagneticField.TryParseUnit("G", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(MagneticFieldUnit.Gauss, parsedUnit);
            }

            {
                Assert.True(MagneticField.TryParseUnit("µT", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(MagneticFieldUnit.Microtesla, parsedUnit);
            }

            {
                Assert.True(MagneticField.TryParseUnit("mG", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(MagneticFieldUnit.Milligauss, parsedUnit);
            }

            {
                Assert.True(MagneticField.TryParseUnit("mT", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(MagneticFieldUnit.Millitesla, parsedUnit);
            }

            {
                Assert.True(MagneticField.TryParseUnit("nT", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(MagneticFieldUnit.Nanotesla, parsedUnit);
            }

            {
                Assert.True(MagneticField.TryParseUnit("T", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(MagneticFieldUnit.Tesla, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(MagneticFieldUnit unit)
        {
            var inBaseUnits = MagneticField.From(1.0, MagneticField.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(MagneticFieldUnit unit)
        {
            var quantity = MagneticField.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(MagneticFieldUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = MagneticField.Units.First(u => u != MagneticField.BaseUnit);

            var quantity = MagneticField.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(MagneticFieldUnit unit)
        {
            var quantity = default(MagneticField);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(1, MagneticField.FromGausses(tesla.Gausses).Teslas, GaussesTolerance);
            AssertEx.EqualTolerance(1, MagneticField.FromMicroteslas(tesla.Microteslas).Teslas, MicroteslasTolerance);
            AssertEx.EqualTolerance(1, MagneticField.FromMilligausses(tesla.Milligausses).Teslas, MilligaussesTolerance);
            AssertEx.EqualTolerance(1, MagneticField.FromMilliteslas(tesla.Milliteslas).Teslas, MilliteslasTolerance);
            AssertEx.EqualTolerance(1, MagneticField.FromNanoteslas(tesla.Nanoteslas).Teslas, NanoteslasTolerance);
            AssertEx.EqualTolerance(1, MagneticField.FromTeslas(tesla.Teslas).Teslas, TeslasTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MagneticField v = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(-1, -v.Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(2, (MagneticField.FromTeslas(3)-v).Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(2, (v + v).Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(10, (v*10).Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(10, (10*v).Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(2, (MagneticField.FromTeslas(10)/5).Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(2, MagneticField.FromTeslas(10)/MagneticField.FromTeslas(5), TeslasTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MagneticField oneTesla = MagneticField.FromTeslas(1);
            MagneticField twoTeslas = MagneticField.FromTeslas(2);

            Assert.True(oneTesla < twoTeslas);
            Assert.True(oneTesla <= twoTeslas);
            Assert.True(twoTeslas > oneTesla);
            Assert.True(twoTeslas >= oneTesla);

            Assert.False(oneTesla > twoTeslas);
            Assert.False(oneTesla >= twoTeslas);
            Assert.False(twoTeslas < oneTesla);
            Assert.False(twoTeslas <= oneTesla);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            Assert.Equal(0, tesla.CompareTo(tesla));
            Assert.True(tesla.CompareTo(MagneticField.Zero) > 0);
            Assert.True(MagneticField.Zero.CompareTo(tesla) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            Assert.Throws<ArgumentException>(() => tesla.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            Assert.Throws<ArgumentNullException>(() => tesla.CompareTo(null));
        }

        [Theory]
        [InlineData(1, MagneticFieldUnit.Tesla, 1, MagneticFieldUnit.Tesla, true)]  // Same value and unit.
        [InlineData(1, MagneticFieldUnit.Tesla, 2, MagneticFieldUnit.Tesla, false)] // Different value.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, MagneticFieldUnit unitA, double valueB, MagneticFieldUnit unitB, bool expectEqual)
        {
            var a = new MagneticField(valueA, unitA);
            var b = new MagneticField(valueB, unitB);

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
            var a = MagneticField.Zero;

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
            var v = MagneticField.FromTeslas(1);
            Assert.True(v.Equals(MagneticField.FromTeslas(1), TeslasTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(MagneticField.Zero, TeslasTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = MagneticField.FromTeslas(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(MagneticField.FromTeslas(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            Assert.False(tesla.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            Assert.False(tesla.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MagneticFieldUnit)).Cast<MagneticFieldUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(MagneticField.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 G", new MagneticField(1, MagneticFieldUnit.Gauss).ToString());
                Assert.Equal("1 µT", new MagneticField(1, MagneticFieldUnit.Microtesla).ToString());
                Assert.Equal("1 mG", new MagneticField(1, MagneticFieldUnit.Milligauss).ToString());
                Assert.Equal("1 mT", new MagneticField(1, MagneticFieldUnit.Millitesla).ToString());
                Assert.Equal("1 nT", new MagneticField(1, MagneticFieldUnit.Nanotesla).ToString());
                Assert.Equal("1 T", new MagneticField(1, MagneticFieldUnit.Tesla).ToString());
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

            Assert.Equal("1 G", new MagneticField(1, MagneticFieldUnit.Gauss).ToString(swedishCulture));
            Assert.Equal("1 µT", new MagneticField(1, MagneticFieldUnit.Microtesla).ToString(swedishCulture));
            Assert.Equal("1 mG", new MagneticField(1, MagneticFieldUnit.Milligauss).ToString(swedishCulture));
            Assert.Equal("1 mT", new MagneticField(1, MagneticFieldUnit.Millitesla).ToString(swedishCulture));
            Assert.Equal("1 nT", new MagneticField(1, MagneticFieldUnit.Nanotesla).ToString(swedishCulture));
            Assert.Equal("1 T", new MagneticField(1, MagneticFieldUnit.Tesla).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 T", new MagneticField(0.123456, MagneticFieldUnit.Tesla).ToString("s1"));
                Assert.Equal("0.12 T", new MagneticField(0.123456, MagneticFieldUnit.Tesla).ToString("s2"));
                Assert.Equal("0.123 T", new MagneticField(0.123456, MagneticFieldUnit.Tesla).ToString("s3"));
                Assert.Equal("0.1235 T", new MagneticField(0.123456, MagneticFieldUnit.Tesla).ToString("s4"));
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
            Assert.Equal("0.1 T", new MagneticField(0.123456, MagneticFieldUnit.Tesla).ToString("s1", culture));
            Assert.Equal("0.12 T", new MagneticField(0.123456, MagneticFieldUnit.Tesla).ToString("s2", culture));
            Assert.Equal("0.123 T", new MagneticField(0.123456, MagneticFieldUnit.Tesla).ToString("s3", culture));
            Assert.Equal("0.1235 T", new MagneticField(0.123456, MagneticFieldUnit.Tesla).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = MagneticField.FromTeslas(1.0);
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
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(MagneticField)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(MagneticFieldUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal(MagneticField.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Equal(MagneticField.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = MagneticField.FromTeslas(1.0);
            #if NET7_0_OR_GREATER
            var expected = HashCode.Combine(MagneticField.Info.Name, quantity.Teslas);
            #else
            var expected = new {MagneticField.Info.Name, valueInBaseUnit = quantity.Teslas}.GetHashCode();
            #endif
            Assert.Equal(expected, quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = MagneticField.FromTeslas(value);
            Assert.Equal(MagneticField.FromTeslas(-value), -quantity);
        }
    }
}

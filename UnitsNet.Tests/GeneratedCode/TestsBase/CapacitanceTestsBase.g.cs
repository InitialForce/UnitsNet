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
    /// Test of Capacitance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class CapacitanceTestsBase : QuantityTestsBase
    {
        protected abstract double FaradsInOneFarad { get; }
        protected abstract double KilofaradsInOneFarad { get; }
        protected abstract double MegafaradsInOneFarad { get; }
        protected abstract double MicrofaradsInOneFarad { get; }
        protected abstract double MillifaradsInOneFarad { get; }
        protected abstract double NanofaradsInOneFarad { get; }
        protected abstract double PicofaradsInOneFarad { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double FaradsTolerance { get { return 1e-5; } }
        protected virtual double KilofaradsTolerance { get { return 1e-5; } }
        protected virtual double MegafaradsTolerance { get { return 1e-5; } }
        protected virtual double MicrofaradsTolerance { get { return 1e-5; } }
        protected virtual double MillifaradsTolerance { get { return 1e-5; } }
        protected virtual double NanofaradsTolerance { get { return 1e-5; } }
        protected virtual double PicofaradsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(CapacitanceUnit unit)
        {
            return unit switch
            {
                CapacitanceUnit.Farad => (FaradsInOneFarad, FaradsTolerance),
                CapacitanceUnit.Kilofarad => (KilofaradsInOneFarad, KilofaradsTolerance),
                CapacitanceUnit.Megafarad => (MegafaradsInOneFarad, MegafaradsTolerance),
                CapacitanceUnit.Microfarad => (MicrofaradsInOneFarad, MicrofaradsTolerance),
                CapacitanceUnit.Millifarad => (MillifaradsInOneFarad, MillifaradsTolerance),
                CapacitanceUnit.Nanofarad => (NanofaradsInOneFarad, NanofaradsTolerance),
                CapacitanceUnit.Picofarad => (PicofaradsInOneFarad, PicofaradsTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { CapacitanceUnit.Farad },
            new object[] { CapacitanceUnit.Kilofarad },
            new object[] { CapacitanceUnit.Megafarad },
            new object[] { CapacitanceUnit.Microfarad },
            new object[] { CapacitanceUnit.Millifarad },
            new object[] { CapacitanceUnit.Nanofarad },
            new object[] { CapacitanceUnit.Picofarad },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Capacitance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(CapacitanceUnit.Farad, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Capacitance(double.PositiveInfinity, CapacitanceUnit.Farad));
            Assert.Throws<ArgumentException>(() => new Capacitance(double.NegativeInfinity, CapacitanceUnit.Farad));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Capacitance(double.NaN, CapacitanceUnit.Farad));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Capacitance(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Capacitance(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Capacitance) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Capacitance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Capacitance(1, CapacitanceUnit.Farad);

            QuantityInfo<CapacitanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Capacitance.Zero, quantityInfo.Zero);
            Assert.Equal("Capacitance", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<CapacitanceUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void FaradToCapacitanceUnits()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            AssertEx.EqualTolerance(FaradsInOneFarad, farad.Farads, FaradsTolerance);
            AssertEx.EqualTolerance(KilofaradsInOneFarad, farad.Kilofarads, KilofaradsTolerance);
            AssertEx.EqualTolerance(MegafaradsInOneFarad, farad.Megafarads, MegafaradsTolerance);
            AssertEx.EqualTolerance(MicrofaradsInOneFarad, farad.Microfarads, MicrofaradsTolerance);
            AssertEx.EqualTolerance(MillifaradsInOneFarad, farad.Millifarads, MillifaradsTolerance);
            AssertEx.EqualTolerance(NanofaradsInOneFarad, farad.Nanofarads, NanofaradsTolerance);
            AssertEx.EqualTolerance(PicofaradsInOneFarad, farad.Picofarads, PicofaradsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Capacitance.From(1, CapacitanceUnit.Farad);
            AssertEx.EqualTolerance(1, quantity00.Farads, FaradsTolerance);
            Assert.Equal(CapacitanceUnit.Farad, quantity00.Unit);

            var quantity01 = Capacitance.From(1, CapacitanceUnit.Kilofarad);
            AssertEx.EqualTolerance(1, quantity01.Kilofarads, KilofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Kilofarad, quantity01.Unit);

            var quantity02 = Capacitance.From(1, CapacitanceUnit.Megafarad);
            AssertEx.EqualTolerance(1, quantity02.Megafarads, MegafaradsTolerance);
            Assert.Equal(CapacitanceUnit.Megafarad, quantity02.Unit);

            var quantity03 = Capacitance.From(1, CapacitanceUnit.Microfarad);
            AssertEx.EqualTolerance(1, quantity03.Microfarads, MicrofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Microfarad, quantity03.Unit);

            var quantity04 = Capacitance.From(1, CapacitanceUnit.Millifarad);
            AssertEx.EqualTolerance(1, quantity04.Millifarads, MillifaradsTolerance);
            Assert.Equal(CapacitanceUnit.Millifarad, quantity04.Unit);

            var quantity05 = Capacitance.From(1, CapacitanceUnit.Nanofarad);
            AssertEx.EqualTolerance(1, quantity05.Nanofarads, NanofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Nanofarad, quantity05.Unit);

            var quantity06 = Capacitance.From(1, CapacitanceUnit.Picofarad);
            AssertEx.EqualTolerance(1, quantity06.Picofarads, PicofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Picofarad, quantity06.Unit);

        }

        [Fact]
        public void FromFarads_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Capacitance.FromFarads(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Capacitance.FromFarads(double.NegativeInfinity));
        }

        [Fact]
        public void FromFarads_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Capacitance.FromFarads(double.NaN));
        }

        [Fact]
        public void As()
        {
            var farad = Capacitance.FromFarads(1);
            AssertEx.EqualTolerance(FaradsInOneFarad, farad.As(CapacitanceUnit.Farad), FaradsTolerance);
            AssertEx.EqualTolerance(KilofaradsInOneFarad, farad.As(CapacitanceUnit.Kilofarad), KilofaradsTolerance);
            AssertEx.EqualTolerance(MegafaradsInOneFarad, farad.As(CapacitanceUnit.Megafarad), MegafaradsTolerance);
            AssertEx.EqualTolerance(MicrofaradsInOneFarad, farad.As(CapacitanceUnit.Microfarad), MicrofaradsTolerance);
            AssertEx.EqualTolerance(MillifaradsInOneFarad, farad.As(CapacitanceUnit.Millifarad), MillifaradsTolerance);
            AssertEx.EqualTolerance(NanofaradsInOneFarad, farad.As(CapacitanceUnit.Nanofarad), NanofaradsTolerance);
            AssertEx.EqualTolerance(PicofaradsInOneFarad, farad.As(CapacitanceUnit.Picofarad), PicofaradsTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Capacitance(value: 1, unit: Capacitance.BaseUnit);
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
                var parsed = Capacitance.Parse("1 F", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Farads, FaradsTolerance);
                Assert.Equal(CapacitanceUnit.Farad, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Capacitance.Parse("1 kF", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Kilofarads, KilofaradsTolerance);
                Assert.Equal(CapacitanceUnit.Kilofarad, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Capacitance.Parse("1 MF", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Megafarads, MegafaradsTolerance);
                Assert.Equal(CapacitanceUnit.Megafarad, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Capacitance.Parse("1 µF", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Microfarads, MicrofaradsTolerance);
                Assert.Equal(CapacitanceUnit.Microfarad, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Capacitance.Parse("1 mF", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Millifarads, MillifaradsTolerance);
                Assert.Equal(CapacitanceUnit.Millifarad, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Capacitance.Parse("1 nF", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Nanofarads, NanofaradsTolerance);
                Assert.Equal(CapacitanceUnit.Nanofarad, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = Capacitance.Parse("1 pF", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Picofarads, PicofaradsTolerance);
                Assert.Equal(CapacitanceUnit.Picofarad, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(Capacitance.TryParse("1 F", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Farads, FaradsTolerance);
                Assert.Equal(CapacitanceUnit.Farad, parsed.Unit);
            }

            {
                Assert.True(Capacitance.TryParse("1 kF", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Kilofarads, KilofaradsTolerance);
                Assert.Equal(CapacitanceUnit.Kilofarad, parsed.Unit);
            }

            {
                Assert.True(Capacitance.TryParse("1 µF", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Microfarads, MicrofaradsTolerance);
                Assert.Equal(CapacitanceUnit.Microfarad, parsed.Unit);
            }

            {
                Assert.True(Capacitance.TryParse("1 nF", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Nanofarads, NanofaradsTolerance);
                Assert.Equal(CapacitanceUnit.Nanofarad, parsed.Unit);
            }

            {
                Assert.True(Capacitance.TryParse("1 pF", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Picofarads, PicofaradsTolerance);
                Assert.Equal(CapacitanceUnit.Picofarad, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = Capacitance.ParseUnit("F", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CapacitanceUnit.Farad, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Capacitance.ParseUnit("kF", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CapacitanceUnit.Kilofarad, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Capacitance.ParseUnit("MF", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CapacitanceUnit.Megafarad, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Capacitance.ParseUnit("µF", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CapacitanceUnit.Microfarad, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Capacitance.ParseUnit("mF", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CapacitanceUnit.Millifarad, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Capacitance.ParseUnit("nF", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CapacitanceUnit.Nanofarad, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = Capacitance.ParseUnit("pF", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(CapacitanceUnit.Picofarad, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(Capacitance.TryParseUnit("F", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CapacitanceUnit.Farad, parsedUnit);
            }

            {
                Assert.True(Capacitance.TryParseUnit("kF", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CapacitanceUnit.Kilofarad, parsedUnit);
            }

            {
                Assert.True(Capacitance.TryParseUnit("µF", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CapacitanceUnit.Microfarad, parsedUnit);
            }

            {
                Assert.True(Capacitance.TryParseUnit("nF", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CapacitanceUnit.Nanofarad, parsedUnit);
            }

            {
                Assert.True(Capacitance.TryParseUnit("pF", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(CapacitanceUnit.Picofarad, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(CapacitanceUnit unit)
        {
            var inBaseUnits = Capacitance.From(1.0, Capacitance.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(CapacitanceUnit unit)
        {
            var quantity = Capacitance.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(CapacitanceUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = Capacitance.Units.First(u => u != Capacitance.BaseUnit);

            var quantity = Capacitance.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(CapacitanceUnit unit)
        {
            var quantity = default(Capacitance);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            AssertEx.EqualTolerance(1, Capacitance.FromFarads(farad.Farads).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromKilofarads(farad.Kilofarads).Farads, KilofaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromMegafarads(farad.Megafarads).Farads, MegafaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromMicrofarads(farad.Microfarads).Farads, MicrofaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromMillifarads(farad.Millifarads).Farads, MillifaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromNanofarads(farad.Nanofarads).Farads, NanofaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromPicofarads(farad.Picofarads).Farads, PicofaradsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Capacitance v = Capacitance.FromFarads(1);
            AssertEx.EqualTolerance(-1, -v.Farads, FaradsTolerance);
            AssertEx.EqualTolerance(2, (Capacitance.FromFarads(3)-v).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(2, (Capacitance.FromFarads(10)/5).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(2, Capacitance.FromFarads(10)/Capacitance.FromFarads(5), FaradsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Capacitance oneFarad = Capacitance.FromFarads(1);
            Capacitance twoFarads = Capacitance.FromFarads(2);

            Assert.True(oneFarad < twoFarads);
            Assert.True(oneFarad <= twoFarads);
            Assert.True(twoFarads > oneFarad);
            Assert.True(twoFarads >= oneFarad);

            Assert.False(oneFarad > twoFarads);
            Assert.False(oneFarad >= twoFarads);
            Assert.False(twoFarads < oneFarad);
            Assert.False(twoFarads <= oneFarad);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            Assert.Equal(0, farad.CompareTo(farad));
            Assert.True(farad.CompareTo(Capacitance.Zero) > 0);
            Assert.True(Capacitance.Zero.CompareTo(farad) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            Assert.Throws<ArgumentException>(() => farad.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            Assert.Throws<ArgumentNullException>(() => farad.CompareTo(null));
        }

        [Theory]
        [InlineData(1, CapacitanceUnit.Farad, 1, CapacitanceUnit.Farad, true)]  // Same value and unit.
        [InlineData(1, CapacitanceUnit.Farad, 2, CapacitanceUnit.Farad, false)] // Different value.
        [InlineData(2, CapacitanceUnit.Farad, 1, CapacitanceUnit.Kilofarad, false)] // Different value and unit.
        [InlineData(1, CapacitanceUnit.Farad, 1, CapacitanceUnit.Kilofarad, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, CapacitanceUnit unitA, double valueB, CapacitanceUnit unitB, bool expectEqual)
        {
            var a = new Capacitance(valueA, unitA);
            var b = new Capacitance(valueB, unitB);

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
            var a = Capacitance.Zero;

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
            var v = Capacitance.FromFarads(1);
            Assert.True(v.Equals(Capacitance.FromFarads(1), FaradsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Capacitance.Zero, FaradsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Capacitance.FromFarads(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Capacitance.FromFarads(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            Assert.False(farad.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            Assert.False(farad.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(CapacitanceUnit)).Cast<CapacitanceUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Capacitance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 F", new Capacitance(1, CapacitanceUnit.Farad).ToString());
                Assert.Equal("1 kF", new Capacitance(1, CapacitanceUnit.Kilofarad).ToString());
                Assert.Equal("1 MF", new Capacitance(1, CapacitanceUnit.Megafarad).ToString());
                Assert.Equal("1 µF", new Capacitance(1, CapacitanceUnit.Microfarad).ToString());
                Assert.Equal("1 mF", new Capacitance(1, CapacitanceUnit.Millifarad).ToString());
                Assert.Equal("1 nF", new Capacitance(1, CapacitanceUnit.Nanofarad).ToString());
                Assert.Equal("1 pF", new Capacitance(1, CapacitanceUnit.Picofarad).ToString());
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

            Assert.Equal("1 F", new Capacitance(1, CapacitanceUnit.Farad).ToString(swedishCulture));
            Assert.Equal("1 kF", new Capacitance(1, CapacitanceUnit.Kilofarad).ToString(swedishCulture));
            Assert.Equal("1 MF", new Capacitance(1, CapacitanceUnit.Megafarad).ToString(swedishCulture));
            Assert.Equal("1 µF", new Capacitance(1, CapacitanceUnit.Microfarad).ToString(swedishCulture));
            Assert.Equal("1 mF", new Capacitance(1, CapacitanceUnit.Millifarad).ToString(swedishCulture));
            Assert.Equal("1 nF", new Capacitance(1, CapacitanceUnit.Nanofarad).ToString(swedishCulture));
            Assert.Equal("1 pF", new Capacitance(1, CapacitanceUnit.Picofarad).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s1"));
                Assert.Equal("0.12 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s2"));
                Assert.Equal("0.123 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s3"));
                Assert.Equal("0.1235 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s4"));
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
            Assert.Equal("0.1 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s1", culture));
            Assert.Equal("0.12 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s2", culture));
            Assert.Equal("0.123 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s3", culture));
            Assert.Equal("0.1235 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = Capacitance.FromFarads(1.0);
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
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Capacitance)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(CapacitanceUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal(Capacitance.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal(Capacitance.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal(new {Capacitance.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Capacitance.FromFarads(value);
            Assert.Equal(Capacitance.FromFarads(-value), -quantity);
        }
    }
}

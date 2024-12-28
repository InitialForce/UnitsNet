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
using UnitsNet.Tests.Helpers;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of BrakeSpecificFuelConsumption.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class BrakeSpecificFuelConsumptionTestsBase : QuantityTestsBase
    {
        protected abstract double GramsPerKiloWattHourInOneKilogramPerJoule { get; }
        protected abstract double KilogramsPerJouleInOneKilogramPerJoule { get; }
        protected abstract double PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GramsPerKiloWattHourTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerJouleTolerance { get { return 1e-5; } }
        protected virtual double PoundsPerMechanicalHorsepowerHourTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(BrakeSpecificFuelConsumptionUnit unit)
        {
            return unit switch
            {
                BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour => (GramsPerKiloWattHourInOneKilogramPerJoule, GramsPerKiloWattHourTolerance),
                BrakeSpecificFuelConsumptionUnit.KilogramPerJoule => (KilogramsPerJouleInOneKilogramPerJoule, KilogramsPerJouleTolerance),
                BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour => (PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule, PoundsPerMechanicalHorsepowerHourTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour },
            new object[] { BrakeSpecificFuelConsumptionUnit.KilogramPerJoule },
            new object[] { BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new BrakeSpecificFuelConsumption();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption(double.PositiveInfinity, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule));
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption(double.NegativeInfinity, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption(double.NaN, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new BrakeSpecificFuelConsumption(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new BrakeSpecificFuelConsumption(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (BrakeSpecificFuelConsumption) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void BrakeSpecificFuelConsumption_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);

            QuantityInfo<BrakeSpecificFuelConsumptionUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(BrakeSpecificFuelConsumption.Zero, quantityInfo.Zero);
            Assert.Equal("BrakeSpecificFuelConsumption", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<BrakeSpecificFuelConsumptionUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void KilogramPerJouleToBrakeSpecificFuelConsumptionUnits()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(GramsPerKiloWattHourInOneKilogramPerJoule, kilogramperjoule.GramsPerKiloWattHour, GramsPerKiloWattHourTolerance);
            AssertEx.EqualTolerance(KilogramsPerJouleInOneKilogramPerJoule, kilogramperjoule.KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule, kilogramperjoule.PoundsPerMechanicalHorsepowerHour, PoundsPerMechanicalHorsepowerHourTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = BrakeSpecificFuelConsumption.From(1, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);
            AssertEx.EqualTolerance(1, quantity00.GramsPerKiloWattHour, GramsPerKiloWattHourTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, quantity00.Unit);

            var quantity01 = BrakeSpecificFuelConsumption.From(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);
            AssertEx.EqualTolerance(1, quantity01.KilogramsPerJoule, KilogramsPerJouleTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, quantity01.Unit);

            var quantity02 = BrakeSpecificFuelConsumption.From(1, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);
            AssertEx.EqualTolerance(1, quantity02.PoundsPerMechanicalHorsepowerHour, PoundsPerMechanicalHorsepowerHourTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, quantity02.Unit);

        }

        [Fact]
        public void FromKilogramsPerJoule_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double.NegativeInfinity));
        }

        [Fact]
        public void FromKilogramsPerJoule_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(GramsPerKiloWattHourInOneKilogramPerJoule, kilogramperjoule.As(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour), GramsPerKiloWattHourTolerance);
            AssertEx.EqualTolerance(KilogramsPerJouleInOneKilogramPerJoule, kilogramperjoule.As(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule), KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule, kilogramperjoule.As(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour), PoundsPerMechanicalHorsepowerHourTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new BrakeSpecificFuelConsumption(value: 1, unit: BrakeSpecificFuelConsumption.BaseUnit);
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
                var parsed = BrakeSpecificFuelConsumption.Parse("1 g/kWh", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.GramsPerKiloWattHour, GramsPerKiloWattHourTolerance);
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = BrakeSpecificFuelConsumption.Parse("1 kg/J", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilogramsPerJoule, KilogramsPerJouleTolerance);
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = BrakeSpecificFuelConsumption.Parse("1 lb/hph", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.PoundsPerMechanicalHorsepowerHour, PoundsPerMechanicalHorsepowerHourTolerance);
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(BrakeSpecificFuelConsumption.TryParse("1 g/kWh", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.GramsPerKiloWattHour, GramsPerKiloWattHourTolerance);
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, parsed.Unit);
            }

            {
                Assert.True(BrakeSpecificFuelConsumption.TryParse("1 kg/J", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilogramsPerJoule, KilogramsPerJouleTolerance);
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, parsed.Unit);
            }

            {
                Assert.True(BrakeSpecificFuelConsumption.TryParse("1 lb/hph", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.PoundsPerMechanicalHorsepowerHour, PoundsPerMechanicalHorsepowerHourTolerance);
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = BrakeSpecificFuelConsumption.ParseUnit("g/kWh", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = BrakeSpecificFuelConsumption.ParseUnit("kg/J", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = BrakeSpecificFuelConsumption.ParseUnit("lb/hph", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(BrakeSpecificFuelConsumption.TryParseUnit("g/kWh", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, parsedUnit);
            }

            {
                Assert.True(BrakeSpecificFuelConsumption.TryParseUnit("kg/J", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, parsedUnit);
            }

            {
                Assert.True(BrakeSpecificFuelConsumption.TryParseUnit("lb/hph", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(BrakeSpecificFuelConsumptionUnit unit)
        {
            var inBaseUnits = BrakeSpecificFuelConsumption.From(1.0, BrakeSpecificFuelConsumption.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(BrakeSpecificFuelConsumptionUnit unit)
        {
            var quantity = BrakeSpecificFuelConsumption.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(BrakeSpecificFuelConsumptionUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = BrakeSpecificFuelConsumption.Units.First(u => u != BrakeSpecificFuelConsumption.BaseUnit);

            var quantity = BrakeSpecificFuelConsumption.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(BrakeSpecificFuelConsumptionUnit unit)
        {
            var quantity = default(BrakeSpecificFuelConsumption);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(kilogramperjoule.GramsPerKiloWattHour).KilogramsPerJoule, GramsPerKiloWattHourTolerance);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.FromKilogramsPerJoule(kilogramperjoule.KilogramsPerJoule).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(kilogramperjoule.PoundsPerMechanicalHorsepowerHour).KilogramsPerJoule, PoundsPerMechanicalHorsepowerHourTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            BrakeSpecificFuelConsumption v = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, (BrakeSpecificFuelConsumption.FromKilogramsPerJoule(3)-v).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, (BrakeSpecificFuelConsumption.FromKilogramsPerJoule(10)/5).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, BrakeSpecificFuelConsumption.FromKilogramsPerJoule(10)/BrakeSpecificFuelConsumption.FromKilogramsPerJoule(5), KilogramsPerJouleTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            BrakeSpecificFuelConsumption oneKilogramPerJoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            BrakeSpecificFuelConsumption twoKilogramsPerJoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(2);

            Assert.True(oneKilogramPerJoule < twoKilogramsPerJoule);
            Assert.True(oneKilogramPerJoule <= twoKilogramsPerJoule);
            Assert.True(twoKilogramsPerJoule > oneKilogramPerJoule);
            Assert.True(twoKilogramsPerJoule >= oneKilogramPerJoule);

            Assert.False(oneKilogramPerJoule > twoKilogramsPerJoule);
            Assert.False(oneKilogramPerJoule >= twoKilogramsPerJoule);
            Assert.False(twoKilogramsPerJoule < oneKilogramPerJoule);
            Assert.False(twoKilogramsPerJoule <= oneKilogramPerJoule);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.Equal(0, kilogramperjoule.CompareTo(kilogramperjoule));
            Assert.True(kilogramperjoule.CompareTo(BrakeSpecificFuelConsumption.Zero) > 0);
            Assert.True(BrakeSpecificFuelConsumption.Zero.CompareTo(kilogramperjoule) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.Throws<ArgumentException>(() => kilogramperjoule.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.Throws<ArgumentNullException>(() => kilogramperjoule.CompareTo(null));
        }

        [Theory]
        [InlineData(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, 1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, true)]  // Same value and unit.
        [InlineData(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, 2, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, false)] // Different value.
        [InlineData(2, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, 1, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, false)] // Different value and unit.
        [InlineData(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, 1, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, BrakeSpecificFuelConsumptionUnit unitA, double valueB, BrakeSpecificFuelConsumptionUnit unitB, bool expectEqual)
        {
            var a = new BrakeSpecificFuelConsumption(valueA, unitA);
            var b = new BrakeSpecificFuelConsumption(valueB, unitB);

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
            var a = BrakeSpecificFuelConsumption.Zero;

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
            var v = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.True(v.Equals(BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1), KilogramsPerJouleTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(BrakeSpecificFuelConsumption.Zero, KilogramsPerJouleTolerance, ComparisonType.Relative));
            Assert.True(BrakeSpecificFuelConsumption.FromKilogramsPerJoule(100).Equals(BrakeSpecificFuelConsumption.FromKilogramsPerJoule(120), (double)0.3m, ComparisonType.Relative));
            Assert.False(BrakeSpecificFuelConsumption.FromKilogramsPerJoule(100).Equals(BrakeSpecificFuelConsumption.FromKilogramsPerJoule(120), (double)0.1m, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.False(kilogramperjoule.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.False(kilogramperjoule.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(BrakeSpecificFuelConsumptionUnit)).Cast<BrakeSpecificFuelConsumptionUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(BrakeSpecificFuelConsumption.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            using var _ = new CultureScope("en-US");
            Assert.Equal("1 g/kWh", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour).ToString());
            Assert.Equal("1 kg/J", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString());
            Assert.Equal("1 lb/hph", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour).ToString());
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 g/kWh", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour).ToString(swedishCulture));
            Assert.Equal("1 kg/J", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString(swedishCulture));
            Assert.Equal("1 lb/hph", new BrakeSpecificFuelConsumption(1, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var _ = new CultureScope(CultureInfo.InvariantCulture);
            Assert.Equal("0.1 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s1"));
            Assert.Equal("0.12 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s2"));
            Assert.Equal("0.123 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s3"));
            Assert.Equal("0.1235 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s4"));
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s1", culture));
            Assert.Equal("0.12 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s2", culture));
            Assert.Equal("0.123 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s3", culture));
            Assert.Equal("0.1235 kg/J", new BrakeSpecificFuelConsumption(0.123456, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
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
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(BrakeSpecificFuelConsumption)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(BrakeSpecificFuelConsumptionUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal(BrakeSpecificFuelConsumption.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal(BrakeSpecificFuelConsumption.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1.0);
            Assert.Equal(new {BrakeSpecificFuelConsumption.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(value);
            Assert.Equal(BrakeSpecificFuelConsumption.FromKilogramsPerJoule(-value), -quantity);
        }
    }
}

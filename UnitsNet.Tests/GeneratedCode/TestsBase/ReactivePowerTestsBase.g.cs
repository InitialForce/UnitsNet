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
    /// Test of ReactivePower.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ReactivePowerTestsBase : QuantityTestsBase
    {
        protected abstract double GigavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double KilovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double MegavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double VoltamperesReactiveInOneVoltampereReactive { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GigavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double KilovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double MegavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double VoltamperesReactiveTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ReactivePowerUnit unit)
        {
            return unit switch
            {
                ReactivePowerUnit.GigavoltampereReactive => (GigavoltamperesReactiveInOneVoltampereReactive, GigavoltamperesReactiveTolerance),
                ReactivePowerUnit.KilovoltampereReactive => (KilovoltamperesReactiveInOneVoltampereReactive, KilovoltamperesReactiveTolerance),
                ReactivePowerUnit.MegavoltampereReactive => (MegavoltamperesReactiveInOneVoltampereReactive, MegavoltamperesReactiveTolerance),
                ReactivePowerUnit.VoltampereReactive => (VoltamperesReactiveInOneVoltampereReactive, VoltamperesReactiveTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ReactivePowerUnit.GigavoltampereReactive },
            new object[] { ReactivePowerUnit.KilovoltampereReactive },
            new object[] { ReactivePowerUnit.MegavoltampereReactive },
            new object[] { ReactivePowerUnit.VoltampereReactive },
        };

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactivePower((double)0.0, ReactivePowerUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ReactivePower();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ReactivePowerUnit.VoltampereReactive, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactivePower(double.PositiveInfinity, ReactivePowerUnit.VoltampereReactive));
            Assert.Throws<ArgumentException>(() => new ReactivePower(double.NegativeInfinity, ReactivePowerUnit.VoltampereReactive));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactivePower(double.NaN, ReactivePowerUnit.VoltampereReactive));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ReactivePower(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ReactivePower(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ReactivePower) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ReactivePower_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ReactivePower(1, ReactivePowerUnit.VoltampereReactive);

            QuantityInfo<ReactivePowerUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ReactivePower.Zero, quantityInfo.Zero);
            Assert.Equal("ReactivePower", quantityInfo.Name);
            Assert.Equal(QuantityType.ReactivePower, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ReactivePowerUnit>().Except(new[] {ReactivePowerUnit.Undefined}).OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void VoltampereReactiveToReactivePowerUnits()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(GigavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.GigavoltamperesReactive, GigavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(KilovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.KilovoltamperesReactive, KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MegavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.MegavoltamperesReactive, MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(VoltamperesReactiveInOneVoltampereReactive, voltamperereactive.VoltamperesReactive, VoltamperesReactiveTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ReactivePower.From(1, ReactivePowerUnit.GigavoltampereReactive);
            AssertEx.EqualTolerance(1, quantity00.GigavoltamperesReactive, GigavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.GigavoltampereReactive, quantity00.Unit);

            var quantity01 = ReactivePower.From(1, ReactivePowerUnit.KilovoltampereReactive);
            AssertEx.EqualTolerance(1, quantity01.KilovoltamperesReactive, KilovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.KilovoltampereReactive, quantity01.Unit);

            var quantity02 = ReactivePower.From(1, ReactivePowerUnit.MegavoltampereReactive);
            AssertEx.EqualTolerance(1, quantity02.MegavoltamperesReactive, MegavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.MegavoltampereReactive, quantity02.Unit);

            var quantity03 = ReactivePower.From(1, ReactivePowerUnit.VoltampereReactive);
            AssertEx.EqualTolerance(1, quantity03.VoltamperesReactive, VoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.VoltampereReactive, quantity03.Unit);

        }

        [Fact]
        public void FromVoltamperesReactive_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReactivePower.FromVoltamperesReactive(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ReactivePower.FromVoltamperesReactive(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltamperesReactive_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReactivePower.FromVoltamperesReactive(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(GigavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.GigavoltampereReactive), GigavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(KilovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.KilovoltampereReactive), KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MegavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.MegavoltampereReactive), MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(VoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.VoltampereReactive), VoltamperesReactiveTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ReactivePower(value: 1, unit: ReactivePower.BaseUnit);
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
                var parsed = ReactivePower.Parse("1 Gvar", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.GigavoltamperesReactive, GigavoltamperesReactiveTolerance);
                Assert.Equal(ReactivePowerUnit.GigavoltampereReactive, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ReactivePower.Parse("1 kvar", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilovoltamperesReactive, KilovoltamperesReactiveTolerance);
                Assert.Equal(ReactivePowerUnit.KilovoltampereReactive, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ReactivePower.Parse("1 Mvar", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.MegavoltamperesReactive, MegavoltamperesReactiveTolerance);
                Assert.Equal(ReactivePowerUnit.MegavoltampereReactive, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ReactivePower.Parse("1 var", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.VoltamperesReactive, VoltamperesReactiveTolerance);
                Assert.Equal(ReactivePowerUnit.VoltampereReactive, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ReactivePower.TryParse("1 Gvar", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.GigavoltamperesReactive, GigavoltamperesReactiveTolerance);
                Assert.Equal(ReactivePowerUnit.GigavoltampereReactive, parsed.Unit);
            }

            {
                Assert.True(ReactivePower.TryParse("1 kvar", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilovoltamperesReactive, KilovoltamperesReactiveTolerance);
                Assert.Equal(ReactivePowerUnit.KilovoltampereReactive, parsed.Unit);
            }

            {
                Assert.True(ReactivePower.TryParse("1 Mvar", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.MegavoltamperesReactive, MegavoltamperesReactiveTolerance);
                Assert.Equal(ReactivePowerUnit.MegavoltampereReactive, parsed.Unit);
            }

            {
                Assert.True(ReactivePower.TryParse("1 var", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.VoltamperesReactive, VoltamperesReactiveTolerance);
                Assert.Equal(ReactivePowerUnit.VoltampereReactive, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = ReactivePower.ParseUnit("Gvar", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ReactivePowerUnit.GigavoltampereReactive, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ReactivePower.ParseUnit("kvar", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ReactivePowerUnit.KilovoltampereReactive, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ReactivePower.ParseUnit("Mvar", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ReactivePowerUnit.MegavoltampereReactive, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ReactivePower.ParseUnit("var", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ReactivePowerUnit.VoltampereReactive, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(ReactivePower.TryParseUnit("Gvar", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ReactivePowerUnit.GigavoltampereReactive, parsedUnit);
            }

            {
                Assert.True(ReactivePower.TryParseUnit("kvar", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ReactivePowerUnit.KilovoltampereReactive, parsedUnit);
            }

            {
                Assert.True(ReactivePower.TryParseUnit("Mvar", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ReactivePowerUnit.MegavoltampereReactive, parsedUnit);
            }

            {
                Assert.True(ReactivePower.TryParseUnit("var", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ReactivePowerUnit.VoltampereReactive, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ReactivePowerUnit unit)
        {
            var inBaseUnits = ReactivePower.From(1.0, ReactivePower.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, (double)converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ReactivePowerUnit unit)
        {
            var quantity = ReactivePower.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ReactivePowerUnit unit)
        {
            // See if there is a unit available that is not the base unit.
            var fromUnit = ReactivePower.Units.FirstOrDefault(u => u != ReactivePower.BaseUnit && u != ReactivePowerUnit.Undefined);

            // If there is only one unit for the quantity, we must use the base unit.
            if (fromUnit == ReactivePowerUnit.Undefined)
                fromUnit = ReactivePower.BaseUnit;

            var quantity = ReactivePower.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(1, ReactivePower.FromGigavoltamperesReactive(voltamperereactive.GigavoltamperesReactive).VoltamperesReactive, GigavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromKilovoltamperesReactive(voltamperereactive.KilovoltamperesReactive).VoltamperesReactive, KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromMegavoltamperesReactive(voltamperereactive.MegavoltamperesReactive).VoltamperesReactive, MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromVoltamperesReactive(voltamperereactive.VoltamperesReactive).VoltamperesReactive, VoltamperesReactiveTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ReactivePower v = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(-1, -v.VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (ReactivePower.FromVoltamperesReactive(3)-v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (ReactivePower.FromVoltamperesReactive(10)/5).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, ReactivePower.FromVoltamperesReactive(10)/ReactivePower.FromVoltamperesReactive(5), VoltamperesReactiveTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ReactivePower oneVoltampereReactive = ReactivePower.FromVoltamperesReactive(1);
            ReactivePower twoVoltamperesReactive = ReactivePower.FromVoltamperesReactive(2);

            Assert.True(oneVoltampereReactive < twoVoltamperesReactive);
            Assert.True(oneVoltampereReactive <= twoVoltamperesReactive);
            Assert.True(twoVoltamperesReactive > oneVoltampereReactive);
            Assert.True(twoVoltamperesReactive >= oneVoltampereReactive);

            Assert.False(oneVoltampereReactive > twoVoltamperesReactive);
            Assert.False(oneVoltampereReactive >= twoVoltamperesReactive);
            Assert.False(twoVoltamperesReactive < oneVoltampereReactive);
            Assert.False(twoVoltamperesReactive <= oneVoltampereReactive);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Equal(0, voltamperereactive.CompareTo(voltamperereactive));
            Assert.True(voltamperereactive.CompareTo(ReactivePower.Zero) > 0);
            Assert.True(ReactivePower.Zero.CompareTo(voltamperereactive) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Throws<ArgumentException>(() => voltamperereactive.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Throws<ArgumentNullException>(() => voltamperereactive.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ReactivePower.FromVoltamperesReactive(1);
            var b = ReactivePower.FromVoltamperesReactive(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = ReactivePower.FromVoltamperesReactive(1);
            var b = ReactivePower.FromVoltamperesReactive(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ReactivePower.FromVoltamperesReactive(1);
            object b = ReactivePower.FromVoltamperesReactive(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ReactivePower.FromVoltamperesReactive(1);
            Assert.True(v.Equals(ReactivePower.FromVoltamperesReactive(1), VoltamperesReactiveTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ReactivePower.Zero, VoltamperesReactiveTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ReactivePower.FromVoltamperesReactive(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ReactivePower.FromVoltamperesReactive(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.False(voltamperereactive.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.False(voltamperereactive.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ReactivePowerUnit.Undefined, ReactivePower.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ReactivePowerUnit)).Cast<ReactivePowerUnit>();
            foreach(var unit in units)
            {
                if (unit == ReactivePowerUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ReactivePower.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 Gvar", new ReactivePower(1, ReactivePowerUnit.GigavoltampereReactive).ToString());
                Assert.Equal("1 kvar", new ReactivePower(1, ReactivePowerUnit.KilovoltampereReactive).ToString());
                Assert.Equal("1 Mvar", new ReactivePower(1, ReactivePowerUnit.MegavoltampereReactive).ToString());
                Assert.Equal("1 var", new ReactivePower(1, ReactivePowerUnit.VoltampereReactive).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 Gvar", new ReactivePower(1, ReactivePowerUnit.GigavoltampereReactive).ToString(swedishCulture));
            Assert.Equal("1 kvar", new ReactivePower(1, ReactivePowerUnit.KilovoltampereReactive).ToString(swedishCulture));
            Assert.Equal("1 Mvar", new ReactivePower(1, ReactivePowerUnit.MegavoltampereReactive).ToString(swedishCulture));
            Assert.Equal("1 var", new ReactivePower(1, ReactivePowerUnit.VoltampereReactive).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s1"));
                Assert.Equal("0.12 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s2"));
                Assert.Equal("0.123 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s3"));
                Assert.Equal("0.1235 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s1", culture));
            Assert.Equal("0.12 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s2", culture));
            Assert.Equal("0.123 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s3", culture));
            Assert.Equal("0.1235 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ReactivePower)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ReactivePowerUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(QuantityType.ReactivePower, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(ReactivePower.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(ReactivePower.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(new {ReactivePower.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ReactivePower.FromVoltamperesReactive(value);
            Assert.Equal(ReactivePower.FromVoltamperesReactive(-value), -quantity);
        }
    }
}

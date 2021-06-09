﻿//------------------------------------------------------------------------------
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
    /// Test of SpecificFuelConsumption.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpecificFuelConsumptionTestsBase : QuantityTestsBase
    {
        protected abstract double GramsPerKiloNewtonSecondInOnePoundMassPerPoundForceHour { get; }
        protected abstract double KilogramsPerKilogramForceHourInOnePoundMassPerPoundForceHour { get; }
        protected abstract double PoundsMassPerPoundForceHourInOnePoundMassPerPoundForceHour { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GramsPerKiloNewtonSecondTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerKilogramForceHourTolerance { get { return 1e-5; } }
        protected virtual double PoundsMassPerPoundForceHourTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificFuelConsumption((double)0.0, SpecificFuelConsumptionUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new SpecificFuelConsumption();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificFuelConsumption(double.PositiveInfinity, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour));
            Assert.Throws<ArgumentException>(() => new SpecificFuelConsumption(double.NegativeInfinity, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificFuelConsumption(double.NaN, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new SpecificFuelConsumption(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new SpecificFuelConsumption(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (SpecificFuelConsumption) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void SpecificFuelConsumption_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour);

            QuantityInfo<SpecificFuelConsumptionUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(SpecificFuelConsumption.Zero, quantityInfo.Zero);
            Assert.Equal("SpecificFuelConsumption", quantityInfo.Name);
            Assert.Equal(QuantityType.SpecificFuelConsumption, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<SpecificFuelConsumptionUnit>().Except(new[] {SpecificFuelConsumptionUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void PoundMassPerPoundForceHourToSpecificFuelConsumptionUnits()
        {
            SpecificFuelConsumption poundmassperpoundforcehour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            AssertEx.EqualTolerance(GramsPerKiloNewtonSecondInOnePoundMassPerPoundForceHour, poundmassperpoundforcehour.GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(KilogramsPerKilogramForceHourInOnePoundMassPerPoundForceHour, poundmassperpoundforcehour.KilogramsPerKilogramForceHour, KilogramsPerKilogramForceHourTolerance);
            AssertEx.EqualTolerance(PoundsMassPerPoundForceHourInOnePoundMassPerPoundForceHour, poundmassperpoundforcehour.PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = SpecificFuelConsumption.From(1, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond);
            AssertEx.EqualTolerance(1, quantity00.GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            Assert.Equal(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond, quantity00.Unit);

            var quantity01 = SpecificFuelConsumption.From(1, SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour);
            AssertEx.EqualTolerance(1, quantity01.KilogramsPerKilogramForceHour, KilogramsPerKilogramForceHourTolerance);
            Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour, quantity01.Unit);

            var quantity02 = SpecificFuelConsumption.From(1, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour);
            AssertEx.EqualTolerance(1, quantity02.PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
            Assert.Equal(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, quantity02.Unit);

        }

        [Fact]
        public void FromPoundsMassPerPoundForceHour_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(double.NegativeInfinity));
        }

        [Fact]
        public void FromPoundsMassPerPoundForceHour_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(double.NaN));
        }

        [Fact]
        public void As()
        {
            var poundmassperpoundforcehour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            AssertEx.EqualTolerance(GramsPerKiloNewtonSecondInOnePoundMassPerPoundForceHour, poundmassperpoundforcehour.As(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond), GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(KilogramsPerKilogramForceHourInOnePoundMassPerPoundForceHour, poundmassperpoundforcehour.As(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour), KilogramsPerKilogramForceHourTolerance);
            AssertEx.EqualTolerance(PoundsMassPerPoundForceHourInOnePoundMassPerPoundForceHour, poundmassperpoundforcehour.As(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour), PoundsMassPerPoundForceHourTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new SpecificFuelConsumption(value: 1, unit: SpecificFuelConsumption.BaseUnit);
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
        public void ToUnit()
        {
            var poundmassperpoundforcehour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);

            var gramperkilonewtonsecondQuantity = poundmassperpoundforcehour.ToUnit(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond);
            AssertEx.EqualTolerance(GramsPerKiloNewtonSecondInOnePoundMassPerPoundForceHour, (double)gramperkilonewtonsecondQuantity.Value, GramsPerKiloNewtonSecondTolerance);
            Assert.Equal(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond, gramperkilonewtonsecondQuantity.Unit);

            var kilogramperkilogramforcehourQuantity = poundmassperpoundforcehour.ToUnit(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour);
            AssertEx.EqualTolerance(KilogramsPerKilogramForceHourInOnePoundMassPerPoundForceHour, (double)kilogramperkilogramforcehourQuantity.Value, KilogramsPerKilogramForceHourTolerance);
            Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour, kilogramperkilogramforcehourQuantity.Unit);

            var poundmassperpoundforcehourQuantity = poundmassperpoundforcehour.ToUnit(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour);
            AssertEx.EqualTolerance(PoundsMassPerPoundForceHourInOnePoundMassPerPoundForceHour, (double)poundmassperpoundforcehourQuantity.Value, PoundsMassPerPoundForceHourTolerance);
            Assert.Equal(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, poundmassperpoundforcehourQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1).ToBaseUnit();
            Assert.Equal(SpecificFuelConsumption.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SpecificFuelConsumption poundmassperpoundforcehour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            AssertEx.EqualTolerance(1, SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(poundmassperpoundforcehour.GramsPerKiloNewtonSecond).PoundsMassPerPoundForceHour, GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(1, SpecificFuelConsumption.FromKilogramsPerKilogramForceHour(poundmassperpoundforcehour.KilogramsPerKilogramForceHour).PoundsMassPerPoundForceHour, KilogramsPerKilogramForceHourTolerance);
            AssertEx.EqualTolerance(1, SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(poundmassperpoundforcehour.PoundsMassPerPoundForceHour).PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SpecificFuelConsumption v = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            AssertEx.EqualTolerance(-1, -v.PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
            AssertEx.EqualTolerance(2, (SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(3)-v).PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
            AssertEx.EqualTolerance(2, (v + v).PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
            AssertEx.EqualTolerance(10, (v*10).PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
            AssertEx.EqualTolerance(10, (10*v).PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
            AssertEx.EqualTolerance(2, (SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(10)/5).PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
            AssertEx.EqualTolerance(2, SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(10)/SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(5), PoundsMassPerPoundForceHourTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SpecificFuelConsumption onePoundMassPerPoundForceHour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            SpecificFuelConsumption twoPoundsMassPerPoundForceHour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(2);

            Assert.True(onePoundMassPerPoundForceHour < twoPoundsMassPerPoundForceHour);
            Assert.True(onePoundMassPerPoundForceHour <= twoPoundsMassPerPoundForceHour);
            Assert.True(twoPoundsMassPerPoundForceHour > onePoundMassPerPoundForceHour);
            Assert.True(twoPoundsMassPerPoundForceHour >= onePoundMassPerPoundForceHour);

            Assert.False(onePoundMassPerPoundForceHour > twoPoundsMassPerPoundForceHour);
            Assert.False(onePoundMassPerPoundForceHour >= twoPoundsMassPerPoundForceHour);
            Assert.False(twoPoundsMassPerPoundForceHour < onePoundMassPerPoundForceHour);
            Assert.False(twoPoundsMassPerPoundForceHour <= onePoundMassPerPoundForceHour);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SpecificFuelConsumption poundmassperpoundforcehour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            Assert.Equal(0, poundmassperpoundforcehour.CompareTo(poundmassperpoundforcehour));
            Assert.True(poundmassperpoundforcehour.CompareTo(SpecificFuelConsumption.Zero) > 0);
            Assert.True(SpecificFuelConsumption.Zero.CompareTo(poundmassperpoundforcehour) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SpecificFuelConsumption poundmassperpoundforcehour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            Assert.Throws<ArgumentException>(() => poundmassperpoundforcehour.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SpecificFuelConsumption poundmassperpoundforcehour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            Assert.Throws<ArgumentNullException>(() => poundmassperpoundforcehour.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            var b = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(2);

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
            var a = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            var b = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            object b = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            Assert.True(v.Equals(SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1), PoundsMassPerPoundForceHourTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(SpecificFuelConsumption.Zero, PoundsMassPerPoundForceHourTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SpecificFuelConsumption poundmassperpoundforcehour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            Assert.False(poundmassperpoundforcehour.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SpecificFuelConsumption poundmassperpoundforcehour = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1);
            Assert.False(poundmassperpoundforcehour.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(SpecificFuelConsumptionUnit.Undefined, SpecificFuelConsumption.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(SpecificFuelConsumptionUnit)).Cast<SpecificFuelConsumptionUnit>();
            foreach(var unit in units)
            {
                if(unit == SpecificFuelConsumptionUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(SpecificFuelConsumption.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 g/(kN*s)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString());
                Assert.Equal("1 kg/(kgf*h)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour).ToString());
                Assert.Equal("1 lb/(lbf*h)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString());
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

            Assert.Equal("1 g/(kN*s)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString(swedishCulture));
            Assert.Equal("1 kg/(kgf*h)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour).ToString(swedishCulture));
            Assert.Equal("1 lb/(lbf*h)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 lb/(lbf*h)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString("s1"));
                Assert.Equal("0.12 lb/(lbf*h)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString("s2"));
                Assert.Equal("0.123 lb/(lbf*h)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString("s3"));
                Assert.Equal("0.1235 lb/(lbf*h)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString("s4"));
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
            Assert.Equal("0.1 lb/(lbf*h)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString("s1", culture));
            Assert.Equal("0.12 lb/(lbf*h)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString("s2", culture));
            Assert.Equal("0.123 lb/(lbf*h)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString("s3", culture));
            Assert.Equal("0.1235 lb/(lbf*h)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(SpecificFuelConsumption)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(SpecificFuelConsumptionUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal(QuantityType.SpecificFuelConsumption, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal(SpecificFuelConsumption.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal(SpecificFuelConsumption.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(1.0);
            Assert.Equal(new {SpecificFuelConsumption.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(value);
            Assert.Equal(SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(-value), -quantity);
        }
    }
}

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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ThermalConductivity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ThermalConductivityTestsBase
    {
        protected abstract double BtusPerHourFootFahrenheitInOneWattPerMeterKelvin { get; }
        protected abstract double WattsPerMeterKelvinInOneWattPerMeterKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BtusPerHourFootFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double WattsPerMeterKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalConductivity<double>((double)0.0, ThermalConductivityUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalConductivity<double>(double.PositiveInfinity, ThermalConductivityUnit.WattPerMeterKelvin));
            Assert.Throws<ArgumentException>(() => new ThermalConductivity<double>(double.NegativeInfinity, ThermalConductivityUnit.WattPerMeterKelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalConductivity<double>(double.NaN, ThermalConductivityUnit.WattPerMeterKelvin));
        }

        [Fact]
        public void WattPerMeterKelvinToThermalConductivityUnits()
        {
            ThermalConductivity<double> wattpermeterkelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(BtusPerHourFootFahrenheitInOneWattPerMeterKelvin, wattpermeterkelvin.BtusPerHourFootFahrenheit, BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(WattsPerMeterKelvinInOneWattPerMeterKelvin, wattpermeterkelvin.WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ThermalConductivity<double>.From(1, ThermalConductivityUnit.BtuPerHourFootFahrenheit).BtusPerHourFootFahrenheit, BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(1, ThermalConductivity<double>.From(1, ThermalConductivityUnit.WattPerMeterKelvin).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void FromWattsPerMeterKelvin_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThermalConductivity<double>.FromWattsPerMeterKelvin(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ThermalConductivity<double>.FromWattsPerMeterKelvin(double.NegativeInfinity));
        }

        [Fact]
        public void FromWattsPerMeterKelvin_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThermalConductivity<double>.FromWattsPerMeterKelvin(double.NaN));
        }

        [Fact]
        public void As()
        {
            var wattpermeterkelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(BtusPerHourFootFahrenheitInOneWattPerMeterKelvin, wattpermeterkelvin.As(ThermalConductivityUnit.BtuPerHourFootFahrenheit), BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(WattsPerMeterKelvinInOneWattPerMeterKelvin, wattpermeterkelvin.As(ThermalConductivityUnit.WattPerMeterKelvin), WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var wattpermeterkelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);

            var btuperhourfootfahrenheitQuantity = wattpermeterkelvin.ToUnit(ThermalConductivityUnit.BtuPerHourFootFahrenheit);
            AssertEx.EqualTolerance(BtusPerHourFootFahrenheitInOneWattPerMeterKelvin, (double)btuperhourfootfahrenheitQuantity.Value, BtusPerHourFootFahrenheitTolerance);
            Assert.Equal(ThermalConductivityUnit.BtuPerHourFootFahrenheit, btuperhourfootfahrenheitQuantity.Unit);

            var wattpermeterkelvinQuantity = wattpermeterkelvin.ToUnit(ThermalConductivityUnit.WattPerMeterKelvin);
            AssertEx.EqualTolerance(WattsPerMeterKelvinInOneWattPerMeterKelvin, (double)wattpermeterkelvinQuantity.Value, WattsPerMeterKelvinTolerance);
            Assert.Equal(ThermalConductivityUnit.WattPerMeterKelvin, wattpermeterkelvinQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ThermalConductivity<double> wattpermeterkelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(1, ThermalConductivity<double>.FromBtusPerHourFootFahrenheit(wattpermeterkelvin.BtusPerHourFootFahrenheit).WattsPerMeterKelvin, BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(1, ThermalConductivity<double>.FromWattsPerMeterKelvin(wattpermeterkelvin.WattsPerMeterKelvin).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ThermalConductivity<double> v = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(-1, -v.WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (ThermalConductivity<double>.FromWattsPerMeterKelvin(3)-v).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (ThermalConductivity<double>.FromWattsPerMeterKelvin(10)/5).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, ThermalConductivity<double>.FromWattsPerMeterKelvin(10)/ThermalConductivity<double>.FromWattsPerMeterKelvin(5), WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ThermalConductivity<double> oneWattPerMeterKelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            ThermalConductivity<double> twoWattsPerMeterKelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(2);

            Assert.True(oneWattPerMeterKelvin < twoWattsPerMeterKelvin);
            Assert.True(oneWattPerMeterKelvin <= twoWattsPerMeterKelvin);
            Assert.True(twoWattsPerMeterKelvin > oneWattPerMeterKelvin);
            Assert.True(twoWattsPerMeterKelvin >= oneWattPerMeterKelvin);

            Assert.False(oneWattPerMeterKelvin > twoWattsPerMeterKelvin);
            Assert.False(oneWattPerMeterKelvin >= twoWattsPerMeterKelvin);
            Assert.False(twoWattsPerMeterKelvin < oneWattPerMeterKelvin);
            Assert.False(twoWattsPerMeterKelvin <= oneWattPerMeterKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ThermalConductivity<double> wattpermeterkelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            Assert.Equal(0, wattpermeterkelvin.CompareTo(wattpermeterkelvin));
            Assert.True(wattpermeterkelvin.CompareTo(ThermalConductivity<double>.Zero) > 0);
            Assert.True(ThermalConductivity<double>.Zero.CompareTo(wattpermeterkelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ThermalConductivity<double> wattpermeterkelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ThermalConductivity<double> wattpermeterkelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            Assert.Throws<ArgumentNullException>(() => wattpermeterkelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            var b = ThermalConductivity<double>.FromWattsPerMeterKelvin(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            var b = ThermalConductivity<double>.FromWattsPerMeterKelvin(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            Assert.True(v.Equals(ThermalConductivity<double>.FromWattsPerMeterKelvin(1), WattsPerMeterKelvinTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ThermalConductivity<double>.Zero, WattsPerMeterKelvinTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ThermalConductivity<double> wattpermeterkelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            Assert.False(wattpermeterkelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ThermalConductivity<double> wattpermeterkelvin = ThermalConductivity<double>.FromWattsPerMeterKelvin(1);
            Assert.False(wattpermeterkelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ThermalConductivityUnit.Undefined, ThermalConductivity<double>.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ThermalConductivityUnit)).Cast<ThermalConductivityUnit>();
            foreach(var unit in units)
            {
                if(unit == ThermalConductivityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ThermalConductivity<double>.BaseDimensions is null);
        }
    }
}

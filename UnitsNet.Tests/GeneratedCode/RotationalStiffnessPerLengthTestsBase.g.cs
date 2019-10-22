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
    /// Test of RotationalStiffnessPerLength.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalStiffnessPerLengthTestsBase
    {
        protected abstract double KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter { get; }
        protected abstract double MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter { get; }
        protected abstract double NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilonewtonMetersPerRadianPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonMetersPerRadianPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonMetersPerRadianPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalStiffnessPerLength<double>((double)0.0, RotationalStiffnessPerLengthUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalStiffnessPerLength<double>(double.PositiveInfinity, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter));
            Assert.Throws<ArgumentException>(() => new RotationalStiffnessPerLength<double>(double.NegativeInfinity, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalStiffnessPerLength<double>(double.NaN, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter));
        }

        [Fact]
        public void NewtonMeterPerRadianPerMeterToRotationalStiffnessPerLengthUnits()
        {
            RotationalStiffnessPerLength<double> newtonmeterperradianpermeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.KilonewtonMetersPerRadianPerMeter, KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.MeganewtonMetersPerRadianPerMeter, MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength<double>.From(1, RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter).KilonewtonMetersPerRadianPerMeter, KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength<double>.From(1, RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter).MeganewtonMetersPerRadianPerMeter, MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength<double>.From(1, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void FromNewtonMetersPerRadianPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtonMetersPerRadianPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newtonmeterperradianpermeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter), KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter), MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter), NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newtonmeterperradianpermeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);

            var kilonewtonmeterperradianpermeterQuantity = newtonmeterperradianpermeter.ToUnit(RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, (double)kilonewtonmeterperradianpermeterQuantity.Value, KilonewtonMetersPerRadianPerMeterTolerance);
            Assert.Equal(RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter, kilonewtonmeterperradianpermeterQuantity.Unit);

            var meganewtonmeterperradianpermeterQuantity = newtonmeterperradianpermeter.ToUnit(RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, (double)meganewtonmeterperradianpermeterQuantity.Value, MeganewtonMetersPerRadianPerMeterTolerance);
            Assert.Equal(RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter, meganewtonmeterperradianpermeterQuantity.Unit);

            var newtonmeterperradianpermeterQuantity = newtonmeterperradianpermeter.ToUnit(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter);
            AssertEx.EqualTolerance(NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, (double)newtonmeterperradianpermeterQuantity.Value, NewtonMetersPerRadianPerMeterTolerance);
            Assert.Equal(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter, newtonmeterperradianpermeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalStiffnessPerLength<double> newtonmeterperradianpermeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength<double>.FromKilonewtonMetersPerRadianPerMeter(newtonmeterperradianpermeter.KilonewtonMetersPerRadianPerMeter).NewtonMetersPerRadianPerMeter, KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength<double>.FromMeganewtonMetersPerRadianPerMeter(newtonmeterperradianpermeter.MeganewtonMetersPerRadianPerMeter).NewtonMetersPerRadianPerMeter, MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(newtonmeterperradianpermeter.NewtonMetersPerRadianPerMeter).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalStiffnessPerLength<double> v = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, (RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(3)-v).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, (RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(10)/5).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(10)/RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(5), NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalStiffnessPerLength<double> oneNewtonMeterPerRadianPerMeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            RotationalStiffnessPerLength<double> twoNewtonMetersPerRadianPerMeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(2);

            Assert.True(oneNewtonMeterPerRadianPerMeter < twoNewtonMetersPerRadianPerMeter);
            Assert.True(oneNewtonMeterPerRadianPerMeter <= twoNewtonMetersPerRadianPerMeter);
            Assert.True(twoNewtonMetersPerRadianPerMeter > oneNewtonMeterPerRadianPerMeter);
            Assert.True(twoNewtonMetersPerRadianPerMeter >= oneNewtonMeterPerRadianPerMeter);

            Assert.False(oneNewtonMeterPerRadianPerMeter > twoNewtonMetersPerRadianPerMeter);
            Assert.False(oneNewtonMeterPerRadianPerMeter >= twoNewtonMetersPerRadianPerMeter);
            Assert.False(twoNewtonMetersPerRadianPerMeter < oneNewtonMeterPerRadianPerMeter);
            Assert.False(twoNewtonMetersPerRadianPerMeter <= oneNewtonMeterPerRadianPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalStiffnessPerLength<double> newtonmeterperradianpermeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            Assert.Equal(0, newtonmeterperradianpermeter.CompareTo(newtonmeterperradianpermeter));
            Assert.True(newtonmeterperradianpermeter.CompareTo(RotationalStiffnessPerLength<double>.Zero) > 0);
            Assert.True(RotationalStiffnessPerLength<double>.Zero.CompareTo(newtonmeterperradianpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalStiffnessPerLength<double> newtonmeterperradianpermeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            Assert.Throws<ArgumentException>(() => newtonmeterperradianpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalStiffnessPerLength<double> newtonmeterperradianpermeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => newtonmeterperradianpermeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            var b = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(2);

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
            var a = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            var b = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            Assert.True(v.Equals(RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1), NewtonMetersPerRadianPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RotationalStiffnessPerLength<double>.Zero, NewtonMetersPerRadianPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalStiffnessPerLength<double> newtonmeterperradianpermeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            Assert.False(newtonmeterperradianpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalStiffnessPerLength<double> newtonmeterperradianpermeter = RotationalStiffnessPerLength<double>.FromNewtonMetersPerRadianPerMeter(1);
            Assert.False(newtonmeterperradianpermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RotationalStiffnessPerLengthUnit.Undefined, RotationalStiffnessPerLength<double>.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RotationalStiffnessPerLengthUnit)).Cast<RotationalStiffnessPerLengthUnit>();
            foreach(var unit in units)
            {
                if(unit == RotationalStiffnessPerLengthUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RotationalStiffnessPerLength<double>.BaseDimensions is null);
        }
    }
}

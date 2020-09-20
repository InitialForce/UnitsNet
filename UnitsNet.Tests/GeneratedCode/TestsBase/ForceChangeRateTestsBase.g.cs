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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ForceChangeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ForceChangeRateTestsBase
    {
        protected abstract double CentinewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double DecanewtonsPerMinuteInOneNewtonPerSecond { get; }
        protected abstract double DecanewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double DecinewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double KilonewtonsPerMinuteInOneNewtonPerSecond { get; }
        protected abstract double KilonewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double MicronewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double MillinewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double NanonewtonsPerSecondInOneNewtonPerSecond { get; }
        protected abstract double NewtonsPerMinuteInOneNewtonPerSecond { get; }
        protected abstract double NewtonsPerSecondInOneNewtonPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentinewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecanewtonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double DecanewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecinewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicronewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MillinewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanonewtonsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ForceChangeRate((double)0.0, ForceChangeRateUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ForceChangeRate();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ForceChangeRateUnit.NewtonPerSecond, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ForceChangeRate(double.PositiveInfinity, ForceChangeRateUnit.NewtonPerSecond));
            Assert.Throws<ArgumentException>(() => new ForceChangeRate(double.NegativeInfinity, ForceChangeRateUnit.NewtonPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ForceChangeRate(double.NaN, ForceChangeRateUnit.NewtonPerSecond));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ForceChangeRate(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void ForceChangeRate_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ForceChangeRate(1, ForceChangeRateUnit.NewtonPerSecond);

            QuantityInfo<ForceChangeRateUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ForceChangeRate.Zero, quantityInfo.Zero);
            Assert.Equal("ForceChangeRate", quantityInfo.Name);
            Assert.Equal(QuantityType.ForceChangeRate, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ForceChangeRateUnit>().Except(new[] {ForceChangeRateUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void NewtonPerSecondToForceChangeRateUnits()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(CentinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.CentinewtonsPerSecond, CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.DecanewtonsPerMinute, DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.DecanewtonsPerSecond, DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.DecinewtonsPerSecond, DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.KilonewtonsPerMinute, KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.KilonewtonsPerSecond, KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MicronewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.MicronewtonsPerSecond, MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MillinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.MillinewtonsPerSecond, MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NanonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.NanonewtonsPerSecond, NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.NewtonsPerMinute, NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(NewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.NewtonsPerSecond, NewtonsPerSecondTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ForceChangeRate.From(1, ForceChangeRateUnit.CentinewtonPerSecond);
            AssertEx.EqualTolerance(1, quantity00.CentinewtonsPerSecond, CentinewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.CentinewtonPerSecond, quantity00.Unit);

            var quantity01 = ForceChangeRate.From(1, ForceChangeRateUnit.DecanewtonPerMinute);
            AssertEx.EqualTolerance(1, quantity01.DecanewtonsPerMinute, DecanewtonsPerMinuteTolerance);
            Assert.Equal(ForceChangeRateUnit.DecanewtonPerMinute, quantity01.Unit);

            var quantity02 = ForceChangeRate.From(1, ForceChangeRateUnit.DecanewtonPerSecond);
            AssertEx.EqualTolerance(1, quantity02.DecanewtonsPerSecond, DecanewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.DecanewtonPerSecond, quantity02.Unit);

            var quantity03 = ForceChangeRate.From(1, ForceChangeRateUnit.DecinewtonPerSecond);
            AssertEx.EqualTolerance(1, quantity03.DecinewtonsPerSecond, DecinewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.DecinewtonPerSecond, quantity03.Unit);

            var quantity04 = ForceChangeRate.From(1, ForceChangeRateUnit.KilonewtonPerMinute);
            AssertEx.EqualTolerance(1, quantity04.KilonewtonsPerMinute, KilonewtonsPerMinuteTolerance);
            Assert.Equal(ForceChangeRateUnit.KilonewtonPerMinute, quantity04.Unit);

            var quantity05 = ForceChangeRate.From(1, ForceChangeRateUnit.KilonewtonPerSecond);
            AssertEx.EqualTolerance(1, quantity05.KilonewtonsPerSecond, KilonewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.KilonewtonPerSecond, quantity05.Unit);

            var quantity06 = ForceChangeRate.From(1, ForceChangeRateUnit.MicronewtonPerSecond);
            AssertEx.EqualTolerance(1, quantity06.MicronewtonsPerSecond, MicronewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.MicronewtonPerSecond, quantity06.Unit);

            var quantity07 = ForceChangeRate.From(1, ForceChangeRateUnit.MillinewtonPerSecond);
            AssertEx.EqualTolerance(1, quantity07.MillinewtonsPerSecond, MillinewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.MillinewtonPerSecond, quantity07.Unit);

            var quantity08 = ForceChangeRate.From(1, ForceChangeRateUnit.NanonewtonPerSecond);
            AssertEx.EqualTolerance(1, quantity08.NanonewtonsPerSecond, NanonewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.NanonewtonPerSecond, quantity08.Unit);

            var quantity09 = ForceChangeRate.From(1, ForceChangeRateUnit.NewtonPerMinute);
            AssertEx.EqualTolerance(1, quantity09.NewtonsPerMinute, NewtonsPerMinuteTolerance);
            Assert.Equal(ForceChangeRateUnit.NewtonPerMinute, quantity09.Unit);

            var quantity10 = ForceChangeRate.From(1, ForceChangeRateUnit.NewtonPerSecond);
            AssertEx.EqualTolerance(1, quantity10.NewtonsPerSecond, NewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.NewtonPerSecond, quantity10.Unit);

        }

        [Fact]
        public void FromNewtonsPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ForceChangeRate.FromNewtonsPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ForceChangeRate.FromNewtonsPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtonsPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ForceChangeRate.FromNewtonsPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(CentinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.CentinewtonPerSecond), CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.DecanewtonPerMinute), DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(DecanewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.DecanewtonPerSecond), DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(DecinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.DecinewtonPerSecond), DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.KilonewtonPerMinute), KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.KilonewtonPerSecond), KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MicronewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.MicronewtonPerSecond), MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(MillinewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.MillinewtonPerSecond), MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NanonewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.NanonewtonPerSecond), NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(NewtonsPerMinuteInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.NewtonPerMinute), NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(NewtonsPerSecondInOneNewtonPerSecond, newtonpersecond.As(ForceChangeRateUnit.NewtonPerSecond), NewtonsPerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);

            var centinewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.CentinewtonPerSecond);
            AssertEx.EqualTolerance(CentinewtonsPerSecondInOneNewtonPerSecond, (double)centinewtonpersecondQuantity.Value, CentinewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.CentinewtonPerSecond, centinewtonpersecondQuantity.Unit);

            var decanewtonperminuteQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.DecanewtonPerMinute);
            AssertEx.EqualTolerance(DecanewtonsPerMinuteInOneNewtonPerSecond, (double)decanewtonperminuteQuantity.Value, DecanewtonsPerMinuteTolerance);
            Assert.Equal(ForceChangeRateUnit.DecanewtonPerMinute, decanewtonperminuteQuantity.Unit);

            var decanewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.DecanewtonPerSecond);
            AssertEx.EqualTolerance(DecanewtonsPerSecondInOneNewtonPerSecond, (double)decanewtonpersecondQuantity.Value, DecanewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.DecanewtonPerSecond, decanewtonpersecondQuantity.Unit);

            var decinewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.DecinewtonPerSecond);
            AssertEx.EqualTolerance(DecinewtonsPerSecondInOneNewtonPerSecond, (double)decinewtonpersecondQuantity.Value, DecinewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.DecinewtonPerSecond, decinewtonpersecondQuantity.Unit);

            var kilonewtonperminuteQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.KilonewtonPerMinute);
            AssertEx.EqualTolerance(KilonewtonsPerMinuteInOneNewtonPerSecond, (double)kilonewtonperminuteQuantity.Value, KilonewtonsPerMinuteTolerance);
            Assert.Equal(ForceChangeRateUnit.KilonewtonPerMinute, kilonewtonperminuteQuantity.Unit);

            var kilonewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.KilonewtonPerSecond);
            AssertEx.EqualTolerance(KilonewtonsPerSecondInOneNewtonPerSecond, (double)kilonewtonpersecondQuantity.Value, KilonewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.KilonewtonPerSecond, kilonewtonpersecondQuantity.Unit);

            var micronewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.MicronewtonPerSecond);
            AssertEx.EqualTolerance(MicronewtonsPerSecondInOneNewtonPerSecond, (double)micronewtonpersecondQuantity.Value, MicronewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.MicronewtonPerSecond, micronewtonpersecondQuantity.Unit);

            var millinewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.MillinewtonPerSecond);
            AssertEx.EqualTolerance(MillinewtonsPerSecondInOneNewtonPerSecond, (double)millinewtonpersecondQuantity.Value, MillinewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.MillinewtonPerSecond, millinewtonpersecondQuantity.Unit);

            var nanonewtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.NanonewtonPerSecond);
            AssertEx.EqualTolerance(NanonewtonsPerSecondInOneNewtonPerSecond, (double)nanonewtonpersecondQuantity.Value, NanonewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.NanonewtonPerSecond, nanonewtonpersecondQuantity.Unit);

            var newtonperminuteQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.NewtonPerMinute);
            AssertEx.EqualTolerance(NewtonsPerMinuteInOneNewtonPerSecond, (double)newtonperminuteQuantity.Value, NewtonsPerMinuteTolerance);
            Assert.Equal(ForceChangeRateUnit.NewtonPerMinute, newtonperminuteQuantity.Unit);

            var newtonpersecondQuantity = newtonpersecond.ToUnit(ForceChangeRateUnit.NewtonPerSecond);
            AssertEx.EqualTolerance(NewtonsPerSecondInOneNewtonPerSecond, (double)newtonpersecondQuantity.Value, NewtonsPerSecondTolerance);
            Assert.Equal(ForceChangeRateUnit.NewtonPerSecond, newtonpersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromCentinewtonsPerSecond(newtonpersecond.CentinewtonsPerSecond).NewtonsPerSecond, CentinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromDecanewtonsPerMinute(newtonpersecond.DecanewtonsPerMinute).NewtonsPerSecond, DecanewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromDecanewtonsPerSecond(newtonpersecond.DecanewtonsPerSecond).NewtonsPerSecond, DecanewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromDecinewtonsPerSecond(newtonpersecond.DecinewtonsPerSecond).NewtonsPerSecond, DecinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromKilonewtonsPerMinute(newtonpersecond.KilonewtonsPerMinute).NewtonsPerSecond, KilonewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromKilonewtonsPerSecond(newtonpersecond.KilonewtonsPerSecond).NewtonsPerSecond, KilonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromMicronewtonsPerSecond(newtonpersecond.MicronewtonsPerSecond).NewtonsPerSecond, MicronewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromMillinewtonsPerSecond(newtonpersecond.MillinewtonsPerSecond).NewtonsPerSecond, MillinewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromNanonewtonsPerSecond(newtonpersecond.NanonewtonsPerSecond).NewtonsPerSecond, NanonewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromNewtonsPerMinute(newtonpersecond.NewtonsPerMinute).NewtonsPerSecond, NewtonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, ForceChangeRate.FromNewtonsPerSecond(newtonpersecond.NewtonsPerSecond).NewtonsPerSecond, NewtonsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ForceChangeRate v = ForceChangeRate.FromNewtonsPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (ForceChangeRate.FromNewtonsPerSecond(3)-v).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (ForceChangeRate.FromNewtonsPerSecond(10)/5).NewtonsPerSecond, NewtonsPerSecondTolerance);
            AssertEx.EqualTolerance(2, ForceChangeRate.FromNewtonsPerSecond(10)/ForceChangeRate.FromNewtonsPerSecond(5), NewtonsPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ForceChangeRate oneNewtonPerSecond = ForceChangeRate.FromNewtonsPerSecond(1);
            ForceChangeRate twoNewtonsPerSecond = ForceChangeRate.FromNewtonsPerSecond(2);

            Assert.True(oneNewtonPerSecond < twoNewtonsPerSecond);
            Assert.True(oneNewtonPerSecond <= twoNewtonsPerSecond);
            Assert.True(twoNewtonsPerSecond > oneNewtonPerSecond);
            Assert.True(twoNewtonsPerSecond >= oneNewtonPerSecond);

            Assert.False(oneNewtonPerSecond > twoNewtonsPerSecond);
            Assert.False(oneNewtonPerSecond >= twoNewtonsPerSecond);
            Assert.False(twoNewtonsPerSecond < oneNewtonPerSecond);
            Assert.False(twoNewtonsPerSecond <= oneNewtonPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.Equal(0, newtonpersecond.CompareTo(newtonpersecond));
            Assert.True(newtonpersecond.CompareTo(ForceChangeRate.Zero) > 0);
            Assert.True(ForceChangeRate.Zero.CompareTo(newtonpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.Throws<ArgumentException>(() => newtonpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => newtonpersecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ForceChangeRate.FromNewtonsPerSecond(1);
            var b = ForceChangeRate.FromNewtonsPerSecond(2);

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
        public void Equals_SameType_IsImplemented()
        {
            var a = ForceChangeRate.FromNewtonsPerSecond(1);
            var b = ForceChangeRate.FromNewtonsPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ForceChangeRate.FromNewtonsPerSecond(1);
            object b = ForceChangeRate.FromNewtonsPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.True(v.Equals(ForceChangeRate.FromNewtonsPerSecond(1), NewtonsPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ForceChangeRate.Zero, NewtonsPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ForceChangeRate.FromNewtonsPerSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.False(newtonpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ForceChangeRate newtonpersecond = ForceChangeRate.FromNewtonsPerSecond(1);
            Assert.False(newtonpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ForceChangeRateUnit.Undefined, ForceChangeRate.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ForceChangeRateUnit)).Cast<ForceChangeRateUnit>();
            foreach(var unit in units)
            {
                if(unit == ForceChangeRateUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ForceChangeRate.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cN/s", new ForceChangeRate(1, ForceChangeRateUnit.CentinewtonPerSecond).ToString());
                Assert.Equal("1 daN/min", new ForceChangeRate(1, ForceChangeRateUnit.DecanewtonPerMinute).ToString());
                Assert.Equal("1 daN/s", new ForceChangeRate(1, ForceChangeRateUnit.DecanewtonPerSecond).ToString());
                Assert.Equal("1 dN/s", new ForceChangeRate(1, ForceChangeRateUnit.DecinewtonPerSecond).ToString());
                Assert.Equal("1 kN/min", new ForceChangeRate(1, ForceChangeRateUnit.KilonewtonPerMinute).ToString());
                Assert.Equal("1 kN/s", new ForceChangeRate(1, ForceChangeRateUnit.KilonewtonPerSecond).ToString());
                Assert.Equal("1 µN/s", new ForceChangeRate(1, ForceChangeRateUnit.MicronewtonPerSecond).ToString());
                Assert.Equal("1 mN/s", new ForceChangeRate(1, ForceChangeRateUnit.MillinewtonPerSecond).ToString());
                Assert.Equal("1 nN/s", new ForceChangeRate(1, ForceChangeRateUnit.NanonewtonPerSecond).ToString());
                Assert.Equal("1 N/min", new ForceChangeRate(1, ForceChangeRateUnit.NewtonPerMinute).ToString());
                Assert.Equal("1 N/s", new ForceChangeRate(1, ForceChangeRateUnit.NewtonPerSecond).ToString());
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

            Assert.Equal("1 cN/s", new ForceChangeRate(1, ForceChangeRateUnit.CentinewtonPerSecond).ToString(swedishCulture));
            Assert.Equal("1 daN/min", new ForceChangeRate(1, ForceChangeRateUnit.DecanewtonPerMinute).ToString(swedishCulture));
            Assert.Equal("1 daN/s", new ForceChangeRate(1, ForceChangeRateUnit.DecanewtonPerSecond).ToString(swedishCulture));
            Assert.Equal("1 dN/s", new ForceChangeRate(1, ForceChangeRateUnit.DecinewtonPerSecond).ToString(swedishCulture));
            Assert.Equal("1 kN/min", new ForceChangeRate(1, ForceChangeRateUnit.KilonewtonPerMinute).ToString(swedishCulture));
            Assert.Equal("1 kN/s", new ForceChangeRate(1, ForceChangeRateUnit.KilonewtonPerSecond).ToString(swedishCulture));
            Assert.Equal("1 µN/s", new ForceChangeRate(1, ForceChangeRateUnit.MicronewtonPerSecond).ToString(swedishCulture));
            Assert.Equal("1 mN/s", new ForceChangeRate(1, ForceChangeRateUnit.MillinewtonPerSecond).ToString(swedishCulture));
            Assert.Equal("1 nN/s", new ForceChangeRate(1, ForceChangeRateUnit.NanonewtonPerSecond).ToString(swedishCulture));
            Assert.Equal("1 N/min", new ForceChangeRate(1, ForceChangeRateUnit.NewtonPerMinute).ToString(swedishCulture));
            Assert.Equal("1 N/s", new ForceChangeRate(1, ForceChangeRateUnit.NewtonPerSecond).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 N/s", new ForceChangeRate(0.123456, ForceChangeRateUnit.NewtonPerSecond).ToString("s1"));
                Assert.Equal("0.12 N/s", new ForceChangeRate(0.123456, ForceChangeRateUnit.NewtonPerSecond).ToString("s2"));
                Assert.Equal("0.123 N/s", new ForceChangeRate(0.123456, ForceChangeRateUnit.NewtonPerSecond).ToString("s3"));
                Assert.Equal("0.1235 N/s", new ForceChangeRate(0.123456, ForceChangeRateUnit.NewtonPerSecond).ToString("s4"));
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
            Assert.Equal("0.1 N/s", new ForceChangeRate(0.123456, ForceChangeRateUnit.NewtonPerSecond).ToString("s1", culture));
            Assert.Equal("0.12 N/s", new ForceChangeRate(0.123456, ForceChangeRateUnit.NewtonPerSecond).ToString("s2", culture));
            Assert.Equal("0.123 N/s", new ForceChangeRate(0.123456, ForceChangeRateUnit.NewtonPerSecond).ToString("s3", culture));
            Assert.Equal("0.1235 N/s", new ForceChangeRate(0.123456, ForceChangeRateUnit.NewtonPerSecond).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ForceChangeRate)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ForceChangeRateUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal(QuantityType.ForceChangeRate, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Equal(ForceChangeRate.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(1.0);
            var roundedBaseValue = Math.Round(quantity.ToBaseUnit().Value, 5);
            Assert.Equal(new {ForceChangeRate.QuantityType, roundedBaseValue}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ForceChangeRate.FromNewtonsPerSecond(value);
            Assert.Equal(ForceChangeRate.FromNewtonsPerSecond(-value), -quantity);
        }

    }
}

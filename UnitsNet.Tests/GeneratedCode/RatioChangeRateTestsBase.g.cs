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
    /// Test of RatioChangeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RatioChangeRateTestsBase
    {
        protected abstract double DecimalFractionsPerSecondInOnePercentPerSecond { get; }
        protected abstract double PercentsPerSecondInOnePercentPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecimalFractionsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double PercentsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RatioChangeRate((double)0.0, RatioChangeRateUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RatioChangeRate(double.PositiveInfinity, RatioChangeRateUnit.PercentPerSecond));
            Assert.Throws<ArgumentException>(() => new RatioChangeRate(double.NegativeInfinity, RatioChangeRateUnit.PercentPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RatioChangeRate(double.NaN, RatioChangeRateUnit.PercentPerSecond));
        }

        [Fact]
        public void PercentPerSecondToRatioChangeRateUnits()
        {
            RatioChangeRate percentpersecond = RatioChangeRate.FromPercentsPerSecond(1);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOnePercentPerSecond, percentpersecond.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(PercentsPerSecondInOnePercentPerSecond, percentpersecond.PercentsPerSecond, PercentsPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, RatioChangeRate.From(1, RatioChangeRateUnit.DecimalFractionPerSecond).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(1, RatioChangeRate.From(1, RatioChangeRateUnit.PercentPerSecond).PercentsPerSecond, PercentsPerSecondTolerance);
        }

        [Fact]
        public void FromPercentsPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RatioChangeRate.FromPercentsPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => RatioChangeRate.FromPercentsPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromPercentsPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RatioChangeRate.FromPercentsPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var percentpersecond = RatioChangeRate.FromPercentsPerSecond(1);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOnePercentPerSecond, percentpersecond.As(RatioChangeRateUnit.DecimalFractionPerSecond), DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(PercentsPerSecondInOnePercentPerSecond, percentpersecond.As(RatioChangeRateUnit.PercentPerSecond), PercentsPerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var percentpersecond = RatioChangeRate.FromPercentsPerSecond(1);

            var decimalfractionpersecondQuantity = percentpersecond.ToUnit(RatioChangeRateUnit.DecimalFractionPerSecond);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOnePercentPerSecond, (double)decimalfractionpersecondQuantity.Value, DecimalFractionsPerSecondTolerance);
            Assert.Equal(RatioChangeRateUnit.DecimalFractionPerSecond, decimalfractionpersecondQuantity.Unit);

            var percentpersecondQuantity = percentpersecond.ToUnit(RatioChangeRateUnit.PercentPerSecond);
            AssertEx.EqualTolerance(PercentsPerSecondInOnePercentPerSecond, (double)percentpersecondQuantity.Value, PercentsPerSecondTolerance);
            Assert.Equal(RatioChangeRateUnit.PercentPerSecond, percentpersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RatioChangeRate percentpersecond = RatioChangeRate.FromPercentsPerSecond(1);
            AssertEx.EqualTolerance(1, RatioChangeRate.FromDecimalFractionsPerSecond(percentpersecond.DecimalFractionsPerSecond).PercentsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(1, RatioChangeRate.FromPercentsPerSecond(percentpersecond.PercentsPerSecond).PercentsPerSecond, PercentsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RatioChangeRate v = RatioChangeRate.FromPercentsPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.PercentsPerSecond, PercentsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RatioChangeRate.FromPercentsPerSecond(3)-v).PercentsPerSecond, PercentsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).PercentsPerSecond, PercentsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).PercentsPerSecond, PercentsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).PercentsPerSecond, PercentsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RatioChangeRate.FromPercentsPerSecond(10)/5).PercentsPerSecond, PercentsPerSecondTolerance);
            AssertEx.EqualTolerance(2, RatioChangeRate.FromPercentsPerSecond(10)/RatioChangeRate.FromPercentsPerSecond(5), PercentsPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RatioChangeRate onePercentPerSecond = RatioChangeRate.FromPercentsPerSecond(1);
            RatioChangeRate twoPercentsPerSecond = RatioChangeRate.FromPercentsPerSecond(2);

            Assert.True(onePercentPerSecond < twoPercentsPerSecond);
            Assert.True(onePercentPerSecond <= twoPercentsPerSecond);
            Assert.True(twoPercentsPerSecond > onePercentPerSecond);
            Assert.True(twoPercentsPerSecond >= onePercentPerSecond);

            Assert.False(onePercentPerSecond > twoPercentsPerSecond);
            Assert.False(onePercentPerSecond >= twoPercentsPerSecond);
            Assert.False(twoPercentsPerSecond < onePercentPerSecond);
            Assert.False(twoPercentsPerSecond <= onePercentPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RatioChangeRate percentpersecond = RatioChangeRate.FromPercentsPerSecond(1);
            Assert.Equal(0, percentpersecond.CompareTo(percentpersecond));
            Assert.True(percentpersecond.CompareTo(RatioChangeRate.Zero) > 0);
            Assert.True(RatioChangeRate.Zero.CompareTo(percentpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RatioChangeRate percentpersecond = RatioChangeRate.FromPercentsPerSecond(1);
            Assert.Throws<ArgumentException>(() => percentpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RatioChangeRate percentpersecond = RatioChangeRate.FromPercentsPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => percentpersecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = RatioChangeRate.FromPercentsPerSecond(1);
            var b = RatioChangeRate.FromPercentsPerSecond(2);

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
            var a = RatioChangeRate.FromPercentsPerSecond(1);
            var b = RatioChangeRate.FromPercentsPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = RatioChangeRate.FromPercentsPerSecond(1);
            Assert.True(v.Equals(RatioChangeRate.FromPercentsPerSecond(1), PercentsPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RatioChangeRate.Zero, PercentsPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RatioChangeRate percentpersecond = RatioChangeRate.FromPercentsPerSecond(1);
            Assert.False(percentpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RatioChangeRate percentpersecond = RatioChangeRate.FromPercentsPerSecond(1);
            Assert.False(percentpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RatioChangeRateUnit.Undefined, RatioChangeRate.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RatioChangeRateUnit)).Cast<RatioChangeRateUnit>();
            foreach(var unit in units)
            {
                if(unit == RatioChangeRateUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RatioChangeRate.BaseDimensions is null);
        }
    }
}

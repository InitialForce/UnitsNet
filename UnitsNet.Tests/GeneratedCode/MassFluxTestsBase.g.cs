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
    /// Test of MassFlux.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MassFluxTestsBase
    {
        protected abstract double GramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter { get; }
        protected abstract double KilogramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GramsPerSecondPerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerSecondPerSquareMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MassFlux((double)0.0, MassFluxUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MassFlux(double.PositiveInfinity, MassFluxUnit.KilogramPerSecondPerSquareMeter));
            Assert.Throws<ArgumentException>(() => new MassFlux(double.NegativeInfinity, MassFluxUnit.KilogramPerSecondPerSquareMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MassFlux(double.NaN, MassFluxUnit.KilogramPerSecondPerSquareMeter));
        }

        [Fact]
        public void KilogramPerSecondPerSquareMeterToMassFluxUnits()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(GramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, kilogrampersecondpersquaremeter.GramsPerSecondPerSquareMeter, GramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, kilogrampersecondpersquaremeter.KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, MassFlux.From(1, MassFluxUnit.GramPerSecondPerSquareMeter).GramsPerSecondPerSquareMeter, GramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, MassFlux.From(1, MassFluxUnit.KilogramPerSecondPerSquareMeter).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void FromKilogramsPerSecondPerSquareMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MassFlux.FromKilogramsPerSecondPerSquareMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => MassFlux.FromKilogramsPerSecondPerSquareMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromKilogramsPerSecondPerSquareMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MassFlux.FromKilogramsPerSecondPerSquareMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(GramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, kilogrampersecondpersquaremeter.As(MassFluxUnit.GramPerSecondPerSquareMeter), GramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, kilogrampersecondpersquaremeter.As(MassFluxUnit.KilogramPerSecondPerSquareMeter), KilogramsPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);

            var grampersecondpersquaremeterQuantity = kilogrampersecondpersquaremeter.ToUnit(MassFluxUnit.GramPerSecondPerSquareMeter);
            AssertEx.EqualTolerance(GramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, (double)grampersecondpersquaremeterQuantity.Value, GramsPerSecondPerSquareMeterTolerance);
            Assert.Equal(MassFluxUnit.GramPerSecondPerSquareMeter, grampersecondpersquaremeterQuantity.Unit);

            var kilogrampersecondpersquaremeterQuantity = kilogrampersecondpersquaremeter.ToUnit(MassFluxUnit.KilogramPerSecondPerSquareMeter);
            AssertEx.EqualTolerance(KilogramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, (double)kilogrampersecondpersquaremeterQuantity.Value, KilogramsPerSecondPerSquareMeterTolerance);
            Assert.Equal(MassFluxUnit.KilogramPerSecondPerSquareMeter, kilogrampersecondpersquaremeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(1, MassFlux.FromGramsPerSecondPerSquareMeter(kilogrampersecondpersquaremeter.GramsPerSecondPerSquareMeter).KilogramsPerSecondPerSquareMeter, GramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, MassFlux.FromKilogramsPerSecondPerSquareMeter(kilogrampersecondpersquaremeter.KilogramsPerSecondPerSquareMeter).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MassFlux v = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (MassFlux.FromKilogramsPerSecondPerSquareMeter(3)-v).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (MassFlux.FromKilogramsPerSecondPerSquareMeter(10)/5).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, MassFlux.FromKilogramsPerSecondPerSquareMeter(10)/MassFlux.FromKilogramsPerSecondPerSquareMeter(5), KilogramsPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MassFlux oneKilogramPerSecondPerSquareMeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            MassFlux twoKilogramsPerSecondPerSquareMeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(2);

            Assert.True(oneKilogramPerSecondPerSquareMeter < twoKilogramsPerSecondPerSquareMeter);
            Assert.True(oneKilogramPerSecondPerSquareMeter <= twoKilogramsPerSecondPerSquareMeter);
            Assert.True(twoKilogramsPerSecondPerSquareMeter > oneKilogramPerSecondPerSquareMeter);
            Assert.True(twoKilogramsPerSecondPerSquareMeter >= oneKilogramPerSecondPerSquareMeter);

            Assert.False(oneKilogramPerSecondPerSquareMeter > twoKilogramsPerSecondPerSquareMeter);
            Assert.False(oneKilogramPerSecondPerSquareMeter >= twoKilogramsPerSecondPerSquareMeter);
            Assert.False(twoKilogramsPerSecondPerSquareMeter < oneKilogramPerSecondPerSquareMeter);
            Assert.False(twoKilogramsPerSecondPerSquareMeter <= oneKilogramPerSecondPerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.Equal(0, kilogrampersecondpersquaremeter.CompareTo(kilogrampersecondpersquaremeter));
            Assert.True(kilogrampersecondpersquaremeter.CompareTo(MassFlux.Zero) > 0);
            Assert.True(MassFlux.Zero.CompareTo(kilogrampersecondpersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => kilogrampersecondpersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => kilogrampersecondpersquaremeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            var b = MassFlux.FromKilogramsPerSecondPerSquareMeter(2);

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
            var a = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            var b = MassFlux.FromKilogramsPerSecondPerSquareMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.True(v.Equals(MassFlux.FromKilogramsPerSecondPerSquareMeter(1), KilogramsPerSecondPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(MassFlux.Zero, KilogramsPerSecondPerSquareMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.False(kilogrampersecondpersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.False(kilogrampersecondpersquaremeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MassFluxUnit.Undefined, MassFlux.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MassFluxUnit)).Cast<MassFluxUnit>();
            foreach(var unit in units)
            {
                if(unit == MassFluxUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(MassFlux.BaseDimensions is null);
        }

        [Fact]
        public void CanCreateInstanceFromTuple()
        {
            MassFlux instance = (3.0, MassFluxUnit.KilogramPerSecondPerSquareMeter);

            Assert.Equal<QuantityValue>(3.0, instance.Value);
            Assert.Equal(MassFluxUnit.KilogramPerSecondPerSquareMeter, instance.Unit);
        }
    }
}

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
    /// Test of MagneticField.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MagneticFieldTestsBase
    {
        protected abstract double MicroteslasInOneTesla { get; }
        protected abstract double MilliteslasInOneTesla { get; }
        protected abstract double NanoteslasInOneTesla { get; }
        protected abstract double TeslasInOneTesla { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double MicroteslasTolerance { get { return 1e-5; } }
        protected virtual double MilliteslasTolerance { get { return 1e-5; } }
        protected virtual double NanoteslasTolerance { get { return 1e-5; } }
        protected virtual double TeslasTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MagneticField((double)0.0, MagneticFieldUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MagneticField(double.PositiveInfinity, MagneticFieldUnit.Tesla));
            Assert.Throws<ArgumentException>(() => new MagneticField(double.NegativeInfinity, MagneticFieldUnit.Tesla));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MagneticField(double.NaN, MagneticFieldUnit.Tesla));
        }

        [Fact]
        public void TeslaToMagneticFieldUnits()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(MicroteslasInOneTesla, tesla.Microteslas, MicroteslasTolerance);
            AssertEx.EqualTolerance(MilliteslasInOneTesla, tesla.Milliteslas, MilliteslasTolerance);
            AssertEx.EqualTolerance(NanoteslasInOneTesla, tesla.Nanoteslas, NanoteslasTolerance);
            AssertEx.EqualTolerance(TeslasInOneTesla, tesla.Teslas, TeslasTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, MagneticField.From(1, MagneticFieldUnit.Microtesla).Microteslas, MicroteslasTolerance);
            AssertEx.EqualTolerance(1, MagneticField.From(1, MagneticFieldUnit.Millitesla).Milliteslas, MilliteslasTolerance);
            AssertEx.EqualTolerance(1, MagneticField.From(1, MagneticFieldUnit.Nanotesla).Nanoteslas, NanoteslasTolerance);
            AssertEx.EqualTolerance(1, MagneticField.From(1, MagneticFieldUnit.Tesla).Teslas, TeslasTolerance);
        }

        [Fact]
        public void FromTeslas_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MagneticField.FromTeslas(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => MagneticField.FromTeslas(double.NegativeInfinity));
        }

        [Fact]
        public void FromTeslas_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MagneticField.FromTeslas(double.NaN));
        }

        [Fact]
        public void As()
        {
            var tesla = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(MicroteslasInOneTesla, tesla.As(MagneticFieldUnit.Microtesla), MicroteslasTolerance);
            AssertEx.EqualTolerance(MilliteslasInOneTesla, tesla.As(MagneticFieldUnit.Millitesla), MilliteslasTolerance);
            AssertEx.EqualTolerance(NanoteslasInOneTesla, tesla.As(MagneticFieldUnit.Nanotesla), NanoteslasTolerance);
            AssertEx.EqualTolerance(TeslasInOneTesla, tesla.As(MagneticFieldUnit.Tesla), TeslasTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var tesla = MagneticField.FromTeslas(1);

            var microteslaQuantity = tesla.ToUnit(MagneticFieldUnit.Microtesla);
            AssertEx.EqualTolerance(MicroteslasInOneTesla, (double)microteslaQuantity.Value, MicroteslasTolerance);
            Assert.Equal(MagneticFieldUnit.Microtesla, microteslaQuantity.Unit);

            var milliteslaQuantity = tesla.ToUnit(MagneticFieldUnit.Millitesla);
            AssertEx.EqualTolerance(MilliteslasInOneTesla, (double)milliteslaQuantity.Value, MilliteslasTolerance);
            Assert.Equal(MagneticFieldUnit.Millitesla, milliteslaQuantity.Unit);

            var nanoteslaQuantity = tesla.ToUnit(MagneticFieldUnit.Nanotesla);
            AssertEx.EqualTolerance(NanoteslasInOneTesla, (double)nanoteslaQuantity.Value, NanoteslasTolerance);
            Assert.Equal(MagneticFieldUnit.Nanotesla, nanoteslaQuantity.Unit);

            var teslaQuantity = tesla.ToUnit(MagneticFieldUnit.Tesla);
            AssertEx.EqualTolerance(TeslasInOneTesla, (double)teslaQuantity.Value, TeslasTolerance);
            Assert.Equal(MagneticFieldUnit.Tesla, teslaQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(1, MagneticField.FromMicroteslas(tesla.Microteslas).Teslas, MicroteslasTolerance);
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

        [Fact]
        public void EqualityOperators()
        {
            var a = MagneticField.FromTeslas(1);
            var b = MagneticField.FromTeslas(2);

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
            var a = MagneticField.FromTeslas(1);
            var b = MagneticField.FromTeslas(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = MagneticField.FromTeslas(1);
            Assert.True(v.Equals(MagneticField.FromTeslas(1), TeslasTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(MagneticField.Zero, TeslasTolerance, ComparisonType.Relative));
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
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MagneticFieldUnit.Undefined, MagneticField.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MagneticFieldUnit)).Cast<MagneticFieldUnit>();
            foreach(var unit in units)
            {
                if(unit == MagneticFieldUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(MagneticField.BaseDimensions is null);
        }
    }
}

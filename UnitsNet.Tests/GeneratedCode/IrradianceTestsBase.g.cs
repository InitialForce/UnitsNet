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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Irradiance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class IrradianceTestsBase
    {
        protected abstract double KilowattsPerSquareMeterInOneWattPerSquareMeter { get; }
        protected abstract double WattsPerSquareMeterInOneWattPerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilowattsPerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double WattsPerSquareMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void WattPerSquareMeterToIrradianceUnits()
        {
            Irradiance wattpersquaremeter = Irradiance.FromWattsPerSquareMeter(1);
            AssertEx.EqualTolerance(KilowattsPerSquareMeterInOneWattPerSquareMeter, wattpersquaremeter.KilowattsPerSquareMeter, KilowattsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(WattsPerSquareMeterInOneWattPerSquareMeter, wattpersquaremeter.WattsPerSquareMeter, WattsPerSquareMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Irradiance.From(1, IrradianceUnit.KilowattPerSquareMeter).KilowattsPerSquareMeter, KilowattsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiance.From(1, IrradianceUnit.WattPerSquareMeter).WattsPerSquareMeter, WattsPerSquareMeterTolerance);
        }

        [Fact]
        public void As()
        {
            var wattpersquaremeter = Irradiance.FromWattsPerSquareMeter(1);
            AssertEx.EqualTolerance(KilowattsPerSquareMeterInOneWattPerSquareMeter, wattpersquaremeter.As(IrradianceUnit.KilowattPerSquareMeter), KilowattsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(WattsPerSquareMeterInOneWattPerSquareMeter, wattpersquaremeter.As(IrradianceUnit.WattPerSquareMeter), WattsPerSquareMeterTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Irradiance wattpersquaremeter = Irradiance.FromWattsPerSquareMeter(1);
            AssertEx.EqualTolerance(1, Irradiance.FromKilowattsPerSquareMeter(wattpersquaremeter.KilowattsPerSquareMeter).WattsPerSquareMeter, KilowattsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Irradiance.FromWattsPerSquareMeter(wattpersquaremeter.WattsPerSquareMeter).WattsPerSquareMeter, WattsPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Irradiance v = Irradiance.FromWattsPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.WattsPerSquareMeter, WattsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (Irradiance.FromWattsPerSquareMeter(3)-v).WattsPerSquareMeter, WattsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).WattsPerSquareMeter, WattsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).WattsPerSquareMeter, WattsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).WattsPerSquareMeter, WattsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (Irradiance.FromWattsPerSquareMeter(10)/5).WattsPerSquareMeter, WattsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, Irradiance.FromWattsPerSquareMeter(10)/Irradiance.FromWattsPerSquareMeter(5), WattsPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Irradiance oneWattPerSquareMeter = Irradiance.FromWattsPerSquareMeter(1);
            Irradiance twoWattsPerSquareMeter = Irradiance.FromWattsPerSquareMeter(2);

            Assert.True(oneWattPerSquareMeter < twoWattsPerSquareMeter);
            Assert.True(oneWattPerSquareMeter <= twoWattsPerSquareMeter);
            Assert.True(twoWattsPerSquareMeter > oneWattPerSquareMeter);
            Assert.True(twoWattsPerSquareMeter >= oneWattPerSquareMeter);

            Assert.False(oneWattPerSquareMeter > twoWattsPerSquareMeter);
            Assert.False(oneWattPerSquareMeter >= twoWattsPerSquareMeter);
            Assert.False(twoWattsPerSquareMeter < oneWattPerSquareMeter);
            Assert.False(twoWattsPerSquareMeter <= oneWattPerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Irradiance wattpersquaremeter = Irradiance.FromWattsPerSquareMeter(1);
            Assert.Equal(0, wattpersquaremeter.CompareTo(wattpersquaremeter));
            Assert.True(wattpersquaremeter.CompareTo(Irradiance.Zero) > 0);
            Assert.True(Irradiance.Zero.CompareTo(wattpersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Irradiance wattpersquaremeter = Irradiance.FromWattsPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => wattpersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Irradiance wattpersquaremeter = Irradiance.FromWattsPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => wattpersquaremeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Irradiance a = Irradiance.FromWattsPerSquareMeter(1);
            Irradiance b = Irradiance.FromWattsPerSquareMeter(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Irradiance v = Irradiance.FromWattsPerSquareMeter(1);
            Assert.True(v.Equals(Irradiance.FromWattsPerSquareMeter(1), Irradiance.FromWattsPerSquareMeter(WattsPerSquareMeterTolerance)));
            Assert.False(v.Equals(Irradiance.Zero, Irradiance.FromWattsPerSquareMeter(WattsPerSquareMeterTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Irradiance wattpersquaremeter = Irradiance.FromWattsPerSquareMeter(1);
            Assert.False(wattpersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Irradiance wattpersquaremeter = Irradiance.FromWattsPerSquareMeter(1);
            Assert.False(wattpersquaremeter.Equals(null));
        }
    }
}

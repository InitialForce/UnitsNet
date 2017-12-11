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
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
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
    /// Test of ElectricPotential.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricPotentialTestsBase
    {
        protected abstract double KilovoltsInOneVolt { get; }
        protected abstract double MegavoltsInOneVolt { get; }
        protected abstract double MicrovoltsInOneVolt { get; }
        protected abstract double MillivoltsInOneVolt { get; }
        protected abstract double VoltsInOneVolt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltsTolerance { get { return 1e-5; } }
        protected virtual double MegavoltsTolerance { get { return 1e-5; } }
        protected virtual double MicrovoltsTolerance { get { return 1e-5; } }
        protected virtual double MillivoltsTolerance { get { return 1e-5; } }
        protected virtual double VoltsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void VoltToElectricPotentialUnits()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            AssertEx.EqualTolerance(KilovoltsInOneVolt, volt.Kilovolts, KilovoltsTolerance);
            AssertEx.EqualTolerance(MegavoltsInOneVolt, volt.Megavolts, MegavoltsTolerance);
            AssertEx.EqualTolerance(MicrovoltsInOneVolt, volt.Microvolts, MicrovoltsTolerance);
            AssertEx.EqualTolerance(MillivoltsInOneVolt, volt.Millivolts, MillivoltsTolerance);
            AssertEx.EqualTolerance(VoltsInOneVolt, volt.Volts, VoltsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricPotential.From(1, ElectricPotentialUnit.Kilovolt).Kilovolts, KilovoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.From(1, ElectricPotentialUnit.Megavolt).Megavolts, MegavoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.From(1, ElectricPotentialUnit.Microvolt).Microvolts, MicrovoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.From(1, ElectricPotentialUnit.Millivolt).Millivolts, MillivoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.From(1, ElectricPotentialUnit.Volt).Volts, VoltsTolerance);
        }

        [Fact]
        public void As()
        {
            var volt = ElectricPotential.FromVolts(1);
            AssertEx.EqualTolerance(KilovoltsInOneVolt, volt.As(ElectricPotentialUnit.Kilovolt), KilovoltsTolerance);
            AssertEx.EqualTolerance(MegavoltsInOneVolt, volt.As(ElectricPotentialUnit.Megavolt), MegavoltsTolerance);
            AssertEx.EqualTolerance(MicrovoltsInOneVolt, volt.As(ElectricPotentialUnit.Microvolt), MicrovoltsTolerance);
            AssertEx.EqualTolerance(MillivoltsInOneVolt, volt.As(ElectricPotentialUnit.Millivolt), MillivoltsTolerance);
            AssertEx.EqualTolerance(VoltsInOneVolt, volt.As(ElectricPotentialUnit.Volt), VoltsTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            AssertEx.EqualTolerance(1, ElectricPotential.FromKilovolts(volt.Kilovolts).Volts, KilovoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.FromMegavolts(volt.Megavolts).Volts, MegavoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.FromMicrovolts(volt.Microvolts).Volts, MicrovoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.FromMillivolts(volt.Millivolts).Volts, MillivoltsTolerance);
            AssertEx.EqualTolerance(1, ElectricPotential.FromVolts(volt.Volts).Volts, VoltsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricPotential v = ElectricPotential.FromVolts(1);
            AssertEx.EqualTolerance(-1, -v.Volts, VoltsTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotential.FromVolts(3)-v).Volts, VoltsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Volts, VoltsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Volts, VoltsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Volts, VoltsTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotential.FromVolts(10)/5).Volts, VoltsTolerance);
            AssertEx.EqualTolerance(2, ElectricPotential.FromVolts(10)/ElectricPotential.FromVolts(5), VoltsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricPotential oneVolt = ElectricPotential.FromVolts(1);
            ElectricPotential twoVolts = ElectricPotential.FromVolts(2);

            Assert.True(oneVolt < twoVolts);
            Assert.True(oneVolt <= twoVolts);
            Assert.True(twoVolts > oneVolt);
            Assert.True(twoVolts >= oneVolt);

            Assert.False(oneVolt > twoVolts);
            Assert.False(oneVolt >= twoVolts);
            Assert.False(twoVolts < oneVolt);
            Assert.False(twoVolts <= oneVolt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            Assert.Equal(0, volt.CompareTo(volt));
            Assert.True(volt.CompareTo(ElectricPotential.Zero) > 0);
            Assert.True(ElectricPotential.Zero.CompareTo(volt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            Assert.Throws<ArgumentException>(() => volt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            Assert.Throws<ArgumentNullException>(() => volt.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ElectricPotential a = ElectricPotential.FromVolts(1);
            ElectricPotential b = ElectricPotential.FromVolts(2);

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
            ElectricPotential v = ElectricPotential.FromVolts(1);
            Assert.True(v.Equals(ElectricPotential.FromVolts(1), ElectricPotential.FromVolts(VoltsTolerance)));
            Assert.False(v.Equals(ElectricPotential.Zero, ElectricPotential.FromVolts(VoltsTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            Assert.False(volt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricPotential volt = ElectricPotential.FromVolts(1);
            Assert.False(volt.Equals(null));
        }
    }
}

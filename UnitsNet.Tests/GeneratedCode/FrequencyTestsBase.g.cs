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

// Copyright (c) 2007 Andreas Gullberg Larsen (angularsen@gmail.com).
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
    /// Test of Frequency.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class FrequencyTestsBase
    {
        protected abstract double CyclesPerHourInOneHertz { get; }
        protected abstract double CyclesPerMinuteInOneHertz { get; }
        protected abstract double GigahertzInOneHertz { get; }
        protected abstract double HertzInOneHertz { get; }
        protected abstract double KilohertzInOneHertz { get; }
        protected abstract double MegahertzInOneHertz { get; }
        protected abstract double RadiansPerSecondInOneHertz { get; }
        protected abstract double TerahertzInOneHertz { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CyclesPerHourTolerance { get { return 1e-5; } }
        protected virtual double CyclesPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double GigahertzTolerance { get { return 1e-5; } }
        protected virtual double HertzTolerance { get { return 1e-5; } }
        protected virtual double KilohertzTolerance { get { return 1e-5; } }
        protected virtual double MegahertzTolerance { get { return 1e-5; } }
        protected virtual double RadiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double TerahertzTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void HertzToFrequencyUnits()
        {
            Frequency hertz = Frequency.FromHertz(1);
            AssertEx.EqualTolerance(CyclesPerHourInOneHertz, hertz.CyclesPerHour, CyclesPerHourTolerance);
            AssertEx.EqualTolerance(CyclesPerMinuteInOneHertz, hertz.CyclesPerMinute, CyclesPerMinuteTolerance);
            AssertEx.EqualTolerance(GigahertzInOneHertz, hertz.Gigahertz, GigahertzTolerance);
            AssertEx.EqualTolerance(HertzInOneHertz, hertz.Hertz, HertzTolerance);
            AssertEx.EqualTolerance(KilohertzInOneHertz, hertz.Kilohertz, KilohertzTolerance);
            AssertEx.EqualTolerance(MegahertzInOneHertz, hertz.Megahertz, MegahertzTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondInOneHertz, hertz.RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(TerahertzInOneHertz, hertz.Terahertz, TerahertzTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Frequency.From(1, FrequencyUnit.CyclePerHour).CyclesPerHour, CyclesPerHourTolerance);
            AssertEx.EqualTolerance(1, Frequency.From(1, FrequencyUnit.CyclePerMinute).CyclesPerMinute, CyclesPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Frequency.From(1, FrequencyUnit.Gigahertz).Gigahertz, GigahertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.From(1, FrequencyUnit.Hertz).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.From(1, FrequencyUnit.Kilohertz).Kilohertz, KilohertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.From(1, FrequencyUnit.Megahertz).Megahertz, MegahertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.From(1, FrequencyUnit.RadianPerSecond).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, Frequency.From(1, FrequencyUnit.Terahertz).Terahertz, TerahertzTolerance);
        }

        [Fact]
        public void As()
        {
            var hertz = Frequency.FromHertz(1);
            AssertEx.EqualTolerance(CyclesPerHourInOneHertz, hertz.As(FrequencyUnit.CyclePerHour), CyclesPerHourTolerance);
            AssertEx.EqualTolerance(CyclesPerMinuteInOneHertz, hertz.As(FrequencyUnit.CyclePerMinute), CyclesPerMinuteTolerance);
            AssertEx.EqualTolerance(GigahertzInOneHertz, hertz.As(FrequencyUnit.Gigahertz), GigahertzTolerance);
            AssertEx.EqualTolerance(HertzInOneHertz, hertz.As(FrequencyUnit.Hertz), HertzTolerance);
            AssertEx.EqualTolerance(KilohertzInOneHertz, hertz.As(FrequencyUnit.Kilohertz), KilohertzTolerance);
            AssertEx.EqualTolerance(MegahertzInOneHertz, hertz.As(FrequencyUnit.Megahertz), MegahertzTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondInOneHertz, hertz.As(FrequencyUnit.RadianPerSecond), RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(TerahertzInOneHertz, hertz.As(FrequencyUnit.Terahertz), TerahertzTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Frequency hertz = Frequency.FromHertz(1);
            AssertEx.EqualTolerance(1, Frequency.FromCyclesPerHour(hertz.CyclesPerHour).Hertz, CyclesPerHourTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromCyclesPerMinute(hertz.CyclesPerMinute).Hertz, CyclesPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromGigahertz(hertz.Gigahertz).Hertz, GigahertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromHertz(hertz.Hertz).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromKilohertz(hertz.Kilohertz).Hertz, KilohertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromMegahertz(hertz.Megahertz).Hertz, MegahertzTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromRadiansPerSecond(hertz.RadiansPerSecond).Hertz, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, Frequency.FromTerahertz(hertz.Terahertz).Hertz, TerahertzTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Frequency v = Frequency.FromHertz(1);
            AssertEx.EqualTolerance(-1, -v.Hertz, HertzTolerance);
            AssertEx.EqualTolerance(2, (Frequency.FromHertz(3)-v).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(2, (v + v).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(10, (v*10).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(10, (10*v).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(2, (Frequency.FromHertz(10)/5).Hertz, HertzTolerance);
            AssertEx.EqualTolerance(2, Frequency.FromHertz(10)/Frequency.FromHertz(5), HertzTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Frequency oneHertz = Frequency.FromHertz(1);
            Frequency twoHertz = Frequency.FromHertz(2);

            Assert.True(oneHertz < twoHertz);
            Assert.True(oneHertz <= twoHertz);
            Assert.True(twoHertz > oneHertz);
            Assert.True(twoHertz >= oneHertz);

            Assert.False(oneHertz > twoHertz);
            Assert.False(oneHertz >= twoHertz);
            Assert.False(twoHertz < oneHertz);
            Assert.False(twoHertz <= oneHertz);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.Equal(0, hertz.CompareTo(hertz));
            Assert.True(hertz.CompareTo(Frequency.Zero) > 0);
            Assert.True(Frequency.Zero.CompareTo(hertz) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.Throws<ArgumentException>(() => hertz.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.Throws<ArgumentNullException>(() => hertz.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Frequency a = Frequency.FromHertz(1);
            Frequency b = Frequency.FromHertz(2);

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
            Frequency v = Frequency.FromHertz(1);
            Assert.True(v.Equals(Frequency.FromHertz(1)));
            Assert.False(v.Equals(Frequency.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.False(hertz.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.False(hertz.Equals(null));
        }
    }
}

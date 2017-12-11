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
    /// Test of Information.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class InformationTestsBase
    {
        protected abstract double BitsInOneBit { get; }
        protected abstract double BytesInOneBit { get; }
        protected abstract double ExabitsInOneBit { get; }
        protected abstract double ExabytesInOneBit { get; }
        protected abstract double ExbibitsInOneBit { get; }
        protected abstract double ExbibytesInOneBit { get; }
        protected abstract double GibibitsInOneBit { get; }
        protected abstract double GibibytesInOneBit { get; }
        protected abstract double GigabitsInOneBit { get; }
        protected abstract double GigabytesInOneBit { get; }
        protected abstract double KibibitsInOneBit { get; }
        protected abstract double KibibytesInOneBit { get; }
        protected abstract double KilobitsInOneBit { get; }
        protected abstract double KilobytesInOneBit { get; }
        protected abstract double MebibitsInOneBit { get; }
        protected abstract double MebibytesInOneBit { get; }
        protected abstract double MegabitsInOneBit { get; }
        protected abstract double MegabytesInOneBit { get; }
        protected abstract double PebibitsInOneBit { get; }
        protected abstract double PebibytesInOneBit { get; }
        protected abstract double PetabitsInOneBit { get; }
        protected abstract double PetabytesInOneBit { get; }
        protected abstract double TebibitsInOneBit { get; }
        protected abstract double TebibytesInOneBit { get; }
        protected abstract double TerabitsInOneBit { get; }
        protected abstract double TerabytesInOneBit { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BitsTolerance { get { return 1e-5; } }
        protected virtual double BytesTolerance { get { return 1e-5; } }
        protected virtual double ExabitsTolerance { get { return 1e-5; } }
        protected virtual double ExabytesTolerance { get { return 1e-5; } }
        protected virtual double ExbibitsTolerance { get { return 1e-5; } }
        protected virtual double ExbibytesTolerance { get { return 1e-5; } }
        protected virtual double GibibitsTolerance { get { return 1e-5; } }
        protected virtual double GibibytesTolerance { get { return 1e-5; } }
        protected virtual double GigabitsTolerance { get { return 1e-5; } }
        protected virtual double GigabytesTolerance { get { return 1e-5; } }
        protected virtual double KibibitsTolerance { get { return 1e-5; } }
        protected virtual double KibibytesTolerance { get { return 1e-5; } }
        protected virtual double KilobitsTolerance { get { return 1e-5; } }
        protected virtual double KilobytesTolerance { get { return 1e-5; } }
        protected virtual double MebibitsTolerance { get { return 1e-5; } }
        protected virtual double MebibytesTolerance { get { return 1e-5; } }
        protected virtual double MegabitsTolerance { get { return 1e-5; } }
        protected virtual double MegabytesTolerance { get { return 1e-5; } }
        protected virtual double PebibitsTolerance { get { return 1e-5; } }
        protected virtual double PebibytesTolerance { get { return 1e-5; } }
        protected virtual double PetabitsTolerance { get { return 1e-5; } }
        protected virtual double PetabytesTolerance { get { return 1e-5; } }
        protected virtual double TebibitsTolerance { get { return 1e-5; } }
        protected virtual double TebibytesTolerance { get { return 1e-5; } }
        protected virtual double TerabitsTolerance { get { return 1e-5; } }
        protected virtual double TerabytesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void BitToInformationUnits()
        {
            Information bit = Information.FromBits(1);
            AssertEx.EqualTolerance(BitsInOneBit, bit.Bits, BitsTolerance);
            AssertEx.EqualTolerance(BytesInOneBit, bit.Bytes, BytesTolerance);
            AssertEx.EqualTolerance(ExabitsInOneBit, bit.Exabits, ExabitsTolerance);
            AssertEx.EqualTolerance(ExabytesInOneBit, bit.Exabytes, ExabytesTolerance);
            AssertEx.EqualTolerance(ExbibitsInOneBit, bit.Exbibits, ExbibitsTolerance);
            AssertEx.EqualTolerance(ExbibytesInOneBit, bit.Exbibytes, ExbibytesTolerance);
            AssertEx.EqualTolerance(GibibitsInOneBit, bit.Gibibits, GibibitsTolerance);
            AssertEx.EqualTolerance(GibibytesInOneBit, bit.Gibibytes, GibibytesTolerance);
            AssertEx.EqualTolerance(GigabitsInOneBit, bit.Gigabits, GigabitsTolerance);
            AssertEx.EqualTolerance(GigabytesInOneBit, bit.Gigabytes, GigabytesTolerance);
            AssertEx.EqualTolerance(KibibitsInOneBit, bit.Kibibits, KibibitsTolerance);
            AssertEx.EqualTolerance(KibibytesInOneBit, bit.Kibibytes, KibibytesTolerance);
            AssertEx.EqualTolerance(KilobitsInOneBit, bit.Kilobits, KilobitsTolerance);
            AssertEx.EqualTolerance(KilobytesInOneBit, bit.Kilobytes, KilobytesTolerance);
            AssertEx.EqualTolerance(MebibitsInOneBit, bit.Mebibits, MebibitsTolerance);
            AssertEx.EqualTolerance(MebibytesInOneBit, bit.Mebibytes, MebibytesTolerance);
            AssertEx.EqualTolerance(MegabitsInOneBit, bit.Megabits, MegabitsTolerance);
            AssertEx.EqualTolerance(MegabytesInOneBit, bit.Megabytes, MegabytesTolerance);
            AssertEx.EqualTolerance(PebibitsInOneBit, bit.Pebibits, PebibitsTolerance);
            AssertEx.EqualTolerance(PebibytesInOneBit, bit.Pebibytes, PebibytesTolerance);
            AssertEx.EqualTolerance(PetabitsInOneBit, bit.Petabits, PetabitsTolerance);
            AssertEx.EqualTolerance(PetabytesInOneBit, bit.Petabytes, PetabytesTolerance);
            AssertEx.EqualTolerance(TebibitsInOneBit, bit.Tebibits, TebibitsTolerance);
            AssertEx.EqualTolerance(TebibytesInOneBit, bit.Tebibytes, TebibytesTolerance);
            AssertEx.EqualTolerance(TerabitsInOneBit, bit.Terabits, TerabitsTolerance);
            AssertEx.EqualTolerance(TerabytesInOneBit, bit.Terabytes, TerabytesTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Bit).Bits, BitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Byte).Bytes, BytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Exabit).Exabits, ExabitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Exabyte).Exabytes, ExabytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Exbibit).Exbibits, ExbibitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Exbibyte).Exbibytes, ExbibytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Gibibit).Gibibits, GibibitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Gibibyte).Gibibytes, GibibytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Gigabit).Gigabits, GigabitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Gigabyte).Gigabytes, GigabytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Kibibit).Kibibits, KibibitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Kibibyte).Kibibytes, KibibytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Kilobit).Kilobits, KilobitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Kilobyte).Kilobytes, KilobytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Mebibit).Mebibits, MebibitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Mebibyte).Mebibytes, MebibytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Megabit).Megabits, MegabitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Megabyte).Megabytes, MegabytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Pebibit).Pebibits, PebibitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Pebibyte).Pebibytes, PebibytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Petabit).Petabits, PetabitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Petabyte).Petabytes, PetabytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Tebibit).Tebibits, TebibitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Tebibyte).Tebibytes, TebibytesTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Terabit).Terabits, TerabitsTolerance);
            AssertEx.EqualTolerance(1, Information.From(1, InformationUnit.Terabyte).Terabytes, TerabytesTolerance);
        }

        [Fact]
        public void As()
        {
            var bit = Information.FromBits(1);
            AssertEx.EqualTolerance(BitsInOneBit, bit.As(InformationUnit.Bit), BitsTolerance);
            AssertEx.EqualTolerance(BytesInOneBit, bit.As(InformationUnit.Byte), BytesTolerance);
            AssertEx.EqualTolerance(ExabitsInOneBit, bit.As(InformationUnit.Exabit), ExabitsTolerance);
            AssertEx.EqualTolerance(ExabytesInOneBit, bit.As(InformationUnit.Exabyte), ExabytesTolerance);
            AssertEx.EqualTolerance(ExbibitsInOneBit, bit.As(InformationUnit.Exbibit), ExbibitsTolerance);
            AssertEx.EqualTolerance(ExbibytesInOneBit, bit.As(InformationUnit.Exbibyte), ExbibytesTolerance);
            AssertEx.EqualTolerance(GibibitsInOneBit, bit.As(InformationUnit.Gibibit), GibibitsTolerance);
            AssertEx.EqualTolerance(GibibytesInOneBit, bit.As(InformationUnit.Gibibyte), GibibytesTolerance);
            AssertEx.EqualTolerance(GigabitsInOneBit, bit.As(InformationUnit.Gigabit), GigabitsTolerance);
            AssertEx.EqualTolerance(GigabytesInOneBit, bit.As(InformationUnit.Gigabyte), GigabytesTolerance);
            AssertEx.EqualTolerance(KibibitsInOneBit, bit.As(InformationUnit.Kibibit), KibibitsTolerance);
            AssertEx.EqualTolerance(KibibytesInOneBit, bit.As(InformationUnit.Kibibyte), KibibytesTolerance);
            AssertEx.EqualTolerance(KilobitsInOneBit, bit.As(InformationUnit.Kilobit), KilobitsTolerance);
            AssertEx.EqualTolerance(KilobytesInOneBit, bit.As(InformationUnit.Kilobyte), KilobytesTolerance);
            AssertEx.EqualTolerance(MebibitsInOneBit, bit.As(InformationUnit.Mebibit), MebibitsTolerance);
            AssertEx.EqualTolerance(MebibytesInOneBit, bit.As(InformationUnit.Mebibyte), MebibytesTolerance);
            AssertEx.EqualTolerance(MegabitsInOneBit, bit.As(InformationUnit.Megabit), MegabitsTolerance);
            AssertEx.EqualTolerance(MegabytesInOneBit, bit.As(InformationUnit.Megabyte), MegabytesTolerance);
            AssertEx.EqualTolerance(PebibitsInOneBit, bit.As(InformationUnit.Pebibit), PebibitsTolerance);
            AssertEx.EqualTolerance(PebibytesInOneBit, bit.As(InformationUnit.Pebibyte), PebibytesTolerance);
            AssertEx.EqualTolerance(PetabitsInOneBit, bit.As(InformationUnit.Petabit), PetabitsTolerance);
            AssertEx.EqualTolerance(PetabytesInOneBit, bit.As(InformationUnit.Petabyte), PetabytesTolerance);
            AssertEx.EqualTolerance(TebibitsInOneBit, bit.As(InformationUnit.Tebibit), TebibitsTolerance);
            AssertEx.EqualTolerance(TebibytesInOneBit, bit.As(InformationUnit.Tebibyte), TebibytesTolerance);
            AssertEx.EqualTolerance(TerabitsInOneBit, bit.As(InformationUnit.Terabit), TerabitsTolerance);
            AssertEx.EqualTolerance(TerabytesInOneBit, bit.As(InformationUnit.Terabyte), TerabytesTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Information bit = Information.FromBits(1);
            AssertEx.EqualTolerance(1, Information.FromBits(bit.Bits).Bits, BitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromBytes(bit.Bytes).Bits, BytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromExabits(bit.Exabits).Bits, ExabitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromExabytes(bit.Exabytes).Bits, ExabytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromExbibits(bit.Exbibits).Bits, ExbibitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromExbibytes(bit.Exbibytes).Bits, ExbibytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromGibibits(bit.Gibibits).Bits, GibibitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromGibibytes(bit.Gibibytes).Bits, GibibytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromGigabits(bit.Gigabits).Bits, GigabitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromGigabytes(bit.Gigabytes).Bits, GigabytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromKibibits(bit.Kibibits).Bits, KibibitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromKibibytes(bit.Kibibytes).Bits, KibibytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromKilobits(bit.Kilobits).Bits, KilobitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromKilobytes(bit.Kilobytes).Bits, KilobytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromMebibits(bit.Mebibits).Bits, MebibitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromMebibytes(bit.Mebibytes).Bits, MebibytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromMegabits(bit.Megabits).Bits, MegabitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromMegabytes(bit.Megabytes).Bits, MegabytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromPebibits(bit.Pebibits).Bits, PebibitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromPebibytes(bit.Pebibytes).Bits, PebibytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromPetabits(bit.Petabits).Bits, PetabitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromPetabytes(bit.Petabytes).Bits, PetabytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromTebibits(bit.Tebibits).Bits, TebibitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromTebibytes(bit.Tebibytes).Bits, TebibytesTolerance);
            AssertEx.EqualTolerance(1, Information.FromTerabits(bit.Terabits).Bits, TerabitsTolerance);
            AssertEx.EqualTolerance(1, Information.FromTerabytes(bit.Terabytes).Bits, TerabytesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Information v = Information.FromBits(1);
            AssertEx.EqualTolerance(-1, -v.Bits, BitsTolerance);
            AssertEx.EqualTolerance(2, (Information.FromBits(3)-v).Bits, BitsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Bits, BitsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Bits, BitsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Bits, BitsTolerance);
            AssertEx.EqualTolerance(2, (Information.FromBits(10)/5).Bits, BitsTolerance);
            AssertEx.EqualTolerance(2, Information.FromBits(10)/Information.FromBits(5), BitsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Information oneBit = Information.FromBits(1);
            Information twoBits = Information.FromBits(2);

            Assert.True(oneBit < twoBits);
            Assert.True(oneBit <= twoBits);
            Assert.True(twoBits > oneBit);
            Assert.True(twoBits >= oneBit);

            Assert.False(oneBit > twoBits);
            Assert.False(oneBit >= twoBits);
            Assert.False(twoBits < oneBit);
            Assert.False(twoBits <= oneBit);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Information bit = Information.FromBits(1);
            Assert.Equal(0, bit.CompareTo(bit));
            Assert.True(bit.CompareTo(Information.Zero) > 0);
            Assert.True(Information.Zero.CompareTo(bit) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Information bit = Information.FromBits(1);
            Assert.Throws<ArgumentException>(() => bit.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Information bit = Information.FromBits(1);
            Assert.Throws<ArgumentNullException>(() => bit.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Information a = Information.FromBits(1);
            Information b = Information.FromBits(2);

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
            Information v = Information.FromBits(1);
            Assert.True(v.Equals(Information.FromBits(1), Information.FromBits(BitsTolerance)));
            Assert.False(v.Equals(Information.Zero, Information.FromBits(BitsTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Information bit = Information.FromBits(1);
            Assert.False(bit.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Information bit = Information.FromBits(1);
            Assert.False(bit.Equals(null));
        }
    }
}

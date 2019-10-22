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
    /// Test of AmountOfSubstance<double>.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AmountOfSubstanceTestsBase
    {
        protected abstract double CentimolesInOneMole { get; }
        protected abstract double CentipoundMolesInOneMole { get; }
        protected abstract double DecimolesInOneMole { get; }
        protected abstract double DecipoundMolesInOneMole { get; }
        protected abstract double KilomolesInOneMole { get; }
        protected abstract double KilopoundMolesInOneMole { get; }
        protected abstract double MegamolesInOneMole { get; }
        protected abstract double MicromolesInOneMole { get; }
        protected abstract double MicropoundMolesInOneMole { get; }
        protected abstract double MillimolesInOneMole { get; }
        protected abstract double MillipoundMolesInOneMole { get; }
        protected abstract double MolesInOneMole { get; }
        protected abstract double NanomolesInOneMole { get; }
        protected abstract double NanopoundMolesInOneMole { get; }
        protected abstract double PoundMolesInOneMole { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimolesTolerance { get { return 1e-5; } }
        protected virtual double CentipoundMolesTolerance { get { return 1e-5; } }
        protected virtual double DecimolesTolerance { get { return 1e-5; } }
        protected virtual double DecipoundMolesTolerance { get { return 1e-5; } }
        protected virtual double KilomolesTolerance { get { return 1e-5; } }
        protected virtual double KilopoundMolesTolerance { get { return 1e-5; } }
        protected virtual double MegamolesTolerance { get { return 1e-5; } }
        protected virtual double MicromolesTolerance { get { return 1e-5; } }
        protected virtual double MicropoundMolesTolerance { get { return 1e-5; } }
        protected virtual double MillimolesTolerance { get { return 1e-5; } }
        protected virtual double MillipoundMolesTolerance { get { return 1e-5; } }
        protected virtual double MolesTolerance { get { return 1e-5; } }
        protected virtual double NanomolesTolerance { get { return 1e-5; } }
        protected virtual double NanopoundMolesTolerance { get { return 1e-5; } }
        protected virtual double PoundMolesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance<double>((double)0.0, AmountOfSubstanceUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance<double>(double.PositiveInfinity, AmountOfSubstanceUnit.Mole));
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance<double>(double.NegativeInfinity, AmountOfSubstanceUnit.Mole));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance<double>(double.NaN, AmountOfSubstanceUnit.Mole));
        }

        [Fact]
        public void MoleToAmountOfSubstanceUnits()
        {
            AmountOfSubstance<double> mole = AmountOfSubstance<double>.FromMoles(1);
            AssertEx.EqualTolerance(CentimolesInOneMole, mole.Centimoles, CentimolesTolerance);
            AssertEx.EqualTolerance(CentipoundMolesInOneMole, mole.CentipoundMoles, CentipoundMolesTolerance);
            AssertEx.EqualTolerance(DecimolesInOneMole, mole.Decimoles, DecimolesTolerance);
            AssertEx.EqualTolerance(DecipoundMolesInOneMole, mole.DecipoundMoles, DecipoundMolesTolerance);
            AssertEx.EqualTolerance(KilomolesInOneMole, mole.Kilomoles, KilomolesTolerance);
            AssertEx.EqualTolerance(KilopoundMolesInOneMole, mole.KilopoundMoles, KilopoundMolesTolerance);
            AssertEx.EqualTolerance(MegamolesInOneMole, mole.Megamoles, MegamolesTolerance);
            AssertEx.EqualTolerance(MicromolesInOneMole, mole.Micromoles, MicromolesTolerance);
            AssertEx.EqualTolerance(MicropoundMolesInOneMole, mole.MicropoundMoles, MicropoundMolesTolerance);
            AssertEx.EqualTolerance(MillimolesInOneMole, mole.Millimoles, MillimolesTolerance);
            AssertEx.EqualTolerance(MillipoundMolesInOneMole, mole.MillipoundMoles, MillipoundMolesTolerance);
            AssertEx.EqualTolerance(MolesInOneMole, mole.Moles, MolesTolerance);
            AssertEx.EqualTolerance(NanomolesInOneMole, mole.Nanomoles, NanomolesTolerance);
            AssertEx.EqualTolerance(NanopoundMolesInOneMole, mole.NanopoundMoles, NanopoundMolesTolerance);
            AssertEx.EqualTolerance(PoundMolesInOneMole, mole.PoundMoles, PoundMolesTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.Centimole).Centimoles, CentimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.CentipoundMole).CentipoundMoles, CentipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.Decimole).Decimoles, DecimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.DecipoundMole).DecipoundMoles, DecipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.Kilomole).Kilomoles, KilomolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.KilopoundMole).KilopoundMoles, KilopoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.Megamole).Megamoles, MegamolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.Micromole).Micromoles, MicromolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.MicropoundMole).MicropoundMoles, MicropoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.Millimole).Millimoles, MillimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.MillipoundMole).MillipoundMoles, MillipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.Mole).Moles, MolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.Nanomole).Nanomoles, NanomolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.NanopoundMole).NanopoundMoles, NanopoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.From(1, AmountOfSubstanceUnit.PoundMole).PoundMoles, PoundMolesTolerance);
        }

        [Fact]
        public void FromMoles_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AmountOfSubstance<double>.FromMoles(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => AmountOfSubstance<double>.FromMoles(double.NegativeInfinity));
        }

        [Fact]
        public void FromMoles_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AmountOfSubstance<double>.FromMoles(double.NaN));
        }

        [Fact]
        public void As()
        {
            var mole = AmountOfSubstance<double>.FromMoles(1);
            AssertEx.EqualTolerance(CentimolesInOneMole, mole.As(AmountOfSubstanceUnit.Centimole), CentimolesTolerance);
            AssertEx.EqualTolerance(CentipoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.CentipoundMole), CentipoundMolesTolerance);
            AssertEx.EqualTolerance(DecimolesInOneMole, mole.As(AmountOfSubstanceUnit.Decimole), DecimolesTolerance);
            AssertEx.EqualTolerance(DecipoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.DecipoundMole), DecipoundMolesTolerance);
            AssertEx.EqualTolerance(KilomolesInOneMole, mole.As(AmountOfSubstanceUnit.Kilomole), KilomolesTolerance);
            AssertEx.EqualTolerance(KilopoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.KilopoundMole), KilopoundMolesTolerance);
            AssertEx.EqualTolerance(MegamolesInOneMole, mole.As(AmountOfSubstanceUnit.Megamole), MegamolesTolerance);
            AssertEx.EqualTolerance(MicromolesInOneMole, mole.As(AmountOfSubstanceUnit.Micromole), MicromolesTolerance);
            AssertEx.EqualTolerance(MicropoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.MicropoundMole), MicropoundMolesTolerance);
            AssertEx.EqualTolerance(MillimolesInOneMole, mole.As(AmountOfSubstanceUnit.Millimole), MillimolesTolerance);
            AssertEx.EqualTolerance(MillipoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.MillipoundMole), MillipoundMolesTolerance);
            AssertEx.EqualTolerance(MolesInOneMole, mole.As(AmountOfSubstanceUnit.Mole), MolesTolerance);
            AssertEx.EqualTolerance(NanomolesInOneMole, mole.As(AmountOfSubstanceUnit.Nanomole), NanomolesTolerance);
            AssertEx.EqualTolerance(NanopoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.NanopoundMole), NanopoundMolesTolerance);
            AssertEx.EqualTolerance(PoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.PoundMole), PoundMolesTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var mole = AmountOfSubstance<double>.FromMoles(1);

            var centimoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Centimole);
            AssertEx.EqualTolerance(CentimolesInOneMole, (double)centimoleQuantity.Value, CentimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Centimole, centimoleQuantity.Unit);

            var centipoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.CentipoundMole);
            AssertEx.EqualTolerance(CentipoundMolesInOneMole, (double)centipoundmoleQuantity.Value, CentipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.CentipoundMole, centipoundmoleQuantity.Unit);

            var decimoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Decimole);
            AssertEx.EqualTolerance(DecimolesInOneMole, (double)decimoleQuantity.Value, DecimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Decimole, decimoleQuantity.Unit);

            var decipoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.DecipoundMole);
            AssertEx.EqualTolerance(DecipoundMolesInOneMole, (double)decipoundmoleQuantity.Value, DecipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.DecipoundMole, decipoundmoleQuantity.Unit);

            var kilomoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Kilomole);
            AssertEx.EqualTolerance(KilomolesInOneMole, (double)kilomoleQuantity.Value, KilomolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Kilomole, kilomoleQuantity.Unit);

            var kilopoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.KilopoundMole);
            AssertEx.EqualTolerance(KilopoundMolesInOneMole, (double)kilopoundmoleQuantity.Value, KilopoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.KilopoundMole, kilopoundmoleQuantity.Unit);

            var megamoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Megamole);
            AssertEx.EqualTolerance(MegamolesInOneMole, (double)megamoleQuantity.Value, MegamolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Megamole, megamoleQuantity.Unit);

            var micromoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Micromole);
            AssertEx.EqualTolerance(MicromolesInOneMole, (double)micromoleQuantity.Value, MicromolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Micromole, micromoleQuantity.Unit);

            var micropoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.MicropoundMole);
            AssertEx.EqualTolerance(MicropoundMolesInOneMole, (double)micropoundmoleQuantity.Value, MicropoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.MicropoundMole, micropoundmoleQuantity.Unit);

            var millimoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Millimole);
            AssertEx.EqualTolerance(MillimolesInOneMole, (double)millimoleQuantity.Value, MillimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Millimole, millimoleQuantity.Unit);

            var millipoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.MillipoundMole);
            AssertEx.EqualTolerance(MillipoundMolesInOneMole, (double)millipoundmoleQuantity.Value, MillipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.MillipoundMole, millipoundmoleQuantity.Unit);

            var moleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Mole);
            AssertEx.EqualTolerance(MolesInOneMole, (double)moleQuantity.Value, MolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Mole, moleQuantity.Unit);

            var nanomoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Nanomole);
            AssertEx.EqualTolerance(NanomolesInOneMole, (double)nanomoleQuantity.Value, NanomolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Nanomole, nanomoleQuantity.Unit);

            var nanopoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.NanopoundMole);
            AssertEx.EqualTolerance(NanopoundMolesInOneMole, (double)nanopoundmoleQuantity.Value, NanopoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.NanopoundMole, nanopoundmoleQuantity.Unit);

            var poundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.PoundMole);
            AssertEx.EqualTolerance(PoundMolesInOneMole, (double)poundmoleQuantity.Value, PoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.PoundMole, poundmoleQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            AmountOfSubstance<double> mole = AmountOfSubstance<double>.FromMoles(1);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromCentimoles(mole.Centimoles).Moles, CentimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromCentipoundMoles(mole.CentipoundMoles).Moles, CentipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromDecimoles(mole.Decimoles).Moles, DecimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromDecipoundMoles(mole.DecipoundMoles).Moles, DecipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromKilomoles(mole.Kilomoles).Moles, KilomolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromKilopoundMoles(mole.KilopoundMoles).Moles, KilopoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromMegamoles(mole.Megamoles).Moles, MegamolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromMicromoles(mole.Micromoles).Moles, MicromolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromMicropoundMoles(mole.MicropoundMoles).Moles, MicropoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromMillimoles(mole.Millimoles).Moles, MillimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromMillipoundMoles(mole.MillipoundMoles).Moles, MillipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromMoles(mole.Moles).Moles, MolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromNanomoles(mole.Nanomoles).Moles, NanomolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromNanopoundMoles(mole.NanopoundMoles).Moles, NanopoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance<double>.FromPoundMoles(mole.PoundMoles).Moles, PoundMolesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            AmountOfSubstance<double> v = AmountOfSubstance<double>.FromMoles(1);
            AssertEx.EqualTolerance(-1, -v.Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, (AmountOfSubstance<double>.FromMoles(3)-v).Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Moles, MolesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Moles, MolesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, (AmountOfSubstance<double>.FromMoles(10)/5).Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, AmountOfSubstance<double>.FromMoles(10)/AmountOfSubstance<double>.FromMoles(5), MolesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            AmountOfSubstance<double> oneMole = AmountOfSubstance<double>.FromMoles(1);
            AmountOfSubstance<double> twoMoles = AmountOfSubstance<double>.FromMoles(2);

            Assert.True(oneMole < twoMoles);
            Assert.True(oneMole <= twoMoles);
            Assert.True(twoMoles > oneMole);
            Assert.True(twoMoles >= oneMole);

            Assert.False(oneMole > twoMoles);
            Assert.False(oneMole >= twoMoles);
            Assert.False(twoMoles < oneMole);
            Assert.False(twoMoles <= oneMole);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            AmountOfSubstance<double> mole = AmountOfSubstance<double>.FromMoles(1);
            Assert.Equal(0, mole.CompareTo(mole));
            Assert.True(mole.CompareTo(AmountOfSubstance<double>.Zero) > 0);
            Assert.True(AmountOfSubstance<double>.Zero.CompareTo(mole) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            AmountOfSubstance<double> mole = AmountOfSubstance<double>.FromMoles(1);
            Assert.Throws<ArgumentException>(() => mole.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            AmountOfSubstance<double> mole = AmountOfSubstance<double>.FromMoles(1);
            Assert.Throws<ArgumentNullException>(() => mole.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = AmountOfSubstance<double>.FromMoles(1);
            var b = AmountOfSubstance<double>.FromMoles(2);

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
            var a = AmountOfSubstance<double>.FromMoles(1);
            var b = AmountOfSubstance<double>.FromMoles(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = AmountOfSubstance<double>.FromMoles(1);
            Assert.True(v.Equals(AmountOfSubstance<double>.FromMoles(1), MolesTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(AmountOfSubstance<double>.Zero, MolesTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            AmountOfSubstance<double> mole = AmountOfSubstance<double>.FromMoles(1);
            Assert.False(mole.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            AmountOfSubstance<double> mole = AmountOfSubstance<double>.FromMoles(1);
            Assert.False(mole.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(AmountOfSubstanceUnit.Undefined, AmountOfSubstance<double>.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AmountOfSubstanceUnit)).Cast<AmountOfSubstanceUnit>();
            foreach(var unit in units)
            {
                if(unit == AmountOfSubstanceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(AmountOfSubstance<double>.BaseDimensions is null);
        }
    }
}

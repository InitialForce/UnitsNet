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
    /// Test of VolumeConcentration.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class VolumeConcentrationTestsBase
    {
        protected abstract double CentilitersPerLiterInOneDecimalFraction { get; }
        protected abstract double CentilitersPerMililiterInOneDecimalFraction { get; }
        protected abstract double DecilitersPerLiterInOneDecimalFraction { get; }
        protected abstract double DecilitersPerMililiterInOneDecimalFraction { get; }
        protected abstract double DecimalFractionsInOneDecimalFraction { get; }
        protected abstract double LitersPerLiterInOneDecimalFraction { get; }
        protected abstract double LitersPerMililiterInOneDecimalFraction { get; }
        protected abstract double MicrolitersPerLiterInOneDecimalFraction { get; }
        protected abstract double MicrolitersPerMililiterInOneDecimalFraction { get; }
        protected abstract double MillilitersPerLiterInOneDecimalFraction { get; }
        protected abstract double MillilitersPerMililiterInOneDecimalFraction { get; }
        protected abstract double NanolitersPerLiterInOneDecimalFraction { get; }
        protected abstract double NanolitersPerMililiterInOneDecimalFraction { get; }
        protected abstract double PartsPerBillionInOneDecimalFraction { get; }
        protected abstract double PartsPerMillionInOneDecimalFraction { get; }
        protected abstract double PartsPerThousandInOneDecimalFraction { get; }
        protected abstract double PartsPerTrillionInOneDecimalFraction { get; }
        protected abstract double PercentInOneDecimalFraction { get; }
        protected abstract double PicolitersPerLiterInOneDecimalFraction { get; }
        protected abstract double PicolitersPerMililiterInOneDecimalFraction { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentilitersPerLiterTolerance { get { return 1e-5; } }
        protected virtual double CentilitersPerMililiterTolerance { get { return 1e-5; } }
        protected virtual double DecilitersPerLiterTolerance { get { return 1e-5; } }
        protected virtual double DecilitersPerMililiterTolerance { get { return 1e-5; } }
        protected virtual double DecimalFractionsTolerance { get { return 1e-5; } }
        protected virtual double LitersPerLiterTolerance { get { return 1e-5; } }
        protected virtual double LitersPerMililiterTolerance { get { return 1e-5; } }
        protected virtual double MicrolitersPerLiterTolerance { get { return 1e-5; } }
        protected virtual double MicrolitersPerMililiterTolerance { get { return 1e-5; } }
        protected virtual double MillilitersPerLiterTolerance { get { return 1e-5; } }
        protected virtual double MillilitersPerMililiterTolerance { get { return 1e-5; } }
        protected virtual double NanolitersPerLiterTolerance { get { return 1e-5; } }
        protected virtual double NanolitersPerMililiterTolerance { get { return 1e-5; } }
        protected virtual double PartsPerBillionTolerance { get { return 1e-5; } }
        protected virtual double PartsPerMillionTolerance { get { return 1e-5; } }
        protected virtual double PartsPerThousandTolerance { get { return 1e-5; } }
        protected virtual double PartsPerTrillionTolerance { get { return 1e-5; } }
        protected virtual double PercentTolerance { get { return 1e-5; } }
        protected virtual double PicolitersPerLiterTolerance { get { return 1e-5; } }
        protected virtual double PicolitersPerMililiterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumeConcentration((double)0.0, VolumeConcentrationUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumeConcentration(double.PositiveInfinity, VolumeConcentrationUnit.DecimalFraction));
            Assert.Throws<ArgumentException>(() => new VolumeConcentration(double.NegativeInfinity, VolumeConcentrationUnit.DecimalFraction));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumeConcentration(double.NaN, VolumeConcentrationUnit.DecimalFraction));
        }

        [Fact]
        public void DecimalFractionToVolumeConcentrationUnits()
        {
            VolumeConcentration decimalfraction = VolumeConcentration.FromDecimalFractions(1);
            AssertEx.EqualTolerance(CentilitersPerLiterInOneDecimalFraction, decimalfraction.CentilitersPerLiter, CentilitersPerLiterTolerance);
            AssertEx.EqualTolerance(CentilitersPerMililiterInOneDecimalFraction, decimalfraction.CentilitersPerMililiter, CentilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(DecilitersPerLiterInOneDecimalFraction, decimalfraction.DecilitersPerLiter, DecilitersPerLiterTolerance);
            AssertEx.EqualTolerance(DecilitersPerMililiterInOneDecimalFraction, decimalfraction.DecilitersPerMililiter, DecilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, decimalfraction.DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(LitersPerLiterInOneDecimalFraction, decimalfraction.LitersPerLiter, LitersPerLiterTolerance);
            AssertEx.EqualTolerance(LitersPerMililiterInOneDecimalFraction, decimalfraction.LitersPerMililiter, LitersPerMililiterTolerance);
            AssertEx.EqualTolerance(MicrolitersPerLiterInOneDecimalFraction, decimalfraction.MicrolitersPerLiter, MicrolitersPerLiterTolerance);
            AssertEx.EqualTolerance(MicrolitersPerMililiterInOneDecimalFraction, decimalfraction.MicrolitersPerMililiter, MicrolitersPerMililiterTolerance);
            AssertEx.EqualTolerance(MillilitersPerLiterInOneDecimalFraction, decimalfraction.MillilitersPerLiter, MillilitersPerLiterTolerance);
            AssertEx.EqualTolerance(MillilitersPerMililiterInOneDecimalFraction, decimalfraction.MillilitersPerMililiter, MillilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(NanolitersPerLiterInOneDecimalFraction, decimalfraction.NanolitersPerLiter, NanolitersPerLiterTolerance);
            AssertEx.EqualTolerance(NanolitersPerMililiterInOneDecimalFraction, decimalfraction.NanolitersPerMililiter, NanolitersPerMililiterTolerance);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, decimalfraction.PartsPerBillion, PartsPerBillionTolerance);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, decimalfraction.PartsPerMillion, PartsPerMillionTolerance);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, decimalfraction.PartsPerThousand, PartsPerThousandTolerance);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, decimalfraction.PartsPerTrillion, PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, decimalfraction.Percent, PercentTolerance);
            AssertEx.EqualTolerance(PicolitersPerLiterInOneDecimalFraction, decimalfraction.PicolitersPerLiter, PicolitersPerLiterTolerance);
            AssertEx.EqualTolerance(PicolitersPerMililiterInOneDecimalFraction, decimalfraction.PicolitersPerMililiter, PicolitersPerMililiterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.CentilitersPerLiter).CentilitersPerLiter, CentilitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.CentilitersPerMililiter).CentilitersPerMililiter, CentilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.DecilitersPerLiter).DecilitersPerLiter, DecilitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.DecilitersPerMililiter).DecilitersPerMililiter, DecilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.DecimalFraction).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.LitersPerLiter).LitersPerLiter, LitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.LitersPerMililiter).LitersPerMililiter, LitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.MicrolitersPerLiter).MicrolitersPerLiter, MicrolitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.MicrolitersPerMililiter).MicrolitersPerMililiter, MicrolitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.MillilitersPerLiter).MillilitersPerLiter, MillilitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.MillilitersPerMililiter).MillilitersPerMililiter, MillilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.NanolitersPerLiter).NanolitersPerLiter, NanolitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.NanolitersPerMililiter).NanolitersPerMililiter, NanolitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.PartPerBillion).PartsPerBillion, PartsPerBillionTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.PartPerMillion).PartsPerMillion, PartsPerMillionTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.PartPerThousand).PartsPerThousand, PartsPerThousandTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.PartPerTrillion).PartsPerTrillion, PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.Percent).Percent, PercentTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.PicolitersPerLiter).PicolitersPerLiter, PicolitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.From(1, VolumeConcentrationUnit.PicolitersPerMililiter).PicolitersPerMililiter, PicolitersPerMililiterTolerance);
        }

        [Fact]
        public void FromDecimalFractions_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => VolumeConcentration.FromDecimalFractions(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => VolumeConcentration.FromDecimalFractions(double.NegativeInfinity));
        }

        [Fact]
        public void FromDecimalFractions_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => VolumeConcentration.FromDecimalFractions(double.NaN));
        }

        [Fact]
        public void As()
        {
            var decimalfraction = VolumeConcentration.FromDecimalFractions(1);
            AssertEx.EqualTolerance(CentilitersPerLiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.CentilitersPerLiter), CentilitersPerLiterTolerance);
            AssertEx.EqualTolerance(CentilitersPerMililiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.CentilitersPerMililiter), CentilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(DecilitersPerLiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.DecilitersPerLiter), DecilitersPerLiterTolerance);
            AssertEx.EqualTolerance(DecilitersPerMililiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.DecilitersPerMililiter), DecilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.DecimalFraction), DecimalFractionsTolerance);
            AssertEx.EqualTolerance(LitersPerLiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.LitersPerLiter), LitersPerLiterTolerance);
            AssertEx.EqualTolerance(LitersPerMililiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.LitersPerMililiter), LitersPerMililiterTolerance);
            AssertEx.EqualTolerance(MicrolitersPerLiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.MicrolitersPerLiter), MicrolitersPerLiterTolerance);
            AssertEx.EqualTolerance(MicrolitersPerMililiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.MicrolitersPerMililiter), MicrolitersPerMililiterTolerance);
            AssertEx.EqualTolerance(MillilitersPerLiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.MillilitersPerLiter), MillilitersPerLiterTolerance);
            AssertEx.EqualTolerance(MillilitersPerMililiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.MillilitersPerMililiter), MillilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(NanolitersPerLiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.NanolitersPerLiter), NanolitersPerLiterTolerance);
            AssertEx.EqualTolerance(NanolitersPerMililiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.NanolitersPerMililiter), NanolitersPerMililiterTolerance);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.PartPerBillion), PartsPerBillionTolerance);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.PartPerMillion), PartsPerMillionTolerance);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.PartPerThousand), PartsPerThousandTolerance);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.PartPerTrillion), PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.Percent), PercentTolerance);
            AssertEx.EqualTolerance(PicolitersPerLiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.PicolitersPerLiter), PicolitersPerLiterTolerance);
            AssertEx.EqualTolerance(PicolitersPerMililiterInOneDecimalFraction, decimalfraction.As(VolumeConcentrationUnit.PicolitersPerMililiter), PicolitersPerMililiterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var decimalfraction = VolumeConcentration.FromDecimalFractions(1);

            var centilitersperliterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.CentilitersPerLiter);
            AssertEx.EqualTolerance(CentilitersPerLiterInOneDecimalFraction, (double)centilitersperliterQuantity.Value, CentilitersPerLiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.CentilitersPerLiter, centilitersperliterQuantity.Unit);

            var centiliterspermililiterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.CentilitersPerMililiter);
            AssertEx.EqualTolerance(CentilitersPerMililiterInOneDecimalFraction, (double)centiliterspermililiterQuantity.Value, CentilitersPerMililiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.CentilitersPerMililiter, centiliterspermililiterQuantity.Unit);

            var decilitersperliterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.DecilitersPerLiter);
            AssertEx.EqualTolerance(DecilitersPerLiterInOneDecimalFraction, (double)decilitersperliterQuantity.Value, DecilitersPerLiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.DecilitersPerLiter, decilitersperliterQuantity.Unit);

            var deciliterspermililiterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.DecilitersPerMililiter);
            AssertEx.EqualTolerance(DecilitersPerMililiterInOneDecimalFraction, (double)deciliterspermililiterQuantity.Value, DecilitersPerMililiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.DecilitersPerMililiter, deciliterspermililiterQuantity.Unit);

            var decimalfractionQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.DecimalFraction);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, (double)decimalfractionQuantity.Value, DecimalFractionsTolerance);
            Assert.Equal(VolumeConcentrationUnit.DecimalFraction, decimalfractionQuantity.Unit);

            var litersperliterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.LitersPerLiter);
            AssertEx.EqualTolerance(LitersPerLiterInOneDecimalFraction, (double)litersperliterQuantity.Value, LitersPerLiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.LitersPerLiter, litersperliterQuantity.Unit);

            var literspermililiterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.LitersPerMililiter);
            AssertEx.EqualTolerance(LitersPerMililiterInOneDecimalFraction, (double)literspermililiterQuantity.Value, LitersPerMililiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.LitersPerMililiter, literspermililiterQuantity.Unit);

            var microlitersperliterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.MicrolitersPerLiter);
            AssertEx.EqualTolerance(MicrolitersPerLiterInOneDecimalFraction, (double)microlitersperliterQuantity.Value, MicrolitersPerLiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.MicrolitersPerLiter, microlitersperliterQuantity.Unit);

            var microliterspermililiterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.MicrolitersPerMililiter);
            AssertEx.EqualTolerance(MicrolitersPerMililiterInOneDecimalFraction, (double)microliterspermililiterQuantity.Value, MicrolitersPerMililiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.MicrolitersPerMililiter, microliterspermililiterQuantity.Unit);

            var millilitersperliterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.MillilitersPerLiter);
            AssertEx.EqualTolerance(MillilitersPerLiterInOneDecimalFraction, (double)millilitersperliterQuantity.Value, MillilitersPerLiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.MillilitersPerLiter, millilitersperliterQuantity.Unit);

            var milliliterspermililiterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.MillilitersPerMililiter);
            AssertEx.EqualTolerance(MillilitersPerMililiterInOneDecimalFraction, (double)milliliterspermililiterQuantity.Value, MillilitersPerMililiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.MillilitersPerMililiter, milliliterspermililiterQuantity.Unit);

            var nanolitersperliterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.NanolitersPerLiter);
            AssertEx.EqualTolerance(NanolitersPerLiterInOneDecimalFraction, (double)nanolitersperliterQuantity.Value, NanolitersPerLiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.NanolitersPerLiter, nanolitersperliterQuantity.Unit);

            var nanoliterspermililiterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.NanolitersPerMililiter);
            AssertEx.EqualTolerance(NanolitersPerMililiterInOneDecimalFraction, (double)nanoliterspermililiterQuantity.Value, NanolitersPerMililiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.NanolitersPerMililiter, nanoliterspermililiterQuantity.Unit);

            var partperbillionQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.PartPerBillion);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, (double)partperbillionQuantity.Value, PartsPerBillionTolerance);
            Assert.Equal(VolumeConcentrationUnit.PartPerBillion, partperbillionQuantity.Unit);

            var partpermillionQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.PartPerMillion);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, (double)partpermillionQuantity.Value, PartsPerMillionTolerance);
            Assert.Equal(VolumeConcentrationUnit.PartPerMillion, partpermillionQuantity.Unit);

            var partperthousandQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.PartPerThousand);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, (double)partperthousandQuantity.Value, PartsPerThousandTolerance);
            Assert.Equal(VolumeConcentrationUnit.PartPerThousand, partperthousandQuantity.Unit);

            var partpertrillionQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.PartPerTrillion);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, (double)partpertrillionQuantity.Value, PartsPerTrillionTolerance);
            Assert.Equal(VolumeConcentrationUnit.PartPerTrillion, partpertrillionQuantity.Unit);

            var percentQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.Percent);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, (double)percentQuantity.Value, PercentTolerance);
            Assert.Equal(VolumeConcentrationUnit.Percent, percentQuantity.Unit);

            var picolitersperliterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.PicolitersPerLiter);
            AssertEx.EqualTolerance(PicolitersPerLiterInOneDecimalFraction, (double)picolitersperliterQuantity.Value, PicolitersPerLiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.PicolitersPerLiter, picolitersperliterQuantity.Unit);

            var picoliterspermililiterQuantity = decimalfraction.ToUnit(VolumeConcentrationUnit.PicolitersPerMililiter);
            AssertEx.EqualTolerance(PicolitersPerMililiterInOneDecimalFraction, (double)picoliterspermililiterQuantity.Value, PicolitersPerMililiterTolerance);
            Assert.Equal(VolumeConcentrationUnit.PicolitersPerMililiter, picoliterspermililiterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            VolumeConcentration decimalfraction = VolumeConcentration.FromDecimalFractions(1);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromCentilitersPerLiter(decimalfraction.CentilitersPerLiter).DecimalFractions, CentilitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromCentilitersPerMililiter(decimalfraction.CentilitersPerMililiter).DecimalFractions, CentilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromDecilitersPerLiter(decimalfraction.DecilitersPerLiter).DecimalFractions, DecilitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromDecilitersPerMililiter(decimalfraction.DecilitersPerMililiter).DecimalFractions, DecilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromDecimalFractions(decimalfraction.DecimalFractions).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromLitersPerLiter(decimalfraction.LitersPerLiter).DecimalFractions, LitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromLitersPerMililiter(decimalfraction.LitersPerMililiter).DecimalFractions, LitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromMicrolitersPerLiter(decimalfraction.MicrolitersPerLiter).DecimalFractions, MicrolitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromMicrolitersPerMililiter(decimalfraction.MicrolitersPerMililiter).DecimalFractions, MicrolitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromMillilitersPerLiter(decimalfraction.MillilitersPerLiter).DecimalFractions, MillilitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromMillilitersPerMililiter(decimalfraction.MillilitersPerMililiter).DecimalFractions, MillilitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromNanolitersPerLiter(decimalfraction.NanolitersPerLiter).DecimalFractions, NanolitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromNanolitersPerMililiter(decimalfraction.NanolitersPerMililiter).DecimalFractions, NanolitersPerMililiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromPartsPerBillion(decimalfraction.PartsPerBillion).DecimalFractions, PartsPerBillionTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromPartsPerMillion(decimalfraction.PartsPerMillion).DecimalFractions, PartsPerMillionTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromPartsPerThousand(decimalfraction.PartsPerThousand).DecimalFractions, PartsPerThousandTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromPartsPerTrillion(decimalfraction.PartsPerTrillion).DecimalFractions, PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromPercent(decimalfraction.Percent).DecimalFractions, PercentTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromPicolitersPerLiter(decimalfraction.PicolitersPerLiter).DecimalFractions, PicolitersPerLiterTolerance);
            AssertEx.EqualTolerance(1, VolumeConcentration.FromPicolitersPerMililiter(decimalfraction.PicolitersPerMililiter).DecimalFractions, PicolitersPerMililiterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            VolumeConcentration v = VolumeConcentration.FromDecimalFractions(1);
            AssertEx.EqualTolerance(-1, -v.DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (VolumeConcentration.FromDecimalFractions(3)-v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (v + v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(10, (v*10).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(10, (10*v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (VolumeConcentration.FromDecimalFractions(10)/5).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, VolumeConcentration.FromDecimalFractions(10)/VolumeConcentration.FromDecimalFractions(5), DecimalFractionsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            VolumeConcentration oneDecimalFraction = VolumeConcentration.FromDecimalFractions(1);
            VolumeConcentration twoDecimalFractions = VolumeConcentration.FromDecimalFractions(2);

            Assert.True(oneDecimalFraction < twoDecimalFractions);
            Assert.True(oneDecimalFraction <= twoDecimalFractions);
            Assert.True(twoDecimalFractions > oneDecimalFraction);
            Assert.True(twoDecimalFractions >= oneDecimalFraction);

            Assert.False(oneDecimalFraction > twoDecimalFractions);
            Assert.False(oneDecimalFraction >= twoDecimalFractions);
            Assert.False(twoDecimalFractions < oneDecimalFraction);
            Assert.False(twoDecimalFractions <= oneDecimalFraction);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            VolumeConcentration decimalfraction = VolumeConcentration.FromDecimalFractions(1);
            Assert.Equal(0, decimalfraction.CompareTo(decimalfraction));
            Assert.True(decimalfraction.CompareTo(VolumeConcentration.Zero) > 0);
            Assert.True(VolumeConcentration.Zero.CompareTo(decimalfraction) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            VolumeConcentration decimalfraction = VolumeConcentration.FromDecimalFractions(1);
            Assert.Throws<ArgumentException>(() => decimalfraction.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            VolumeConcentration decimalfraction = VolumeConcentration.FromDecimalFractions(1);
            Assert.Throws<ArgumentNullException>(() => decimalfraction.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = VolumeConcentration.FromDecimalFractions(1);
            var b = VolumeConcentration.FromDecimalFractions(2);

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
            var a = VolumeConcentration.FromDecimalFractions(1);
            var b = VolumeConcentration.FromDecimalFractions(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = VolumeConcentration.FromDecimalFractions(1);
            Assert.True(v.Equals(VolumeConcentration.FromDecimalFractions(1), DecimalFractionsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(VolumeConcentration.Zero, DecimalFractionsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            VolumeConcentration decimalfraction = VolumeConcentration.FromDecimalFractions(1);
            Assert.False(decimalfraction.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            VolumeConcentration decimalfraction = VolumeConcentration.FromDecimalFractions(1);
            Assert.False(decimalfraction.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(VolumeConcentrationUnit.Undefined, VolumeConcentration.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(VolumeConcentrationUnit)).Cast<VolumeConcentrationUnit>();
            foreach(var unit in units)
            {
                if(unit == VolumeConcentrationUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(VolumeConcentration.BaseDimensions is null);
        }
    }
}

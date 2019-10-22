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
    /// Test of Mass.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MassTestsBase
    {
        protected abstract double CentigramsInOneKilogram { get; }
        protected abstract double DecagramsInOneKilogram { get; }
        protected abstract double DecigramsInOneKilogram { get; }
        protected abstract double EarthMassesInOneKilogram { get; }
        protected abstract double GrainsInOneKilogram { get; }
        protected abstract double GramsInOneKilogram { get; }
        protected abstract double HectogramsInOneKilogram { get; }
        protected abstract double KilogramsInOneKilogram { get; }
        protected abstract double KilopoundsInOneKilogram { get; }
        protected abstract double KilotonnesInOneKilogram { get; }
        protected abstract double LongHundredweightInOneKilogram { get; }
        protected abstract double LongTonsInOneKilogram { get; }
        protected abstract double MegapoundsInOneKilogram { get; }
        protected abstract double MegatonnesInOneKilogram { get; }
        protected abstract double MicrogramsInOneKilogram { get; }
        protected abstract double MilligramsInOneKilogram { get; }
        protected abstract double NanogramsInOneKilogram { get; }
        protected abstract double OuncesInOneKilogram { get; }
        protected abstract double PoundsInOneKilogram { get; }
        protected abstract double ShortHundredweightInOneKilogram { get; }
        protected abstract double ShortTonsInOneKilogram { get; }
        protected abstract double SlugsInOneKilogram { get; }
        protected abstract double SolarMassesInOneKilogram { get; }
        protected abstract double StoneInOneKilogram { get; }
        protected abstract double TonnesInOneKilogram { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentigramsTolerance { get { return 1e-5; } }
        protected virtual double DecagramsTolerance { get { return 1e-5; } }
        protected virtual double DecigramsTolerance { get { return 1e-5; } }
        protected virtual double EarthMassesTolerance { get { return 1e-5; } }
        protected virtual double GrainsTolerance { get { return 1e-5; } }
        protected virtual double GramsTolerance { get { return 1e-5; } }
        protected virtual double HectogramsTolerance { get { return 1e-5; } }
        protected virtual double KilogramsTolerance { get { return 1e-5; } }
        protected virtual double KilopoundsTolerance { get { return 1e-5; } }
        protected virtual double KilotonnesTolerance { get { return 1e-5; } }
        protected virtual double LongHundredweightTolerance { get { return 1e-5; } }
        protected virtual double LongTonsTolerance { get { return 1e-5; } }
        protected virtual double MegapoundsTolerance { get { return 1e-5; } }
        protected virtual double MegatonnesTolerance { get { return 1e-5; } }
        protected virtual double MicrogramsTolerance { get { return 1e-5; } }
        protected virtual double MilligramsTolerance { get { return 1e-5; } }
        protected virtual double NanogramsTolerance { get { return 1e-5; } }
        protected virtual double OuncesTolerance { get { return 1e-5; } }
        protected virtual double PoundsTolerance { get { return 1e-5; } }
        protected virtual double ShortHundredweightTolerance { get { return 1e-5; } }
        protected virtual double ShortTonsTolerance { get { return 1e-5; } }
        protected virtual double SlugsTolerance { get { return 1e-5; } }
        protected virtual double SolarMassesTolerance { get { return 1e-5; } }
        protected virtual double StoneTolerance { get { return 1e-5; } }
        protected virtual double TonnesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Mass<double>((double)0.0, MassUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Mass<double>(double.PositiveInfinity, MassUnit.Kilogram));
            Assert.Throws<ArgumentException>(() => new Mass<double>(double.NegativeInfinity, MassUnit.Kilogram));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Mass<double>(double.NaN, MassUnit.Kilogram));
        }

        [Fact]
        public void KilogramToMassUnits()
        {
            Mass<double> kilogram = Mass<double>.FromKilograms(1);
            AssertEx.EqualTolerance(CentigramsInOneKilogram, kilogram.Centigrams, CentigramsTolerance);
            AssertEx.EqualTolerance(DecagramsInOneKilogram, kilogram.Decagrams, DecagramsTolerance);
            AssertEx.EqualTolerance(DecigramsInOneKilogram, kilogram.Decigrams, DecigramsTolerance);
            AssertEx.EqualTolerance(EarthMassesInOneKilogram, kilogram.EarthMasses, EarthMassesTolerance);
            AssertEx.EqualTolerance(GrainsInOneKilogram, kilogram.Grains, GrainsTolerance);
            AssertEx.EqualTolerance(GramsInOneKilogram, kilogram.Grams, GramsTolerance);
            AssertEx.EqualTolerance(HectogramsInOneKilogram, kilogram.Hectograms, HectogramsTolerance);
            AssertEx.EqualTolerance(KilogramsInOneKilogram, kilogram.Kilograms, KilogramsTolerance);
            AssertEx.EqualTolerance(KilopoundsInOneKilogram, kilogram.Kilopounds, KilopoundsTolerance);
            AssertEx.EqualTolerance(KilotonnesInOneKilogram, kilogram.Kilotonnes, KilotonnesTolerance);
            AssertEx.EqualTolerance(LongHundredweightInOneKilogram, kilogram.LongHundredweight, LongHundredweightTolerance);
            AssertEx.EqualTolerance(LongTonsInOneKilogram, kilogram.LongTons, LongTonsTolerance);
            AssertEx.EqualTolerance(MegapoundsInOneKilogram, kilogram.Megapounds, MegapoundsTolerance);
            AssertEx.EqualTolerance(MegatonnesInOneKilogram, kilogram.Megatonnes, MegatonnesTolerance);
            AssertEx.EqualTolerance(MicrogramsInOneKilogram, kilogram.Micrograms, MicrogramsTolerance);
            AssertEx.EqualTolerance(MilligramsInOneKilogram, kilogram.Milligrams, MilligramsTolerance);
            AssertEx.EqualTolerance(NanogramsInOneKilogram, kilogram.Nanograms, NanogramsTolerance);
            AssertEx.EqualTolerance(OuncesInOneKilogram, kilogram.Ounces, OuncesTolerance);
            AssertEx.EqualTolerance(PoundsInOneKilogram, kilogram.Pounds, PoundsTolerance);
            AssertEx.EqualTolerance(ShortHundredweightInOneKilogram, kilogram.ShortHundredweight, ShortHundredweightTolerance);
            AssertEx.EqualTolerance(ShortTonsInOneKilogram, kilogram.ShortTons, ShortTonsTolerance);
            AssertEx.EqualTolerance(SlugsInOneKilogram, kilogram.Slugs, SlugsTolerance);
            AssertEx.EqualTolerance(SolarMassesInOneKilogram, kilogram.SolarMasses, SolarMassesTolerance);
            AssertEx.EqualTolerance(StoneInOneKilogram, kilogram.Stone, StoneTolerance);
            AssertEx.EqualTolerance(TonnesInOneKilogram, kilogram.Tonnes, TonnesTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Centigram).Centigrams, CentigramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Decagram).Decagrams, DecagramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Decigram).Decigrams, DecigramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.EarthMass).EarthMasses, EarthMassesTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Grain).Grains, GrainsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Gram).Grams, GramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Hectogram).Hectograms, HectogramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Kilogram).Kilograms, KilogramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Kilopound).Kilopounds, KilopoundsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Kilotonne).Kilotonnes, KilotonnesTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.LongHundredweight).LongHundredweight, LongHundredweightTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.LongTon).LongTons, LongTonsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Megapound).Megapounds, MegapoundsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Megatonne).Megatonnes, MegatonnesTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Microgram).Micrograms, MicrogramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Milligram).Milligrams, MilligramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Nanogram).Nanograms, NanogramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Ounce).Ounces, OuncesTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Pound).Pounds, PoundsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.ShortHundredweight).ShortHundredweight, ShortHundredweightTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.ShortTon).ShortTons, ShortTonsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Slug).Slugs, SlugsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.SolarMass).SolarMasses, SolarMassesTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Stone).Stone, StoneTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.From(1, MassUnit.Tonne).Tonnes, TonnesTolerance);
        }

        [Fact]
        public void FromKilograms_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Mass<double>.FromKilograms(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Mass<double>.FromKilograms(double.NegativeInfinity));
        }

        [Fact]
        public void FromKilograms_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Mass<double>.FromKilograms(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kilogram = Mass<double>.FromKilograms(1);
            AssertEx.EqualTolerance(CentigramsInOneKilogram, kilogram.As(MassUnit.Centigram), CentigramsTolerance);
            AssertEx.EqualTolerance(DecagramsInOneKilogram, kilogram.As(MassUnit.Decagram), DecagramsTolerance);
            AssertEx.EqualTolerance(DecigramsInOneKilogram, kilogram.As(MassUnit.Decigram), DecigramsTolerance);
            AssertEx.EqualTolerance(EarthMassesInOneKilogram, kilogram.As(MassUnit.EarthMass), EarthMassesTolerance);
            AssertEx.EqualTolerance(GrainsInOneKilogram, kilogram.As(MassUnit.Grain), GrainsTolerance);
            AssertEx.EqualTolerance(GramsInOneKilogram, kilogram.As(MassUnit.Gram), GramsTolerance);
            AssertEx.EqualTolerance(HectogramsInOneKilogram, kilogram.As(MassUnit.Hectogram), HectogramsTolerance);
            AssertEx.EqualTolerance(KilogramsInOneKilogram, kilogram.As(MassUnit.Kilogram), KilogramsTolerance);
            AssertEx.EqualTolerance(KilopoundsInOneKilogram, kilogram.As(MassUnit.Kilopound), KilopoundsTolerance);
            AssertEx.EqualTolerance(KilotonnesInOneKilogram, kilogram.As(MassUnit.Kilotonne), KilotonnesTolerance);
            AssertEx.EqualTolerance(LongHundredweightInOneKilogram, kilogram.As(MassUnit.LongHundredweight), LongHundredweightTolerance);
            AssertEx.EqualTolerance(LongTonsInOneKilogram, kilogram.As(MassUnit.LongTon), LongTonsTolerance);
            AssertEx.EqualTolerance(MegapoundsInOneKilogram, kilogram.As(MassUnit.Megapound), MegapoundsTolerance);
            AssertEx.EqualTolerance(MegatonnesInOneKilogram, kilogram.As(MassUnit.Megatonne), MegatonnesTolerance);
            AssertEx.EqualTolerance(MicrogramsInOneKilogram, kilogram.As(MassUnit.Microgram), MicrogramsTolerance);
            AssertEx.EqualTolerance(MilligramsInOneKilogram, kilogram.As(MassUnit.Milligram), MilligramsTolerance);
            AssertEx.EqualTolerance(NanogramsInOneKilogram, kilogram.As(MassUnit.Nanogram), NanogramsTolerance);
            AssertEx.EqualTolerance(OuncesInOneKilogram, kilogram.As(MassUnit.Ounce), OuncesTolerance);
            AssertEx.EqualTolerance(PoundsInOneKilogram, kilogram.As(MassUnit.Pound), PoundsTolerance);
            AssertEx.EqualTolerance(ShortHundredweightInOneKilogram, kilogram.As(MassUnit.ShortHundredweight), ShortHundredweightTolerance);
            AssertEx.EqualTolerance(ShortTonsInOneKilogram, kilogram.As(MassUnit.ShortTon), ShortTonsTolerance);
            AssertEx.EqualTolerance(SlugsInOneKilogram, kilogram.As(MassUnit.Slug), SlugsTolerance);
            AssertEx.EqualTolerance(SolarMassesInOneKilogram, kilogram.As(MassUnit.SolarMass), SolarMassesTolerance);
            AssertEx.EqualTolerance(StoneInOneKilogram, kilogram.As(MassUnit.Stone), StoneTolerance);
            AssertEx.EqualTolerance(TonnesInOneKilogram, kilogram.As(MassUnit.Tonne), TonnesTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kilogram = Mass<double>.FromKilograms(1);

            var centigramQuantity = kilogram.ToUnit(MassUnit.Centigram);
            AssertEx.EqualTolerance(CentigramsInOneKilogram, (double)centigramQuantity.Value, CentigramsTolerance);
            Assert.Equal(MassUnit.Centigram, centigramQuantity.Unit);

            var decagramQuantity = kilogram.ToUnit(MassUnit.Decagram);
            AssertEx.EqualTolerance(DecagramsInOneKilogram, (double)decagramQuantity.Value, DecagramsTolerance);
            Assert.Equal(MassUnit.Decagram, decagramQuantity.Unit);

            var decigramQuantity = kilogram.ToUnit(MassUnit.Decigram);
            AssertEx.EqualTolerance(DecigramsInOneKilogram, (double)decigramQuantity.Value, DecigramsTolerance);
            Assert.Equal(MassUnit.Decigram, decigramQuantity.Unit);

            var earthmassQuantity = kilogram.ToUnit(MassUnit.EarthMass);
            AssertEx.EqualTolerance(EarthMassesInOneKilogram, (double)earthmassQuantity.Value, EarthMassesTolerance);
            Assert.Equal(MassUnit.EarthMass, earthmassQuantity.Unit);

            var grainQuantity = kilogram.ToUnit(MassUnit.Grain);
            AssertEx.EqualTolerance(GrainsInOneKilogram, (double)grainQuantity.Value, GrainsTolerance);
            Assert.Equal(MassUnit.Grain, grainQuantity.Unit);

            var gramQuantity = kilogram.ToUnit(MassUnit.Gram);
            AssertEx.EqualTolerance(GramsInOneKilogram, (double)gramQuantity.Value, GramsTolerance);
            Assert.Equal(MassUnit.Gram, gramQuantity.Unit);

            var hectogramQuantity = kilogram.ToUnit(MassUnit.Hectogram);
            AssertEx.EqualTolerance(HectogramsInOneKilogram, (double)hectogramQuantity.Value, HectogramsTolerance);
            Assert.Equal(MassUnit.Hectogram, hectogramQuantity.Unit);

            var kilogramQuantity = kilogram.ToUnit(MassUnit.Kilogram);
            AssertEx.EqualTolerance(KilogramsInOneKilogram, (double)kilogramQuantity.Value, KilogramsTolerance);
            Assert.Equal(MassUnit.Kilogram, kilogramQuantity.Unit);

            var kilopoundQuantity = kilogram.ToUnit(MassUnit.Kilopound);
            AssertEx.EqualTolerance(KilopoundsInOneKilogram, (double)kilopoundQuantity.Value, KilopoundsTolerance);
            Assert.Equal(MassUnit.Kilopound, kilopoundQuantity.Unit);

            var kilotonneQuantity = kilogram.ToUnit(MassUnit.Kilotonne);
            AssertEx.EqualTolerance(KilotonnesInOneKilogram, (double)kilotonneQuantity.Value, KilotonnesTolerance);
            Assert.Equal(MassUnit.Kilotonne, kilotonneQuantity.Unit);

            var longhundredweightQuantity = kilogram.ToUnit(MassUnit.LongHundredweight);
            AssertEx.EqualTolerance(LongHundredweightInOneKilogram, (double)longhundredweightQuantity.Value, LongHundredweightTolerance);
            Assert.Equal(MassUnit.LongHundredweight, longhundredweightQuantity.Unit);

            var longtonQuantity = kilogram.ToUnit(MassUnit.LongTon);
            AssertEx.EqualTolerance(LongTonsInOneKilogram, (double)longtonQuantity.Value, LongTonsTolerance);
            Assert.Equal(MassUnit.LongTon, longtonQuantity.Unit);

            var megapoundQuantity = kilogram.ToUnit(MassUnit.Megapound);
            AssertEx.EqualTolerance(MegapoundsInOneKilogram, (double)megapoundQuantity.Value, MegapoundsTolerance);
            Assert.Equal(MassUnit.Megapound, megapoundQuantity.Unit);

            var megatonneQuantity = kilogram.ToUnit(MassUnit.Megatonne);
            AssertEx.EqualTolerance(MegatonnesInOneKilogram, (double)megatonneQuantity.Value, MegatonnesTolerance);
            Assert.Equal(MassUnit.Megatonne, megatonneQuantity.Unit);

            var microgramQuantity = kilogram.ToUnit(MassUnit.Microgram);
            AssertEx.EqualTolerance(MicrogramsInOneKilogram, (double)microgramQuantity.Value, MicrogramsTolerance);
            Assert.Equal(MassUnit.Microgram, microgramQuantity.Unit);

            var milligramQuantity = kilogram.ToUnit(MassUnit.Milligram);
            AssertEx.EqualTolerance(MilligramsInOneKilogram, (double)milligramQuantity.Value, MilligramsTolerance);
            Assert.Equal(MassUnit.Milligram, milligramQuantity.Unit);

            var nanogramQuantity = kilogram.ToUnit(MassUnit.Nanogram);
            AssertEx.EqualTolerance(NanogramsInOneKilogram, (double)nanogramQuantity.Value, NanogramsTolerance);
            Assert.Equal(MassUnit.Nanogram, nanogramQuantity.Unit);

            var ounceQuantity = kilogram.ToUnit(MassUnit.Ounce);
            AssertEx.EqualTolerance(OuncesInOneKilogram, (double)ounceQuantity.Value, OuncesTolerance);
            Assert.Equal(MassUnit.Ounce, ounceQuantity.Unit);

            var poundQuantity = kilogram.ToUnit(MassUnit.Pound);
            AssertEx.EqualTolerance(PoundsInOneKilogram, (double)poundQuantity.Value, PoundsTolerance);
            Assert.Equal(MassUnit.Pound, poundQuantity.Unit);

            var shorthundredweightQuantity = kilogram.ToUnit(MassUnit.ShortHundredweight);
            AssertEx.EqualTolerance(ShortHundredweightInOneKilogram, (double)shorthundredweightQuantity.Value, ShortHundredweightTolerance);
            Assert.Equal(MassUnit.ShortHundredweight, shorthundredweightQuantity.Unit);

            var shorttonQuantity = kilogram.ToUnit(MassUnit.ShortTon);
            AssertEx.EqualTolerance(ShortTonsInOneKilogram, (double)shorttonQuantity.Value, ShortTonsTolerance);
            Assert.Equal(MassUnit.ShortTon, shorttonQuantity.Unit);

            var slugQuantity = kilogram.ToUnit(MassUnit.Slug);
            AssertEx.EqualTolerance(SlugsInOneKilogram, (double)slugQuantity.Value, SlugsTolerance);
            Assert.Equal(MassUnit.Slug, slugQuantity.Unit);

            var solarmassQuantity = kilogram.ToUnit(MassUnit.SolarMass);
            AssertEx.EqualTolerance(SolarMassesInOneKilogram, (double)solarmassQuantity.Value, SolarMassesTolerance);
            Assert.Equal(MassUnit.SolarMass, solarmassQuantity.Unit);

            var stoneQuantity = kilogram.ToUnit(MassUnit.Stone);
            AssertEx.EqualTolerance(StoneInOneKilogram, (double)stoneQuantity.Value, StoneTolerance);
            Assert.Equal(MassUnit.Stone, stoneQuantity.Unit);

            var tonneQuantity = kilogram.ToUnit(MassUnit.Tonne);
            AssertEx.EqualTolerance(TonnesInOneKilogram, (double)tonneQuantity.Value, TonnesTolerance);
            Assert.Equal(MassUnit.Tonne, tonneQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Mass<double> kilogram = Mass<double>.FromKilograms(1);
            AssertEx.EqualTolerance(1, Mass<double>.FromCentigrams(kilogram.Centigrams).Kilograms, CentigramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromDecagrams(kilogram.Decagrams).Kilograms, DecagramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromDecigrams(kilogram.Decigrams).Kilograms, DecigramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromEarthMasses(kilogram.EarthMasses).Kilograms, EarthMassesTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromGrains(kilogram.Grains).Kilograms, GrainsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromGrams(kilogram.Grams).Kilograms, GramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromHectograms(kilogram.Hectograms).Kilograms, HectogramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromKilograms(kilogram.Kilograms).Kilograms, KilogramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromKilopounds(kilogram.Kilopounds).Kilograms, KilopoundsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromKilotonnes(kilogram.Kilotonnes).Kilograms, KilotonnesTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromLongHundredweight(kilogram.LongHundredweight).Kilograms, LongHundredweightTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromLongTons(kilogram.LongTons).Kilograms, LongTonsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromMegapounds(kilogram.Megapounds).Kilograms, MegapoundsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromMegatonnes(kilogram.Megatonnes).Kilograms, MegatonnesTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromMicrograms(kilogram.Micrograms).Kilograms, MicrogramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromMilligrams(kilogram.Milligrams).Kilograms, MilligramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromNanograms(kilogram.Nanograms).Kilograms, NanogramsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromOunces(kilogram.Ounces).Kilograms, OuncesTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromPounds(kilogram.Pounds).Kilograms, PoundsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromShortHundredweight(kilogram.ShortHundredweight).Kilograms, ShortHundredweightTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromShortTons(kilogram.ShortTons).Kilograms, ShortTonsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromSlugs(kilogram.Slugs).Kilograms, SlugsTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromSolarMasses(kilogram.SolarMasses).Kilograms, SolarMassesTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromStone(kilogram.Stone).Kilograms, StoneTolerance);
            AssertEx.EqualTolerance(1, Mass<double>.FromTonnes(kilogram.Tonnes).Kilograms, TonnesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Mass<double> v = Mass<double>.FromKilograms(1);
            AssertEx.EqualTolerance(-1, -v.Kilograms, KilogramsTolerance);
            AssertEx.EqualTolerance(2, (Mass<double>.FromKilograms(3)-v).Kilograms, KilogramsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Kilograms, KilogramsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Kilograms, KilogramsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Kilograms, KilogramsTolerance);
            AssertEx.EqualTolerance(2, (Mass<double>.FromKilograms(10)/5).Kilograms, KilogramsTolerance);
            AssertEx.EqualTolerance(2, Mass<double>.FromKilograms(10)/Mass<double>.FromKilograms(5), KilogramsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Mass<double> oneKilogram = Mass<double>.FromKilograms(1);
            Mass<double> twoKilograms = Mass<double>.FromKilograms(2);

            Assert.True(oneKilogram < twoKilograms);
            Assert.True(oneKilogram <= twoKilograms);
            Assert.True(twoKilograms > oneKilogram);
            Assert.True(twoKilograms >= oneKilogram);

            Assert.False(oneKilogram > twoKilograms);
            Assert.False(oneKilogram >= twoKilograms);
            Assert.False(twoKilograms < oneKilogram);
            Assert.False(twoKilograms <= oneKilogram);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Mass<double> kilogram = Mass<double>.FromKilograms(1);
            Assert.Equal(0, kilogram.CompareTo(kilogram));
            Assert.True(kilogram.CompareTo(Mass<double>.Zero) > 0);
            Assert.True(Mass<double>.Zero.CompareTo(kilogram) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Mass<double> kilogram = Mass<double>.FromKilograms(1);
            Assert.Throws<ArgumentException>(() => kilogram.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Mass<double> kilogram = Mass<double>.FromKilograms(1);
            Assert.Throws<ArgumentNullException>(() => kilogram.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Mass<double>.FromKilograms(1);
            var b = Mass<double>.FromKilograms(2);

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
            var a = Mass<double>.FromKilograms(1);
            var b = Mass<double>.FromKilograms(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = Mass<double>.FromKilograms(1);
            Assert.True(v.Equals(Mass<double>.FromKilograms(1), KilogramsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Mass<double>.Zero, KilogramsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Mass<double> kilogram = Mass<double>.FromKilograms(1);
            Assert.False(kilogram.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Mass<double> kilogram = Mass<double>.FromKilograms(1);
            Assert.False(kilogram.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MassUnit.Undefined, Mass<double>.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MassUnit)).Cast<MassUnit>();
            foreach(var unit in units)
            {
                if(unit == MassUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Mass<double>.BaseDimensions is null);
        }
    }
}

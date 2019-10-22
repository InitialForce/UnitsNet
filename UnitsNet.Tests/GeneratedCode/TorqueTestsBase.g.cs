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
    /// Test of Torque<double>.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class TorqueTestsBase
    {
        protected abstract double KilogramForceCentimetersInOneNewtonMeter { get; }
        protected abstract double KilogramForceMetersInOneNewtonMeter { get; }
        protected abstract double KilogramForceMillimetersInOneNewtonMeter { get; }
        protected abstract double KilonewtonCentimetersInOneNewtonMeter { get; }
        protected abstract double KilonewtonMetersInOneNewtonMeter { get; }
        protected abstract double KilonewtonMillimetersInOneNewtonMeter { get; }
        protected abstract double KilopoundForceFeetInOneNewtonMeter { get; }
        protected abstract double KilopoundForceInchesInOneNewtonMeter { get; }
        protected abstract double MeganewtonCentimetersInOneNewtonMeter { get; }
        protected abstract double MeganewtonMetersInOneNewtonMeter { get; }
        protected abstract double MeganewtonMillimetersInOneNewtonMeter { get; }
        protected abstract double MegapoundForceFeetInOneNewtonMeter { get; }
        protected abstract double MegapoundForceInchesInOneNewtonMeter { get; }
        protected abstract double NewtonCentimetersInOneNewtonMeter { get; }
        protected abstract double NewtonMetersInOneNewtonMeter { get; }
        protected abstract double NewtonMillimetersInOneNewtonMeter { get; }
        protected abstract double PoundForceFeetInOneNewtonMeter { get; }
        protected abstract double PoundForceInchesInOneNewtonMeter { get; }
        protected abstract double TonneForceCentimetersInOneNewtonMeter { get; }
        protected abstract double TonneForceMetersInOneNewtonMeter { get; }
        protected abstract double TonneForceMillimetersInOneNewtonMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilogramForceCentimetersTolerance { get { return 1e-5; } }
        protected virtual double KilogramForceMetersTolerance { get { return 1e-5; } }
        protected virtual double KilogramForceMillimetersTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonCentimetersTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonMetersTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonMillimetersTolerance { get { return 1e-5; } }
        protected virtual double KilopoundForceFeetTolerance { get { return 1e-5; } }
        protected virtual double KilopoundForceInchesTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonCentimetersTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonMetersTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonMillimetersTolerance { get { return 1e-5; } }
        protected virtual double MegapoundForceFeetTolerance { get { return 1e-5; } }
        protected virtual double MegapoundForceInchesTolerance { get { return 1e-5; } }
        protected virtual double NewtonCentimetersTolerance { get { return 1e-5; } }
        protected virtual double NewtonMetersTolerance { get { return 1e-5; } }
        protected virtual double NewtonMillimetersTolerance { get { return 1e-5; } }
        protected virtual double PoundForceFeetTolerance { get { return 1e-5; } }
        protected virtual double PoundForceInchesTolerance { get { return 1e-5; } }
        protected virtual double TonneForceCentimetersTolerance { get { return 1e-5; } }
        protected virtual double TonneForceMetersTolerance { get { return 1e-5; } }
        protected virtual double TonneForceMillimetersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Torque<double>((double)0.0, TorqueUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Torque<double>(double.PositiveInfinity, TorqueUnit.NewtonMeter));
            Assert.Throws<ArgumentException>(() => new Torque<double>(double.NegativeInfinity, TorqueUnit.NewtonMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Torque<double>(double.NaN, TorqueUnit.NewtonMeter));
        }

        [Fact]
        public void NewtonMeterToTorqueUnits()
        {
            Torque<double> newtonmeter = Torque<double>.FromNewtonMeters(1);
            AssertEx.EqualTolerance(KilogramForceCentimetersInOneNewtonMeter, newtonmeter.KilogramForceCentimeters, KilogramForceCentimetersTolerance);
            AssertEx.EqualTolerance(KilogramForceMetersInOneNewtonMeter, newtonmeter.KilogramForceMeters, KilogramForceMetersTolerance);
            AssertEx.EqualTolerance(KilogramForceMillimetersInOneNewtonMeter, newtonmeter.KilogramForceMillimeters, KilogramForceMillimetersTolerance);
            AssertEx.EqualTolerance(KilonewtonCentimetersInOneNewtonMeter, newtonmeter.KilonewtonCentimeters, KilonewtonCentimetersTolerance);
            AssertEx.EqualTolerance(KilonewtonMetersInOneNewtonMeter, newtonmeter.KilonewtonMeters, KilonewtonMetersTolerance);
            AssertEx.EqualTolerance(KilonewtonMillimetersInOneNewtonMeter, newtonmeter.KilonewtonMillimeters, KilonewtonMillimetersTolerance);
            AssertEx.EqualTolerance(KilopoundForceFeetInOneNewtonMeter, newtonmeter.KilopoundForceFeet, KilopoundForceFeetTolerance);
            AssertEx.EqualTolerance(KilopoundForceInchesInOneNewtonMeter, newtonmeter.KilopoundForceInches, KilopoundForceInchesTolerance);
            AssertEx.EqualTolerance(MeganewtonCentimetersInOneNewtonMeter, newtonmeter.MeganewtonCentimeters, MeganewtonCentimetersTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersInOneNewtonMeter, newtonmeter.MeganewtonMeters, MeganewtonMetersTolerance);
            AssertEx.EqualTolerance(MeganewtonMillimetersInOneNewtonMeter, newtonmeter.MeganewtonMillimeters, MeganewtonMillimetersTolerance);
            AssertEx.EqualTolerance(MegapoundForceFeetInOneNewtonMeter, newtonmeter.MegapoundForceFeet, MegapoundForceFeetTolerance);
            AssertEx.EqualTolerance(MegapoundForceInchesInOneNewtonMeter, newtonmeter.MegapoundForceInches, MegapoundForceInchesTolerance);
            AssertEx.EqualTolerance(NewtonCentimetersInOneNewtonMeter, newtonmeter.NewtonCentimeters, NewtonCentimetersTolerance);
            AssertEx.EqualTolerance(NewtonMetersInOneNewtonMeter, newtonmeter.NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(NewtonMillimetersInOneNewtonMeter, newtonmeter.NewtonMillimeters, NewtonMillimetersTolerance);
            AssertEx.EqualTolerance(PoundForceFeetInOneNewtonMeter, newtonmeter.PoundForceFeet, PoundForceFeetTolerance);
            AssertEx.EqualTolerance(PoundForceInchesInOneNewtonMeter, newtonmeter.PoundForceInches, PoundForceInchesTolerance);
            AssertEx.EqualTolerance(TonneForceCentimetersInOneNewtonMeter, newtonmeter.TonneForceCentimeters, TonneForceCentimetersTolerance);
            AssertEx.EqualTolerance(TonneForceMetersInOneNewtonMeter, newtonmeter.TonneForceMeters, TonneForceMetersTolerance);
            AssertEx.EqualTolerance(TonneForceMillimetersInOneNewtonMeter, newtonmeter.TonneForceMillimeters, TonneForceMillimetersTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.KilogramForceCentimeter).KilogramForceCentimeters, KilogramForceCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.KilogramForceMeter).KilogramForceMeters, KilogramForceMetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.KilogramForceMillimeter).KilogramForceMillimeters, KilogramForceMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.KilonewtonCentimeter).KilonewtonCentimeters, KilonewtonCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.KilonewtonMeter).KilonewtonMeters, KilonewtonMetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.KilonewtonMillimeter).KilonewtonMillimeters, KilonewtonMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.KilopoundForceFoot).KilopoundForceFeet, KilopoundForceFeetTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.KilopoundForceInch).KilopoundForceInches, KilopoundForceInchesTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.MeganewtonCentimeter).MeganewtonCentimeters, MeganewtonCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.MeganewtonMeter).MeganewtonMeters, MeganewtonMetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.MeganewtonMillimeter).MeganewtonMillimeters, MeganewtonMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.MegapoundForceFoot).MegapoundForceFeet, MegapoundForceFeetTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.MegapoundForceInch).MegapoundForceInches, MegapoundForceInchesTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.NewtonCentimeter).NewtonCentimeters, NewtonCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.NewtonMeter).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.NewtonMillimeter).NewtonMillimeters, NewtonMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.PoundForceFoot).PoundForceFeet, PoundForceFeetTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.PoundForceInch).PoundForceInches, PoundForceInchesTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.TonneForceCentimeter).TonneForceCentimeters, TonneForceCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.TonneForceMeter).TonneForceMeters, TonneForceMetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.From(1, TorqueUnit.TonneForceMillimeter).TonneForceMillimeters, TonneForceMillimetersTolerance);
        }

        [Fact]
        public void FromNewtonMeters_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Torque<double>.FromNewtonMeters(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Torque<double>.FromNewtonMeters(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtonMeters_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Torque<double>.FromNewtonMeters(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newtonmeter = Torque<double>.FromNewtonMeters(1);
            AssertEx.EqualTolerance(KilogramForceCentimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilogramForceCentimeter), KilogramForceCentimetersTolerance);
            AssertEx.EqualTolerance(KilogramForceMetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilogramForceMeter), KilogramForceMetersTolerance);
            AssertEx.EqualTolerance(KilogramForceMillimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilogramForceMillimeter), KilogramForceMillimetersTolerance);
            AssertEx.EqualTolerance(KilonewtonCentimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilonewtonCentimeter), KilonewtonCentimetersTolerance);
            AssertEx.EqualTolerance(KilonewtonMetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilonewtonMeter), KilonewtonMetersTolerance);
            AssertEx.EqualTolerance(KilonewtonMillimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilonewtonMillimeter), KilonewtonMillimetersTolerance);
            AssertEx.EqualTolerance(KilopoundForceFeetInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilopoundForceFoot), KilopoundForceFeetTolerance);
            AssertEx.EqualTolerance(KilopoundForceInchesInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilopoundForceInch), KilopoundForceInchesTolerance);
            AssertEx.EqualTolerance(MeganewtonCentimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.MeganewtonCentimeter), MeganewtonCentimetersTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.MeganewtonMeter), MeganewtonMetersTolerance);
            AssertEx.EqualTolerance(MeganewtonMillimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.MeganewtonMillimeter), MeganewtonMillimetersTolerance);
            AssertEx.EqualTolerance(MegapoundForceFeetInOneNewtonMeter, newtonmeter.As(TorqueUnit.MegapoundForceFoot), MegapoundForceFeetTolerance);
            AssertEx.EqualTolerance(MegapoundForceInchesInOneNewtonMeter, newtonmeter.As(TorqueUnit.MegapoundForceInch), MegapoundForceInchesTolerance);
            AssertEx.EqualTolerance(NewtonCentimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.NewtonCentimeter), NewtonCentimetersTolerance);
            AssertEx.EqualTolerance(NewtonMetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.NewtonMeter), NewtonMetersTolerance);
            AssertEx.EqualTolerance(NewtonMillimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.NewtonMillimeter), NewtonMillimetersTolerance);
            AssertEx.EqualTolerance(PoundForceFeetInOneNewtonMeter, newtonmeter.As(TorqueUnit.PoundForceFoot), PoundForceFeetTolerance);
            AssertEx.EqualTolerance(PoundForceInchesInOneNewtonMeter, newtonmeter.As(TorqueUnit.PoundForceInch), PoundForceInchesTolerance);
            AssertEx.EqualTolerance(TonneForceCentimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.TonneForceCentimeter), TonneForceCentimetersTolerance);
            AssertEx.EqualTolerance(TonneForceMetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.TonneForceMeter), TonneForceMetersTolerance);
            AssertEx.EqualTolerance(TonneForceMillimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.TonneForceMillimeter), TonneForceMillimetersTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newtonmeter = Torque<double>.FromNewtonMeters(1);

            var kilogramforcecentimeterQuantity = newtonmeter.ToUnit(TorqueUnit.KilogramForceCentimeter);
            AssertEx.EqualTolerance(KilogramForceCentimetersInOneNewtonMeter, (double)kilogramforcecentimeterQuantity.Value, KilogramForceCentimetersTolerance);
            Assert.Equal(TorqueUnit.KilogramForceCentimeter, kilogramforcecentimeterQuantity.Unit);

            var kilogramforcemeterQuantity = newtonmeter.ToUnit(TorqueUnit.KilogramForceMeter);
            AssertEx.EqualTolerance(KilogramForceMetersInOneNewtonMeter, (double)kilogramforcemeterQuantity.Value, KilogramForceMetersTolerance);
            Assert.Equal(TorqueUnit.KilogramForceMeter, kilogramforcemeterQuantity.Unit);

            var kilogramforcemillimeterQuantity = newtonmeter.ToUnit(TorqueUnit.KilogramForceMillimeter);
            AssertEx.EqualTolerance(KilogramForceMillimetersInOneNewtonMeter, (double)kilogramforcemillimeterQuantity.Value, KilogramForceMillimetersTolerance);
            Assert.Equal(TorqueUnit.KilogramForceMillimeter, kilogramforcemillimeterQuantity.Unit);

            var kilonewtoncentimeterQuantity = newtonmeter.ToUnit(TorqueUnit.KilonewtonCentimeter);
            AssertEx.EqualTolerance(KilonewtonCentimetersInOneNewtonMeter, (double)kilonewtoncentimeterQuantity.Value, KilonewtonCentimetersTolerance);
            Assert.Equal(TorqueUnit.KilonewtonCentimeter, kilonewtoncentimeterQuantity.Unit);

            var kilonewtonmeterQuantity = newtonmeter.ToUnit(TorqueUnit.KilonewtonMeter);
            AssertEx.EqualTolerance(KilonewtonMetersInOneNewtonMeter, (double)kilonewtonmeterQuantity.Value, KilonewtonMetersTolerance);
            Assert.Equal(TorqueUnit.KilonewtonMeter, kilonewtonmeterQuantity.Unit);

            var kilonewtonmillimeterQuantity = newtonmeter.ToUnit(TorqueUnit.KilonewtonMillimeter);
            AssertEx.EqualTolerance(KilonewtonMillimetersInOneNewtonMeter, (double)kilonewtonmillimeterQuantity.Value, KilonewtonMillimetersTolerance);
            Assert.Equal(TorqueUnit.KilonewtonMillimeter, kilonewtonmillimeterQuantity.Unit);

            var kilopoundforcefootQuantity = newtonmeter.ToUnit(TorqueUnit.KilopoundForceFoot);
            AssertEx.EqualTolerance(KilopoundForceFeetInOneNewtonMeter, (double)kilopoundforcefootQuantity.Value, KilopoundForceFeetTolerance);
            Assert.Equal(TorqueUnit.KilopoundForceFoot, kilopoundforcefootQuantity.Unit);

            var kilopoundforceinchQuantity = newtonmeter.ToUnit(TorqueUnit.KilopoundForceInch);
            AssertEx.EqualTolerance(KilopoundForceInchesInOneNewtonMeter, (double)kilopoundforceinchQuantity.Value, KilopoundForceInchesTolerance);
            Assert.Equal(TorqueUnit.KilopoundForceInch, kilopoundforceinchQuantity.Unit);

            var meganewtoncentimeterQuantity = newtonmeter.ToUnit(TorqueUnit.MeganewtonCentimeter);
            AssertEx.EqualTolerance(MeganewtonCentimetersInOneNewtonMeter, (double)meganewtoncentimeterQuantity.Value, MeganewtonCentimetersTolerance);
            Assert.Equal(TorqueUnit.MeganewtonCentimeter, meganewtoncentimeterQuantity.Unit);

            var meganewtonmeterQuantity = newtonmeter.ToUnit(TorqueUnit.MeganewtonMeter);
            AssertEx.EqualTolerance(MeganewtonMetersInOneNewtonMeter, (double)meganewtonmeterQuantity.Value, MeganewtonMetersTolerance);
            Assert.Equal(TorqueUnit.MeganewtonMeter, meganewtonmeterQuantity.Unit);

            var meganewtonmillimeterQuantity = newtonmeter.ToUnit(TorqueUnit.MeganewtonMillimeter);
            AssertEx.EqualTolerance(MeganewtonMillimetersInOneNewtonMeter, (double)meganewtonmillimeterQuantity.Value, MeganewtonMillimetersTolerance);
            Assert.Equal(TorqueUnit.MeganewtonMillimeter, meganewtonmillimeterQuantity.Unit);

            var megapoundforcefootQuantity = newtonmeter.ToUnit(TorqueUnit.MegapoundForceFoot);
            AssertEx.EqualTolerance(MegapoundForceFeetInOneNewtonMeter, (double)megapoundforcefootQuantity.Value, MegapoundForceFeetTolerance);
            Assert.Equal(TorqueUnit.MegapoundForceFoot, megapoundforcefootQuantity.Unit);

            var megapoundforceinchQuantity = newtonmeter.ToUnit(TorqueUnit.MegapoundForceInch);
            AssertEx.EqualTolerance(MegapoundForceInchesInOneNewtonMeter, (double)megapoundforceinchQuantity.Value, MegapoundForceInchesTolerance);
            Assert.Equal(TorqueUnit.MegapoundForceInch, megapoundforceinchQuantity.Unit);

            var newtoncentimeterQuantity = newtonmeter.ToUnit(TorqueUnit.NewtonCentimeter);
            AssertEx.EqualTolerance(NewtonCentimetersInOneNewtonMeter, (double)newtoncentimeterQuantity.Value, NewtonCentimetersTolerance);
            Assert.Equal(TorqueUnit.NewtonCentimeter, newtoncentimeterQuantity.Unit);

            var newtonmeterQuantity = newtonmeter.ToUnit(TorqueUnit.NewtonMeter);
            AssertEx.EqualTolerance(NewtonMetersInOneNewtonMeter, (double)newtonmeterQuantity.Value, NewtonMetersTolerance);
            Assert.Equal(TorqueUnit.NewtonMeter, newtonmeterQuantity.Unit);

            var newtonmillimeterQuantity = newtonmeter.ToUnit(TorqueUnit.NewtonMillimeter);
            AssertEx.EqualTolerance(NewtonMillimetersInOneNewtonMeter, (double)newtonmillimeterQuantity.Value, NewtonMillimetersTolerance);
            Assert.Equal(TorqueUnit.NewtonMillimeter, newtonmillimeterQuantity.Unit);

            var poundforcefootQuantity = newtonmeter.ToUnit(TorqueUnit.PoundForceFoot);
            AssertEx.EqualTolerance(PoundForceFeetInOneNewtonMeter, (double)poundforcefootQuantity.Value, PoundForceFeetTolerance);
            Assert.Equal(TorqueUnit.PoundForceFoot, poundforcefootQuantity.Unit);

            var poundforceinchQuantity = newtonmeter.ToUnit(TorqueUnit.PoundForceInch);
            AssertEx.EqualTolerance(PoundForceInchesInOneNewtonMeter, (double)poundforceinchQuantity.Value, PoundForceInchesTolerance);
            Assert.Equal(TorqueUnit.PoundForceInch, poundforceinchQuantity.Unit);

            var tonneforcecentimeterQuantity = newtonmeter.ToUnit(TorqueUnit.TonneForceCentimeter);
            AssertEx.EqualTolerance(TonneForceCentimetersInOneNewtonMeter, (double)tonneforcecentimeterQuantity.Value, TonneForceCentimetersTolerance);
            Assert.Equal(TorqueUnit.TonneForceCentimeter, tonneforcecentimeterQuantity.Unit);

            var tonneforcemeterQuantity = newtonmeter.ToUnit(TorqueUnit.TonneForceMeter);
            AssertEx.EqualTolerance(TonneForceMetersInOneNewtonMeter, (double)tonneforcemeterQuantity.Value, TonneForceMetersTolerance);
            Assert.Equal(TorqueUnit.TonneForceMeter, tonneforcemeterQuantity.Unit);

            var tonneforcemillimeterQuantity = newtonmeter.ToUnit(TorqueUnit.TonneForceMillimeter);
            AssertEx.EqualTolerance(TonneForceMillimetersInOneNewtonMeter, (double)tonneforcemillimeterQuantity.Value, TonneForceMillimetersTolerance);
            Assert.Equal(TorqueUnit.TonneForceMillimeter, tonneforcemillimeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Torque<double> newtonmeter = Torque<double>.FromNewtonMeters(1);
            AssertEx.EqualTolerance(1, Torque<double>.FromKilogramForceCentimeters(newtonmeter.KilogramForceCentimeters).NewtonMeters, KilogramForceCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromKilogramForceMeters(newtonmeter.KilogramForceMeters).NewtonMeters, KilogramForceMetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromKilogramForceMillimeters(newtonmeter.KilogramForceMillimeters).NewtonMeters, KilogramForceMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromKilonewtonCentimeters(newtonmeter.KilonewtonCentimeters).NewtonMeters, KilonewtonCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromKilonewtonMeters(newtonmeter.KilonewtonMeters).NewtonMeters, KilonewtonMetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromKilonewtonMillimeters(newtonmeter.KilonewtonMillimeters).NewtonMeters, KilonewtonMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromKilopoundForceFeet(newtonmeter.KilopoundForceFeet).NewtonMeters, KilopoundForceFeetTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromKilopoundForceInches(newtonmeter.KilopoundForceInches).NewtonMeters, KilopoundForceInchesTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromMeganewtonCentimeters(newtonmeter.MeganewtonCentimeters).NewtonMeters, MeganewtonCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromMeganewtonMeters(newtonmeter.MeganewtonMeters).NewtonMeters, MeganewtonMetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromMeganewtonMillimeters(newtonmeter.MeganewtonMillimeters).NewtonMeters, MeganewtonMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromMegapoundForceFeet(newtonmeter.MegapoundForceFeet).NewtonMeters, MegapoundForceFeetTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromMegapoundForceInches(newtonmeter.MegapoundForceInches).NewtonMeters, MegapoundForceInchesTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromNewtonCentimeters(newtonmeter.NewtonCentimeters).NewtonMeters, NewtonCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromNewtonMeters(newtonmeter.NewtonMeters).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromNewtonMillimeters(newtonmeter.NewtonMillimeters).NewtonMeters, NewtonMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromPoundForceFeet(newtonmeter.PoundForceFeet).NewtonMeters, PoundForceFeetTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromPoundForceInches(newtonmeter.PoundForceInches).NewtonMeters, PoundForceInchesTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromTonneForceCentimeters(newtonmeter.TonneForceCentimeters).NewtonMeters, TonneForceCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromTonneForceMeters(newtonmeter.TonneForceMeters).NewtonMeters, TonneForceMetersTolerance);
            AssertEx.EqualTolerance(1, Torque<double>.FromTonneForceMillimeters(newtonmeter.TonneForceMillimeters).NewtonMeters, TonneForceMillimetersTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Torque<double> v = Torque<double>.FromNewtonMeters(1);
            AssertEx.EqualTolerance(-1, -v.NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(2, (Torque<double>.FromNewtonMeters(3)-v).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(2, (Torque<double>.FromNewtonMeters(10)/5).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(2, Torque<double>.FromNewtonMeters(10)/Torque<double>.FromNewtonMeters(5), NewtonMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Torque<double> oneNewtonMeter = Torque<double>.FromNewtonMeters(1);
            Torque<double> twoNewtonMeters = Torque<double>.FromNewtonMeters(2);

            Assert.True(oneNewtonMeter < twoNewtonMeters);
            Assert.True(oneNewtonMeter <= twoNewtonMeters);
            Assert.True(twoNewtonMeters > oneNewtonMeter);
            Assert.True(twoNewtonMeters >= oneNewtonMeter);

            Assert.False(oneNewtonMeter > twoNewtonMeters);
            Assert.False(oneNewtonMeter >= twoNewtonMeters);
            Assert.False(twoNewtonMeters < oneNewtonMeter);
            Assert.False(twoNewtonMeters <= oneNewtonMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Torque<double> newtonmeter = Torque<double>.FromNewtonMeters(1);
            Assert.Equal(0, newtonmeter.CompareTo(newtonmeter));
            Assert.True(newtonmeter.CompareTo(Torque<double>.Zero) > 0);
            Assert.True(Torque<double>.Zero.CompareTo(newtonmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Torque<double> newtonmeter = Torque<double>.FromNewtonMeters(1);
            Assert.Throws<ArgumentException>(() => newtonmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Torque<double> newtonmeter = Torque<double>.FromNewtonMeters(1);
            Assert.Throws<ArgumentNullException>(() => newtonmeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Torque<double>.FromNewtonMeters(1);
            var b = Torque<double>.FromNewtonMeters(2);

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
            var a = Torque<double>.FromNewtonMeters(1);
            var b = Torque<double>.FromNewtonMeters(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = Torque<double>.FromNewtonMeters(1);
            Assert.True(v.Equals(Torque<double>.FromNewtonMeters(1), NewtonMetersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Torque<double>.Zero, NewtonMetersTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Torque<double> newtonmeter = Torque<double>.FromNewtonMeters(1);
            Assert.False(newtonmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Torque<double> newtonmeter = Torque<double>.FromNewtonMeters(1);
            Assert.False(newtonmeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(TorqueUnit.Undefined, Torque<double>.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(TorqueUnit)).Cast<TorqueUnit>();
            foreach(var unit in units)
            {
                if(unit == TorqueUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Torque<double>.BaseDimensions is null);
        }
    }
}

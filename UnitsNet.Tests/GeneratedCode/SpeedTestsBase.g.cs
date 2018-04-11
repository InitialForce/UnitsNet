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
    /// Test of Speed.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpeedTestsBase
    {
        protected abstract double CentimetersPerHourInOneMeterPerSecond { get; }
        protected abstract double CentimetersPerMinutesInOneMeterPerSecond { get; }
        protected abstract double CentimetersPerSecondInOneMeterPerSecond { get; }
        protected abstract double DecimetersPerMinutesInOneMeterPerSecond { get; }
        protected abstract double DecimetersPerSecondInOneMeterPerSecond { get; }
        protected abstract double FeetPerHourInOneMeterPerSecond { get; }
        protected abstract double FeetPerMinuteInOneMeterPerSecond { get; }
        protected abstract double FeetPerSecondInOneMeterPerSecond { get; }
        protected abstract double InchesPerHourInOneMeterPerSecond { get; }
        protected abstract double InchesPerMinuteInOneMeterPerSecond { get; }
        protected abstract double InchesPerSecondInOneMeterPerSecond { get; }
        protected abstract double KilometersPerHourInOneMeterPerSecond { get; }
        protected abstract double KilometersPerMinutesInOneMeterPerSecond { get; }
        protected abstract double KilometersPerSecondInOneMeterPerSecond { get; }
        protected abstract double KnotsInOneMeterPerSecond { get; }
        protected abstract double MetersPerHourInOneMeterPerSecond { get; }
        protected abstract double MetersPerMinutesInOneMeterPerSecond { get; }
        protected abstract double MetersPerSecondInOneMeterPerSecond { get; }
        protected abstract double MicrometersPerMinutesInOneMeterPerSecond { get; }
        protected abstract double MicrometersPerSecondInOneMeterPerSecond { get; }
        protected abstract double MilesPerHourInOneMeterPerSecond { get; }
        protected abstract double MillimetersPerHourInOneMeterPerSecond { get; }
        protected abstract double MillimetersPerMinutesInOneMeterPerSecond { get; }
        protected abstract double MillimetersPerSecondInOneMeterPerSecond { get; }
        protected abstract double NanometersPerMinutesInOneMeterPerSecond { get; }
        protected abstract double NanometersPerSecondInOneMeterPerSecond { get; }
        protected abstract double UsSurveyFeetPerHourInOneMeterPerSecond { get; }
        protected abstract double UsSurveyFeetPerMinuteInOneMeterPerSecond { get; }
        protected abstract double UsSurveyFeetPerSecondInOneMeterPerSecond { get; }
        protected abstract double YardsPerHourInOneMeterPerSecond { get; }
        protected abstract double YardsPerMinuteInOneMeterPerSecond { get; }
        protected abstract double YardsPerSecondInOneMeterPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimetersPerHourTolerance { get { return 1e-5; } }
        protected virtual double CentimetersPerMinutesTolerance { get { return 1e-5; } }
        protected virtual double CentimetersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecimetersPerMinutesTolerance { get { return 1e-5; } }
        protected virtual double DecimetersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double FeetPerHourTolerance { get { return 1e-5; } }
        protected virtual double FeetPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double FeetPerSecondTolerance { get { return 1e-5; } }
        protected virtual double InchesPerHourTolerance { get { return 1e-5; } }
        protected virtual double InchesPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double InchesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KilometersPerHourTolerance { get { return 1e-5; } }
        protected virtual double KilometersPerMinutesTolerance { get { return 1e-5; } }
        protected virtual double KilometersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KnotsTolerance { get { return 1e-5; } }
        protected virtual double MetersPerHourTolerance { get { return 1e-5; } }
        protected virtual double MetersPerMinutesTolerance { get { return 1e-5; } }
        protected virtual double MetersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicrometersPerMinutesTolerance { get { return 1e-5; } }
        protected virtual double MicrometersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MilesPerHourTolerance { get { return 1e-5; } }
        protected virtual double MillimetersPerHourTolerance { get { return 1e-5; } }
        protected virtual double MillimetersPerMinutesTolerance { get { return 1e-5; } }
        protected virtual double MillimetersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanometersPerMinutesTolerance { get { return 1e-5; } }
        protected virtual double NanometersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double UsSurveyFeetPerHourTolerance { get { return 1e-5; } }
        protected virtual double UsSurveyFeetPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double UsSurveyFeetPerSecondTolerance { get { return 1e-5; } }
        protected virtual double YardsPerHourTolerance { get { return 1e-5; } }
        protected virtual double YardsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double YardsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void MeterPerSecondToSpeedUnits()
        {
            Speed meterpersecond = Speed.FromMetersPerSecond(1);
            AssertEx.EqualTolerance(CentimetersPerHourInOneMeterPerSecond, meterpersecond.CentimetersPerHour, CentimetersPerHourTolerance);
            AssertEx.EqualTolerance(CentimetersPerMinutesInOneMeterPerSecond, meterpersecond.CentimetersPerMinutes, CentimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(CentimetersPerSecondInOneMeterPerSecond, meterpersecond.CentimetersPerSecond, CentimetersPerSecondTolerance);
            AssertEx.EqualTolerance(DecimetersPerMinutesInOneMeterPerSecond, meterpersecond.DecimetersPerMinutes, DecimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(DecimetersPerSecondInOneMeterPerSecond, meterpersecond.DecimetersPerSecond, DecimetersPerSecondTolerance);
            AssertEx.EqualTolerance(FeetPerHourInOneMeterPerSecond, meterpersecond.FeetPerHour, FeetPerHourTolerance);
            AssertEx.EqualTolerance(FeetPerMinuteInOneMeterPerSecond, meterpersecond.FeetPerMinute, FeetPerMinuteTolerance);
            AssertEx.EqualTolerance(FeetPerSecondInOneMeterPerSecond, meterpersecond.FeetPerSecond, FeetPerSecondTolerance);
            AssertEx.EqualTolerance(InchesPerHourInOneMeterPerSecond, meterpersecond.InchesPerHour, InchesPerHourTolerance);
            AssertEx.EqualTolerance(InchesPerMinuteInOneMeterPerSecond, meterpersecond.InchesPerMinute, InchesPerMinuteTolerance);
            AssertEx.EqualTolerance(InchesPerSecondInOneMeterPerSecond, meterpersecond.InchesPerSecond, InchesPerSecondTolerance);
            AssertEx.EqualTolerance(KilometersPerHourInOneMeterPerSecond, meterpersecond.KilometersPerHour, KilometersPerHourTolerance);
            AssertEx.EqualTolerance(KilometersPerMinutesInOneMeterPerSecond, meterpersecond.KilometersPerMinutes, KilometersPerMinutesTolerance);
            AssertEx.EqualTolerance(KilometersPerSecondInOneMeterPerSecond, meterpersecond.KilometersPerSecond, KilometersPerSecondTolerance);
            AssertEx.EqualTolerance(KnotsInOneMeterPerSecond, meterpersecond.Knots, KnotsTolerance);
            AssertEx.EqualTolerance(MetersPerHourInOneMeterPerSecond, meterpersecond.MetersPerHour, MetersPerHourTolerance);
            AssertEx.EqualTolerance(MetersPerMinutesInOneMeterPerSecond, meterpersecond.MetersPerMinutes, MetersPerMinutesTolerance);
            AssertEx.EqualTolerance(MetersPerSecondInOneMeterPerSecond, meterpersecond.MetersPerSecond, MetersPerSecondTolerance);
            AssertEx.EqualTolerance(MicrometersPerMinutesInOneMeterPerSecond, meterpersecond.MicrometersPerMinutes, MicrometersPerMinutesTolerance);
            AssertEx.EqualTolerance(MicrometersPerSecondInOneMeterPerSecond, meterpersecond.MicrometersPerSecond, MicrometersPerSecondTolerance);
            AssertEx.EqualTolerance(MilesPerHourInOneMeterPerSecond, meterpersecond.MilesPerHour, MilesPerHourTolerance);
            AssertEx.EqualTolerance(MillimetersPerHourInOneMeterPerSecond, meterpersecond.MillimetersPerHour, MillimetersPerHourTolerance);
            AssertEx.EqualTolerance(MillimetersPerMinutesInOneMeterPerSecond, meterpersecond.MillimetersPerMinutes, MillimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(MillimetersPerSecondInOneMeterPerSecond, meterpersecond.MillimetersPerSecond, MillimetersPerSecondTolerance);
            AssertEx.EqualTolerance(NanometersPerMinutesInOneMeterPerSecond, meterpersecond.NanometersPerMinutes, NanometersPerMinutesTolerance);
            AssertEx.EqualTolerance(NanometersPerSecondInOneMeterPerSecond, meterpersecond.NanometersPerSecond, NanometersPerSecondTolerance);
            AssertEx.EqualTolerance(UsSurveyFeetPerHourInOneMeterPerSecond, meterpersecond.UsSurveyFeetPerHour, UsSurveyFeetPerHourTolerance);
            AssertEx.EqualTolerance(UsSurveyFeetPerMinuteInOneMeterPerSecond, meterpersecond.UsSurveyFeetPerMinute, UsSurveyFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(UsSurveyFeetPerSecondInOneMeterPerSecond, meterpersecond.UsSurveyFeetPerSecond, UsSurveyFeetPerSecondTolerance);
            AssertEx.EqualTolerance(YardsPerHourInOneMeterPerSecond, meterpersecond.YardsPerHour, YardsPerHourTolerance);
            AssertEx.EqualTolerance(YardsPerMinuteInOneMeterPerSecond, meterpersecond.YardsPerMinute, YardsPerMinuteTolerance);
            AssertEx.EqualTolerance(YardsPerSecondInOneMeterPerSecond, meterpersecond.YardsPerSecond, YardsPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.CentimeterPerHour).CentimetersPerHour, CentimetersPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.CentimeterPerMinute).CentimetersPerMinutes, CentimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.CentimeterPerSecond).CentimetersPerSecond, CentimetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.DecimeterPerMinute).DecimetersPerMinutes, DecimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.DecimeterPerSecond).DecimetersPerSecond, DecimetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.FootPerHour).FeetPerHour, FeetPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.FootPerMinute).FeetPerMinute, FeetPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.FootPerSecond).FeetPerSecond, FeetPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.InchPerHour).InchesPerHour, InchesPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.InchPerMinute).InchesPerMinute, InchesPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.InchPerSecond).InchesPerSecond, InchesPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.KilometerPerHour).KilometersPerHour, KilometersPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.KilometerPerMinute).KilometersPerMinutes, KilometersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.KilometerPerSecond).KilometersPerSecond, KilometersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.Knot).Knots, KnotsTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.MeterPerHour).MetersPerHour, MetersPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.MeterPerMinute).MetersPerMinutes, MetersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.MeterPerSecond).MetersPerSecond, MetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.MicrometerPerMinute).MicrometersPerMinutes, MicrometersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.MicrometerPerSecond).MicrometersPerSecond, MicrometersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.MilePerHour).MilesPerHour, MilesPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.MillimeterPerHour).MillimetersPerHour, MillimetersPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.MillimeterPerMinute).MillimetersPerMinutes, MillimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.MillimeterPerSecond).MillimetersPerSecond, MillimetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.NanometerPerMinute).NanometersPerMinutes, NanometersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.NanometerPerSecond).NanometersPerSecond, NanometersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.UsSurveyFootPerHour).UsSurveyFeetPerHour, UsSurveyFeetPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.UsSurveyFootPerMinute).UsSurveyFeetPerMinute, UsSurveyFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.UsSurveyFootPerSecond).UsSurveyFeetPerSecond, UsSurveyFeetPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.YardPerHour).YardsPerHour, YardsPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.YardPerMinute).YardsPerMinute, YardsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Speed.From(1, SpeedUnit.YardPerSecond).YardsPerSecond, YardsPerSecondTolerance);
        }

        [Fact]
        public void As()
        {
            var meterpersecond = Speed.FromMetersPerSecond(1);
            AssertEx.EqualTolerance(CentimetersPerHourInOneMeterPerSecond, meterpersecond.As(SpeedUnit.CentimeterPerHour), CentimetersPerHourTolerance);
            AssertEx.EqualTolerance(CentimetersPerMinutesInOneMeterPerSecond, meterpersecond.As(SpeedUnit.CentimeterPerMinute), CentimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(CentimetersPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.CentimeterPerSecond), CentimetersPerSecondTolerance);
            AssertEx.EqualTolerance(DecimetersPerMinutesInOneMeterPerSecond, meterpersecond.As(SpeedUnit.DecimeterPerMinute), DecimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(DecimetersPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.DecimeterPerSecond), DecimetersPerSecondTolerance);
            AssertEx.EqualTolerance(FeetPerHourInOneMeterPerSecond, meterpersecond.As(SpeedUnit.FootPerHour), FeetPerHourTolerance);
            AssertEx.EqualTolerance(FeetPerMinuteInOneMeterPerSecond, meterpersecond.As(SpeedUnit.FootPerMinute), FeetPerMinuteTolerance);
            AssertEx.EqualTolerance(FeetPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.FootPerSecond), FeetPerSecondTolerance);
            AssertEx.EqualTolerance(InchesPerHourInOneMeterPerSecond, meterpersecond.As(SpeedUnit.InchPerHour), InchesPerHourTolerance);
            AssertEx.EqualTolerance(InchesPerMinuteInOneMeterPerSecond, meterpersecond.As(SpeedUnit.InchPerMinute), InchesPerMinuteTolerance);
            AssertEx.EqualTolerance(InchesPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.InchPerSecond), InchesPerSecondTolerance);
            AssertEx.EqualTolerance(KilometersPerHourInOneMeterPerSecond, meterpersecond.As(SpeedUnit.KilometerPerHour), KilometersPerHourTolerance);
            AssertEx.EqualTolerance(KilometersPerMinutesInOneMeterPerSecond, meterpersecond.As(SpeedUnit.KilometerPerMinute), KilometersPerMinutesTolerance);
            AssertEx.EqualTolerance(KilometersPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.KilometerPerSecond), KilometersPerSecondTolerance);
            AssertEx.EqualTolerance(KnotsInOneMeterPerSecond, meterpersecond.As(SpeedUnit.Knot), KnotsTolerance);
            AssertEx.EqualTolerance(MetersPerHourInOneMeterPerSecond, meterpersecond.As(SpeedUnit.MeterPerHour), MetersPerHourTolerance);
            AssertEx.EqualTolerance(MetersPerMinutesInOneMeterPerSecond, meterpersecond.As(SpeedUnit.MeterPerMinute), MetersPerMinutesTolerance);
            AssertEx.EqualTolerance(MetersPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.MeterPerSecond), MetersPerSecondTolerance);
            AssertEx.EqualTolerance(MicrometersPerMinutesInOneMeterPerSecond, meterpersecond.As(SpeedUnit.MicrometerPerMinute), MicrometersPerMinutesTolerance);
            AssertEx.EqualTolerance(MicrometersPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.MicrometerPerSecond), MicrometersPerSecondTolerance);
            AssertEx.EqualTolerance(MilesPerHourInOneMeterPerSecond, meterpersecond.As(SpeedUnit.MilePerHour), MilesPerHourTolerance);
            AssertEx.EqualTolerance(MillimetersPerHourInOneMeterPerSecond, meterpersecond.As(SpeedUnit.MillimeterPerHour), MillimetersPerHourTolerance);
            AssertEx.EqualTolerance(MillimetersPerMinutesInOneMeterPerSecond, meterpersecond.As(SpeedUnit.MillimeterPerMinute), MillimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(MillimetersPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.MillimeterPerSecond), MillimetersPerSecondTolerance);
            AssertEx.EqualTolerance(NanometersPerMinutesInOneMeterPerSecond, meterpersecond.As(SpeedUnit.NanometerPerMinute), NanometersPerMinutesTolerance);
            AssertEx.EqualTolerance(NanometersPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.NanometerPerSecond), NanometersPerSecondTolerance);
            AssertEx.EqualTolerance(UsSurveyFeetPerHourInOneMeterPerSecond, meterpersecond.As(SpeedUnit.UsSurveyFootPerHour), UsSurveyFeetPerHourTolerance);
            AssertEx.EqualTolerance(UsSurveyFeetPerMinuteInOneMeterPerSecond, meterpersecond.As(SpeedUnit.UsSurveyFootPerMinute), UsSurveyFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(UsSurveyFeetPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.UsSurveyFootPerSecond), UsSurveyFeetPerSecondTolerance);
            AssertEx.EqualTolerance(YardsPerHourInOneMeterPerSecond, meterpersecond.As(SpeedUnit.YardPerHour), YardsPerHourTolerance);
            AssertEx.EqualTolerance(YardsPerMinuteInOneMeterPerSecond, meterpersecond.As(SpeedUnit.YardPerMinute), YardsPerMinuteTolerance);
            AssertEx.EqualTolerance(YardsPerSecondInOneMeterPerSecond, meterpersecond.As(SpeedUnit.YardPerSecond), YardsPerSecondTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Speed meterpersecond = Speed.FromMetersPerSecond(1);
            AssertEx.EqualTolerance(1, Speed.FromCentimetersPerHour(meterpersecond.CentimetersPerHour).MetersPerSecond, CentimetersPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.FromCentimetersPerMinutes(meterpersecond.CentimetersPerMinutes).MetersPerSecond, CentimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.FromCentimetersPerSecond(meterpersecond.CentimetersPerSecond).MetersPerSecond, CentimetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.FromDecimetersPerMinutes(meterpersecond.DecimetersPerMinutes).MetersPerSecond, DecimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.FromDecimetersPerSecond(meterpersecond.DecimetersPerSecond).MetersPerSecond, DecimetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.FromFeetPerHour(meterpersecond.FeetPerHour).MetersPerSecond, FeetPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.FromFeetPerMinute(meterpersecond.FeetPerMinute).MetersPerSecond, FeetPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Speed.FromFeetPerSecond(meterpersecond.FeetPerSecond).MetersPerSecond, FeetPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.FromInchesPerHour(meterpersecond.InchesPerHour).MetersPerSecond, InchesPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.FromInchesPerMinute(meterpersecond.InchesPerMinute).MetersPerSecond, InchesPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Speed.FromInchesPerSecond(meterpersecond.InchesPerSecond).MetersPerSecond, InchesPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.FromKilometersPerHour(meterpersecond.KilometersPerHour).MetersPerSecond, KilometersPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.FromKilometersPerMinutes(meterpersecond.KilometersPerMinutes).MetersPerSecond, KilometersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.FromKilometersPerSecond(meterpersecond.KilometersPerSecond).MetersPerSecond, KilometersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.FromKnots(meterpersecond.Knots).MetersPerSecond, KnotsTolerance);
            AssertEx.EqualTolerance(1, Speed.FromMetersPerHour(meterpersecond.MetersPerHour).MetersPerSecond, MetersPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.FromMetersPerMinutes(meterpersecond.MetersPerMinutes).MetersPerSecond, MetersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.FromMetersPerSecond(meterpersecond.MetersPerSecond).MetersPerSecond, MetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.FromMicrometersPerMinutes(meterpersecond.MicrometersPerMinutes).MetersPerSecond, MicrometersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.FromMicrometersPerSecond(meterpersecond.MicrometersPerSecond).MetersPerSecond, MicrometersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.FromMilesPerHour(meterpersecond.MilesPerHour).MetersPerSecond, MilesPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.FromMillimetersPerHour(meterpersecond.MillimetersPerHour).MetersPerSecond, MillimetersPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.FromMillimetersPerMinutes(meterpersecond.MillimetersPerMinutes).MetersPerSecond, MillimetersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.FromMillimetersPerSecond(meterpersecond.MillimetersPerSecond).MetersPerSecond, MillimetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.FromNanometersPerMinutes(meterpersecond.NanometersPerMinutes).MetersPerSecond, NanometersPerMinutesTolerance);
            AssertEx.EqualTolerance(1, Speed.FromNanometersPerSecond(meterpersecond.NanometersPerSecond).MetersPerSecond, NanometersPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.FromUsSurveyFeetPerHour(meterpersecond.UsSurveyFeetPerHour).MetersPerSecond, UsSurveyFeetPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.FromUsSurveyFeetPerMinute(meterpersecond.UsSurveyFeetPerMinute).MetersPerSecond, UsSurveyFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Speed.FromUsSurveyFeetPerSecond(meterpersecond.UsSurveyFeetPerSecond).MetersPerSecond, UsSurveyFeetPerSecondTolerance);
            AssertEx.EqualTolerance(1, Speed.FromYardsPerHour(meterpersecond.YardsPerHour).MetersPerSecond, YardsPerHourTolerance);
            AssertEx.EqualTolerance(1, Speed.FromYardsPerMinute(meterpersecond.YardsPerMinute).MetersPerSecond, YardsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, Speed.FromYardsPerSecond(meterpersecond.YardsPerSecond).MetersPerSecond, YardsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Speed v = Speed.FromMetersPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.MetersPerSecond, MetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (Speed.FromMetersPerSecond(3)-v).MetersPerSecond, MetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).MetersPerSecond, MetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).MetersPerSecond, MetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).MetersPerSecond, MetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (Speed.FromMetersPerSecond(10)/5).MetersPerSecond, MetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, Speed.FromMetersPerSecond(10)/Speed.FromMetersPerSecond(5), MetersPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Speed oneMeterPerSecond = Speed.FromMetersPerSecond(1);
            Speed twoMetersPerSecond = Speed.FromMetersPerSecond(2);

            Assert.True(oneMeterPerSecond < twoMetersPerSecond);
            Assert.True(oneMeterPerSecond <= twoMetersPerSecond);
            Assert.True(twoMetersPerSecond > oneMeterPerSecond);
            Assert.True(twoMetersPerSecond >= oneMeterPerSecond);

            Assert.False(oneMeterPerSecond > twoMetersPerSecond);
            Assert.False(oneMeterPerSecond >= twoMetersPerSecond);
            Assert.False(twoMetersPerSecond < oneMeterPerSecond);
            Assert.False(twoMetersPerSecond <= oneMeterPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Speed meterpersecond = Speed.FromMetersPerSecond(1);
            Assert.Equal(0, meterpersecond.CompareTo(meterpersecond));
            Assert.True(meterpersecond.CompareTo(Speed.Zero) > 0);
            Assert.True(Speed.Zero.CompareTo(meterpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Speed meterpersecond = Speed.FromMetersPerSecond(1);
            Assert.Throws<ArgumentException>(() => meterpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Speed meterpersecond = Speed.FromMetersPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => meterpersecond.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Speed a = Speed.FromMetersPerSecond(1);
            Speed b = Speed.FromMetersPerSecond(2);

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
            Speed v = Speed.FromMetersPerSecond(1);
            Assert.True(v.Equals(Speed.FromMetersPerSecond(1), Speed.FromMetersPerSecond(MetersPerSecondTolerance)));
            Assert.False(v.Equals(Speed.Zero, Speed.FromMetersPerSecond(MetersPerSecondTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Speed meterpersecond = Speed.FromMetersPerSecond(1);
            Assert.False(meterpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Speed meterpersecond = Speed.FromMetersPerSecond(1);
            Assert.False(meterpersecond.Equals(null));
        }
    }
}

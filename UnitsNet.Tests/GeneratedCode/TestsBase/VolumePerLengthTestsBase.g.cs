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
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of VolumePerLength.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class VolumePerLengthTestsBase
    {
        protected abstract double CubicMetersPerMeterInOneCubicMeterPerMeter { get; }
        protected abstract double CubicYardsPerFootInOneCubicMeterPerMeter { get; }
        protected abstract double CubicYardsPerUsSurveyFootInOneCubicMeterPerMeter { get; }
        protected abstract double LitersPerKilometerInOneCubicMeterPerMeter { get; }
        protected abstract double LitersPerMeterInOneCubicMeterPerMeter { get; }
        protected abstract double LitersPerMillimeterInOneCubicMeterPerMeter { get; }
        protected abstract double OilBarrelsPerFootInOneCubicMeterPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CubicMetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double CubicYardsPerFootTolerance { get { return 1e-5; } }
        protected virtual double CubicYardsPerUsSurveyFootTolerance { get { return 1e-5; } }
        protected virtual double LitersPerKilometerTolerance { get { return 1e-5; } }
        protected virtual double LitersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double LitersPerMillimeterTolerance { get { return 1e-5; } }
        protected virtual double OilBarrelsPerFootTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumePerLength((double)0.0, VolumePerLengthUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new VolumePerLength();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(VolumePerLengthUnit.CubicMeterPerMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumePerLength(double.PositiveInfinity, VolumePerLengthUnit.CubicMeterPerMeter));
            Assert.Throws<ArgumentException>(() => new VolumePerLength(double.NegativeInfinity, VolumePerLengthUnit.CubicMeterPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumePerLength(double.NaN, VolumePerLengthUnit.CubicMeterPerMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new VolumePerLength(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void VolumePerLength_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new VolumePerLength(1, VolumePerLengthUnit.CubicMeterPerMeter);

            QuantityInfo<VolumePerLengthUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(VolumePerLength.Zero, quantityInfo.Zero);
            Assert.Equal("VolumePerLength", quantityInfo.Name);
            Assert.Equal(QuantityType.VolumePerLength, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<VolumePerLengthUnit>().Except(new[] {VolumePerLengthUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void CubicMeterPerMeterToVolumePerLengthUnits()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            AssertEx.EqualTolerance(CubicMetersPerMeterInOneCubicMeterPerMeter, cubicmeterpermeter.CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(CubicYardsPerFootInOneCubicMeterPerMeter, cubicmeterpermeter.CubicYardsPerFoot, CubicYardsPerFootTolerance);
            AssertEx.EqualTolerance(CubicYardsPerUsSurveyFootInOneCubicMeterPerMeter, cubicmeterpermeter.CubicYardsPerUsSurveyFoot, CubicYardsPerUsSurveyFootTolerance);
            AssertEx.EqualTolerance(LitersPerKilometerInOneCubicMeterPerMeter, cubicmeterpermeter.LitersPerKilometer, LitersPerKilometerTolerance);
            AssertEx.EqualTolerance(LitersPerMeterInOneCubicMeterPerMeter, cubicmeterpermeter.LitersPerMeter, LitersPerMeterTolerance);
            AssertEx.EqualTolerance(LitersPerMillimeterInOneCubicMeterPerMeter, cubicmeterpermeter.LitersPerMillimeter, LitersPerMillimeterTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerFootInOneCubicMeterPerMeter, cubicmeterpermeter.OilBarrelsPerFoot, OilBarrelsPerFootTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = VolumePerLength.From(1, VolumePerLengthUnit.CubicMeterPerMeter);
            AssertEx.EqualTolerance(1, quantity00.CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            Assert.Equal(VolumePerLengthUnit.CubicMeterPerMeter, quantity00.Unit);

            var quantity01 = VolumePerLength.From(1, VolumePerLengthUnit.CubicYardPerFoot);
            AssertEx.EqualTolerance(1, quantity01.CubicYardsPerFoot, CubicYardsPerFootTolerance);
            Assert.Equal(VolumePerLengthUnit.CubicYardPerFoot, quantity01.Unit);

            var quantity02 = VolumePerLength.From(1, VolumePerLengthUnit.CubicYardPerUsSurveyFoot);
            AssertEx.EqualTolerance(1, quantity02.CubicYardsPerUsSurveyFoot, CubicYardsPerUsSurveyFootTolerance);
            Assert.Equal(VolumePerLengthUnit.CubicYardPerUsSurveyFoot, quantity02.Unit);

            var quantity03 = VolumePerLength.From(1, VolumePerLengthUnit.LiterPerKilometer);
            AssertEx.EqualTolerance(1, quantity03.LitersPerKilometer, LitersPerKilometerTolerance);
            Assert.Equal(VolumePerLengthUnit.LiterPerKilometer, quantity03.Unit);

            var quantity04 = VolumePerLength.From(1, VolumePerLengthUnit.LiterPerMeter);
            AssertEx.EqualTolerance(1, quantity04.LitersPerMeter, LitersPerMeterTolerance);
            Assert.Equal(VolumePerLengthUnit.LiterPerMeter, quantity04.Unit);

            var quantity05 = VolumePerLength.From(1, VolumePerLengthUnit.LiterPerMillimeter);
            AssertEx.EqualTolerance(1, quantity05.LitersPerMillimeter, LitersPerMillimeterTolerance);
            Assert.Equal(VolumePerLengthUnit.LiterPerMillimeter, quantity05.Unit);

            var quantity06 = VolumePerLength.From(1, VolumePerLengthUnit.OilBarrelPerFoot);
            AssertEx.EqualTolerance(1, quantity06.OilBarrelsPerFoot, OilBarrelsPerFootTolerance);
            Assert.Equal(VolumePerLengthUnit.OilBarrelPerFoot, quantity06.Unit);

        }

        [Fact]
        public void FromCubicMetersPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => VolumePerLength.FromCubicMetersPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => VolumePerLength.FromCubicMetersPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromCubicMetersPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => VolumePerLength.FromCubicMetersPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            AssertEx.EqualTolerance(CubicMetersPerMeterInOneCubicMeterPerMeter, cubicmeterpermeter.As(VolumePerLengthUnit.CubicMeterPerMeter), CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(CubicYardsPerFootInOneCubicMeterPerMeter, cubicmeterpermeter.As(VolumePerLengthUnit.CubicYardPerFoot), CubicYardsPerFootTolerance);
            AssertEx.EqualTolerance(CubicYardsPerUsSurveyFootInOneCubicMeterPerMeter, cubicmeterpermeter.As(VolumePerLengthUnit.CubicYardPerUsSurveyFoot), CubicYardsPerUsSurveyFootTolerance);
            AssertEx.EqualTolerance(LitersPerKilometerInOneCubicMeterPerMeter, cubicmeterpermeter.As(VolumePerLengthUnit.LiterPerKilometer), LitersPerKilometerTolerance);
            AssertEx.EqualTolerance(LitersPerMeterInOneCubicMeterPerMeter, cubicmeterpermeter.As(VolumePerLengthUnit.LiterPerMeter), LitersPerMeterTolerance);
            AssertEx.EqualTolerance(LitersPerMillimeterInOneCubicMeterPerMeter, cubicmeterpermeter.As(VolumePerLengthUnit.LiterPerMillimeter), LitersPerMillimeterTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerFootInOneCubicMeterPerMeter, cubicmeterpermeter.As(VolumePerLengthUnit.OilBarrelPerFoot), OilBarrelsPerFootTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);

            var cubicmeterpermeterQuantity = cubicmeterpermeter.ToUnit(VolumePerLengthUnit.CubicMeterPerMeter);
            AssertEx.EqualTolerance(CubicMetersPerMeterInOneCubicMeterPerMeter, (double)cubicmeterpermeterQuantity.Value, CubicMetersPerMeterTolerance);
            Assert.Equal(VolumePerLengthUnit.CubicMeterPerMeter, cubicmeterpermeterQuantity.Unit);

            var cubicyardperfootQuantity = cubicmeterpermeter.ToUnit(VolumePerLengthUnit.CubicYardPerFoot);
            AssertEx.EqualTolerance(CubicYardsPerFootInOneCubicMeterPerMeter, (double)cubicyardperfootQuantity.Value, CubicYardsPerFootTolerance);
            Assert.Equal(VolumePerLengthUnit.CubicYardPerFoot, cubicyardperfootQuantity.Unit);

            var cubicyardperussurveyfootQuantity = cubicmeterpermeter.ToUnit(VolumePerLengthUnit.CubicYardPerUsSurveyFoot);
            AssertEx.EqualTolerance(CubicYardsPerUsSurveyFootInOneCubicMeterPerMeter, (double)cubicyardperussurveyfootQuantity.Value, CubicYardsPerUsSurveyFootTolerance);
            Assert.Equal(VolumePerLengthUnit.CubicYardPerUsSurveyFoot, cubicyardperussurveyfootQuantity.Unit);

            var literperkilometerQuantity = cubicmeterpermeter.ToUnit(VolumePerLengthUnit.LiterPerKilometer);
            AssertEx.EqualTolerance(LitersPerKilometerInOneCubicMeterPerMeter, (double)literperkilometerQuantity.Value, LitersPerKilometerTolerance);
            Assert.Equal(VolumePerLengthUnit.LiterPerKilometer, literperkilometerQuantity.Unit);

            var literpermeterQuantity = cubicmeterpermeter.ToUnit(VolumePerLengthUnit.LiterPerMeter);
            AssertEx.EqualTolerance(LitersPerMeterInOneCubicMeterPerMeter, (double)literpermeterQuantity.Value, LitersPerMeterTolerance);
            Assert.Equal(VolumePerLengthUnit.LiterPerMeter, literpermeterQuantity.Unit);

            var literpermillimeterQuantity = cubicmeterpermeter.ToUnit(VolumePerLengthUnit.LiterPerMillimeter);
            AssertEx.EqualTolerance(LitersPerMillimeterInOneCubicMeterPerMeter, (double)literpermillimeterQuantity.Value, LitersPerMillimeterTolerance);
            Assert.Equal(VolumePerLengthUnit.LiterPerMillimeter, literpermillimeterQuantity.Unit);

            var oilbarrelperfootQuantity = cubicmeterpermeter.ToUnit(VolumePerLengthUnit.OilBarrelPerFoot);
            AssertEx.EqualTolerance(OilBarrelsPerFootInOneCubicMeterPerMeter, (double)oilbarrelperfootQuantity.Value, OilBarrelsPerFootTolerance);
            Assert.Equal(VolumePerLengthUnit.OilBarrelPerFoot, oilbarrelperfootQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            AssertEx.EqualTolerance(1, VolumePerLength.FromCubicMetersPerMeter(cubicmeterpermeter.CubicMetersPerMeter).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, VolumePerLength.FromCubicYardsPerFoot(cubicmeterpermeter.CubicYardsPerFoot).CubicMetersPerMeter, CubicYardsPerFootTolerance);
            AssertEx.EqualTolerance(1, VolumePerLength.FromCubicYardsPerUsSurveyFoot(cubicmeterpermeter.CubicYardsPerUsSurveyFoot).CubicMetersPerMeter, CubicYardsPerUsSurveyFootTolerance);
            AssertEx.EqualTolerance(1, VolumePerLength.FromLitersPerKilometer(cubicmeterpermeter.LitersPerKilometer).CubicMetersPerMeter, LitersPerKilometerTolerance);
            AssertEx.EqualTolerance(1, VolumePerLength.FromLitersPerMeter(cubicmeterpermeter.LitersPerMeter).CubicMetersPerMeter, LitersPerMeterTolerance);
            AssertEx.EqualTolerance(1, VolumePerLength.FromLitersPerMillimeter(cubicmeterpermeter.LitersPerMillimeter).CubicMetersPerMeter, LitersPerMillimeterTolerance);
            AssertEx.EqualTolerance(1, VolumePerLength.FromOilBarrelsPerFoot(cubicmeterpermeter.OilBarrelsPerFoot).CubicMetersPerMeter, OilBarrelsPerFootTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            VolumePerLength v = VolumePerLength.FromCubicMetersPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, (VolumePerLength.FromCubicMetersPerMeter(3)-v).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, (VolumePerLength.FromCubicMetersPerMeter(10)/5).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, VolumePerLength.FromCubicMetersPerMeter(10)/VolumePerLength.FromCubicMetersPerMeter(5), CubicMetersPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            VolumePerLength oneCubicMeterPerMeter = VolumePerLength.FromCubicMetersPerMeter(1);
            VolumePerLength twoCubicMetersPerMeter = VolumePerLength.FromCubicMetersPerMeter(2);

            Assert.True(oneCubicMeterPerMeter < twoCubicMetersPerMeter);
            Assert.True(oneCubicMeterPerMeter <= twoCubicMetersPerMeter);
            Assert.True(twoCubicMetersPerMeter > oneCubicMeterPerMeter);
            Assert.True(twoCubicMetersPerMeter >= oneCubicMeterPerMeter);

            Assert.False(oneCubicMeterPerMeter > twoCubicMetersPerMeter);
            Assert.False(oneCubicMeterPerMeter >= twoCubicMetersPerMeter);
            Assert.False(twoCubicMetersPerMeter < oneCubicMeterPerMeter);
            Assert.False(twoCubicMetersPerMeter <= oneCubicMeterPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.Equal(0, cubicmeterpermeter.CompareTo(cubicmeterpermeter));
            Assert.True(cubicmeterpermeter.CompareTo(VolumePerLength.Zero) > 0);
            Assert.True(VolumePerLength.Zero.CompareTo(cubicmeterpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeterpermeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = VolumePerLength.FromCubicMetersPerMeter(1);
            var b = VolumePerLength.FromCubicMetersPerMeter(2);

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
        public void Equals_SameType_IsImplemented()
        {
            var a = VolumePerLength.FromCubicMetersPerMeter(1);
            var b = VolumePerLength.FromCubicMetersPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = VolumePerLength.FromCubicMetersPerMeter(1);
            object b = VolumePerLength.FromCubicMetersPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.True(v.Equals(VolumePerLength.FromCubicMetersPerMeter(1), CubicMetersPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(VolumePerLength.Zero, CubicMetersPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(VolumePerLength.FromCubicMetersPerMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.False(cubicmeterpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.False(cubicmeterpermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(VolumePerLengthUnit.Undefined, VolumePerLength.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(VolumePerLengthUnit)).Cast<VolumePerLengthUnit>();
            foreach(var unit in units)
            {
                if(unit == VolumePerLengthUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(VolumePerLength.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 m³/m", new VolumePerLength(1, VolumePerLengthUnit.CubicMeterPerMeter).ToString());
                Assert.Equal("1 yd³/ft", new VolumePerLength(1, VolumePerLengthUnit.CubicYardPerFoot).ToString());
                Assert.Equal("1 yd³/ftUS", new VolumePerLength(1, VolumePerLengthUnit.CubicYardPerUsSurveyFoot).ToString());
                Assert.Equal("1 l/km", new VolumePerLength(1, VolumePerLengthUnit.LiterPerKilometer).ToString());
                Assert.Equal("1 l/m", new VolumePerLength(1, VolumePerLengthUnit.LiterPerMeter).ToString());
                Assert.Equal("1 l/mm", new VolumePerLength(1, VolumePerLengthUnit.LiterPerMillimeter).ToString());
                Assert.Equal("1 bbl/ft", new VolumePerLength(1, VolumePerLengthUnit.OilBarrelPerFoot).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 m³/m", new VolumePerLength(1, VolumePerLengthUnit.CubicMeterPerMeter).ToString(swedishCulture));
            Assert.Equal("1 yd³/ft", new VolumePerLength(1, VolumePerLengthUnit.CubicYardPerFoot).ToString(swedishCulture));
            Assert.Equal("1 yd³/ftUS", new VolumePerLength(1, VolumePerLengthUnit.CubicYardPerUsSurveyFoot).ToString(swedishCulture));
            Assert.Equal("1 l/km", new VolumePerLength(1, VolumePerLengthUnit.LiterPerKilometer).ToString(swedishCulture));
            Assert.Equal("1 l/m", new VolumePerLength(1, VolumePerLengthUnit.LiterPerMeter).ToString(swedishCulture));
            Assert.Equal("1 l/mm", new VolumePerLength(1, VolumePerLengthUnit.LiterPerMillimeter).ToString(swedishCulture));
            Assert.Equal("1 bbl/ft", new VolumePerLength(1, VolumePerLengthUnit.OilBarrelPerFoot).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 m³/m", new VolumePerLength(0.123456, VolumePerLengthUnit.CubicMeterPerMeter).ToString("s1"));
                Assert.Equal("0.12 m³/m", new VolumePerLength(0.123456, VolumePerLengthUnit.CubicMeterPerMeter).ToString("s2"));
                Assert.Equal("0.123 m³/m", new VolumePerLength(0.123456, VolumePerLengthUnit.CubicMeterPerMeter).ToString("s3"));
                Assert.Equal("0.1235 m³/m", new VolumePerLength(0.123456, VolumePerLengthUnit.CubicMeterPerMeter).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 m³/m", new VolumePerLength(0.123456, VolumePerLengthUnit.CubicMeterPerMeter).ToString("s1", culture));
            Assert.Equal("0.12 m³/m", new VolumePerLength(0.123456, VolumePerLengthUnit.CubicMeterPerMeter).ToString("s2", culture));
            Assert.Equal("0.123 m³/m", new VolumePerLength(0.123456, VolumePerLengthUnit.CubicMeterPerMeter).ToString("s3", culture));
            Assert.Equal("0.1235 m³/m", new VolumePerLength(0.123456, VolumePerLengthUnit.CubicMeterPerMeter).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(VolumePerLength)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(VolumePerLengthUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal(QuantityType.VolumePerLength, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Equal(VolumePerLength.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(1.0);
            var roundedBaseValue = Math.Round(quantity.ToBaseUnit().Value, 5);
            Assert.Equal(new {VolumePerLength.QuantityType, roundedBaseValue}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = VolumePerLength.FromCubicMetersPerMeter(value);
            Assert.Equal(VolumePerLength.FromCubicMetersPerMeter(-value), -quantity);
        }

    }
}

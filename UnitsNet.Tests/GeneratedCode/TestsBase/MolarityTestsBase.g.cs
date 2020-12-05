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
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Molarity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MolarityTestsBase : QuantityTestsBase
    {
        protected abstract double CentimolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double DecimolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double MicromolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double MillimolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double MolesPerCubicMeterInOneMolesPerCubicMeter { get; }
        protected abstract double MolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double NanomolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double PicomolesPerLiterInOneMolesPerCubicMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double DecimolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double MicromolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double MillimolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double MolesPerCubicMeterTolerance { get { return 1e-5; } }
        protected virtual double MolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double NanomolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double PicomolesPerLiterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Molarity((double)0.0, MolarityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Molarity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(MolarityUnit.MolesPerCubicMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Molarity(double.PositiveInfinity, MolarityUnit.MolesPerCubicMeter));
            Assert.Throws<ArgumentException>(() => new Molarity(double.NegativeInfinity, MolarityUnit.MolesPerCubicMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Molarity(double.NaN, MolarityUnit.MolesPerCubicMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Molarity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Molarity(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Molarity) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Molarity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Molarity(1, MolarityUnit.MolesPerCubicMeter);

            QuantityInfo<MolarityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Molarity.Zero, quantityInfo.Zero);
            Assert.Equal("Molarity", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<MolarityUnit>().Except(new[] {MolarityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void MolesPerCubicMeterToMolarityUnits()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            AssertEx.EqualTolerance(CentimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.CentimolesPerLiter, CentimolesPerLiterTolerance);
            AssertEx.EqualTolerance(DecimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.DecimolesPerLiter, DecimolesPerLiterTolerance);
            AssertEx.EqualTolerance(MicromolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.MicromolesPerLiter, MicromolesPerLiterTolerance);
            AssertEx.EqualTolerance(MillimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.MillimolesPerLiter, MillimolesPerLiterTolerance);
            AssertEx.EqualTolerance(MolesPerCubicMeterInOneMolesPerCubicMeter, molespercubicmeter.MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(MolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.MolesPerLiter, MolesPerLiterTolerance);
            AssertEx.EqualTolerance(NanomolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.NanomolesPerLiter, NanomolesPerLiterTolerance);
            AssertEx.EqualTolerance(PicomolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.PicomolesPerLiter, PicomolesPerLiterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Molarity.From(1, MolarityUnit.CentimolesPerLiter);
            AssertEx.EqualTolerance(1, quantity00.CentimolesPerLiter, CentimolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.CentimolesPerLiter, quantity00.Unit);

            var quantity01 = Molarity.From(1, MolarityUnit.DecimolesPerLiter);
            AssertEx.EqualTolerance(1, quantity01.DecimolesPerLiter, DecimolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.DecimolesPerLiter, quantity01.Unit);

            var quantity02 = Molarity.From(1, MolarityUnit.MicromolesPerLiter);
            AssertEx.EqualTolerance(1, quantity02.MicromolesPerLiter, MicromolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.MicromolesPerLiter, quantity02.Unit);

            var quantity03 = Molarity.From(1, MolarityUnit.MillimolesPerLiter);
            AssertEx.EqualTolerance(1, quantity03.MillimolesPerLiter, MillimolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.MillimolesPerLiter, quantity03.Unit);

            var quantity04 = Molarity.From(1, MolarityUnit.MolesPerCubicMeter);
            AssertEx.EqualTolerance(1, quantity04.MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            Assert.Equal(MolarityUnit.MolesPerCubicMeter, quantity04.Unit);

            var quantity05 = Molarity.From(1, MolarityUnit.MolesPerLiter);
            AssertEx.EqualTolerance(1, quantity05.MolesPerLiter, MolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.MolesPerLiter, quantity05.Unit);

            var quantity06 = Molarity.From(1, MolarityUnit.NanomolesPerLiter);
            AssertEx.EqualTolerance(1, quantity06.NanomolesPerLiter, NanomolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.NanomolesPerLiter, quantity06.Unit);

            var quantity07 = Molarity.From(1, MolarityUnit.PicomolesPerLiter);
            AssertEx.EqualTolerance(1, quantity07.PicomolesPerLiter, PicomolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.PicomolesPerLiter, quantity07.Unit);

        }

        [Fact]
        public void FromMolesPerCubicMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Molarity.FromMolesPerCubicMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Molarity.FromMolesPerCubicMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromMolesPerCubicMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Molarity.FromMolesPerCubicMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            AssertEx.EqualTolerance(CentimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.CentimolesPerLiter), CentimolesPerLiterTolerance);
            AssertEx.EqualTolerance(DecimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.DecimolesPerLiter), DecimolesPerLiterTolerance);
            AssertEx.EqualTolerance(MicromolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.MicromolesPerLiter), MicromolesPerLiterTolerance);
            AssertEx.EqualTolerance(MillimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.MillimolesPerLiter), MillimolesPerLiterTolerance);
            AssertEx.EqualTolerance(MolesPerCubicMeterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.MolesPerCubicMeter), MolesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(MolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.MolesPerLiter), MolesPerLiterTolerance);
            AssertEx.EqualTolerance(NanomolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.NanomolesPerLiter), NanomolesPerLiterTolerance);
            AssertEx.EqualTolerance(PicomolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.PicomolesPerLiter), PicomolesPerLiterTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Molarity(value: 1, unit: Molarity.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);

            var centimolesperliterQuantity = molespercubicmeter.ToUnit(MolarityUnit.CentimolesPerLiter);
            AssertEx.EqualTolerance(CentimolesPerLiterInOneMolesPerCubicMeter, (double)centimolesperliterQuantity.Value, CentimolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.CentimolesPerLiter, centimolesperliterQuantity.Unit);

            var decimolesperliterQuantity = molespercubicmeter.ToUnit(MolarityUnit.DecimolesPerLiter);
            AssertEx.EqualTolerance(DecimolesPerLiterInOneMolesPerCubicMeter, (double)decimolesperliterQuantity.Value, DecimolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.DecimolesPerLiter, decimolesperliterQuantity.Unit);

            var micromolesperliterQuantity = molespercubicmeter.ToUnit(MolarityUnit.MicromolesPerLiter);
            AssertEx.EqualTolerance(MicromolesPerLiterInOneMolesPerCubicMeter, (double)micromolesperliterQuantity.Value, MicromolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.MicromolesPerLiter, micromolesperliterQuantity.Unit);

            var millimolesperliterQuantity = molespercubicmeter.ToUnit(MolarityUnit.MillimolesPerLiter);
            AssertEx.EqualTolerance(MillimolesPerLiterInOneMolesPerCubicMeter, (double)millimolesperliterQuantity.Value, MillimolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.MillimolesPerLiter, millimolesperliterQuantity.Unit);

            var molespercubicmeterQuantity = molespercubicmeter.ToUnit(MolarityUnit.MolesPerCubicMeter);
            AssertEx.EqualTolerance(MolesPerCubicMeterInOneMolesPerCubicMeter, (double)molespercubicmeterQuantity.Value, MolesPerCubicMeterTolerance);
            Assert.Equal(MolarityUnit.MolesPerCubicMeter, molespercubicmeterQuantity.Unit);

            var molesperliterQuantity = molespercubicmeter.ToUnit(MolarityUnit.MolesPerLiter);
            AssertEx.EqualTolerance(MolesPerLiterInOneMolesPerCubicMeter, (double)molesperliterQuantity.Value, MolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.MolesPerLiter, molesperliterQuantity.Unit);

            var nanomolesperliterQuantity = molespercubicmeter.ToUnit(MolarityUnit.NanomolesPerLiter);
            AssertEx.EqualTolerance(NanomolesPerLiterInOneMolesPerCubicMeter, (double)nanomolesperliterQuantity.Value, NanomolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.NanomolesPerLiter, nanomolesperliterQuantity.Unit);

            var picomolesperliterQuantity = molespercubicmeter.ToUnit(MolarityUnit.PicomolesPerLiter);
            AssertEx.EqualTolerance(PicomolesPerLiterInOneMolesPerCubicMeter, (double)picomolesperliterQuantity.Value, PicomolesPerLiterTolerance);
            Assert.Equal(MolarityUnit.PicomolesPerLiter, picomolesperliterQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = Molarity.FromMolesPerCubicMeter(1).ToBaseUnit();
            Assert.Equal(Molarity.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            AssertEx.EqualTolerance(1, Molarity.FromCentimolesPerLiter(molespercubicmeter.CentimolesPerLiter).MolesPerCubicMeter, CentimolesPerLiterTolerance);
            AssertEx.EqualTolerance(1, Molarity.FromDecimolesPerLiter(molespercubicmeter.DecimolesPerLiter).MolesPerCubicMeter, DecimolesPerLiterTolerance);
            AssertEx.EqualTolerance(1, Molarity.FromMicromolesPerLiter(molespercubicmeter.MicromolesPerLiter).MolesPerCubicMeter, MicromolesPerLiterTolerance);
            AssertEx.EqualTolerance(1, Molarity.FromMillimolesPerLiter(molespercubicmeter.MillimolesPerLiter).MolesPerCubicMeter, MillimolesPerLiterTolerance);
            AssertEx.EqualTolerance(1, Molarity.FromMolesPerCubicMeter(molespercubicmeter.MolesPerCubicMeter).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, Molarity.FromMolesPerLiter(molespercubicmeter.MolesPerLiter).MolesPerCubicMeter, MolesPerLiterTolerance);
            AssertEx.EqualTolerance(1, Molarity.FromNanomolesPerLiter(molespercubicmeter.NanomolesPerLiter).MolesPerCubicMeter, NanomolesPerLiterTolerance);
            AssertEx.EqualTolerance(1, Molarity.FromPicomolesPerLiter(molespercubicmeter.PicomolesPerLiter).MolesPerCubicMeter, PicomolesPerLiterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Molarity v = Molarity.FromMolesPerCubicMeter(1);
            AssertEx.EqualTolerance(-1, -v.MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (Molarity.FromMolesPerCubicMeter(3)-v).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (Molarity.FromMolesPerCubicMeter(10)/5).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, Molarity.FromMolesPerCubicMeter(10)/Molarity.FromMolesPerCubicMeter(5), MolesPerCubicMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Molarity oneMolesPerCubicMeter = Molarity.FromMolesPerCubicMeter(1);
            Molarity twoMolesPerCubicMeter = Molarity.FromMolesPerCubicMeter(2);

            Assert.True(oneMolesPerCubicMeter < twoMolesPerCubicMeter);
            Assert.True(oneMolesPerCubicMeter <= twoMolesPerCubicMeter);
            Assert.True(twoMolesPerCubicMeter > oneMolesPerCubicMeter);
            Assert.True(twoMolesPerCubicMeter >= oneMolesPerCubicMeter);

            Assert.False(oneMolesPerCubicMeter > twoMolesPerCubicMeter);
            Assert.False(oneMolesPerCubicMeter >= twoMolesPerCubicMeter);
            Assert.False(twoMolesPerCubicMeter < oneMolesPerCubicMeter);
            Assert.False(twoMolesPerCubicMeter <= oneMolesPerCubicMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.Equal(0, molespercubicmeter.CompareTo(molespercubicmeter));
            Assert.True(molespercubicmeter.CompareTo(Molarity.Zero) > 0);
            Assert.True(Molarity.Zero.CompareTo(molespercubicmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.Throws<ArgumentException>(() => molespercubicmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.Throws<ArgumentNullException>(() => molespercubicmeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Molarity.FromMolesPerCubicMeter(1);
            var b = Molarity.FromMolesPerCubicMeter(2);

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
            var a = Molarity.FromMolesPerCubicMeter(1);
            var b = Molarity.FromMolesPerCubicMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Molarity.FromMolesPerCubicMeter(1);
            object b = Molarity.FromMolesPerCubicMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Molarity.FromMolesPerCubicMeter(1);
            Assert.True(v.Equals(Molarity.FromMolesPerCubicMeter(1), MolesPerCubicMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Molarity.Zero, MolesPerCubicMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Molarity.FromMolesPerCubicMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Molarity.FromMolesPerCubicMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.False(molespercubicmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.False(molespercubicmeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MolarityUnit.Undefined, Molarity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MolarityUnit)).Cast<MolarityUnit>();
            foreach(var unit in units)
            {
                if(unit == MolarityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Molarity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cmol/L", new Molarity(1, MolarityUnit.CentimolesPerLiter).ToString());
                Assert.Equal("1 dmol/L", new Molarity(1, MolarityUnit.DecimolesPerLiter).ToString());
                Assert.Equal("1 µmol/L", new Molarity(1, MolarityUnit.MicromolesPerLiter).ToString());
                Assert.Equal("1 mmol/L", new Molarity(1, MolarityUnit.MillimolesPerLiter).ToString());
                Assert.Equal("1 mol/m³", new Molarity(1, MolarityUnit.MolesPerCubicMeter).ToString());
                Assert.Equal("1 mol/L", new Molarity(1, MolarityUnit.MolesPerLiter).ToString());
                Assert.Equal("1 nmol/L", new Molarity(1, MolarityUnit.NanomolesPerLiter).ToString());
                Assert.Equal("1 pmol/L", new Molarity(1, MolarityUnit.PicomolesPerLiter).ToString());
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

            Assert.Equal("1 cmol/L", new Molarity(1, MolarityUnit.CentimolesPerLiter).ToString(swedishCulture));
            Assert.Equal("1 dmol/L", new Molarity(1, MolarityUnit.DecimolesPerLiter).ToString(swedishCulture));
            Assert.Equal("1 µmol/L", new Molarity(1, MolarityUnit.MicromolesPerLiter).ToString(swedishCulture));
            Assert.Equal("1 mmol/L", new Molarity(1, MolarityUnit.MillimolesPerLiter).ToString(swedishCulture));
            Assert.Equal("1 mol/m³", new Molarity(1, MolarityUnit.MolesPerCubicMeter).ToString(swedishCulture));
            Assert.Equal("1 mol/L", new Molarity(1, MolarityUnit.MolesPerLiter).ToString(swedishCulture));
            Assert.Equal("1 nmol/L", new Molarity(1, MolarityUnit.NanomolesPerLiter).ToString(swedishCulture));
            Assert.Equal("1 pmol/L", new Molarity(1, MolarityUnit.PicomolesPerLiter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 mol/m³", new Molarity(0.123456, MolarityUnit.MolesPerCubicMeter).ToString("s1"));
                Assert.Equal("0.12 mol/m³", new Molarity(0.123456, MolarityUnit.MolesPerCubicMeter).ToString("s2"));
                Assert.Equal("0.123 mol/m³", new Molarity(0.123456, MolarityUnit.MolesPerCubicMeter).ToString("s3"));
                Assert.Equal("0.1235 mol/m³", new Molarity(0.123456, MolarityUnit.MolesPerCubicMeter).ToString("s4"));
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
            Assert.Equal("0.1 mol/m³", new Molarity(0.123456, MolarityUnit.MolesPerCubicMeter).ToString("s1", culture));
            Assert.Equal("0.12 mol/m³", new Molarity(0.123456, MolarityUnit.MolesPerCubicMeter).ToString("s2", culture));
            Assert.Equal("0.123 mol/m³", new Molarity(0.123456, MolarityUnit.MolesPerCubicMeter).ToString("s3", culture));
            Assert.Equal("0.1235 mol/m³", new Molarity(0.123456, MolarityUnit.MolesPerCubicMeter).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Molarity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(MolarityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal(QuantityType.Molarity, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal(Molarity.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal(Molarity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Molarity.FromMolesPerCubicMeter(1.0);
            Assert.Equal(new {Molarity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Molarity.FromMolesPerCubicMeter(value);
            Assert.Equal(Molarity.FromMolesPerCubicMeter(-value), -quantity);
        }
    }
}

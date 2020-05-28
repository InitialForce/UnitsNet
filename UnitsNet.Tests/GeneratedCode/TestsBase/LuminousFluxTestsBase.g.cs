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
    /// Test of LuminousFlux.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LuminousFluxTestsBase
    {
        protected abstract double LumensInOneLumen { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double LumensTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousFlux((double)0.0, LuminousFluxUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new LuminousFlux();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(LuminousFluxUnit.Lumen, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousFlux(double.PositiveInfinity, LuminousFluxUnit.Lumen));
            Assert.Throws<ArgumentException>(() => new LuminousFlux(double.NegativeInfinity, LuminousFluxUnit.Lumen));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousFlux(double.NaN, LuminousFluxUnit.Lumen));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new LuminousFlux(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void LuminousFlux_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new LuminousFlux(1, LuminousFluxUnit.Lumen);

            QuantityInfo<LuminousFluxUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(LuminousFlux.Zero, quantityInfo.Zero);
            Assert.Equal("LuminousFlux", quantityInfo.Name);
            Assert.Equal(QuantityType.LuminousFlux, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<LuminousFluxUnit>().Except(new[] {LuminousFluxUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void LumenToLuminousFluxUnits()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            AssertEx.EqualTolerance(LumensInOneLumen, lumen.Lumens, LumensTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = LuminousFlux.From(1, LuminousFluxUnit.Lumen);
            AssertEx.EqualTolerance(1, quantity00.Lumens, LumensTolerance);
            Assert.Equal(LuminousFluxUnit.Lumen, quantity00.Unit);

        }

        [Fact]
        public void FromLumens_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LuminousFlux.FromLumens(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => LuminousFlux.FromLumens(double.NegativeInfinity));
        }

        [Fact]
        public void FromLumens_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LuminousFlux.FromLumens(double.NaN));
        }

        [Fact]
        public void As()
        {
            var lumen = LuminousFlux.FromLumens(1);
            AssertEx.EqualTolerance(LumensInOneLumen, lumen.As(LuminousFluxUnit.Lumen), LumensTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var lumen = LuminousFlux.FromLumens(1);

            var lumenQuantity = lumen.ToUnit(LuminousFluxUnit.Lumen);
            AssertEx.EqualTolerance(LumensInOneLumen, (double)lumenQuantity.Value, LumensTolerance);
            Assert.Equal(LuminousFluxUnit.Lumen, lumenQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            AssertEx.EqualTolerance(1, LuminousFlux.FromLumens(lumen.Lumens).Lumens, LumensTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LuminousFlux v = LuminousFlux.FromLumens(1);
            AssertEx.EqualTolerance(-1, -v.Lumens, LumensTolerance);
            AssertEx.EqualTolerance(2, (LuminousFlux.FromLumens(3)-v).Lumens, LumensTolerance);
            AssertEx.EqualTolerance(2, (v + v).Lumens, LumensTolerance);
            AssertEx.EqualTolerance(10, (v*10).Lumens, LumensTolerance);
            AssertEx.EqualTolerance(10, (10*v).Lumens, LumensTolerance);
            AssertEx.EqualTolerance(2, (LuminousFlux.FromLumens(10)/5).Lumens, LumensTolerance);
            AssertEx.EqualTolerance(2, LuminousFlux.FromLumens(10)/LuminousFlux.FromLumens(5), LumensTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LuminousFlux oneLumen = LuminousFlux.FromLumens(1);
            LuminousFlux twoLumens = LuminousFlux.FromLumens(2);

            Assert.True(oneLumen < twoLumens);
            Assert.True(oneLumen <= twoLumens);
            Assert.True(twoLumens > oneLumen);
            Assert.True(twoLumens >= oneLumen);

            Assert.False(oneLumen > twoLumens);
            Assert.False(oneLumen >= twoLumens);
            Assert.False(twoLumens < oneLumen);
            Assert.False(twoLumens <= oneLumen);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            Assert.Equal(0, lumen.CompareTo(lumen));
            Assert.True(lumen.CompareTo(LuminousFlux.Zero) > 0);
            Assert.True(LuminousFlux.Zero.CompareTo(lumen) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            Assert.Throws<ArgumentException>(() => lumen.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            Assert.Throws<ArgumentNullException>(() => lumen.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = LuminousFlux.FromLumens(1);
            var b = LuminousFlux.FromLumens(2);

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
            var a = LuminousFlux.FromLumens(1);
            var b = LuminousFlux.FromLumens(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = LuminousFlux.FromLumens(1);
            Assert.True(v.Equals(LuminousFlux.FromLumens(1), LumensTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(LuminousFlux.Zero, LumensTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            Assert.False(lumen.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            Assert.False(lumen.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(LuminousFluxUnit.Undefined, LuminousFlux.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(LuminousFluxUnit)).Cast<LuminousFluxUnit>();
            foreach(var unit in units)
            {
                if(unit == LuminousFluxUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(LuminousFlux.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 lm", new LuminousFlux(1, LuminousFluxUnit.Lumen).ToString());
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

            Assert.Equal("1 lm", new LuminousFlux(1, LuminousFluxUnit.Lumen).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 lm", new LuminousFlux(0.123456, LuminousFluxUnit.Lumen).ToString("s1"));
                Assert.Equal("0.12 lm", new LuminousFlux(0.123456, LuminousFluxUnit.Lumen).ToString("s2"));
                Assert.Equal("0.123 lm", new LuminousFlux(0.123456, LuminousFluxUnit.Lumen).ToString("s3"));
                Assert.Equal("0.1235 lm", new LuminousFlux(0.123456, LuminousFluxUnit.Lumen).ToString("s4"));
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
            Assert.Equal("0.1 lm", new LuminousFlux(0.123456, LuminousFluxUnit.Lumen).ToString("s1", culture));
            Assert.Equal("0.12 lm", new LuminousFlux(0.123456, LuminousFluxUnit.Lumen).ToString("s2", culture));
            Assert.Equal("0.123 lm", new LuminousFlux(0.123456, LuminousFluxUnit.Lumen).ToString("s3", culture));
            Assert.Equal("0.1235 lm", new LuminousFlux(0.123456, LuminousFluxUnit.Lumen).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(LuminousFlux)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(LuminousFluxUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal(QuantityType.LuminousFlux, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Equal(LuminousFlux.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = LuminousFlux.FromLumens(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = LuminousFlux.FromLumens(value);
            Assert.Equal(LuminousFlux.FromLumens(-value), -quantity);
        }

    }
}

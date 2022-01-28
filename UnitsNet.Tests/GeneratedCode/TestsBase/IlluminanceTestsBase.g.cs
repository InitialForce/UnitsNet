//------------------------------------------------------------------------------
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
    /// Test of Illuminance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class IlluminanceTestsBase : QuantityTestsBase
    {
        protected abstract double KiloluxInOneLux { get; }
        protected abstract double LuxInOneLux { get; }
        protected abstract double MegaluxInOneLux { get; }
        protected abstract double MilliluxInOneLux { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KiloluxTolerance { get { return 1e-5; } }
        protected virtual double LuxTolerance { get { return 1e-5; } }
        protected virtual double MegaluxTolerance { get { return 1e-5; } }
        protected virtual double MilliluxTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Illuminance((double)0.0, IlluminanceUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Illuminance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(IlluminanceUnit.Lux, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Illuminance(double.PositiveInfinity, IlluminanceUnit.Lux));
            Assert.Throws<ArgumentException>(() => new Illuminance(double.NegativeInfinity, IlluminanceUnit.Lux));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Illuminance(double.NaN, IlluminanceUnit.Lux));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Illuminance(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Illuminance(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Illuminance) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Illuminance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Illuminance(1, IlluminanceUnit.Lux);

            QuantityInfo<IlluminanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Illuminance.Zero, quantityInfo.Zero);
            Assert.Equal("Illuminance", quantityInfo.Name);
            Assert.Equal(QuantityType.Illuminance, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<IlluminanceUnit>().Except(new[] {IlluminanceUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void LuxToIlluminanceUnits()
        {
            Illuminance lux = Illuminance.FromLux(1);
            AssertEx.EqualTolerance(KiloluxInOneLux, lux.Kilolux, KiloluxTolerance);
            AssertEx.EqualTolerance(LuxInOneLux, lux.Lux, LuxTolerance);
            AssertEx.EqualTolerance(MegaluxInOneLux, lux.Megalux, MegaluxTolerance);
            AssertEx.EqualTolerance(MilliluxInOneLux, lux.Millilux, MilliluxTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Illuminance.From(1, IlluminanceUnit.Kilolux);
            AssertEx.EqualTolerance(1, quantity00.Kilolux, KiloluxTolerance);
            Assert.Equal(IlluminanceUnit.Kilolux, quantity00.Unit);

            var quantity01 = Illuminance.From(1, IlluminanceUnit.Lux);
            AssertEx.EqualTolerance(1, quantity01.Lux, LuxTolerance);
            Assert.Equal(IlluminanceUnit.Lux, quantity01.Unit);

            var quantity02 = Illuminance.From(1, IlluminanceUnit.Megalux);
            AssertEx.EqualTolerance(1, quantity02.Megalux, MegaluxTolerance);
            Assert.Equal(IlluminanceUnit.Megalux, quantity02.Unit);

            var quantity03 = Illuminance.From(1, IlluminanceUnit.Millilux);
            AssertEx.EqualTolerance(1, quantity03.Millilux, MilliluxTolerance);
            Assert.Equal(IlluminanceUnit.Millilux, quantity03.Unit);

        }

        [Fact]
        public void FromLux_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Illuminance.FromLux(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Illuminance.FromLux(double.NegativeInfinity));
        }

        [Fact]
        public void FromLux_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Illuminance.FromLux(double.NaN));
        }

        [Fact]
        public void As()
        {
            var lux = Illuminance.FromLux(1);
            AssertEx.EqualTolerance(KiloluxInOneLux, lux.As(IlluminanceUnit.Kilolux), KiloluxTolerance);
            AssertEx.EqualTolerance(LuxInOneLux, lux.As(IlluminanceUnit.Lux), LuxTolerance);
            AssertEx.EqualTolerance(MegaluxInOneLux, lux.As(IlluminanceUnit.Megalux), MegaluxTolerance);
            AssertEx.EqualTolerance(MilliluxInOneLux, lux.As(IlluminanceUnit.Millilux), MilliluxTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Illuminance(value: 1, unit: Illuminance.BaseUnit);
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
            var lux = Illuminance.FromLux(1);

            var kiloluxQuantity = lux.ToUnit(IlluminanceUnit.Kilolux);
            AssertEx.EqualTolerance(KiloluxInOneLux, (double)kiloluxQuantity.Value, KiloluxTolerance);
            Assert.Equal(IlluminanceUnit.Kilolux, kiloluxQuantity.Unit);

            var luxQuantity = lux.ToUnit(IlluminanceUnit.Lux);
            AssertEx.EqualTolerance(LuxInOneLux, (double)luxQuantity.Value, LuxTolerance);
            Assert.Equal(IlluminanceUnit.Lux, luxQuantity.Unit);

            var megaluxQuantity = lux.ToUnit(IlluminanceUnit.Megalux);
            AssertEx.EqualTolerance(MegaluxInOneLux, (double)megaluxQuantity.Value, MegaluxTolerance);
            Assert.Equal(IlluminanceUnit.Megalux, megaluxQuantity.Unit);

            var milliluxQuantity = lux.ToUnit(IlluminanceUnit.Millilux);
            AssertEx.EqualTolerance(MilliluxInOneLux, (double)milliluxQuantity.Value, MilliluxTolerance);
            Assert.Equal(IlluminanceUnit.Millilux, milliluxQuantity.Unit);
        }

        [Fact]
        public void ToUnit_WithBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = Illuminance.FromLux(1).ToUnit(Illuminance.BaseUnit);
            Assert.Equal(Illuminance.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Illuminance lux = Illuminance.FromLux(1);
            AssertEx.EqualTolerance(1, Illuminance.FromKilolux(lux.Kilolux).Lux, KiloluxTolerance);
            AssertEx.EqualTolerance(1, Illuminance.FromLux(lux.Lux).Lux, LuxTolerance);
            AssertEx.EqualTolerance(1, Illuminance.FromMegalux(lux.Megalux).Lux, MegaluxTolerance);
            AssertEx.EqualTolerance(1, Illuminance.FromMillilux(lux.Millilux).Lux, MilliluxTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Illuminance v = Illuminance.FromLux(1);
            AssertEx.EqualTolerance(-1, -v.Lux, LuxTolerance);
            AssertEx.EqualTolerance(2, (Illuminance.FromLux(3)-v).Lux, LuxTolerance);
            AssertEx.EqualTolerance(2, (v + v).Lux, LuxTolerance);
            AssertEx.EqualTolerance(10, (v*10).Lux, LuxTolerance);
            AssertEx.EqualTolerance(10, (10*v).Lux, LuxTolerance);
            AssertEx.EqualTolerance(2, (Illuminance.FromLux(10)/5).Lux, LuxTolerance);
            AssertEx.EqualTolerance(2, Illuminance.FromLux(10)/Illuminance.FromLux(5), LuxTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Illuminance oneLux = Illuminance.FromLux(1);
            Illuminance twoLux = Illuminance.FromLux(2);

            Assert.True(oneLux < twoLux);
            Assert.True(oneLux <= twoLux);
            Assert.True(twoLux > oneLux);
            Assert.True(twoLux >= oneLux);

            Assert.False(oneLux > twoLux);
            Assert.False(oneLux >= twoLux);
            Assert.False(twoLux < oneLux);
            Assert.False(twoLux <= oneLux);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Illuminance lux = Illuminance.FromLux(1);
            Assert.Equal(0, lux.CompareTo(lux));
            Assert.True(lux.CompareTo(Illuminance.Zero) > 0);
            Assert.True(Illuminance.Zero.CompareTo(lux) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Illuminance lux = Illuminance.FromLux(1);
            Assert.Throws<ArgumentException>(() => lux.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Illuminance lux = Illuminance.FromLux(1);
            Assert.Throws<ArgumentNullException>(() => lux.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Illuminance.FromLux(1);
            var b = Illuminance.FromLux(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = Illuminance.FromLux(1);
            var b = Illuminance.FromLux(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Illuminance.FromLux(1);
            object b = Illuminance.FromLux(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Illuminance.FromLux(1);
            Assert.True(v.Equals(Illuminance.FromLux(1), LuxTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Illuminance.Zero, LuxTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Illuminance.FromLux(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Illuminance.FromLux(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Illuminance lux = Illuminance.FromLux(1);
            Assert.False(lux.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Illuminance lux = Illuminance.FromLux(1);
            Assert.False(lux.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(IlluminanceUnit.Undefined, Illuminance.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(IlluminanceUnit)).Cast<IlluminanceUnit>();
            foreach(var unit in units)
            {
                if(unit == IlluminanceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Illuminance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 klx", new Illuminance(1, IlluminanceUnit.Kilolux).ToString());
                Assert.Equal("1 lx", new Illuminance(1, IlluminanceUnit.Lux).ToString());
                Assert.Equal("1 Mlx", new Illuminance(1, IlluminanceUnit.Megalux).ToString());
                Assert.Equal("1 mlx", new Illuminance(1, IlluminanceUnit.Millilux).ToString());
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

            Assert.Equal("1 klx", new Illuminance(1, IlluminanceUnit.Kilolux).ToString(swedishCulture));
            Assert.Equal("1 lx", new Illuminance(1, IlluminanceUnit.Lux).ToString(swedishCulture));
            Assert.Equal("1 Mlx", new Illuminance(1, IlluminanceUnit.Megalux).ToString(swedishCulture));
            Assert.Equal("1 mlx", new Illuminance(1, IlluminanceUnit.Millilux).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 lx", new Illuminance(0.123456, IlluminanceUnit.Lux).ToString("s1"));
                Assert.Equal("0.12 lx", new Illuminance(0.123456, IlluminanceUnit.Lux).ToString("s2"));
                Assert.Equal("0.123 lx", new Illuminance(0.123456, IlluminanceUnit.Lux).ToString("s3"));
                Assert.Equal("0.1235 lx", new Illuminance(0.123456, IlluminanceUnit.Lux).ToString("s4"));
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
            Assert.Equal("0.1 lx", new Illuminance(0.123456, IlluminanceUnit.Lux).ToString("s1", culture));
            Assert.Equal("0.12 lx", new Illuminance(0.123456, IlluminanceUnit.Lux).ToString("s2", culture));
            Assert.Equal("0.123 lx", new Illuminance(0.123456, IlluminanceUnit.Lux).ToString("s3", culture));
            Assert.Equal("0.1235 lx", new Illuminance(0.123456, IlluminanceUnit.Lux).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Illuminance)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(IlluminanceUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal(QuantityType.Illuminance, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal(Illuminance.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal(Illuminance.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Illuminance.FromLux(1.0);
            Assert.Equal(new {Illuminance.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Illuminance.FromLux(value);
            Assert.Equal(Illuminance.FromLux(-value), -quantity);
        }
    }
}

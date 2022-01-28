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
    /// Test of MolarEntropy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MolarEntropyTestsBase : QuantityTestsBase
    {
        protected abstract double JoulesPerMoleKelvinInOneJoulePerMoleKelvin { get; }
        protected abstract double KilojoulesPerMoleKelvinInOneJoulePerMoleKelvin { get; }
        protected abstract double MegajoulesPerMoleKelvinInOneJoulePerMoleKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double JoulesPerMoleKelvinTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerMoleKelvinTolerance { get { return 1e-5; } }
        protected virtual double MegajoulesPerMoleKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MolarEntropy((double)0.0, MolarEntropyUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new MolarEntropy();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(MolarEntropyUnit.JoulePerMoleKelvin, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MolarEntropy(double.PositiveInfinity, MolarEntropyUnit.JoulePerMoleKelvin));
            Assert.Throws<ArgumentException>(() => new MolarEntropy(double.NegativeInfinity, MolarEntropyUnit.JoulePerMoleKelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MolarEntropy(double.NaN, MolarEntropyUnit.JoulePerMoleKelvin));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MolarEntropy(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new MolarEntropy(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (MolarEntropy) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void MolarEntropy_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new MolarEntropy(1, MolarEntropyUnit.JoulePerMoleKelvin);

            QuantityInfo<MolarEntropyUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(MolarEntropy.Zero, quantityInfo.Zero);
            Assert.Equal("MolarEntropy", quantityInfo.Name);
            Assert.Equal(QuantityType.MolarEntropy, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<MolarEntropyUnit>().Except(new[] {MolarEntropyUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void JoulePerMoleKelvinToMolarEntropyUnits()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            AssertEx.EqualTolerance(JoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(KilojoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.KilojoulesPerMoleKelvin, KilojoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(MegajoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.MegajoulesPerMoleKelvin, MegajoulesPerMoleKelvinTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = MolarEntropy.From(1, MolarEntropyUnit.JoulePerMoleKelvin);
            AssertEx.EqualTolerance(1, quantity00.JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            Assert.Equal(MolarEntropyUnit.JoulePerMoleKelvin, quantity00.Unit);

            var quantity01 = MolarEntropy.From(1, MolarEntropyUnit.KilojoulePerMoleKelvin);
            AssertEx.EqualTolerance(1, quantity01.KilojoulesPerMoleKelvin, KilojoulesPerMoleKelvinTolerance);
            Assert.Equal(MolarEntropyUnit.KilojoulePerMoleKelvin, quantity01.Unit);

            var quantity02 = MolarEntropy.From(1, MolarEntropyUnit.MegajoulePerMoleKelvin);
            AssertEx.EqualTolerance(1, quantity02.MegajoulesPerMoleKelvin, MegajoulesPerMoleKelvinTolerance);
            Assert.Equal(MolarEntropyUnit.MegajoulePerMoleKelvin, quantity02.Unit);

        }

        [Fact]
        public void FromJoulesPerMoleKelvin_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MolarEntropy.FromJoulesPerMoleKelvin(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => MolarEntropy.FromJoulesPerMoleKelvin(double.NegativeInfinity));
        }

        [Fact]
        public void FromJoulesPerMoleKelvin_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MolarEntropy.FromJoulesPerMoleKelvin(double.NaN));
        }

        [Fact]
        public void As()
        {
            var joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            AssertEx.EqualTolerance(JoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.As(MolarEntropyUnit.JoulePerMoleKelvin), JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(KilojoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.As(MolarEntropyUnit.KilojoulePerMoleKelvin), KilojoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(MegajoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.As(MolarEntropyUnit.MegajoulePerMoleKelvin), MegajoulesPerMoleKelvinTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new MolarEntropy(value: 1, unit: MolarEntropy.BaseUnit);
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
            var joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);

            var joulepermolekelvinQuantity = joulepermolekelvin.ToUnit(MolarEntropyUnit.JoulePerMoleKelvin);
            AssertEx.EqualTolerance(JoulesPerMoleKelvinInOneJoulePerMoleKelvin, (double)joulepermolekelvinQuantity.Value, JoulesPerMoleKelvinTolerance);
            Assert.Equal(MolarEntropyUnit.JoulePerMoleKelvin, joulepermolekelvinQuantity.Unit);

            var kilojoulepermolekelvinQuantity = joulepermolekelvin.ToUnit(MolarEntropyUnit.KilojoulePerMoleKelvin);
            AssertEx.EqualTolerance(KilojoulesPerMoleKelvinInOneJoulePerMoleKelvin, (double)kilojoulepermolekelvinQuantity.Value, KilojoulesPerMoleKelvinTolerance);
            Assert.Equal(MolarEntropyUnit.KilojoulePerMoleKelvin, kilojoulepermolekelvinQuantity.Unit);

            var megajoulepermolekelvinQuantity = joulepermolekelvin.ToUnit(MolarEntropyUnit.MegajoulePerMoleKelvin);
            AssertEx.EqualTolerance(MegajoulesPerMoleKelvinInOneJoulePerMoleKelvin, (double)megajoulepermolekelvinQuantity.Value, MegajoulesPerMoleKelvinTolerance);
            Assert.Equal(MolarEntropyUnit.MegajoulePerMoleKelvin, megajoulepermolekelvinQuantity.Unit);
        }

        [Fact]
        public void ToUnit_WithBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = MolarEntropy.FromJoulesPerMoleKelvin(1).ToUnit(MolarEntropy.BaseUnit);
            Assert.Equal(MolarEntropy.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            AssertEx.EqualTolerance(1, MolarEntropy.FromJoulesPerMoleKelvin(joulepermolekelvin.JoulesPerMoleKelvin).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(1, MolarEntropy.FromKilojoulesPerMoleKelvin(joulepermolekelvin.KilojoulesPerMoleKelvin).JoulesPerMoleKelvin, KilojoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(1, MolarEntropy.FromMegajoulesPerMoleKelvin(joulepermolekelvin.MegajoulesPerMoleKelvin).JoulesPerMoleKelvin, MegajoulesPerMoleKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MolarEntropy v = MolarEntropy.FromJoulesPerMoleKelvin(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(2, (MolarEntropy.FromJoulesPerMoleKelvin(3)-v).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(2, (MolarEntropy.FromJoulesPerMoleKelvin(10)/5).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(2, MolarEntropy.FromJoulesPerMoleKelvin(10)/MolarEntropy.FromJoulesPerMoleKelvin(5), JoulesPerMoleKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MolarEntropy oneJoulePerMoleKelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            MolarEntropy twoJoulesPerMoleKelvin = MolarEntropy.FromJoulesPerMoleKelvin(2);

            Assert.True(oneJoulePerMoleKelvin < twoJoulesPerMoleKelvin);
            Assert.True(oneJoulePerMoleKelvin <= twoJoulesPerMoleKelvin);
            Assert.True(twoJoulesPerMoleKelvin > oneJoulePerMoleKelvin);
            Assert.True(twoJoulesPerMoleKelvin >= oneJoulePerMoleKelvin);

            Assert.False(oneJoulePerMoleKelvin > twoJoulesPerMoleKelvin);
            Assert.False(oneJoulePerMoleKelvin >= twoJoulesPerMoleKelvin);
            Assert.False(twoJoulesPerMoleKelvin < oneJoulePerMoleKelvin);
            Assert.False(twoJoulesPerMoleKelvin <= oneJoulePerMoleKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.Equal(0, joulepermolekelvin.CompareTo(joulepermolekelvin));
            Assert.True(joulepermolekelvin.CompareTo(MolarEntropy.Zero) > 0);
            Assert.True(MolarEntropy.Zero.CompareTo(joulepermolekelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.Throws<ArgumentException>(() => joulepermolekelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.Throws<ArgumentNullException>(() => joulepermolekelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = MolarEntropy.FromJoulesPerMoleKelvin(1);
            var b = MolarEntropy.FromJoulesPerMoleKelvin(2);

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
            var a = MolarEntropy.FromJoulesPerMoleKelvin(1);
            var b = MolarEntropy.FromJoulesPerMoleKelvin(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = MolarEntropy.FromJoulesPerMoleKelvin(1);
            object b = MolarEntropy.FromJoulesPerMoleKelvin(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.True(v.Equals(MolarEntropy.FromJoulesPerMoleKelvin(1), JoulesPerMoleKelvinTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(MolarEntropy.Zero, JoulesPerMoleKelvinTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(MolarEntropy.FromJoulesPerMoleKelvin(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.False(joulepermolekelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.False(joulepermolekelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MolarEntropyUnit.Undefined, MolarEntropy.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MolarEntropyUnit)).Cast<MolarEntropyUnit>();
            foreach(var unit in units)
            {
                if(unit == MolarEntropyUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(MolarEntropy.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 J/(mol*K)", new MolarEntropy(1, MolarEntropyUnit.JoulePerMoleKelvin).ToString());
                Assert.Equal("1 kJ/(mol*K)", new MolarEntropy(1, MolarEntropyUnit.KilojoulePerMoleKelvin).ToString());
                Assert.Equal("1 MJ/(mol*K)", new MolarEntropy(1, MolarEntropyUnit.MegajoulePerMoleKelvin).ToString());
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

            Assert.Equal("1 J/(mol*K)", new MolarEntropy(1, MolarEntropyUnit.JoulePerMoleKelvin).ToString(swedishCulture));
            Assert.Equal("1 kJ/(mol*K)", new MolarEntropy(1, MolarEntropyUnit.KilojoulePerMoleKelvin).ToString(swedishCulture));
            Assert.Equal("1 MJ/(mol*K)", new MolarEntropy(1, MolarEntropyUnit.MegajoulePerMoleKelvin).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 J/(mol*K)", new MolarEntropy(0.123456, MolarEntropyUnit.JoulePerMoleKelvin).ToString("s1"));
                Assert.Equal("0.12 J/(mol*K)", new MolarEntropy(0.123456, MolarEntropyUnit.JoulePerMoleKelvin).ToString("s2"));
                Assert.Equal("0.123 J/(mol*K)", new MolarEntropy(0.123456, MolarEntropyUnit.JoulePerMoleKelvin).ToString("s3"));
                Assert.Equal("0.1235 J/(mol*K)", new MolarEntropy(0.123456, MolarEntropyUnit.JoulePerMoleKelvin).ToString("s4"));
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
            Assert.Equal("0.1 J/(mol*K)", new MolarEntropy(0.123456, MolarEntropyUnit.JoulePerMoleKelvin).ToString("s1", culture));
            Assert.Equal("0.12 J/(mol*K)", new MolarEntropy(0.123456, MolarEntropyUnit.JoulePerMoleKelvin).ToString("s2", culture));
            Assert.Equal("0.123 J/(mol*K)", new MolarEntropy(0.123456, MolarEntropyUnit.JoulePerMoleKelvin).ToString("s3", culture));
            Assert.Equal("0.1235 J/(mol*K)", new MolarEntropy(0.123456, MolarEntropyUnit.JoulePerMoleKelvin).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(MolarEntropy)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(MolarEntropyUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal(QuantityType.MolarEntropy, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal(MolarEntropy.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal(MolarEntropy.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(1.0);
            Assert.Equal(new {MolarEntropy.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = MolarEntropy.FromJoulesPerMoleKelvin(value);
            Assert.Equal(MolarEntropy.FromJoulesPerMoleKelvin(-value), -quantity);
        }
    }
}

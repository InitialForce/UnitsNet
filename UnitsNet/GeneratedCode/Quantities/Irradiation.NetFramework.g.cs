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
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Irradiation is the process by which an object is exposed to radiation. The exposure can originate from various sources, including natural sources.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Irradiation
    /// </remarks>
    public partial struct Irradiation : IQuantity<IrradiationUnit>, IEquatable<Irradiation>, IComparable, IComparable<Irradiation>, IConvertible
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly IrradiationUnit? _unit;

        static Irradiation()
        {
            BaseDimensions = new BaseDimensions(0, 1, -2, 0, 0, 0, 0);

            Info = new QuantityInfo<IrradiationUnit>(QuantityType.Irradiation,
                new UnitInfo<IrradiationUnit>[] {
                    new UnitInfo<IrradiationUnit>(IrradiationUnit.JoulePerSquareCentimeter, BaseUnits.Undefined),
                    new UnitInfo<IrradiationUnit>(IrradiationUnit.JoulePerSquareMeter, BaseUnits.Undefined),
                    new UnitInfo<IrradiationUnit>(IrradiationUnit.JoulePerSquareMillimeter, BaseUnits.Undefined),
                    new UnitInfo<IrradiationUnit>(IrradiationUnit.KilojoulePerSquareMeter, BaseUnits.Undefined),
                    new UnitInfo<IrradiationUnit>(IrradiationUnit.KilowattHourPerSquareMeter, BaseUnits.Undefined),
                    new UnitInfo<IrradiationUnit>(IrradiationUnit.WattHourPerSquareMeter, BaseUnits.Undefined),
                },
                BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Irradiation(double numericValue, IrradiationUnit unit)
        {
            if(unit == IrradiationUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = unit;
        }

        public Irradiation(double numericValue, UnitSystem unitSystem)
        {
            if(unitSystem == null) throw new ArgumentNullException(nameof(unitSystem));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = GetUnitForBaseUnits(unitSystem.BaseUnits);
        }

        public Irradiation(double numericValue, BaseUnits baseUnits)
        {
            if(baseUnits == null) throw new ArgumentNullException(nameof(baseUnits));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = GetUnitForBaseUnits(baseUnits);
        }

        #region Static Properties

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<IrradiationUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Irradiation, which is JoulePerSquareMeter. All conversions go via this value.
        /// </summary>
        public static IrradiationUnit BaseUnit { get; } = IrradiationUnit.JoulePerSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Irradiation
        /// </summary>
        public static Irradiation MaxValue { get; } = new Irradiation(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Irradiation
        /// </summary>
        public static Irradiation MinValue { get; } = new Irradiation(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.Irradiation;

        /// <summary>
        ///     All units of measurement for the Irradiation quantity.
        /// </summary>
        public static IrradiationUnit[] Units { get; } = Enum.GetValues(typeof(IrradiationUnit)).Cast<IrradiationUnit>().Except(new IrradiationUnit[]{ IrradiationUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit JoulePerSquareMeter.
        /// </summary>
        public static Irradiation Zero { get; } = new Irradiation(0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc cref="IQuantity.Unit"/>
        Enum IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public IrradiationUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        public QuantityInfo<IrradiationUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Irradiation.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Irradiation.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get Irradiation in JoulesPerSquareCentimeter.
        /// </summary>
        public double JoulesPerSquareCentimeter => As(IrradiationUnit.JoulePerSquareCentimeter);

        /// <summary>
        ///     Get Irradiation in JoulesPerSquareMeter.
        /// </summary>
        public double JoulesPerSquareMeter => As(IrradiationUnit.JoulePerSquareMeter);

        /// <summary>
        ///     Get Irradiation in JoulesPerSquareMillimeter.
        /// </summary>
        public double JoulesPerSquareMillimeter => As(IrradiationUnit.JoulePerSquareMillimeter);

        /// <summary>
        ///     Get Irradiation in KilojoulesPerSquareMeter.
        /// </summary>
        public double KilojoulesPerSquareMeter => As(IrradiationUnit.KilojoulePerSquareMeter);

        /// <summary>
        ///     Get Irradiation in KilowattHoursPerSquareMeter.
        /// </summary>
        public double KilowattHoursPerSquareMeter => As(IrradiationUnit.KilowattHourPerSquareMeter);

        /// <summary>
        ///     Get Irradiation in WattHoursPerSquareMeter.
        /// </summary>
        public double WattHoursPerSquareMeter => As(IrradiationUnit.WattHourPerSquareMeter);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(IrradiationUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(IrradiationUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Irradiation from JoulesPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromJoulesPerSquareCentimeter(QuantityValue joulespersquarecentimeter)
        {
            double value = (double) joulespersquarecentimeter;
            return new Irradiation(value, IrradiationUnit.JoulePerSquareCentimeter);
        }
        /// <summary>
        ///     Get Irradiation from JoulesPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromJoulesPerSquareMeter(QuantityValue joulespersquaremeter)
        {
            double value = (double) joulespersquaremeter;
            return new Irradiation(value, IrradiationUnit.JoulePerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiation from JoulesPerSquareMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromJoulesPerSquareMillimeter(QuantityValue joulespersquaremillimeter)
        {
            double value = (double) joulespersquaremillimeter;
            return new Irradiation(value, IrradiationUnit.JoulePerSquareMillimeter);
        }
        /// <summary>
        ///     Get Irradiation from KilojoulesPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromKilojoulesPerSquareMeter(QuantityValue kilojoulespersquaremeter)
        {
            double value = (double) kilojoulespersquaremeter;
            return new Irradiation(value, IrradiationUnit.KilojoulePerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiation from KilowattHoursPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromKilowattHoursPerSquareMeter(QuantityValue kilowatthourspersquaremeter)
        {
            double value = (double) kilowatthourspersquaremeter;
            return new Irradiation(value, IrradiationUnit.KilowattHourPerSquareMeter);
        }
        /// <summary>
        ///     Get Irradiation from WattHoursPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Irradiation FromWattHoursPerSquareMeter(QuantityValue watthourspersquaremeter)
        {
            double value = (double) watthourspersquaremeter;
            return new Irradiation(value, IrradiationUnit.WattHourPerSquareMeter);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="IrradiationUnit" /> to <see cref="Irradiation" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Irradiation unit value.</returns>
        public static Irradiation From(QuantityValue value, IrradiationUnit fromUnit)
        {
            return new Irradiation((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Irradiation Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static Irradiation Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            return QuantityParser.Default.Parse<Irradiation, IrradiationUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Irradiation result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out Irradiation result)
        {
            return QuantityParser.Default.TryParse<Irradiation, IrradiationUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static IrradiationUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static IrradiationUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            return UnitParser.Default.Parse<IrradiationUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out IrradiationUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, IFormatProvider provider, out IrradiationUnit unit)
        {
            return UnitParser.Default.TryParse<IrradiationUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        public static Irradiation operator -(Irradiation right)
        {
            return new Irradiation(-right.Value, right.Unit);
        }

        public static Irradiation operator +(Irradiation left, Irradiation right)
        {
            return new Irradiation(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Irradiation operator -(Irradiation left, Irradiation right)
        {
            return new Irradiation(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Irradiation operator *(double left, Irradiation right)
        {
            return new Irradiation(left * right.Value, right.Unit);
        }

        public static Irradiation operator *(Irradiation left, double right)
        {
            return new Irradiation(left.Value * right, left.Unit);
        }

        public static Irradiation operator /(Irradiation left, double right)
        {
            return new Irradiation(left.Value / right, left.Unit);
        }

        public static double operator /(Irradiation left, Irradiation right)
        {
            return left.JoulesPerSquareMeter / right.JoulesPerSquareMeter;
        }

        #endregion

        #region Equality / IComparable

        public static bool operator <=(Irradiation left, Irradiation right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Irradiation left, Irradiation right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Irradiation left, Irradiation right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Irradiation left, Irradiation right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        public static bool operator ==(Irradiation left, Irradiation right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Irradiation left, Irradiation right)
        {
            return !(left == right);
        }

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Irradiation objIrradiation)) throw new ArgumentException("Expected type Irradiation.", nameof(obj));

            return CompareTo(objIrradiation);
        }

        public int CompareTo(Irradiation other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is Irradiation objIrradiation))
                return false;

            return Equals(objIrradiation);
        }

        public bool Equals(Irradiation other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Irradiation within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Irradiation other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Irradiation.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(Enum unit) => As((IrradiationUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(IrradiationUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        public double As(Enum unit) => As((IrradiationUnit) unit);

        /// <summary>
        ///     Converts this Irradiation to another Irradiation with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Irradiation with the specified unit.</returns>
        public Irradiation ToUnit(IrradiationUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Irradiation(convertedValue, unit);
        }

        IQuantity<IrradiationUnit> IQuantity<IrradiationUnit>.ToUnit(IrradiationUnit unit) => ToUnit(unit);

        public IQuantity ToUnit(Enum unit) => ToUnit((IrradiationUnit) unit);

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case IrradiationUnit.JoulePerSquareCentimeter: return _value*1e4;
                case IrradiationUnit.JoulePerSquareMeter: return _value;
                case IrradiationUnit.JoulePerSquareMillimeter: return _value*1e6;
                case IrradiationUnit.KilojoulePerSquareMeter: return (_value) * 1e3d;
                case IrradiationUnit.KilowattHourPerSquareMeter: return (_value*3600d) * 1e3d;
                case IrradiationUnit.WattHourPerSquareMeter: return _value*3600d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(IrradiationUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case IrradiationUnit.JoulePerSquareCentimeter: return baseUnitValue/1e4;
                case IrradiationUnit.JoulePerSquareMeter: return baseUnitValue;
                case IrradiationUnit.JoulePerSquareMillimeter: return baseUnitValue/1e6;
                case IrradiationUnit.KilojoulePerSquareMeter: return (baseUnitValue) / 1e3d;
                case IrradiationUnit.KilowattHourPerSquareMeter: return (baseUnitValue/3600d) / 1e3d;
                case IrradiationUnit.WattHourPerSquareMeter: return baseUnitValue/3600d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        public static IrradiationUnit GetUnitForBaseUnits(BaseUnits baseUnits)
        {
            var unit = Info.UnitInfos.Where((unitInfo) => unitInfo.BaseUnits.EqualsIgnoreUndefined(baseUnits)).FirstOrDefault();
            if(unit == null)
                throw new NotImplementedException($"No LengthUnit was found for the given BaseUnits.");

            return unit.Value;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider)
        {
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Irradiation)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Irradiation)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Irradiation)} to DateTime is not supported.");
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(_value);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(_value);
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(_value);
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(_value);
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(_value);
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(_value);
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(_value);
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return ToString(provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if(conversionType == typeof(Irradiation))
                return this;
            else if(conversionType == typeof(IrradiationUnit))
                return Unit;
            else if(conversionType == typeof(QuantityType))
                return Irradiation.QuantityType;
            else if(conversionType == typeof(BaseDimensions))
                return Irradiation.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(Irradiation)} to {conversionType} is not supported.");
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(_value);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(_value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(_value);
        }

        #endregion
    }
}

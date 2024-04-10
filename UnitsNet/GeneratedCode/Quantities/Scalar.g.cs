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
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;
using System.Numerics;

#nullable enable

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     A way of representing a number of items.
    /// </summary>
    [DataContract]
    public readonly partial struct Scalar :
        IArithmeticQuantity<Scalar, ScalarUnit>,
        IComparable,
        IComparable<Scalar>,
        IConvertible,
        IEquatable<Scalar>,
        IFormattable
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Value", Order = 1)]
        private readonly QuantityValue _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Unit", Order = 2)]
        private readonly ScalarUnit? _unit;

        static Scalar()
        {
            BaseDimensions = BaseDimensions.Dimensionless;
            BaseUnit = ScalarUnit.Amount;
            Units = Enum.GetValues(typeof(ScalarUnit)).Cast<ScalarUnit>().ToArray();
            Zero = new Scalar(0, BaseUnit);
            Info = new QuantityInfo<ScalarUnit>("Scalar",
                new UnitInfo<ScalarUnit>[]
                {
                    new UnitInfo<ScalarUnit>(ScalarUnit.Amount, "Amount", BaseUnits.Undefined, "Scalar"),
                },
                BaseUnit, Zero, BaseDimensions);

            DefaultConversionFunctions = new UnitConverter();
            RegisterDefaultConversions(DefaultConversionFunctions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public Scalar(QuantityValue value, ScalarUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        /// Creates an instance of the quantity with the given numeric value in units compatible with the given <see cref="UnitSystem"/>.
        /// If multiple compatible units were found, the first match is used.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unitSystem">The unit system to create the quantity with.</param>
        /// <exception cref="ArgumentNullException">The given <see cref="UnitSystem"/> is null.</exception>
        /// <exception cref="ArgumentException">No unit was found for the given <see cref="UnitSystem"/>.</exception>
        public Scalar(QuantityValue value, UnitSystem unitSystem)
        {
            if (unitSystem is null) throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);
            var firstUnitInfo = unitInfos.FirstOrDefault();

            _value = value;
            _unit = firstUnitInfo?.Value ?? throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="Scalar" /> instances.
        /// </summary>
        public static UnitConverter DefaultConversionFunctions { get; }

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<ScalarUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Scalar, which is Amount. All conversions go via this value.
        /// </summary>
        public static ScalarUnit BaseUnit { get; }

        /// <summary>
        ///     All units of measurement for the Scalar quantity.
        /// </summary>
        public static ScalarUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Amount.
        /// </summary>
        public static Scalar Zero { get; }

        /// <inheritdoc cref="Zero"/>
        public static Scalar AdditiveIdentity => Zero;

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public QuantityValue Value => _value;

        /// <inheritdoc />
        QuantityValue IQuantity.Value => _value;

        Enum IQuantity.Unit => Unit;

        /// <inheritdoc />
        public ScalarUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<ScalarUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Scalar.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ScalarUnit.Amount"/>
        /// </summary>
        public QuantityValue Amount => As(ScalarUnit.Amount);

        #endregion

        #region Static Methods

        /// <summary>
        /// Registers the default conversion functions in the given <see cref="UnitConverter"/> instance.
        /// </summary>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to register the default conversion functions in.</param>
        internal static void RegisterDefaultConversions(UnitConverter unitConverter)
        {
            // Register in unit converter: ScalarUnit -> BaseUnit

            // Register in unit converter: BaseUnit <-> BaseUnit
            unitConverter.SetConversionFunction<Scalar>(ScalarUnit.Amount, ScalarUnit.Amount, quantity => quantity);

            // Register in unit converter: BaseUnit -> ScalarUnit
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(ScalarUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(ScalarUnit unit, IFormatProvider? provider)
        {
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Scalar"/> from <see cref="ScalarUnit.Amount"/>.
        /// </summary>
        public static Scalar FromAmount(QuantityValue value)
        {
            return new Scalar(value, ScalarUnit.Amount);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ScalarUnit" /> to <see cref="Scalar" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Scalar unit value.</returns>
        public static Scalar From(QuantityValue value, ScalarUnit fromUnit)
        {
            return new Scalar(value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
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
        public static Scalar Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static Scalar Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<Scalar, ScalarUnit>(
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
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        public static bool TryParse(string? str, out Scalar result)
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
        ///     Length.Parse("5.5 m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static bool TryParse(string? str, IFormatProvider? provider, out Scalar result)
        {
            return QuantityParser.Default.TryParse<Scalar, ScalarUnit>(
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
        ///     Length.ParseUnit("m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ScalarUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <example>
        ///     Length.ParseUnit("m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ScalarUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse<ScalarUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.ScalarUnit)"/>
        public static bool TryParseUnit(string str, out ScalarUnit unit)
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
        ///     Length.TryParseUnit("m", CultureInfo.GetCultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static bool TryParseUnit(string str, IFormatProvider? provider, out ScalarUnit unit)
        {
            return UnitParser.Default.TryParse<ScalarUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static Scalar operator -(Scalar right)
        {
            return new Scalar(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Scalar"/> from adding two <see cref="Scalar"/>.</summary>
        public static Scalar operator +(Scalar left, Scalar right)
        {
            return new Scalar(left.Value + right.ToUnit(left.Unit).Value, left.Unit);
        }

        /// <summary>Get <see cref="Scalar"/> from subtracting two <see cref="Scalar"/>.</summary>
        public static Scalar operator -(Scalar left, Scalar right)
        {
            return new Scalar(left.Value - right.ToUnit(left.Unit).Value, left.Unit);
        }

        /// <summary>Get <see cref="Scalar"/> from multiplying value and <see cref="Scalar"/>.</summary>
        public static Scalar operator *(QuantityValue left, Scalar right)
        {
            return new Scalar(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Scalar"/> from multiplying value and <see cref="Scalar"/>.</summary>
        public static Scalar operator *(Scalar left, QuantityValue right)
        {
            return new Scalar(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="Scalar"/> from dividing <see cref="Scalar"/> by value.</summary>
        public static Scalar operator /(Scalar left, QuantityValue right)
        {
            return new Scalar(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="Scalar"/> by <see cref="Scalar"/>.</summary>
        public static QuantityValue operator /(Scalar left, Scalar right)
        {
            return left.Amount / right.Amount;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(Scalar left, Scalar right)
        {
            return left.Value <= right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(Scalar left, Scalar right)
        {
            return left.Value >= right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(Scalar left, Scalar right)
        {
            return left.Value < right.ToUnit(left.Unit).Value;
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(Scalar left, Scalar right)
        {
            return left.Value > right.ToUnit(left.Unit).Value;
        }

        /// <summary>Indicates strict equality of two <see cref="Scalar"/> quantities.</summary>
        public static bool operator ==(Scalar left, Scalar right)
        {
            return left.Equals(right);
        }

        /// <summary>Indicates strict inequality of two <see cref="Scalar"/> quantities.</summary>
        public static bool operator !=(Scalar left, Scalar right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="Scalar"/> quantities.</summary>
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Scalar otherQuantity))
                return false;

            return Equals(otherQuantity);
        }

        /// <inheritdoc />
        /// <summary>Indicates strict equality of two <see cref="Scalar"/> quantities.</summary>
        public bool Equals(Scalar other)
        {
            return _value.Equals(other.As(this.Unit));
        }

        /// <summary>Compares the current <see cref="Scalar"/> with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other when converted to the same unit.</summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <exception cref="T:System.ArgumentException">
        ///    <paramref name="obj" /> is not the same type as this instance.
        /// </exception>
        /// <returns>A value that indicates the relative order of the quantities being compared. The return value has these meanings:
        ///     <list type="table">
        ///         <listheader><term> Value</term><description> Meaning</description></listheader>
        ///         <item><term> Less than zero</term><description> This instance precedes <paramref name="obj" /> in the sort order.</description></item>
        ///         <item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="obj" />.</description></item>
        ///         <item><term> Greater than zero</term><description> This instance follows <paramref name="obj" /> in the sort order.</description></item>
        ///     </list>
        /// </returns>
        public int CompareTo(object? obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is Scalar otherQuantity)) throw new ArgumentException("Expected type Scalar.", nameof(obj));

            return CompareTo(otherQuantity);
        }

        /// <summary>Compares the current <see cref="Scalar"/> with another <see cref="Scalar"/> and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other when converted to the same unit.</summary>
        /// <param name="other">A quantity to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the quantities being compared. The return value has these meanings:
        ///     <list type="table">
        ///         <listheader><term> Value</term><description> Meaning</description></listheader>
        ///         <item><term> Less than zero</term><description> This instance precedes <paramref name="other" /> in the sort order.</description></item>
        ///         <item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="other" />.</description></item>
        ///         <item><term> Greater than zero</term><description> This instance follows <paramref name="other" /> in the sort order.</description></item>
        ///     </list>
        /// </returns>
        public int CompareTo(Scalar other)
        {
            return _value.CompareTo(other.ToUnit(this.Unit).Value);
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Scalar within the given absolute or relative tolerance.
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
        ///     of floating-point operations and using double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        [Obsolete("Use Equals(Scalar other, Scalar tolerance) instead, to check equality across units and to specify the max tolerance for rounding errors due to floating-point arithmetic when converting between units.")]
        public bool Equals(Scalar other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException(nameof(tolerance), "Tolerance must be greater than or equal to 0.");

            return UnitsNet.QuantityValueComparison.Equals(
                referenceValue: this.Value,
                otherValue: other.As(this.Unit),
                tolerance: (QuantityValue)tolerance,
                comparisonType: ComparisonType.Absolute);
        }

        /// <inheritdoc />
        public bool Equals(IQuantity? other, IQuantity tolerance)
        {
            return other is Scalar otherTyped
                   && (tolerance is Scalar toleranceTyped
                       ? true
                       : throw new ArgumentException($"Tolerance quantity ({tolerance.QuantityInfo.Name}) did not match the other quantities of type 'Scalar'.", nameof(tolerance)))
                   && Equals(otherTyped, toleranceTyped);
        }

        /// <inheritdoc />
        public bool Equals(Scalar other, Scalar tolerance)
        {
            return UnitsNet.QuantityValueComparison.Equals(
                referenceValue: this.Value,
                otherValue: other.As(this.Unit),
                tolerance: tolerance.As(this.Unit),
                comparisonType: ComparisonType.Absolute);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Scalar.</returns>
        public override int GetHashCode()
        {
            var valueInBaseUnit = As(BaseUnit);
            #if NET7_0_OR_GREATER
            return HashCode.Combine(Info.Name, valueInBaseUnit);
            #else
            return new { Info.Name, valueInBaseUnit }.GetHashCode();
            #endif
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public QuantityValue As(ScalarUnit unit)
        {
            if (Unit == unit)
                return Value;

            return ToUnit(unit).Value;
        }

        /// <inheritdoc cref="IQuantity.As(UnitSystem)"/>
        public QuantityValue As(UnitSystem unitSystem)
        {
            if (unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if (firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return As(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        QuantityValue IQuantity.As(Enum unit)
        {
            if (!(unit is ScalarUnit typedUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(ScalarUnit)} is supported.", nameof(unit));

            return As(typedUnit);
        }

        /// <summary>
        ///     Converts this Scalar to another Scalar with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <returns>A Scalar with the specified unit.</returns>
        public Scalar ToUnit(ScalarUnit unit)
        {
            return ToUnit(unit, DefaultConversionFunctions);
        }

        /// <summary>
        ///     Converts this <see cref="Scalar"/> to another <see cref="Scalar"/> using the given <paramref name="unitConverter"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to use for the conversion.</param>
        /// <returns>A Scalar with the specified unit.</returns>
        public Scalar ToUnit(ScalarUnit unit, UnitConverter unitConverter)
        {
            if (TryToUnit(unit, out var converted))
            {
                // Try to convert using the auto-generated conversion methods.
                return converted!.Value;
            }
            else if (unitConverter.TryGetConversionFunction((typeof(Scalar), Unit, typeof(Scalar), unit), out var conversionFunction))
            {
                // See if the unit converter has an extensibility conversion registered.
                return (Scalar)conversionFunction(this);
            }
            else if (Unit != BaseUnit)
            {
                // Conversion to requested unit NOT found. Try to convert to BaseUnit, and then from BaseUnit to requested unit.
                var inBaseUnits = ToUnit(BaseUnit);
                return inBaseUnits.ToUnit(unit);
            }
            else
            {
                // No possible conversion
                throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        /// <summary>
        ///     Attempts to convert this <see cref="Scalar"/> to another <see cref="Scalar"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="converted">The converted <see cref="Scalar"/> in <paramref name="unit"/>, if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        private bool TryToUnit(ScalarUnit unit, [NotNullWhen(true)] out Scalar? converted)
        {
            if (Unit == unit)
            {
                converted = this;
                return true;
            }

            Scalar? convertedOrNull = (Unit, unit) switch
            {
                // ScalarUnit -> BaseUnit

                // BaseUnit -> ScalarUnit

                _ => null
            };

            if (convertedOrNull is null)
            {
                converted = default;
                return false;
            }

            converted = convertedOrNull.Value;
            return true;
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(Enum unit)
        {
            if (!(unit is ScalarUnit typedUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(ScalarUnit)} is supported.", nameof(unit));

            return ToUnit(typedUnit, DefaultConversionFunctions);
        }

        /// <inheritdoc cref="IQuantity.ToUnit(UnitSystem)"/>
        public Scalar ToUnit(UnitSystem unitSystem)
        {
            if (unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if (firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return ToUnit(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <inheritdoc />
        IQuantity<ScalarUnit> IQuantity<ScalarUnit>.ToUnit(ScalarUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        IQuantity<ScalarUnit> IQuantity<ScalarUnit>.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Gets the default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString("g");
        }

        /// <summary>
        ///     Gets the default string representation of value and unit using the given format provider.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public string ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.CurrentCulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentCulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string? format, IFormatProvider? provider)
        {
            return QuantityFormatter.Format<ScalarUnit>(this, format, provider);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(Scalar)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider? provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(Scalar)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider? provider)
        {
            throw new InvalidCastException($"Converting {typeof(Scalar)} to DateTime is not supported.");
        }

        decimal IConvertible.ToDecimal(IFormatProvider? provider)
        {
            return Convert.ToDecimal(_value);
        }

        double IConvertible.ToDouble(IFormatProvider? provider)
        {
            return Convert.ToDouble(_value);
        }

        short IConvertible.ToInt16(IFormatProvider? provider)
        {
            return Convert.ToInt16(_value);
        }

        int IConvertible.ToInt32(IFormatProvider? provider)
        {
            return Convert.ToInt32(_value);
        }

        long IConvertible.ToInt64(IFormatProvider? provider)
        {
            return Convert.ToInt64(_value);
        }

        sbyte IConvertible.ToSByte(IFormatProvider? provider)
        {
            return Convert.ToSByte(_value);
        }

        float IConvertible.ToSingle(IFormatProvider? provider)
        {
            return Convert.ToSingle(_value);
        }

        string IConvertible.ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider? provider)
        {
            if (conversionType == typeof(Scalar))
                return this;
            else if (conversionType == typeof(ScalarUnit))
                return Unit;
            else if (conversionType == typeof(QuantityInfo))
                return Scalar.Info;
            else if (conversionType == typeof(BaseDimensions))
                return Scalar.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(Scalar)} to {conversionType} is not supported.");
        }

        ushort IConvertible.ToUInt16(IFormatProvider? provider)
        {
            return Convert.ToUInt16(_value);
        }

        uint IConvertible.ToUInt32(IFormatProvider? provider)
        {
            return Convert.ToUInt32(_value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider? provider)
        {
            return Convert.ToUInt64(_value);
        }

        #endregion
    }
}

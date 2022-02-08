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
using System.Runtime.Serialization;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

#nullable enable

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In geometry, a solid angle is the two-dimensional angle in three-dimensional space that an object subtends at a point.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Solid_angle
    /// </remarks>
    [DataContract]
    public partial struct SolidAngle : IQuantity<SolidAngleUnit>, IEquatable<SolidAngle>, IComparable, IComparable<SolidAngle>, IConvertible, IFormattable
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Value", Order = 0)]
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Unit", Order = 1)]
        private readonly SolidAngleUnit? _unit;

        static SolidAngle()
        {
            BaseDimensions = BaseDimensions.Dimensionless;
            BaseUnit = SolidAngleUnit.Steradian;
            MaxValue = new SolidAngle(double.MaxValue, BaseUnit);
            MinValue = new SolidAngle(double.MinValue, BaseUnit);
            QuantityType = QuantityType.SolidAngle;
            Units = Enum.GetValues(typeof(SolidAngleUnit)).Cast<SolidAngleUnit>().Except(new SolidAngleUnit[]{ SolidAngleUnit.Undefined }).ToArray();
            Zero = new SolidAngle(0, BaseUnit);
            Info = new QuantityInfo<SolidAngleUnit>("SolidAngle",
                new UnitInfo<SolidAngleUnit>[]
                {
                    new UnitInfo<SolidAngleUnit>(SolidAngleUnit.Steradian, "Steradians", BaseUnits.Undefined),
                },
                BaseUnit, Zero, BaseDimensions, QuantityType.SolidAngle);

            DefaultConversionFunctions = new UnitConverter();

            RegisterDefaultConversions(DefaultConversionFunctions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public SolidAngle(double value, SolidAngleUnit unit)
        {
            if(unit == SolidAngleUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
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
        public SolidAngle(double value, UnitSystem unitSystem)
        {
            if(unitSystem is null) throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);
            var firstUnitInfo = unitInfos.FirstOrDefault();

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = firstUnitInfo?.Value ?? throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="SolidAngle" /> instances.
        /// </summary>
        public static UnitConverter DefaultConversionFunctions { get; }

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<SolidAngleUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of SolidAngle, which is Steradian. All conversions go via this value.
        /// </summary>
        public static SolidAngleUnit BaseUnit { get; }

        /// <summary>
        /// Represents the largest possible value of SolidAngle
        /// </summary>
        [Obsolete("MaxValue and MinValue will be removed. Choose your own value or use nullability for unbounded lower/upper range checks. See discussion in https://github.com/angularsen/UnitsNet/issues/848.")]
        public static SolidAngle MaxValue { get; }

        /// <summary>
        /// Represents the smallest possible value of SolidAngle
        /// </summary>
        [Obsolete("MaxValue and MinValue will be removed. Choose your own value or use nullability for unbounded lower/upper range checks. See discussion in https://github.com/angularsen/UnitsNet/issues/848.")]
        public static SolidAngle MinValue { get; }

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public static QuantityType QuantityType { get; }

        /// <summary>
        ///     All units of measurement for the SolidAngle quantity.
        /// </summary>
        public static SolidAngleUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Steradian.
        /// </summary>
        public static SolidAngle Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        Enum IQuantity.Unit => Unit;

        /// <inheritdoc />
        public SolidAngleUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<SolidAngleUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public QuantityType Type => QuantityType.SolidAngle;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => SolidAngle.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get SolidAngle in Steradians.
        /// </summary>
        public double Steradians => As(SolidAngleUnit.Steradian);

        #endregion

        #region Static Methods

        /// <summary>
        /// Registers the default conversion functions in the given <see cref="UnitConverter"/> instance.
        /// </summary>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to register the default conversion functions in.</param>
        internal static void RegisterDefaultConversions(UnitConverter unitConverter)
        {
            // Register in unit converter: BaseUnit -> SolidAngleUnit
            
            // Register in unit converter: BaseUnit <-> BaseUnit
            unitConverter.SetConversionFunction<SolidAngle>(SolidAngleUnit.Steradian, SolidAngleUnit.Steradian, quantity => quantity);

            // Register in unit converter: SolidAngleUnit -> BaseUnit
        }

        internal static void MapGeneratedLocalizations(UnitAbbreviationsCache unitAbbreviationsCache)
        {
            unitAbbreviationsCache.PerformAbbreviationMapping(SolidAngleUnit.Steradian, new CultureInfo("en-US"), false, true, new string[]{"sr"});
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(SolidAngleUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static string GetAbbreviation(SolidAngleUnit unit, IFormatProvider? provider)
        {
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get SolidAngle from Steradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SolidAngle FromSteradians(QuantityValue steradians)
        {
            double value = (double) steradians;
            return new SolidAngle(value, SolidAngleUnit.Steradian);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="SolidAngleUnit" /> to <see cref="SolidAngle" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>SolidAngle unit value.</returns>
        public static SolidAngle From(QuantityValue value, SolidAngleUnit fromUnit)
        {
            return new SolidAngle((double)value, fromUnit);
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
        public static SolidAngle Parse(string str)
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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static SolidAngle Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<SolidAngle, SolidAngleUnit>(
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
        public static bool TryParse(string? str, out SolidAngle result)
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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static bool TryParse(string? str, IFormatProvider? provider, out SolidAngle result)
        {
            return QuantityParser.Default.TryParse<SolidAngle, SolidAngleUnit>(
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
        public static SolidAngleUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static SolidAngleUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse<SolidAngleUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.SolidAngleUnit)"/>
        public static bool TryParseUnit(string str, out SolidAngleUnit unit)
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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static bool TryParseUnit(string str, IFormatProvider? provider, out SolidAngleUnit unit)
        {
            return UnitParser.Default.TryParse<SolidAngleUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static SolidAngle operator -(SolidAngle right)
        {
            return new SolidAngle(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="SolidAngle"/> from adding two <see cref="SolidAngle"/>.</summary>
        public static SolidAngle operator +(SolidAngle left, SolidAngle right)
        {
            return new SolidAngle(left.Value + right.GetValueAs(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="SolidAngle"/> from subtracting two <see cref="SolidAngle"/>.</summary>
        public static SolidAngle operator -(SolidAngle left, SolidAngle right)
        {
            return new SolidAngle(left.Value - right.GetValueAs(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="SolidAngle"/> from multiplying value and <see cref="SolidAngle"/>.</summary>
        public static SolidAngle operator *(double left, SolidAngle right)
        {
            return new SolidAngle(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="SolidAngle"/> from multiplying value and <see cref="SolidAngle"/>.</summary>
        public static SolidAngle operator *(SolidAngle left, double right)
        {
            return new SolidAngle(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="SolidAngle"/> from dividing <see cref="SolidAngle"/> by value.</summary>
        public static SolidAngle operator /(SolidAngle left, double right)
        {
            return new SolidAngle(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="SolidAngle"/> by <see cref="SolidAngle"/>.</summary>
        public static double operator /(SolidAngle left, SolidAngle right)
        {
            return left.Steradians / right.Steradians;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(SolidAngle left, SolidAngle right)
        {
            return left.Value <= right.GetValueAs(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(SolidAngle left, SolidAngle right)
        {
            return left.Value >= right.GetValueAs(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(SolidAngle left, SolidAngle right)
        {
            return left.Value < right.GetValueAs(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(SolidAngle left, SolidAngle right)
        {
            return left.Value > right.GetValueAs(left.Unit);
        }

        /// <summary>Returns true if exactly equal.</summary>
        /// <remarks>Consider using <see cref="Equals(SolidAngle, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public static bool operator ==(SolidAngle left, SolidAngle right)
        {
            return left.Equals(right);
        }

        /// <summary>Returns true if not exactly equal.</summary>
        /// <remarks>Consider using <see cref="Equals(SolidAngle, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public static bool operator !=(SolidAngle left, SolidAngle right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is SolidAngle objSolidAngle)) throw new ArgumentException("Expected type SolidAngle.", nameof(obj));

            return CompareTo(objSolidAngle);
        }

        /// <inheritdoc />
        public int CompareTo(SolidAngle other)
        {
            return _value.CompareTo(other.GetValueAs(this.Unit));
        }

        /// <inheritdoc />
        /// <remarks>Consider using <see cref="Equals(SolidAngle, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is SolidAngle objSolidAngle))
                return false;

            return Equals(objSolidAngle);
        }

        /// <inheritdoc />
        /// <remarks>Consider using <see cref="Equals(SolidAngle, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public bool Equals(SolidAngle other)
        {
            return _value.Equals(other.GetValueAs(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another SolidAngle within the given absolute or relative tolerance.
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
        public bool Equals(SolidAngle other, double tolerance, ComparisonType comparisonType)
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
        /// <returns>A hash code for the current SolidAngle.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(SolidAngleUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = GetValueAs(unit);
            return Convert.ToDouble(converted);
        }

        /// <inheritdoc cref="IQuantity.As(UnitSystem)"/>
        public double As(UnitSystem unitSystem)
        {
            if(unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if(firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return As(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        double IQuantity.As(Enum unit)
        {
            if(!(unit is SolidAngleUnit unitAsSolidAngleUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(SolidAngleUnit)} is supported.", nameof(unit));

            return As(unitAsSolidAngleUnit);
        }

        /// <summary>
        ///     Converts this SolidAngle to another SolidAngle with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <returns>A SolidAngle with the specified unit.</returns>
        public SolidAngle ToUnit(SolidAngleUnit unit)
        {
            return ToUnit(unit, DefaultConversionFunctions);
        }

        /// <summary>
        ///     Converts this SolidAngle to another SolidAngle using the given <paramref name="unitConverter"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to use for the conversion.</param>
        /// <returns>A SolidAngle with the specified unit.</returns>
        public SolidAngle ToUnit(SolidAngleUnit unit, UnitConverter unitConverter)
        {
            if(Unit == unit)
            {
                // Already in requested units.
                return this;
            }
            else if(unitConverter.TryGetConversionFunction((typeof(SolidAngle), Unit, typeof(SolidAngle), unit), out var conversionFunction))
            {
                // Direct conversion to requested unit found. Return the converted quantity.
                var converted = conversionFunction(this);
                return (SolidAngle)converted;
            }
            else if(Unit != BaseUnit)
            {
                // Direct conversion to requested unit NOT found. Convert to BaseUnit, and then from BaseUnit to requested unit.
                var inBaseUnits = ToUnit(BaseUnit);
                return inBaseUnits.ToUnit(unit);
            }
            else
            {
                throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(Enum unit)
        {
            if(!(unit is SolidAngleUnit unitAsSolidAngleUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(SolidAngleUnit)} is supported.", nameof(unit));

            return ToUnit(unitAsSolidAngleUnit, DefaultConversionFunctions);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(Enum unit, UnitConverter unitConverter)
        {
            if(!(unit is SolidAngleUnit unitAsSolidAngleUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(SolidAngleUnit)} is supported.", nameof(unit));

            return ToUnit(unitAsSolidAngleUnit, unitConverter);
        }

        /// <inheritdoc cref="IQuantity.ToUnit(UnitSystem)"/>
        public SolidAngle ToUnit(UnitSystem unitSystem)
        {
            if(unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if(firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return ToUnit(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <inheritdoc />
        IQuantity<SolidAngleUnit> IQuantity<SolidAngleUnit>.ToUnit(SolidAngleUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        IQuantity<SolidAngleUnit> IQuantity<SolidAngleUnit>.ToUnit(SolidAngleUnit unit, UnitConverter unitConverter) => ToUnit(unit, unitConverter);

        /// <inheritdoc />
        IQuantity<SolidAngleUnit> IQuantity<SolidAngleUnit>.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        private double GetValueAs(SolidAngleUnit unit)
        {
            var converted = ToUnit(unit);
            return (double)converted.Value;
        }

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
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public string ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        [Obsolete(@"This method is deprecated and will be removed at a future release. Please use ToString(""s2"") or ToString(""s2"", provider) where 2 is an example of the number passed to significantDigitsAfterRadix.")]
        public string ToString(IFormatProvider? provider, int significantDigitsAfterRadix)
        {
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        [Obsolete("This method is deprecated and will be removed at a future release. Please use string.Format().")]
        public string ToString(IFormatProvider? provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? CultureInfo.CurrentUICulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.CurrentUICulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentUICulture);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentUICulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format, IFormatProvider? provider)
        {
            return QuantityFormatter.Format<SolidAngleUnit>(this, format, provider);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(SolidAngle)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(SolidAngle)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(SolidAngle)} to DateTime is not supported.");
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
            return ToString("g", provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if(conversionType == typeof(SolidAngle))
                return this;
            else if(conversionType == typeof(SolidAngleUnit))
                return Unit;
            else if(conversionType == typeof(QuantityType))
                return SolidAngle.QuantityType;
            else if(conversionType == typeof(QuantityInfo))
                return SolidAngle.Info;
            else if(conversionType == typeof(BaseDimensions))
                return SolidAngle.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(SolidAngle)} to {conversionType} is not supported.");
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

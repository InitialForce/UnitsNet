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
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Luminance is a photometric measure of the luminous intensity per unit area of light travelling in a given direction.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Luminance
    /// </remarks>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class Luminance : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly LuminanceUnit? _unit;

        static Luminance()
        {
            BaseDimensions = new BaseDimensions(-2, 0, 0, 0, 0, 0, 1);
            BaseUnit = LuminanceUnit.CandelaPerSquareMeter;
            MaxValue = new Luminance(double.MaxValue, BaseUnit);
            MinValue = new Luminance(double.MinValue, BaseUnit);
            QuantityType = QuantityType.Luminance;
            Units = Enum.GetValues(typeof(LuminanceUnit)).Cast<LuminanceUnit>().Except(new LuminanceUnit[]{ LuminanceUnit.Undefined }).ToArray();
            Zero = new Luminance(0, BaseUnit);
            Info = new QuantityInfo(QuantityType.Luminance, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit CandelaPerSquareMeter.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public Luminance()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private Luminance(double value, LuminanceUnit unit)
        {
            if (unit == LuminanceUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Luminance, which is CandelaPerSquareMeter. All conversions go via this value.
        /// </summary>
        public static LuminanceUnit BaseUnit { get; }

        /// <summary>
        /// Represents the largest possible value of Luminance
        /// </summary>
        public static Luminance MaxValue { get; }

        /// <summary>
        /// Represents the smallest possible value of Luminance
        /// </summary>
        public static Luminance MinValue { get; }

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public static QuantityType QuantityType { get; }

        /// <summary>
        ///     All units of measurement for the Luminance quantity.
        /// </summary>
        public static LuminanceUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit CandelaPerSquareMeter.
        /// </summary>
        public static Luminance Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public LuminanceUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public QuantityType Type => Luminance.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Luminance.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminanceUnit.CandelaPerSquareFoot"/>
        /// </summary>
        public double CandelasPerSquareFoot => As(LuminanceUnit.CandelaPerSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminanceUnit.CandelaPerSquareInch"/>
        /// </summary>
        public double CandelasPerSquareInch => As(LuminanceUnit.CandelaPerSquareInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminanceUnit.CandelaPerSquareMeter"/>
        /// </summary>
        public double CandelasPerSquareMeter => As(LuminanceUnit.CandelaPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminanceUnit.CenticandelaPerSquareMeter"/>
        /// </summary>
        public double CenticandelasPerSquareMeter => As(LuminanceUnit.CenticandelaPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminanceUnit.DecicandelaPerSquareMeter"/>
        /// </summary>
        public double DecicandelasPerSquareMeter => As(LuminanceUnit.DecicandelaPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminanceUnit.KilocandelaPerSquareMeter"/>
        /// </summary>
        public double KilocandelasPerSquareMeter => As(LuminanceUnit.KilocandelaPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminanceUnit.MicrocandelaPerSquareMeter"/>
        /// </summary>
        public double MicrocandelasPerSquareMeter => As(LuminanceUnit.MicrocandelaPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminanceUnit.MillicandelaPerSquareMeter"/>
        /// </summary>
        public double MillicandelasPerSquareMeter => As(LuminanceUnit.MillicandelaPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminanceUnit.NanocandelaPerSquareMeter"/>
        /// </summary>
        public double NanocandelasPerSquareMeter => As(LuminanceUnit.NanocandelaPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminanceUnit.Nit"/>
        /// </summary>
        public double Nits => As(LuminanceUnit.Nit);

        #endregion

        #region Static Methods

        internal static void MapGeneratedLocalizations(UnitAbbreviationsCache unitAbbreviationsCache)
        {
            unitAbbreviationsCache.PerformAbbreviationMapping(LuminanceUnit.CandelaPerSquareFoot, new CultureInfo("en-US"), false, true, new string[]{"Cd/ft²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(LuminanceUnit.CandelaPerSquareInch, new CultureInfo("en-US"), false, true, new string[]{"Cd/in²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(LuminanceUnit.CandelaPerSquareMeter, new CultureInfo("en-US"), false, true, new string[]{"Cd/m²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(LuminanceUnit.CenticandelaPerSquareMeter, new CultureInfo("en-US"), false, true, new string[]{"cCd/m²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(LuminanceUnit.DecicandelaPerSquareMeter, new CultureInfo("en-US"), false, true, new string[]{"dCd/m²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(LuminanceUnit.KilocandelaPerSquareMeter, new CultureInfo("en-US"), false, true, new string[]{"kCd/m²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(LuminanceUnit.MicrocandelaPerSquareMeter, new CultureInfo("en-US"), false, true, new string[]{"µCd/m²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(LuminanceUnit.MillicandelaPerSquareMeter, new CultureInfo("en-US"), false, true, new string[]{"mCd/m²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(LuminanceUnit.NanocandelaPerSquareMeter, new CultureInfo("en-US"), false, true, new string[]{"nCd/m²"});
            unitAbbreviationsCache.PerformAbbreviationMapping(LuminanceUnit.Nit, new CultureInfo("en-US"), false, true, new string[]{"nt"});
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(LuminanceUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(LuminanceUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Luminance"/> from <see cref="LuminanceUnit.CandelaPerSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminance FromCandelasPerSquareFoot(double candelaspersquarefoot)
        {
            double value = (double) candelaspersquarefoot;
            return new Luminance(value, LuminanceUnit.CandelaPerSquareFoot);
        }

        /// <summary>
        ///     Creates a <see cref="Luminance"/> from <see cref="LuminanceUnit.CandelaPerSquareInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminance FromCandelasPerSquareInch(double candelaspersquareinch)
        {
            double value = (double) candelaspersquareinch;
            return new Luminance(value, LuminanceUnit.CandelaPerSquareInch);
        }

        /// <summary>
        ///     Creates a <see cref="Luminance"/> from <see cref="LuminanceUnit.CandelaPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminance FromCandelasPerSquareMeter(double candelaspersquaremeter)
        {
            double value = (double) candelaspersquaremeter;
            return new Luminance(value, LuminanceUnit.CandelaPerSquareMeter);
        }

        /// <summary>
        ///     Creates a <see cref="Luminance"/> from <see cref="LuminanceUnit.CenticandelaPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminance FromCenticandelasPerSquareMeter(double centicandelaspersquaremeter)
        {
            double value = (double) centicandelaspersquaremeter;
            return new Luminance(value, LuminanceUnit.CenticandelaPerSquareMeter);
        }

        /// <summary>
        ///     Creates a <see cref="Luminance"/> from <see cref="LuminanceUnit.DecicandelaPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminance FromDecicandelasPerSquareMeter(double decicandelaspersquaremeter)
        {
            double value = (double) decicandelaspersquaremeter;
            return new Luminance(value, LuminanceUnit.DecicandelaPerSquareMeter);
        }

        /// <summary>
        ///     Creates a <see cref="Luminance"/> from <see cref="LuminanceUnit.KilocandelaPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminance FromKilocandelasPerSquareMeter(double kilocandelaspersquaremeter)
        {
            double value = (double) kilocandelaspersquaremeter;
            return new Luminance(value, LuminanceUnit.KilocandelaPerSquareMeter);
        }

        /// <summary>
        ///     Creates a <see cref="Luminance"/> from <see cref="LuminanceUnit.MicrocandelaPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminance FromMicrocandelasPerSquareMeter(double microcandelaspersquaremeter)
        {
            double value = (double) microcandelaspersquaremeter;
            return new Luminance(value, LuminanceUnit.MicrocandelaPerSquareMeter);
        }

        /// <summary>
        ///     Creates a <see cref="Luminance"/> from <see cref="LuminanceUnit.MillicandelaPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminance FromMillicandelasPerSquareMeter(double millicandelaspersquaremeter)
        {
            double value = (double) millicandelaspersquaremeter;
            return new Luminance(value, LuminanceUnit.MillicandelaPerSquareMeter);
        }

        /// <summary>
        ///     Creates a <see cref="Luminance"/> from <see cref="LuminanceUnit.NanocandelaPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminance FromNanocandelasPerSquareMeter(double nanocandelaspersquaremeter)
        {
            double value = (double) nanocandelaspersquaremeter;
            return new Luminance(value, LuminanceUnit.NanocandelaPerSquareMeter);
        }

        /// <summary>
        ///     Creates a <see cref="Luminance"/> from <see cref="LuminanceUnit.Nit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminance FromNits(double nits)
        {
            double value = (double) nits;
            return new Luminance(value, LuminanceUnit.Nit);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LuminanceUnit" /> to <see cref="Luminance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Luminance unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Luminance From(double value, LuminanceUnit fromUnit)
        {
            return new Luminance((double)value, fromUnit);
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
        public static Luminance Parse(string str)
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static Luminance Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<Luminance, LuminanceUnit>(
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
        public static bool TryParse([CanBeNull] string str, out Luminance result)
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out Luminance result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<Luminance, LuminanceUnit>(
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
        public static LuminanceUnit ParseUnit(string str)
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static LuminanceUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<LuminanceUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out LuminanceUnit unit)
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out LuminanceUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<LuminanceUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object? obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is Luminance objLuminance)) throw new ArgumentException("Expected type Luminance.", nameof(obj));

            return CompareTo(objLuminance);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(Luminance other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Luminance objLuminance))
                return false;

            return Equals(objLuminance);
        }

        public bool Equals(Luminance other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Luminance within the given absolute or relative tolerance.
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
        public bool Equals(Luminance other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Luminance.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((LuminanceUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(LuminanceUnit unit)
        {
            if (Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Luminance to another Luminance with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Luminance with the specified unit.</returns>
        public Luminance ToUnit(LuminanceUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Luminance(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case LuminanceUnit.CandelaPerSquareFoot: return _value* 1.07639e1;
                case LuminanceUnit.CandelaPerSquareInch: return _value* 1.5500031e3;
                case LuminanceUnit.CandelaPerSquareMeter: return _value;
                case LuminanceUnit.CenticandelaPerSquareMeter: return (_value) * 1e-2d;
                case LuminanceUnit.DecicandelaPerSquareMeter: return (_value) * 1e-1d;
                case LuminanceUnit.KilocandelaPerSquareMeter: return (_value) * 1e3d;
                case LuminanceUnit.MicrocandelaPerSquareMeter: return (_value) * 1e-6d;
                case LuminanceUnit.MillicandelaPerSquareMeter: return (_value) * 1e-3d;
                case LuminanceUnit.NanocandelaPerSquareMeter: return (_value) * 1e-9d;
                case LuminanceUnit.Nit: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(LuminanceUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case LuminanceUnit.CandelaPerSquareFoot: return baseUnitValue/ 1.07639e1;
                case LuminanceUnit.CandelaPerSquareInch: return baseUnitValue/ 1.5500031e3;
                case LuminanceUnit.CandelaPerSquareMeter: return baseUnitValue;
                case LuminanceUnit.CenticandelaPerSquareMeter: return (baseUnitValue) / 1e-2d;
                case LuminanceUnit.DecicandelaPerSquareMeter: return (baseUnitValue) / 1e-1d;
                case LuminanceUnit.KilocandelaPerSquareMeter: return (baseUnitValue) / 1e3d;
                case LuminanceUnit.MicrocandelaPerSquareMeter: return (baseUnitValue) / 1e-6d;
                case LuminanceUnit.MillicandelaPerSquareMeter: return (baseUnitValue) / 1e-3d;
                case LuminanceUnit.NanocandelaPerSquareMeter: return (baseUnitValue) / 1e-9d;
                case LuminanceUnit.Nit: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}

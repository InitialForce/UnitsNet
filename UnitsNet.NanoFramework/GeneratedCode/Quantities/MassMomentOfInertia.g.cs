//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/OasysUnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnitsNet.

using System;
using OasysUnitsNet.Units;

namespace OasysUnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     A property of body reflects how its mass is distributed with regard to an axis.
    /// </summary>
    public struct  MassMomentOfInertia
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MassMomentOfInertiaUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MassMomentOfInertiaUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public MassMomentOfInertia(double value, MassMomentOfInertiaUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static MassMomentOfInertiaUnit BaseUnit { get; } = MassMomentOfInertiaUnit.KilogramSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static MassMomentOfInertia MaxValue { get; } = new MassMomentOfInertia(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static MassMomentOfInertia MinValue { get; } = new MassMomentOfInertia(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static MassMomentOfInertia Zero { get; } = new MassMomentOfInertia(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.GramSquareCentimeter"/>
        /// </summary>
        public double GramSquareCentimeters => As(MassMomentOfInertiaUnit.GramSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.GramSquareDecimeter"/>
        /// </summary>
        public double GramSquareDecimeters => As(MassMomentOfInertiaUnit.GramSquareDecimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.GramSquareMeter"/>
        /// </summary>
        public double GramSquareMeters => As(MassMomentOfInertiaUnit.GramSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.GramSquareMillimeter"/>
        /// </summary>
        public double GramSquareMillimeters => As(MassMomentOfInertiaUnit.GramSquareMillimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.KilogramSquareCentimeter"/>
        /// </summary>
        public double KilogramSquareCentimeters => As(MassMomentOfInertiaUnit.KilogramSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.KilogramSquareDecimeter"/>
        /// </summary>
        public double KilogramSquareDecimeters => As(MassMomentOfInertiaUnit.KilogramSquareDecimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.KilogramSquareMeter"/>
        /// </summary>
        public double KilogramSquareMeters => As(MassMomentOfInertiaUnit.KilogramSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.KilogramSquareMillimeter"/>
        /// </summary>
        public double KilogramSquareMillimeters => As(MassMomentOfInertiaUnit.KilogramSquareMillimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.KilotonneSquareCentimeter"/>
        /// </summary>
        public double KilotonneSquareCentimeters => As(MassMomentOfInertiaUnit.KilotonneSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.KilotonneSquareDecimeter"/>
        /// </summary>
        public double KilotonneSquareDecimeters => As(MassMomentOfInertiaUnit.KilotonneSquareDecimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.KilotonneSquareMeter"/>
        /// </summary>
        public double KilotonneSquareMeters => As(MassMomentOfInertiaUnit.KilotonneSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.KilotonneSquareMilimeter"/>
        /// </summary>
        public double KilotonneSquareMilimeters => As(MassMomentOfInertiaUnit.KilotonneSquareMilimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.MegatonneSquareCentimeter"/>
        /// </summary>
        public double MegatonneSquareCentimeters => As(MassMomentOfInertiaUnit.MegatonneSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.MegatonneSquareDecimeter"/>
        /// </summary>
        public double MegatonneSquareDecimeters => As(MassMomentOfInertiaUnit.MegatonneSquareDecimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.MegatonneSquareMeter"/>
        /// </summary>
        public double MegatonneSquareMeters => As(MassMomentOfInertiaUnit.MegatonneSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.MegatonneSquareMilimeter"/>
        /// </summary>
        public double MegatonneSquareMilimeters => As(MassMomentOfInertiaUnit.MegatonneSquareMilimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.MilligramSquareCentimeter"/>
        /// </summary>
        public double MilligramSquareCentimeters => As(MassMomentOfInertiaUnit.MilligramSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.MilligramSquareDecimeter"/>
        /// </summary>
        public double MilligramSquareDecimeters => As(MassMomentOfInertiaUnit.MilligramSquareDecimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.MilligramSquareMeter"/>
        /// </summary>
        public double MilligramSquareMeters => As(MassMomentOfInertiaUnit.MilligramSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.MilligramSquareMillimeter"/>
        /// </summary>
        public double MilligramSquareMillimeters => As(MassMomentOfInertiaUnit.MilligramSquareMillimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.PoundSquareFoot"/>
        /// </summary>
        public double PoundSquareFeet => As(MassMomentOfInertiaUnit.PoundSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.PoundSquareInch"/>
        /// </summary>
        public double PoundSquareInches => As(MassMomentOfInertiaUnit.PoundSquareInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.SlugSquareFoot"/>
        /// </summary>
        public double SlugSquareFeet => As(MassMomentOfInertiaUnit.SlugSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.SlugSquareInch"/>
        /// </summary>
        public double SlugSquareInches => As(MassMomentOfInertiaUnit.SlugSquareInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.TonneSquareCentimeter"/>
        /// </summary>
        public double TonneSquareCentimeters => As(MassMomentOfInertiaUnit.TonneSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.TonneSquareDecimeter"/>
        /// </summary>
        public double TonneSquareDecimeters => As(MassMomentOfInertiaUnit.TonneSquareDecimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.TonneSquareMeter"/>
        /// </summary>
        public double TonneSquareMeters => As(MassMomentOfInertiaUnit.TonneSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassMomentOfInertiaUnit.TonneSquareMilimeter"/>
        /// </summary>
        public double TonneSquareMilimeters => As(MassMomentOfInertiaUnit.TonneSquareMilimeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.GramSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromGramSquareCentimeters(double gramsquarecentimeters) => new MassMomentOfInertia(gramsquarecentimeters, MassMomentOfInertiaUnit.GramSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.GramSquareDecimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromGramSquareDecimeters(double gramsquaredecimeters) => new MassMomentOfInertia(gramsquaredecimeters, MassMomentOfInertiaUnit.GramSquareDecimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.GramSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromGramSquareMeters(double gramsquaremeters) => new MassMomentOfInertia(gramsquaremeters, MassMomentOfInertiaUnit.GramSquareMeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.GramSquareMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromGramSquareMillimeters(double gramsquaremillimeters) => new MassMomentOfInertia(gramsquaremillimeters, MassMomentOfInertiaUnit.GramSquareMillimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.KilogramSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilogramSquareCentimeters(double kilogramsquarecentimeters) => new MassMomentOfInertia(kilogramsquarecentimeters, MassMomentOfInertiaUnit.KilogramSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.KilogramSquareDecimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilogramSquareDecimeters(double kilogramsquaredecimeters) => new MassMomentOfInertia(kilogramsquaredecimeters, MassMomentOfInertiaUnit.KilogramSquareDecimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.KilogramSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilogramSquareMeters(double kilogramsquaremeters) => new MassMomentOfInertia(kilogramsquaremeters, MassMomentOfInertiaUnit.KilogramSquareMeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.KilogramSquareMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilogramSquareMillimeters(double kilogramsquaremillimeters) => new MassMomentOfInertia(kilogramsquaremillimeters, MassMomentOfInertiaUnit.KilogramSquareMillimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.KilotonneSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilotonneSquareCentimeters(double kilotonnesquarecentimeters) => new MassMomentOfInertia(kilotonnesquarecentimeters, MassMomentOfInertiaUnit.KilotonneSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.KilotonneSquareDecimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilotonneSquareDecimeters(double kilotonnesquaredecimeters) => new MassMomentOfInertia(kilotonnesquaredecimeters, MassMomentOfInertiaUnit.KilotonneSquareDecimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.KilotonneSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilotonneSquareMeters(double kilotonnesquaremeters) => new MassMomentOfInertia(kilotonnesquaremeters, MassMomentOfInertiaUnit.KilotonneSquareMeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.KilotonneSquareMilimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilotonneSquareMilimeters(double kilotonnesquaremilimeters) => new MassMomentOfInertia(kilotonnesquaremilimeters, MassMomentOfInertiaUnit.KilotonneSquareMilimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.MegatonneSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMegatonneSquareCentimeters(double megatonnesquarecentimeters) => new MassMomentOfInertia(megatonnesquarecentimeters, MassMomentOfInertiaUnit.MegatonneSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.MegatonneSquareDecimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMegatonneSquareDecimeters(double megatonnesquaredecimeters) => new MassMomentOfInertia(megatonnesquaredecimeters, MassMomentOfInertiaUnit.MegatonneSquareDecimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.MegatonneSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMegatonneSquareMeters(double megatonnesquaremeters) => new MassMomentOfInertia(megatonnesquaremeters, MassMomentOfInertiaUnit.MegatonneSquareMeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.MegatonneSquareMilimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMegatonneSquareMilimeters(double megatonnesquaremilimeters) => new MassMomentOfInertia(megatonnesquaremilimeters, MassMomentOfInertiaUnit.MegatonneSquareMilimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.MilligramSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMilligramSquareCentimeters(double milligramsquarecentimeters) => new MassMomentOfInertia(milligramsquarecentimeters, MassMomentOfInertiaUnit.MilligramSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.MilligramSquareDecimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMilligramSquareDecimeters(double milligramsquaredecimeters) => new MassMomentOfInertia(milligramsquaredecimeters, MassMomentOfInertiaUnit.MilligramSquareDecimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.MilligramSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMilligramSquareMeters(double milligramsquaremeters) => new MassMomentOfInertia(milligramsquaremeters, MassMomentOfInertiaUnit.MilligramSquareMeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.MilligramSquareMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMilligramSquareMillimeters(double milligramsquaremillimeters) => new MassMomentOfInertia(milligramsquaremillimeters, MassMomentOfInertiaUnit.MilligramSquareMillimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.PoundSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromPoundSquareFeet(double poundsquarefeet) => new MassMomentOfInertia(poundsquarefeet, MassMomentOfInertiaUnit.PoundSquareFoot);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.PoundSquareInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromPoundSquareInches(double poundsquareinches) => new MassMomentOfInertia(poundsquareinches, MassMomentOfInertiaUnit.PoundSquareInch);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.SlugSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromSlugSquareFeet(double slugsquarefeet) => new MassMomentOfInertia(slugsquarefeet, MassMomentOfInertiaUnit.SlugSquareFoot);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.SlugSquareInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromSlugSquareInches(double slugsquareinches) => new MassMomentOfInertia(slugsquareinches, MassMomentOfInertiaUnit.SlugSquareInch);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.TonneSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromTonneSquareCentimeters(double tonnesquarecentimeters) => new MassMomentOfInertia(tonnesquarecentimeters, MassMomentOfInertiaUnit.TonneSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.TonneSquareDecimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromTonneSquareDecimeters(double tonnesquaredecimeters) => new MassMomentOfInertia(tonnesquaredecimeters, MassMomentOfInertiaUnit.TonneSquareDecimeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.TonneSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromTonneSquareMeters(double tonnesquaremeters) => new MassMomentOfInertia(tonnesquaremeters, MassMomentOfInertiaUnit.TonneSquareMeter);

        /// <summary>
        ///     Creates a <see cref="MassMomentOfInertia"/> from <see cref="MassMomentOfInertiaUnit.TonneSquareMilimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromTonneSquareMilimeters(double tonnesquaremilimeters) => new MassMomentOfInertia(tonnesquaremilimeters, MassMomentOfInertiaUnit.TonneSquareMilimeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MassMomentOfInertiaUnit" /> to <see cref="MassMomentOfInertia" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MassMomentOfInertia unit value.</returns>
        public static MassMomentOfInertia From(double value, MassMomentOfInertiaUnit fromUnit)
        {
            return new MassMomentOfInertia(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MassMomentOfInertiaUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public MassMomentOfInertia ToUnit(MassMomentOfInertiaUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new MassMomentOfInertia(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            return Unit switch
            {
                MassMomentOfInertiaUnit.GramSquareCentimeter => _value / 1e7,
                MassMomentOfInertiaUnit.GramSquareDecimeter => _value / 1e5,
                MassMomentOfInertiaUnit.GramSquareMeter => _value / 1e3,
                MassMomentOfInertiaUnit.GramSquareMillimeter => _value / 1e9,
                MassMomentOfInertiaUnit.KilogramSquareCentimeter => (_value / 1e7) * 1e3d,
                MassMomentOfInertiaUnit.KilogramSquareDecimeter => (_value / 1e5) * 1e3d,
                MassMomentOfInertiaUnit.KilogramSquareMeter => (_value / 1e3) * 1e3d,
                MassMomentOfInertiaUnit.KilogramSquareMillimeter => (_value / 1e9) * 1e3d,
                MassMomentOfInertiaUnit.KilotonneSquareCentimeter => (_value / 1e1) * 1e3d,
                MassMomentOfInertiaUnit.KilotonneSquareDecimeter => (_value / 1e-1) * 1e3d,
                MassMomentOfInertiaUnit.KilotonneSquareMeter => (_value / 1e-3) * 1e3d,
                MassMomentOfInertiaUnit.KilotonneSquareMilimeter => (_value / 1e3) * 1e3d,
                MassMomentOfInertiaUnit.MegatonneSquareCentimeter => (_value / 1e1) * 1e6d,
                MassMomentOfInertiaUnit.MegatonneSquareDecimeter => (_value / 1e-1) * 1e6d,
                MassMomentOfInertiaUnit.MegatonneSquareMeter => (_value / 1e-3) * 1e6d,
                MassMomentOfInertiaUnit.MegatonneSquareMilimeter => (_value / 1e3) * 1e6d,
                MassMomentOfInertiaUnit.MilligramSquareCentimeter => (_value / 1e7) * 1e-3d,
                MassMomentOfInertiaUnit.MilligramSquareDecimeter => (_value / 1e5) * 1e-3d,
                MassMomentOfInertiaUnit.MilligramSquareMeter => (_value / 1e3) * 1e-3d,
                MassMomentOfInertiaUnit.MilligramSquareMillimeter => (_value / 1e9) * 1e-3d,
                MassMomentOfInertiaUnit.PoundSquareFoot => _value * 4.21401101e-2,
                MassMomentOfInertiaUnit.PoundSquareInch => _value * 2.9263965e-4,
                MassMomentOfInertiaUnit.SlugSquareFoot => _value * 1.3558179619,
                MassMomentOfInertiaUnit.SlugSquareInch => _value * 9.41540242e-3,
                MassMomentOfInertiaUnit.TonneSquareCentimeter => _value / 1e1,
                MassMomentOfInertiaUnit.TonneSquareDecimeter => _value / 1e-1,
                MassMomentOfInertiaUnit.TonneSquareMeter => _value / 1e-3,
                MassMomentOfInertiaUnit.TonneSquareMilimeter => _value / 1e3,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(MassMomentOfInertiaUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                MassMomentOfInertiaUnit.GramSquareCentimeter => baseUnitValue * 1e7,
                MassMomentOfInertiaUnit.GramSquareDecimeter => baseUnitValue * 1e5,
                MassMomentOfInertiaUnit.GramSquareMeter => baseUnitValue * 1e3,
                MassMomentOfInertiaUnit.GramSquareMillimeter => baseUnitValue * 1e9,
                MassMomentOfInertiaUnit.KilogramSquareCentimeter => (baseUnitValue * 1e7) / 1e3d,
                MassMomentOfInertiaUnit.KilogramSquareDecimeter => (baseUnitValue * 1e5) / 1e3d,
                MassMomentOfInertiaUnit.KilogramSquareMeter => (baseUnitValue * 1e3) / 1e3d,
                MassMomentOfInertiaUnit.KilogramSquareMillimeter => (baseUnitValue * 1e9) / 1e3d,
                MassMomentOfInertiaUnit.KilotonneSquareCentimeter => (baseUnitValue * 1e1) / 1e3d,
                MassMomentOfInertiaUnit.KilotonneSquareDecimeter => (baseUnitValue * 1e-1) / 1e3d,
                MassMomentOfInertiaUnit.KilotonneSquareMeter => (baseUnitValue * 1e-3) / 1e3d,
                MassMomentOfInertiaUnit.KilotonneSquareMilimeter => (baseUnitValue * 1e3) / 1e3d,
                MassMomentOfInertiaUnit.MegatonneSquareCentimeter => (baseUnitValue * 1e1) / 1e6d,
                MassMomentOfInertiaUnit.MegatonneSquareDecimeter => (baseUnitValue * 1e-1) / 1e6d,
                MassMomentOfInertiaUnit.MegatonneSquareMeter => (baseUnitValue * 1e-3) / 1e6d,
                MassMomentOfInertiaUnit.MegatonneSquareMilimeter => (baseUnitValue * 1e3) / 1e6d,
                MassMomentOfInertiaUnit.MilligramSquareCentimeter => (baseUnitValue * 1e7) / 1e-3d,
                MassMomentOfInertiaUnit.MilligramSquareDecimeter => (baseUnitValue * 1e5) / 1e-3d,
                MassMomentOfInertiaUnit.MilligramSquareMeter => (baseUnitValue * 1e3) / 1e-3d,
                MassMomentOfInertiaUnit.MilligramSquareMillimeter => (baseUnitValue * 1e9) / 1e-3d,
                MassMomentOfInertiaUnit.PoundSquareFoot => baseUnitValue / 4.21401101e-2,
                MassMomentOfInertiaUnit.PoundSquareInch => baseUnitValue / 2.9263965e-4,
                MassMomentOfInertiaUnit.SlugSquareFoot => baseUnitValue / 1.3558179619,
                MassMomentOfInertiaUnit.SlugSquareInch => baseUnitValue / 9.41540242e-3,
                MassMomentOfInertiaUnit.TonneSquareCentimeter => baseUnitValue * 1e1,
                MassMomentOfInertiaUnit.TonneSquareDecimeter => baseUnitValue * 1e-1,
                MassMomentOfInertiaUnit.TonneSquareMeter => baseUnitValue * 1e-3,
                MassMomentOfInertiaUnit.TonneSquareMilimeter => baseUnitValue * 1e3,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}


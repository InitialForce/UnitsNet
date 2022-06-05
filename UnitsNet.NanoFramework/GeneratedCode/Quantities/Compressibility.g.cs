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
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     
    /// </summary>
    public struct  Compressibility
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly CompressibilityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public CompressibilityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Compressibility(double value, CompressibilityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static CompressibilityUnit BaseUnit { get; } = CompressibilityUnit.InversePascal;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Compressibility MaxValue { get; } = new Compressibility(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Compressibility MinValue { get; } = new Compressibility(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Compressibility Zero { get; } = new Compressibility(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CompressibilityUnit.InverseAtmosphere"/>
        /// </summary>
        public double InverseAtmospheres => As(CompressibilityUnit.InverseAtmosphere);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CompressibilityUnit.InverseBar"/>
        /// </summary>
        public double InverseBars => As(CompressibilityUnit.InverseBar);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CompressibilityUnit.InverseKilopascal"/>
        /// </summary>
        public double InverseKilopascals => As(CompressibilityUnit.InverseKilopascal);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CompressibilityUnit.InverseMegapascal"/>
        /// </summary>
        public double InverseMegapascals => As(CompressibilityUnit.InverseMegapascal);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CompressibilityUnit.InverseMillibar"/>
        /// </summary>
        public double InverseMillibars => As(CompressibilityUnit.InverseMillibar);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CompressibilityUnit.InversePascal"/>
        /// </summary>
        public double InversePascals => As(CompressibilityUnit.InversePascal);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CompressibilityUnit.InversePoundForcePerSquareInch"/>
        /// </summary>
        public double InversePoundsForcePerSquareInch => As(CompressibilityUnit.InversePoundForcePerSquareInch);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Compressibility"/> from <see cref="CompressibilityUnit.InverseAtmosphere"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Compressibility FromInverseAtmospheres(double inverseatmospheres) => new Compressibility(inverseatmospheres, CompressibilityUnit.InverseAtmosphere);

        /// <summary>
        ///     Creates a <see cref="Compressibility"/> from <see cref="CompressibilityUnit.InverseBar"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Compressibility FromInverseBars(double inversebars) => new Compressibility(inversebars, CompressibilityUnit.InverseBar);

        /// <summary>
        ///     Creates a <see cref="Compressibility"/> from <see cref="CompressibilityUnit.InverseKilopascal"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Compressibility FromInverseKilopascals(double inversekilopascals) => new Compressibility(inversekilopascals, CompressibilityUnit.InverseKilopascal);

        /// <summary>
        ///     Creates a <see cref="Compressibility"/> from <see cref="CompressibilityUnit.InverseMegapascal"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Compressibility FromInverseMegapascals(double inversemegapascals) => new Compressibility(inversemegapascals, CompressibilityUnit.InverseMegapascal);

        /// <summary>
        ///     Creates a <see cref="Compressibility"/> from <see cref="CompressibilityUnit.InverseMillibar"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Compressibility FromInverseMillibars(double inversemillibars) => new Compressibility(inversemillibars, CompressibilityUnit.InverseMillibar);

        /// <summary>
        ///     Creates a <see cref="Compressibility"/> from <see cref="CompressibilityUnit.InversePascal"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Compressibility FromInversePascals(double inversepascals) => new Compressibility(inversepascals, CompressibilityUnit.InversePascal);

        /// <summary>
        ///     Creates a <see cref="Compressibility"/> from <see cref="CompressibilityUnit.InversePoundForcePerSquareInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Compressibility FromInversePoundsForcePerSquareInch(double inversepoundsforcepersquareinch) => new Compressibility(inversepoundsforcepersquareinch, CompressibilityUnit.InversePoundForcePerSquareInch);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="CompressibilityUnit" /> to <see cref="Compressibility" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Compressibility unit value.</returns>
        public static Compressibility From(double value, CompressibilityUnit fromUnit)
        {
            return new Compressibility(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(CompressibilityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Duration with the specified unit.</returns>
                public Compressibility ToUnit(CompressibilityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Compressibility(convertedValue, unit);
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
                        CompressibilityUnit.InverseAtmosphere => _value * 101325,
                        CompressibilityUnit.InverseBar => _value * 1e5,
                        CompressibilityUnit.InverseKilopascal => _value * 1e3,
                        CompressibilityUnit.InverseMegapascal => _value * 1e6,
                        CompressibilityUnit.InverseMillibar => _value * 100,
                        CompressibilityUnit.InversePascal => _value,
                        CompressibilityUnit.InversePoundForcePerSquareInch => _value * 6.894757293168361e3,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(CompressibilityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        CompressibilityUnit.InverseAtmosphere => baseUnitValue / 101325,
                        CompressibilityUnit.InverseBar => baseUnitValue / 1e5,
                        CompressibilityUnit.InverseKilopascal => baseUnitValue / 1e3,
                        CompressibilityUnit.InverseMegapascal => baseUnitValue / 1e6,
                        CompressibilityUnit.InverseMillibar => baseUnitValue / 100,
                        CompressibilityUnit.InversePascal => baseUnitValue,
                        CompressibilityUnit.InversePoundForcePerSquareInch => baseUnitValue / 6.894757293168361e3,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


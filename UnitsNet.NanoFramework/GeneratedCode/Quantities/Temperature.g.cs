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
    ///     A temperature is a numerical measure of hot or cold. Its measurement is by detection of heat radiation or particle velocity or kinetic energy, or by the bulk behavior of a thermometric material. It may be calibrated in any of various temperature scales, Celsius, Fahrenheit, Kelvin, etc. The fundamental physical definition of temperature is provided by thermodynamics.
    /// </summary>
    public struct  Temperature
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TemperatureUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public TemperatureUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Temperature(double value, TemperatureUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static TemperatureUnit BaseUnit { get; } = TemperatureUnit.Kelvin;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Temperature MaxValue { get; } = new Temperature(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Temperature MinValue { get; } = new Temperature(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Temperature Zero { get; } = new Temperature(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureUnit.DegreeCelsius"/>
        /// </summary>
        public double DegreesCelsius => As(TemperatureUnit.DegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureUnit.DegreeDelisle"/>
        /// </summary>
        public double DegreesDelisle => As(TemperatureUnit.DegreeDelisle);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureUnit.DegreeFahrenheit"/>
        /// </summary>
        public double DegreesFahrenheit => As(TemperatureUnit.DegreeFahrenheit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureUnit.DegreeNewton"/>
        /// </summary>
        public double DegreesNewton => As(TemperatureUnit.DegreeNewton);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureUnit.DegreeRankine"/>
        /// </summary>
        public double DegreesRankine => As(TemperatureUnit.DegreeRankine);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureUnit.DegreeReaumur"/>
        /// </summary>
        public double DegreesReaumur => As(TemperatureUnit.DegreeReaumur);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureUnit.DegreeRoemer"/>
        /// </summary>
        public double DegreesRoemer => As(TemperatureUnit.DegreeRoemer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureUnit.Kelvin"/>
        /// </summary>
        public double Kelvins => As(TemperatureUnit.Kelvin);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureUnit.MillidegreeCelsius"/>
        /// </summary>
        public double MillidegreesCelsius => As(TemperatureUnit.MillidegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="TemperatureUnit.SolarTemperature"/>
        /// </summary>
        public double SolarTemperatures => As(TemperatureUnit.SolarTemperature);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Temperature"/> from <see cref="TemperatureUnit.DegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesCelsius(double degreescelsius) => new Temperature(degreescelsius, TemperatureUnit.DegreeCelsius);

        /// <summary>
        ///     Creates a <see cref="Temperature"/> from <see cref="TemperatureUnit.DegreeDelisle"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesDelisle(double degreesdelisle) => new Temperature(degreesdelisle, TemperatureUnit.DegreeDelisle);

        /// <summary>
        ///     Creates a <see cref="Temperature"/> from <see cref="TemperatureUnit.DegreeFahrenheit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesFahrenheit(double degreesfahrenheit) => new Temperature(degreesfahrenheit, TemperatureUnit.DegreeFahrenheit);

        /// <summary>
        ///     Creates a <see cref="Temperature"/> from <see cref="TemperatureUnit.DegreeNewton"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesNewton(double degreesnewton) => new Temperature(degreesnewton, TemperatureUnit.DegreeNewton);

        /// <summary>
        ///     Creates a <see cref="Temperature"/> from <see cref="TemperatureUnit.DegreeRankine"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesRankine(double degreesrankine) => new Temperature(degreesrankine, TemperatureUnit.DegreeRankine);

        /// <summary>
        ///     Creates a <see cref="Temperature"/> from <see cref="TemperatureUnit.DegreeReaumur"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesReaumur(double degreesreaumur) => new Temperature(degreesreaumur, TemperatureUnit.DegreeReaumur);

        /// <summary>
        ///     Creates a <see cref="Temperature"/> from <see cref="TemperatureUnit.DegreeRoemer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesRoemer(double degreesroemer) => new Temperature(degreesroemer, TemperatureUnit.DegreeRoemer);

        /// <summary>
        ///     Creates a <see cref="Temperature"/> from <see cref="TemperatureUnit.Kelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromKelvins(double kelvins) => new Temperature(kelvins, TemperatureUnit.Kelvin);

        /// <summary>
        ///     Creates a <see cref="Temperature"/> from <see cref="TemperatureUnit.MillidegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromMillidegreesCelsius(double millidegreescelsius) => new Temperature(millidegreescelsius, TemperatureUnit.MillidegreeCelsius);

        /// <summary>
        ///     Creates a <see cref="Temperature"/> from <see cref="TemperatureUnit.SolarTemperature"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromSolarTemperatures(double solartemperatures) => new Temperature(solartemperatures, TemperatureUnit.SolarTemperature);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TemperatureUnit" /> to <see cref="Temperature" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Temperature unit value.</returns>
        public static Temperature From(double value, TemperatureUnit fromUnit)
        {
            return new Temperature(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TemperatureUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Temperature ToUnit(TemperatureUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Temperature(convertedValue, unit);
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
                TemperatureUnit.DegreeCelsius => _value + 273.15,
                TemperatureUnit.DegreeDelisle => _value * -2 / 3 + 373.15,
                TemperatureUnit.DegreeFahrenheit => _value * 5 / 9 + 459.67 * 5 / 9,
                TemperatureUnit.DegreeNewton => _value * 100 / 33 + 273.15,
                TemperatureUnit.DegreeRankine => _value * 5 / 9,
                TemperatureUnit.DegreeReaumur => _value * 5 / 4 + 273.15,
                TemperatureUnit.DegreeRoemer => _value * 40 / 21 + 273.15 - 7.5 * 40d / 21,
                TemperatureUnit.Kelvin => _value,
                TemperatureUnit.MillidegreeCelsius => _value / 1000 + 273.15,
                TemperatureUnit.SolarTemperature => _value * 5778,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(TemperatureUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                TemperatureUnit.DegreeCelsius => baseUnitValue - 273.15,
                TemperatureUnit.DegreeDelisle => (baseUnitValue - 373.15) * -3 / 2,
                TemperatureUnit.DegreeFahrenheit => (baseUnitValue - 459.67 * 5 / 9) * 9 / 5,
                TemperatureUnit.DegreeNewton => (baseUnitValue - 273.15) * 33 / 100,
                TemperatureUnit.DegreeRankine => baseUnitValue * 9 / 5,
                TemperatureUnit.DegreeReaumur => (baseUnitValue - 273.15) * 4 / 5,
                TemperatureUnit.DegreeRoemer => (baseUnitValue - (273.15 - 7.5 * 40d / 21)) * 21 / 40,
                TemperatureUnit.Kelvin => baseUnitValue,
                TemperatureUnit.MillidegreeCelsius => (baseUnitValue - 273.15) * 1000,
                TemperatureUnit.SolarTemperature => baseUnitValue / 5778,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}


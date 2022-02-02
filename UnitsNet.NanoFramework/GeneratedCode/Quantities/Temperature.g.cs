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
        ///     Get Temperature in DegreesCelsius.
        /// </summary>
        public double DegreesCelsius => As(TemperatureUnit.DegreeCelsius);

        /// <summary>
        ///     Get Temperature in DegreesDelisle.
        /// </summary>
        public double DegreesDelisle => As(TemperatureUnit.DegreeDelisle);

        /// <summary>
        ///     Get Temperature in DegreesFahrenheit.
        /// </summary>
        public double DegreesFahrenheit => As(TemperatureUnit.DegreeFahrenheit);

        /// <summary>
        ///     Get Temperature in DegreesNewton.
        /// </summary>
        public double DegreesNewton => As(TemperatureUnit.DegreeNewton);

        /// <summary>
        ///     Get Temperature in DegreesRankine.
        /// </summary>
        public double DegreesRankine => As(TemperatureUnit.DegreeRankine);

        /// <summary>
        ///     Get Temperature in DegreesReaumur.
        /// </summary>
        public double DegreesReaumur => As(TemperatureUnit.DegreeReaumur);

        /// <summary>
        ///     Get Temperature in DegreesRoemer.
        /// </summary>
        public double DegreesRoemer => As(TemperatureUnit.DegreeRoemer);

        /// <summary>
        ///     Get Temperature in Kelvins.
        /// </summary>
        public double Kelvins => As(TemperatureUnit.Kelvin);

        /// <summary>
        ///     Get Temperature in MillidegreesCelsius.
        /// </summary>
        public double MillidegreesCelsius => As(TemperatureUnit.MillidegreeCelsius);

        /// <summary>
        ///     Get Temperature in SolarTemperatures.
        /// </summary>
        public double SolarTemperatures => As(TemperatureUnit.SolarTemperature);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Temperature from DegreesCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesCelsius(double degreescelsius) => new Temperature(degreescelsius, TemperatureUnit.DegreeCelsius);

        /// <summary>
        ///     Get Temperature from DegreesDelisle.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesDelisle(double degreesdelisle) => new Temperature(degreesdelisle, TemperatureUnit.DegreeDelisle);

        /// <summary>
        ///     Get Temperature from DegreesFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesFahrenheit(double degreesfahrenheit) => new Temperature(degreesfahrenheit, TemperatureUnit.DegreeFahrenheit);

        /// <summary>
        ///     Get Temperature from DegreesNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesNewton(double degreesnewton) => new Temperature(degreesnewton, TemperatureUnit.DegreeNewton);

        /// <summary>
        ///     Get Temperature from DegreesRankine.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesRankine(double degreesrankine) => new Temperature(degreesrankine, TemperatureUnit.DegreeRankine);

        /// <summary>
        ///     Get Temperature from DegreesReaumur.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesReaumur(double degreesreaumur) => new Temperature(degreesreaumur, TemperatureUnit.DegreeReaumur);

        /// <summary>
        ///     Get Temperature from DegreesRoemer.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesRoemer(double degreesroemer) => new Temperature(degreesroemer, TemperatureUnit.DegreeRoemer);

        /// <summary>
        ///     Get Temperature from Kelvins.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromKelvins(double kelvins) => new Temperature(kelvins, TemperatureUnit.Kelvin);

        /// <summary>
        ///     Get Temperature from MillidegreesCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromMillidegreesCelsius(double millidegreescelsius) => new Temperature(millidegreescelsius, TemperatureUnit.MillidegreeCelsius);

        /// <summary>
        ///     Get Temperature from SolarTemperatures.
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
            switch(Unit)
            {
                case TemperatureUnit.DegreeCelsius: return _value + 273.15;
                case TemperatureUnit.DegreeDelisle: return _value*-2/3 + 373.15;
                case TemperatureUnit.DegreeFahrenheit: return _value*5/9 + 459.67*5/9;
                case TemperatureUnit.DegreeNewton: return _value*100/33 + 273.15;
                case TemperatureUnit.DegreeRankine: return _value*5/9;
                case TemperatureUnit.DegreeReaumur: return _value*5/4 + 273.15;
                case TemperatureUnit.DegreeRoemer: return _value*40/21 + 273.15 - 7.5*40d/21;
                case TemperatureUnit.Kelvin: return _value;
                case TemperatureUnit.MillidegreeCelsius: return _value / 1000 + 273.15;
                case TemperatureUnit.SolarTemperature: return _value * 5778;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(TemperatureUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case TemperatureUnit.DegreeCelsius: return baseUnitValue - 273.15;
                case TemperatureUnit.DegreeDelisle: return (baseUnitValue - 373.15)*-3/2;
                case TemperatureUnit.DegreeFahrenheit: return (baseUnitValue - 459.67*5/9)*9/5;
                case TemperatureUnit.DegreeNewton: return (baseUnitValue - 273.15)*33/100;
                case TemperatureUnit.DegreeRankine: return baseUnitValue*9/5;
                case TemperatureUnit.DegreeReaumur: return (baseUnitValue - 273.15)*4/5;
                case TemperatureUnit.DegreeRoemer: return (baseUnitValue - (273.15 - 7.5*40d/21))*21/40;
                case TemperatureUnit.Kelvin: return baseUnitValue;
                case TemperatureUnit.MillidegreeCelsius: return (baseUnitValue - 273.15) * 1000;
                case TemperatureUnit.SolarTemperature: return baseUnitValue / 5778;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}


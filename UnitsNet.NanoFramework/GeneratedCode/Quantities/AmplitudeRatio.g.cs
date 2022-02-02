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
    ///     The strength of a signal expressed in decibels (dB) relative to one volt RMS.
    /// </summary>
    public struct  AmplitudeRatio
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AmplitudeRatioUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public AmplitudeRatioUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public AmplitudeRatio(double value, AmplitudeRatioUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static AmplitudeRatioUnit BaseUnit { get; } = AmplitudeRatioUnit.DecibelVolt;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static AmplitudeRatio MaxValue { get; } = new AmplitudeRatio(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static AmplitudeRatio MinValue { get; } = new AmplitudeRatio(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static AmplitudeRatio Zero { get; } = new AmplitudeRatio(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get AmplitudeRatio in DecibelMicrovolts.
        /// </summary>
        public double DecibelMicrovolts => As(AmplitudeRatioUnit.DecibelMicrovolt);

        /// <summary>
        ///     Get AmplitudeRatio in DecibelMillivolts.
        /// </summary>
        public double DecibelMillivolts => As(AmplitudeRatioUnit.DecibelMillivolt);

        /// <summary>
        ///     Get AmplitudeRatio in DecibelsUnloaded.
        /// </summary>
        public double DecibelsUnloaded => As(AmplitudeRatioUnit.DecibelUnloaded);

        /// <summary>
        ///     Get AmplitudeRatio in DecibelVolts.
        /// </summary>
        public double DecibelVolts => As(AmplitudeRatioUnit.DecibelVolt);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get AmplitudeRatio from DecibelMicrovolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmplitudeRatio FromDecibelMicrovolts(double decibelmicrovolts) => new AmplitudeRatio(decibelmicrovolts, AmplitudeRatioUnit.DecibelMicrovolt);

        /// <summary>
        ///     Get AmplitudeRatio from DecibelMillivolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmplitudeRatio FromDecibelMillivolts(double decibelmillivolts) => new AmplitudeRatio(decibelmillivolts, AmplitudeRatioUnit.DecibelMillivolt);

        /// <summary>
        ///     Get AmplitudeRatio from DecibelsUnloaded.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmplitudeRatio FromDecibelsUnloaded(double decibelsunloaded) => new AmplitudeRatio(decibelsunloaded, AmplitudeRatioUnit.DecibelUnloaded);

        /// <summary>
        ///     Get AmplitudeRatio from DecibelVolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmplitudeRatio FromDecibelVolts(double decibelvolts) => new AmplitudeRatio(decibelvolts, AmplitudeRatioUnit.DecibelVolt);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AmplitudeRatioUnit" /> to <see cref="AmplitudeRatio" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>AmplitudeRatio unit value.</returns>
        public static AmplitudeRatio From(double value, AmplitudeRatioUnit fromUnit)
        {
            return new AmplitudeRatio(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AmplitudeRatioUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public AmplitudeRatio ToUnit(AmplitudeRatioUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new AmplitudeRatio(convertedValue, unit);
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
                case AmplitudeRatioUnit.DecibelMicrovolt: return _value - 120;
                case AmplitudeRatioUnit.DecibelMillivolt: return _value - 60;
                case AmplitudeRatioUnit.DecibelUnloaded: return _value - 2.218487499;
                case AmplitudeRatioUnit.DecibelVolt: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(AmplitudeRatioUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case AmplitudeRatioUnit.DecibelMicrovolt: return baseUnitValue + 120;
                case AmplitudeRatioUnit.DecibelMillivolt: return baseUnitValue + 60;
                case AmplitudeRatioUnit.DecibelUnloaded: return baseUnitValue + 2.218487499;
                case AmplitudeRatioUnit.DecibelVolt: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}


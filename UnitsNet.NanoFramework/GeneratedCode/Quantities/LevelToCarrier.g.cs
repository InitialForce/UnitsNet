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
    ///     Level is the logarithm of the ratio between the level of the signal and the level carrier or reference signal.
    /// </summary>
    public struct  LevelToCarrier
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly LevelToCarrierUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public LevelToCarrierUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public LevelToCarrier(double value, LevelToCarrierUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of LevelToCarrier, which is Second. All conversions go via this value.
        /// </summary>
        public static LevelToCarrierUnit BaseUnit { get; } = LevelToCarrierUnit.DecibelCarrier;

        /// <summary>
        /// Represents the largest possible value of LevelToCarrier.
        /// </summary>
        public static LevelToCarrier MaxValue { get; } = new LevelToCarrier(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of LevelToCarrier.
        /// </summary>
        public static LevelToCarrier MinValue { get; } = new LevelToCarrier(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static LevelToCarrier Zero { get; } = new LevelToCarrier(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LevelToCarrierUnit.DecibelCarrier"/>
        /// </summary>
        public double DecibelsCarrier => As(LevelToCarrierUnit.DecibelCarrier);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="LevelToCarrier"/> from <see cref="LevelToCarrierUnit.DecibelCarrier"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LevelToCarrier FromDecibelsCarrier(double decibelscarrier) => new LevelToCarrier(decibelscarrier, LevelToCarrierUnit.DecibelCarrier);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LevelToCarrierUnit" /> to <see cref="LevelToCarrier" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>LevelToCarrier unit value.</returns>
        public static LevelToCarrier From(double value, LevelToCarrierUnit fromUnit)
        {
            return new LevelToCarrier(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(LevelToCarrierUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this LevelToCarrier to another LevelToCarrier with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A LevelToCarrier with the specified unit.</returns>
                public LevelToCarrier ToUnit(LevelToCarrierUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new LevelToCarrier(convertedValue, unit);
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
                        LevelToCarrierUnit.DecibelCarrier => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(LevelToCarrierUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        LevelToCarrierUnit.DecibelCarrier => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


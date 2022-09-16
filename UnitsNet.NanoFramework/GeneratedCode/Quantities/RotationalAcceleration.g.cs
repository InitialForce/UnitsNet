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
    ///     Angular acceleration is the rate of change of rotational speed.
    /// </summary>
    public struct  RotationalAcceleration
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly RotationalAccelerationUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public RotationalAccelerationUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public RotationalAcceleration(double value, RotationalAccelerationUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static RotationalAccelerationUnit BaseUnit { get; } = RotationalAccelerationUnit.RadianPerSecondSquared;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static RotationalAcceleration MaxValue { get; } = new RotationalAcceleration(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static RotationalAcceleration MinValue { get; } = new RotationalAcceleration(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static RotationalAcceleration Zero { get; } = new RotationalAcceleration(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RotationalAccelerationUnit.DegreePerSecondSquared"/>
        /// </summary>
        public double DegreesPerSecondSquared => As(RotationalAccelerationUnit.DegreePerSecondSquared);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RotationalAccelerationUnit.RadianPerSecondSquared"/>
        /// </summary>
        public double RadiansPerSecondSquared => As(RotationalAccelerationUnit.RadianPerSecondSquared);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RotationalAccelerationUnit.RevolutionPerMinutePerSecond"/>
        /// </summary>
        public double RevolutionsPerMinutePerSecond => As(RotationalAccelerationUnit.RevolutionPerMinutePerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RotationalAccelerationUnit.RevolutionPerSecondSquared"/>
        /// </summary>
        public double RevolutionsPerSecondSquared => As(RotationalAccelerationUnit.RevolutionPerSecondSquared);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="RotationalAcceleration"/> from <see cref="RotationalAccelerationUnit.DegreePerSecondSquared"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalAcceleration FromDegreesPerSecondSquared(double degreespersecondsquared) => new RotationalAcceleration(degreespersecondsquared, RotationalAccelerationUnit.DegreePerSecondSquared);

        /// <summary>
        ///     Creates a <see cref="RotationalAcceleration"/> from <see cref="RotationalAccelerationUnit.RadianPerSecondSquared"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalAcceleration FromRadiansPerSecondSquared(double radianspersecondsquared) => new RotationalAcceleration(radianspersecondsquared, RotationalAccelerationUnit.RadianPerSecondSquared);

        /// <summary>
        ///     Creates a <see cref="RotationalAcceleration"/> from <see cref="RotationalAccelerationUnit.RevolutionPerMinutePerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalAcceleration FromRevolutionsPerMinutePerSecond(double revolutionsperminutepersecond) => new RotationalAcceleration(revolutionsperminutepersecond, RotationalAccelerationUnit.RevolutionPerMinutePerSecond);

        /// <summary>
        ///     Creates a <see cref="RotationalAcceleration"/> from <see cref="RotationalAccelerationUnit.RevolutionPerSecondSquared"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalAcceleration FromRevolutionsPerSecondSquared(double revolutionspersecondsquared) => new RotationalAcceleration(revolutionspersecondsquared, RotationalAccelerationUnit.RevolutionPerSecondSquared);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RotationalAccelerationUnit" /> to <see cref="RotationalAcceleration" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>RotationalAcceleration unit value.</returns>
        public static RotationalAcceleration From(double value, RotationalAccelerationUnit fromUnit)
        {
            return new RotationalAcceleration(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(RotationalAccelerationUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public RotationalAcceleration ToUnit(RotationalAccelerationUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new RotationalAcceleration(convertedValue, unit);
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
                RotationalAccelerationUnit.DegreePerSecondSquared => (3.1415926535897931 / 180) * _value,
                RotationalAccelerationUnit.RadianPerSecondSquared => _value,
                RotationalAccelerationUnit.RevolutionPerMinutePerSecond => ((2 * 3.1415926535897931) / 60) * _value,
                RotationalAccelerationUnit.RevolutionPerSecondSquared => (2 * 3.1415926535897931) * _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(RotationalAccelerationUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                RotationalAccelerationUnit.DegreePerSecondSquared => (180 / 3.1415926535897931) * baseUnitValue,
                RotationalAccelerationUnit.RadianPerSecondSquared => baseUnitValue,
                RotationalAccelerationUnit.RevolutionPerMinutePerSecond => (60 / (2 * 3.1415926535897931)) * baseUnitValue,
                RotationalAccelerationUnit.RevolutionPerSecondSquared => (1 / (2 * 3.1415926535897931)) * baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}


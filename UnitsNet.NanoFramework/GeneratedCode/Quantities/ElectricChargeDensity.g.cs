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
    ///     In electromagnetism, charge density is a measure of the amount of electric charge per volume.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Charge_density
    /// </remarks>
    public struct  ElectricChargeDensity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricChargeDensityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricChargeDensityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public ElectricChargeDensity(double value, ElectricChargeDensityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of ElectricChargeDensity, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricChargeDensityUnit BaseUnit { get; } = ElectricChargeDensityUnit.CoulombPerCubicMeter;

        /// <summary>
        /// Represents the largest possible value of ElectricChargeDensity.
        /// </summary>
        public static ElectricChargeDensity MaxValue { get; } = new ElectricChargeDensity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ElectricChargeDensity.
        /// </summary>
        public static ElectricChargeDensity MinValue { get; } = new ElectricChargeDensity(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricChargeDensity Zero { get; } = new ElectricChargeDensity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeDensityUnit.CoulombPerCubicMeter"/>
        /// </summary>
        public double CoulombsPerCubicMeter => As(ElectricChargeDensityUnit.CoulombPerCubicMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricChargeDensity"/> from <see cref="ElectricChargeDensityUnit.CoulombPerCubicMeter"/>.
        /// </summary>
        public static ElectricChargeDensity FromCoulombsPerCubicMeter(double coulombspercubicmeter) => new ElectricChargeDensity(coulombspercubicmeter, ElectricChargeDensityUnit.CoulombPerCubicMeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricChargeDensityUnit" /> to <see cref="ElectricChargeDensity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricChargeDensity unit value.</returns>
        public static ElectricChargeDensity From(double value, ElectricChargeDensityUnit fromUnit)
        {
            return new ElectricChargeDensity(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ElectricChargeDensityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this ElectricChargeDensity to another ElectricChargeDensity with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A ElectricChargeDensity with the specified unit.</returns>
                public ElectricChargeDensity ToUnit(ElectricChargeDensityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ElectricChargeDensity(convertedValue, unit);
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
                        ElectricChargeDensityUnit.CoulombPerCubicMeter => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ElectricChargeDensityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ElectricChargeDensityUnit.CoulombPerCubicMeter => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


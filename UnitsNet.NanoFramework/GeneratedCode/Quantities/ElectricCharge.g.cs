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
    ///     Electric charge is the physical property of matter that causes it to experience a force when placed in an electromagnetic field.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Electric_charge
    /// </remarks>
    public struct  ElectricCharge
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricChargeUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricChargeUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricCharge(double value, ElectricChargeUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricChargeUnit BaseUnit { get; } = ElectricChargeUnit.Coulomb;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricCharge MaxValue { get; } = new ElectricCharge(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricCharge MinValue { get; } = new ElectricCharge(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricCharge Zero { get; } = new ElectricCharge(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.AmpereHour"/>
        /// </summary>
        public double AmpereHours => As(ElectricChargeUnit.AmpereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.Coulomb"/>
        /// </summary>
        public double Coulombs => As(ElectricChargeUnit.Coulomb);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.KiloampereHour"/>
        /// </summary>
        public double KiloampereHours => As(ElectricChargeUnit.KiloampereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.MegaampereHour"/>
        /// </summary>
        public double MegaampereHours => As(ElectricChargeUnit.MegaampereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.MilliampereHour"/>
        /// </summary>
        public double MilliampereHours => As(ElectricChargeUnit.MilliampereHour);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.AmpereHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromAmpereHours(double amperehours) => new ElectricCharge(amperehours, ElectricChargeUnit.AmpereHour);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.Coulomb"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromCoulombs(double coulombs) => new ElectricCharge(coulombs, ElectricChargeUnit.Coulomb);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.KiloampereHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromKiloampereHours(double kiloamperehours) => new ElectricCharge(kiloamperehours, ElectricChargeUnit.KiloampereHour);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.MegaampereHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromMegaampereHours(double megaamperehours) => new ElectricCharge(megaamperehours, ElectricChargeUnit.MegaampereHour);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.MilliampereHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromMilliampereHours(double milliamperehours) => new ElectricCharge(milliamperehours, ElectricChargeUnit.MilliampereHour);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricChargeUnit" /> to <see cref="ElectricCharge" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricCharge unit value.</returns>
        public static ElectricCharge From(double value, ElectricChargeUnit fromUnit)
        {
            return new ElectricCharge(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricChargeUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricCharge ToUnit(ElectricChargeUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricCharge(convertedValue, unit);
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
                ElectricChargeUnit.AmpereHour => _value / 2.77777777777e-4,
                ElectricChargeUnit.Coulomb => _value,
                ElectricChargeUnit.KiloampereHour => (_value / 2.77777777777e-4) * 1e3d,
                ElectricChargeUnit.MegaampereHour => (_value / 2.77777777777e-4) * 1e6d,
                ElectricChargeUnit.MilliampereHour => (_value / 2.77777777777e-4) * 1e-3d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(ElectricChargeUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ElectricChargeUnit.AmpereHour => baseUnitValue * 2.77777777777e-4,
                ElectricChargeUnit.Coulomb => baseUnitValue,
                ElectricChargeUnit.KiloampereHour => (baseUnitValue * 2.77777777777e-4) / 1e3d,
                ElectricChargeUnit.MegaampereHour => (baseUnitValue * 2.77777777777e-4) / 1e6d,
                ElectricChargeUnit.MilliampereHour => (baseUnitValue * 2.77777777777e-4) / 1e-3d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}


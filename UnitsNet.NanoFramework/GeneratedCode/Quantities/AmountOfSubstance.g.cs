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
    ///     Mole is the amount of substance containing Avagadro's Number (6.02 x 10 ^ 23) of real particles such as molecules,atoms, ions or radicals.
    /// </summary>
    public struct  AmountOfSubstance
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AmountOfSubstanceUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public AmountOfSubstanceUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public AmountOfSubstance(double value, AmountOfSubstanceUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static AmountOfSubstanceUnit BaseUnit { get; } = AmountOfSubstanceUnit.Mole;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static AmountOfSubstance MaxValue { get; } = new AmountOfSubstance(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static AmountOfSubstance MinValue { get; } = new AmountOfSubstance(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static AmountOfSubstance Zero { get; } = new AmountOfSubstance(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.Centimole"/>
        /// </summary>
        public double Centimoles => As(AmountOfSubstanceUnit.Centimole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.CentipoundMole"/>
        /// </summary>
        public double CentipoundMoles => As(AmountOfSubstanceUnit.CentipoundMole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.Decimole"/>
        /// </summary>
        public double Decimoles => As(AmountOfSubstanceUnit.Decimole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.DecipoundMole"/>
        /// </summary>
        public double DecipoundMoles => As(AmountOfSubstanceUnit.DecipoundMole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.Kilomole"/>
        /// </summary>
        public double Kilomoles => As(AmountOfSubstanceUnit.Kilomole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.KilopoundMole"/>
        /// </summary>
        public double KilopoundMoles => As(AmountOfSubstanceUnit.KilopoundMole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.Megamole"/>
        /// </summary>
        public double Megamoles => As(AmountOfSubstanceUnit.Megamole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.Micromole"/>
        /// </summary>
        public double Micromoles => As(AmountOfSubstanceUnit.Micromole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.MicropoundMole"/>
        /// </summary>
        public double MicropoundMoles => As(AmountOfSubstanceUnit.MicropoundMole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.Millimole"/>
        /// </summary>
        public double Millimoles => As(AmountOfSubstanceUnit.Millimole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.MillipoundMole"/>
        /// </summary>
        public double MillipoundMoles => As(AmountOfSubstanceUnit.MillipoundMole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.Mole"/>
        /// </summary>
        public double Moles => As(AmountOfSubstanceUnit.Mole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.Nanomole"/>
        /// </summary>
        public double Nanomoles => As(AmountOfSubstanceUnit.Nanomole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.NanopoundMole"/>
        /// </summary>
        public double NanopoundMoles => As(AmountOfSubstanceUnit.NanopoundMole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AmountOfSubstanceUnit.PoundMole"/>
        /// </summary>
        public double PoundMoles => As(AmountOfSubstanceUnit.PoundMole);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.Centimole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromCentimoles(double centimoles) => new AmountOfSubstance(centimoles, AmountOfSubstanceUnit.Centimole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.CentipoundMole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromCentipoundMoles(double centipoundmoles) => new AmountOfSubstance(centipoundmoles, AmountOfSubstanceUnit.CentipoundMole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.Decimole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromDecimoles(double decimoles) => new AmountOfSubstance(decimoles, AmountOfSubstanceUnit.Decimole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.DecipoundMole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromDecipoundMoles(double decipoundmoles) => new AmountOfSubstance(decipoundmoles, AmountOfSubstanceUnit.DecipoundMole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.Kilomole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromKilomoles(double kilomoles) => new AmountOfSubstance(kilomoles, AmountOfSubstanceUnit.Kilomole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.KilopoundMole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromKilopoundMoles(double kilopoundmoles) => new AmountOfSubstance(kilopoundmoles, AmountOfSubstanceUnit.KilopoundMole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.Megamole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMegamoles(double megamoles) => new AmountOfSubstance(megamoles, AmountOfSubstanceUnit.Megamole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.Micromole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMicromoles(double micromoles) => new AmountOfSubstance(micromoles, AmountOfSubstanceUnit.Micromole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.MicropoundMole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMicropoundMoles(double micropoundmoles) => new AmountOfSubstance(micropoundmoles, AmountOfSubstanceUnit.MicropoundMole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.Millimole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMillimoles(double millimoles) => new AmountOfSubstance(millimoles, AmountOfSubstanceUnit.Millimole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.MillipoundMole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMillipoundMoles(double millipoundmoles) => new AmountOfSubstance(millipoundmoles, AmountOfSubstanceUnit.MillipoundMole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.Mole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromMoles(double moles) => new AmountOfSubstance(moles, AmountOfSubstanceUnit.Mole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.Nanomole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromNanomoles(double nanomoles) => new AmountOfSubstance(nanomoles, AmountOfSubstanceUnit.Nanomole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.NanopoundMole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromNanopoundMoles(double nanopoundmoles) => new AmountOfSubstance(nanopoundmoles, AmountOfSubstanceUnit.NanopoundMole);

        /// <summary>
        ///     Creates a <see cref="AmountOfSubstance"/> from <see cref="AmountOfSubstanceUnit.PoundMole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AmountOfSubstance FromPoundMoles(double poundmoles) => new AmountOfSubstance(poundmoles, AmountOfSubstanceUnit.PoundMole);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AmountOfSubstanceUnit" /> to <see cref="AmountOfSubstance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>AmountOfSubstance unit value.</returns>
        public static AmountOfSubstance From(double value, AmountOfSubstanceUnit fromUnit)
        {
            return new AmountOfSubstance(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AmountOfSubstanceUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public AmountOfSubstance ToUnit(AmountOfSubstanceUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new AmountOfSubstance(convertedValue, unit);
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
                AmountOfSubstanceUnit.Centimole => (_value) * 1e-2d,
                AmountOfSubstanceUnit.CentipoundMole => (_value * 453.59237) * 1e-2d,
                AmountOfSubstanceUnit.Decimole => (_value) * 1e-1d,
                AmountOfSubstanceUnit.DecipoundMole => (_value * 453.59237) * 1e-1d,
                AmountOfSubstanceUnit.Kilomole => (_value) * 1e3d,
                AmountOfSubstanceUnit.KilopoundMole => (_value * 453.59237) * 1e3d,
                AmountOfSubstanceUnit.Megamole => (_value) * 1e6d,
                AmountOfSubstanceUnit.Micromole => (_value) * 1e-6d,
                AmountOfSubstanceUnit.MicropoundMole => (_value * 453.59237) * 1e-6d,
                AmountOfSubstanceUnit.Millimole => (_value) * 1e-3d,
                AmountOfSubstanceUnit.MillipoundMole => (_value * 453.59237) * 1e-3d,
                AmountOfSubstanceUnit.Mole => _value,
                AmountOfSubstanceUnit.Nanomole => (_value) * 1e-9d,
                AmountOfSubstanceUnit.NanopoundMole => (_value * 453.59237) * 1e-9d,
                AmountOfSubstanceUnit.PoundMole => _value * 453.59237,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(AmountOfSubstanceUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                AmountOfSubstanceUnit.Centimole => (baseUnitValue) / 1e-2d,
                AmountOfSubstanceUnit.CentipoundMole => (baseUnitValue / 453.59237) / 1e-2d,
                AmountOfSubstanceUnit.Decimole => (baseUnitValue) / 1e-1d,
                AmountOfSubstanceUnit.DecipoundMole => (baseUnitValue / 453.59237) / 1e-1d,
                AmountOfSubstanceUnit.Kilomole => (baseUnitValue) / 1e3d,
                AmountOfSubstanceUnit.KilopoundMole => (baseUnitValue / 453.59237) / 1e3d,
                AmountOfSubstanceUnit.Megamole => (baseUnitValue) / 1e6d,
                AmountOfSubstanceUnit.Micromole => (baseUnitValue) / 1e-6d,
                AmountOfSubstanceUnit.MicropoundMole => (baseUnitValue / 453.59237) / 1e-6d,
                AmountOfSubstanceUnit.Millimole => (baseUnitValue) / 1e-3d,
                AmountOfSubstanceUnit.MillipoundMole => (baseUnitValue / 453.59237) / 1e-3d,
                AmountOfSubstanceUnit.Mole => baseUnitValue,
                AmountOfSubstanceUnit.Nanomole => (baseUnitValue) / 1e-9d,
                AmountOfSubstanceUnit.NanopoundMole => (baseUnitValue / 453.59237) / 1e-9d,
                AmountOfSubstanceUnit.PoundMole => baseUnitValue / 453.59237,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}


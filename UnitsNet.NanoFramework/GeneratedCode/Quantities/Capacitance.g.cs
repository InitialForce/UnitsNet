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
    ///     Capacitance is the ability of a body to store an electric charge.
    /// </summary>
    /// <remarks>
    ///     <see cref="Capacitance" /> has been renamed to <see cref="ElectricCapacitance" />, and will be removed in a later major version.
    /// </remarks>
    [Obsolete("Capacitance has been renamed to ElectricCapacitance, and will be removed in a later major version.")]
    public struct  Capacitance
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly CapacitanceUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public CapacitanceUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Capacitance(double value, CapacitanceUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Capacitance, which is Second. All conversions go via this value.
        /// </summary>
        public static CapacitanceUnit BaseUnit { get; } = CapacitanceUnit.Farad;

        /// <summary>
        /// Represents the largest possible value of Capacitance.
        /// </summary>
        public static Capacitance MaxValue { get; } = new Capacitance(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Capacitance.
        /// </summary>
        public static Capacitance MinValue { get; } = new Capacitance(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Capacitance Zero { get; } = new Capacitance(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CapacitanceUnit.Farad"/>
        /// </summary>
        public double Farads => As(CapacitanceUnit.Farad);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CapacitanceUnit.Kilofarad"/>
        /// </summary>
        public double Kilofarads => As(CapacitanceUnit.Kilofarad);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CapacitanceUnit.Megafarad"/>
        /// </summary>
        public double Megafarads => As(CapacitanceUnit.Megafarad);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CapacitanceUnit.Microfarad"/>
        /// </summary>
        public double Microfarads => As(CapacitanceUnit.Microfarad);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CapacitanceUnit.Millifarad"/>
        /// </summary>
        public double Millifarads => As(CapacitanceUnit.Millifarad);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CapacitanceUnit.Nanofarad"/>
        /// </summary>
        public double Nanofarads => As(CapacitanceUnit.Nanofarad);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CapacitanceUnit.Picofarad"/>
        /// </summary>
        public double Picofarads => As(CapacitanceUnit.Picofarad);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Capacitance"/> from <see cref="CapacitanceUnit.Farad"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromFarads(double farads) => new Capacitance(farads, CapacitanceUnit.Farad);

        /// <summary>
        ///     Creates a <see cref="Capacitance"/> from <see cref="CapacitanceUnit.Kilofarad"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromKilofarads(double kilofarads) => new Capacitance(kilofarads, CapacitanceUnit.Kilofarad);

        /// <summary>
        ///     Creates a <see cref="Capacitance"/> from <see cref="CapacitanceUnit.Megafarad"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromMegafarads(double megafarads) => new Capacitance(megafarads, CapacitanceUnit.Megafarad);

        /// <summary>
        ///     Creates a <see cref="Capacitance"/> from <see cref="CapacitanceUnit.Microfarad"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromMicrofarads(double microfarads) => new Capacitance(microfarads, CapacitanceUnit.Microfarad);

        /// <summary>
        ///     Creates a <see cref="Capacitance"/> from <see cref="CapacitanceUnit.Millifarad"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromMillifarads(double millifarads) => new Capacitance(millifarads, CapacitanceUnit.Millifarad);

        /// <summary>
        ///     Creates a <see cref="Capacitance"/> from <see cref="CapacitanceUnit.Nanofarad"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromNanofarads(double nanofarads) => new Capacitance(nanofarads, CapacitanceUnit.Nanofarad);

        /// <summary>
        ///     Creates a <see cref="Capacitance"/> from <see cref="CapacitanceUnit.Picofarad"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Capacitance FromPicofarads(double picofarads) => new Capacitance(picofarads, CapacitanceUnit.Picofarad);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="CapacitanceUnit" /> to <see cref="Capacitance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Capacitance unit value.</returns>
        public static Capacitance From(double value, CapacitanceUnit fromUnit)
        {
            return new Capacitance(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(CapacitanceUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Capacitance to another Capacitance with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Capacitance with the specified unit.</returns>
                public Capacitance ToUnit(CapacitanceUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Capacitance(convertedValue, unit);
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
                        CapacitanceUnit.Farad => _value,
                        CapacitanceUnit.Kilofarad => (_value) * 1e3d,
                        CapacitanceUnit.Megafarad => (_value) * 1e6d,
                        CapacitanceUnit.Microfarad => (_value) * 1e-6d,
                        CapacitanceUnit.Millifarad => (_value) * 1e-3d,
                        CapacitanceUnit.Nanofarad => (_value) * 1e-9d,
                        CapacitanceUnit.Picofarad => (_value) * 1e-12d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(CapacitanceUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        CapacitanceUnit.Farad => baseUnitValue,
                        CapacitanceUnit.Kilofarad => (baseUnitValue) / 1e3d,
                        CapacitanceUnit.Megafarad => (baseUnitValue) / 1e6d,
                        CapacitanceUnit.Microfarad => (baseUnitValue) / 1e-6d,
                        CapacitanceUnit.Millifarad => (baseUnitValue) / 1e-3d,
                        CapacitanceUnit.Nanofarad => (baseUnitValue) / 1e-9d,
                        CapacitanceUnit.Picofarad => (baseUnitValue) / 1e-12d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


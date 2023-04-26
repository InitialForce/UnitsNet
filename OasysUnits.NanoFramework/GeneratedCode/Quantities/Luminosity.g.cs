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
using OasysUnits.Units;

namespace OasysUnits
{
    /// <inheritdoc />
    /// <summary>
    ///     Luminosity is an absolute measure of radiated electromagnetic power (light), the radiant power emitted by a light-emitting object.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Luminosity
    /// </remarks>
    public struct  Luminosity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly LuminosityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public LuminosityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Luminosity(double value, LuminosityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static LuminosityUnit BaseUnit { get; } = LuminosityUnit.Watt;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Luminosity MaxValue { get; } = new Luminosity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Luminosity MinValue { get; } = new Luminosity(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Luminosity Zero { get; } = new Luminosity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Decawatt"/>
        /// </summary>
        public double Decawatts => As(LuminosityUnit.Decawatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Deciwatt"/>
        /// </summary>
        public double Deciwatts => As(LuminosityUnit.Deciwatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Femtowatt"/>
        /// </summary>
        public double Femtowatts => As(LuminosityUnit.Femtowatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Gigawatt"/>
        /// </summary>
        public double Gigawatts => As(LuminosityUnit.Gigawatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Kilowatt"/>
        /// </summary>
        public double Kilowatts => As(LuminosityUnit.Kilowatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Megawatt"/>
        /// </summary>
        public double Megawatts => As(LuminosityUnit.Megawatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Microwatt"/>
        /// </summary>
        public double Microwatts => As(LuminosityUnit.Microwatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Milliwatt"/>
        /// </summary>
        public double Milliwatts => As(LuminosityUnit.Milliwatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Nanowatt"/>
        /// </summary>
        public double Nanowatts => As(LuminosityUnit.Nanowatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Petawatt"/>
        /// </summary>
        public double Petawatts => As(LuminosityUnit.Petawatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Picowatt"/>
        /// </summary>
        public double Picowatts => As(LuminosityUnit.Picowatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.SolarLuminosity"/>
        /// </summary>
        public double SolarLuminosities => As(LuminosityUnit.SolarLuminosity);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Terawatt"/>
        /// </summary>
        public double Terawatts => As(LuminosityUnit.Terawatt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminosityUnit.Watt"/>
        /// </summary>
        public double Watts => As(LuminosityUnit.Watt);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Decawatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromDecawatts(double decawatts) => new Luminosity(decawatts, LuminosityUnit.Decawatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Deciwatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromDeciwatts(double deciwatts) => new Luminosity(deciwatts, LuminosityUnit.Deciwatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Femtowatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromFemtowatts(double femtowatts) => new Luminosity(femtowatts, LuminosityUnit.Femtowatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Gigawatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromGigawatts(double gigawatts) => new Luminosity(gigawatts, LuminosityUnit.Gigawatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Kilowatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromKilowatts(double kilowatts) => new Luminosity(kilowatts, LuminosityUnit.Kilowatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Megawatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromMegawatts(double megawatts) => new Luminosity(megawatts, LuminosityUnit.Megawatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Microwatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromMicrowatts(double microwatts) => new Luminosity(microwatts, LuminosityUnit.Microwatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Milliwatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromMilliwatts(double milliwatts) => new Luminosity(milliwatts, LuminosityUnit.Milliwatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Nanowatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromNanowatts(double nanowatts) => new Luminosity(nanowatts, LuminosityUnit.Nanowatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Petawatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromPetawatts(double petawatts) => new Luminosity(petawatts, LuminosityUnit.Petawatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Picowatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromPicowatts(double picowatts) => new Luminosity(picowatts, LuminosityUnit.Picowatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.SolarLuminosity"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromSolarLuminosities(double solarluminosities) => new Luminosity(solarluminosities, LuminosityUnit.SolarLuminosity);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Terawatt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromTerawatts(double terawatts) => new Luminosity(terawatts, LuminosityUnit.Terawatt);

        /// <summary>
        ///     Creates a <see cref="Luminosity"/> from <see cref="LuminosityUnit.Watt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Luminosity FromWatts(double watts) => new Luminosity(watts, LuminosityUnit.Watt);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LuminosityUnit" /> to <see cref="Luminosity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Luminosity unit value.</returns>
        public static Luminosity From(double value, LuminosityUnit fromUnit)
        {
            return new Luminosity(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(LuminosityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Duration with the specified unit.</returns>
                public Luminosity ToUnit(LuminosityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Luminosity(convertedValue, unit);
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
                        LuminosityUnit.Decawatt => (_value) * 1e1d,
                        LuminosityUnit.Deciwatt => (_value) * 1e-1d,
                        LuminosityUnit.Femtowatt => (_value) * 1e-15d,
                        LuminosityUnit.Gigawatt => (_value) * 1e9d,
                        LuminosityUnit.Kilowatt => (_value) * 1e3d,
                        LuminosityUnit.Megawatt => (_value) * 1e6d,
                        LuminosityUnit.Microwatt => (_value) * 1e-6d,
                        LuminosityUnit.Milliwatt => (_value) * 1e-3d,
                        LuminosityUnit.Nanowatt => (_value) * 1e-9d,
                        LuminosityUnit.Petawatt => (_value) * 1e15d,
                        LuminosityUnit.Picowatt => (_value) * 1e-12d,
                        LuminosityUnit.SolarLuminosity => _value * 3.846e26,
                        LuminosityUnit.Terawatt => (_value) * 1e12d,
                        LuminosityUnit.Watt => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(LuminosityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        LuminosityUnit.Decawatt => (baseUnitValue) / 1e1d,
                        LuminosityUnit.Deciwatt => (baseUnitValue) / 1e-1d,
                        LuminosityUnit.Femtowatt => (baseUnitValue) / 1e-15d,
                        LuminosityUnit.Gigawatt => (baseUnitValue) / 1e9d,
                        LuminosityUnit.Kilowatt => (baseUnitValue) / 1e3d,
                        LuminosityUnit.Megawatt => (baseUnitValue) / 1e6d,
                        LuminosityUnit.Microwatt => (baseUnitValue) / 1e-6d,
                        LuminosityUnit.Milliwatt => (baseUnitValue) / 1e-3d,
                        LuminosityUnit.Nanowatt => (baseUnitValue) / 1e-9d,
                        LuminosityUnit.Petawatt => (baseUnitValue) / 1e15d,
                        LuminosityUnit.Picowatt => (baseUnitValue) / 1e-12d,
                        LuminosityUnit.SolarLuminosity => baseUnitValue / 3.846e26,
                        LuminosityUnit.Terawatt => (baseUnitValue) / 1e12d,
                        LuminosityUnit.Watt => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


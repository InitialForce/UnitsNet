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
    ///     A magnetic field is a force field that is created by moving electric charges (electric currents) and magnetic dipoles, and exerts a force on other nearby moving charges and magnetic dipoles.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Magnetic_field
    /// </remarks>
    public struct  MagneticField
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MagneticFieldUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MagneticFieldUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public MagneticField(double value, MagneticFieldUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static MagneticFieldUnit BaseUnit { get; } = MagneticFieldUnit.Tesla;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static MagneticField MaxValue { get; } = new MagneticField(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static MagneticField MinValue { get; } = new MagneticField(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static MagneticField Zero { get; } = new MagneticField(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MagneticFieldUnit.Gauss"/>
        /// </summary>
        public double Gausses => As(MagneticFieldUnit.Gauss);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MagneticFieldUnit.Microtesla"/>
        /// </summary>
        public double Microteslas => As(MagneticFieldUnit.Microtesla);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MagneticFieldUnit.Milligauss"/>
        /// </summary>
        public double Milligausses => As(MagneticFieldUnit.Milligauss);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MagneticFieldUnit.Millitesla"/>
        /// </summary>
        public double Milliteslas => As(MagneticFieldUnit.Millitesla);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MagneticFieldUnit.Nanotesla"/>
        /// </summary>
        public double Nanoteslas => As(MagneticFieldUnit.Nanotesla);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MagneticFieldUnit.Tesla"/>
        /// </summary>
        public double Teslas => As(MagneticFieldUnit.Tesla);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="MagneticField"/> from <see cref="MagneticFieldUnit.Gauss"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromGausses(double gausses) => new MagneticField(gausses, MagneticFieldUnit.Gauss);

        /// <summary>
        ///     Creates a <see cref="MagneticField"/> from <see cref="MagneticFieldUnit.Microtesla"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromMicroteslas(double microteslas) => new MagneticField(microteslas, MagneticFieldUnit.Microtesla);

        /// <summary>
        ///     Creates a <see cref="MagneticField"/> from <see cref="MagneticFieldUnit.Milligauss"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromMilligausses(double milligausses) => new MagneticField(milligausses, MagneticFieldUnit.Milligauss);

        /// <summary>
        ///     Creates a <see cref="MagneticField"/> from <see cref="MagneticFieldUnit.Millitesla"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromMilliteslas(double milliteslas) => new MagneticField(milliteslas, MagneticFieldUnit.Millitesla);

        /// <summary>
        ///     Creates a <see cref="MagneticField"/> from <see cref="MagneticFieldUnit.Nanotesla"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromNanoteslas(double nanoteslas) => new MagneticField(nanoteslas, MagneticFieldUnit.Nanotesla);

        /// <summary>
        ///     Creates a <see cref="MagneticField"/> from <see cref="MagneticFieldUnit.Tesla"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticField FromTeslas(double teslas) => new MagneticField(teslas, MagneticFieldUnit.Tesla);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MagneticFieldUnit" /> to <see cref="MagneticField" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MagneticField unit value.</returns>
        public static MagneticField From(double value, MagneticFieldUnit fromUnit)
        {
            return new MagneticField(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(MagneticFieldUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Duration with the specified unit.</returns>
                public MagneticField ToUnit(MagneticFieldUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new MagneticField(convertedValue, unit);
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
                        MagneticFieldUnit.Gauss => _value / 1e4,
                        MagneticFieldUnit.Microtesla => (_value) * 1e-6d,
                        MagneticFieldUnit.Milligauss => (_value / 1e4) * 1e-3d,
                        MagneticFieldUnit.Millitesla => (_value) * 1e-3d,
                        MagneticFieldUnit.Nanotesla => (_value) * 1e-9d,
                        MagneticFieldUnit.Tesla => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(MagneticFieldUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        MagneticFieldUnit.Gauss => baseUnitValue * 1e4,
                        MagneticFieldUnit.Microtesla => (baseUnitValue) / 1e-6d,
                        MagneticFieldUnit.Milligauss => (baseUnitValue * 1e4) / 1e-3d,
                        MagneticFieldUnit.Millitesla => (baseUnitValue) / 1e-3d,
                        MagneticFieldUnit.Nanotesla => (baseUnitValue) / 1e-9d,
                        MagneticFieldUnit.Tesla => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


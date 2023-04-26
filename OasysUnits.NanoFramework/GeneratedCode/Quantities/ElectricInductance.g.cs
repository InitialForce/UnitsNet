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
    ///     Inductance is a property of an electrical conductor which opposes a change in current.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Inductance
    /// </remarks>
    public struct  ElectricInductance
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricInductanceUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricInductanceUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricInductance(double value, ElectricInductanceUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricInductanceUnit BaseUnit { get; } = ElectricInductanceUnit.Henry;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricInductance MaxValue { get; } = new ElectricInductance(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricInductance MinValue { get; } = new ElectricInductance(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricInductance Zero { get; } = new ElectricInductance(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricInductanceUnit.Henry"/>
        /// </summary>
        public double Henries => As(ElectricInductanceUnit.Henry);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricInductanceUnit.Microhenry"/>
        /// </summary>
        public double Microhenries => As(ElectricInductanceUnit.Microhenry);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricInductanceUnit.Millihenry"/>
        /// </summary>
        public double Millihenries => As(ElectricInductanceUnit.Millihenry);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricInductanceUnit.Nanohenry"/>
        /// </summary>
        public double Nanohenries => As(ElectricInductanceUnit.Nanohenry);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricInductanceUnit.Picohenry"/>
        /// </summary>
        public double Picohenries => As(ElectricInductanceUnit.Picohenry);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricInductance"/> from <see cref="ElectricInductanceUnit.Henry"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricInductance FromHenries(double henries) => new ElectricInductance(henries, ElectricInductanceUnit.Henry);

        /// <summary>
        ///     Creates a <see cref="ElectricInductance"/> from <see cref="ElectricInductanceUnit.Microhenry"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricInductance FromMicrohenries(double microhenries) => new ElectricInductance(microhenries, ElectricInductanceUnit.Microhenry);

        /// <summary>
        ///     Creates a <see cref="ElectricInductance"/> from <see cref="ElectricInductanceUnit.Millihenry"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricInductance FromMillihenries(double millihenries) => new ElectricInductance(millihenries, ElectricInductanceUnit.Millihenry);

        /// <summary>
        ///     Creates a <see cref="ElectricInductance"/> from <see cref="ElectricInductanceUnit.Nanohenry"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricInductance FromNanohenries(double nanohenries) => new ElectricInductance(nanohenries, ElectricInductanceUnit.Nanohenry);

        /// <summary>
        ///     Creates a <see cref="ElectricInductance"/> from <see cref="ElectricInductanceUnit.Picohenry"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricInductance FromPicohenries(double picohenries) => new ElectricInductance(picohenries, ElectricInductanceUnit.Picohenry);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricInductanceUnit" /> to <see cref="ElectricInductance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricInductance unit value.</returns>
        public static ElectricInductance From(double value, ElectricInductanceUnit fromUnit)
        {
            return new ElectricInductance(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ElectricInductanceUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Duration with the specified unit.</returns>
                public ElectricInductance ToUnit(ElectricInductanceUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ElectricInductance(convertedValue, unit);
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
                        ElectricInductanceUnit.Henry => _value,
                        ElectricInductanceUnit.Microhenry => (_value) * 1e-6d,
                        ElectricInductanceUnit.Millihenry => (_value) * 1e-3d,
                        ElectricInductanceUnit.Nanohenry => (_value) * 1e-9d,
                        ElectricInductanceUnit.Picohenry => (_value) * 1e-12d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ElectricInductanceUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ElectricInductanceUnit.Henry => baseUnitValue,
                        ElectricInductanceUnit.Microhenry => (baseUnitValue) / 1e-6d,
                        ElectricInductanceUnit.Millihenry => (baseUnitValue) / 1e-3d,
                        ElectricInductanceUnit.Nanohenry => (baseUnitValue) / 1e-9d,
                        ElectricInductanceUnit.Picohenry => (baseUnitValue) / 1e-12d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


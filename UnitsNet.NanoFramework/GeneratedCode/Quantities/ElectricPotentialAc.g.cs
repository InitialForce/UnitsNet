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
    ///     The Electric Potential of a system known to use Alternating Current.
    /// </summary>
    public struct  ElectricPotentialAc
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricPotentialAcUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricPotentialAcUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public ElectricPotentialAc(double value, ElectricPotentialAcUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of ElectricPotentialAc, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricPotentialAcUnit BaseUnit { get; } = ElectricPotentialAcUnit.VoltAc;

        /// <summary>
        /// Represents the largest possible value of ElectricPotentialAc.
        /// </summary>
        public static ElectricPotentialAc MaxValue { get; } = new ElectricPotentialAc(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ElectricPotentialAc.
        /// </summary>
        public static ElectricPotentialAc MinValue { get; } = new ElectricPotentialAc(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricPotentialAc Zero { get; } = new ElectricPotentialAc(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialAcUnit.KilovoltAc"/>
        /// </summary>
        public double KilovoltsAc => As(ElectricPotentialAcUnit.KilovoltAc);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialAcUnit.MegavoltAc"/>
        /// </summary>
        public double MegavoltsAc => As(ElectricPotentialAcUnit.MegavoltAc);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialAcUnit.MicrovoltAc"/>
        /// </summary>
        public double MicrovoltsAc => As(ElectricPotentialAcUnit.MicrovoltAc);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialAcUnit.MillivoltAc"/>
        /// </summary>
        public double MillivoltsAc => As(ElectricPotentialAcUnit.MillivoltAc);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialAcUnit.VoltAc"/>
        /// </summary>
        public double VoltsAc => As(ElectricPotentialAcUnit.VoltAc);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialAc"/> from <see cref="ElectricPotentialAcUnit.KilovoltAc"/>.
        /// </summary>
        public static ElectricPotentialAc FromKilovoltsAc(double kilovoltsac) => new ElectricPotentialAc(kilovoltsac, ElectricPotentialAcUnit.KilovoltAc);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialAc"/> from <see cref="ElectricPotentialAcUnit.MegavoltAc"/>.
        /// </summary>
        public static ElectricPotentialAc FromMegavoltsAc(double megavoltsac) => new ElectricPotentialAc(megavoltsac, ElectricPotentialAcUnit.MegavoltAc);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialAc"/> from <see cref="ElectricPotentialAcUnit.MicrovoltAc"/>.
        /// </summary>
        public static ElectricPotentialAc FromMicrovoltsAc(double microvoltsac) => new ElectricPotentialAc(microvoltsac, ElectricPotentialAcUnit.MicrovoltAc);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialAc"/> from <see cref="ElectricPotentialAcUnit.MillivoltAc"/>.
        /// </summary>
        public static ElectricPotentialAc FromMillivoltsAc(double millivoltsac) => new ElectricPotentialAc(millivoltsac, ElectricPotentialAcUnit.MillivoltAc);

        /// <summary>
        ///     Creates a <see cref="ElectricPotentialAc"/> from <see cref="ElectricPotentialAcUnit.VoltAc"/>.
        /// </summary>
        public static ElectricPotentialAc FromVoltsAc(double voltsac) => new ElectricPotentialAc(voltsac, ElectricPotentialAcUnit.VoltAc);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricPotentialAcUnit" /> to <see cref="ElectricPotentialAc" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricPotentialAc unit value.</returns>
        public static ElectricPotentialAc From(double value, ElectricPotentialAcUnit fromUnit)
        {
            return new ElectricPotentialAc(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ElectricPotentialAcUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this ElectricPotentialAc to another ElectricPotentialAc with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A ElectricPotentialAc with the specified unit.</returns>
                public ElectricPotentialAc ToUnit(ElectricPotentialAcUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ElectricPotentialAc(convertedValue, unit);
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
                        ElectricPotentialAcUnit.KilovoltAc => (_value) * 1e3d,
                        ElectricPotentialAcUnit.MegavoltAc => (_value) * 1e6d,
                        ElectricPotentialAcUnit.MicrovoltAc => (_value) * 1e-6d,
                        ElectricPotentialAcUnit.MillivoltAc => (_value) * 1e-3d,
                        ElectricPotentialAcUnit.VoltAc => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ElectricPotentialAcUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ElectricPotentialAcUnit.KilovoltAc => (baseUnitValue) / 1e3d,
                        ElectricPotentialAcUnit.MegavoltAc => (baseUnitValue) / 1e6d,
                        ElectricPotentialAcUnit.MicrovoltAc => (baseUnitValue) / 1e-6d,
                        ElectricPotentialAcUnit.MillivoltAc => (baseUnitValue) / 1e-3d,
                        ElectricPotentialAcUnit.VoltAc => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


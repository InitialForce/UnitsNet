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
    ///     Molar concentration, also called molarity, amount concentration or substance concentration, is a measure of the concentration of a solute in a solution, or of any chemical species, in terms of amount of substance in a given volume.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Molar_concentration
    /// </remarks>
    public struct  Molarity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MolarityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public Molarity(double value, MolarityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Molarity, which is Second. All conversions go via this value.
        /// </summary>
        public static MolarityUnit BaseUnit { get; } = MolarityUnit.MolePerCubicMeter;

        /// <summary>
        /// Represents the largest possible value of Molarity.
        /// </summary>
        public static Molarity MaxValue { get; } = new Molarity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Molarity.
        /// </summary>
        public static Molarity MinValue { get; } = new Molarity(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Molarity Zero { get; } = new Molarity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.CentimolePerLiter"/>
        /// </summary>
        public double CentimolesPerLiter => As(MolarityUnit.CentimolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.DecimolePerLiter"/>
        /// </summary>
        public double DecimolesPerLiter => As(MolarityUnit.DecimolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.FemtomolePerLiter"/>
        /// </summary>
        public double FemtomolesPerLiter => As(MolarityUnit.FemtomolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.KilomolePerCubicMeter"/>
        /// </summary>
        public double KilomolesPerCubicMeter => As(MolarityUnit.KilomolePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.MicromolePerLiter"/>
        /// </summary>
        public double MicromolesPerLiter => As(MolarityUnit.MicromolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.MillimolePerLiter"/>
        /// </summary>
        public double MillimolesPerLiter => As(MolarityUnit.MillimolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.MolePerCubicMeter"/>
        /// </summary>
        public double MolesPerCubicMeter => As(MolarityUnit.MolePerCubicMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.MolePerLiter"/>
        /// </summary>
        public double MolesPerLiter => As(MolarityUnit.MolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.NanomolePerLiter"/>
        /// </summary>
        public double NanomolesPerLiter => As(MolarityUnit.NanomolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.PicomolePerLiter"/>
        /// </summary>
        public double PicomolesPerLiter => As(MolarityUnit.PicomolePerLiter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarityUnit.PoundMolePerCubicFoot"/>
        /// </summary>
        public double PoundMolesPerCubicFoot => As(MolarityUnit.PoundMolePerCubicFoot);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.CentimolePerLiter"/>.
        /// </summary>
        public static Molarity FromCentimolesPerLiter(double centimolesperliter) => new Molarity(centimolesperliter, MolarityUnit.CentimolePerLiter);

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.DecimolePerLiter"/>.
        /// </summary>
        public static Molarity FromDecimolesPerLiter(double decimolesperliter) => new Molarity(decimolesperliter, MolarityUnit.DecimolePerLiter);

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.FemtomolePerLiter"/>.
        /// </summary>
        public static Molarity FromFemtomolesPerLiter(double femtomolesperliter) => new Molarity(femtomolesperliter, MolarityUnit.FemtomolePerLiter);

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.KilomolePerCubicMeter"/>.
        /// </summary>
        public static Molarity FromKilomolesPerCubicMeter(double kilomolespercubicmeter) => new Molarity(kilomolespercubicmeter, MolarityUnit.KilomolePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.MicromolePerLiter"/>.
        /// </summary>
        public static Molarity FromMicromolesPerLiter(double micromolesperliter) => new Molarity(micromolesperliter, MolarityUnit.MicromolePerLiter);

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.MillimolePerLiter"/>.
        /// </summary>
        public static Molarity FromMillimolesPerLiter(double millimolesperliter) => new Molarity(millimolesperliter, MolarityUnit.MillimolePerLiter);

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.MolePerCubicMeter"/>.
        /// </summary>
        public static Molarity FromMolesPerCubicMeter(double molespercubicmeter) => new Molarity(molespercubicmeter, MolarityUnit.MolePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.MolePerLiter"/>.
        /// </summary>
        public static Molarity FromMolesPerLiter(double molesperliter) => new Molarity(molesperliter, MolarityUnit.MolePerLiter);

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.NanomolePerLiter"/>.
        /// </summary>
        public static Molarity FromNanomolesPerLiter(double nanomolesperliter) => new Molarity(nanomolesperliter, MolarityUnit.NanomolePerLiter);

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.PicomolePerLiter"/>.
        /// </summary>
        public static Molarity FromPicomolesPerLiter(double picomolesperliter) => new Molarity(picomolesperliter, MolarityUnit.PicomolePerLiter);

        /// <summary>
        ///     Creates a <see cref="Molarity"/> from <see cref="MolarityUnit.PoundMolePerCubicFoot"/>.
        /// </summary>
        public static Molarity FromPoundMolesPerCubicFoot(double poundmolespercubicfoot) => new Molarity(poundmolespercubicfoot, MolarityUnit.PoundMolePerCubicFoot);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarityUnit" /> to <see cref="Molarity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Molarity unit value.</returns>
        public static Molarity From(double value, MolarityUnit fromUnit)
        {
            return new Molarity(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(MolarityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Molarity to another Molarity with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Molarity with the specified unit.</returns>
                public Molarity ToUnit(MolarityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Molarity(convertedValue, unit);
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
                        MolarityUnit.CentimolePerLiter => (_value / 1e-3) * 1e-2d,
                        MolarityUnit.DecimolePerLiter => (_value / 1e-3) * 1e-1d,
                        MolarityUnit.FemtomolePerLiter => (_value / 1e-3) * 1e-15d,
                        MolarityUnit.KilomolePerCubicMeter => (_value) * 1e3d,
                        MolarityUnit.MicromolePerLiter => (_value / 1e-3) * 1e-6d,
                        MolarityUnit.MillimolePerLiter => (_value / 1e-3) * 1e-3d,
                        MolarityUnit.MolePerCubicMeter => _value,
                        MolarityUnit.MolePerLiter => _value / 1e-3,
                        MolarityUnit.NanomolePerLiter => (_value / 1e-3) * 1e-9d,
                        MolarityUnit.PicomolePerLiter => (_value / 1e-3) * 1e-12d,
                        MolarityUnit.PoundMolePerCubicFoot => _value / 6.2427960576144611956325455827221e-5,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(MolarityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        MolarityUnit.CentimolePerLiter => (baseUnitValue * 1e-3) / 1e-2d,
                        MolarityUnit.DecimolePerLiter => (baseUnitValue * 1e-3) / 1e-1d,
                        MolarityUnit.FemtomolePerLiter => (baseUnitValue * 1e-3) / 1e-15d,
                        MolarityUnit.KilomolePerCubicMeter => (baseUnitValue) / 1e3d,
                        MolarityUnit.MicromolePerLiter => (baseUnitValue * 1e-3) / 1e-6d,
                        MolarityUnit.MillimolePerLiter => (baseUnitValue * 1e-3) / 1e-3d,
                        MolarityUnit.MolePerCubicMeter => baseUnitValue,
                        MolarityUnit.MolePerLiter => baseUnitValue * 1e-3,
                        MolarityUnit.NanomolePerLiter => (baseUnitValue * 1e-3) / 1e-9d,
                        MolarityUnit.PicomolePerLiter => (baseUnitValue * 1e-3) / 1e-12d,
                        MolarityUnit.PoundMolePerCubicFoot => baseUnitValue * 6.2427960576144611956325455827221e-5,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


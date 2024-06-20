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
    ///     The electrical conductance per area of an electrical conductor is a measure of the easeness to pass an electric current through that conductor per unit area.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Electrical_resistance_and_conductance
    /// </remarks>
    public struct  ElectricConductancePerArea
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricConductancePerAreaUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricConductancePerAreaUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricConductancePerArea(double value, ElectricConductancePerAreaUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of ElectricConductancePerArea, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricConductancePerAreaUnit BaseUnit { get; } = ElectricConductancePerAreaUnit.SiemensPerSquareMeter;

        /// <summary>
        /// Represents the largest possible value of ElectricConductancePerArea.
        /// </summary>
        public static ElectricConductancePerArea MaxValue { get; } = new ElectricConductancePerArea(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ElectricConductancePerArea.
        /// </summary>
        public static ElectricConductancePerArea MinValue { get; } = new ElectricConductancePerArea(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricConductancePerArea Zero { get; } = new ElectricConductancePerArea(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.FemtosiemensPerSquareMeter"/>
        /// </summary>
        public double FemtosiemensPerSquareMeter => As(ElectricConductancePerAreaUnit.FemtosiemensPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.KilosiemensPerSquareMeter"/>
        /// </summary>
        public double KilosiemensPerSquareMeter => As(ElectricConductancePerAreaUnit.KilosiemensPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.MegasiemensPerSquareMeter"/>
        /// </summary>
        public double MegasiemensPerSquareMeter => As(ElectricConductancePerAreaUnit.MegasiemensPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.MicrosiemensPerSquareCentimeter"/>
        /// </summary>
        public double MicrosiemensPerSquareCentimeters => As(ElectricConductancePerAreaUnit.MicrosiemensPerSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.MicrosiemensPerSquareMeter"/>
        /// </summary>
        public double MicrosiemensPerSquareMeter => As(ElectricConductancePerAreaUnit.MicrosiemensPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.MillisiemensPerSquareCentimeter"/>
        /// </summary>
        public double MillisiemensPerSquareCentimeters => As(ElectricConductancePerAreaUnit.MillisiemensPerSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.MillisiemensPerSquareMeter"/>
        /// </summary>
        public double MillisiemensPerSquareMeter => As(ElectricConductancePerAreaUnit.MillisiemensPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.NanosiemensPerSquareMeter"/>
        /// </summary>
        public double NanosiemensPerSquareMeter => As(ElectricConductancePerAreaUnit.NanosiemensPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.PicosiemensPerSquareMeter"/>
        /// </summary>
        public double PicosiemensPerSquareMeter => As(ElectricConductancePerAreaUnit.PicosiemensPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareCentimeter"/>
        /// </summary>
        public double SiemensPerSquareCentimeters => As(ElectricConductancePerAreaUnit.SiemensPerSquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareDecimeter"/>
        /// </summary>
        public double SiemensPerSquareDecimeters => As(ElectricConductancePerAreaUnit.SiemensPerSquareDecimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareFoot"/>
        /// </summary>
        public double SiemensPerSquareFeet => As(ElectricConductancePerAreaUnit.SiemensPerSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareInch"/>
        /// </summary>
        public double SiemensPerSquareInches => As(ElectricConductancePerAreaUnit.SiemensPerSquareInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareMeter"/>
        /// </summary>
        public double SiemensPerSquareMeter => As(ElectricConductancePerAreaUnit.SiemensPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareMile"/>
        /// </summary>
        public double SiemensPerSquareMiles => As(ElectricConductancePerAreaUnit.SiemensPerSquareMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareMillimeter"/>
        /// </summary>
        public double SiemensPerSquareMillimeters => As(ElectricConductancePerAreaUnit.SiemensPerSquareMillimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareYard"/>
        /// </summary>
        public double SiemensPerSquareYards => As(ElectricConductancePerAreaUnit.SiemensPerSquareYard);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricConductancePerAreaUnit.SiemensPerUsSurveySquareFoot"/>
        /// </summary>
        public double SiemensPerUsSurveySquareFeet => As(ElectricConductancePerAreaUnit.SiemensPerUsSurveySquareFoot);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.FemtosiemensPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromFemtosiemensPerSquareMeter(double femtosiemenspersquaremeter) => new ElectricConductancePerArea(femtosiemenspersquaremeter, ElectricConductancePerAreaUnit.FemtosiemensPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.KilosiemensPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromKilosiemensPerSquareMeter(double kilosiemenspersquaremeter) => new ElectricConductancePerArea(kilosiemenspersquaremeter, ElectricConductancePerAreaUnit.KilosiemensPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.MegasiemensPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromMegasiemensPerSquareMeter(double megasiemenspersquaremeter) => new ElectricConductancePerArea(megasiemenspersquaremeter, ElectricConductancePerAreaUnit.MegasiemensPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.MicrosiemensPerSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromMicrosiemensPerSquareCentimeters(double microsiemenspersquarecentimeters) => new ElectricConductancePerArea(microsiemenspersquarecentimeters, ElectricConductancePerAreaUnit.MicrosiemensPerSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.MicrosiemensPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromMicrosiemensPerSquareMeter(double microsiemenspersquaremeter) => new ElectricConductancePerArea(microsiemenspersquaremeter, ElectricConductancePerAreaUnit.MicrosiemensPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.MillisiemensPerSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromMillisiemensPerSquareCentimeters(double millisiemenspersquarecentimeters) => new ElectricConductancePerArea(millisiemenspersquarecentimeters, ElectricConductancePerAreaUnit.MillisiemensPerSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.MillisiemensPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromMillisiemensPerSquareMeter(double millisiemenspersquaremeter) => new ElectricConductancePerArea(millisiemenspersquaremeter, ElectricConductancePerAreaUnit.MillisiemensPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.NanosiemensPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromNanosiemensPerSquareMeter(double nanosiemenspersquaremeter) => new ElectricConductancePerArea(nanosiemenspersquaremeter, ElectricConductancePerAreaUnit.NanosiemensPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.PicosiemensPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromPicosiemensPerSquareMeter(double picosiemenspersquaremeter) => new ElectricConductancePerArea(picosiemenspersquaremeter, ElectricConductancePerAreaUnit.PicosiemensPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromSiemensPerSquareCentimeters(double siemenspersquarecentimeters) => new ElectricConductancePerArea(siemenspersquarecentimeters, ElectricConductancePerAreaUnit.SiemensPerSquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareDecimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromSiemensPerSquareDecimeters(double siemenspersquaredecimeters) => new ElectricConductancePerArea(siemenspersquaredecimeters, ElectricConductancePerAreaUnit.SiemensPerSquareDecimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromSiemensPerSquareFeet(double siemenspersquarefeet) => new ElectricConductancePerArea(siemenspersquarefeet, ElectricConductancePerAreaUnit.SiemensPerSquareFoot);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromSiemensPerSquareInches(double siemenspersquareinches) => new ElectricConductancePerArea(siemenspersquareinches, ElectricConductancePerAreaUnit.SiemensPerSquareInch);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromSiemensPerSquareMeter(double siemenspersquaremeter) => new ElectricConductancePerArea(siemenspersquaremeter, ElectricConductancePerAreaUnit.SiemensPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromSiemensPerSquareMiles(double siemenspersquaremiles) => new ElectricConductancePerArea(siemenspersquaremiles, ElectricConductancePerAreaUnit.SiemensPerSquareMile);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromSiemensPerSquareMillimeters(double siemenspersquaremillimeters) => new ElectricConductancePerArea(siemenspersquaremillimeters, ElectricConductancePerAreaUnit.SiemensPerSquareMillimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.SiemensPerSquareYard"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromSiemensPerSquareYards(double siemenspersquareyards) => new ElectricConductancePerArea(siemenspersquareyards, ElectricConductancePerAreaUnit.SiemensPerSquareYard);

        /// <summary>
        ///     Creates a <see cref="ElectricConductancePerArea"/> from <see cref="ElectricConductancePerAreaUnit.SiemensPerUsSurveySquareFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricConductancePerArea FromSiemensPerUsSurveySquareFeet(double siemensperussurveysquarefeet) => new ElectricConductancePerArea(siemensperussurveysquarefeet, ElectricConductancePerAreaUnit.SiemensPerUsSurveySquareFoot);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricConductancePerAreaUnit" /> to <see cref="ElectricConductancePerArea" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricConductancePerArea unit value.</returns>
        public static ElectricConductancePerArea From(double value, ElectricConductancePerAreaUnit fromUnit)
        {
            return new ElectricConductancePerArea(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ElectricConductancePerAreaUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this ElectricConductancePerArea to another ElectricConductancePerArea with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A ElectricConductancePerArea with the specified unit.</returns>
                public ElectricConductancePerArea ToUnit(ElectricConductancePerAreaUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ElectricConductancePerArea(convertedValue, unit);
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
                        ElectricConductancePerAreaUnit.FemtosiemensPerSquareMeter => (_value) * 1e-15d,
                        ElectricConductancePerAreaUnit.KilosiemensPerSquareMeter => (_value) * 1e3d,
                        ElectricConductancePerAreaUnit.MegasiemensPerSquareMeter => (_value) * 1e6d,
                        ElectricConductancePerAreaUnit.MicrosiemensPerSquareCentimeter => (_value / 1e-4) * 1e-6d,
                        ElectricConductancePerAreaUnit.MicrosiemensPerSquareMeter => (_value) * 1e-6d,
                        ElectricConductancePerAreaUnit.MillisiemensPerSquareCentimeter => (_value / 1e-4) * 1e-3d,
                        ElectricConductancePerAreaUnit.MillisiemensPerSquareMeter => (_value) * 1e-3d,
                        ElectricConductancePerAreaUnit.NanosiemensPerSquareMeter => (_value) * 1e-9d,
                        ElectricConductancePerAreaUnit.PicosiemensPerSquareMeter => (_value) * 1e-12d,
                        ElectricConductancePerAreaUnit.SiemensPerSquareCentimeter => _value / 1e-4,
                        ElectricConductancePerAreaUnit.SiemensPerSquareDecimeter => _value / 1e-2,
                        ElectricConductancePerAreaUnit.SiemensPerSquareFoot => _value / 0.092903,
                        ElectricConductancePerAreaUnit.SiemensPerSquareInch => _value / 0.00064516,
                        ElectricConductancePerAreaUnit.SiemensPerSquareMeter => _value,
                        ElectricConductancePerAreaUnit.SiemensPerSquareMile => _value / 2.59e6,
                        ElectricConductancePerAreaUnit.SiemensPerSquareMillimeter => _value / 1e-6,
                        ElectricConductancePerAreaUnit.SiemensPerSquareYard => _value / 0.836127,
                        ElectricConductancePerAreaUnit.SiemensPerUsSurveySquareFoot => _value / 0.09290341161,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ElectricConductancePerAreaUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ElectricConductancePerAreaUnit.FemtosiemensPerSquareMeter => (baseUnitValue) / 1e-15d,
                        ElectricConductancePerAreaUnit.KilosiemensPerSquareMeter => (baseUnitValue) / 1e3d,
                        ElectricConductancePerAreaUnit.MegasiemensPerSquareMeter => (baseUnitValue) / 1e6d,
                        ElectricConductancePerAreaUnit.MicrosiemensPerSquareCentimeter => (baseUnitValue * 1e-4) / 1e-6d,
                        ElectricConductancePerAreaUnit.MicrosiemensPerSquareMeter => (baseUnitValue) / 1e-6d,
                        ElectricConductancePerAreaUnit.MillisiemensPerSquareCentimeter => (baseUnitValue * 1e-4) / 1e-3d,
                        ElectricConductancePerAreaUnit.MillisiemensPerSquareMeter => (baseUnitValue) / 1e-3d,
                        ElectricConductancePerAreaUnit.NanosiemensPerSquareMeter => (baseUnitValue) / 1e-9d,
                        ElectricConductancePerAreaUnit.PicosiemensPerSquareMeter => (baseUnitValue) / 1e-12d,
                        ElectricConductancePerAreaUnit.SiemensPerSquareCentimeter => baseUnitValue * 1e-4,
                        ElectricConductancePerAreaUnit.SiemensPerSquareDecimeter => baseUnitValue * 1e-2,
                        ElectricConductancePerAreaUnit.SiemensPerSquareFoot => baseUnitValue * 0.092903,
                        ElectricConductancePerAreaUnit.SiemensPerSquareInch => baseUnitValue * 0.00064516,
                        ElectricConductancePerAreaUnit.SiemensPerSquareMeter => baseUnitValue,
                        ElectricConductancePerAreaUnit.SiemensPerSquareMile => baseUnitValue * 2.59e6,
                        ElectricConductancePerAreaUnit.SiemensPerSquareMillimeter => baseUnitValue * 1e-6,
                        ElectricConductancePerAreaUnit.SiemensPerSquareYard => baseUnitValue * 0.836127,
                        ElectricConductancePerAreaUnit.SiemensPerUsSurveySquareFoot => baseUnitValue * 0.09290341161,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


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
    ///     The dynamic (shear) viscosity of a fluid expresses its resistance to shearing flows, where adjacent layers move parallel to each other with different speeds
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Viscosity#Dynamic_.28shear.29_viscosity
    /// </remarks>
    public struct  DynamicViscosity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly DynamicViscosityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public DynamicViscosityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public DynamicViscosity(double value, DynamicViscosityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of DynamicViscosity, which is Second. All conversions go via this value.
        /// </summary>
        public static DynamicViscosityUnit BaseUnit { get; } = DynamicViscosityUnit.NewtonSecondPerMeterSquared;

        /// <summary>
        /// Represents the largest possible value of DynamicViscosity.
        /// </summary>
        public static DynamicViscosity MaxValue { get; } = new DynamicViscosity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of DynamicViscosity.
        /// </summary>
        public static DynamicViscosity MinValue { get; } = new DynamicViscosity(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static DynamicViscosity Zero { get; } = new DynamicViscosity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.Centipoise"/>
        /// </summary>
        public double Centipoise => As(DynamicViscosityUnit.Centipoise);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.MicropascalSecond"/>
        /// </summary>
        public double MicropascalSeconds => As(DynamicViscosityUnit.MicropascalSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.MillipascalSecond"/>
        /// </summary>
        public double MillipascalSeconds => As(DynamicViscosityUnit.MillipascalSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.NewtonSecondPerMeterSquared"/>
        /// </summary>
        public double NewtonSecondsPerMeterSquared => As(DynamicViscosityUnit.NewtonSecondPerMeterSquared);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.PascalSecond"/>
        /// </summary>
        public double PascalSeconds => As(DynamicViscosityUnit.PascalSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.Poise"/>
        /// </summary>
        public double Poise => As(DynamicViscosityUnit.Poise);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.PoundForceSecondPerSquareFoot"/>
        /// </summary>
        public double PoundsForceSecondPerSquareFoot => As(DynamicViscosityUnit.PoundForceSecondPerSquareFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.PoundForceSecondPerSquareInch"/>
        /// </summary>
        public double PoundsForceSecondPerSquareInch => As(DynamicViscosityUnit.PoundForceSecondPerSquareInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.PoundPerFootSecond"/>
        /// </summary>
        public double PoundsPerFootSecond => As(DynamicViscosityUnit.PoundPerFootSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="DynamicViscosityUnit.Reyn"/>
        /// </summary>
        public double Reyns => As(DynamicViscosityUnit.Reyn);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.Centipoise"/>.
        /// </summary>
        public static DynamicViscosity FromCentipoise(double centipoise) => new DynamicViscosity(centipoise, DynamicViscosityUnit.Centipoise);

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.MicropascalSecond"/>.
        /// </summary>
        public static DynamicViscosity FromMicropascalSeconds(double micropascalseconds) => new DynamicViscosity(micropascalseconds, DynamicViscosityUnit.MicropascalSecond);

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.MillipascalSecond"/>.
        /// </summary>
        public static DynamicViscosity FromMillipascalSeconds(double millipascalseconds) => new DynamicViscosity(millipascalseconds, DynamicViscosityUnit.MillipascalSecond);

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.NewtonSecondPerMeterSquared"/>.
        /// </summary>
        public static DynamicViscosity FromNewtonSecondsPerMeterSquared(double newtonsecondspermetersquared) => new DynamicViscosity(newtonsecondspermetersquared, DynamicViscosityUnit.NewtonSecondPerMeterSquared);

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.PascalSecond"/>.
        /// </summary>
        public static DynamicViscosity FromPascalSeconds(double pascalseconds) => new DynamicViscosity(pascalseconds, DynamicViscosityUnit.PascalSecond);

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.Poise"/>.
        /// </summary>
        public static DynamicViscosity FromPoise(double poise) => new DynamicViscosity(poise, DynamicViscosityUnit.Poise);

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.PoundForceSecondPerSquareFoot"/>.
        /// </summary>
        public static DynamicViscosity FromPoundsForceSecondPerSquareFoot(double poundsforcesecondpersquarefoot) => new DynamicViscosity(poundsforcesecondpersquarefoot, DynamicViscosityUnit.PoundForceSecondPerSquareFoot);

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.PoundForceSecondPerSquareInch"/>.
        /// </summary>
        public static DynamicViscosity FromPoundsForceSecondPerSquareInch(double poundsforcesecondpersquareinch) => new DynamicViscosity(poundsforcesecondpersquareinch, DynamicViscosityUnit.PoundForceSecondPerSquareInch);

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.PoundPerFootSecond"/>.
        /// </summary>
        public static DynamicViscosity FromPoundsPerFootSecond(double poundsperfootsecond) => new DynamicViscosity(poundsperfootsecond, DynamicViscosityUnit.PoundPerFootSecond);

        /// <summary>
        ///     Creates a <see cref="DynamicViscosity"/> from <see cref="DynamicViscosityUnit.Reyn"/>.
        /// </summary>
        public static DynamicViscosity FromReyns(double reyns) => new DynamicViscosity(reyns, DynamicViscosityUnit.Reyn);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="DynamicViscosityUnit" /> to <see cref="DynamicViscosity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>DynamicViscosity unit value.</returns>
        public static DynamicViscosity From(double value, DynamicViscosityUnit fromUnit)
        {
            return new DynamicViscosity(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(DynamicViscosityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this DynamicViscosity to another DynamicViscosity with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A DynamicViscosity with the specified unit.</returns>
                public DynamicViscosity ToUnit(DynamicViscosityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new DynamicViscosity(convertedValue, unit);
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
                        DynamicViscosityUnit.Centipoise => (_value / 10) * 1e-2d,
                        DynamicViscosityUnit.MicropascalSecond => (_value) * 1e-6d,
                        DynamicViscosityUnit.MillipascalSecond => (_value) * 1e-3d,
                        DynamicViscosityUnit.NewtonSecondPerMeterSquared => _value,
                        DynamicViscosityUnit.PascalSecond => _value,
                        DynamicViscosityUnit.Poise => _value / 10,
                        DynamicViscosityUnit.PoundForceSecondPerSquareFoot => _value * 4.7880258980335843e1,
                        DynamicViscosityUnit.PoundForceSecondPerSquareInch => _value * 6.8947572931683613e3,
                        DynamicViscosityUnit.PoundPerFootSecond => _value * 1.4881639,
                        DynamicViscosityUnit.Reyn => _value * 6.8947572931683613e3,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(DynamicViscosityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        DynamicViscosityUnit.Centipoise => (baseUnitValue * 10) / 1e-2d,
                        DynamicViscosityUnit.MicropascalSecond => (baseUnitValue) / 1e-6d,
                        DynamicViscosityUnit.MillipascalSecond => (baseUnitValue) / 1e-3d,
                        DynamicViscosityUnit.NewtonSecondPerMeterSquared => baseUnitValue,
                        DynamicViscosityUnit.PascalSecond => baseUnitValue,
                        DynamicViscosityUnit.Poise => baseUnitValue * 10,
                        DynamicViscosityUnit.PoundForceSecondPerSquareFoot => baseUnitValue / 4.7880258980335843e1,
                        DynamicViscosityUnit.PoundForceSecondPerSquareInch => baseUnitValue / 6.8947572931683613e3,
                        DynamicViscosityUnit.PoundPerFootSecond => baseUnitValue / 1.4881639,
                        DynamicViscosityUnit.Reyn => baseUnitValue / 6.8947572931683613e3,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}


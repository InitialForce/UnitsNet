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
    ///     https://en.wikipedia.org/wiki/Stiffness#Rotational_stiffness
    /// </summary>
    public struct  RotationalStiffnessPerLength
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly RotationalStiffnessPerLengthUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public RotationalStiffnessPerLengthUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public RotationalStiffnessPerLength(double value, RotationalStiffnessPerLengthUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static RotationalStiffnessPerLengthUnit BaseUnit { get; } = RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static RotationalStiffnessPerLength MaxValue { get; } = new RotationalStiffnessPerLength(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static RotationalStiffnessPerLength MinValue { get; } = new RotationalStiffnessPerLength(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static RotationalStiffnessPerLength Zero { get; } = new RotationalStiffnessPerLength(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get RotationalStiffnessPerLength in KilonewtonMetersPerRadianPerMeter.
        /// </summary>
        public double KilonewtonMetersPerRadianPerMeter => As(RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter);

        /// <summary>
        ///     Get RotationalStiffnessPerLength in KilopoundForceFeetPerDegreesPerFeet.
        /// </summary>
        public double KilopoundForceFeetPerDegreesPerFeet => As(RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot);

        /// <summary>
        ///     Get RotationalStiffnessPerLength in MeganewtonMetersPerRadianPerMeter.
        /// </summary>
        public double MeganewtonMetersPerRadianPerMeter => As(RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter);

        /// <summary>
        ///     Get RotationalStiffnessPerLength in NewtonMetersPerRadianPerMeter.
        /// </summary>
        public double NewtonMetersPerRadianPerMeter => As(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter);

        /// <summary>
        ///     Get RotationalStiffnessPerLength in PoundForceFeetPerDegreesPerFeet.
        /// </summary>
        public double PoundForceFeetPerDegreesPerFeet => As(RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get RotationalStiffnessPerLength from KilonewtonMetersPerRadianPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalStiffnessPerLength FromKilonewtonMetersPerRadianPerMeter(double kilonewtonmetersperradianpermeter) => new RotationalStiffnessPerLength(kilonewtonmetersperradianpermeter, RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter);

        /// <summary>
        ///     Get RotationalStiffnessPerLength from KilopoundForceFeetPerDegreesPerFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalStiffnessPerLength FromKilopoundForceFeetPerDegreesPerFeet(double kilopoundforcefeetperdegreesperfeet) => new RotationalStiffnessPerLength(kilopoundforcefeetperdegreesperfeet, RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot);

        /// <summary>
        ///     Get RotationalStiffnessPerLength from MeganewtonMetersPerRadianPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalStiffnessPerLength FromMeganewtonMetersPerRadianPerMeter(double meganewtonmetersperradianpermeter) => new RotationalStiffnessPerLength(meganewtonmetersperradianpermeter, RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter);

        /// <summary>
        ///     Get RotationalStiffnessPerLength from NewtonMetersPerRadianPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalStiffnessPerLength FromNewtonMetersPerRadianPerMeter(double newtonmetersperradianpermeter) => new RotationalStiffnessPerLength(newtonmetersperradianpermeter, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter);

        /// <summary>
        ///     Get RotationalStiffnessPerLength from PoundForceFeetPerDegreesPerFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalStiffnessPerLength FromPoundForceFeetPerDegreesPerFeet(double poundforcefeetperdegreesperfeet) => new RotationalStiffnessPerLength(poundforcefeetperdegreesperfeet, RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RotationalStiffnessPerLengthUnit" /> to <see cref="RotationalStiffnessPerLength" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>RotationalStiffnessPerLength unit value.</returns>
        public static RotationalStiffnessPerLength From(double value, RotationalStiffnessPerLengthUnit fromUnit)
        {
            return new RotationalStiffnessPerLength(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(RotationalStiffnessPerLengthUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public RotationalStiffnessPerLength ToUnit(RotationalStiffnessPerLengthUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new RotationalStiffnessPerLength(convertedValue, unit);
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
                RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter => (_value) * 1e3d,
                RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot => _value*254864.324570,
                RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter => (_value) * 1e6d,
                RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter => _value,
                RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot => _value*254.864324570,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(RotationalStiffnessPerLengthUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter => (baseUnitValue) / 1e3d,
                RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot => baseUnitValue/254864.324570,
                RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter => (baseUnitValue) / 1e6d,
                RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter => baseUnitValue,
                RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot => baseUnitValue/254.864324570,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}


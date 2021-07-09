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
    ///     Acceleration, in physics, is the rate at which the velocity of an object changes over time. An object's acceleration is the net result of any and all forces acting on the object, as described by Newton's Second Law. The SI unit for acceleration is the Meter per second squared (m/s²). Accelerations are vector quantities (they have magnitude and direction) and add according to the parallelogram law. As a vector, the calculated net force is equal to the product of the object's mass (a scalar quantity) and the acceleration.
    /// </summary>
    public struct  Acceleration
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AccelerationUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public AccelerationUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Acceleration(double value, AccelerationUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static AccelerationUnit BaseUnit { get; } = AccelerationUnit.MeterPerSecondSquared;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Acceleration MaxValue { get; } = new Acceleration(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Acceleration MinValue { get; } = new Acceleration(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Acceleration Zero { get; } = new Acceleration(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get Acceleration in CentimetersPerSecondSquared.
        /// </summary>
        public double CentimetersPerSecondSquared => As(AccelerationUnit.CentimeterPerSecondSquared);

        /// <summary>
        ///     Get Acceleration in DecimetersPerSecondSquared.
        /// </summary>
        public double DecimetersPerSecondSquared => As(AccelerationUnit.DecimeterPerSecondSquared);

        /// <summary>
        ///     Get Acceleration in FeetPerSecondSquared.
        /// </summary>
        public double FeetPerSecondSquared => As(AccelerationUnit.FootPerSecondSquared);

        /// <summary>
        ///     Get Acceleration in InchesPerSecondSquared.
        /// </summary>
        public double InchesPerSecondSquared => As(AccelerationUnit.InchPerSecondSquared);

        /// <summary>
        ///     Get Acceleration in KilometersPerSecondSquared.
        /// </summary>
        public double KilometersPerSecondSquared => As(AccelerationUnit.KilometerPerSecondSquared);

        /// <summary>
        ///     Get Acceleration in KnotsPerHour.
        /// </summary>
        public double KnotsPerHour => As(AccelerationUnit.KnotPerHour);

        /// <summary>
        ///     Get Acceleration in KnotsPerMinute.
        /// </summary>
        public double KnotsPerMinute => As(AccelerationUnit.KnotPerMinute);

        /// <summary>
        ///     Get Acceleration in KnotsPerSecond.
        /// </summary>
        public double KnotsPerSecond => As(AccelerationUnit.KnotPerSecond);

        /// <summary>
        ///     Get Acceleration in MetersPerSecondSquared.
        /// </summary>
        public double MetersPerSecondSquared => As(AccelerationUnit.MeterPerSecondSquared);

        /// <summary>
        ///     Get Acceleration in MicrometersPerSecondSquared.
        /// </summary>
        public double MicrometersPerSecondSquared => As(AccelerationUnit.MicrometerPerSecondSquared);

        /// <summary>
        ///     Get Acceleration in MillimetersPerSecondSquared.
        /// </summary>
        public double MillimetersPerSecondSquared => As(AccelerationUnit.MillimeterPerSecondSquared);

        /// <summary>
        ///     Get Acceleration in MillistandardGravity.
        /// </summary>
        public double MillistandardGravity => As(AccelerationUnit.MillistandardGravity);

        /// <summary>
        ///     Get Acceleration in NanometersPerSecondSquared.
        /// </summary>
        public double NanometersPerSecondSquared => As(AccelerationUnit.NanometerPerSecondSquared);

        /// <summary>
        ///     Get Acceleration in StandardGravity.
        /// </summary>
        public double StandardGravity => As(AccelerationUnit.StandardGravity);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Acceleration from CentimetersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromCentimetersPerSecondSquared(double centimeterspersecondsquared) => new Acceleration(centimeterspersecondsquared, AccelerationUnit.CentimeterPerSecondSquared);

        /// <summary>
        ///     Get Acceleration from DecimetersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromDecimetersPerSecondSquared(double decimeterspersecondsquared) => new Acceleration(decimeterspersecondsquared, AccelerationUnit.DecimeterPerSecondSquared);

        /// <summary>
        ///     Get Acceleration from FeetPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromFeetPerSecondSquared(double feetpersecondsquared) => new Acceleration(feetpersecondsquared, AccelerationUnit.FootPerSecondSquared);

        /// <summary>
        ///     Get Acceleration from InchesPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromInchesPerSecondSquared(double inchespersecondsquared) => new Acceleration(inchespersecondsquared, AccelerationUnit.InchPerSecondSquared);

        /// <summary>
        ///     Get Acceleration from KilometersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromKilometersPerSecondSquared(double kilometerspersecondsquared) => new Acceleration(kilometerspersecondsquared, AccelerationUnit.KilometerPerSecondSquared);

        /// <summary>
        ///     Get Acceleration from KnotsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromKnotsPerHour(double knotsperhour) => new Acceleration(knotsperhour, AccelerationUnit.KnotPerHour);

        /// <summary>
        ///     Get Acceleration from KnotsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromKnotsPerMinute(double knotsperminute) => new Acceleration(knotsperminute, AccelerationUnit.KnotPerMinute);

        /// <summary>
        ///     Get Acceleration from KnotsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromKnotsPerSecond(double knotspersecond) => new Acceleration(knotspersecond, AccelerationUnit.KnotPerSecond);

        /// <summary>
        ///     Get Acceleration from MetersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromMetersPerSecondSquared(double meterspersecondsquared) => new Acceleration(meterspersecondsquared, AccelerationUnit.MeterPerSecondSquared);

        /// <summary>
        ///     Get Acceleration from MicrometersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromMicrometersPerSecondSquared(double micrometerspersecondsquared) => new Acceleration(micrometerspersecondsquared, AccelerationUnit.MicrometerPerSecondSquared);

        /// <summary>
        ///     Get Acceleration from MillimetersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromMillimetersPerSecondSquared(double millimeterspersecondsquared) => new Acceleration(millimeterspersecondsquared, AccelerationUnit.MillimeterPerSecondSquared);

        /// <summary>
        ///     Get Acceleration from MillistandardGravity.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromMillistandardGravity(double millistandardgravity) => new Acceleration(millistandardgravity, AccelerationUnit.MillistandardGravity);

        /// <summary>
        ///     Get Acceleration from NanometersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromNanometersPerSecondSquared(double nanometerspersecondsquared) => new Acceleration(nanometerspersecondsquared, AccelerationUnit.NanometerPerSecondSquared);

        /// <summary>
        ///     Get Acceleration from StandardGravity.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Acceleration FromStandardGravity(double standardgravity) => new Acceleration(standardgravity, AccelerationUnit.StandardGravity);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AccelerationUnit" /> to <see cref="Acceleration" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Acceleration unit value.</returns>
        public static Acceleration From(double value, AccelerationUnit fromUnit)
        {
            return new Acceleration(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AccelerationUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Acceleration ToUnit(AccelerationUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new Acceleration(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case AccelerationUnit.CentimeterPerSecondSquared: return (_value) * 1e-2d;
                case AccelerationUnit.DecimeterPerSecondSquared: return (_value) * 1e-1d;
                case AccelerationUnit.FootPerSecondSquared: return _value*0.304800;
                case AccelerationUnit.InchPerSecondSquared: return _value*0.0254;
                case AccelerationUnit.KilometerPerSecondSquared: return (_value) * 1e3d;
                case AccelerationUnit.KnotPerHour: return _value*0.5144444444444/3600;
                case AccelerationUnit.KnotPerMinute: return _value*0.5144444444444/60;
                case AccelerationUnit.KnotPerSecond: return _value*0.5144444444444;
                case AccelerationUnit.MeterPerSecondSquared: return _value;
                case AccelerationUnit.MicrometerPerSecondSquared: return (_value) * 1e-6d;
                case AccelerationUnit.MillimeterPerSecondSquared: return (_value) * 1e-3d;
                case AccelerationUnit.MillistandardGravity: return (_value*9.80665) * 1e-3d;
                case AccelerationUnit.NanometerPerSecondSquared: return (_value) * 1e-9d;
                case AccelerationUnit.StandardGravity: return _value*9.80665;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(AccelerationUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case AccelerationUnit.CentimeterPerSecondSquared: return (baseUnitValue) / 1e-2d;
                case AccelerationUnit.DecimeterPerSecondSquared: return (baseUnitValue) / 1e-1d;
                case AccelerationUnit.FootPerSecondSquared: return baseUnitValue/0.304800;
                case AccelerationUnit.InchPerSecondSquared: return baseUnitValue/0.0254;
                case AccelerationUnit.KilometerPerSecondSquared: return (baseUnitValue) / 1e3d;
                case AccelerationUnit.KnotPerHour: return baseUnitValue/0.5144444444444*3600;
                case AccelerationUnit.KnotPerMinute: return baseUnitValue/0.5144444444444*60;
                case AccelerationUnit.KnotPerSecond: return baseUnitValue/0.5144444444444;
                case AccelerationUnit.MeterPerSecondSquared: return baseUnitValue;
                case AccelerationUnit.MicrometerPerSecondSquared: return (baseUnitValue) / 1e-6d;
                case AccelerationUnit.MillimeterPerSecondSquared: return (baseUnitValue) / 1e-3d;
                case AccelerationUnit.MillistandardGravity: return (baseUnitValue/9.80665) / 1e-3d;
                case AccelerationUnit.NanometerPerSecondSquared: return (baseUnitValue) / 1e-9d;
                case AccelerationUnit.StandardGravity: return baseUnitValue/9.80665;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}


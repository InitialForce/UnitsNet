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
    ///     The magnitude of torque per unit length.
    /// </summary>
    public struct  TorquePerLength
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TorquePerLengthUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public TorquePerLengthUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public TorquePerLength(double value, TorquePerLengthUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static TorquePerLengthUnit BaseUnit { get; } = TorquePerLengthUnit.NewtonMeterPerMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static TorquePerLength MaxValue { get; } = new TorquePerLength(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static TorquePerLength MinValue { get; } = new TorquePerLength(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static TorquePerLength Zero { get; } = new TorquePerLength(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get TorquePerLength in KilogramForceCentimetersPerMeter.
        /// </summary>
        public double KilogramForceCentimetersPerMeter => As(TorquePerLengthUnit.KilogramForceCentimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in KilogramForceMetersPerMeter.
        /// </summary>
        public double KilogramForceMetersPerMeter => As(TorquePerLengthUnit.KilogramForceMeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in KilogramForceMillimetersPerMeter.
        /// </summary>
        public double KilogramForceMillimetersPerMeter => As(TorquePerLengthUnit.KilogramForceMillimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in KilonewtonCentimetersPerMeter.
        /// </summary>
        public double KilonewtonCentimetersPerMeter => As(TorquePerLengthUnit.KilonewtonCentimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in KilonewtonMetersPerMeter.
        /// </summary>
        public double KilonewtonMetersPerMeter => As(TorquePerLengthUnit.KilonewtonMeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in KilonewtonMillimetersPerMeter.
        /// </summary>
        public double KilonewtonMillimetersPerMeter => As(TorquePerLengthUnit.KilonewtonMillimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in KilopoundForceFeetPerFoot.
        /// </summary>
        public double KilopoundForceFeetPerFoot => As(TorquePerLengthUnit.KilopoundForceFootPerFoot);

        /// <summary>
        ///     Get TorquePerLength in KilopoundForceInchesPerFoot.
        /// </summary>
        public double KilopoundForceInchesPerFoot => As(TorquePerLengthUnit.KilopoundForceInchPerFoot);

        /// <summary>
        ///     Get TorquePerLength in MeganewtonCentimetersPerMeter.
        /// </summary>
        public double MeganewtonCentimetersPerMeter => As(TorquePerLengthUnit.MeganewtonCentimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in MeganewtonMetersPerMeter.
        /// </summary>
        public double MeganewtonMetersPerMeter => As(TorquePerLengthUnit.MeganewtonMeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in MeganewtonMillimetersPerMeter.
        /// </summary>
        public double MeganewtonMillimetersPerMeter => As(TorquePerLengthUnit.MeganewtonMillimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in MegapoundForceFeetPerFoot.
        /// </summary>
        public double MegapoundForceFeetPerFoot => As(TorquePerLengthUnit.MegapoundForceFootPerFoot);

        /// <summary>
        ///     Get TorquePerLength in MegapoundForceInchesPerFoot.
        /// </summary>
        public double MegapoundForceInchesPerFoot => As(TorquePerLengthUnit.MegapoundForceInchPerFoot);

        /// <summary>
        ///     Get TorquePerLength in NewtonCentimetersPerMeter.
        /// </summary>
        public double NewtonCentimetersPerMeter => As(TorquePerLengthUnit.NewtonCentimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in NewtonMetersPerMeter.
        /// </summary>
        public double NewtonMetersPerMeter => As(TorquePerLengthUnit.NewtonMeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in NewtonMillimetersPerMeter.
        /// </summary>
        public double NewtonMillimetersPerMeter => As(TorquePerLengthUnit.NewtonMillimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in PoundForceFeetPerFoot.
        /// </summary>
        public double PoundForceFeetPerFoot => As(TorquePerLengthUnit.PoundForceFootPerFoot);

        /// <summary>
        ///     Get TorquePerLength in PoundForceInchesPerFoot.
        /// </summary>
        public double PoundForceInchesPerFoot => As(TorquePerLengthUnit.PoundForceInchPerFoot);

        /// <summary>
        ///     Get TorquePerLength in TonneForceCentimetersPerMeter.
        /// </summary>
        public double TonneForceCentimetersPerMeter => As(TorquePerLengthUnit.TonneForceCentimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in TonneForceMetersPerMeter.
        /// </summary>
        public double TonneForceMetersPerMeter => As(TorquePerLengthUnit.TonneForceMeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength in TonneForceMillimetersPerMeter.
        /// </summary>
        public double TonneForceMillimetersPerMeter => As(TorquePerLengthUnit.TonneForceMillimeterPerMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get TorquePerLength from KilogramForceCentimetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilogramForceCentimetersPerMeter(double kilogramforcecentimeterspermeter) => new TorquePerLength(kilogramforcecentimeterspermeter, TorquePerLengthUnit.KilogramForceCentimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from KilogramForceMetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilogramForceMetersPerMeter(double kilogramforcemeterspermeter) => new TorquePerLength(kilogramforcemeterspermeter, TorquePerLengthUnit.KilogramForceMeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from KilogramForceMillimetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilogramForceMillimetersPerMeter(double kilogramforcemillimeterspermeter) => new TorquePerLength(kilogramforcemillimeterspermeter, TorquePerLengthUnit.KilogramForceMillimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from KilonewtonCentimetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilonewtonCentimetersPerMeter(double kilonewtoncentimeterspermeter) => new TorquePerLength(kilonewtoncentimeterspermeter, TorquePerLengthUnit.KilonewtonCentimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from KilonewtonMetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilonewtonMetersPerMeter(double kilonewtonmeterspermeter) => new TorquePerLength(kilonewtonmeterspermeter, TorquePerLengthUnit.KilonewtonMeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from KilonewtonMillimetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilonewtonMillimetersPerMeter(double kilonewtonmillimeterspermeter) => new TorquePerLength(kilonewtonmillimeterspermeter, TorquePerLengthUnit.KilonewtonMillimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from KilopoundForceFeetPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilopoundForceFeetPerFoot(double kilopoundforcefeetperfoot) => new TorquePerLength(kilopoundforcefeetperfoot, TorquePerLengthUnit.KilopoundForceFootPerFoot);

        /// <summary>
        ///     Get TorquePerLength from KilopoundForceInchesPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilopoundForceInchesPerFoot(double kilopoundforceinchesperfoot) => new TorquePerLength(kilopoundforceinchesperfoot, TorquePerLengthUnit.KilopoundForceInchPerFoot);

        /// <summary>
        ///     Get TorquePerLength from MeganewtonCentimetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromMeganewtonCentimetersPerMeter(double meganewtoncentimeterspermeter) => new TorquePerLength(meganewtoncentimeterspermeter, TorquePerLengthUnit.MeganewtonCentimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from MeganewtonMetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromMeganewtonMetersPerMeter(double meganewtonmeterspermeter) => new TorquePerLength(meganewtonmeterspermeter, TorquePerLengthUnit.MeganewtonMeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from MeganewtonMillimetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromMeganewtonMillimetersPerMeter(double meganewtonmillimeterspermeter) => new TorquePerLength(meganewtonmillimeterspermeter, TorquePerLengthUnit.MeganewtonMillimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from MegapoundForceFeetPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromMegapoundForceFeetPerFoot(double megapoundforcefeetperfoot) => new TorquePerLength(megapoundforcefeetperfoot, TorquePerLengthUnit.MegapoundForceFootPerFoot);

        /// <summary>
        ///     Get TorquePerLength from MegapoundForceInchesPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromMegapoundForceInchesPerFoot(double megapoundforceinchesperfoot) => new TorquePerLength(megapoundforceinchesperfoot, TorquePerLengthUnit.MegapoundForceInchPerFoot);

        /// <summary>
        ///     Get TorquePerLength from NewtonCentimetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromNewtonCentimetersPerMeter(double newtoncentimeterspermeter) => new TorquePerLength(newtoncentimeterspermeter, TorquePerLengthUnit.NewtonCentimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from NewtonMetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromNewtonMetersPerMeter(double newtonmeterspermeter) => new TorquePerLength(newtonmeterspermeter, TorquePerLengthUnit.NewtonMeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from NewtonMillimetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromNewtonMillimetersPerMeter(double newtonmillimeterspermeter) => new TorquePerLength(newtonmillimeterspermeter, TorquePerLengthUnit.NewtonMillimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from PoundForceFeetPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromPoundForceFeetPerFoot(double poundforcefeetperfoot) => new TorquePerLength(poundforcefeetperfoot, TorquePerLengthUnit.PoundForceFootPerFoot);

        /// <summary>
        ///     Get TorquePerLength from PoundForceInchesPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromPoundForceInchesPerFoot(double poundforceinchesperfoot) => new TorquePerLength(poundforceinchesperfoot, TorquePerLengthUnit.PoundForceInchPerFoot);

        /// <summary>
        ///     Get TorquePerLength from TonneForceCentimetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromTonneForceCentimetersPerMeter(double tonneforcecentimeterspermeter) => new TorquePerLength(tonneforcecentimeterspermeter, TorquePerLengthUnit.TonneForceCentimeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from TonneForceMetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromTonneForceMetersPerMeter(double tonneforcemeterspermeter) => new TorquePerLength(tonneforcemeterspermeter, TorquePerLengthUnit.TonneForceMeterPerMeter);

        /// <summary>
        ///     Get TorquePerLength from TonneForceMillimetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromTonneForceMillimetersPerMeter(double tonneforcemillimeterspermeter) => new TorquePerLength(tonneforcemillimeterspermeter, TorquePerLengthUnit.TonneForceMillimeterPerMeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TorquePerLengthUnit" /> to <see cref="TorquePerLength" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>TorquePerLength unit value.</returns>
        public static TorquePerLength From(double value, TorquePerLengthUnit fromUnit)
        {
            return new TorquePerLength(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TorquePerLengthUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public TorquePerLength ToUnit(TorquePerLengthUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new TorquePerLength(convertedValue, unit);
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
                case TorquePerLengthUnit.KilogramForceCentimeterPerMeter: return _value*0.0980665019960652;
                case TorquePerLengthUnit.KilogramForceMeterPerMeter: return _value*9.80665019960652;
                case TorquePerLengthUnit.KilogramForceMillimeterPerMeter: return _value*0.00980665019960652;
                case TorquePerLengthUnit.KilonewtonCentimeterPerMeter: return (_value*0.01) * 1e3d;
                case TorquePerLengthUnit.KilonewtonMeterPerMeter: return (_value) * 1e3d;
                case TorquePerLengthUnit.KilonewtonMillimeterPerMeter: return (_value*0.001) * 1e3d;
                case TorquePerLengthUnit.KilopoundForceFootPerFoot: return (_value*4.44822161526) * 1e3d;
                case TorquePerLengthUnit.KilopoundForceInchPerFoot: return (_value*0.370685147638) * 1e3d;
                case TorquePerLengthUnit.MeganewtonCentimeterPerMeter: return (_value*0.01) * 1e6d;
                case TorquePerLengthUnit.MeganewtonMeterPerMeter: return (_value) * 1e6d;
                case TorquePerLengthUnit.MeganewtonMillimeterPerMeter: return (_value*0.001) * 1e6d;
                case TorquePerLengthUnit.MegapoundForceFootPerFoot: return (_value*4.44822161526) * 1e6d;
                case TorquePerLengthUnit.MegapoundForceInchPerFoot: return (_value*0.370685147638) * 1e6d;
                case TorquePerLengthUnit.NewtonCentimeterPerMeter: return _value*0.01;
                case TorquePerLengthUnit.NewtonMeterPerMeter: return _value;
                case TorquePerLengthUnit.NewtonMillimeterPerMeter: return _value*0.001;
                case TorquePerLengthUnit.PoundForceFootPerFoot: return _value*4.44822161526;
                case TorquePerLengthUnit.PoundForceInchPerFoot: return _value*0.370685147638;
                case TorquePerLengthUnit.TonneForceCentimeterPerMeter: return _value*98.0665019960652;
                case TorquePerLengthUnit.TonneForceMeterPerMeter: return _value*9806.65019960653;
                case TorquePerLengthUnit.TonneForceMillimeterPerMeter: return _value*9.80665019960652;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(TorquePerLengthUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case TorquePerLengthUnit.KilogramForceCentimeterPerMeter: return baseUnitValue*10.1971619222242;
                case TorquePerLengthUnit.KilogramForceMeterPerMeter: return baseUnitValue*0.101971619222242;
                case TorquePerLengthUnit.KilogramForceMillimeterPerMeter: return baseUnitValue*101.971619222242;
                case TorquePerLengthUnit.KilonewtonCentimeterPerMeter: return (baseUnitValue*100) / 1e3d;
                case TorquePerLengthUnit.KilonewtonMeterPerMeter: return (baseUnitValue) / 1e3d;
                case TorquePerLengthUnit.KilonewtonMillimeterPerMeter: return (baseUnitValue*1000) / 1e3d;
                case TorquePerLengthUnit.KilopoundForceFootPerFoot: return (baseUnitValue/4.44822161526) / 1e3d;
                case TorquePerLengthUnit.KilopoundForceInchPerFoot: return (baseUnitValue/0.370685147638) / 1e3d;
                case TorquePerLengthUnit.MeganewtonCentimeterPerMeter: return (baseUnitValue*100) / 1e6d;
                case TorquePerLengthUnit.MeganewtonMeterPerMeter: return (baseUnitValue) / 1e6d;
                case TorquePerLengthUnit.MeganewtonMillimeterPerMeter: return (baseUnitValue*1000) / 1e6d;
                case TorquePerLengthUnit.MegapoundForceFootPerFoot: return (baseUnitValue/4.44822161526) / 1e6d;
                case TorquePerLengthUnit.MegapoundForceInchPerFoot: return (baseUnitValue/0.370685147638) / 1e6d;
                case TorquePerLengthUnit.NewtonCentimeterPerMeter: return baseUnitValue*100;
                case TorquePerLengthUnit.NewtonMeterPerMeter: return baseUnitValue;
                case TorquePerLengthUnit.NewtonMillimeterPerMeter: return baseUnitValue*1000;
                case TorquePerLengthUnit.PoundForceFootPerFoot: return baseUnitValue/4.44822161526;
                case TorquePerLengthUnit.PoundForceInchPerFoot: return baseUnitValue/0.370685147638;
                case TorquePerLengthUnit.TonneForceCentimeterPerMeter: return baseUnitValue*0.0101971619222242;
                case TorquePerLengthUnit.TonneForceMeterPerMeter: return baseUnitValue*0.000101971619222242;
                case TorquePerLengthUnit.TonneForceMillimeterPerMeter: return baseUnitValue*0.101971619222242;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}


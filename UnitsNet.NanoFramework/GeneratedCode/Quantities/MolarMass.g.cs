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
    ///     In chemistry, the molar mass M is a physical property defined as the mass of a given substance (chemical element or chemical compound) divided by the amount of substance.
    /// </summary>
    public struct  MolarMass
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarMassUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MolarMassUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public MolarMass(double value, MolarMassUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static MolarMassUnit BaseUnit { get; } = MolarMassUnit.KilogramPerMole;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static MolarMass MaxValue { get; } = new MolarMass(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static MolarMass MinValue { get; } = new MolarMass(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static MolarMass Zero { get; } = new MolarMass(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get MolarMass in CentigramsPerMole.
        /// </summary>
        public double CentigramsPerMole => As(MolarMassUnit.CentigramPerMole);

        /// <summary>
        ///     Get MolarMass in DecagramsPerMole.
        /// </summary>
        public double DecagramsPerMole => As(MolarMassUnit.DecagramPerMole);

        /// <summary>
        ///     Get MolarMass in DecigramsPerMole.
        /// </summary>
        public double DecigramsPerMole => As(MolarMassUnit.DecigramPerMole);

        /// <summary>
        ///     Get MolarMass in GramsPerMole.
        /// </summary>
        public double GramsPerMole => As(MolarMassUnit.GramPerMole);

        /// <summary>
        ///     Get MolarMass in HectogramsPerMole.
        /// </summary>
        public double HectogramsPerMole => As(MolarMassUnit.HectogramPerMole);

        /// <summary>
        ///     Get MolarMass in KilogramsPerMole.
        /// </summary>
        public double KilogramsPerMole => As(MolarMassUnit.KilogramPerMole);

        /// <summary>
        ///     Get MolarMass in KilopoundsPerMole.
        /// </summary>
        public double KilopoundsPerMole => As(MolarMassUnit.KilopoundPerMole);

        /// <summary>
        ///     Get MolarMass in MegapoundsPerMole.
        /// </summary>
        public double MegapoundsPerMole => As(MolarMassUnit.MegapoundPerMole);

        /// <summary>
        ///     Get MolarMass in MicrogramsPerMole.
        /// </summary>
        public double MicrogramsPerMole => As(MolarMassUnit.MicrogramPerMole);

        /// <summary>
        ///     Get MolarMass in MilligramsPerMole.
        /// </summary>
        public double MilligramsPerMole => As(MolarMassUnit.MilligramPerMole);

        /// <summary>
        ///     Get MolarMass in NanogramsPerMole.
        /// </summary>
        public double NanogramsPerMole => As(MolarMassUnit.NanogramPerMole);

        /// <summary>
        ///     Get MolarMass in PoundsPerMole.
        /// </summary>
        public double PoundsPerMole => As(MolarMassUnit.PoundPerMole);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get MolarMass from CentigramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromCentigramsPerMole(double centigramspermole) => new MolarMass(centigramspermole, MolarMassUnit.CentigramPerMole);

        /// <summary>
        ///     Get MolarMass from DecagramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromDecagramsPerMole(double decagramspermole) => new MolarMass(decagramspermole, MolarMassUnit.DecagramPerMole);

        /// <summary>
        ///     Get MolarMass from DecigramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromDecigramsPerMole(double decigramspermole) => new MolarMass(decigramspermole, MolarMassUnit.DecigramPerMole);

        /// <summary>
        ///     Get MolarMass from GramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromGramsPerMole(double gramspermole) => new MolarMass(gramspermole, MolarMassUnit.GramPerMole);

        /// <summary>
        ///     Get MolarMass from HectogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromHectogramsPerMole(double hectogramspermole) => new MolarMass(hectogramspermole, MolarMassUnit.HectogramPerMole);

        /// <summary>
        ///     Get MolarMass from KilogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromKilogramsPerMole(double kilogramspermole) => new MolarMass(kilogramspermole, MolarMassUnit.KilogramPerMole);

        /// <summary>
        ///     Get MolarMass from KilopoundsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromKilopoundsPerMole(double kilopoundspermole) => new MolarMass(kilopoundspermole, MolarMassUnit.KilopoundPerMole);

        /// <summary>
        ///     Get MolarMass from MegapoundsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromMegapoundsPerMole(double megapoundspermole) => new MolarMass(megapoundspermole, MolarMassUnit.MegapoundPerMole);

        /// <summary>
        ///     Get MolarMass from MicrogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromMicrogramsPerMole(double microgramspermole) => new MolarMass(microgramspermole, MolarMassUnit.MicrogramPerMole);

        /// <summary>
        ///     Get MolarMass from MilligramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromMilligramsPerMole(double milligramspermole) => new MolarMass(milligramspermole, MolarMassUnit.MilligramPerMole);

        /// <summary>
        ///     Get MolarMass from NanogramsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromNanogramsPerMole(double nanogramspermole) => new MolarMass(nanogramspermole, MolarMassUnit.NanogramPerMole);

        /// <summary>
        ///     Get MolarMass from PoundsPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarMass FromPoundsPerMole(double poundspermole) => new MolarMass(poundspermole, MolarMassUnit.PoundPerMole);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarMassUnit" /> to <see cref="MolarMass" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarMass unit value.</returns>
        public static MolarMass From(double value, MolarMassUnit fromUnit)
        {
            return new MolarMass(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MolarMassUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public MolarMass ToUnit(MolarMassUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new MolarMass(convertedValue, unit);
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
                MolarMassUnit.CentigramPerMole => (_value/1e3) * 1e-2d,
                MolarMassUnit.DecagramPerMole => (_value/1e3) * 1e1d,
                MolarMassUnit.DecigramPerMole => (_value/1e3) * 1e-1d,
                MolarMassUnit.GramPerMole => _value/1e3,
                MolarMassUnit.HectogramPerMole => (_value/1e3) * 1e2d,
                MolarMassUnit.KilogramPerMole => (_value/1e3) * 1e3d,
                MolarMassUnit.KilopoundPerMole => (_value*0.45359237) * 1e3d,
                MolarMassUnit.MegapoundPerMole => (_value*0.45359237) * 1e6d,
                MolarMassUnit.MicrogramPerMole => (_value/1e3) * 1e-6d,
                MolarMassUnit.MilligramPerMole => (_value/1e3) * 1e-3d,
                MolarMassUnit.NanogramPerMole => (_value/1e3) * 1e-9d,
                MolarMassUnit.PoundPerMole => _value*0.45359237,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(MolarMassUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                MolarMassUnit.CentigramPerMole => (baseUnitValue*1e3) / 1e-2d,
                MolarMassUnit.DecagramPerMole => (baseUnitValue*1e3) / 1e1d,
                MolarMassUnit.DecigramPerMole => (baseUnitValue*1e3) / 1e-1d,
                MolarMassUnit.GramPerMole => baseUnitValue*1e3,
                MolarMassUnit.HectogramPerMole => (baseUnitValue*1e3) / 1e2d,
                MolarMassUnit.KilogramPerMole => (baseUnitValue*1e3) / 1e3d,
                MolarMassUnit.KilopoundPerMole => (baseUnitValue/0.45359237) / 1e3d,
                MolarMassUnit.MegapoundPerMole => (baseUnitValue/0.45359237) / 1e6d,
                MolarMassUnit.MicrogramPerMole => (baseUnitValue*1e3) / 1e-6d,
                MolarMassUnit.MilligramPerMole => (baseUnitValue*1e3) / 1e-3d,
                MolarMassUnit.NanogramPerMole => (baseUnitValue*1e3) / 1e-9d,
                MolarMassUnit.PoundPerMole => baseUnitValue/0.45359237,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion

    }
}


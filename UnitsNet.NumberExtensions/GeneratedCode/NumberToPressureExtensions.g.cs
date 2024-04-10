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

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToPressure
{
    /// <summary>
    /// A number to Pressure Extensions
    /// </summary>
    public static class NumberToPressureExtensions
    {
        /// <inheritdoc cref="Pressure.FromAtmospheres(QuantityValue)" />
        public static Pressure Atmospheres<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromAtmospheres(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromBars(QuantityValue)" />
        public static Pressure Bars<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromBars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromCentibars(QuantityValue)" />
        public static Pressure Centibars<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromCentibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromCentimetersOfWaterColumn(QuantityValue)" />
        public static Pressure CentimetersOfWaterColumn<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromCentimetersOfWaterColumn(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromDecapascals(QuantityValue)" />
        public static Pressure Decapascals<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromDecapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromDecibars(QuantityValue)" />
        public static Pressure Decibars<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromDecibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromDynesPerSquareCentimeter(QuantityValue)" />
        public static Pressure DynesPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromDynesPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromFeetOfElevation(QuantityValue)" />
        public static Pressure FeetOfElevation<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromFeetOfElevation(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromFeetOfHead(QuantityValue)" />
        public static Pressure FeetOfHead<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromFeetOfHead(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromGigapascals(QuantityValue)" />
        public static Pressure Gigapascals<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromGigapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromHectopascals(QuantityValue)" />
        public static Pressure Hectopascals<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromHectopascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromInchesOfMercury(QuantityValue)" />
        public static Pressure InchesOfMercury<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromInchesOfMercury(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromInchesOfWaterColumn(QuantityValue)" />
        public static Pressure InchesOfWaterColumn<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromInchesOfWaterColumn(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilobars(QuantityValue)" />
        public static Pressure Kilobars<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilobars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(QuantityValue)" />
        public static Pressure KilogramsForcePerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilogramsForcePerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(QuantityValue)" />
        public static Pressure KilogramsForcePerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilogramsForcePerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(QuantityValue)" />
        public static Pressure KilogramsForcePerSquareMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilogramsForcePerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(QuantityValue)" />
        public static Pressure KilonewtonsPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilonewtonsPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(QuantityValue)" />
        public static Pressure KilonewtonsPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilonewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(QuantityValue)" />
        public static Pressure KilonewtonsPerSquareMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilonewtonsPerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopascals(QuantityValue)" />
        public static Pressure Kilopascals<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilopascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(QuantityValue)" />
        public static Pressure KilopoundsForcePerSquareFoot<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilopoundsForcePerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(QuantityValue)" />
        public static Pressure KilopoundsForcePerSquareInch<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilopoundsForcePerSquareInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareMil(QuantityValue)" />
        public static Pressure KilopoundsForcePerSquareMil<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromKilopoundsForcePerSquareMil(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMegabars(QuantityValue)" />
        public static Pressure Megabars<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMegabars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMeganewtonsPerSquareMeter(QuantityValue)" />
        public static Pressure MeganewtonsPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMeganewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMegapascals(QuantityValue)" />
        public static Pressure Megapascals<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMegapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMetersOfElevation(QuantityValue)" />
        public static Pressure MetersOfElevation<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMetersOfElevation(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMetersOfHead(QuantityValue)" />
        public static Pressure MetersOfHead<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMetersOfHead(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMetersOfWaterColumn(QuantityValue)" />
        public static Pressure MetersOfWaterColumn<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMetersOfWaterColumn(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMicrobars(QuantityValue)" />
        public static Pressure Microbars<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMicrobars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMicropascals(QuantityValue)" />
        public static Pressure Micropascals<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMicropascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMillibars(QuantityValue)" />
        public static Pressure Millibars<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMillibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMillimetersOfMercury(QuantityValue)" />
        public static Pressure MillimetersOfMercury<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMillimetersOfMercury(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMillimetersOfWaterColumn(QuantityValue)" />
        public static Pressure MillimetersOfWaterColumn<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMillimetersOfWaterColumn(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMillipascals(QuantityValue)" />
        public static Pressure Millipascals<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromMillipascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(QuantityValue)" />
        public static Pressure NewtonsPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromNewtonsPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(QuantityValue)" />
        public static Pressure NewtonsPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromNewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(QuantityValue)" />
        public static Pressure NewtonsPerSquareMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromNewtonsPerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPascals(QuantityValue)" />
        public static Pressure Pascals<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromPascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(QuantityValue)" />
        public static Pressure PoundsForcePerSquareFoot<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromPoundsForcePerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(QuantityValue)" />
        public static Pressure PoundsForcePerSquareInch<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromPoundsForcePerSquareInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareMil(QuantityValue)" />
        public static Pressure PoundsForcePerSquareMil<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromPoundsForcePerSquareMil(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsPerInchSecondSquared(QuantityValue)" />
        public static Pressure PoundsPerInchSecondSquared<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromPoundsPerInchSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(QuantityValue)" />
        public static Pressure TechnicalAtmospheres<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromTechnicalAtmospheres(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(QuantityValue)" />
        public static Pressure TonnesForcePerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromTonnesForcePerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(QuantityValue)" />
        public static Pressure TonnesForcePerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromTonnesForcePerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(QuantityValue)" />
        public static Pressure TonnesForcePerSquareMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromTonnesForcePerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTorrs(QuantityValue)" />
        public static Pressure Torrs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Pressure.FromTorrs(Convert.ToDouble(value));

    }
}

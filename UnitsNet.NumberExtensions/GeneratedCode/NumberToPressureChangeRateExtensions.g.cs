﻿//------------------------------------------------------------------------------
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

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToPressureChangeRate
{
    /// <summary>
    /// A number to PressureChangeRate Extensions
    /// </summary>
    public static class NumberToPressureChangeRateExtensions
    {
        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(UnitsNet.QuantityValue)" />
        public static PressureChangeRate AtmospheresPerSecond<T>(this T value) =>
            PressureChangeRate.FromAtmospheresPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromBarsPerMinute(UnitsNet.QuantityValue)" />
        public static PressureChangeRate BarsPerMinute<T>(this T value) =>
            PressureChangeRate.FromBarsPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromBarsPerSecond(UnitsNet.QuantityValue)" />
        public static PressureChangeRate BarsPerSecond<T>(this T value) =>
            PressureChangeRate.FromBarsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerMinute(UnitsNet.QuantityValue)" />
        public static PressureChangeRate KilopascalsPerMinute<T>(this T value) =>
            PressureChangeRate.FromKilopascalsPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(UnitsNet.QuantityValue)" />
        public static PressureChangeRate KilopascalsPerSecond<T>(this T value) =>
            PressureChangeRate.FromKilopascalsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerMinute(UnitsNet.QuantityValue)" />
        public static PressureChangeRate MegapascalsPerMinute<T>(this T value) =>
            PressureChangeRate.FromMegapascalsPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(UnitsNet.QuantityValue)" />
        public static PressureChangeRate MegapascalsPerSecond<T>(this T value) =>
            PressureChangeRate.FromMegapascalsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerMinute(UnitsNet.QuantityValue)" />
        public static PressureChangeRate PascalsPerMinute<T>(this T value) =>
            PressureChangeRate.FromPascalsPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(UnitsNet.QuantityValue)" />
        public static PressureChangeRate PascalsPerSecond<T>(this T value) =>
            PressureChangeRate.FromPascalsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromPoundForcesPerSquareInchPerMinute(UnitsNet.QuantityValue)" />
        public static PressureChangeRate PoundForcesPerSquareInchPerMinute<T>(this T value) =>
            PressureChangeRate.FromPoundForcesPerSquareInchPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromPoundForcesPerSquareInchPerSecond(UnitsNet.QuantityValue)" />
        public static PressureChangeRate PoundForcesPerSquareInchPerSecond<T>(this T value) =>
            PressureChangeRate.FromPoundForcesPerSquareInchPerSecond(Convert.ToDouble(value));

    }
}

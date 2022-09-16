//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/OasysUnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnitsNet.

using System;

#nullable enable

namespace OasysUnitsNet.NumberExtensions.NumberToTemperatureDelta
{
    /// <summary>
    /// A number to TemperatureDelta Extensions
    /// </summary>
    public static class NumberToTemperatureDeltaExtensions
    {
        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsius(OasysUnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesCelsius<T>(this T value) =>
            TemperatureDelta.FromDegreesCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesDelisle(OasysUnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesDelisle<T>(this T value) =>
            TemperatureDelta.FromDegreesDelisle(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheit(OasysUnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesFahrenheit<T>(this T value) =>
            TemperatureDelta.FromDegreesFahrenheit(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewton(OasysUnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesNewton<T>(this T value) =>
            TemperatureDelta.FromDegreesNewton(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankine(OasysUnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesRankine<T>(this T value) =>
            TemperatureDelta.FromDegreesRankine(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesReaumur(OasysUnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesReaumur<T>(this T value) =>
            TemperatureDelta.FromDegreesReaumur(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRoemer(OasysUnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesRoemer<T>(this T value) =>
            TemperatureDelta.FromDegreesRoemer(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromKelvins(OasysUnitsNet.QuantityValue)" />
        public static TemperatureDelta Kelvins<T>(this T value) =>
            TemperatureDelta.FromKelvins(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureDelta.FromMillidegreesCelsius(OasysUnitsNet.QuantityValue)" />
        public static TemperatureDelta MillidegreesCelsius<T>(this T value) =>
            TemperatureDelta.FromMillidegreesCelsius(Convert.ToDouble(value));

    }
}

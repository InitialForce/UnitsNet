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

namespace OasysUnitsNet.NumberExtensions.NumberToFuelEfficiency
{
    /// <summary>
    /// A number to FuelEfficiency Extensions
    /// </summary>
    public static class NumberToFuelEfficiencyExtensions
    {
        /// <inheritdoc cref="FuelEfficiency.FromKilometersPerLiters(OasysUnitsNet.QuantityValue)" />
        public static FuelEfficiency KilometersPerLiters<T>(this T value) =>
            FuelEfficiency.FromKilometersPerLiters(Convert.ToDouble(value));

        /// <inheritdoc cref="FuelEfficiency.FromLitersPer100Kilometers(OasysUnitsNet.QuantityValue)" />
        public static FuelEfficiency LitersPer100Kilometers<T>(this T value) =>
            FuelEfficiency.FromLitersPer100Kilometers(Convert.ToDouble(value));

        /// <inheritdoc cref="FuelEfficiency.FromMilesPerUkGallon(OasysUnitsNet.QuantityValue)" />
        public static FuelEfficiency MilesPerUkGallon<T>(this T value) =>
            FuelEfficiency.FromMilesPerUkGallon(Convert.ToDouble(value));

        /// <inheritdoc cref="FuelEfficiency.FromMilesPerUsGallon(OasysUnitsNet.QuantityValue)" />
        public static FuelEfficiency MilesPerUsGallon<T>(this T value) =>
            FuelEfficiency.FromMilesPerUsGallon(Convert.ToDouble(value));

    }
}

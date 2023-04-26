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

#nullable enable

namespace OasysUnits.NumberExtensions.NumberToAreaDensity
{
    /// <summary>
    /// A number to AreaDensity Extensions
    /// </summary>
    public static class NumberToAreaDensityExtensions
    {
        /// <inheritdoc cref="AreaDensity.FromGramsPerSquareMeter(OasysUnits.QuantityValue)" />
        public static AreaDensity GramsPerSquareMeter<T>(this T value) =>
            AreaDensity.FromGramsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="AreaDensity.FromKilogramsPerSquareMeter(OasysUnits.QuantityValue)" />
        public static AreaDensity KilogramsPerSquareMeter<T>(this T value) =>
            AreaDensity.FromKilogramsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="AreaDensity.FromMilligramsPerSquareMeter(OasysUnits.QuantityValue)" />
        public static AreaDensity MilligramsPerSquareMeter<T>(this T value) =>
            AreaDensity.FromMilligramsPerSquareMeter(Convert.ToDouble(value));

    }
}

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

namespace OasysUnitsNet.NumberExtensions.NumberToLevel
{
    /// <summary>
    /// A number to Level Extensions
    /// </summary>
    public static class NumberToLevelExtensions
    {
        /// <inheritdoc cref="Level.FromDecibels(OasysUnitsNet.QuantityValue)" />
        public static Level Decibels<T>(this T value) =>
            Level.FromDecibels(Convert.ToDouble(value));

        /// <inheritdoc cref="Level.FromNepers(OasysUnitsNet.QuantityValue)" />
        public static Level Nepers<T>(this T value) =>
            Level.FromNepers(Convert.ToDouble(value));

    }
}

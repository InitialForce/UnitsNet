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

namespace UnitsNet.NumberExtensions.NumberToMolarEnergy
{
    /// <summary>
    /// A number to MolarEnergy Extensions
    /// </summary>
    public static class NumberToMolarEnergyExtensions
    {
        /// <inheritdoc cref="MolarEnergy.FromJoulesPerMole(UnitsNet.QuantityValue)" />
        public static MolarEnergy JoulesPerMole<T>(this T value) =>
            MolarEnergy.FromJoulesPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarEnergy.FromKilojoulesPerMole(UnitsNet.QuantityValue)" />
        public static MolarEnergy KilojoulesPerMole<T>(this T value) =>
            MolarEnergy.FromKilojoulesPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarEnergy.FromMegajoulesPerMole(UnitsNet.QuantityValue)" />
        public static MolarEnergy MegajoulesPerMole<T>(this T value) =>
            MolarEnergy.FromMegajoulesPerMole(Convert.ToDouble(value));

    }
}

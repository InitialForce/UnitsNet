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

namespace UnitsNet.NumberExtensions.NumberToSpecificVolume
{
    /// <summary>
    /// A number to SpecificVolume Extensions
    /// </summary>
    public static class NumberToSpecificVolumeExtensions
    {
        /// <inheritdoc cref="SpecificVolume.FromCubicFeetPerPound(QuantityValue)" />
        public static SpecificVolume CubicFeetPerPound<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => SpecificVolume.FromCubicFeetPerPound(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificVolume.FromCubicMetersPerKilogram(QuantityValue)" />
        public static SpecificVolume CubicMetersPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => SpecificVolume.FromCubicMetersPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificVolume.FromMillicubicMetersPerKilogram(QuantityValue)" />
        public static SpecificVolume MillicubicMetersPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => SpecificVolume.FromMillicubicMetersPerKilogram(Convert.ToDouble(value));

    }
}

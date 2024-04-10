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

namespace UnitsNet.NumberExtensions.NumberToMolarity
{
    /// <summary>
    /// A number to Molarity Extensions
    /// </summary>
    public static class NumberToMolarityExtensions
    {
        /// <inheritdoc cref="Molarity.FromCentimolesPerLiter(QuantityValue)" />
        public static Molarity CentimolesPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromCentimolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromDecimolesPerLiter(QuantityValue)" />
        public static Molarity DecimolesPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromDecimolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromFemtomolesPerLiter(QuantityValue)" />
        public static Molarity FemtomolesPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromFemtomolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromKilomolesPerCubicMeter(QuantityValue)" />
        public static Molarity KilomolesPerCubicMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromKilomolesPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromMicromolesPerLiter(QuantityValue)" />
        public static Molarity MicromolesPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromMicromolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromMillimolesPerLiter(QuantityValue)" />
        public static Molarity MillimolesPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromMillimolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromMolesPerCubicMeter(QuantityValue)" />
        public static Molarity MolesPerCubicMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromMolesPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromMolesPerLiter(QuantityValue)" />
        public static Molarity MolesPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromMolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromNanomolesPerLiter(QuantityValue)" />
        public static Molarity NanomolesPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromNanomolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromPicomolesPerLiter(QuantityValue)" />
        public static Molarity PicomolesPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromPicomolesPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Molarity.FromPoundMolesPerCubicFoot(QuantityValue)" />
        public static Molarity PoundMolesPerCubicFoot<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molarity.FromPoundMolesPerCubicFoot(Convert.ToDouble(value));

    }
}

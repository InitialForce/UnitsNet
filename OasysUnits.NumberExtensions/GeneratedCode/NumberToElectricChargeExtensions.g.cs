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

namespace OasysUnits.NumberExtensions.NumberToElectricCharge
{
    /// <summary>
    /// A number to ElectricCharge Extensions
    /// </summary>
    public static class NumberToElectricChargeExtensions
    {
        /// <inheritdoc cref="ElectricCharge.FromAmpereHours(OasysUnits.QuantityValue)" />
        public static ElectricCharge AmpereHours<T>(this T value) =>
            ElectricCharge.FromAmpereHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromCoulombs(OasysUnits.QuantityValue)" />
        public static ElectricCharge Coulombs<T>(this T value) =>
            ElectricCharge.FromCoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromKiloampereHours(OasysUnits.QuantityValue)" />
        public static ElectricCharge KiloampereHours<T>(this T value) =>
            ElectricCharge.FromKiloampereHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromKilocoulombs(OasysUnits.QuantityValue)" />
        public static ElectricCharge Kilocoulombs<T>(this T value) =>
            ElectricCharge.FromKilocoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromMegaampereHours(OasysUnits.QuantityValue)" />
        public static ElectricCharge MegaampereHours<T>(this T value) =>
            ElectricCharge.FromMegaampereHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromMegacoulombs(OasysUnits.QuantityValue)" />
        public static ElectricCharge Megacoulombs<T>(this T value) =>
            ElectricCharge.FromMegacoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromMicrocoulombs(OasysUnits.QuantityValue)" />
        public static ElectricCharge Microcoulombs<T>(this T value) =>
            ElectricCharge.FromMicrocoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromMilliampereHours(OasysUnits.QuantityValue)" />
        public static ElectricCharge MilliampereHours<T>(this T value) =>
            ElectricCharge.FromMilliampereHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromMillicoulombs(OasysUnits.QuantityValue)" />
        public static ElectricCharge Millicoulombs<T>(this T value) =>
            ElectricCharge.FromMillicoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromNanocoulombs(OasysUnits.QuantityValue)" />
        public static ElectricCharge Nanocoulombs<T>(this T value) =>
            ElectricCharge.FromNanocoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromPicocoulombs(OasysUnits.QuantityValue)" />
        public static ElectricCharge Picocoulombs<T>(this T value) =>
            ElectricCharge.FromPicocoulombs(Convert.ToDouble(value));

    }
}

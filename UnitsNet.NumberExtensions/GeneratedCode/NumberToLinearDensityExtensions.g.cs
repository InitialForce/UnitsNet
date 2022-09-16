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

namespace OasysUnitsNet.NumberExtensions.NumberToLinearDensity
{
    /// <summary>
    /// A number to LinearDensity Extensions
    /// </summary>
    public static class NumberToLinearDensityExtensions
    {
        /// <inheritdoc cref="LinearDensity.FromGramsPerCentimeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity GramsPerCentimeter<T>(this T value) =>
            LinearDensity.FromGramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromGramsPerMeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity GramsPerMeter<T>(this T value) =>
            LinearDensity.FromGramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromGramsPerMillimeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity GramsPerMillimeter<T>(this T value) =>
            LinearDensity.FromGramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromKilogramsPerCentimeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity KilogramsPerCentimeter<T>(this T value) =>
            LinearDensity.FromKilogramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromKilogramsPerMeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity KilogramsPerMeter<T>(this T value) =>
            LinearDensity.FromKilogramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromKilogramsPerMillimeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity KilogramsPerMillimeter<T>(this T value) =>
            LinearDensity.FromKilogramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMicrogramsPerCentimeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity MicrogramsPerCentimeter<T>(this T value) =>
            LinearDensity.FromMicrogramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMicrogramsPerMeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity MicrogramsPerMeter<T>(this T value) =>
            LinearDensity.FromMicrogramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMicrogramsPerMillimeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity MicrogramsPerMillimeter<T>(this T value) =>
            LinearDensity.FromMicrogramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMilligramsPerCentimeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity MilligramsPerCentimeter<T>(this T value) =>
            LinearDensity.FromMilligramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMilligramsPerMeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity MilligramsPerMeter<T>(this T value) =>
            LinearDensity.FromMilligramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMilligramsPerMillimeter(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity MilligramsPerMillimeter<T>(this T value) =>
            LinearDensity.FromMilligramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromPoundsPerFoot(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity PoundsPerFoot<T>(this T value) =>
            LinearDensity.FromPoundsPerFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromPoundsPerInch(OasysUnitsNet.QuantityValue)" />
        public static LinearDensity PoundsPerInch<T>(this T value) =>
            LinearDensity.FromPoundsPerInch(Convert.ToDouble(value));

    }
}

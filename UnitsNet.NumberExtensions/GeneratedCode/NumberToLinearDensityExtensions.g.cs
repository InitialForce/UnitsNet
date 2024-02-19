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

namespace UnitsNet.NumberExtensions.NumberToLinearDensity
{
    /// <summary>
    /// A number to LinearDensity Extensions
    /// </summary>
    public static class NumberToLinearDensityExtensions
    {
        /// <inheritdoc cref="LinearDensity.FromGramsPerCentimeter(double)" />
        public static LinearDensity GramsPerCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromGramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromGramsPerMeter(double)" />
        public static LinearDensity GramsPerMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromGramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromGramsPerMillimeter(double)" />
        public static LinearDensity GramsPerMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromGramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromKilogramsPerCentimeter(double)" />
        public static LinearDensity KilogramsPerCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromKilogramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromKilogramsPerMeter(double)" />
        public static LinearDensity KilogramsPerMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromKilogramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromKilogramsPerMillimeter(double)" />
        public static LinearDensity KilogramsPerMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromKilogramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMicrogramsPerCentimeter(double)" />
        public static LinearDensity MicrogramsPerCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromMicrogramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMicrogramsPerMeter(double)" />
        public static LinearDensity MicrogramsPerMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromMicrogramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMicrogramsPerMillimeter(double)" />
        public static LinearDensity MicrogramsPerMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromMicrogramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMilligramsPerCentimeter(double)" />
        public static LinearDensity MilligramsPerCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromMilligramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMilligramsPerMeter(double)" />
        public static LinearDensity MilligramsPerMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromMilligramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMilligramsPerMillimeter(double)" />
        public static LinearDensity MilligramsPerMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromMilligramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromPoundsPerFoot(double)" />
        public static LinearDensity PoundsPerFoot<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromPoundsPerFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromPoundsPerInch(double)" />
        public static LinearDensity PoundsPerInch<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => LinearDensity.FromPoundsPerInch(Convert.ToDouble(value));

    }
}

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

namespace UnitsNet.NumberExtensions.NumberToTemperatureChangeRate
{
    /// <summary>
    /// A number to TemperatureChangeRate Extensions
    /// </summary>
    public static class NumberToTemperatureChangeRateExtensions
    {
        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(QuantityValue)" />
        public static TemperatureChangeRate CentidegreesCelsiusPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(QuantityValue)" />
        public static TemperatureChangeRate DecadegreesCelsiusPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(QuantityValue)" />
        public static TemperatureChangeRate DecidegreesCelsiusPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerMinute(QuantityValue)" />
        public static TemperatureChangeRate DegreesCelsiusPerMinute<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => TemperatureChangeRate.FromDegreesCelsiusPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(QuantityValue)" />
        public static TemperatureChangeRate DegreesCelsiusPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => TemperatureChangeRate.FromDegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(QuantityValue)" />
        public static TemperatureChangeRate HectodegreesCelsiusPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(QuantityValue)" />
        public static TemperatureChangeRate KilodegreesCelsiusPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(QuantityValue)" />
        public static TemperatureChangeRate MicrodegreesCelsiusPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(QuantityValue)" />
        public static TemperatureChangeRate MillidegreesCelsiusPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(QuantityValue)" />
        public static TemperatureChangeRate NanodegreesCelsiusPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(Convert.ToDouble(value));

    }
}

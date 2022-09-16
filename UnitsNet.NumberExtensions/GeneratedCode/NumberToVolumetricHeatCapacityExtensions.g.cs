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

namespace OasysUnitsNet.NumberExtensions.NumberToVolumetricHeatCapacity
{
    /// <summary>
    /// A number to VolumetricHeatCapacity Extensions
    /// </summary>
    public static class NumberToVolumetricHeatCapacityExtensions
    {
        /// <inheritdoc cref="VolumetricHeatCapacity.FromBtusPerCubicFootDegreeFahrenheit(OasysUnitsNet.QuantityValue)" />
        public static VolumetricHeatCapacity BtusPerCubicFootDegreeFahrenheit<T>(this T value) =>
            VolumetricHeatCapacity.FromBtusPerCubicFootDegreeFahrenheit(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumetricHeatCapacity.FromCaloriesPerCubicCentimeterDegreeCelsius(OasysUnitsNet.QuantityValue)" />
        public static VolumetricHeatCapacity CaloriesPerCubicCentimeterDegreeCelsius<T>(this T value) =>
            VolumetricHeatCapacity.FromCaloriesPerCubicCentimeterDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumetricHeatCapacity.FromJoulesPerCubicMeterDegreeCelsius(OasysUnitsNet.QuantityValue)" />
        public static VolumetricHeatCapacity JoulesPerCubicMeterDegreeCelsius<T>(this T value) =>
            VolumetricHeatCapacity.FromJoulesPerCubicMeterDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumetricHeatCapacity.FromJoulesPerCubicMeterKelvin(OasysUnitsNet.QuantityValue)" />
        public static VolumetricHeatCapacity JoulesPerCubicMeterKelvin<T>(this T value) =>
            VolumetricHeatCapacity.FromJoulesPerCubicMeterKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumetricHeatCapacity.FromKilocaloriesPerCubicCentimeterDegreeCelsius(OasysUnitsNet.QuantityValue)" />
        public static VolumetricHeatCapacity KilocaloriesPerCubicCentimeterDegreeCelsius<T>(this T value) =>
            VolumetricHeatCapacity.FromKilocaloriesPerCubicCentimeterDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumetricHeatCapacity.FromKilojoulesPerCubicMeterDegreeCelsius(OasysUnitsNet.QuantityValue)" />
        public static VolumetricHeatCapacity KilojoulesPerCubicMeterDegreeCelsius<T>(this T value) =>
            VolumetricHeatCapacity.FromKilojoulesPerCubicMeterDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumetricHeatCapacity.FromKilojoulesPerCubicMeterKelvin(OasysUnitsNet.QuantityValue)" />
        public static VolumetricHeatCapacity KilojoulesPerCubicMeterKelvin<T>(this T value) =>
            VolumetricHeatCapacity.FromKilojoulesPerCubicMeterKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumetricHeatCapacity.FromMegajoulesPerCubicMeterDegreeCelsius(OasysUnitsNet.QuantityValue)" />
        public static VolumetricHeatCapacity MegajoulesPerCubicMeterDegreeCelsius<T>(this T value) =>
            VolumetricHeatCapacity.FromMegajoulesPerCubicMeterDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumetricHeatCapacity.FromMegajoulesPerCubicMeterKelvin(OasysUnitsNet.QuantityValue)" />
        public static VolumetricHeatCapacity MegajoulesPerCubicMeterKelvin<T>(this T value) =>
            VolumetricHeatCapacity.FromMegajoulesPerCubicMeterKelvin(Convert.ToDouble(value));

    }
}

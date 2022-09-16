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

namespace OasysUnitsNet.NumberExtensions.NumberToElectricConductivity
{
    /// <summary>
    /// A number to ElectricConductivity Extensions
    /// </summary>
    public static class NumberToElectricConductivityExtensions
    {
        /// <inheritdoc cref="ElectricConductivity.FromMicrosiemensPerCentimeter(OasysUnitsNet.QuantityValue)" />
        public static ElectricConductivity MicrosiemensPerCentimeter<T>(this T value) =>
            ElectricConductivity.FromMicrosiemensPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductivity.FromMillisiemensPerCentimeter(OasysUnitsNet.QuantityValue)" />
        public static ElectricConductivity MillisiemensPerCentimeter<T>(this T value) =>
            ElectricConductivity.FromMillisiemensPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductivity.FromSiemensPerCentimeter(OasysUnitsNet.QuantityValue)" />
        public static ElectricConductivity SiemensPerCentimeter<T>(this T value) =>
            ElectricConductivity.FromSiemensPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductivity.FromSiemensPerFoot(OasysUnitsNet.QuantityValue)" />
        public static ElectricConductivity SiemensPerFoot<T>(this T value) =>
            ElectricConductivity.FromSiemensPerFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductivity.FromSiemensPerInch(OasysUnitsNet.QuantityValue)" />
        public static ElectricConductivity SiemensPerInch<T>(this T value) =>
            ElectricConductivity.FromSiemensPerInch(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductivity.FromSiemensPerMeter(OasysUnitsNet.QuantityValue)" />
        public static ElectricConductivity SiemensPerMeter<T>(this T value) =>
            ElectricConductivity.FromSiemensPerMeter(Convert.ToDouble(value));

    }
}

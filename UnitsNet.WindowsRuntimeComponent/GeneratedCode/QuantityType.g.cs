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

// ReSharper disable once CheckNamespace

using System;

namespace OasysUnitsNet
{
    /// <summary>
    ///     Lists all generated quantities with the same name as the quantity struct type,
    ///     such as Length, Mass, Force etc.
    ///     This is useful for populating options in the UI, such as creating a generic conversion
    ///     tool with inputValue, quantityName, fromUnit and toUnit selectors.
    /// </summary>
    [Obsolete("QuantityType will be removed in the future. Use the QuantityInfo class instead.")]
    public enum QuantityType
    {
        Undefined = 0,
        Acceleration,
        AmountOfSubstance,
        AmplitudeRatio,
        Angle,
        ApparentEnergy,
        ApparentPower,
        Area,
        AreaDensity,
        AreaMomentOfInertia,
        AxialStiffness,
        BendingStiffness,
        BitRate,
        BrakeSpecificFuelConsumption,
        Capacitance,
        CoefficientOfThermalExpansion,
        Compressibility,
        Curvature,
        Density,
        Duration,
        DynamicViscosity,
        ElectricAdmittance,
        ElectricCharge,
        ElectricChargeDensity,
        ElectricConductance,
        ElectricConductivity,
        ElectricCurrent,
        ElectricCurrentDensity,
        ElectricCurrentGradient,
        ElectricField,
        ElectricInductance,
        ElectricPotential,
        ElectricPotentialAc,
        ElectricPotentialChangeRate,
        ElectricPotentialDc,
        ElectricResistance,
        ElectricResistivity,
        ElectricSurfaceChargeDensity,
        Energy,
        Entropy,
        Force,
        ForceChangeRate,
        ForcePerLength,
        Frequency,
        FuelEfficiency,
        HeatFlux,
        HeatTransferCoefficient,
        Illuminance,
        Information,
        Irradiance,
        Irradiation,
        Jerk,
        KinematicViscosity,
        LapseRate,
        Length,
        Level,
        LinearDensity,
        LinearPowerDensity,
        Luminance,
        Luminosity,
        LuminousFlux,
        LuminousIntensity,
        MagneticField,
        MagneticFlux,
        Magnetization,
        Mass,
        MassConcentration,
        MassFlow,
        MassFlux,
        MassFraction,
        MassMomentOfInertia,
        MolarEnergy,
        MolarEntropy,
        Molarity,
        MolarMass,
        Moment,
        Permeability,
        Permittivity,
        PorousMediumPermeability,
        Power,
        PowerDensity,
        PowerRatio,
        Pressure,
        PressureChangeRate,
        Ratio,
        RatioChangeRate,
        ReactiveEnergy,
        ReactivePower,
        ReciprocalArea,
        ReciprocalLength,
        RelativeHumidity,
        RotationalAcceleration,
        RotationalSpeed,
        RotationalStiffness,
        RotationalStiffnessPerLength,
        Scalar,
        SectionModulus,
        SolidAngle,
        SpecificEnergy,
        SpecificEntropy,
        SpecificFuelConsumption,
        SpecificVolume,
        SpecificWeight,
        Speed,
        StandardVolumeFlow,
        Strain,
        Temperature,
        TemperatureChangeRate,
        TemperatureDelta,
        TemperatureGradient,
        ThermalConductivity,
        ThermalResistance,
        Torque,
        TorquePerLength,
        Turbidity,
        VitaminA,
        Volume,
        VolumeConcentration,
        VolumeFlow,
        VolumeFlowPerArea,
        VolumePerLength,
        VolumetricHeatCapacity,
        WarpingMomentOfInertia,
    }
}

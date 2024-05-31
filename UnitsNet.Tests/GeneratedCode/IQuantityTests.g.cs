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
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests
{
    public partial class IQuantityTests
    {
        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            void Assertion(int expectedValue, Enum expectedUnit, IQuantity quantity)
            {
                Assert.Equal(expectedUnit, quantity.Unit);
                Assert.Equal(expectedValue, quantity.Value);
            }

            Assertion(3, AbsorbedDoseOfIonizingRadiationUnit.Teragray, Quantity.From(3, AbsorbedDoseOfIonizingRadiationUnit.Teragray));
            Assertion(3, AccelerationUnit.StandardGravity, Quantity.From(3, AccelerationUnit.StandardGravity));
            Assertion(3, AmountOfSubstanceUnit.PoundMole, Quantity.From(3, AmountOfSubstanceUnit.PoundMole));
            Assertion(3, AmplitudeRatioUnit.DecibelVolt, Quantity.From(3, AmplitudeRatioUnit.DecibelVolt));
            Assertion(3, AngleUnit.Tilt, Quantity.From(3, AngleUnit.Tilt));
            Assertion(3, ApparentEnergyUnit.VoltampereHour, Quantity.From(3, ApparentEnergyUnit.VoltampereHour));
            Assertion(3, ApparentPowerUnit.Voltampere, Quantity.From(3, ApparentPowerUnit.Voltampere));
            Assertion(3, AreaUnit.UsSurveySquareFoot, Quantity.From(3, AreaUnit.UsSurveySquareFoot));
            Assertion(3, AreaDensityUnit.MilligramPerSquareMeter, Quantity.From(3, AreaDensityUnit.MilligramPerSquareMeter));
            Assertion(3, AreaMomentOfInertiaUnit.MillimeterToTheFourth, Quantity.From(3, AreaMomentOfInertiaUnit.MillimeterToTheFourth));
            Assertion(3, BitRateUnit.TerabytePerSecond, Quantity.From(3, BitRateUnit.TerabytePerSecond));
            Assertion(3, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, Quantity.From(3, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour));
            Assertion(3, CapacitanceUnit.Picofarad, Quantity.From(3, CapacitanceUnit.Picofarad));
            Assertion(3, CoefficientOfThermalExpansionUnit.PpmPerKelvin, Quantity.From(3, CoefficientOfThermalExpansionUnit.PpmPerKelvin));
            Assertion(3, CompressibilityUnit.InversePoundForcePerSquareInch, Quantity.From(3, CompressibilityUnit.InversePoundForcePerSquareInch));
            Assertion(3, DensityUnit.TonnePerCubicMillimeter, Quantity.From(3, DensityUnit.TonnePerCubicMillimeter));
            Assertion(3, DurationUnit.Year365, Quantity.From(3, DurationUnit.Year365));
            Assertion(3, DynamicViscosityUnit.Reyn, Quantity.From(3, DynamicViscosityUnit.Reyn));
            Assertion(3, ElectricAdmittanceUnit.Siemens, Quantity.From(3, ElectricAdmittanceUnit.Siemens));
            Assertion(3, ElectricChargeUnit.Picocoulomb, Quantity.From(3, ElectricChargeUnit.Picocoulomb));
            Assertion(3, ElectricChargeDensityUnit.CoulombPerCubicMeter, Quantity.From(3, ElectricChargeDensityUnit.CoulombPerCubicMeter));
            Assertion(3, ElectricConductanceUnit.Siemens, Quantity.From(3, ElectricConductanceUnit.Siemens));
            Assertion(3, ElectricConductivityUnit.SiemensPerMeter, Quantity.From(3, ElectricConductivityUnit.SiemensPerMeter));
            Assertion(3, ElectricCurrentUnit.Picoampere, Quantity.From(3, ElectricCurrentUnit.Picoampere));
            Assertion(3, ElectricCurrentDensityUnit.AmperePerSquareMeter, Quantity.From(3, ElectricCurrentDensityUnit.AmperePerSquareMeter));
            Assertion(3, ElectricCurrentGradientUnit.MilliamperePerSecond, Quantity.From(3, ElectricCurrentGradientUnit.MilliamperePerSecond));
            Assertion(3, ElectricFieldUnit.VoltPerMeter, Quantity.From(3, ElectricFieldUnit.VoltPerMeter));
            Assertion(3, ElectricInductanceUnit.Picohenry, Quantity.From(3, ElectricInductanceUnit.Picohenry));
            Assertion(3, ElectricPotentialUnit.Volt, Quantity.From(3, ElectricPotentialUnit.Volt));
            Assertion(3, ElectricPotentialAcUnit.VoltAc, Quantity.From(3, ElectricPotentialAcUnit.VoltAc));
            Assertion(3, ElectricPotentialChangeRateUnit.VoltPerSecond, Quantity.From(3, ElectricPotentialChangeRateUnit.VoltPerSecond));
            Assertion(3, ElectricPotentialDcUnit.VoltDc, Quantity.From(3, ElectricPotentialDcUnit.VoltDc));
            Assertion(3, ElectricResistanceUnit.Teraohm, Quantity.From(3, ElectricResistanceUnit.Teraohm));
            Assertion(3, ElectricResistivityUnit.PicoohmMeter, Quantity.From(3, ElectricResistivityUnit.PicoohmMeter));
            Assertion(3, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, Quantity.From(3, ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter));
            Assertion(3, EnergyUnit.WattHour, Quantity.From(3, EnergyUnit.WattHour));
            Assertion(3, EnergyDensityUnit.WattHourPerCubicMeter, Quantity.From(3, EnergyDensityUnit.WattHourPerCubicMeter));
            Assertion(3, EntropyUnit.MegajoulePerKelvin, Quantity.From(3, EntropyUnit.MegajoulePerKelvin));
            Assertion(3, ForceUnit.TonneForce, Quantity.From(3, ForceUnit.TonneForce));
            Assertion(3, ForceChangeRateUnit.PoundForcePerSecond, Quantity.From(3, ForceChangeRateUnit.PoundForcePerSecond));
            Assertion(3, ForcePerLengthUnit.TonneForcePerMillimeter, Quantity.From(3, ForcePerLengthUnit.TonneForcePerMillimeter));
            Assertion(3, FrequencyUnit.Terahertz, Quantity.From(3, FrequencyUnit.Terahertz));
            Assertion(3, FuelEfficiencyUnit.MilePerUsGallon, Quantity.From(3, FuelEfficiencyUnit.MilePerUsGallon));
            Assertion(3, HeatFluxUnit.WattPerSquareMeter, Quantity.From(3, HeatFluxUnit.WattPerSquareMeter));
            Assertion(3, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin, Quantity.From(3, HeatTransferCoefficientUnit.WattPerSquareMeterKelvin));
            Assertion(3, IlluminanceUnit.Millilux, Quantity.From(3, IlluminanceUnit.Millilux));
            Assertion(3, ImpulseUnit.SlugFootPerSecond, Quantity.From(3, ImpulseUnit.SlugFootPerSecond));
            Assertion(3, InformationUnit.Terabyte, Quantity.From(3, InformationUnit.Terabyte));
            Assertion(3, IrradianceUnit.WattPerSquareMeter, Quantity.From(3, IrradianceUnit.WattPerSquareMeter));
            Assertion(3, IrradiationUnit.WattHourPerSquareMeter, Quantity.From(3, IrradiationUnit.WattHourPerSquareMeter));
            Assertion(3, JerkUnit.StandardGravitiesPerSecond, Quantity.From(3, JerkUnit.StandardGravitiesPerSecond));
            Assertion(3, KinematicViscosityUnit.Stokes, Quantity.From(3, KinematicViscosityUnit.Stokes));
            Assertion(3, LeakRateUnit.TorrLiterPerSecond, Quantity.From(3, LeakRateUnit.TorrLiterPerSecond));
            Assertion(3, LengthUnit.Yard, Quantity.From(3, LengthUnit.Yard));
            Assertion(3, LevelUnit.Neper, Quantity.From(3, LevelUnit.Neper));
            Assertion(3, LevelToCarrierUnit.DecibelCarrier, Quantity.From(3, LevelToCarrierUnit.DecibelCarrier));
            Assertion(3, LinearDensityUnit.PoundPerInch, Quantity.From(3, LinearDensityUnit.PoundPerInch));
            Assertion(3, LinearPowerDensityUnit.WattPerMillimeter, Quantity.From(3, LinearPowerDensityUnit.WattPerMillimeter));
            Assertion(3, LuminanceUnit.Nit, Quantity.From(3, LuminanceUnit.Nit));
            Assertion(3, LuminosityUnit.Watt, Quantity.From(3, LuminosityUnit.Watt));
            Assertion(3, LuminousFluxUnit.Lumen, Quantity.From(3, LuminousFluxUnit.Lumen));
            Assertion(3, LuminousIntensityUnit.Candela, Quantity.From(3, LuminousIntensityUnit.Candela));
            Assertion(3, MagneticFieldUnit.Tesla, Quantity.From(3, MagneticFieldUnit.Tesla));
            Assertion(3, MagneticFluxUnit.Weber, Quantity.From(3, MagneticFluxUnit.Weber));
            Assertion(3, MagnetizationUnit.AmperePerMeter, Quantity.From(3, MagnetizationUnit.AmperePerMeter));
            Assertion(3, MassUnit.Tonne, Quantity.From(3, MassUnit.Tonne));
            Assertion(3, MassConcentrationUnit.TonnePerCubicMillimeter, Quantity.From(3, MassConcentrationUnit.TonnePerCubicMillimeter));
            Assertion(3, MassFlowUnit.TonnePerHour, Quantity.From(3, MassFlowUnit.TonnePerHour));
            Assertion(3, MassFluxUnit.KilogramPerSecondPerSquareMillimeter, Quantity.From(3, MassFluxUnit.KilogramPerSecondPerSquareMillimeter));
            Assertion(3, MassFractionUnit.Percent, Quantity.From(3, MassFractionUnit.Percent));
            Assertion(3, MassMomentOfInertiaUnit.TonneSquareMilimeter, Quantity.From(3, MassMomentOfInertiaUnit.TonneSquareMilimeter));
            Assertion(3, MolalityUnit.MolePerKilogram, Quantity.From(3, MolalityUnit.MolePerKilogram));
            Assertion(3, MolarEnergyUnit.MegajoulePerMole, Quantity.From(3, MolarEnergyUnit.MegajoulePerMole));
            Assertion(3, MolarEntropyUnit.MegajoulePerMoleKelvin, Quantity.From(3, MolarEntropyUnit.MegajoulePerMoleKelvin));
            Assertion(3, MolarFlowUnit.PoundMolePerSecond, Quantity.From(3, MolarFlowUnit.PoundMolePerSecond));
            Assertion(3, MolarityUnit.PoundMolePerCubicFoot, Quantity.From(3, MolarityUnit.PoundMolePerCubicFoot));
            Assertion(3, MolarMassUnit.PoundPerMole, Quantity.From(3, MolarMassUnit.PoundPerMole));
            Assertion(3, PermeabilityUnit.HenryPerMeter, Quantity.From(3, PermeabilityUnit.HenryPerMeter));
            Assertion(3, PermittivityUnit.FaradPerMeter, Quantity.From(3, PermittivityUnit.FaradPerMeter));
            Assertion(3, PorousMediumPermeabilityUnit.SquareMeter, Quantity.From(3, PorousMediumPermeabilityUnit.SquareMeter));
            Assertion(3, PowerUnit.Watt, Quantity.From(3, PowerUnit.Watt));
            Assertion(3, PowerDensityUnit.WattPerLiter, Quantity.From(3, PowerDensityUnit.WattPerLiter));
            Assertion(3, PowerRatioUnit.DecibelWatt, Quantity.From(3, PowerRatioUnit.DecibelWatt));
            Assertion(3, PressureUnit.Torr, Quantity.From(3, PressureUnit.Torr));
            Assertion(3, PressureChangeRateUnit.PoundForcePerSquareInchPerSecond, Quantity.From(3, PressureChangeRateUnit.PoundForcePerSquareInchPerSecond));
            Assertion(3, RadiationEquivalentDoseUnit.Sievert, Quantity.From(3, RadiationEquivalentDoseUnit.Sievert));
            Assertion(3, RadiationExposureUnit.Roentgen, Quantity.From(3, RadiationExposureUnit.Roentgen));
            Assertion(3, RadioactivityUnit.Terarutherford, Quantity.From(3, RadioactivityUnit.Terarutherford));
            Assertion(3, RatioUnit.Percent, Quantity.From(3, RatioUnit.Percent));
            Assertion(3, RatioChangeRateUnit.PercentPerSecond, Quantity.From(3, RatioChangeRateUnit.PercentPerSecond));
            Assertion(3, ReactiveEnergyUnit.VoltampereReactiveHour, Quantity.From(3, ReactiveEnergyUnit.VoltampereReactiveHour));
            Assertion(3, ReactivePowerUnit.VoltampereReactive, Quantity.From(3, ReactivePowerUnit.VoltampereReactive));
            Assertion(3, ReciprocalAreaUnit.InverseUsSurveySquareFoot, Quantity.From(3, ReciprocalAreaUnit.InverseUsSurveySquareFoot));
            Assertion(3, ReciprocalLengthUnit.InverseYard, Quantity.From(3, ReciprocalLengthUnit.InverseYard));
            Assertion(3, RelativeHumidityUnit.Percent, Quantity.From(3, RelativeHumidityUnit.Percent));
            Assertion(3, RotationalAccelerationUnit.RevolutionPerSecondSquared, Quantity.From(3, RotationalAccelerationUnit.RevolutionPerSecondSquared));
            Assertion(3, RotationalSpeedUnit.RevolutionPerSecond, Quantity.From(3, RotationalSpeedUnit.RevolutionPerSecond));
            Assertion(3, RotationalStiffnessUnit.PoundForceFootPerDegrees, Quantity.From(3, RotationalStiffnessUnit.PoundForceFootPerDegrees));
            Assertion(3, RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot, Quantity.From(3, RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot));
            Assertion(3, ScalarUnit.Amount, Quantity.From(3, ScalarUnit.Amount));
            Assertion(3, SolidAngleUnit.Steradian, Quantity.From(3, SolidAngleUnit.Steradian));
            Assertion(3, SpecificEnergyUnit.WattHourPerPound, Quantity.From(3, SpecificEnergyUnit.WattHourPerPound));
            Assertion(3, SpecificEntropyUnit.MegajoulePerKilogramKelvin, Quantity.From(3, SpecificEntropyUnit.MegajoulePerKilogramKelvin));
            Assertion(3, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, Quantity.From(3, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour));
            Assertion(3, SpecificVolumeUnit.MillicubicMeterPerKilogram, Quantity.From(3, SpecificVolumeUnit.MillicubicMeterPerKilogram));
            Assertion(3, SpecificWeightUnit.TonneForcePerCubicMillimeter, Quantity.From(3, SpecificWeightUnit.TonneForcePerCubicMillimeter));
            Assertion(3, SpeedUnit.YardPerSecond, Quantity.From(3, SpeedUnit.YardPerSecond));
            Assertion(3, StandardVolumeFlowUnit.StandardLiterPerMinute, Quantity.From(3, StandardVolumeFlowUnit.StandardLiterPerMinute));
            Assertion(3, TemperatureUnit.SolarTemperature, Quantity.From(3, TemperatureUnit.SolarTemperature));
            Assertion(3, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond, Quantity.From(3, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond));
            Assertion(3, TemperatureDeltaUnit.MillidegreeCelsius, Quantity.From(3, TemperatureDeltaUnit.MillidegreeCelsius));
            Assertion(3, TemperatureGradientUnit.KelvinPerMeter, Quantity.From(3, TemperatureGradientUnit.KelvinPerMeter));
            Assertion(3, ThermalConductivityUnit.WattPerMeterKelvin, Quantity.From(3, ThermalConductivityUnit.WattPerMeterKelvin));
            Assertion(3, ThermalResistanceUnit.SquareMeterKelvinPerWatt, Quantity.From(3, ThermalResistanceUnit.SquareMeterKelvinPerWatt));
            Assertion(3, TorqueUnit.TonneForceMillimeter, Quantity.From(3, TorqueUnit.TonneForceMillimeter));
            Assertion(3, TorquePerLengthUnit.TonneForceMillimeterPerMeter, Quantity.From(3, TorquePerLengthUnit.TonneForceMillimeterPerMeter));
            Assertion(3, TurbidityUnit.NTU, Quantity.From(3, TurbidityUnit.NTU));
            Assertion(3, VitaminAUnit.InternationalUnit, Quantity.From(3, VitaminAUnit.InternationalUnit));
            Assertion(3, VolumeUnit.UsTeaspoon, Quantity.From(3, VolumeUnit.UsTeaspoon));
            Assertion(3, VolumeConcentrationUnit.PicolitersPerMililiter, Quantity.From(3, VolumeConcentrationUnit.PicolitersPerMililiter));
            Assertion(3, VolumeFlowUnit.UsGallonPerSecond, Quantity.From(3, VolumeFlowUnit.UsGallonPerSecond));
            Assertion(3, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, Quantity.From(3, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter));
            Assertion(3, VolumePerLengthUnit.UsGallonPerMile, Quantity.From(3, VolumePerLengthUnit.UsGallonPerMile));
            Assertion(3, VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin, Quantity.From(3, VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin));
            Assertion(3, WarpingMomentOfInertiaUnit.MillimeterToTheSixth, Quantity.From(3, WarpingMomentOfInertiaUnit.MillimeterToTheSixth));
        }

        [Fact]
        public void QuantityInfo_IsSameAsStaticInfoProperty()
        {
            void Assertion(QuantityInfo expected, IQuantity quantity) => Assert.Same(expected, quantity.QuantityInfo);

            Assertion(AbsorbedDoseOfIonizingRadiation.Info, AbsorbedDoseOfIonizingRadiation.Zero);
            Assertion(Acceleration.Info, Acceleration.Zero);
            Assertion(AmountOfSubstance.Info, AmountOfSubstance.Zero);
            Assertion(AmplitudeRatio.Info, AmplitudeRatio.Zero);
            Assertion(Angle.Info, Angle.Zero);
            Assertion(ApparentEnergy.Info, ApparentEnergy.Zero);
            Assertion(ApparentPower.Info, ApparentPower.Zero);
            Assertion(Area.Info, Area.Zero);
            Assertion(AreaDensity.Info, AreaDensity.Zero);
            Assertion(AreaMomentOfInertia.Info, AreaMomentOfInertia.Zero);
            Assertion(BitRate.Info, BitRate.Zero);
            Assertion(BrakeSpecificFuelConsumption.Info, BrakeSpecificFuelConsumption.Zero);
            Assertion(Capacitance.Info, Capacitance.Zero);
            Assertion(CoefficientOfThermalExpansion.Info, CoefficientOfThermalExpansion.Zero);
            Assertion(Compressibility.Info, Compressibility.Zero);
            Assertion(Density.Info, Density.Zero);
            Assertion(Duration.Info, Duration.Zero);
            Assertion(DynamicViscosity.Info, DynamicViscosity.Zero);
            Assertion(ElectricAdmittance.Info, ElectricAdmittance.Zero);
            Assertion(ElectricCharge.Info, ElectricCharge.Zero);
            Assertion(ElectricChargeDensity.Info, ElectricChargeDensity.Zero);
            Assertion(ElectricConductance.Info, ElectricConductance.Zero);
            Assertion(ElectricConductivity.Info, ElectricConductivity.Zero);
            Assertion(ElectricCurrent.Info, ElectricCurrent.Zero);
            Assertion(ElectricCurrentDensity.Info, ElectricCurrentDensity.Zero);
            Assertion(ElectricCurrentGradient.Info, ElectricCurrentGradient.Zero);
            Assertion(ElectricField.Info, ElectricField.Zero);
            Assertion(ElectricInductance.Info, ElectricInductance.Zero);
            Assertion(ElectricPotential.Info, ElectricPotential.Zero);
            Assertion(ElectricPotentialAc.Info, ElectricPotentialAc.Zero);
            Assertion(ElectricPotentialChangeRate.Info, ElectricPotentialChangeRate.Zero);
            Assertion(ElectricPotentialDc.Info, ElectricPotentialDc.Zero);
            Assertion(ElectricResistance.Info, ElectricResistance.Zero);
            Assertion(ElectricResistivity.Info, ElectricResistivity.Zero);
            Assertion(ElectricSurfaceChargeDensity.Info, ElectricSurfaceChargeDensity.Zero);
            Assertion(Energy.Info, Energy.Zero);
            Assertion(EnergyDensity.Info, EnergyDensity.Zero);
            Assertion(Entropy.Info, Entropy.Zero);
            Assertion(Force.Info, Force.Zero);
            Assertion(ForceChangeRate.Info, ForceChangeRate.Zero);
            Assertion(ForcePerLength.Info, ForcePerLength.Zero);
            Assertion(Frequency.Info, Frequency.Zero);
            Assertion(FuelEfficiency.Info, FuelEfficiency.Zero);
            Assertion(HeatFlux.Info, HeatFlux.Zero);
            Assertion(HeatTransferCoefficient.Info, HeatTransferCoefficient.Zero);
            Assertion(Illuminance.Info, Illuminance.Zero);
            Assertion(Impulse.Info, Impulse.Zero);
            Assertion(Information.Info, Information.Zero);
            Assertion(Irradiance.Info, Irradiance.Zero);
            Assertion(Irradiation.Info, Irradiation.Zero);
            Assertion(Jerk.Info, Jerk.Zero);
            Assertion(KinematicViscosity.Info, KinematicViscosity.Zero);
            Assertion(LeakRate.Info, LeakRate.Zero);
            Assertion(Length.Info, Length.Zero);
            Assertion(Level.Info, Level.Zero);
            Assertion(LevelToCarrier.Info, LevelToCarrier.Zero);
            Assertion(LinearDensity.Info, LinearDensity.Zero);
            Assertion(LinearPowerDensity.Info, LinearPowerDensity.Zero);
            Assertion(Luminance.Info, Luminance.Zero);
            Assertion(Luminosity.Info, Luminosity.Zero);
            Assertion(LuminousFlux.Info, LuminousFlux.Zero);
            Assertion(LuminousIntensity.Info, LuminousIntensity.Zero);
            Assertion(MagneticField.Info, MagneticField.Zero);
            Assertion(MagneticFlux.Info, MagneticFlux.Zero);
            Assertion(Magnetization.Info, Magnetization.Zero);
            Assertion(Mass.Info, Mass.Zero);
            Assertion(MassConcentration.Info, MassConcentration.Zero);
            Assertion(MassFlow.Info, MassFlow.Zero);
            Assertion(MassFlux.Info, MassFlux.Zero);
            Assertion(MassFraction.Info, MassFraction.Zero);
            Assertion(MassMomentOfInertia.Info, MassMomentOfInertia.Zero);
            Assertion(Molality.Info, Molality.Zero);
            Assertion(MolarEnergy.Info, MolarEnergy.Zero);
            Assertion(MolarEntropy.Info, MolarEntropy.Zero);
            Assertion(MolarFlow.Info, MolarFlow.Zero);
            Assertion(Molarity.Info, Molarity.Zero);
            Assertion(MolarMass.Info, MolarMass.Zero);
            Assertion(Permeability.Info, Permeability.Zero);
            Assertion(Permittivity.Info, Permittivity.Zero);
            Assertion(PorousMediumPermeability.Info, PorousMediumPermeability.Zero);
            Assertion(Power.Info, Power.Zero);
            Assertion(PowerDensity.Info, PowerDensity.Zero);
            Assertion(PowerRatio.Info, PowerRatio.Zero);
            Assertion(Pressure.Info, Pressure.Zero);
            Assertion(PressureChangeRate.Info, PressureChangeRate.Zero);
            Assertion(RadiationEquivalentDose.Info, RadiationEquivalentDose.Zero);
            Assertion(RadiationExposure.Info, RadiationExposure.Zero);
            Assertion(Radioactivity.Info, Radioactivity.Zero);
            Assertion(Ratio.Info, Ratio.Zero);
            Assertion(RatioChangeRate.Info, RatioChangeRate.Zero);
            Assertion(ReactiveEnergy.Info, ReactiveEnergy.Zero);
            Assertion(ReactivePower.Info, ReactivePower.Zero);
            Assertion(ReciprocalArea.Info, ReciprocalArea.Zero);
            Assertion(ReciprocalLength.Info, ReciprocalLength.Zero);
            Assertion(RelativeHumidity.Info, RelativeHumidity.Zero);
            Assertion(RotationalAcceleration.Info, RotationalAcceleration.Zero);
            Assertion(RotationalSpeed.Info, RotationalSpeed.Zero);
            Assertion(RotationalStiffness.Info, RotationalStiffness.Zero);
            Assertion(RotationalStiffnessPerLength.Info, RotationalStiffnessPerLength.Zero);
            Assertion(Scalar.Info, Scalar.Zero);
            Assertion(SolidAngle.Info, SolidAngle.Zero);
            Assertion(SpecificEnergy.Info, SpecificEnergy.Zero);
            Assertion(SpecificEntropy.Info, SpecificEntropy.Zero);
            Assertion(SpecificFuelConsumption.Info, SpecificFuelConsumption.Zero);
            Assertion(SpecificVolume.Info, SpecificVolume.Zero);
            Assertion(SpecificWeight.Info, SpecificWeight.Zero);
            Assertion(Speed.Info, Speed.Zero);
            Assertion(StandardVolumeFlow.Info, StandardVolumeFlow.Zero);
            Assertion(Temperature.Info, Temperature.Zero);
            Assertion(TemperatureChangeRate.Info, TemperatureChangeRate.Zero);
            Assertion(TemperatureDelta.Info, TemperatureDelta.Zero);
            Assertion(TemperatureGradient.Info, TemperatureGradient.Zero);
            Assertion(ThermalConductivity.Info, ThermalConductivity.Zero);
            Assertion(ThermalResistance.Info, ThermalResistance.Zero);
            Assertion(Torque.Info, Torque.Zero);
            Assertion(TorquePerLength.Info, TorquePerLength.Zero);
            Assertion(Turbidity.Info, Turbidity.Zero);
            Assertion(VitaminA.Info, VitaminA.Zero);
            Assertion(Volume.Info, Volume.Zero);
            Assertion(VolumeConcentration.Info, VolumeConcentration.Zero);
            Assertion(VolumeFlow.Info, VolumeFlow.Zero);
            Assertion(VolumeFlowPerArea.Info, VolumeFlowPerArea.Zero);
            Assertion(VolumePerLength.Info, VolumePerLength.Zero);
            Assertion(VolumetricHeatCapacity.Info, VolumetricHeatCapacity.Zero);
            Assertion(WarpingMomentOfInertia.Info, WarpingMomentOfInertia.Zero);
        }

        [Fact]
        public void Dimensions_IsSameAsStaticBaseDimensions()
        {
            void Assertion(BaseDimensions expected, IQuantity quantity) => Assert.Equal(expected, quantity.Dimensions);

            Assertion(AbsorbedDoseOfIonizingRadiation.BaseDimensions, AbsorbedDoseOfIonizingRadiation.Zero);
            Assertion(Acceleration.BaseDimensions, Acceleration.Zero);
            Assertion(AmountOfSubstance.BaseDimensions, AmountOfSubstance.Zero);
            Assertion(AmplitudeRatio.BaseDimensions, AmplitudeRatio.Zero);
            Assertion(Angle.BaseDimensions, Angle.Zero);
            Assertion(ApparentEnergy.BaseDimensions, ApparentEnergy.Zero);
            Assertion(ApparentPower.BaseDimensions, ApparentPower.Zero);
            Assertion(Area.BaseDimensions, Area.Zero);
            Assertion(AreaDensity.BaseDimensions, AreaDensity.Zero);
            Assertion(AreaMomentOfInertia.BaseDimensions, AreaMomentOfInertia.Zero);
            Assertion(BitRate.BaseDimensions, BitRate.Zero);
            Assertion(BrakeSpecificFuelConsumption.BaseDimensions, BrakeSpecificFuelConsumption.Zero);
            Assertion(Capacitance.BaseDimensions, Capacitance.Zero);
            Assertion(CoefficientOfThermalExpansion.BaseDimensions, CoefficientOfThermalExpansion.Zero);
            Assertion(Compressibility.BaseDimensions, Compressibility.Zero);
            Assertion(Density.BaseDimensions, Density.Zero);
            Assertion(Duration.BaseDimensions, Duration.Zero);
            Assertion(DynamicViscosity.BaseDimensions, DynamicViscosity.Zero);
            Assertion(ElectricAdmittance.BaseDimensions, ElectricAdmittance.Zero);
            Assertion(ElectricCharge.BaseDimensions, ElectricCharge.Zero);
            Assertion(ElectricChargeDensity.BaseDimensions, ElectricChargeDensity.Zero);
            Assertion(ElectricConductance.BaseDimensions, ElectricConductance.Zero);
            Assertion(ElectricConductivity.BaseDimensions, ElectricConductivity.Zero);
            Assertion(ElectricCurrent.BaseDimensions, ElectricCurrent.Zero);
            Assertion(ElectricCurrentDensity.BaseDimensions, ElectricCurrentDensity.Zero);
            Assertion(ElectricCurrentGradient.BaseDimensions, ElectricCurrentGradient.Zero);
            Assertion(ElectricField.BaseDimensions, ElectricField.Zero);
            Assertion(ElectricInductance.BaseDimensions, ElectricInductance.Zero);
            Assertion(ElectricPotential.BaseDimensions, ElectricPotential.Zero);
            Assertion(ElectricPotentialAc.BaseDimensions, ElectricPotentialAc.Zero);
            Assertion(ElectricPotentialChangeRate.BaseDimensions, ElectricPotentialChangeRate.Zero);
            Assertion(ElectricPotentialDc.BaseDimensions, ElectricPotentialDc.Zero);
            Assertion(ElectricResistance.BaseDimensions, ElectricResistance.Zero);
            Assertion(ElectricResistivity.BaseDimensions, ElectricResistivity.Zero);
            Assertion(ElectricSurfaceChargeDensity.BaseDimensions, ElectricSurfaceChargeDensity.Zero);
            Assertion(Energy.BaseDimensions, Energy.Zero);
            Assertion(EnergyDensity.BaseDimensions, EnergyDensity.Zero);
            Assertion(Entropy.BaseDimensions, Entropy.Zero);
            Assertion(Force.BaseDimensions, Force.Zero);
            Assertion(ForceChangeRate.BaseDimensions, ForceChangeRate.Zero);
            Assertion(ForcePerLength.BaseDimensions, ForcePerLength.Zero);
            Assertion(Frequency.BaseDimensions, Frequency.Zero);
            Assertion(FuelEfficiency.BaseDimensions, FuelEfficiency.Zero);
            Assertion(HeatFlux.BaseDimensions, HeatFlux.Zero);
            Assertion(HeatTransferCoefficient.BaseDimensions, HeatTransferCoefficient.Zero);
            Assertion(Illuminance.BaseDimensions, Illuminance.Zero);
            Assertion(Impulse.BaseDimensions, Impulse.Zero);
            Assertion(Information.BaseDimensions, Information.Zero);
            Assertion(Irradiance.BaseDimensions, Irradiance.Zero);
            Assertion(Irradiation.BaseDimensions, Irradiation.Zero);
            Assertion(Jerk.BaseDimensions, Jerk.Zero);
            Assertion(KinematicViscosity.BaseDimensions, KinematicViscosity.Zero);
            Assertion(LeakRate.BaseDimensions, LeakRate.Zero);
            Assertion(Length.BaseDimensions, Length.Zero);
            Assertion(Level.BaseDimensions, Level.Zero);
            Assertion(LevelToCarrier.BaseDimensions, LevelToCarrier.Zero);
            Assertion(LinearDensity.BaseDimensions, LinearDensity.Zero);
            Assertion(LinearPowerDensity.BaseDimensions, LinearPowerDensity.Zero);
            Assertion(Luminance.BaseDimensions, Luminance.Zero);
            Assertion(Luminosity.BaseDimensions, Luminosity.Zero);
            Assertion(LuminousFlux.BaseDimensions, LuminousFlux.Zero);
            Assertion(LuminousIntensity.BaseDimensions, LuminousIntensity.Zero);
            Assertion(MagneticField.BaseDimensions, MagneticField.Zero);
            Assertion(MagneticFlux.BaseDimensions, MagneticFlux.Zero);
            Assertion(Magnetization.BaseDimensions, Magnetization.Zero);
            Assertion(Mass.BaseDimensions, Mass.Zero);
            Assertion(MassConcentration.BaseDimensions, MassConcentration.Zero);
            Assertion(MassFlow.BaseDimensions, MassFlow.Zero);
            Assertion(MassFlux.BaseDimensions, MassFlux.Zero);
            Assertion(MassFraction.BaseDimensions, MassFraction.Zero);
            Assertion(MassMomentOfInertia.BaseDimensions, MassMomentOfInertia.Zero);
            Assertion(Molality.BaseDimensions, Molality.Zero);
            Assertion(MolarEnergy.BaseDimensions, MolarEnergy.Zero);
            Assertion(MolarEntropy.BaseDimensions, MolarEntropy.Zero);
            Assertion(MolarFlow.BaseDimensions, MolarFlow.Zero);
            Assertion(Molarity.BaseDimensions, Molarity.Zero);
            Assertion(MolarMass.BaseDimensions, MolarMass.Zero);
            Assertion(Permeability.BaseDimensions, Permeability.Zero);
            Assertion(Permittivity.BaseDimensions, Permittivity.Zero);
            Assertion(PorousMediumPermeability.BaseDimensions, PorousMediumPermeability.Zero);
            Assertion(Power.BaseDimensions, Power.Zero);
            Assertion(PowerDensity.BaseDimensions, PowerDensity.Zero);
            Assertion(PowerRatio.BaseDimensions, PowerRatio.Zero);
            Assertion(Pressure.BaseDimensions, Pressure.Zero);
            Assertion(PressureChangeRate.BaseDimensions, PressureChangeRate.Zero);
            Assertion(RadiationEquivalentDose.BaseDimensions, RadiationEquivalentDose.Zero);
            Assertion(RadiationExposure.BaseDimensions, RadiationExposure.Zero);
            Assertion(Radioactivity.BaseDimensions, Radioactivity.Zero);
            Assertion(Ratio.BaseDimensions, Ratio.Zero);
            Assertion(RatioChangeRate.BaseDimensions, RatioChangeRate.Zero);
            Assertion(ReactiveEnergy.BaseDimensions, ReactiveEnergy.Zero);
            Assertion(ReactivePower.BaseDimensions, ReactivePower.Zero);
            Assertion(ReciprocalArea.BaseDimensions, ReciprocalArea.Zero);
            Assertion(ReciprocalLength.BaseDimensions, ReciprocalLength.Zero);
            Assertion(RelativeHumidity.BaseDimensions, RelativeHumidity.Zero);
            Assertion(RotationalAcceleration.BaseDimensions, RotationalAcceleration.Zero);
            Assertion(RotationalSpeed.BaseDimensions, RotationalSpeed.Zero);
            Assertion(RotationalStiffness.BaseDimensions, RotationalStiffness.Zero);
            Assertion(RotationalStiffnessPerLength.BaseDimensions, RotationalStiffnessPerLength.Zero);
            Assertion(Scalar.BaseDimensions, Scalar.Zero);
            Assertion(SolidAngle.BaseDimensions, SolidAngle.Zero);
            Assertion(SpecificEnergy.BaseDimensions, SpecificEnergy.Zero);
            Assertion(SpecificEntropy.BaseDimensions, SpecificEntropy.Zero);
            Assertion(SpecificFuelConsumption.BaseDimensions, SpecificFuelConsumption.Zero);
            Assertion(SpecificVolume.BaseDimensions, SpecificVolume.Zero);
            Assertion(SpecificWeight.BaseDimensions, SpecificWeight.Zero);
            Assertion(Speed.BaseDimensions, Speed.Zero);
            Assertion(StandardVolumeFlow.BaseDimensions, StandardVolumeFlow.Zero);
            Assertion(Temperature.BaseDimensions, Temperature.Zero);
            Assertion(TemperatureChangeRate.BaseDimensions, TemperatureChangeRate.Zero);
            Assertion(TemperatureDelta.BaseDimensions, TemperatureDelta.Zero);
            Assertion(TemperatureGradient.BaseDimensions, TemperatureGradient.Zero);
            Assertion(ThermalConductivity.BaseDimensions, ThermalConductivity.Zero);
            Assertion(ThermalResistance.BaseDimensions, ThermalResistance.Zero);
            Assertion(Torque.BaseDimensions, Torque.Zero);
            Assertion(TorquePerLength.BaseDimensions, TorquePerLength.Zero);
            Assertion(Turbidity.BaseDimensions, Turbidity.Zero);
            Assertion(VitaminA.BaseDimensions, VitaminA.Zero);
            Assertion(Volume.BaseDimensions, Volume.Zero);
            Assertion(VolumeConcentration.BaseDimensions, VolumeConcentration.Zero);
            Assertion(VolumeFlow.BaseDimensions, VolumeFlow.Zero);
            Assertion(VolumeFlowPerArea.BaseDimensions, VolumeFlowPerArea.Zero);
            Assertion(VolumePerLength.BaseDimensions, VolumePerLength.Zero);
            Assertion(VolumetricHeatCapacity.BaseDimensions, VolumetricHeatCapacity.Zero);
            Assertion(WarpingMomentOfInertia.BaseDimensions, WarpingMomentOfInertia.Zero);
        }
    }
}

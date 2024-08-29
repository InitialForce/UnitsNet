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

namespace UnitsNet.Tests.CustomCode
{
    public class EnergyEfficiencyTests : EnergyEfficiencyTestsBase
    {
        protected override bool SupportsSIUnitSystem => true;
        protected override double FemtowattHoursPerKilometerInOneWattHourPerKilometer => 1e15;
        protected override double FemtowattHoursPerMeterInOneWattHourPerKilometer  => 1e12;
        protected override double GigawattHoursPerKilometerInOneWattHourPerKilometer  => 1e-9;
        protected override double GigawattHoursPerMeterInOneWattHourPerKilometer  => 1e-12;
        protected override double KilowattHoursPerKilometerInOneWattHourPerKilometer  => 1e-3;
        protected override double KilowattHoursPerMeterInOneWattHourPerKilometer  => 1e-6;
        protected override double MegawattHoursPerKilometerInOneWattHourPerKilometer  => 1e-6;
        protected override double MegawattHoursPerMeterInOneWattHourPerKilometer  => 1e-9;
        protected override double MicrowattHoursPerKilometerInOneWattHourPerKilometer  => 1e6;
        protected override double MicrowattHoursPerMeterInOneWattHourPerKilometer  => 1e3;
        protected override double MilliwattHoursPerKilometerInOneWattHourPerKilometer  => 1e3;
        protected override double MilliwattHoursPerMeterInOneWattHourPerKilometer  => 1;
        protected override double NanowattHoursPerKilometerInOneWattHourPerKilometer  => 1e9;
        protected override double NanowattHoursPerMeterInOneWattHourPerKilometer  => 1e6;
        protected override double PicowattHoursPerKilometerInOneWattHourPerKilometer => 1e12;
        protected override double PicowattHoursPerMeterInOneWattHourPerKilometer  => 1e9;
        protected override double WattHoursPerKilometerInOneWattHourPerKilometer  => 1;
        protected override double WattHoursPerMeterInOneWattHourPerKilometer  => 1e-3;
    }
}

﻿//------------------------------------------------------------------------------
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

namespace OasysUnitsNet.Tests.CustomCode
{
    public class LuminosityTests : LuminosityTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;
        protected override double FemtowattsInOneWatt => 1e15;

        protected override double PicowattsInOneWatt => 1e12;

        protected override double NanowattsInOneWatt => 1e9;

        protected override double MicrowattsInOneWatt => 1e6;

        protected override double MilliwattsInOneWatt => 1e3;

        protected override double DeciwattsInOneWatt => 1e1;

        protected override double WattsInOneWatt => 1;

        protected override double DecawattsInOneWatt => 1e-1;

        protected override double KilowattsInOneWatt => 1e-3;

        protected override double MegawattsInOneWatt => 1e-6;

        protected override double GigawattsInOneWatt => 1e-9;

        protected override double TerawattsInOneWatt => 1e-12;

        protected override double PetawattsInOneWatt => 1e-15;

        protected override double SolarLuminositiesInOneWatt => 2.6001040041601700000000000E-27;

    }
}

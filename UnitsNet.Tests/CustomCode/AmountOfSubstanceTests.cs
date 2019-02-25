﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

namespace UnitsNet.Tests.CustomCode
{
    public class AmountOfSubstanceTests : AmountOfSubstanceTestsBase
    {
        protected override double CentimolesInOneMole => 1e2;
        protected override double CentipoundMolesInOneMole => 0.002204622621848776 * 1e2;
        protected override double DecimolesInOneMole => 1e1;
        protected override double DecipoundMolesInOneMole => 0.002204622621848776 * 1e1;
        protected override double KilomolesInOneMole => 1e-3;
        protected override double KilopoundMolesInOneMole => 0.002204622621848776 * 1e-3;
        protected override double MicromolesInOneMole => 1e6;
        protected override double MicropoundMolesInOneMole => 0.002204622621848776 * 1e6;
        protected override double MillimolesInOneMole => 1e3;
        protected override double MillipoundMolesInOneMole => 0.002204622621848776 * 1e3;
        protected override double MolesInOneMole => 1;
        protected override double NanomolesInOneMole => 1e9;
        protected override double NanopoundMolesInOneMole => 0.002204622621848776 * 1e9;
        protected override double PoundMolesInOneMole => 0.002204622621848776;
        protected override double MegamolesInOneMole => 1e-6;
    }
}

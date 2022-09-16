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
    public class StrainTests : StrainTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;

        protected override double MicroStrainInOneRatio => 1e6;

        protected override double MilliStrainInOneRatio => 1e3;

        protected override double PercentInOneRatio => 1e2;

        protected override double RatioInOneRatio => 1;
    }
}

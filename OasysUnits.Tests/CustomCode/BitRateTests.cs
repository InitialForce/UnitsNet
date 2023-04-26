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

namespace OasysUnits.Tests.CustomCode
{
    public class BitRateTests : BitRateTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;

        protected override decimal BitsPerSecondInOneBitPerSecond => 1m;
        protected override decimal BytesPerSecondInOneBitPerSecond => 1.25E-1m;

        protected override decimal KilobitsPerSecondInOneBitPerSecond => 1E-3m;
        protected override decimal KilobytesPerSecondInOneBitPerSecond => 1.25E-4m;
        protected override decimal KibibitsPerSecondInOneBitPerSecond => 0.0009765625m;
        protected override decimal KibibytesPerSecondInOneBitPerSecond => 0.0001220703125m;

        protected override decimal MegabitsPerSecondInOneBitPerSecond => 1E-6m;
        protected override decimal MegabytesPerSecondInOneBitPerSecond => 1.25E-07m;
        protected override decimal MebibitsPerSecondInOneBitPerSecond => 9.5367431640625E-07m;
        protected override decimal MebibytesPerSecondInOneBitPerSecond => 1.19209289550781E-07m;

        protected override decimal GigabitsPerSecondInOneBitPerSecond => 1E-9m;
        protected override decimal GigabytesPerSecondInOneBitPerSecond => 1.25E-10m;
        protected override decimal GibibitsPerSecondInOneBitPerSecond => 9.31322574615479E-10m;
        protected override decimal GibibytesPerSecondInOneBitPerSecond => 1.16415321826935E-10m;

        protected override decimal TerabitsPerSecondInOneBitPerSecond => 1E-12m;
        protected override decimal TerabytesPerSecondInOneBitPerSecond => 1.25E-13m;
        protected override decimal TebibitsPerSecondInOneBitPerSecond => 9.09494701772928E-13m;
        protected override decimal TebibytesPerSecondInOneBitPerSecond => 1.13686837721616E-13m;

        protected override decimal PetabitsPerSecondInOneBitPerSecond => 1E-15m;
        protected override decimal PetabytesPerSecondInOneBitPerSecond => 1.25E-16m;
        protected override decimal PebibitsPerSecondInOneBitPerSecond => 8.88178419700125E-16m;
        protected override decimal PebibytesPerSecondInOneBitPerSecond => 1.11022302462516E-16m;

        protected override decimal ExabitsPerSecondInOneBitPerSecond => 1E-18m;
        protected override decimal ExabytesPerSecondInOneBitPerSecond => 1.25E-19m;
        protected override decimal ExbibitsPerSecondInOneBitPerSecond => 8.67361738E-19m;
        protected override decimal ExbibytesPerSecondInOneBitPerSecond => 1.0842021724855E-19m;
    }
}

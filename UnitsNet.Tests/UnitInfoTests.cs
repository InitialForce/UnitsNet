﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnitsNet.

using OasysUnitsNet.Units;
using Xunit;

namespace OasysUnitsNet.Tests
{
    public class UnitInfoTests
    {
        [Fact]
        public void ConstructorTest()
        {
            var unitInfo = new UnitInfo(LengthUnit.Meter, "Meters", new BaseUnits(LengthUnit.Meter));
            Assert.Equal(LengthUnit.Meter, unitInfo.Value);
            Assert.Equal(LengthUnit.Meter.ToString(), unitInfo.Name);
        }

        [Fact]
        public void GenericConstructorTest()
        {
            var unitInfo = new UnitInfo<LengthUnit>(LengthUnit.Meter, "Meters", new BaseUnits(LengthUnit.Meter));
            Assert.Equal(LengthUnit.Meter, unitInfo.Value);
            Assert.Equal(LengthUnit.Meter.ToString(), unitInfo.Name);
        }
    }
}

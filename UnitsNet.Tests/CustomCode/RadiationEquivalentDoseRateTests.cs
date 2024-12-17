// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class RadiationEquivalentDoseRateTests : RadiationEquivalentDoseRateTestsBase
    {
        // Override properties in base class here
        protected override bool SupportsSIUnitSystem => false;
        protected override double SievertsPerHourInOneSievertPerHour => 1;
        protected override double MillisievertsPerHourInOneSievertPerHour => 1e+3;
        protected override double MicrosievertsPerHourInOneSievertPerHour => 1e+6;
        protected override double NanosievertsPerHourInOneSievertPerHour => 1e+9;
        protected override double RoentgensEquivalentManPerHourInOneSievertPerHour => 100;
        protected override double MilliroentgensEquivalentManPerHourInOneSievertPerHour => 1e+5;

        [Fact]
        public void RadiationEquivalentDoseRateTimesTimeSpanEqualsRadiationEquivalentDose()
        {
            RadiationEquivalentDose dose = RadiationEquivalentDoseRate.FromSievertsPerHour(20)*TimeSpan.FromHours(2);
            Assert.Equal(dose, RadiationEquivalentDose.FromSieverts(40));
        }

        [Fact]
        public void RadiationEquivalentDoseRateTimesDurationEqualsRadiationEquivalentDose()
        {
            RadiationEquivalentDose dose = RadiationEquivalentDoseRate.FromSievertsPerHour(20)*Duration.FromHours(2);
            Assert.Equal(dose, RadiationEquivalentDose.FromSieverts(40));
        }
    }
}

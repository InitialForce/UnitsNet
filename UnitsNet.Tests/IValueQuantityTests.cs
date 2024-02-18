﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests
{
    // ReSharper disable once InconsistentNaming
    public class IValueQuantityTests
    {
        [Fact]
        public void IValueQuantityTDouble_Value_ReturnsDouble()
        {
            IValueQuantity<double> doubleQuantity = Temperature.FromDegreesCelsius(1234.5);
            Assert.IsType<double>(doubleQuantity.Value);
        }

        [Fact]
        public void IValueQuantityTDouble_AsEnum_ReturnsDouble()
        {
            IValueQuantity<double> doubleQuantity = Temperature.FromDegreesCelsius(1234.5);
            Assert.IsType<double>(doubleQuantity.As(TemperatureUnit.Kelvin));
        }

        [Fact]
        public void IValueQuantityTDouble_AsUnitSystem_ReturnsDouble()
        {
            IValueQuantity<double> doubleQuantity = Temperature.FromDegreesCelsius(1234.5);
            Assert.IsType<double>(doubleQuantity.As(UnitSystem.SI));
        }

        [Fact]
        public void IValueQuantityTDouble_ToUnitEnum_ReturnsIValueQuantityTDouble()
        {
            IValueQuantity<double> doubleQuantity = Temperature.FromDegreesCelsius(1234.5);
            Assert.IsAssignableFrom<IValueQuantity<double>>(doubleQuantity.ToUnit(TemperatureUnit.Kelvin));
        }

        [Fact]
        public void IValueQuantityTDouble_ToUnitUnitSystem_ReturnsIValueQuantityTDouble()
        {
            IValueQuantity<double> doubleQuantity = Temperature.FromDegreesCelsius(1234.5);
            Assert.IsAssignableFrom<IValueQuantity<double>>(doubleQuantity.ToUnit(UnitSystem.SI));
        }
    }
}

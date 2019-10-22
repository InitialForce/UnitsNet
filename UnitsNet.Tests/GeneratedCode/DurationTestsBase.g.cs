﻿//------------------------------------------------------------------------------
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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Duration.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class DurationTestsBase
    {
        protected abstract double DaysInOneSecond { get; }
        protected abstract double HoursInOneSecond { get; }
        protected abstract double MicrosecondsInOneSecond { get; }
        protected abstract double MillisecondsInOneSecond { get; }
        protected abstract double MinutesInOneSecond { get; }
        protected abstract double Months30InOneSecond { get; }
        protected abstract double NanosecondsInOneSecond { get; }
        protected abstract double SecondsInOneSecond { get; }
        protected abstract double WeeksInOneSecond { get; }
        protected abstract double Years365InOneSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DaysTolerance { get { return 1e-5; } }
        protected virtual double HoursTolerance { get { return 1e-5; } }
        protected virtual double MicrosecondsTolerance { get { return 1e-5; } }
        protected virtual double MillisecondsTolerance { get { return 1e-5; } }
        protected virtual double MinutesTolerance { get { return 1e-5; } }
        protected virtual double Months30Tolerance { get { return 1e-5; } }
        protected virtual double NanosecondsTolerance { get { return 1e-5; } }
        protected virtual double SecondsTolerance { get { return 1e-5; } }
        protected virtual double WeeksTolerance { get { return 1e-5; } }
        protected virtual double Years365Tolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Duration<double>((double)0.0, DurationUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Duration<double>(double.PositiveInfinity, DurationUnit.Second));
            Assert.Throws<ArgumentException>(() => new Duration<double>(double.NegativeInfinity, DurationUnit.Second));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Duration<double>(double.NaN, DurationUnit.Second));
        }

        [Fact]
        public void SecondToDurationUnits()
        {
            Duration<double> second = Duration<double>.FromSeconds(1);
            AssertEx.EqualTolerance(DaysInOneSecond, second.Days, DaysTolerance);
            AssertEx.EqualTolerance(HoursInOneSecond, second.Hours, HoursTolerance);
            AssertEx.EqualTolerance(MicrosecondsInOneSecond, second.Microseconds, MicrosecondsTolerance);
            AssertEx.EqualTolerance(MillisecondsInOneSecond, second.Milliseconds, MillisecondsTolerance);
            AssertEx.EqualTolerance(MinutesInOneSecond, second.Minutes, MinutesTolerance);
            AssertEx.EqualTolerance(Months30InOneSecond, second.Months30, Months30Tolerance);
            AssertEx.EqualTolerance(NanosecondsInOneSecond, second.Nanoseconds, NanosecondsTolerance);
            AssertEx.EqualTolerance(SecondsInOneSecond, second.Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(WeeksInOneSecond, second.Weeks, WeeksTolerance);
            AssertEx.EqualTolerance(Years365InOneSecond, second.Years365, Years365Tolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Duration<double>.From(1, DurationUnit.Day).Days, DaysTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.From(1, DurationUnit.Hour).Hours, HoursTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.From(1, DurationUnit.Microsecond).Microseconds, MicrosecondsTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.From(1, DurationUnit.Millisecond).Milliseconds, MillisecondsTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.From(1, DurationUnit.Minute).Minutes, MinutesTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.From(1, DurationUnit.Month30).Months30, Months30Tolerance);
            AssertEx.EqualTolerance(1, Duration<double>.From(1, DurationUnit.Nanosecond).Nanoseconds, NanosecondsTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.From(1, DurationUnit.Second).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.From(1, DurationUnit.Week).Weeks, WeeksTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.From(1, DurationUnit.Year365).Years365, Years365Tolerance);
        }

        [Fact]
        public void FromSeconds_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Duration<double>.FromSeconds(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Duration<double>.FromSeconds(double.NegativeInfinity));
        }

        [Fact]
        public void FromSeconds_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Duration<double>.FromSeconds(double.NaN));
        }

        [Fact]
        public void As()
        {
            var second = Duration<double>.FromSeconds(1);
            AssertEx.EqualTolerance(DaysInOneSecond, second.As(DurationUnit.Day), DaysTolerance);
            AssertEx.EqualTolerance(HoursInOneSecond, second.As(DurationUnit.Hour), HoursTolerance);
            AssertEx.EqualTolerance(MicrosecondsInOneSecond, second.As(DurationUnit.Microsecond), MicrosecondsTolerance);
            AssertEx.EqualTolerance(MillisecondsInOneSecond, second.As(DurationUnit.Millisecond), MillisecondsTolerance);
            AssertEx.EqualTolerance(MinutesInOneSecond, second.As(DurationUnit.Minute), MinutesTolerance);
            AssertEx.EqualTolerance(Months30InOneSecond, second.As(DurationUnit.Month30), Months30Tolerance);
            AssertEx.EqualTolerance(NanosecondsInOneSecond, second.As(DurationUnit.Nanosecond), NanosecondsTolerance);
            AssertEx.EqualTolerance(SecondsInOneSecond, second.As(DurationUnit.Second), SecondsTolerance);
            AssertEx.EqualTolerance(WeeksInOneSecond, second.As(DurationUnit.Week), WeeksTolerance);
            AssertEx.EqualTolerance(Years365InOneSecond, second.As(DurationUnit.Year365), Years365Tolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var second = Duration<double>.FromSeconds(1);

            var dayQuantity = second.ToUnit(DurationUnit.Day);
            AssertEx.EqualTolerance(DaysInOneSecond, (double)dayQuantity.Value, DaysTolerance);
            Assert.Equal(DurationUnit.Day, dayQuantity.Unit);

            var hourQuantity = second.ToUnit(DurationUnit.Hour);
            AssertEx.EqualTolerance(HoursInOneSecond, (double)hourQuantity.Value, HoursTolerance);
            Assert.Equal(DurationUnit.Hour, hourQuantity.Unit);

            var microsecondQuantity = second.ToUnit(DurationUnit.Microsecond);
            AssertEx.EqualTolerance(MicrosecondsInOneSecond, (double)microsecondQuantity.Value, MicrosecondsTolerance);
            Assert.Equal(DurationUnit.Microsecond, microsecondQuantity.Unit);

            var millisecondQuantity = second.ToUnit(DurationUnit.Millisecond);
            AssertEx.EqualTolerance(MillisecondsInOneSecond, (double)millisecondQuantity.Value, MillisecondsTolerance);
            Assert.Equal(DurationUnit.Millisecond, millisecondQuantity.Unit);

            var minuteQuantity = second.ToUnit(DurationUnit.Minute);
            AssertEx.EqualTolerance(MinutesInOneSecond, (double)minuteQuantity.Value, MinutesTolerance);
            Assert.Equal(DurationUnit.Minute, minuteQuantity.Unit);

            var month30Quantity = second.ToUnit(DurationUnit.Month30);
            AssertEx.EqualTolerance(Months30InOneSecond, (double)month30Quantity.Value, Months30Tolerance);
            Assert.Equal(DurationUnit.Month30, month30Quantity.Unit);

            var nanosecondQuantity = second.ToUnit(DurationUnit.Nanosecond);
            AssertEx.EqualTolerance(NanosecondsInOneSecond, (double)nanosecondQuantity.Value, NanosecondsTolerance);
            Assert.Equal(DurationUnit.Nanosecond, nanosecondQuantity.Unit);

            var secondQuantity = second.ToUnit(DurationUnit.Second);
            AssertEx.EqualTolerance(SecondsInOneSecond, (double)secondQuantity.Value, SecondsTolerance);
            Assert.Equal(DurationUnit.Second, secondQuantity.Unit);

            var weekQuantity = second.ToUnit(DurationUnit.Week);
            AssertEx.EqualTolerance(WeeksInOneSecond, (double)weekQuantity.Value, WeeksTolerance);
            Assert.Equal(DurationUnit.Week, weekQuantity.Unit);

            var year365Quantity = second.ToUnit(DurationUnit.Year365);
            AssertEx.EqualTolerance(Years365InOneSecond, (double)year365Quantity.Value, Years365Tolerance);
            Assert.Equal(DurationUnit.Year365, year365Quantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Duration<double> second = Duration<double>.FromSeconds(1);
            AssertEx.EqualTolerance(1, Duration<double>.FromDays(second.Days).Seconds, DaysTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.FromHours(second.Hours).Seconds, HoursTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.FromMicroseconds(second.Microseconds).Seconds, MicrosecondsTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.FromMilliseconds(second.Milliseconds).Seconds, MillisecondsTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.FromMinutes(second.Minutes).Seconds, MinutesTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.FromMonths30(second.Months30).Seconds, Months30Tolerance);
            AssertEx.EqualTolerance(1, Duration<double>.FromNanoseconds(second.Nanoseconds).Seconds, NanosecondsTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.FromSeconds(second.Seconds).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.FromWeeks(second.Weeks).Seconds, WeeksTolerance);
            AssertEx.EqualTolerance(1, Duration<double>.FromYears365(second.Years365).Seconds, Years365Tolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Duration<double> v = Duration<double>.FromSeconds(1);
            AssertEx.EqualTolerance(-1, -v.Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, (Duration<double>.FromSeconds(3)-v).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, (Duration<double>.FromSeconds(10)/5).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, Duration<double>.FromSeconds(10)/Duration<double>.FromSeconds(5), SecondsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Duration<double> oneSecond = Duration<double>.FromSeconds(1);
            Duration<double> twoSeconds = Duration<double>.FromSeconds(2);

            Assert.True(oneSecond < twoSeconds);
            Assert.True(oneSecond <= twoSeconds);
            Assert.True(twoSeconds > oneSecond);
            Assert.True(twoSeconds >= oneSecond);

            Assert.False(oneSecond > twoSeconds);
            Assert.False(oneSecond >= twoSeconds);
            Assert.False(twoSeconds < oneSecond);
            Assert.False(twoSeconds <= oneSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Duration<double> second = Duration<double>.FromSeconds(1);
            Assert.Equal(0, second.CompareTo(second));
            Assert.True(second.CompareTo(Duration<double>.Zero) > 0);
            Assert.True(Duration<double>.Zero.CompareTo(second) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Duration<double> second = Duration<double>.FromSeconds(1);
            Assert.Throws<ArgumentException>(() => second.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Duration<double> second = Duration<double>.FromSeconds(1);
            Assert.Throws<ArgumentNullException>(() => second.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Duration<double>.FromSeconds(1);
            var b = Duration<double>.FromSeconds(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = Duration<double>.FromSeconds(1);
            var b = Duration<double>.FromSeconds(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = Duration<double>.FromSeconds(1);
            Assert.True(v.Equals(Duration<double>.FromSeconds(1), SecondsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Duration<double>.Zero, SecondsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Duration<double> second = Duration<double>.FromSeconds(1);
            Assert.False(second.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Duration<double> second = Duration<double>.FromSeconds(1);
            Assert.False(second.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(DurationUnit.Undefined, Duration<double>.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(DurationUnit)).Cast<DurationUnit>();
            foreach(var unit in units)
            {
                if(unit == DurationUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Duration<double>.BaseDimensions is null);
        }
    }
}

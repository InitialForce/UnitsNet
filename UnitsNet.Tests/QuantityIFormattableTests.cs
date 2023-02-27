﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using Xunit;

namespace UnitsNet.Tests
{
    public class QuantityIFormattableTests
    {
        private static readonly Length MyLength = Length.FromFeet(1.2345678);

        [Fact]
        public void GFormatStringEqualsToString()
        {
            Assert.Equal(MyLength.ToString("g"), MyLength.ToString());
        }

        [Fact]
        public void EmptyOrNullFormatStringEqualsGFormat()
        {
            Assert.Equal(MyLength.ToString("g"), MyLength.ToString(string.Empty));
            Assert.Equal(MyLength.ToString("g"), MyLength.ToString(format: null!));
        }

        [Fact]
        public void AFormatGetsAbbreviations()
        {
            Assert.Equal(UnitAbbreviationsCache.Default.GetDefaultAbbreviation(MyLength.Unit), MyLength.ToString("a"));
            Assert.Equal(UnitAbbreviationsCache.Default.GetDefaultAbbreviation(MyLength.Unit), MyLength.ToString("a0"));

            Assert.Equal(UnitAbbreviationsCache.Default.GetUnitAbbreviations(MyLength.Unit)[1], MyLength.ToString("a1"));
            Assert.Equal(UnitAbbreviationsCache.Default.GetUnitAbbreviations(MyLength.Unit)[2], MyLength.ToString("a2"));
        }

        [Fact]
        public void AFormatWithInvalidIndexThrowsFormatException()
        {
            Assert.Throws<FormatException>(() => MyLength.ToString("a100"));
        }

        [Fact]
        public void UnsupportedFormatStringThrowsException()
        {
            Assert.Throws<FormatException>(() => MyLength.ToString("z"));
        }
    }
}

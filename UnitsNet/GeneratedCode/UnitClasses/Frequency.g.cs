﻿// Copyright © 2007 by Initial Force AS.  All rights reserved.
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     The number of occurrences of a repeating event per unit time.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    public partial struct Frequency : IComparable, IComparable<Frequency>
    {
        /// <summary>
        ///     Base unit of Frequency.
        /// </summary>
        private readonly double _hertz;

        public Frequency(double hertz) : this()
        {
            _hertz = hertz;
        }

        #region Properties

        public static FrequencyUnit BaseUnit
        {
            get { return FrequencyUnit.Hertz; }
        }

        /// <summary>
        ///     Get Frequency in CyclesPerHour.
        /// </summary>
        public double CyclesPerHour
        {
            get { return _hertz/3600; }
        }

        /// <summary>
        ///     Get Frequency in CyclesPerMinute.
        /// </summary>
        public double CyclesPerMinute
        {
            get { return _hertz/60; }
        }

        /// <summary>
        ///     Get Frequency in Gigahertz.
        /// </summary>
        public double Gigahertz
        {
            get { return (_hertz) / 1e9d; }
        }

        /// <summary>
        ///     Get Frequency in Hertz.
        /// </summary>
        public double Hertz
        {
            get { return _hertz; }
        }

        /// <summary>
        ///     Get Frequency in Kilohertz.
        /// </summary>
        public double Kilohertz
        {
            get { return (_hertz) / 1e3d; }
        }

        /// <summary>
        ///     Get Frequency in Megahertz.
        /// </summary>
        public double Megahertz
        {
            get { return (_hertz) / 1e6d; }
        }

        /// <summary>
        ///     Get Frequency in RadiansPerSecond.
        /// </summary>
        public double RadiansPerSecond
        {
            get { return _hertz*6.2831853072; }
        }

        /// <summary>
        ///     Get Frequency in Terahertz.
        /// </summary>
        public double Terahertz
        {
            get { return (_hertz) / 1e12d; }
        }

        #endregion

        #region Static 

        public static Frequency Zero
        {
            get { return new Frequency(); }
        }

        /// <summary>
        ///     Get Frequency from CyclesPerHour.
        /// </summary>
        public static Frequency FromCyclesPerHour(double cyclesperhour)
        {
            return new Frequency(cyclesperhour*3600);
        }

        /// <summary>
        ///     Get Frequency from CyclesPerMinute.
        /// </summary>
        public static Frequency FromCyclesPerMinute(double cyclesperminute)
        {
            return new Frequency(cyclesperminute*60);
        }

        /// <summary>
        ///     Get Frequency from Gigahertz.
        /// </summary>
        public static Frequency FromGigahertz(double gigahertz)
        {
            return new Frequency((gigahertz) * 1e9d);
        }

        /// <summary>
        ///     Get Frequency from Hertz.
        /// </summary>
        public static Frequency FromHertz(double hertz)
        {
            return new Frequency(hertz);
        }

        /// <summary>
        ///     Get Frequency from Kilohertz.
        /// </summary>
        public static Frequency FromKilohertz(double kilohertz)
        {
            return new Frequency((kilohertz) * 1e3d);
        }

        /// <summary>
        ///     Get Frequency from Megahertz.
        /// </summary>
        public static Frequency FromMegahertz(double megahertz)
        {
            return new Frequency((megahertz) * 1e6d);
        }

        /// <summary>
        ///     Get Frequency from RadiansPerSecond.
        /// </summary>
        public static Frequency FromRadiansPerSecond(double radianspersecond)
        {
            return new Frequency(radianspersecond/6.2831853072);
        }

        /// <summary>
        ///     Get Frequency from Terahertz.
        /// </summary>
        public static Frequency FromTerahertz(double terahertz)
        {
            return new Frequency((terahertz) * 1e12d);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="FrequencyUnit" /> to <see cref="Frequency" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Frequency unit value.</returns>
        public static Frequency From(double value, FrequencyUnit fromUnit)
        {
            switch (fromUnit)
            {
                case FrequencyUnit.CyclePerHour:
                    return FromCyclesPerHour(value);
                case FrequencyUnit.CyclePerMinute:
                    return FromCyclesPerMinute(value);
                case FrequencyUnit.Gigahertz:
                    return FromGigahertz(value);
                case FrequencyUnit.Hertz:
                    return FromHertz(value);
                case FrequencyUnit.Kilohertz:
                    return FromKilohertz(value);
                case FrequencyUnit.Megahertz:
                    return FromMegahertz(value);
                case FrequencyUnit.RadianPerSecond:
                    return FromRadiansPerSecond(value);
                case FrequencyUnit.Terahertz:
                    return FromTerahertz(value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(FrequencyUnit unit, CultureInfo culture = null)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        public static Frequency operator -(Frequency right)
        {
            return new Frequency(-right._hertz);
        }

        public static Frequency operator +(Frequency left, Frequency right)
        {
            return new Frequency(left._hertz + right._hertz);
        }

        public static Frequency operator -(Frequency left, Frequency right)
        {
            return new Frequency(left._hertz - right._hertz);
        }

        public static Frequency operator *(double left, Frequency right)
        {
            return new Frequency(left*right._hertz);
        }

        public static Frequency operator *(Frequency left, double right)
        {
            return new Frequency(left._hertz*(double)right);
        }

        public static Frequency operator /(Frequency left, double right)
        {
            return new Frequency(left._hertz/(double)right);
        }

        public static double operator /(Frequency left, Frequency right)
        {
            return Convert.ToDouble(left._hertz/right._hertz);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is Frequency)) throw new ArgumentException("Expected type Frequency.", "obj");
            return CompareTo((Frequency) obj);
        }

        public int CompareTo(Frequency other)
        {
            return _hertz.CompareTo(other._hertz);
        }

        public static bool operator <=(Frequency left, Frequency right)
        {
            return left._hertz <= right._hertz;
        }

        public static bool operator >=(Frequency left, Frequency right)
        {
            return left._hertz >= right._hertz;
        }

        public static bool operator <(Frequency left, Frequency right)
        {
            return left._hertz < right._hertz;
        }

        public static bool operator >(Frequency left, Frequency right)
        {
            return left._hertz > right._hertz;
        }

        public static bool operator ==(Frequency left, Frequency right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._hertz == right._hertz;
        }

        public static bool operator !=(Frequency left, Frequency right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._hertz != right._hertz;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _hertz.Equals(((Frequency) obj)._hertz);
        }

        public override int GetHashCode()
        {
            return _hertz.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(FrequencyUnit unit)
        {
            switch (unit)
            {
                case FrequencyUnit.CyclePerHour:
                    return CyclesPerHour;
                case FrequencyUnit.CyclePerMinute:
                    return CyclesPerMinute;
                case FrequencyUnit.Gigahertz:
                    return Gigahertz;
                case FrequencyUnit.Hertz:
                    return Hertz;
                case FrequencyUnit.Kilohertz:
                    return Kilohertz;
                case FrequencyUnit.Megahertz:
                    return Megahertz;
                case FrequencyUnit.RadianPerSecond:
                    return RadiansPerSecond;
                case FrequencyUnit.Terahertz:
                    return Terahertz;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in" 
        /// </exception>
        public static Frequency Parse(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var numFormat = formatProvider != null ?
                (NumberFormatInfo) formatProvider.GetFormat(typeof (NumberFormatInfo)) :
                NumberFormatInfo.CurrentInfo;

            var numRegex = string.Format(@"[\d., {0}{1}]*\d",  // allows digits, dots, commas, and spaces in the quantity (must end in digit)
                            numFormat.NumberGroupSeparator,    // adds provided (or current) culture's group separator
                            numFormat.NumberDecimalSeparator); // adds provided (or current) culture's decimal separator
            var exponentialRegex = @"(?:[eE][-+]?\d+)?)";
            var regexString = string.Format(@"(?:\s*(?<value>[-+]?{0}{1}{2}{3})?{4}{5}",
                            numRegex,                // capture base (integral) Quantity value
                            exponentialRegex,        // capture exponential (if any), end of Quantity capturing
                            @"\s?",                  // ignore whitespace (allows both "1kg", "1 kg")
                            @"(?<unit>[^\s\d,]+)",   // capture Unit (non-whitespace) input
                            @"(and)?,?",             // allow "and" & "," separators between quantities
                            @"(?<invalid>[a-z]*)?"); // capture invalid input

            var quantities = ParseWithRegex(regexString, str, formatProvider);
            if (quantities.Count == 0)
            {
                throw new ArgumentException(
                    "Expected string to have at least one pair of quantity and unit in the format"
                    + " \"&lt;quantity&gt; &lt;unit&gt;\". Eg. \"5.5 m\" or \"1ft 2in\"");
            }
            return quantities.Aggregate((x, y) => x + y);
        }

        /// <summary>
        ///     Parse a string given a particular regular expression.
        /// </summary>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        private static List<Frequency> ParseWithRegex(string regexString, string str, IFormatProvider formatProvider = null)
        {
            var regex = new Regex(regexString);
            MatchCollection matches = regex.Matches(str.Trim());
            var converted = new List<Frequency>();

            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;

                var valueString = groups["value"].Value;
                var unitString = groups["unit"].Value;
                if (groups["invalid"].Value != "")
                {
                    var newEx = new UnitsNetException("Invalid string detected: " + groups["invalid"].Value);
                    newEx.Data["input"] = str;
                    newEx.Data["matched value"] = valueString;
                    newEx.Data["matched unit"] = unitString;
                    newEx.Data["formatprovider"] = formatProvider == null ? null : formatProvider.ToString();
                    throw newEx;
                }
                if (valueString == "" && unitString == "") continue;

                try
                {
                    FrequencyUnit unit = ParseUnit(unitString, formatProvider);
                    double value = double.Parse(valueString, formatProvider);

                    converted.Add(From(value, unit));
                }
                catch (Exception ex)
                {
                    var newEx = new UnitsNetException("Error parsing string.", ex);
                    newEx.Data["input"] = str;
                    newEx.Data["matched value"] = valueString;
                    newEx.Data["matched unit"] = unitString;
                    newEx.Data["formatprovider"] = formatProvider == null ? null : formatProvider.ToString();
                    throw newEx;
                }
            }
            return converted;
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static FrequencyUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");
            var unitSystem = UnitSystem.GetCached(formatProvider);

            var unit = unitSystem.Parse<FrequencyUnit>(str.Trim());

            if (unit == FrequencyUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized FrequencyUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider == null ? null : formatProvider.ToString();
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(FrequencyUnit.Hertz);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(FrequencyUnit unit, CultureInfo culture = null, int significantDigitsAfterRadix = 2)
        {
            return ToString(unit, culture, UnitFormatter.GetFormat(As(unit), significantDigitsAfterRadix));
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(FrequencyUnit unit, CultureInfo culture, string format, params object[] args)
        {
            return string.Format(culture, format, UnitFormatter.GetFormatArgs(unit, As(unit), culture, args));
        }
    }
}

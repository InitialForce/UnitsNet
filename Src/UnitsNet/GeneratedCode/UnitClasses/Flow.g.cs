﻿// Copyright © 2007 by Initial Force AS.  All rights reserved.
// https://github.com/InitialForce/UnitsNet
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
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In physics and engineering, in particular fluid dynamics and hydrometry, the volumetric flow rate, (also known as volume flow rate, rate of fluid flow or volume velocity) is the volume of fluid which passes through a given surface per unit time. The SI unit is m3·s−1 (cubic meters per second). In US Customary Units and British Imperial Units, volumetric flow rate is often expressed as ft3/s (cubic feet per second). It is usually represented by the symbol Q.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    public partial struct Flow : IComparable, IComparable<Flow>
    {
        /// <summary>
        ///     Base unit of Flow.
        /// </summary>
        private readonly double _cubicMetersPerSecond;

        public Flow(double cubicmeterspersecond) : this()
        {
            _cubicMetersPerSecond = cubicmeterspersecond;
        }

        #region Properties

        /// <summary>
        ///     Get Flow in CubicFeetPerSecond.
        /// </summary>
        public double CubicFeetPerSecond
        {
            get { return _cubicMetersPerSecond*35.314666213; }
        }

        /// <summary>
        ///     Get Flow in CubicMetersPerHour.
        /// </summary>
        public double CubicMetersPerHour
        {
            get { return _cubicMetersPerSecond*3600; }
        }

        /// <summary>
        ///     Get Flow in CubicMetersPerSecond.
        /// </summary>
        public double CubicMetersPerSecond
        {
            get { return _cubicMetersPerSecond; }
        }

        /// <summary>
        ///     Get Flow in MillionUsGallonsPerDay.
        /// </summary>
        public double MillionUsGallonsPerDay
        {
            get { return _cubicMetersPerSecond*22.824465227; }
        }

        #endregion

        #region Static 

        public static Flow Zero
        {
            get { return new Flow(); }
        }

        /// <summary>
        ///     Get Flow from CubicFeetPerSecond.
        /// </summary>
        public static Flow FromCubicFeetPerSecond(double cubicfeetpersecond)
        {
            return new Flow(cubicfeetpersecond/35.314666213);
        }

        /// <summary>
        ///     Get Flow from CubicMetersPerHour.
        /// </summary>
        public static Flow FromCubicMetersPerHour(double cubicmetersperhour)
        {
            return new Flow(cubicmetersperhour/3600);
        }

        /// <summary>
        ///     Get Flow from CubicMetersPerSecond.
        /// </summary>
        public static Flow FromCubicMetersPerSecond(double cubicmeterspersecond)
        {
            return new Flow(cubicmeterspersecond);
        }

        /// <summary>
        ///     Get Flow from MillionUsGallonsPerDay.
        /// </summary>
        public static Flow FromMillionUsGallonsPerDay(double millionusgallonsperday)
        {
            return new Flow(millionusgallonsperday/22.824465227);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="FlowUnit" /> to <see cref="Flow" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Flow unit value.</returns>
        public static Flow From(double value, FlowUnit fromUnit)
        {
            switch (fromUnit)
            {
                case FlowUnit.CubicFootPerSecond:
                    return FromCubicFeetPerSecond(value);
                case FlowUnit.CubicMeterPerHour:
                    return FromCubicMetersPerHour(value);
                case FlowUnit.CubicMeterPerSecond:
                    return FromCubicMetersPerSecond(value);
                case FlowUnit.MillionUsGallonsPerDay:
                    return FromMillionUsGallonsPerDay(value);

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
        public static string GetAbbreviation(FlowUnit unit, CultureInfo culture = null)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        public static Flow operator -(Flow right)
        {
            return new Flow(-right._cubicMetersPerSecond);
        }

        public static Flow operator +(Flow left, Flow right)
        {
            return new Flow(left._cubicMetersPerSecond + right._cubicMetersPerSecond);
        }

        public static Flow operator -(Flow left, Flow right)
        {
            return new Flow(left._cubicMetersPerSecond - right._cubicMetersPerSecond);
        }

        public static Flow operator *(double left, Flow right)
        {
            return new Flow(left*right._cubicMetersPerSecond);
        }

        public static Flow operator *(Flow left, double right)
        {
            return new Flow(left._cubicMetersPerSecond*(double)right);
        }

        public static Flow operator /(Flow left, double right)
        {
            return new Flow(left._cubicMetersPerSecond/(double)right);
        }

        public static double operator /(Flow left, Flow right)
        {
            return Convert.ToDouble(left._cubicMetersPerSecond/right._cubicMetersPerSecond);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is Flow)) throw new ArgumentException("Expected type Flow.", "obj");
            return CompareTo((Flow) obj);
        }

        public int CompareTo(Flow other)
        {
            return _cubicMetersPerSecond.CompareTo(other._cubicMetersPerSecond);
        }

        public static bool operator <=(Flow left, Flow right)
        {
            return left._cubicMetersPerSecond <= right._cubicMetersPerSecond;
        }

        public static bool operator >=(Flow left, Flow right)
        {
            return left._cubicMetersPerSecond >= right._cubicMetersPerSecond;
        }

        public static bool operator <(Flow left, Flow right)
        {
            return left._cubicMetersPerSecond < right._cubicMetersPerSecond;
        }

        public static bool operator >(Flow left, Flow right)
        {
            return left._cubicMetersPerSecond > right._cubicMetersPerSecond;
        }

        public static bool operator ==(Flow left, Flow right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._cubicMetersPerSecond == right._cubicMetersPerSecond;
        }

        public static bool operator !=(Flow left, Flow right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._cubicMetersPerSecond != right._cubicMetersPerSecond;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _cubicMetersPerSecond.Equals(((Flow) obj)._cubicMetersPerSecond);
        }

        public override int GetHashCode()
        {
            return _cubicMetersPerSecond.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(FlowUnit unit)
        {
            switch (unit)
            {
                case FlowUnit.CubicFootPerSecond:
                    return CubicFeetPerSecond;
                case FlowUnit.CubicMeterPerHour:
                    return CubicMetersPerHour;
                case FlowUnit.CubicMeterPerSecond:
                    return CubicMetersPerSecond;
                case FlowUnit.MillionUsGallonsPerDay:
                    return MillionUsGallonsPerDay;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected 2 words. Input string needs to be in the format "&lt;quantity&gt; &lt;unit
        ///     &gt;".
        /// </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static Flow Parse(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var numFormat = formatProvider != null ?
                (NumberFormatInfo) formatProvider.GetFormat(typeof (NumberFormatInfo)) :
                (NumberFormatInfo) CultureInfo.CurrentCulture.NumberFormat.Clone();

            var numRegex = @"[\d., "                        // allows digits, dots, commas, and spaces in the number by default
                         + numFormat.NumberGroupSeparator   // adds provided (or current) culture's group separator
                         + numFormat.NumberDecimalSeparator // adds provided (or current) culture's decimal separator
                         + @"]*\d";                         // ensures quantity ends in digit
            var regexString = @"(?<value>[-+]?" + numRegex + @"(?:[eE][-+]?\d+)?)" // capture Quantity input
                            + @"\s?"                                               // ignore whitespace (allows both "1kg", "1 kg")
                            + @"(?<unit>\S+)";                                     // capture Unit (non-whitespace) input

            var regex = new Regex(regexString);
            GroupCollection groups = regex.Match(str.Trim()).Groups;

            var valueString = groups["value"].Value;
            var unitString = groups["unit"].Value;

            if (valueString == "" || unitString == "")
            {
                var ex = new ArgumentException(
                    "Expected valid quantity and unit. Input string needs to be in the format \"<quantity><unit> or <quantity> <unit>\".", "str");
                ex.Data["input"] = str;
                ex.Data["formatprovider"] = formatProvider == null ? null : formatProvider.ToString();
                throw ex;
            }

            try
            {
                var unitSystem = UnitSystem.GetCached(formatProvider);

                FlowUnit unit = unitSystem.Parse<FlowUnit>(unitString);
                double value = double.Parse(valueString, formatProvider);

                return From(value, unit);
            }
            catch (Exception e)
            {
                var newEx = new UnitsNetException("Error parsing string.", e);
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider == null ? null : formatProvider.ToString();
                throw newEx;
            }
        }

        #endregion

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(FlowUnit.CubicMeterPerSecond);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(FlowUnit unit, CultureInfo culture = null, int significantDigitsAfterRadix = 2)
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
        public string ToString(FlowUnit unit, CultureInfo culture, string format, params object[] args)
        {
            return string.Format(culture, format, UnitFormatter.GetFormatArgs(unit, As(unit), culture, args));
        }
    }
}

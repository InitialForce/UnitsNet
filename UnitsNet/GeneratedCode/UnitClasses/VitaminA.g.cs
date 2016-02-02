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
    ///     Vitamin A: 1 IU is the biological equivalent of 0.3 μg retinol, or of 0.6 μg beta-carotene.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    public partial struct VitaminA : IComparable, IComparable<VitaminA>
    {
        /// <summary>
        ///     Base unit of VitaminA.
        /// </summary>
        private readonly double _internationalUnits;

        public VitaminA(double internationalunits) : this()
        {
            _internationalUnits = internationalunits;
        }

        #region Properties

        public static VitaminAUnit BaseUnit
        {
            get { return VitaminAUnit.InternationalUnit; }
        }

        /// <summary>
        ///     Get VitaminA in InternationalUnits.
        /// </summary>
        public double InternationalUnits
        {
            get { return _internationalUnits; }
        }

        #endregion

        #region Static 

        public static VitaminA Zero
        {
            get { return new VitaminA(); }
        }

        /// <summary>
        ///     Get VitaminA from InternationalUnits.
        /// </summary>
        public static VitaminA FromInternationalUnits(double internationalunits)
        {
            return new VitaminA(internationalunits);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="VitaminAUnit" /> to <see cref="VitaminA" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>VitaminA unit value.</returns>
        public static VitaminA From(double value, VitaminAUnit fromUnit)
        {
            switch (fromUnit)
            {
                case VitaminAUnit.InternationalUnit:
                    return FromInternationalUnits(value);

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
        public static string GetAbbreviation(VitaminAUnit unit, CultureInfo culture = null)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        public static VitaminA operator -(VitaminA right)
        {
            return new VitaminA(-right._internationalUnits);
        }

        public static VitaminA operator +(VitaminA left, VitaminA right)
        {
            return new VitaminA(left._internationalUnits + right._internationalUnits);
        }

        public static VitaminA operator -(VitaminA left, VitaminA right)
        {
            return new VitaminA(left._internationalUnits - right._internationalUnits);
        }

        public static VitaminA operator *(double left, VitaminA right)
        {
            return new VitaminA(left*right._internationalUnits);
        }

        public static VitaminA operator *(VitaminA left, double right)
        {
            return new VitaminA(left._internationalUnits*(double)right);
        }

        public static VitaminA operator /(VitaminA left, double right)
        {
            return new VitaminA(left._internationalUnits/(double)right);
        }

        public static double operator /(VitaminA left, VitaminA right)
        {
            return Convert.ToDouble(left._internationalUnits/right._internationalUnits);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is VitaminA)) throw new ArgumentException("Expected type VitaminA.", "obj");
            return CompareTo((VitaminA) obj);
        }

        public int CompareTo(VitaminA other)
        {
            return _internationalUnits.CompareTo(other._internationalUnits);
        }

        public static bool operator <=(VitaminA left, VitaminA right)
        {
            return left._internationalUnits <= right._internationalUnits;
        }

        public static bool operator >=(VitaminA left, VitaminA right)
        {
            return left._internationalUnits >= right._internationalUnits;
        }

        public static bool operator <(VitaminA left, VitaminA right)
        {
            return left._internationalUnits < right._internationalUnits;
        }

        public static bool operator >(VitaminA left, VitaminA right)
        {
            return left._internationalUnits > right._internationalUnits;
        }

        public static bool operator ==(VitaminA left, VitaminA right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._internationalUnits == right._internationalUnits;
        }

        public static bool operator !=(VitaminA left, VitaminA right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._internationalUnits != right._internationalUnits;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _internationalUnits.Equals(((VitaminA) obj)._internationalUnits);
        }

        public override int GetHashCode()
        {
            return _internationalUnits.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(VitaminAUnit unit)
        {
            switch (unit)
            {
                case VitaminAUnit.InternationalUnit:
                    return InternationalUnits;

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
        public static VitaminA Parse(string str, IFormatProvider formatProvider = null)
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
        private static List<VitaminA> ParseWithRegex(string regexString, string str, IFormatProvider formatProvider = null)
        {
            var regex = new Regex(regexString);
            MatchCollection matches = regex.Matches(str.Trim());
            var converted = new List<VitaminA>();

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
                    VitaminAUnit unit = ParseUnit(unitString, formatProvider);
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
        public static VitaminAUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");
            var unitSystem = UnitSystem.GetCached(formatProvider);

            var unit = unitSystem.Parse<VitaminAUnit>(str.Trim());

            if (unit == VitaminAUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized VitaminAUnit.");
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
            return ToString(VitaminAUnit.InternationalUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(VitaminAUnit unit, CultureInfo culture = null, int significantDigitsAfterRadix = 2)
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
        public string ToString(VitaminAUnit unit, CultureInfo culture, string format, params object[] args)
        {
            return string.Format(culture, format, UnitFormatter.GetFormatArgs(unit, As(unit), culture, args));
        }
    }
}

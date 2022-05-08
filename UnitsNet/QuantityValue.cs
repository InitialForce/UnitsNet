﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.


using System;
using System.Globalization;
using UnitsNet.InternalHelpers;

namespace UnitsNet
{
    /// <summary>
    ///     A type that supports implicit cast from all .NET numeric types, in order to avoid a large number of overloads
    ///     and binary size for all From(value, unit) factory methods, for each of the 700+ units in the library.
    ///     <see cref="QuantityValue"/> stores the value internally with the proper type to preserve the range or precision of the original value:
    /// <list type="bullet">
    /// <item><description><see cref="double"/> for [byte, short, int, long, float, double]</description></item>
    /// <item><description><see cref="decimal"/> for [decimal] to preserve the 128-bit precision</description></item>
    /// </list>
    /// </summary>
    /// <remarks>
    ///     At the time of this writing, this reduces the number of From(value, unit) overloads to 1/4th:
    ///     From 8 (int, long, double, decimal + each nullable) down to 2 (QuantityValue and QuantityValue?).
    ///     This also adds more numeric types with no extra overhead, such as float, short and byte.
    /// </remarks>
    public struct QuantityValue : IFormattable, IEquatable<QuantityValue>
    {
        /// <summary>
        /// The value 0
        /// </summary>
        public static readonly QuantityValue Zero = new QuantityValue(0, 0);

        /// <summary>
        ///     Value assigned when implicitly casting from all numeric types except <see cref="decimal" />, since
        ///     <see cref="double" /> has the greatest range and is 64 bits versus 128 bits for <see cref="decimal"/>.
        /// </summary>
        private readonly double? _value;

        /// <summary>
        ///     Value assigned when implicitly casting from <see cref="decimal" /> type, since it has a greater precision than
        ///     <see cref="double"/> and we want to preserve that when constructing quantities that use <see cref="decimal"/>
        ///     as their value type.
        /// </summary>
        private readonly decimal? _valueDecimal;

        private QuantityValue(double val)
        {
            _value = Guard.EnsureValidNumber(val, nameof(val));
            _valueDecimal = null;
        }

        private QuantityValue(decimal val)
        {
            _valueDecimal = val;
            _value = null;
        }

        private QuantityValue(double value, decimal valueDecimal)
        {
            _value = value;
            _valueDecimal = valueDecimal;
        }

        /// <summary>
        /// Returns true if the underlying value is stored as a decimal
        /// </summary>
        public bool IsDecimal =>  _valueDecimal.HasValue;

        #region To QuantityValue

        // Prefer double for integer types, since most quantities use that type as of now and
        // that avoids unnecessary casts back and forth.
        // If we later change to use decimal more, we should revisit this.
        /// <summary>Implicit cast from <see cref="byte"/> to <see cref="QuantityValue"/>.</summary>
        public static implicit operator QuantityValue(byte val) => new QuantityValue((double) val);
        /// <summary>Implicit cast from <see cref="short"/> to <see cref="QuantityValue"/>.</summary>
        public static implicit operator QuantityValue(short val) => new QuantityValue((double) val);
        /// <summary>Implicit cast from <see cref="int"/> to <see cref="QuantityValue"/>.</summary>
        public static implicit operator QuantityValue(int val) => new QuantityValue((double) val);
        /// <summary>Implicit cast from <see cref="long"/> to <see cref="QuantityValue"/>.</summary>
        public static implicit operator QuantityValue(long val) => new QuantityValue((double) val);
        /// <summary>Implicit cast from <see cref="float"/> to <see cref="QuantityValue"/>.</summary>
        public static implicit operator QuantityValue(float val) => new QuantityValue(val); // double
        /// <summary>Implicit cast from <see cref="double"/> to <see cref="QuantityValue"/>.</summary>
        public static implicit operator QuantityValue(double val) => new QuantityValue(val); // double
        /// <summary>Implicit cast from <see cref="decimal"/> to <see cref="QuantityValue"/>.</summary>
        public static implicit operator QuantityValue(decimal val) => new QuantityValue(val); // decimal
        #endregion

        #region To double

        /// <summary>Explicit cast from <see cref="QuantityValue"/> to <see cref="double"/>.</summary>
        public static explicit operator double(QuantityValue number)
        {
            // double -> decimal -> zero (since we can't implement the default struct ctor)
            return number._value ?? (double) number._valueDecimal.GetValueOrDefault();
        }

        #endregion

        #region To decimal

        /// <summary>Explicit cast from <see cref="QuantityValue"/> to <see cref="decimal"/>.</summary>
        public static explicit operator decimal(QuantityValue number)
        {
            // decimal -> double -> zero (since we can't implement the default struct ctor)
            return number._valueDecimal ?? (decimal) number._value.GetValueOrDefault();
        }

        #endregion

        #region Operators and Comparators

        /// <inheritdoc />
        public override bool Equals(object other)
        {
            if (other is QuantityValue qv)
            {
                return Equals(qv);
            }

            return false;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            if (IsDecimal)
            {
                return _valueDecimal.GetHashCode();
            }
            else
            {
                return _value.GetHashCode();
            }
        }

        /// <summary>
        /// Performs an equality comparison on two instances of <see cref="QuantityValue"/>.
        /// Note that rounding might occur if the two values don't use the same base type.
        /// </summary>
        /// <param name="other">The value to compare to</param>
        /// <returns>True on exact equality, false otherwise</returns>
        public bool Equals(QuantityValue other)
        {
            if (IsDecimal && other.IsDecimal)
            {
                return _valueDecimal == other._valueDecimal;
            }
            else if (IsDecimal)
            {
                return _valueDecimal == (decimal)other._value.GetValueOrDefault(0); // other._value cannot be null here
            }
            else if (other.IsDecimal)
            {
                return (decimal)_value.GetValueOrDefault(0) == other._valueDecimal;
            }
            else
            {
                return _value == other._value;
            }
        }

        /// <summary>Equality comparator</summary>
        public static bool operator ==(QuantityValue a, QuantityValue b)
        {
            return a.Equals(b);
        }

        /// <summary>Inequality comparator</summary>
        public static bool operator !=(QuantityValue a, QuantityValue b)
        {
            return !a.Equals(b);
        }

        /// <summary>
        /// Greater-than operator
        /// </summary>
        public static bool operator >(QuantityValue a, QuantityValue b)
        {
            if (a.IsDecimal && b.IsDecimal)
            {
                return a._valueDecimal.GetValueOrDefault(0) > b._valueDecimal.GetValueOrDefault(0);
            }
            else if (a.IsDecimal)
            {
                return a._valueDecimal.GetValueOrDefault(0) > (decimal)b._value.GetValueOrDefault(0); // other._value cannot be null here
            }
            else if (b.IsDecimal)
            {
                return (decimal)a._value.GetValueOrDefault(0) > b._valueDecimal.GetValueOrDefault(0);
            }
            else
            {
                // Both are double
                return a._value.GetValueOrDefault(0) > b._value.GetValueOrDefault(0);
            }
        }

        /// <summary>
        /// Less-than operator
        /// </summary>
        public static bool operator <(QuantityValue a, QuantityValue b)
        {
            if (a.IsDecimal && b.IsDecimal)
            {
                return a._valueDecimal.GetValueOrDefault(0) < b._valueDecimal.GetValueOrDefault(0);
            }
            else if (a.IsDecimal)
            {
                return a._valueDecimal.GetValueOrDefault(0) < (decimal)b._value.GetValueOrDefault(0); // other._value cannot be null here
            }
            else if (b.IsDecimal)
            {
                return (decimal)a._value.GetValueOrDefault(0) < b._valueDecimal.GetValueOrDefault(0);
            }
            else
            {
                // Both are double
                return a._value.GetValueOrDefault(0) < b._value.GetValueOrDefault(0);
            }
        }

        /// <summary>
        /// Greater-than-or-equal operator
        /// </summary>
        public static bool operator >=(QuantityValue a, QuantityValue b)
        {
            if (a.IsDecimal && b.IsDecimal)
            {
                return a._valueDecimal.GetValueOrDefault(0) >= b._valueDecimal.GetValueOrDefault(0);
            }
            else if (a.IsDecimal)
            {
                return a._valueDecimal.GetValueOrDefault(0) >= (decimal)b._value.GetValueOrDefault(0); // other._value cannot be null here
            }
            else if (b.IsDecimal)
            {
                return (decimal)a._value.GetValueOrDefault(0) >= b._valueDecimal.GetValueOrDefault(0);
            }
            else
            {
                // Both are double
                return a._value >= b._value;
            }
        }

        /// <summary>
        /// Less-than-or-equal operator
        /// </summary>
        public static bool operator <=(QuantityValue a, QuantityValue b)
        {
            if (a.IsDecimal && b.IsDecimal)
            {
                return a._valueDecimal.GetValueOrDefault(0) <= b._valueDecimal.GetValueOrDefault(0);
            }
            else if (a.IsDecimal)
            {
                return a._valueDecimal.GetValueOrDefault(0) <= (decimal)b._value.GetValueOrDefault(0); // other._value cannot be null here
            }
            else if (b.IsDecimal)
            {
                return (decimal)a._value.GetValueOrDefault(0) <= b._valueDecimal.GetValueOrDefault(0);
            }
            else
            {
                // Both are double
                return a._value.GetValueOrDefault(0) <= b._value.GetValueOrDefault(0);
            }
        }

        /// <summary>
        /// Returns the negated value of the operand
        /// </summary>
        /// <param name="v">Value to negate</param>
        /// <returns>-v</returns>
        public static QuantityValue operator -(QuantityValue v)
        {
            if (v._valueDecimal.HasValue)
            {
                return new QuantityValue(-v._valueDecimal.Value);
            }
            else
            {
                return new QuantityValue(-v._value.GetValueOrDefault());
            }
        }

        /// <summary>
        /// Multiplication operator.
        /// </summary>
        /// <remarks>
        /// This performs an operation on the numeric value of a quantity, there is no unit or conversions involved.
        /// </remarks>
        public static QuantityValue operator *(QuantityValue a, QuantityValue b)
        {
            if (a.IsDecimal && b.IsDecimal)
            {
                return new QuantityValue(a._valueDecimal.GetValueOrDefault(0) * b._valueDecimal.GetValueOrDefault(0));
            }
            else if (a.IsDecimal)
            {
                return new QuantityValue(a._valueDecimal.GetValueOrDefault(0) * (decimal)b._value.GetValueOrDefault(0)); // other._value cannot be null here
            }
            else if (b.IsDecimal)
            {
                return new QuantityValue((decimal)a._value.GetValueOrDefault(0) * b._valueDecimal.GetValueOrDefault(0));
            }
            else
            {
                // Both are double
                return new QuantityValue(a._value.GetValueOrDefault(0) * b._value.GetValueOrDefault(0));
            }
        }

        /// <summary>
        /// Division operator.
        /// </summary>
        /// <remarks>
        /// This performs an operation on the numeric value of a quantity, there is no unit or conversions involved.
        /// </remarks>
        public static QuantityValue operator /(QuantityValue a, QuantityValue b)
        {
            if (a.IsDecimal && b.IsDecimal)
            {
                return new QuantityValue(a._valueDecimal.GetValueOrDefault(0) / b._valueDecimal.GetValueOrDefault(0));
            }
            else if (a.IsDecimal)
            {
                return new QuantityValue(a._valueDecimal.GetValueOrDefault(0) / (decimal)b._value.GetValueOrDefault(0)); // other._value cannot be null here
            }
            else if (b.IsDecimal)
            {
                return new QuantityValue((decimal)a._value.GetValueOrDefault(0) / b._valueDecimal.GetValueOrDefault(0));
            }
            else
            {
                // Both are double
                return new QuantityValue(a._value.GetValueOrDefault(0) / b._value.GetValueOrDefault(0));
            }
        }

        #endregion

        /// <summary>Returns the string representation of the numeric value.</summary>
        public override string ToString()
        {
            return ToString(string.Empty, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns the string representation of the numeric value, formatted using the given standard numeric format string
        /// </summary>
        /// <param name="format">A standard numeric format string (must be valid for either double or decimal, depending on the base type)</param>
        /// <returns>The string representation</returns>
        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns the string representation of the numeric value, formatted using the given standard numeric format string
        /// </summary>
        /// <param name="formatProvider">The culture to use</param>
        /// <returns>The string representation</returns>
        public string ToString(IFormatProvider formatProvider)
        {
            return ToString(string.Empty, formatProvider);
        }

        /// <summary>
        /// Returns the string representation of the underlying value
        /// </summary>
        /// <param name="format">Standard format specifiers. Because the underlying value can be double or decimal, the meaning can vary</param>
        /// <param name="formatProvider">Culture specific settings</param>
        /// <returns>A string representation of the number</returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (_value.HasValue)
            {
                return _value.Value.ToString(format, formatProvider);
            }
            else if (_valueDecimal.HasValue)
            {
                return _valueDecimal.Value.ToString(format, formatProvider);
            }

            return 0.ToString(format, formatProvider);
        }
    }
}

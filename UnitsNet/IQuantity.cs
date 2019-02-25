﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using JetBrains.Annotations;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    ///     Represents a quantity.
    /// </summary>
    public interface IQuantity
    {
        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        QuantityType Type { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        BaseDimensions Dimensions { get; }

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        QuantityInfo QuantityInfo { get; }

        /// <summary>
        ///     Dynamically convert to another unit representation.
        /// </summary>
        /// <param name="unit">The unit enum value. The unit must be compatible, so for <see cref="Length"/> you should provide a <see cref="LengthUnit"/> value.</param>
        /// <returns>Value converted to the specified unit.</returns>
        /// <exception cref="InvalidCastException">Wrong unit enum type was given.</exception>
        double As(Enum unit);

        /// <summary>
        ///     The unit this quantity was constructed with or the BaseUnit if the default constructor was used.
        /// </summary>
        Enum Unit { get; }

        /// <summary>
        ///     The value this quantity was constructed with. Should be seen in combination with <see cref="Unit"/>.
        /// </summary>
        double Value { get; }

        /// <summary>
        ///     Change the default unit representation of the quantity, which affects things like <see cref="IQuantity.ToString(System.IFormatProvider)"/>.
        /// </summary>
        /// <param name="unit">The unit enum value. The unit must be compatible, so for <see cref="Length"/> you should provide a <see cref="LengthUnit"/> value.</param>
        /// <returns>A new quantity with the given unit as default unit representation.</returns>
        IQuantity ToUnit(Enum unit);

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        string ToString([CanBeNull] IFormatProvider provider);

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        string ToString([CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix);

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        string ToString([CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args);
    }

    public interface IQuantity<TUnitType> : IQuantity where TUnitType : Enum
    {
        /// <summary>
        ///     Convert to a unit representation <typeparamref name="TUnitType"/>.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        double As(TUnitType unit);

        /// <inheritdoc cref="IQuantity.Unit"/>
        new TUnitType Unit { get; }

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        new QuantityInfo<TUnitType> QuantityInfo { get; }

        /// <summary>
        ///     Change the default unit representation of the quantity, which affects things like <see cref="IQuantity.ToString(System.IFormatProvider)"/>.
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        IQuantity<TUnitType> ToUnit(TUnitType unit);
    }
}

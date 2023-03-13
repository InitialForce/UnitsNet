﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    ///     Information about the unit, such as its name and value.
    ///     This is useful to enumerate units and present names with quantities and units
    ///     chosen dynamically at runtime, such as unit conversion apps or allowing the user to change the
    ///     unit representation.
    /// </summary>
    /// <remarks>
    ///     Typically you obtain this by looking it up via <see cref="QuantityInfo.UnitInfos" />.
    /// </remarks>
    public class UnitInfo
    {
        /// <summary>
        /// Creates an instance of the UnitInfo class.
        /// </summary>
        /// <param name="value">The enum value for this class, for example <see cref="LengthUnit.Meter"/>.</param>
        /// <param name="pluralName">The plural name of the unit, such as "Centimeters".</param>
        /// <param name="baseUnits">The <see cref="BaseUnits"/> for this unit.</param>
        public UnitInfo(Enum value, string pluralName, BaseUnits baseUnits)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
            Name = value.ToString();
            PluralName = pluralName;
            BaseUnits = baseUnits ?? throw new ArgumentNullException(nameof(baseUnits));

            AbbreviationsMap = new ConcurrentDictionary<CultureInfo, Lazy<List<string>>>();
        }

        /// <summary>
        /// Creates an instance of the UnitInfo class.
        /// </summary>
        /// <param name="value">The enum value for this class, for example <see cref="LengthUnit.Meter"/>.</param>
        /// <param name="pluralName">The plural name of the unit, such as "Centimeters".</param>
        /// <param name="baseUnits">The <see cref="BaseUnits"/> for this unit.</param>
        /// <param name="quantityName">The quantity name that this unit is for.</param>
        internal UnitInfo(Enum value, string pluralName, BaseUnits baseUnits, string quantityName) :
            this(value, pluralName, baseUnits)
        {
            QuantityName = quantityName;
        }

        /// <summary>
        /// The enum value of the unit, such as <see cref="LengthUnit.Centimeter" />.
        /// </summary>
        public Enum Value { get; }

        /// <summary>
        /// The singular name of the unit, such as "Centimeter".
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The plural name of the unit, such as "Centimeters".
        /// </summary>
        public string PluralName { get; }

        /// <summary>
        /// Gets the <see cref="BaseUnits"/> for this unit.
        /// </summary>
        public BaseUnits BaseUnits { get; }

        private string? QuantityName { get; }

        /// <summary>
        /// The per-culture abbreviations. To add a custom default abbreviation, add to the beginning of the list.
        /// </summary>
        private IDictionary<CultureInfo, Lazy<List<string>>> AbbreviationsMap { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IList<string> GetAbbreviations(CultureInfo culture)
        {
            culture ??= CultureInfo.CurrentCulture;

            if(!AbbreviationsMap.TryGetValue(culture, out var abbreviations))
                AbbreviationsMap[culture] = abbreviations = new Lazy<List<string>>(() => ReadAbbreviationsFromResourceFile(culture));

            return abbreviations.Value;
        }

        private List<string> ReadAbbreviationsFromResourceFile(CultureInfo culture)
        {
            var abbreviationsList = new List<string>();

            if(QuantityName is not null)
            {
                string resourceName = $"UnitsNet.GeneratedCode.Resources.{QuantityName}";
                var resourceManager = new ResourceManager(resourceName, GetType().Assembly);

                var abbreviationsString = resourceManager.GetString(PluralName, culture);
                if(abbreviationsString is not null)
                    abbreviationsList.AddRange(abbreviationsString.Split(','));
            }

            return abbreviationsList;
        }
    }

    /// <inheritdoc cref="UnitInfo" />
    /// <remarks>
    ///     This is a specialization of <see cref="UnitInfo" />, for when the unit type is known.
    ///     Typically you obtain this by looking it up statically from <see cref="QuantityInfo{LengthUnit}.UnitInfos" /> or
    ///     or dynamically via <see cref="IQuantity{TUnitType}.QuantityInfo" />.
    /// </remarks>
    /// <typeparam name="TUnit">The unit enum type, such as <see cref="LengthUnit" />. </typeparam>
    public class UnitInfo<TUnit> : UnitInfo
        where TUnit : Enum
    {
        /// <inheritdoc />
        public UnitInfo(TUnit value, string pluralName, BaseUnits baseUnits) :
            base(value, pluralName, baseUnits)
        {
            Value = value;
        }

        /// <inheritdoc />
        internal UnitInfo(TUnit value, string pluralName, BaseUnits baseUnits, string quantityName) :
            base(value, pluralName, baseUnits, quantityName)
        {
            Value = value;
        }

        /// <inheritdoc cref="UnitInfo.Value"/>
        public new TUnit Value { get; }
    }
}

﻿using UnitsNet.Attributes;

namespace UnitsNet.Units
{
    public enum LengthUnit
    {
        [I18n("en-US", "(undefined)")]
        [I18n("ru-RU", "(нет ед.изм.)")]
        [I18n("nb-NO", "(ingen)")]
        Undefined = 0,

        /*
         * International Nautical Mile
         * "Beginning on July 1, 1954, the National Bureau of Standards will use
         * the international Nautical Mile in lieu of the U.S. Nautical Mil. This deciision, replacint the U.S. Nautical
         * Mile of 1,853.248 meters (6,080.20 feet) by the International Nautical Mile of 1,852 meters (6,076.10333... feet),
         * confirms an official agreement between the Secretart of Commerce and the Secretary of Defense to use the 
         * Inernational Nautical Mile within their respective departments." http://physics.nist.gov/Pubs/SP447/app4.pdf
        */
        [I18n("en-US", "nmi")]
        [I18n("ru-RU", "нмиля")]
        [Length(1852)]
        InternationalNauticalMile,

        [I18n("en-US", "km")]
        [I18n("ru-RU", "км")]
        [Length(1e3)]
        Kilometer,

        [I18n("en-US", "m")]
        [I18n("ru-RU", "м")]
        [Length(1)]
        Meter, // Base unit

        [I18n("en-US", "dm")]
        [I18n("ru-RU", "дм")]
        [Length(1e-1)]
        Decimeter,

        [I18n("en-US", "cm")]
        [I18n("ru-RU", "см")]
        [Length(1e-2)]
        Centimeter,

        [I18n("en-US", "mm")]
        [I18n("ru-RU", "мм")]
        [Length(1e-3)]
        Millimeter,

        [I18n("en-US", "μm")]
        [I18n("ru-RU", "мкм")]
        [Length(1e-6)]
        Micrometer,

        [I18n("en-US", "nm")]
        [I18n("ru-RU", "нм")]
        [Length(1e-9)]
        Nanometer,

        // US, imperial and other
        [I18n("en-US", "mi")]
        [I18n("ru-RU", "миля")]
        [Length(1609.34)]
        Mile,

        [I18n("en-US", "yd")]
        [I18n("ru-RU", "ярд")]
        [Length(0.9144)]
        Yard,

        [I18n("en-US", "ft")]
        [I18n("ru-RU", "фут")]
        [Length(0.3048, "Feet")]
        Foot,

        [I18n("en-US", "in")]
        [I18n("ru-RU", "дюйм")]
        [Length(2.54e-2, "Inches")]
        Inch,

        [I18n("en-US", "mil")]
        [I18n("ru-RU", "мил")]
        [Length(2.54e-5)]
        Mil,

        [I18n("en-US", "μin")]
        [I18n("ru-RU", "микродюйм")]
        [Length(2.54e-8, "Microinches")]
        Microinch,
    }
}
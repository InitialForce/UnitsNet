﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnitsNet.

using System;
using OasysUnitsNet.Units;

namespace OasysUnitsNet
{
    /// <summary>
    ///     Unable to parse because more than one unit of the given quantity type had this exact unit abbreviation.
    ///     Example: Length.Parse("1 pt") will throw <see cref="AmbiguousUnitParseException" />, because both
    ///     <see cref="LengthUnit.DtpPoint" /> and
    ///     <see cref="LengthUnit.PrinterPoint" /> have "pt" as their abbreviation.
    /// </summary>
    internal class AmbiguousUnitParseException : OasysUnitsNetException
    {
        /// <inheritdoc />
        public AmbiguousUnitParseException(string message) : base(message)
        {
            HResult = 2;
        }

        /// <inheritdoc />
        public AmbiguousUnitParseException(string message, Exception innerException) : base(message, innerException)
        {
            HResult = 2;
        }
    }
}

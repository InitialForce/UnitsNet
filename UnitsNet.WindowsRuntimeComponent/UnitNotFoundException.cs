﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnitsNet.

using System;

namespace OasysUnitsNet
{
    /// <summary>
    ///     Unit was not found. This is typically thrown for dynamic conversions,
    ///     such as <see cref="UnitConverter.ConvertByName" />.
    /// </summary>
    internal class UnitNotFoundException : OasysUnitsNetException
    {
        public UnitNotFoundException()
        {
        }

        public UnitNotFoundException(string message) : base(message)
        {
        }

        public UnitNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

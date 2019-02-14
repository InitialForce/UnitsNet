﻿// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
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

namespace UnitsNet
{
    public partial struct Area
    {
        #region Static Methods

        public static Area FromCircleDiameter(Length diameter)
        {
            var radius = Length.FromMeters(diameter.Meters / 2d);
            return FromCircleRadius(radius);
        }

        public static Area FromCircleRadius(Length radius)
        {
            return FromSquareMeters(Math.PI * radius.Meters * radius.Meters);
        }

        #endregion

        public static Length operator /(Area area, Length length)
        {
            return Length.FromMeters(area.SquareMeters / length.Meters);
        }

        public static MassFlow operator *(Area area, MassFlux massFlux)
        {
            return MassFlow.FromGramsPerSecond(area.SquareMeters * massFlux.GramsPerSecondPerSquareMeter);
        }

        public static VolumeFlow operator *(Area area, Speed speed)
        {
            return VolumeFlow.FromCubicMetersPerSecond(area.SquareMeters * speed.MetersPerSecond);
        }
    }
}

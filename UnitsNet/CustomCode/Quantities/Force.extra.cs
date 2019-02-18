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

using UnitsNet.Units;

namespace UnitsNet
{
    public partial struct Force
    {
        public static Force FromPressureByArea(Pressure p, Area area)
        {
            double newtons = p.Pascals * area.SquareMeters;
            return new Force(newtons, ForceUnit.Newton);
        }

        public static Force FromMassByAcceleration(Mass mass, Acceleration acceleration)
        {
            return new Force(mass.Kilograms * acceleration.MetersPerSecondSquared, ForceUnit.Newton);
        }

        public static Power operator *(Force force, Speed speed)
        {
            return Power.FromWatts(force.Newtons * speed.MetersPerSecond);
        }

        public static Power operator *(Speed speed, Force force)
        {
            return Power.FromWatts(force.Newtons * speed.MetersPerSecond);
        }

        public static Acceleration operator /(Force force, Mass mass)
        {
            return Acceleration.FromMetersPerSecondSquared(force.Newtons / mass.Kilograms);
        }

        public static Mass operator /(Force force, Acceleration mass)
        {
            return Mass.FromKilograms(force.Newtons / mass.MetersPerSecondSquared);
        }

        public static Pressure operator /(Force force, Area area)
        {
            return Pressure.FromPascals(force.Newtons / area.SquareMeters);
        }

        public static ForcePerLength operator /(Force force, Length length)
        {
            return ForcePerLength.FromNewtonsPerMeter(force.Newtons / length.Meters);
        }
    }
}

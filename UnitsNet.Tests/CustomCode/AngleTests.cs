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

namespace UnitsNet.Tests.CustomCode
{
    public class AngleTests : AngleTestsBase
    {

        protected override double DegreesInOneDegree
        {
            get { return 1; }
        }

        protected override double GradiansInOneDegree
        {
            get { return 400/360.0; }
        }

        protected override double ArcminutesInOneDegree
        {
            get
            {
                return 60.0;
            }
        }

        protected override double RadiansInOneDegree
        {
            get { return Math.PI/2/90; }
        }

        protected override double NanoradiansInOneDegree
        {
            get { return (Math.PI / 2 / 90) * 1E9; }
        }

        protected override double MicroradiansInOneDegree
        {
            get { return (Math.PI / 2 / 90) * 1E6; }
        }

        protected override double MilliradiansInOneDegree
        {
            get { return (Math.PI / 2 / 90) * 1E3; }
        }

        protected override double CentiradiansInOneDegree
        {
            get { return (Math.PI / 2 / 90) * 1E2; }
        }

        protected override double DeciradiansInOneDegree
        {
            get { return (Math.PI / 2 / 90) * 1E1; }
        }

        protected override double ArcsecondsInOneDegree
        {
            get
            {
                return 3600.0;
            }
        }

    }
}
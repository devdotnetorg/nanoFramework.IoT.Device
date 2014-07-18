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
using NUnit.Framework;
using UnitsNet.Units;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Angle.
    /// </summary>
    [TestFixture]
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AngleTestsBase
    {
        protected abstract double DegreesInOneDegree { get; }
        protected abstract double GradiansInOneDegree { get; }
        protected abstract double RadiansInOneDegree { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesTolerance { get { return 1E-5; } }
        protected virtual double GradiansTolerance { get { return 1E-5; } }
        protected virtual double RadiansTolerance { get { return 1E-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Test]
        public void DegreeToAngleUnits()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.AreEqual(DegreesInOneDegree, degree.Degrees, DegreesTolerance);
            Assert.AreEqual(GradiansInOneDegree, degree.Gradians, GradiansTolerance);
            Assert.AreEqual(RadiansInOneDegree, degree.Radians, RadiansTolerance);
        }

        [Test]
        public void FromValueAndUnit()
        {
            Assert.AreEqual(1, Angle.From(1, AngleUnit.Degree).Degrees, DegreesTolerance);
            Assert.AreEqual(1, Angle.From(1, AngleUnit.Gradian).Gradians, GradiansTolerance);
            Assert.AreEqual(1, Angle.From(1, AngleUnit.Radian).Radians, RadiansTolerance);
        }

        [Test]
        public void As()
        {
            var degree = Angle.FromDegrees(1);
            Assert.AreEqual(DegreesInOneDegree, degree.As(AngleUnit.Degree), DegreesTolerance);
            Assert.AreEqual(GradiansInOneDegree, degree.As(AngleUnit.Gradian), GradiansTolerance);
            Assert.AreEqual(RadiansInOneDegree, degree.As(AngleUnit.Radian), RadiansTolerance);
        }

        [Test]
        public void ConversionRoundTrip()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.AreEqual(1, Angle.FromDegrees(degree.Degrees).Degrees, DegreesTolerance);
            Assert.AreEqual(1, Angle.FromGradians(degree.Gradians).Degrees, GradiansTolerance);
            Assert.AreEqual(1, Angle.FromRadians(degree.Radians).Degrees, RadiansTolerance);
        }

        [Test]
        public void ArithmeticOperators()
        {
            Angle v = Angle.FromDegrees(1);
            Assert.AreEqual(-1, -v.Degrees, RadiansTolerance);
            Assert.AreEqual(2, (Angle.FromDegrees(3)-v).Degrees, RadiansTolerance);
            Assert.AreEqual(2, (v + v).Degrees, RadiansTolerance);
            Assert.AreEqual(10, (v*10).Degrees, RadiansTolerance);
            Assert.AreEqual(10, (10*v).Degrees, RadiansTolerance);
            Assert.AreEqual(2, (Angle.FromDegrees(10)/5).Degrees, RadiansTolerance);
            Assert.AreEqual(2, Angle.FromDegrees(10)/Angle.FromDegrees(5), RadiansTolerance);
        }

        [Test]
        public void ComparisonOperators()
        {
            Angle oneDegree = Angle.FromDegrees(1);
            Angle twoDegrees = Angle.FromDegrees(2);

            Assert.True(oneDegree < twoDegrees);
            Assert.True(oneDegree <= twoDegrees);
            Assert.True(twoDegrees > oneDegree);
            Assert.True(twoDegrees >= oneDegree);

            Assert.False(oneDegree > twoDegrees);
            Assert.False(oneDegree >= twoDegrees);
            Assert.False(twoDegrees < oneDegree);
            Assert.False(twoDegrees <= oneDegree);
        }

        [Test]
        public void CompareToIsImplemented()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.AreEqual(0, degree.CompareTo(degree));
            Assert.Greater(degree.CompareTo(Angle.Zero), 0);
            Assert.Less(Angle.Zero.CompareTo(degree), 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CompareToThrowsOnTypeMismatch()
        {
            Angle degree = Angle.FromDegrees(1);
// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            degree.CompareTo(new object());
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareToThrowsOnNull()
        { 
            Angle degree = Angle.FromDegrees(1);
// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            degree.CompareTo(null);
        }


        [Test]
        public void EqualityOperators()
        {
            Angle a = Angle.FromDegrees(1);
            Angle b = Angle.FromDegrees(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a); 
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Test]
        public void EqualsIsImplemented()
        {
            Angle v = Angle.FromDegrees(1);
            Assert.IsTrue(v.Equals(Angle.FromDegrees(1)));
            Assert.IsFalse(v.Equals(Angle.Zero));
        }

        [Test]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.IsFalse(degree.Equals(new object()));
        }

        [Test]
        public void EqualsReturnsFalseOnNull()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.IsFalse(degree.Equals(null));
        }
    }
}

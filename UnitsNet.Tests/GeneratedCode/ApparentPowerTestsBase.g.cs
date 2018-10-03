﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ApparentPower.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ApparentPowerTestsBase
    {
        protected abstract double GigavoltamperesInOneVoltampere { get; }
        protected abstract double KilovoltamperesInOneVoltampere { get; }
        protected abstract double MegavoltamperesInOneVoltampere { get; }
        protected abstract double VoltamperesInOneVoltampere { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GigavoltamperesTolerance { get { return 1e-5; } }
        protected virtual double KilovoltamperesTolerance { get { return 1e-5; } }
        protected virtual double MegavoltamperesTolerance { get { return 1e-5; } }
        protected virtual double VoltamperesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ApparentPower((double)0.0, ApparentPowerUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ApparentPower(double.PositiveInfinity, ApparentPowerUnit.Voltampere));
            Assert.Throws<ArgumentException>(() => new ApparentPower(double.NegativeInfinity, ApparentPowerUnit.Voltampere));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ApparentPower(double.NaN, ApparentPowerUnit.Voltampere));
        }

        [Fact]
        public void VoltampereToApparentPowerUnits()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            AssertEx.EqualTolerance(GigavoltamperesInOneVoltampere, voltampere.Gigavoltamperes, GigavoltamperesTolerance);
            AssertEx.EqualTolerance(KilovoltamperesInOneVoltampere, voltampere.Kilovoltamperes, KilovoltamperesTolerance);
            AssertEx.EqualTolerance(MegavoltamperesInOneVoltampere, voltampere.Megavoltamperes, MegavoltamperesTolerance);
            AssertEx.EqualTolerance(VoltamperesInOneVoltampere, voltampere.Voltamperes, VoltamperesTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ApparentPower.From(1, ApparentPowerUnit.Gigavoltampere).Gigavoltamperes, GigavoltamperesTolerance);
            AssertEx.EqualTolerance(1, ApparentPower.From(1, ApparentPowerUnit.Kilovoltampere).Kilovoltamperes, KilovoltamperesTolerance);
            AssertEx.EqualTolerance(1, ApparentPower.From(1, ApparentPowerUnit.Megavoltampere).Megavoltamperes, MegavoltamperesTolerance);
            AssertEx.EqualTolerance(1, ApparentPower.From(1, ApparentPowerUnit.Voltampere).Voltamperes, VoltamperesTolerance);
        }

        [Fact]
        public void FromVoltamperes_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ApparentPower.FromVoltamperes(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ApparentPower.FromVoltamperes(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltamperes_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ApparentPower.FromVoltamperes(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltampere = ApparentPower.FromVoltamperes(1);
            AssertEx.EqualTolerance(GigavoltamperesInOneVoltampere, voltampere.As(ApparentPowerUnit.Gigavoltampere), GigavoltamperesTolerance);
            AssertEx.EqualTolerance(KilovoltamperesInOneVoltampere, voltampere.As(ApparentPowerUnit.Kilovoltampere), KilovoltamperesTolerance);
            AssertEx.EqualTolerance(MegavoltamperesInOneVoltampere, voltampere.As(ApparentPowerUnit.Megavoltampere), MegavoltamperesTolerance);
            AssertEx.EqualTolerance(VoltamperesInOneVoltampere, voltampere.As(ApparentPowerUnit.Voltampere), VoltamperesTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var voltampere = ApparentPower.FromVoltamperes(1);

            var gigavoltampereQuantity = voltampere.ToUnit(ApparentPowerUnit.Gigavoltampere);
            AssertEx.EqualTolerance(GigavoltamperesInOneVoltampere, (double)gigavoltampereQuantity.Value, GigavoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Gigavoltampere, gigavoltampereQuantity.Unit);

            var kilovoltampereQuantity = voltampere.ToUnit(ApparentPowerUnit.Kilovoltampere);
            AssertEx.EqualTolerance(KilovoltamperesInOneVoltampere, (double)kilovoltampereQuantity.Value, KilovoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Kilovoltampere, kilovoltampereQuantity.Unit);

            var megavoltampereQuantity = voltampere.ToUnit(ApparentPowerUnit.Megavoltampere);
            AssertEx.EqualTolerance(MegavoltamperesInOneVoltampere, (double)megavoltampereQuantity.Value, MegavoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Megavoltampere, megavoltampereQuantity.Unit);

            var voltampereQuantity = voltampere.ToUnit(ApparentPowerUnit.Voltampere);
            AssertEx.EqualTolerance(VoltamperesInOneVoltampere, (double)voltampereQuantity.Value, VoltamperesTolerance);
            Assert.Equal(ApparentPowerUnit.Voltampere, voltampereQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            AssertEx.EqualTolerance(1, ApparentPower.FromGigavoltamperes(voltampere.Gigavoltamperes).Voltamperes, GigavoltamperesTolerance);
            AssertEx.EqualTolerance(1, ApparentPower.FromKilovoltamperes(voltampere.Kilovoltamperes).Voltamperes, KilovoltamperesTolerance);
            AssertEx.EqualTolerance(1, ApparentPower.FromMegavoltamperes(voltampere.Megavoltamperes).Voltamperes, MegavoltamperesTolerance);
            AssertEx.EqualTolerance(1, ApparentPower.FromVoltamperes(voltampere.Voltamperes).Voltamperes, VoltamperesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ApparentPower v = ApparentPower.FromVoltamperes(1);
            AssertEx.EqualTolerance(-1, -v.Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(2, (ApparentPower.FromVoltamperes(3)-v).Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(2, (ApparentPower.FromVoltamperes(10)/5).Voltamperes, VoltamperesTolerance);
            AssertEx.EqualTolerance(2, ApparentPower.FromVoltamperes(10)/ApparentPower.FromVoltamperes(5), VoltamperesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ApparentPower oneVoltampere = ApparentPower.FromVoltamperes(1);
            ApparentPower twoVoltamperes = ApparentPower.FromVoltamperes(2);

            Assert.True(oneVoltampere < twoVoltamperes);
            Assert.True(oneVoltampere <= twoVoltamperes);
            Assert.True(twoVoltamperes > oneVoltampere);
            Assert.True(twoVoltamperes >= oneVoltampere);

            Assert.False(oneVoltampere > twoVoltamperes);
            Assert.False(oneVoltampere >= twoVoltamperes);
            Assert.False(twoVoltamperes < oneVoltampere);
            Assert.False(twoVoltamperes <= oneVoltampere);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            Assert.Equal(0, voltampere.CompareTo(voltampere));
            Assert.True(voltampere.CompareTo(ApparentPower.Zero) > 0);
            Assert.True(ApparentPower.Zero.CompareTo(voltampere) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            Assert.Throws<ArgumentException>(() => voltampere.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            Assert.Throws<ArgumentNullException>(() => voltampere.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ApparentPower v = ApparentPower.FromVoltamperes(1);
            Assert.True(v.Equals(ApparentPower.FromVoltamperes(1), VoltamperesTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ApparentPower.Zero, VoltamperesTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            Assert.False(voltampere.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ApparentPower voltampere = ApparentPower.FromVoltamperes(1);
            Assert.False(voltampere.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ApparentPowerUnit.Undefined, ApparentPower.Units);
        }
    }
}

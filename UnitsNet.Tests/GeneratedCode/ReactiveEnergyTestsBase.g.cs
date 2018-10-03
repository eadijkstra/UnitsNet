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
    /// Test of ReactiveEnergy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ReactiveEnergyTestsBase
    {
        protected abstract double KilovoltampereReactiveHoursInOneVoltampereReactiveHour { get; }
        protected abstract double MegavoltampereReactiveHoursInOneVoltampereReactiveHour { get; }
        protected abstract double VoltampereReactiveHoursInOneVoltampereReactiveHour { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltampereReactiveHoursTolerance { get { return 1e-5; } }
        protected virtual double MegavoltampereReactiveHoursTolerance { get { return 1e-5; } }
        protected virtual double VoltampereReactiveHoursTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactiveEnergy((double)0.0, ReactiveEnergyUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactiveEnergy(double.PositiveInfinity, ReactiveEnergyUnit.VoltampereReactiveHour));
            Assert.Throws<ArgumentException>(() => new ReactiveEnergy(double.NegativeInfinity, ReactiveEnergyUnit.VoltampereReactiveHour));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactiveEnergy(double.NaN, ReactiveEnergyUnit.VoltampereReactiveHour));
        }

        [Fact]
        public void VoltampereReactiveHourToReactiveEnergyUnits()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(KilovoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.KilovoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(MegavoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.MegavoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(VoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ReactiveEnergy.From(1, ReactiveEnergyUnit.KilovoltampereReactiveHour).KilovoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(1, ReactiveEnergy.From(1, ReactiveEnergyUnit.MegavoltampereReactiveHour).MegavoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(1, ReactiveEnergy.From(1, ReactiveEnergyUnit.VoltampereReactiveHour).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void FromVoltampereReactiveHours_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReactiveEnergy.FromVoltampereReactiveHours(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ReactiveEnergy.FromVoltampereReactiveHours(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltampereReactiveHours_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReactiveEnergy.FromVoltampereReactiveHours(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(KilovoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.As(ReactiveEnergyUnit.KilovoltampereReactiveHour), KilovoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(MegavoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.As(ReactiveEnergyUnit.MegavoltampereReactiveHour), MegavoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(VoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.As(ReactiveEnergyUnit.VoltampereReactiveHour), VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);

            var kilovoltamperereactivehourQuantity = voltamperereactivehour.ToUnit(ReactiveEnergyUnit.KilovoltampereReactiveHour);
            AssertEx.EqualTolerance(KilovoltampereReactiveHoursInOneVoltampereReactiveHour, (double)kilovoltamperereactivehourQuantity.Value, KilovoltampereReactiveHoursTolerance);
            Assert.Equal(ReactiveEnergyUnit.KilovoltampereReactiveHour, kilovoltamperereactivehourQuantity.Unit);

            var megavoltamperereactivehourQuantity = voltamperereactivehour.ToUnit(ReactiveEnergyUnit.MegavoltampereReactiveHour);
            AssertEx.EqualTolerance(MegavoltampereReactiveHoursInOneVoltampereReactiveHour, (double)megavoltamperereactivehourQuantity.Value, MegavoltampereReactiveHoursTolerance);
            Assert.Equal(ReactiveEnergyUnit.MegavoltampereReactiveHour, megavoltamperereactivehourQuantity.Unit);

            var voltamperereactivehourQuantity = voltamperereactivehour.ToUnit(ReactiveEnergyUnit.VoltampereReactiveHour);
            AssertEx.EqualTolerance(VoltampereReactiveHoursInOneVoltampereReactiveHour, (double)voltamperereactivehourQuantity.Value, VoltampereReactiveHoursTolerance);
            Assert.Equal(ReactiveEnergyUnit.VoltampereReactiveHour, voltamperereactivehourQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(1, ReactiveEnergy.FromKilovoltampereReactiveHours(voltamperereactivehour.KilovoltampereReactiveHours).VoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(1, ReactiveEnergy.FromMegavoltampereReactiveHours(voltamperereactivehour.MegavoltampereReactiveHours).VoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(1, ReactiveEnergy.FromVoltampereReactiveHours(voltamperereactivehour.VoltampereReactiveHours).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ReactiveEnergy v = ReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(-1, -v.VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, (ReactiveEnergy.FromVoltampereReactiveHours(3)-v).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, (ReactiveEnergy.FromVoltampereReactiveHours(10)/5).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, ReactiveEnergy.FromVoltampereReactiveHours(10)/ReactiveEnergy.FromVoltampereReactiveHours(5), VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ReactiveEnergy oneVoltampereReactiveHour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            ReactiveEnergy twoVoltampereReactiveHours = ReactiveEnergy.FromVoltampereReactiveHours(2);

            Assert.True(oneVoltampereReactiveHour < twoVoltampereReactiveHours);
            Assert.True(oneVoltampereReactiveHour <= twoVoltampereReactiveHours);
            Assert.True(twoVoltampereReactiveHours > oneVoltampereReactiveHour);
            Assert.True(twoVoltampereReactiveHours >= oneVoltampereReactiveHour);

            Assert.False(oneVoltampereReactiveHour > twoVoltampereReactiveHours);
            Assert.False(oneVoltampereReactiveHour >= twoVoltampereReactiveHours);
            Assert.False(twoVoltampereReactiveHours < oneVoltampereReactiveHour);
            Assert.False(twoVoltampereReactiveHours <= oneVoltampereReactiveHour);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Equal(0, voltamperereactivehour.CompareTo(voltamperereactivehour));
            Assert.True(voltamperereactivehour.CompareTo(ReactiveEnergy.Zero) > 0);
            Assert.True(ReactiveEnergy.Zero.CompareTo(voltamperereactivehour) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Throws<ArgumentException>(() => voltamperereactivehour.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Throws<ArgumentNullException>(() => voltamperereactivehour.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ReactiveEnergy v = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.True(v.Equals(ReactiveEnergy.FromVoltampereReactiveHours(1), VoltampereReactiveHoursTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ReactiveEnergy.Zero, VoltampereReactiveHoursTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.False(voltamperereactivehour.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.False(voltamperereactivehour.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ReactiveEnergyUnit.Undefined, ReactiveEnergy.Units);
        }
    }
}

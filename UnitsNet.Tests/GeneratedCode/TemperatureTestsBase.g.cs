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
    /// Test of Temperature.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class TemperatureTestsBase
    {
        protected abstract double DegreesCelsiusInOneKelvin { get; }
        protected abstract double DegreesDelisleInOneKelvin { get; }
        protected abstract double DegreesFahrenheitInOneKelvin { get; }
        protected abstract double DegreesNewtonInOneKelvin { get; }
        protected abstract double DegreesRankineInOneKelvin { get; }
        protected abstract double DegreesReaumurInOneKelvin { get; }
        protected abstract double DegreesRoemerInOneKelvin { get; }
        protected abstract double KelvinsInOneKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesCelsiusTolerance { get { return 1e-5; } }
        protected virtual double DegreesDelisleTolerance { get { return 1e-5; } }
        protected virtual double DegreesFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double DegreesNewtonTolerance { get { return 1e-5; } }
        protected virtual double DegreesRankineTolerance { get { return 1e-5; } }
        protected virtual double DegreesReaumurTolerance { get { return 1e-5; } }
        protected virtual double DegreesRoemerTolerance { get { return 1e-5; } }
        protected virtual double KelvinsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Temperature((double)0.0, TemperatureUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Temperature(double.PositiveInfinity, TemperatureUnit.Kelvin));
            Assert.Throws<ArgumentException>(() => new Temperature(double.NegativeInfinity, TemperatureUnit.Kelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Temperature(double.NaN, TemperatureUnit.Kelvin));
        }

        [Fact]
        public void KelvinToTemperatureUnits()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, kelvin.DegreesCelsius, DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, kelvin.DegreesDelisle, DegreesDelisleTolerance);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, kelvin.DegreesFahrenheit, DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, kelvin.DegreesNewton, DegreesNewtonTolerance);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, kelvin.DegreesRankine, DegreesRankineTolerance);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, kelvin.DegreesReaumur, DegreesReaumurTolerance);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, kelvin.DegreesRoemer, DegreesRoemerTolerance);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, kelvin.Kelvins, KelvinsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Temperature.From(1, TemperatureUnit.DegreeCelsius).DegreesCelsius, DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(1, Temperature.From(1, TemperatureUnit.DegreeDelisle).DegreesDelisle, DegreesDelisleTolerance);
            AssertEx.EqualTolerance(1, Temperature.From(1, TemperatureUnit.DegreeFahrenheit).DegreesFahrenheit, DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(1, Temperature.From(1, TemperatureUnit.DegreeNewton).DegreesNewton, DegreesNewtonTolerance);
            AssertEx.EqualTolerance(1, Temperature.From(1, TemperatureUnit.DegreeRankine).DegreesRankine, DegreesRankineTolerance);
            AssertEx.EqualTolerance(1, Temperature.From(1, TemperatureUnit.DegreeReaumur).DegreesReaumur, DegreesReaumurTolerance);
            AssertEx.EqualTolerance(1, Temperature.From(1, TemperatureUnit.DegreeRoemer).DegreesRoemer, DegreesRoemerTolerance);
            AssertEx.EqualTolerance(1, Temperature.From(1, TemperatureUnit.Kelvin).Kelvins, KelvinsTolerance);
        }

        [Fact]
        public void FromKelvins_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Temperature.FromKelvins(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Temperature.FromKelvins(double.NegativeInfinity));
        }

        [Fact]
        public void FromKelvins_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Temperature.FromKelvins(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kelvin = Temperature.FromKelvins(1);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, kelvin.As(TemperatureUnit.DegreeCelsius), DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, kelvin.As(TemperatureUnit.DegreeDelisle), DegreesDelisleTolerance);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, kelvin.As(TemperatureUnit.DegreeFahrenheit), DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, kelvin.As(TemperatureUnit.DegreeNewton), DegreesNewtonTolerance);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, kelvin.As(TemperatureUnit.DegreeRankine), DegreesRankineTolerance);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, kelvin.As(TemperatureUnit.DegreeReaumur), DegreesReaumurTolerance);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, kelvin.As(TemperatureUnit.DegreeRoemer), DegreesRoemerTolerance);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, kelvin.As(TemperatureUnit.Kelvin), KelvinsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kelvin = Temperature.FromKelvins(1);

            var degreecelsiusQuantity = kelvin.ToUnit(TemperatureUnit.DegreeCelsius);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, (double)degreecelsiusQuantity.Value, DegreesCelsiusTolerance);
            Assert.Equal(TemperatureUnit.DegreeCelsius, degreecelsiusQuantity.Unit);

            var degreedelisleQuantity = kelvin.ToUnit(TemperatureUnit.DegreeDelisle);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, (double)degreedelisleQuantity.Value, DegreesDelisleTolerance);
            Assert.Equal(TemperatureUnit.DegreeDelisle, degreedelisleQuantity.Unit);

            var degreefahrenheitQuantity = kelvin.ToUnit(TemperatureUnit.DegreeFahrenheit);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, (double)degreefahrenheitQuantity.Value, DegreesFahrenheitTolerance);
            Assert.Equal(TemperatureUnit.DegreeFahrenheit, degreefahrenheitQuantity.Unit);

            var degreenewtonQuantity = kelvin.ToUnit(TemperatureUnit.DegreeNewton);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, (double)degreenewtonQuantity.Value, DegreesNewtonTolerance);
            Assert.Equal(TemperatureUnit.DegreeNewton, degreenewtonQuantity.Unit);

            var degreerankineQuantity = kelvin.ToUnit(TemperatureUnit.DegreeRankine);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, (double)degreerankineQuantity.Value, DegreesRankineTolerance);
            Assert.Equal(TemperatureUnit.DegreeRankine, degreerankineQuantity.Unit);

            var degreereaumurQuantity = kelvin.ToUnit(TemperatureUnit.DegreeReaumur);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, (double)degreereaumurQuantity.Value, DegreesReaumurTolerance);
            Assert.Equal(TemperatureUnit.DegreeReaumur, degreereaumurQuantity.Unit);

            var degreeroemerQuantity = kelvin.ToUnit(TemperatureUnit.DegreeRoemer);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, (double)degreeroemerQuantity.Value, DegreesRoemerTolerance);
            Assert.Equal(TemperatureUnit.DegreeRoemer, degreeroemerQuantity.Unit);

            var kelvinQuantity = kelvin.ToUnit(TemperatureUnit.Kelvin);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, (double)kelvinQuantity.Value, KelvinsTolerance);
            Assert.Equal(TemperatureUnit.Kelvin, kelvinQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesCelsius(kelvin.DegreesCelsius).Kelvins, DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesDelisle(kelvin.DegreesDelisle).Kelvins, DegreesDelisleTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesFahrenheit(kelvin.DegreesFahrenheit).Kelvins, DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesNewton(kelvin.DegreesNewton).Kelvins, DegreesNewtonTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesRankine(kelvin.DegreesRankine).Kelvins, DegreesRankineTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesReaumur(kelvin.DegreesReaumur).Kelvins, DegreesReaumurTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesRoemer(kelvin.DegreesRoemer).Kelvins, DegreesRoemerTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromKelvins(kelvin.Kelvins).Kelvins, KelvinsTolerance);
        }


        [Fact]
        public void ComparisonOperators()
        {
            Temperature oneKelvin = Temperature.FromKelvins(1);
            Temperature twoKelvins = Temperature.FromKelvins(2);

            Assert.True(oneKelvin < twoKelvins);
            Assert.True(oneKelvin <= twoKelvins);
            Assert.True(twoKelvins > oneKelvin);
            Assert.True(twoKelvins >= oneKelvin);

            Assert.False(oneKelvin > twoKelvins);
            Assert.False(oneKelvin >= twoKelvins);
            Assert.False(twoKelvins < oneKelvin);
            Assert.False(twoKelvins <= oneKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            Assert.Equal(0, kelvin.CompareTo(kelvin));
            Assert.True(kelvin.CompareTo(Temperature.Zero) > 0);
            Assert.True(Temperature.Zero.CompareTo(kelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            Assert.Throws<ArgumentException>(() => kelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            Assert.Throws<ArgumentNullException>(() => kelvin.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Temperature v = Temperature.FromKelvins(1);
            Assert.True(v.Equals(Temperature.FromKelvins(1), KelvinsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Temperature.Zero, KelvinsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            Assert.False(kelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            Assert.False(kelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(TemperatureUnit.Undefined, Temperature.Units);
        }
    }
}

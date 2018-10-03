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
    /// Test of ThermalResistance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ThermalResistanceTestsBase
    {
        protected abstract double HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double HourSquareFeetDegreesFahrenheitPerBtuTolerance { get { return 1e-5; } }
        protected virtual double SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance { get { return 1e-5; } }
        protected virtual double SquareCentimeterKelvinsPerWattTolerance { get { return 1e-5; } }
        protected virtual double SquareMeterDegreesCelsiusPerWattTolerance { get { return 1e-5; } }
        protected virtual double SquareMeterKelvinsPerKilowattTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalResistance((double)0.0, ThermalResistanceUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalResistance(double.PositiveInfinity, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt));
            Assert.Throws<ArgumentException>(() => new ThermalResistance(double.NegativeInfinity, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalResistance(double.NaN, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt));
        }

        [Fact]
        public void SquareMeterKelvinPerKilowattToThermalResistanceUnits()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.HourSquareFeetDegreesFahrenheitPerBtu, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareCentimeterHourDegreesCelsiusPerKilocalorie, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareCentimeterKelvinsPerWatt, SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareMeterDegreesCelsiusPerWatt, SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ThermalResistance.From(1, ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu).HourSquareFeetDegreesFahrenheitPerBtu, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.From(1, ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie).SquareCentimeterHourDegreesCelsiusPerKilocalorie, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.From(1, ThermalResistanceUnit.SquareCentimeterKelvinPerWatt).SquareCentimeterKelvinsPerWatt, SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.From(1, ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt).SquareMeterDegreesCelsiusPerWatt, SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.From(1, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void FromSquareMeterKelvinsPerKilowatt_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThermalResistance.FromSquareMeterKelvinsPerKilowatt(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ThermalResistance.FromSquareMeterKelvinsPerKilowatt(double.NegativeInfinity));
        }

        [Fact]
        public void FromSquareMeterKelvinsPerKilowatt_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThermalResistance.FromSquareMeterKelvinsPerKilowatt(double.NaN));
        }

        [Fact]
        public void As()
        {
            var squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu), HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie), SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt), SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt), SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt), SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);

            var hoursquarefeetdegreefahrenheitperbtuQuantity = squaremeterkelvinperkilowatt.ToUnit(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu);
            AssertEx.EqualTolerance(HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt, (double)hoursquarefeetdegreefahrenheitperbtuQuantity.Value, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            Assert.Equal(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu, hoursquarefeetdegreefahrenheitperbtuQuantity.Unit);

            var squarecentimeterhourdegreecelsiusperkilocalorieQuantity = squaremeterkelvinperkilowatt.ToUnit(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie);
            AssertEx.EqualTolerance(SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt, (double)squarecentimeterhourdegreecelsiusperkilocalorieQuantity.Value, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie, squarecentimeterhourdegreecelsiusperkilocalorieQuantity.Unit);

            var squarecentimeterkelvinperwattQuantity = squaremeterkelvinperkilowatt.ToUnit(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);
            AssertEx.EqualTolerance(SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt, (double)squarecentimeterkelvinperwattQuantity.Value, SquareCentimeterKelvinsPerWattTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt, squarecentimeterkelvinperwattQuantity.Unit);

            var squaremeterdegreecelsiusperwattQuantity = squaremeterkelvinperkilowatt.ToUnit(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt);
            AssertEx.EqualTolerance(SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt, (double)squaremeterdegreecelsiusperwattQuantity.Value, SquareMeterDegreesCelsiusPerWattTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt, squaremeterdegreecelsiusperwattQuantity.Unit);

            var squaremeterkelvinperkilowattQuantity = squaremeterkelvinperkilowatt.ToUnit(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt);
            AssertEx.EqualTolerance(SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt, (double)squaremeterkelvinperkilowattQuantity.Value, SquareMeterKelvinsPerKilowattTolerance);
            Assert.Equal(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowattQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(1, ThermalResistance.FromHourSquareFeetDegreesFahrenheitPerBtu(squaremeterkelvinperkilowatt.HourSquareFeetDegreesFahrenheitPerBtu).SquareMeterKelvinsPerKilowatt, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(squaremeterkelvinperkilowatt.SquareCentimeterHourDegreesCelsiusPerKilocalorie).SquareMeterKelvinsPerKilowatt, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareCentimeterKelvinsPerWatt(squaremeterkelvinperkilowatt.SquareCentimeterKelvinsPerWatt).SquareMeterKelvinsPerKilowatt, SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareMeterDegreesCelsiusPerWatt(squaremeterkelvinperkilowatt.SquareMeterDegreesCelsiusPerWatt).SquareMeterKelvinsPerKilowatt, SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareMeterKelvinsPerKilowatt(squaremeterkelvinperkilowatt.SquareMeterKelvinsPerKilowatt).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ThermalResistance v = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(-1, -v.SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, (ThermalResistance.FromSquareMeterKelvinsPerKilowatt(3)-v).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, (v + v).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(10, (v*10).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(10, (10*v).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, (ThermalResistance.FromSquareMeterKelvinsPerKilowatt(10)/5).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, ThermalResistance.FromSquareMeterKelvinsPerKilowatt(10)/ThermalResistance.FromSquareMeterKelvinsPerKilowatt(5), SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ThermalResistance oneSquareMeterKelvinPerKilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            ThermalResistance twoSquareMeterKelvinsPerKilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(2);

            Assert.True(oneSquareMeterKelvinPerKilowatt < twoSquareMeterKelvinsPerKilowatt);
            Assert.True(oneSquareMeterKelvinPerKilowatt <= twoSquareMeterKelvinsPerKilowatt);
            Assert.True(twoSquareMeterKelvinsPerKilowatt > oneSquareMeterKelvinPerKilowatt);
            Assert.True(twoSquareMeterKelvinsPerKilowatt >= oneSquareMeterKelvinPerKilowatt);

            Assert.False(oneSquareMeterKelvinPerKilowatt > twoSquareMeterKelvinsPerKilowatt);
            Assert.False(oneSquareMeterKelvinPerKilowatt >= twoSquareMeterKelvinsPerKilowatt);
            Assert.False(twoSquareMeterKelvinsPerKilowatt < oneSquareMeterKelvinPerKilowatt);
            Assert.False(twoSquareMeterKelvinsPerKilowatt <= oneSquareMeterKelvinPerKilowatt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.Equal(0, squaremeterkelvinperkilowatt.CompareTo(squaremeterkelvinperkilowatt));
            Assert.True(squaremeterkelvinperkilowatt.CompareTo(ThermalResistance.Zero) > 0);
            Assert.True(ThermalResistance.Zero.CompareTo(squaremeterkelvinperkilowatt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.Throws<ArgumentException>(() => squaremeterkelvinperkilowatt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.Throws<ArgumentNullException>(() => squaremeterkelvinperkilowatt.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ThermalResistance v = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.True(v.Equals(ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1), SquareMeterKelvinsPerKilowattTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ThermalResistance.Zero, SquareMeterKelvinsPerKilowattTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.False(squaremeterkelvinperkilowatt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.False(squaremeterkelvinperkilowatt.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ThermalResistanceUnit.Undefined, ThermalResistance.Units);
        }
    }
}

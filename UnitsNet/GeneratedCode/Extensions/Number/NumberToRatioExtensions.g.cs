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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToRatio
{
    public static class NumberToRatioExtensions
    {
        #region DecimalFraction

        /// <inheritdoc cref="Ratio.FromDecimalFractions(UnitsNet.QuantityValue)" />
        public static Ratio DecimalFractions(this int value) => Ratio.FromDecimalFractions(value);

        /// <inheritdoc cref="Ratio.FromDecimalFractions(UnitsNet.QuantityValue)" />
        public static Ratio? DecimalFractions(this int? value) => Ratio.FromDecimalFractions(value);

        /// <inheritdoc cref="Ratio.FromDecimalFractions(UnitsNet.QuantityValue)" />
        public static Ratio DecimalFractions(this long value) => Ratio.FromDecimalFractions(value);

        /// <inheritdoc cref="Ratio.FromDecimalFractions(UnitsNet.QuantityValue)" />
        public static Ratio? DecimalFractions(this long? value) => Ratio.FromDecimalFractions(value);

        /// <inheritdoc cref="Ratio.FromDecimalFractions(UnitsNet.QuantityValue)" />
        public static Ratio DecimalFractions(this double value) => Ratio.FromDecimalFractions(value);

        /// <inheritdoc cref="Ratio.FromDecimalFractions(UnitsNet.QuantityValue)" />
        public static Ratio? DecimalFractions(this double? value) => Ratio.FromDecimalFractions(value);

        /// <inheritdoc cref="Ratio.FromDecimalFractions(UnitsNet.QuantityValue)" />
        public static Ratio DecimalFractions(this float value) => Ratio.FromDecimalFractions(value);

        /// <inheritdoc cref="Ratio.FromDecimalFractions(UnitsNet.QuantityValue)" />
        public static Ratio? DecimalFractions(this float? value) => Ratio.FromDecimalFractions(value);

        /// <inheritdoc cref="Ratio.FromDecimalFractions(UnitsNet.QuantityValue)" />
        public static Ratio DecimalFractions(this decimal value) => Ratio.FromDecimalFractions(Convert.ToDouble(value));

        /// <inheritdoc cref="Ratio.FromDecimalFractions(UnitsNet.QuantityValue)" />
        public static Ratio? DecimalFractions(this decimal? value) => Ratio.FromDecimalFractions(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PartPerBillion

        /// <inheritdoc cref="Ratio.FromPartsPerBillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerBillion(this int value) => Ratio.FromPartsPerBillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerBillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerBillion(this int? value) => Ratio.FromPartsPerBillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerBillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerBillion(this long value) => Ratio.FromPartsPerBillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerBillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerBillion(this long? value) => Ratio.FromPartsPerBillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerBillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerBillion(this double value) => Ratio.FromPartsPerBillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerBillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerBillion(this double? value) => Ratio.FromPartsPerBillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerBillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerBillion(this float value) => Ratio.FromPartsPerBillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerBillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerBillion(this float? value) => Ratio.FromPartsPerBillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerBillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerBillion(this decimal value) => Ratio.FromPartsPerBillion(Convert.ToDouble(value));

        /// <inheritdoc cref="Ratio.FromPartsPerBillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerBillion(this decimal? value) => Ratio.FromPartsPerBillion(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PartPerMillion

        /// <inheritdoc cref="Ratio.FromPartsPerMillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerMillion(this int value) => Ratio.FromPartsPerMillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerMillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerMillion(this int? value) => Ratio.FromPartsPerMillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerMillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerMillion(this long value) => Ratio.FromPartsPerMillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerMillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerMillion(this long? value) => Ratio.FromPartsPerMillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerMillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerMillion(this double value) => Ratio.FromPartsPerMillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerMillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerMillion(this double? value) => Ratio.FromPartsPerMillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerMillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerMillion(this float value) => Ratio.FromPartsPerMillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerMillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerMillion(this float? value) => Ratio.FromPartsPerMillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerMillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerMillion(this decimal value) => Ratio.FromPartsPerMillion(Convert.ToDouble(value));

        /// <inheritdoc cref="Ratio.FromPartsPerMillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerMillion(this decimal? value) => Ratio.FromPartsPerMillion(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PartPerThousand

        /// <inheritdoc cref="Ratio.FromPartsPerThousand(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerThousand(this int value) => Ratio.FromPartsPerThousand(value);

        /// <inheritdoc cref="Ratio.FromPartsPerThousand(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerThousand(this int? value) => Ratio.FromPartsPerThousand(value);

        /// <inheritdoc cref="Ratio.FromPartsPerThousand(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerThousand(this long value) => Ratio.FromPartsPerThousand(value);

        /// <inheritdoc cref="Ratio.FromPartsPerThousand(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerThousand(this long? value) => Ratio.FromPartsPerThousand(value);

        /// <inheritdoc cref="Ratio.FromPartsPerThousand(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerThousand(this double value) => Ratio.FromPartsPerThousand(value);

        /// <inheritdoc cref="Ratio.FromPartsPerThousand(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerThousand(this double? value) => Ratio.FromPartsPerThousand(value);

        /// <inheritdoc cref="Ratio.FromPartsPerThousand(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerThousand(this float value) => Ratio.FromPartsPerThousand(value);

        /// <inheritdoc cref="Ratio.FromPartsPerThousand(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerThousand(this float? value) => Ratio.FromPartsPerThousand(value);

        /// <inheritdoc cref="Ratio.FromPartsPerThousand(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerThousand(this decimal value) => Ratio.FromPartsPerThousand(Convert.ToDouble(value));

        /// <inheritdoc cref="Ratio.FromPartsPerThousand(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerThousand(this decimal? value) => Ratio.FromPartsPerThousand(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PartPerTrillion

        /// <inheritdoc cref="Ratio.FromPartsPerTrillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerTrillion(this int value) => Ratio.FromPartsPerTrillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerTrillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerTrillion(this int? value) => Ratio.FromPartsPerTrillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerTrillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerTrillion(this long value) => Ratio.FromPartsPerTrillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerTrillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerTrillion(this long? value) => Ratio.FromPartsPerTrillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerTrillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerTrillion(this double value) => Ratio.FromPartsPerTrillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerTrillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerTrillion(this double? value) => Ratio.FromPartsPerTrillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerTrillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerTrillion(this float value) => Ratio.FromPartsPerTrillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerTrillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerTrillion(this float? value) => Ratio.FromPartsPerTrillion(value);

        /// <inheritdoc cref="Ratio.FromPartsPerTrillion(UnitsNet.QuantityValue)" />
        public static Ratio PartsPerTrillion(this decimal value) => Ratio.FromPartsPerTrillion(Convert.ToDouble(value));

        /// <inheritdoc cref="Ratio.FromPartsPerTrillion(UnitsNet.QuantityValue)" />
        public static Ratio? PartsPerTrillion(this decimal? value) => Ratio.FromPartsPerTrillion(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Percent

        /// <inheritdoc cref="Ratio.FromPercent(UnitsNet.QuantityValue)" />
        public static Ratio Percent(this int value) => Ratio.FromPercent(value);

        /// <inheritdoc cref="Ratio.FromPercent(UnitsNet.QuantityValue)" />
        public static Ratio? Percent(this int? value) => Ratio.FromPercent(value);

        /// <inheritdoc cref="Ratio.FromPercent(UnitsNet.QuantityValue)" />
        public static Ratio Percent(this long value) => Ratio.FromPercent(value);

        /// <inheritdoc cref="Ratio.FromPercent(UnitsNet.QuantityValue)" />
        public static Ratio? Percent(this long? value) => Ratio.FromPercent(value);

        /// <inheritdoc cref="Ratio.FromPercent(UnitsNet.QuantityValue)" />
        public static Ratio Percent(this double value) => Ratio.FromPercent(value);

        /// <inheritdoc cref="Ratio.FromPercent(UnitsNet.QuantityValue)" />
        public static Ratio? Percent(this double? value) => Ratio.FromPercent(value);

        /// <inheritdoc cref="Ratio.FromPercent(UnitsNet.QuantityValue)" />
        public static Ratio Percent(this float value) => Ratio.FromPercent(value);

        /// <inheritdoc cref="Ratio.FromPercent(UnitsNet.QuantityValue)" />
        public static Ratio? Percent(this float? value) => Ratio.FromPercent(value);

        /// <inheritdoc cref="Ratio.FromPercent(UnitsNet.QuantityValue)" />
        public static Ratio Percent(this decimal value) => Ratio.FromPercent(Convert.ToDouble(value));

        /// <inheritdoc cref="Ratio.FromPercent(UnitsNet.QuantityValue)" />
        public static Ratio? Percent(this decimal? value) => Ratio.FromPercent(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif

using System;
using System.Globalization;

namespace Nesur.Core.Util {
    public class NumberUtils {
        private static readonly string[] Suffixes = { "", "k", "M", "B", "T", "Qa", "Qi" };

        private static string FormatShort(double value, int decimals = 1) {
            if (double.IsNaN(value) || double.IsInfinity(value)) return "0";

            double absValue = Math.Abs(value);
            if (absValue < 1000)
                return Math.Floor(value).ToString("0", CultureInfo.InvariantCulture);

            int suffixIndex = 0;
            while (absValue >= 1000 && suffixIndex < Suffixes.Length - 1) {
                value /= 1000;
                absValue /= 1000;
                suffixIndex++;
            }

            string format = "0";
            if (decimals > 0) format += "." + new string('#', decimals);

            return value.ToString(format, CultureInfo.InvariantCulture) + Suffixes[suffixIndex];
        }
    }
}
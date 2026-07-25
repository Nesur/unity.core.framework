using System;

namespace Nesur.Core.Util {
    public abstract class DateUtil {
        public static DateTime FromTicks(long ticks) {
            return new DateTime(ticks);
        }

        public static DateTime FromTicksUtc(long ticks) {
            return new DateTime(ticks, DateTimeKind.Utc);
        }

        /// <summary>
        /// Formats a time duration, given in seconds, into a string using the format "hh:mm:ss".
        /// </summary>
        /// <param name="seconds">The total time duration in seconds to be formatted.</param>
        /// <returns>A string representation of the time duration in the format "hh:mm:ss".</returns>
        public static string FormatDateFromSeconds(double seconds) {
            return TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        }
    }
}
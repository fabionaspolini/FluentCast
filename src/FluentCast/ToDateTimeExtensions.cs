using System;

namespace FluentCast
{
    public static class ToDateTimeExtensions
    {
        public static DateTime ToDateTime(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToDateTime(v, provider ?? GlobalSettings.Properties.DateTimeCulture));

        public static DateTime? ToDateTimeSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToDateTime(value, provider ?? GlobalSettings.Properties.DateTimeCulture));

        public static DateTime ToDateTimeSafe(this object value, DateTime @default, IFormatProvider provider = null) =>
            value.ToDateTimeSafe(provider) ?? @default;
    }
}
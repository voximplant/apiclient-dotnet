using System.Globalization;
using Newtonsoft.Json.Converters;

namespace Voximplant.API
{
    public class TimestampConverter : IsoDateTimeConverter
    {
        public TimestampConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            base.DateTimeStyles = DateTimeStyles.AssumeUniversal;
        }
    }
}
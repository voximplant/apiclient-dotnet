using Newtonsoft.Json.Converters;

namespace Voximplant.API
{
    public class TimestampConverter : IsoDateTimeConverter
    {
        public TimestampConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        }
    }
}
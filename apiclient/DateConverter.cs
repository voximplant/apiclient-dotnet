using System.Globalization;
using Newtonsoft.Json.Converters;

namespace Voximplant.API
{
    public class DateConverter : IsoDateTimeConverter
    {
        public DateConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
            base.DateTimeStyles = DateTimeStyles.AssumeUniversal;
        }
    }
}
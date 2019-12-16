using System;

namespace Voximplant.API
{
    public class DateTimeFormatAttribute : Attribute
    {
        public readonly string Format;

        public DateTimeFormatAttribute(string format)
        {
            Format = format;
        }
    }
}
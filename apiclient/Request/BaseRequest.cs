using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Voximplant.API.Request
{
    public abstract class BaseRequest : IEnumerable<KeyValuePair<string, string>>
    {
        private long _accountId;

        internal void SetAccountId(long accountId)
        {
            _accountId = accountId;
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            var serializedRequest = new Dictionary<string, string> { ["account_id"] = _accountId.ToString() };

            foreach (var field in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(info =>
                info.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Length > 0))
            {
                var value = field.GetValue(this);
                var key = field.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName;
                if (key == null || value == null) continue;
                switch (value)
                {
                    case DateTime date:
                    {
                        var format = field.GetCustomAttribute<DateTimeFormatAttribute>()?.Format;
                        serializedRequest[key] = date.ToString(format);
                        break;
                    }
                    case bool boolValue:
                        serializedRequest[key] = boolValue ? "1" : "0";
                        break;
                    default:
                        serializedRequest[key] = value.ToString();
                        break;
                }
            }

            return serializedRequest.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
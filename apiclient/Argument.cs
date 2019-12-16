using System.Collections.Generic;

namespace Voximplant.API
{
    public class Argument<T>
    {
        private readonly List<T> _values;
        private readonly bool _any;

        public override string ToString()
        {
            if (_any) return "all";
            return _values == null ? "" : string.Join(";", _values);
        }

        public Argument(params T[] values)
        {
            _values = new List<T>(values);
        }

        public Argument(IEnumerable<T> values)
        {
            _values = new List<T>(values);
        }

        public Argument(T value)
        {
            _values = new List<T> { value };
        }

        public Argument()
        {
            _any = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Resource
    {
        public int SomeIntProp { get; set; }
        public bool SomeBoolProp { get; set; }
        public string SomeStringProp { get; set; }

        public Resource() { }

        public override string ToString()
        {
            string result = string.Empty;
            result += $"SomeIntProp: {SomeIntProp}, ";
            result += $"SomeBoolProp: {SomeBoolProp}, ";
            result += $"SomeStringProp: {SomeStringProp}";
            return result;
        }
    }
}

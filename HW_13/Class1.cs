using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13
{
    public class Class1
    {
        public Action<bool>? DelegateForShowMethod { get; set; }

        public int Multiply(int value1, int value2) => value1 * value2;
    }
}

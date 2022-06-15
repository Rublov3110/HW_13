using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13
{
    public class Class2
    {
        private int ResultValue { get; set; }

        public Predicate<int> Calc(Func<int, int, int> delegateForMultipleMethod, int value1, int value2)
        {
            ResultValue = delegateForMultipleMethod(value1, value2);

            return new Predicate<int>(Result);
        }

        public bool Result(int value)
        {
            return ResultValue % value == 0;
        }
    }
}

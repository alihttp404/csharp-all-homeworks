using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point__Counter__Fraction
{
    internal class Counter
    {
        public int? Min { get; set; }
        public int? Max { get; set; } 
        public int? Curr { get; set; }

        public Counter()
        {
            Min = 0;
            Max = 100;
            Curr = 0;
        }

        public Counter(int? min, int? max)
        {
            Min = min;
            Max = max;
        }

        public Counter(int? min, int? max, int? curr)
        {
            Min = min;
            Max = max;
            Curr = curr;
        }

        public void increment()
        {
            if (Curr < Max) Curr++;
            else Curr = 0;
        }

        public void decrement() { if (Curr > Min) Curr--; }
    }
}

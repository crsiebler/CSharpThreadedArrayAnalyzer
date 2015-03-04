using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberArrayAnalyzer
{
    class NumberStatistics
    {
        private int oddCount, evenCount, zeroCount;

        public NumberStatistics()
        {
            oddCount = 0;
            evenCount = 0;
            zeroCount = 0;
        }

        public void incrementOddCount()
        {
            oddCount++;
        }

        public void incrementEvenCount()
        {
            evenCount++;
        }

        public void incrementZeroCount()
        {
            zeroCount++;
        }

        public void displayStatistics()
        {
            Console.WriteLine("Even Count : " + evenCount);
            Console.WriteLine("Odd Count  : " + oddCount);
            Console.WriteLine("Zero Count : " + zeroCount);
        }
    }
}
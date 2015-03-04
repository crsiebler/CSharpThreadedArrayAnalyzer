using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NumberArrayAnalyzer
{
    //delegate that can be used to define references to void non parameter taking methods
    public delegate void stringDelegate();

    class Program
    {
        // Create three event objects
        public static event stringDelegate oddEvent;
        public static event stringDelegate evenEvent;
        public static event stringDelegate zeroEvent;

        private static int[] nums;

        private static void initArray()
        {
            int Min = 0;
            int Max = 99;

            nums = new int[50];

            Random randNum = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = randNum.Next(Min, Max);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME: Program Started");
            Console.WriteLine("INITIALIZING: Random Array");

            initArray();

            Console.WriteLine("SUCCESS: Array Initialized");

            NumberStatistics ns = new NumberStatistics();

            Console.WriteLine("CREATING: Event Delegates");

            // Register methods in events
            oddEvent += new stringDelegate(ns.incrementOddCount);
            evenEvent += new stringDelegate(ns.incrementEvenCount);
            zeroEvent += new stringDelegate(ns.incrementZeroCount);

            Console.WriteLine("COMPLETE: Event Delegates Created");
            Console.WriteLine("STARTING: Number Array Analysis");

            for (int i = 0; i < nums.Length; ++i)
            {
                Console.WriteLine("ANALYING: Index (" + i + ") - Number (" + nums[i] + ")");

                if (nums[i] == 0)
                {
                    Console.WriteLine("FOUND: Zero");
                    zeroEvent();
                }
                else if (nums[i] % 2 == 0)
                {
                    Console.WriteLine("FOUND: Even");
                    evenEvent();
                }
                else
                {
                    Console.WriteLine("FOUND: Odd");
                    oddEvent();
                }
            }

            ns.displayStatistics();
            Console.ReadLine();
        }
    }
}

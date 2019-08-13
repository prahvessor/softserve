using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIO
{
    public class Terminal
    {
        public static void Print(int[] customArray, int minIndex, int maxIndex)
        {
            Console.WriteLine("  Minimal element is customArray[{0}]={1}", minIndex, customArray[minIndex]);
            Console.WriteLine("  Maximal element is customArray[{0}]={1}", maxIndex, customArray[maxIndex]);
        }

        public static string Input()
        {
            return Console.ReadLine();
        }
    }
}

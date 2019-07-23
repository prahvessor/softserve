using System;
using System.Collections.Generic;
using System.Text;

namespace Statistic
{
    class Statistic
    {
        public static int GetMinIndexByFor(int[] customArray)
        {
            int min = customArray[0];
            int index = 0;
            for (int i = 1; i < customArray.Length; i++)
            {
                if (min > customArray[i])
                {
                    min = customArray[i];
                    index = i;
                }
            }
            return index;
        }

        public static int GetMaxIndexByFor(int[] customArray)
        {
            int max = customArray[0];
            int index = 0;
            for (int i = 1; i < customArray.Length; i++)
            {
                if (max < customArray[i])
                {
                    max = customArray[i];
                    index = i;
                }
            }
            return index;
        }

        public static int GetMinIndexByWhile(int[] customArray)
        {
            int min = customArray[0];
            int index = 0;
            int i = 0;
            while (i < customArray.Length)
            {
                if (min > customArray[i])
                {
                    min = customArray[i];
                    index = i;
                }
                i++;
            }
            return index;
        }

        public static int GetMaxIndexByWhile(int[] customArray)
        {
            int max = customArray[0];
            int index = 0;
            int i = 0;
            while (i < customArray.Length)
            {
                if (max < customArray[i])
                {
                    max = customArray[i];
                    index = i;
                }
                i++;
            }
            return index;
        }

        public static int GetMinIndexByDo(int[] customArray)
        {
            int min = customArray[0];
            int index = 0;
            int i = 0;
            do
            {
                if (min > customArray[i])
                {
                    min = customArray[i];
                    index = i;
                }
                i++;
            } while (i < customArray.Length);
            return index;
        }

        public static int GetMaxIndexByDo(int[] customArray)
        {
            int max = customArray[0];
            int index = 0;
            int i = 0;
            do
            {
                if (max < customArray[i])
                {
                    max = customArray[i];
                    index = i;
                }
                i++;
            } while (i < customArray.Length);
            return index;
        }

        public static void Print(int[] customArray, int minIndex, int maxIndex)
        {
            Console.WriteLine("  Minimal element is customArray[{0}]={1}", minIndex, customArray[minIndex]);
            Console.WriteLine("  Maximal element is customArray[{0}]={1}", maxIndex, customArray[maxIndex]);
        }
    }
}

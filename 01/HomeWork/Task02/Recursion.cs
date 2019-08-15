using System;

namespace Task02
{
    class Recursion
    {
        public static void Main(string[] args)
        {
            Recursion myRecursion = new Recursion();
            int[] customSequence = myRecursion.Initialize();
            int FirstIndex = 0;
            myRecursion.Print(customSequence, FirstIndex);
        }

        private int[] Initialize()
        {
            int itemNumber = 10;
            Random rand = new Random();
            int[] customSequence = new int[itemNumber];

            for (int i = 0; i < itemNumber; i++)
            {
                customSequence[i] = rand.Next(-100, 100);
            }

            return customSequence;
        }

        public void Print(int[] customSequence, int current = 0)
        {
            int tempIndex = current;
            int tempElement = 0;

            if (current == customSequence.Length)
            {
                return;
            }
            else
            {
                tempElement = customSequence[current];
                if (customSequence[current] < 0)
                {
                    Console.WriteLine("array[{0}]={1} ", current, customSequence[current]);
                }
                Print(customSequence, ++current);
            }

            if (tempElement > 0)
            {
                Console.WriteLine("array[{0}]={1} ", tempIndex, tempElement);
            }
        }
    }
}

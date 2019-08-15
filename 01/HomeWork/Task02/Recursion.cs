using System;

namespace Task02
{
    class Recursion
    {
        private static Random rand = new Random();
        public static void Main(string[] args)
        {
            Recursion myRecursion = new Recursion();

            int[] customSequence = myRecursion.Initialize(10, -100, 100);

            myRecursion.Print(customSequence);
        }

        private int[] Initialize(int count, int min, int max)
        {
            int[] customSequence = new int[count];

            for (int i = 0; i < count; i++)
            {
                customSequence[i] = rand.Next(min, max);
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

            tempElement = customSequence[current];
            if (customSequence[current] < 0)
            {
                Console.WriteLine("array[{0}]={1} ", current, customSequence[current]);
            }
            Print(customSequence, ++current);

            if (tempElement > 0)
            {
                Console.WriteLine("array[{0}]={1} ", tempIndex, tempElement);
            }
        }
    }
}

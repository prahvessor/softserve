using System;

namespace Statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            // Case 1. User etners number of items, after that input numbers
            int arrayLength = 0;
            Console.WriteLine("Enter array length:");
            arrayLength = int.Parse(Console.ReadLine());
            //
            Console.WriteLine("Enter numbers of array:");
            int[] customArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                customArray[i] = int.Parse(Console.ReadLine());
            }
            */
            // Case 2. User inputs line of numbers
            Console.WriteLine("Enter numbers. Use white space between numbers:");
            String text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] customArray = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                customArray[i] = int.Parse(words[i]);
            }

            // using for loop
            Console.WriteLine("Using For loop:");
            int minIndexFor = Statistic.GetMinIndexByFor(customArray);
            int maxIndexFor = Statistic.GetMaxIndexByFor(customArray);
            Statistic.Print(customArray, minIndexFor, maxIndexFor);
            
            // using while loop
            Console.WriteLine("Using While loop:");
            int minIndexWhile = Statistic.GetMinIndexByWhile(customArray);
            int maxIndexWhile = Statistic.GetMaxIndexByWhile(customArray);
            Statistic.Print(customArray, minIndexWhile, maxIndexWhile);
            
            // using do loop
            Console.WriteLine("Using Do loop:");
            int minIndexDo = Statistic.GetMinIndexByDo(customArray);
            int maxIndexDo = Statistic.GetMaxIndexByDo(customArray);
            Statistic.Print(customArray, minIndexDo, maxIndexDo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Animals = new string[5] { "Giraffe", "Kangaroo", "Crocodile", "Ostrich", "Elephant" };
            foreach (string i in Animals)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            int[] numbers = new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Array.Reverse(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

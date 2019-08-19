using System;

namespace AlgorthimsBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Chapter2.MergeSortMechanism mergeTest = new Chapter2.MergeSortMechanism();

            int[] ar = new int[] { 5, 2, 9, 7 };

            int half = (int) Math.Floor((double) ar.Length / 2);

            //Console.WriteLine(string.Join(',', mergeTest.splitArray(ar,0, half)));

            Console.WriteLine(string.Join(',', mergeTest.MergeSortIteratively(ar)));
            Console.ReadKey();
        }
    }
}

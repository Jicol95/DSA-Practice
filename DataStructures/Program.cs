using DataStructures.Sorting;
using System;

namespace DataStructures {

    public class Program {

        private static void Main(string[] args) {
            int[] ints = new int[] { 2, 5, 3, -3 };
            ints.QuickSort();
            foreach (int i in ints) {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
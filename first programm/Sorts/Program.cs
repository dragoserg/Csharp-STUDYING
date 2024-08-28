using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 6, 10, 3, 7, 12, 2, 5, 2, 3, 4, 4, 1 };

            Sorting.printArr(arr);

            Sorting.BubleSort(arr);
            Sorting.printArr(arr);
        }
    }
}

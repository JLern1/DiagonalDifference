using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = diagonalDifference(PopulateList());
            Debug.Print(result.ToString());



            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            //int result = diagonalDifference(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static List<List<int>> PopulateList()
        { 
            List<List<int>> arr = new List<List<int>>
            {
                /*new List<int> {1, 2, 3},
                new List<int> {4, 5, 6},
                new List<int> {9, 8, 9}*/

                new List<int> {11, 2, 4},
                new List<int> {4, 5, 6},
                new List<int> {10, 8, -12}

                /*new List<int>{ 6, 6, 7, -10, 9, -3, 8, 9, -1 },
                new List<int>{ 9, 7, -10, 6, 4, 1, 6, 1, 1 },
                new List<int>{ -1, -2, 4, -6, 1, -4, -6, 3, 9 },
                new List<int>{ -8, 7, 6, -1, -6, -6, 6, -7, 2 },
                new List<int>{ -10, -4, 9, 1, -7, 8, -5, 3, -5 },
                new List<int>{ -8, -3, -4, 2, -3, 7, -5, 1, -5 },
                new List<int>{ -2, -7, -4, 8, 3, -1, 8, 2, 3 },
                new List<int>{ -3, 4, 6, -7, -7, -8, -3, 9, -6 },
                new List<int>{ -2, 0, 5, 4, 4, 4, -3, 3, 0 }*/

            };

            return arr;
        }

        /*public static int diagonalDifference(List<List<int>> arr)
        {
            List<int> firstRow = arr[0];
            List<int> secondRow = arr[1];
            List<int> thirdRow = arr[2];

            int firstDiag = firstRow[0] + secondRow[1] + thirdRow[2]; //add up first, second, and third elements
            int secondDiag = firstRow[2] + secondRow[1] + thirdRow[0]; //add up third, second, and first elements

            Debug.Print(firstDiag + "  " + secondDiag);

            return Math.Abs(firstDiag - secondDiag);
        }*/

        public static int diagonalDifference(List<List<int>> arr)
        {
            int minToMaxDiagTotal = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                minToMaxDiagTotal += arr[i][i];
            }

            int maxToMinDiaTotal = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                maxToMinDiaTotal += arr[arr.Count - i - 1][i];
            }

            return Math.Abs(minToMaxDiagTotal - maxToMinDiaTotal);
        }
    }
}

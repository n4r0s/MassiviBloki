// See https://akusing System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region много блокав
            #region Блок 1
            int[] arr = { 0, 1, 32, 43, 5, 22, 1, -423, -154, 10, 55 };

            //блок 1
            int dobavit = 10;
            int[] noviyarr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                noviyarr[i] = arr[i];
            }

            noviyarr[arr.Length] = dobavit;
            arr = noviyarr;
            #endregion
            #region Блок 2
            //блок 2
            dobavit = 10;
            noviyarr = new int[arr.Length + 1];

            for (int i = 1; i <= arr.Length; i++)
            {
                noviyarr[i] = arr[i - 1];
            }

            noviyarr[0] = dobavit;
            arr = noviyarr;
            #endregion
            #region Блок 3
            //блок 3

            dobavit = 10;
            int position = 4;
            noviyarr = new int[arr.Length + 1];

            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i == position)
                    continue;

                noviyarr[i] = arr[j];
                j++;
            }

            noviyarr[position] = dobavit;
            arr = noviyarr;
            #endregion
            #region Блок 4
            //блок 4
            int[] small = new int[arr.Length - 1];

            for (int i = 0; i < small.Length; i++)
            {
                small[i] = arr[i];
            }

            arr = small;
            #endregion
            #region Блок 5
            //блок 5
            small = new int[arr.Length - 1];

            for (int i = 1; i <= small.Length; i++)
            {
                small[i - 1] = arr[i];
            }

            arr = small;
            #endregion
            #region Блок 6
            //блок 6
            small = new int[arr.Length - 1];
            int pos = 5;

            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i == pos)
                    continue;

                small[j] = arr[i];
                j++;
            }
            #endregion
            #region Блок 7
            //блок 7
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            int[][] toM = { arr1, arr2 };

            int[] res = new int[arr1.Length + arr2.Length];

            for (int i = 0, j = 0; i < toM.Length; i++)
            {
                for (int k = 0; k < toM[i].Length; k++)
                {
                    res[j] = toM[i][k];
                    j++;
                }
            }
            #endregion
            #endregion
            #region непомню

            Console.WriteLine("колво чисел:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("числа:");
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
            int index = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] == 100)
                {
                    index = i + 1;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("нету.");
            }
            else
            {
                Console.WriteLine($"тута {index}.");
            }
            #endregion
        }
    }

}

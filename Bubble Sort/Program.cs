using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static int Loops = 0;
        static int Swaps = 0;
        static int sort = 0;
        static void Main(string[] args)
        {


            /* int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 }; */

            int[] arrayToSort = {14, 65, 63, 1, 54, 89, 84, 9, 98, 57,
            71, 18, 21, 84, 69, 28, 11, 83, 13, 42,
            64, 58, 78, 82, 13, 9, 96, 14, 39, 89, 40, 32, 51, 85, 48, 40, 23, 15, 94, 93,
            35, 81, 1, 9, 43, 39, 15, 17, 97, 52};

            for (int i = 0; i < arrayToSort.Length; i++)
            {

                Console.Write(" " + arrayToSort[i] + " ");
            }

            CocktailShakerShort(arrayToSort);



            Console.WriteLine("");
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(" " + arrayToSort[i] + " ");

            }
            Console.WriteLine("");
            Console.WriteLine("Loops: " + Loops);
            Console.WriteLine("Swaps: " + Swaps);
            Console.ReadKey();







        }
        public static void BubbleSort(int[] arrayToSort)
        {
            bool sorting = false;
            while (!sorting)
            {
                sorting = true;
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {

                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        sort = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = sort;
                        sorting = false;
                        Swaps++;
                    }




                    Loops++;



                }
            }
        }


        public static void OptimizedBubbleSort(int[] arrayToSort)
        {
            bool sorting = false;
            int length = arrayToSort.Length - 1;
            while (!sorting)
            {
                sorting = true;
                for (int i = 0; i < length; i++)
                {

                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        sort = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = sort;
                        sorting = false;
                        Swaps++;
                    }




                    Loops++;



                }
                length--;
            }

        }
        public static void CocktailShakerShort(int[] arrayToSort)
        {
            {
                bool sorting = false;
                int length = arrayToSort.Length - 1;
                int start = 0;
                while (!sorting)
                {
                    sorting = true;
                    for (int i = start; i < length; i++)
                    {

                        if (arrayToSort[i] > arrayToSort[i + 1])
                        {
                            sort = arrayToSort[i];
                            arrayToSort[i] = arrayToSort[i + 1];
                            arrayToSort[i + 1] = sort;
                            sorting = false;
                            Swaps++;
                        }
                        



                            Loops++;



                    }
                    length--;
                    for (int i = length; i > start; i--)
                    {

                        if (arrayToSort[i] < arrayToSort[i - 1])
                        {
                            sort = arrayToSort[i];
                            arrayToSort[i] = arrayToSort[i - 1];
                            arrayToSort[i - 1] = sort;
                            sorting = false;
                            Swaps++;
                        }
                        Loops++;
                        
                    }
                    start++;



                }
            }
        }
    }
    }

 


using System;
using System.Collections.Generic;

namespace QuickSort_Remasterizado
{
    class Program
    {
        public static int comps = 0;
        public static int iters = 0;
        public static int inter = 0;
        static void Main(string[] args)
        {
            Console.Write("Size: ");
            int size = int.Parse(Console.ReadLine());
            List <int> lista = llenarLista(size);
            /*Console.WriteLine("---------- Lista de datos ----------");
            Console.WriteLine("**** Original ****");
            mostrar(lista);*/
            List <int> sortedQs = QuickSort(lista);
            /*Console.WriteLine("**** Ordenada ****");
            mostrar(sortedQs);*/
            Console.WriteLine("Comparaciones: " + comps);
            Console.WriteLine("Iteraciones: " + iters);
            Console.WriteLine("Intercambios: " + inter);
        }

        static List<int> llenarLista(int size)
        {
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Add(r.Next(0, size));
            }
            //List<int> list = new List<int> { 5, 7, 3, 4, 6, 9 };
            return list;
        }

        static List<int> QuickSort(List<int> numArray)
        {
            comps++;
            if (numArray.Count == 1)
            {
                return new List<int> { numArray[0] };
            }
            else if (numArray.Count == 2)
            {
                comps++;
                if (numArray[0] <= numArray[1])
                {
                    inter++;
                    return new List<int>() { numArray[0], numArray[1] };
                }
                else
                {
                    inter++;
                    return new List<int>() { numArray[1], numArray[0] };
                }
            }
            else if (numArray.Count > 2)
            {
                int pivotIndex = (int)Math.Floor(numArray.Count / 2.0);
                int pivot = numArray[pivotIndex];
                List<int> leftArray = new();
                List<int> rightArray = new();

                for (int i = 0; i < numArray.Count; i++)
                {
                    iters++;

                    comps++;
                    if (i == pivotIndex) continue;

                    comps++;
                    if (numArray[i] <= pivot)
                    {
                        inter++;
                        leftArray.Add(numArray[i]);
                    }
                    else
                    {
                        inter++;
                        rightArray.Add(numArray[i]);
                    }
                }

                List<int> sortedArray = new();
                sortedArray.AddRange(QuickSort(leftArray));
                sortedArray.Add(pivot);
                sortedArray.AddRange(QuickSort(rightArray));
                return sortedArray;
            }
            else
            {
                return new List<int>();
            }
        }

        public static void mostrar(List <int> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

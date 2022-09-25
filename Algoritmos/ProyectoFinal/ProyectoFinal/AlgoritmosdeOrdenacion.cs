using System;
using System.Collections.Generic;

namespace ProyectoFinal
{
    class AlgoritmosdeOrdenacion
    {
        public int comps = 0;
        public int iters = 0;
        public int inter = 0;
        public int aux = 0;

        public List<int> RandomList(int size){
            List<int> list = new List<int>();
            Random rndm = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Add(rndm.Next(0, 1000));
            }
            return list;
        }

        public List<int> burbuja(List<int> numArray)
        {
            //int aux = 0;
            for (int j = 0; j < numArray.Count; j++)
            {
                for (int i = 0; i < numArray.Count - 1 - j; i++)
                {
                    comps++;
                    if (numArray[i] > numArray[i + 1])
                    {
                        inter++;
                        aux = numArray[i];
                        numArray[i] = numArray[i + 1];
                        numArray[i + 1] = aux;
                    }
                }
            }
            return numArray;
        }

        public List<int> burbujaBandera(List<int> numArray)
        {
            Boolean Bandera;
            for (int j = 0; j < numArray.Count; j++)
            {
                Bandera = false;
                for (int i = 0; i < numArray.Count - 1 - j; i++)
                {
                    comps++;
                    if (numArray[i] > numArray[i + 1])
                    {
                        aux = numArray[i];
                        numArray[i] = numArray[i + 1];
                        numArray[i + 1] = aux;
                        inter++;
                        Bandera = true;
                    }
                }
                if (Bandera == false)
                {
                    break;
                }
            }
            return numArray;
        }

        public List<int> intercambio(List<int> numArray)
        {
            for (int i = 0; i < numArray.Count - 1; i++)
            {
                for (int j = i + 1; j < numArray.Count; j++)
                {
                    comps++;
                    if (numArray[i] > numArray[j])
                    {
                        aux = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = aux;
                        inter++;
                    }
                }
            }
            return numArray;
        }

        public List<int> insercion(List<int> numArray)
        {
            int i, j, actual = 0;
            for (i = 1; i < numArray.Count; i++)
            {
                actual = numArray[i];
                for (j = i; j > 0 && numArray[j - 1] > actual; j--)
                {
                    numArray[j] = numArray[j - 1];
                    inter++;
                    comps++;
                }
                numArray[j] = actual;
                comps++;
            }
            return numArray;
        }

        public List<int> seleccion(List<int> numArray)
        {
            int i, j;
            int menor;
            int cambio = 0;
            for (i = 0; i < numArray.Count; i++)
            {
                menor = numArray[i];
                for (j = i + 1; j < numArray.Count; j++)
                {

                    if (numArray[j] < menor)
                    {
                        menor = numArray[j];
                        cambio = j;
                    }
                    comps++;
                }
                if (numArray[i] != menor)
                {
                    aux = numArray[i];
                    numArray[i] = menor;
                    numArray[cambio] = aux;
                    inter++;
                }
            }
            return numArray;
        }

        public List<int> shell(List<int> numArray)
        {
            int mitad = 0;
            bool ejecutar = false;
            int x = 0;
            mitad = numArray.Count / 2;
            while (mitad > 0)
            {
                ejecutar = true;
                while (ejecutar)
                {
                    ejecutar = false;
                    x = 1;
                    while (x <= (numArray.Count - mitad))
                    {
                        comps++;
                        if (numArray[x - 1] > numArray[(x - 1) + mitad])
                        {
                            inter++;
                            aux = numArray[(x - 1) + mitad];
                            numArray[(x - 1) + mitad] = numArray[x - 1];
                            numArray[(x - 1)] = aux;
                            ejecutar = true;
                        }
                        x++;
                    }
                }
                mitad = mitad / 2;
            }
            return numArray;
        }

        public List<int> QuickSort(List<int> numArray)
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
                    return new List<int>() { numArray[0], numArray[1] };
                }
                else
                {
                    return new List<int>() { numArray[1], numArray[0] };
                }
            }
            else if (numArray.Count > 2)
            {
                int pivotIndex = (int)Math.Floor(numArray.Count / 2.0);
                int pivot = numArray[pivotIndex];
                List<int> leftArray = new List<int>();
                List<int> rightArray = new List<int>();

                for (int i = 0; i < numArray.Count; i++)
                {
                    iters++;

                    comps++;
                    if (i == pivotIndex) continue;

                    comps++;
                    if (numArray[i] <= pivot)
                    {
                        leftArray.Add(numArray[i]);
                    }
                    else
                    {
                        rightArray.Add(numArray[i]);
                    }
                }

                List<int> sortedArray = new List<int>();
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

        public int getComparaciones()
        {
            return comps;
        }

        public void setComparaciones(int c)
        {
            comps = c;
        }

        public int getIteraiones()
        {
            return iters;
        }

        public void setIteraciones(int it)
        {
            iters = it;
        }

        public int getIntercambios()
        {
            return inter;
        }

        public void setIntercambios(int inte)
        {
            inter = inte;
        }
    }
}

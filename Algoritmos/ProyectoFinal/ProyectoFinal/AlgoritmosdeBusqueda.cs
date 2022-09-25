using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    class AlgoritmosdeBusqueda
    {
        public int comps = 0;
        public int indice = 0;
        public int Pivote = 0;
        public List<int> pivotes = new List<int>();

        public int busquedaLineal(int valorB, List<int> lista)
        {            
            indice = -1;
            for (int i = 0; i < lista.Count; i++)
            {
                comps++;
                if (lista[i] == valorB)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        public int busquedaBinaria(int valorB, List<int> lista)
        {
            int PosI = 0;
            //int Encotardo = -1;
            indice = -1;
            int PosF = lista.Count - 1;
            //int Pivote = 0;
            do
            {
                comps++;
                Pivote = (PosF + PosI) / 2;
                pivotes.Add(Pivote);
                //Console.WriteLine("Primer Pivote= " + Pivote);
                if (lista[Pivote] == valorB)
                {
                    indice = Pivote;
                }
                else
                {
                    if (valorB > lista[Pivote])
                    {
                        PosI = Pivote + 1;
                    }
                    else
                    {
                        PosF = Pivote - 1;
                    }
                }
            } while (PosI <= PosF && indice == -1);
            return indice;
        }

        public int getComparaciones()
        {
            return comps;
        }

        public void setComparacione(int c)
        {
            comps = c;
        }

        public int getIndice()
        {
            return indice;
        }

        public void setIndice(int i)
        {
            indice = i;
        }

        public List<int> getPivotes()
        {
            return pivotes;
        }

        public void setPivotes(List<int> p)
        {
            pivotes = p;
        }
    }
}

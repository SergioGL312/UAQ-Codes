using System;

namespace _1_DesplazamientoDerecha_8
{
    class Program
    {
        static int[] vector = new int[6];
        static void Main(string[] args)
        {
            llenarArreglo();
            Console.WriteLine("Original");
            mostrar();
            //desplazamientoDerecha(1, 9);
            //mostrar();
            desplazamientoIzquierda(4,9);
            mostrar();
        }

        static void llenarArreglo()
        {
            vector[0] = 8;
            vector[1] = 6;
            vector[2] = 1;
            vector[3] = 9;
            vector[4] = 7;
            vector[5] = 6;
        }

        static void mostrar()
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }

        static void desplazamientoDerecha(int pos, int valor)
        {
            Console.WriteLine("Desplazamineot Derecha");
            Array.Resize(ref vector, vector.Length + 1);
            for (int i = vector.Length - 1; i > pos ; i--)
            {
                vector[i] = vector[i - 1];
            }
            vector[pos] = valor;
        }
        static void desplazamientoIzquierda(int pos, int valor)
        {
            int temp = 0;
            int tempFi = 0; 
            temp = vector[0];
            
            Console.WriteLine("Desplazamiento Izquierda");
            Array.Resize(ref vector, vector.Length + 1);
            tempFi = vector[vector.Length - 2];
            for (int i = 0; i < vector.Length - 1; i++)
            {
                vector[i] = vector[i+1];
            }
            vector[pos] = valor;
            vector[vector.Length - 1] = temp;
            vector[vector.Length - 2] = tempFi;
        }
    }
}

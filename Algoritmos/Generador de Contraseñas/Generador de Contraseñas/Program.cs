using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generador_de_Contraseñas
{
    class Program
    {
        /*public static List<string> mayusculas = new List<string>() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                 "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public static List<string> minusculas = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                 "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

        public static List<string> simbolos = new List<string>() { "!", "\"", "#", "$", "%", "&", "\'", "(", ")", "*", "+", ",", "-",
                 ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "]", "^", "_",
                 "`", "{", "|", "}", "~"};

        public static List<string> numeros = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public static List<string> caracteres = new List<string>();*/

        public static string[] mayusculas = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                 "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };


        public static string[] minusculas = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                 "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

        public static string[] simbolos = { "!", "\"", "#", "$", "%", "&", "\'", "(", ")", "*", "+", ",", "-",
                 ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "]", "^", "_"};

        public static string[] numeros = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public static string[] caracter = new string[88]; //mayusculas.Length + minusculas.Length + simbolos.Length + numeros.Length



        static void Main(string[] args)
        {
            int opc = 0, tam = 0;
            do
            {
                Console.WriteLine("Hello World!\ntam: ");
                tam = int.Parse(Console.ReadLine());
                Console.WriteLine("Password: " + generarContra(tam));
                opc = int.Parse(Console.ReadLine());
            } while (opc != 2);
            
            
            //mostrar();
        }

        public static string generarContra(int size)
        {
            Random r = new Random();
            StringBuilder pass = new StringBuilder();
            caracter = mayusculas.Concat(caracter).ToArray();
            caracter = minusculas.Concat(caracter).ToArray();
            caracter = simbolos.Concat(caracter).ToArray();
            caracter = numeros.Concat(caracter).ToArray();

            for (int i = 0; i < size; i++)
            {
                int index = r.Next(0, 88);

                pass.Append(caracter[r.Next(88)]);
            }

            return pass.ToString();
            /*Random r = new Random();
            string caracterRandm, contr;
            caracteres.AddRange(mayusculas);
            caracteres.AddRange(minusculas);
            caracteres.AddRange(simbolos);
            caracteres.AddRange(numeros);

            for (int i = 0; i < size; i++)
            {
                caracterRandm = r.Next(caracteres.Count).ToString();
                contr = 
            }
            Console.WriteLine(caracteres);*/


        }

        public static void mostrar()
        {
            for (int i = 0; i < 88; i++)
            {
                Console.WriteLine((i + 1) + ".- " + caracter[i]);
            }
        }
    }
}

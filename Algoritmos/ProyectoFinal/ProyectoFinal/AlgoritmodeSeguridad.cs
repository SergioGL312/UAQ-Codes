using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal
{
    class AlgoritmodeSeguridad
    {
        public string[] mayusculas = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                 "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };


        public string[] minusculas = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                 "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

        public string[] simbolos = { "!", "\"", "#", "$", "%", "&", "\'", "(", ")", "*", "+", ",", "-",
                 ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "]", "^", "_"};

        public string[] numeros = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public string[] caracter = new string[88];

        public string generarContra(int size)
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
        }
    }
}

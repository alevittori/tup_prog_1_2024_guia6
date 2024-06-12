using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    internal class Program
    {

        /*
         * 
         * Ejercicio 3)
            Realizar un programa que permita ingresar 10 números y calcule su promedio.

         * 
         * */
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int suma = 0;
            double promedio;
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el numero {0}", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];
                Console.Clear();
            }

            promedio = suma/ numeros.Length;
                
            Console.WriteLine($"El promedio de los numeros ingresados es de {promedio:f2}");

            Console.ReadKey();
        }
    }
}   

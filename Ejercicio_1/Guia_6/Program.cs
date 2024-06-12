using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    internal class Program
    {
        /*
        Ejercicio 1)
        Un estudiante de matemáticas requiere una aplicación que permita calcular la suma de los números naturales hasta un valor determinado.Implemente una solución con C#
        */
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;

            Console.WriteLine("Ingrese la cantidad de numeros naturales que desea sumar");
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de los numeros hasta {numero} es de: {suma}");

            Console.ReadKey();
        }
    }
}

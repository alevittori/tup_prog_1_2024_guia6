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
         * Ejercicio 4)
            Implemente una aplicación que dados dos valores enteros ingresados por el usuario muestre en pantalla todos los valores
                divisibles por 2 y por 3 en el intervalo formado por los números ingresados. No realice ninguna suposición sobre el orden en 
                el que se ingresan los valores y su magnitud.

        */
        static void Main(string[] args)
        {
            int valor1, valor2;

            Console.WriteLine("ingrese valor 1:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese valor 2:");
            valor2 = int.Parse(Console.ReadLine());

            //verifico que los intervalos sean crecientes
            if(valor1 < valor2)
            {
                Console.Clear();
                Console.WriteLine($"Numeros divicible por 2 en el intervalo {valor1} : {valor2}");
                for(int i = valor1; i < valor2; i++)
                {
                    if(i%2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
               
                }
                Console.WriteLine($"\n Numeros divicible por 3 en el intervalo {valor1} : {valor2}");
                for (int i = valor1; i < valor2; i++)
                {

                    if (i % 3 == 0)
                    {
                    Console.Write($"{i}  ");
                    }

                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Numeros divicible por 2 en el intervalo {valor1} : {valor2}");
                for (int i = valor2; i < valor1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }

                }
                Console.WriteLine($"\n Numeros divicible por 3 en el intervalo {valor1} : {valor2}");
                for (int i = valor2; i < valor1; i++)
                {

                    if (i % 3 == 0)
                    {
                        Console.Write($"{i}  ");
                    }

                }
            }



            Console.ReadKey();
        }
    }
}

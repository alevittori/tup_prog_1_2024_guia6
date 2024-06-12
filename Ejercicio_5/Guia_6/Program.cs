using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool IsPrimo(int numero)
            {
                if (numero <= 1) return false;
                if(numero == 2 ) return true;
                if(numero % 2 == 0 ) return false;

                int perimetro = (int)Math.Sqrt(numero);
                for(int i = 3; i <= perimetro; i += 2)
                {
                    if(numero % i == 0 ) return false;
                }


                return true;
            }


            Console.WriteLine("Ingrese un numero para saber si es primo");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                bool esPrimo = IsPrimo(num);
                if(esPrimo)
                {
                    Console.WriteLine($"{num} es Primo");
                }
                else
                {
                    Console.WriteLine($"{num} no es Primo");
                }
            }
            else
            {
                Console.WriteLine("Por favor ingrese un numero entero valido");
            }

            Console.ReadKey();
        }
    }
}

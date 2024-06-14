using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6
{
    internal class Program
    {
        /*
         * 
         * Ejercicio 9)
            Implemente una pequeña aplicación que permita calcular el total por una compra ingresando el código del producto, la cantidad y el precio unitario.

            Nota: la aplicación debe consultar si se desea otro producto o ya terminó el ingreso

        */
        static void Main(string[] args)
        {
            int cant = 0;
            double precio, total = 0;

            do
            {
                
                Console.WriteLine("1->Ingresar producto  (-1)-> Salir Sistema");
                cant = int.Parse(Console.ReadLine());

                if(cant == 1 | cant == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Debe elegir una opcion valida");
                }
            }while (true);

            while(cant != -1)
            {
                do
                {
                    Console.WriteLine("Ingrese cantidad (-1 para salir): ");
                    cant = int.Parse(Console.ReadLine());
                    if (cant > 0 | cant == -1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("La cantidad debe ser mayor a 0 ");
                    }
                } while (true);
                
                Console.Clear();

                if(cant != -1)
                {
                    Console.WriteLine("Ingrese codigo del producto");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Ingrese precio unitario: ");
                    precio = double.Parse(Console.ReadLine());
                    total += precio * cant;
                    Console.Clear();
                }
            }//fin del ingreso de producto
            if(total >0)
            {
                Console.Clear();
                Console.WriteLine("Total a pagar: {0:C}", total);
                Console.ReadKey();
            }
        }//FIN METODO MAIN
    }
}

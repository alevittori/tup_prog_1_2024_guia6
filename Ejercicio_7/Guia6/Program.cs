using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6
{
    internal class Program
    {
        /**
         * 
         * Ejercicio 7)
            Realice una aplicación que permita ingresar la base y la altura de un rectángulo y lo dibuje en pantalla.
        Nota: Considerando el tamaño de pantalla el dibujo debe ser siempre en forma horizontal (el lado mayor como columnas) 
        y si no entra en la pantalla debe informarlo con un mensaje aproximadamente en el centro de la misma.

        */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese medida de la base:");
            int baseLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese medida de la altura:");
            int height = int.Parse(Console.ReadLine());

            
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            
            Console.Clear();

            
            if (baseLength > consoleWidth || height > consoleHeight)
            {
                Console.WriteLine("Las dimenciones son muy largas para que entre en la pantalla.");
                Console.WriteLine($"Ancho de pantalla: {consoleWidth}, Altura de la pantallat: {consoleHeight}");
                Console.WriteLine($"Base del rectangulo: {baseLength}, Base del rectangulo: {height}");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < baseLength; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        

            Console.ReadKey();
    }
    }
}

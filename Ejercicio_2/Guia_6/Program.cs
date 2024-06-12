using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    internal class Program
    {
        /*
         * 
         * Ejercicio 2)
            Realizar un marco de pantalla con signos asteriscos desde la posición (5,2) a (75,22)

        */
        static void Main(string[] args)
        {
            string marco = "*";

            int inicioX = 5;
            int inicioY = 2;
            int finX = 75;
            int finY = 22;

            //marco superior
            Console.SetCursorPosition(inicioX, inicioY);
            for (int i = inicioX; i <= finX; i++)
            {
                Console.Write(marco);
            }

            //Marco inferior
            Console.SetCursorPosition(inicioX, finY);
            for (int i = inicioX; i <= finX; i++)
            {
                Console.Write(marco);
            }

            for (int i = inicioY; i <= finY; i++)
            {
                Console.SetCursorPosition(inicioX, i);
                Console.Write(marco);
            }

            

            for (int i = inicioY; i <= finY; i++)
            {
                Console.SetCursorPosition(finX, i);
                Console.Write(marco);
            }
            Console.ReadKey();
        }
    }
}

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
         * Ejercicio 6)
        Codifique una aplicación de consola que permita el ingreso de una lista de canciones grabadas en un CD y sus tiempos en formato MM:SS y 
        muestre el tiempo total de la lista y el nombre de la canción con mayor duración.
        La aplicación debe solicitar la cantidad de canciones a procesar al inicio.


        */
        static void Main(string[] args)
        {
            int total_canciones;
            double duracion = 0; 
                int mm = 0, ss = 0;
            double timepo_lista = 0, tiempo_max = 0;
            string cancion, cancionMaxDuracion="";

            //armamos el metodo para formatear los minutos
            string formatoMMSS(double totalMinutos)
            {
                int total_segundos = (int)(totalMinutos * 60);
                mm = total_segundos / 60;
                ss = total_segundos % 60;

                return $"{mm:D2}:{ss:D2}";
            }

            Console.WriteLine("Cuantas canciones desea ingresar?");
            total_canciones = int.Parse(Console.ReadLine());

            Console.Clear();
            for (int i = 0; i < total_canciones; i++)
            {
                Console.WriteLine("Ingrese el nombre de la cancion {0}: ", i + 1);
                cancion = Console.ReadLine();
                Console.Write($"ingre la duracion de la cancion {cancion}: ");
                duracion = double.Parse(Console.ReadLine());

                if (duracion > tiempo_max)
                {
                    tiempo_max = duracion;
                    cancionMaxDuracion = cancion;
                }

                timepo_lista += duracion;

                
                Console.Clear();
            }

            Console.WriteLine($"Tiempo total de la lista: {timepo_lista}");
            Console.WriteLine($"Cancion con mayor duracion fue: {cancionMaxDuracion}, tiempo: {formatoMMSS(tiempo_max)}");

            Console.ReadKey();


        }
    }
}

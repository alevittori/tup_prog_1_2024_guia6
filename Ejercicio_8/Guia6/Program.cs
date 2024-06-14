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
         * Ciclo While con centinela

            Ejercicio 8)
            Se ingresa una lista de notas correspondientes a una evaluación de programación numeradas entre 0 y 10.

            Al finalizar se debe mostrar en pantalla:
            Cantidad de notas
            Promedio
            Cantidad de aprobados y no aprobados
            Porcentaje de alumnos con:

            o Muy Bueno ( 8 o más)
        */


        static void Main(string[] args)
        {
            int nota, cant_notas=0, cant_aprobados=0, cant_noAprobados=0, sumaNotas=0, cant_muyBuenos=0;
            double promedio = 0, alumnosMuyBuenos = 0;
            bool centinel = true;

            while (centinel)
            {
                do
                {
                    Console.Write($"ingrese nota {cant_notas + 1} o (-1) finalizar ingresos ");
                    nota = int.Parse(Console.ReadLine());

                    if (nota >= 1 && nota <= 10 || nota == -1)
                    {
                        if (nota == -1) { centinel = false; cant_notas--; }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("La nota debe ser entre 1 y 10");
                    }
                } while (true);
               
               
                cant_notas++;
                sumaNotas += nota;
                if (nota >= 6)
                {
                    cant_aprobados++;
                    if(nota >= 8) { cant_muyBuenos++;}
                }
                else if(nota !=-1)
                {
                    cant_noAprobados++;
                }
               
            }// FIN INGRESO DE NOTAS
            if (cant_notas  > 0)
            {
                //Console.WriteLine("cant nota antes del promerio{0}", cant_notas);
              //  cant_notas--;
               // Console.WriteLine("cant nota despúes del promerio{0}", cant_notas);
                promedio = sumaNotas / cant_notas +1;
                alumnosMuyBuenos = cant_muyBuenos * 100 / cant_notas;
                Console.WriteLine($"Cantidad de notas {cant_notas} \n Promedio: {promedio} \n Cantidad de aprobados. {cant_aprobados} \n Cantidad que no aprobaron: {cant_noAprobados} \n Porcentaje de Muy Buenos: {alumnosMuyBuenos}%");

            }
            else
            {
                Console.WriteLine("No se ha ingresado datos. Fin del programa");
            }


            Console.ReadKey();

        }
    }
}

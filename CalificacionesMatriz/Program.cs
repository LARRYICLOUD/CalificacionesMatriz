using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionesMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, numAlumnos;
            double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

            Console.WriteLine("HOLA MUNDO SOY UN PROGRAMADOR  EN C# Y EXPERTO EN REDES EXCELENTE");

            //pedimos el numero de alumnos

            Console.Write("Ingrese el numero de alumnos:  ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            //Creacion de la matriz
            double[] calificaciones = new double[numAlumnos];
            // for para pedir calificaciones
            for (i = 0; i < numAlumnos; i++)
            {
                Console.Write("Ingresa la calificacion: ");
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());

                //Acumulamos las calificaciones
                sumaCalif += calificaciones[i];

            }

            //Calculamos el promedio
            promedio = sumaCalif / numAlumnos;


            //Calculamos la calificacion minima
            for (i = 0; i < numAlumnos; i++)
            {
                if (calificaciones[i] < califMin)
                {
                    califMin = calificaciones[i];
                }

            }
            //Calculamos la calificacion maxima
            for (i = 0; i < numAlumnos; i++)
            {
                if (calificaciones[i] > califMax)
                {
                    califMax = calificaciones[i];
                }

            }

            //Mostramos los resultados

            Console.WriteLine("el promedio es: {0} ", promedio);

            Console.WriteLine("la calificacion minima es: {0} ", califMin);

            Console.WriteLine("la calificacion maxima  es: {0} ", califMax);







        }
    }
}

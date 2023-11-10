using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRU2_DGGR
{
    public class Examen
    {
        public void DatosCurp()
        {
            Console.WriteLine("Ingrese su CURP");
            string curp = Console.ReadLine();

            string HoM = curp.Substring(10, 1);
            string sexo = "";
            if (HoM == "H" || HoM == "h")
            {
                sexo = "Maculino";
            }
            else
                sexo = "Femenino";

            string año = curp.Substring(4, 2);
            string mes = curp.Substring(6, 2);
            string dia = curp.Substring(8, 2);

            int añoint = int.Parse(año);
            string añocom = "";
            if (añoint > 23)
            {
                añocom = "19" + año;
            }
            else
                añocom = "20" + año;

            Console.WriteLine($"El sexo es {sexo} y la fecha de nacimiento es {dia}/{mes}/{añocom}");
        }

        public void Calificaciones()
        {
            int[] calificaciones = new int[10];
            Random random = new Random(101);
            //Rellenar matriz
            for (int i = 0; i < calificaciones.Length; i++)
            {
                calificaciones[i] = random.Next(101);
            }
            //Imprima la matriz desordenada
            for (int h = 0; h < calificaciones.Length; h++)
            {
                Console.Write(calificaciones[h] + ", ");
            }
            Console.WriteLine();

            //Ordena la matriz de forma descendente utilizando el método de ordenamiento burbuja
            int temporal = 0;
            for (int y = 0; y < calificaciones.Length - 1; y++)
            {
                for (int x = y + 1; x < calificaciones.Length; x++)
                {
                    while (calificaciones[y] < calificaciones[x])
                    {
                        temporal = calificaciones[y];
                        calificaciones[y] = calificaciones[x];
                        calificaciones[x] = temporal;
                    }
                }
            }
            //Imprima el matriz ordenada.
            for (int j = 0; j < calificaciones.Length; j++)
            {
                Console.Write(calificaciones[j] + ", ");
            }
            Console.WriteLine();
            //Busque un número deseado por el usuario en la matriz ordenada utilizando una búsqueda lineal.
            Console.WriteLine("introdusca el numero a buscar");
            int buscar = Convert.ToInt32(Console.ReadLine());
            int posicion = -1;
            for (int a = 0; a < calificaciones.Length; a++)
            {
                if (buscar == calificaciones[a])
                {
                    posicion = a + 1;
                    break;
                }
            }
            //Imprima la posición del número 75 en la matriz, si se encuentra o un texto que le informe al usuario que el valor no se encuentra
            if (posicion != -1)
            {
                Console.WriteLine($"El numero {buscar} esta en la psicion {posicion}");
            }
            else
            {
                Console.WriteLine($"El numero {buscar} no se encuentra ");
            }
        }

        public void TablaVendedores()
        {
            int[,] tabla = { { 500, 3000, 100, 400 }, { 1000, 150, 200, 500 }, { 250, 1800, 2900, 300 }, { 400, 130, 90, 2400 }, { 60, 20, 4000, 3600 } };

            //Imprima la tabla en consola.

            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int h = 0; h < tabla.GetLength(1); h++)
                {
                    Console.Write(tabla[i, h] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                int suma = 0;
                for (int h = 0; h < tabla.GetLength(1); h++)
                {
                    suma = suma + tabla[i, h];

                }
                Console.WriteLine($"El producto {i+1} tiene un total de {suma}");
            }
            Console.WriteLine();
            for (int i = 0; i < tabla.GetLength(1); i++)
            {
                int suma = 0;
                for (int h = 0; h < tabla.GetLength(0); h++)
                {
                    suma = suma + tabla [h,i];

                }
                Console.WriteLine($"El vendedor {i+1} tiene un total de {suma}");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSueldo
{
    class Program
    {
        /// <summary>
        /// //Este programa tienen la finaldiad de leer y mostras 5 sueldos utilizando vectores
        /// </summary>
        /// <param name="args"></param>

        private int[] sueldo;
        public void CargarDatos()
        {
            sueldo = new int[5];
            string linea;
            for(int x=0; x<5; x++)
            {
                Console.Write("Ingrese sueldo ");
                linea = Console.ReadLine();
                sueldo[x] =int.Parse(linea);
            }
        }

        public void MostrarDatos()
        {
            for(int x=0; x<5; x++)
            {
                Console.WriteLine("El sueldo " + x + " es: " + sueldo[x]);
            }
        }

        static void Main(string[] args)
        {
            Program s = new Program();
            s.CargarDatos();
            s.MostrarDatos();
            Console.ReadKey();
        }
    }
}

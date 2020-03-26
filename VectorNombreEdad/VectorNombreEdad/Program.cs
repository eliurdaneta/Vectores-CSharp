using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorNombreEdad
{
     class Edades
    {
        //Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas.
        //Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas mayores de edad
        private string[] nombres;
        private int[] edades;
        int longitud;

        // Solicitamos Datos y los guardamos en los vectores sueldos y edades
        public void CargarDatos()
        {
            string linea;
            Console.Write("Cantidd de sueldos a Ingresar: ");
            linea = Console.ReadLine();
            longitud = int.Parse(linea);
            nombres = new string[longitud];
            edades = new int[longitud];
            int y;
            for (int x = 0; x < nombres.Length; x++)
            {
                y = x + 1;
                Console.WriteLine("Ingrese nombre del trabajador " + y + ": ");
                nombres[x] = Console.ReadLine();
                Console.WriteLine("Ingrese edad del trabajador " + y + ": ");
                linea = Console.ReadLine();
                edades[x] = int.Parse(linea);                
            }
        }

         public void  MayoresdeEdad()
         {
            for(int x=0; x < edades.Length; x++)
            {
                if(edades[x]>18)
                {
                    Console.WriteLine("El trabajador "+" "+nombres[x]+ " es mayor de edad");
                }
            }
         }

        static void Main(string[] args)
        {
            Edades e = new Edades();
            e.CargarDatos();
            e.MayoresdeEdad();
            Console.ReadKey();
        }
    }
}

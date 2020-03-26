using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorSueldo
{
    //Confeccionar un programa que permita cargar los nombres de los operarios solicitados por consola
    //y sus sueldos respectivos. La cantidad de Operarios a ingresar, deben ser solicitados.
    //Mostrar el sueldo mayor y el nombre del operario.
    class MaxSueldo
    {
        private string[] nombres;
        private float[] sueldos;

        public void CargarDatos()
        {
            int longitud;
            int y;
            Console.Write("Ingrese la cnatidad de Trabajadores a Ingresar: ");
            longitud = int.Parse(Console.ReadLine());
            nombres = new string[longitud];
            sueldos = new float[longitud];

            for(int x=0; x < nombres.Length; x++)
            {
                y = x + 1;
                Console.WriteLine("Ingrese nombre del trabajador " + y +" :");
                nombres[x] = Console.ReadLine();
                Console.WriteLine("Ingrese sueldo del trabajador " + y + " :");
                sueldos[x] = float.Parse(Console.ReadLine());
            }
        }

        public void CalculaMayor()
        {
            float max=0;
            string name = " ";
            for(int x=0; x<nombres.Length; x++)
            {
                if(sueldos[x] > max)
                {
                    max = sueldos[x];
                    name = nombres[x];
                }
            }
            Console.WriteLine("El trabajador " + name + " tiene el mayor sueldo y es de: "+ max);
        }
        static void Main(string[] args)
        {
            MaxSueldo m = new MaxSueldo();
            m.CargarDatos();
            m.CalculaMayor();
            Console.ReadKey();
        }
    }
}

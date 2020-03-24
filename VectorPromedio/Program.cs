using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorPromedio
{
    class Promedio
    {
        //Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas.
        //Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.
         private float[] altura;
         float promedio;
         public void CargarDatos()
         {
            string linea;
            altura = new float[5];
            for(int x=0; x<5; x++)
            {
                int y = x + 1;
                Console.WriteLine("Ingrese altura " + y + " :");
                linea = Console.ReadLine();
                altura[x] = float.Parse(linea.Replace(".", ","));
            }
         }

        public void CalcularPromedio()
        {
            float suma = 0;
            for(int x=0; x<5; x++)
            {
                suma = altura[x] + suma;
            }
            promedio = suma / 5;
            Console.WriteLine("El promedio de las alturas es: "+ promedio);
        }

        public void PersonasAltBa()
        {
            int countAltas=0;
            int countBajas = 0;
            for (int x=0; x<5; x++)
            {
                if(altura[x] > promedio)
                {
                    countAltas = 1 + countAltas;
                }
                if(altura[x]< promedio)
                {
                    countBajas = 1 + countBajas;
                }
            }
            Console.WriteLine("La cantidad de personas mas altas que el promedio son: " + countAltas);
            Console.WriteLine("La cantidad de personas más bajas que el promedio son: " + countBajas);
        }
        
        static void Main(string[] args)
        {
            Promedio pm = new Promedio();
            pm.CargarDatos();
            pm.CalcularPromedio();
            pm.PersonasAltBa();
            Console.ReadKey();
        }
    }
}

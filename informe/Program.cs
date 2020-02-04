using System;
using System.Collections.Generic;
using System.Linq;

namespace informe
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int>();
            IEnumerable<int> Enumerable_numeros;
            int aux;
            Console.WriteLine("Ingresar 10 numeros del 0 al 100");
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    aux = int.Parse(Console.ReadLine());                    
                } while (aux < 0 || aux > 100);
                numeros.Add(aux);
            }
            Enumerable_numeros = numeros;
            Console.WriteLine("El mas alto es: " + Enumerable_numeros.Max().ToString());
            Console.WriteLine("El mas bajo es: " + Enumerable_numeros.Min().ToString());
            Console.WriteLine("La suma de los valores es de: " + Enumerable_numeros.Sum().ToString());
            Console.WriteLine("El promedio de los valores es de: " + Enumerable_numeros.Average().ToString());

        }
    }
}

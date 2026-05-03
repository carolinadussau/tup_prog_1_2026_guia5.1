using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasNiñas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            double total, porcion;
            double edad1, edad2, edad3, edad4;
            double mesada1, mesada2, mesada3, mesada4;
            double edades;
            double porcentaje1, porcentaje2, porcentaje3, porcentaje4;

            // Solicitar al usuario el monto total
            Console.Write("Ingrese el monto total a repartir: ");
            total = Convert.ToDouble(Console.ReadLine());

            //Solicitar al usuario las edades de las niñas
            Console.Write("Ingrese la edad de la primera niña: ");
            edad1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la edad de la segunda niña: ");
            edad2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la edad de la tercera niña: ");
            edad3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la edad de la cuarta niña: ");
            edad4 = Convert.ToInt32(Console.ReadLine());

            // Calcular la porción (mesada) de cada niña
            edades = edad1 + edad2 + edad3 + edad4;

            porcion = total / edades;

            mesada1 = edad1 * porcion;
            mesada2 = edad2 * porcion;
            mesada3 = edad3 * porcion;
            mesada4 = edad4 * porcion;

            porcentaje1 = edad1 / edades;
            porcentaje2 = edad2 / edades;
            porcentaje3 = edad3 / edades;
            porcentaje4 = edad4 / edades;


            //Mostrar el porcentaje y la mesada de cada niña
            Console.WriteLine($"Porcentaje niña 1: {porcentaje1:P2} Mesada: {mesada1:N2}");
            Console.WriteLine($"Porcentaje niña 2: {porcentaje2:P2} Mesada: {mesada2:N2}");
            Console.WriteLine($"Porcentaje niña 3: {porcentaje3:P2} Mesada: {mesada3:N2}");
            Console.WriteLine($"Porcentaje niña 4: {porcentaje4:P2} Mesada: {mesada4:N2}");
            Console.ReadKey();
        }
    }
}


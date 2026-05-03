using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            double kgsMasa, gramos;
            int cantBudines, masaSobrante;
            int cantPaquetes, cantCajas, budSobrantes;

            //Solicitar al usuario los kgs de masa
            Console.Write("Ingrese los kgs de masa disponibles: ");
            kgsMasa = Convert.ToDouble(Console.ReadLine());

            // Convertir los kgs a gramos
            gramos = kgsMasa * 1000;

            // Calcular la cantidad de budines que se pueden hacer
            cantBudines = (int)(gramos / 250);

            // Calcular la masa sobrante
            masaSobrante = (int)(gramos % 250);

            // Calcular la cantidad de paquetes
            cantPaquetes = cantBudines / 12;

            // Calcular la cantidad de cajas
            cantCajas = cantPaquetes / 20;

            // Calcular los budines sobrantes
            budSobrantes = cantBudines - (cantCajas * 20 * 12);

            //Mostrar los resultados
            Console.WriteLine($"Cantidad de budines que se pueden hacer: {cantBudines}");
            Console.WriteLine($"Cantidad de masa sobrante: {masaSobrante} gramos");
            Console.WriteLine($"Cantidad de paquetes: {cantPaquetes}");
            Console.WriteLine($"Cantidad de cajas: {cantCajas}");
            Console.WriteLine($"Cantidad de budines sobrantes: {budSobrantes}");
        }
    }
}

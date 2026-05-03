using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int num, parteNum, parteLetras; 
            int l1, l2, l3;
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string patente;

            // Solicitar al usuario un número de 6 dígitos
            Console.Write("Ingrese un número de 6 dígitos: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Calcular la parte numérica y la parte de letras
            parteNum = num % 1000;
            parteLetras = num / 1000;

            // Obtener las letras correspondientes a la parte de letras
            l3 = parteLetras % 26;
            parteLetras = parteLetras / 26;

            l2 = parteLetras % 26;
            parteLetras = parteLetras / 26;

            l1 = parteLetras % 26;

            // Construir la patente
            patente = $"{letras[l1]}{letras[l2]}{letras[l3]} {parteNum}";
            Console.WriteLine($"Patente: {patente}");


        }
    }
}

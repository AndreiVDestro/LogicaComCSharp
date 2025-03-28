using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado, contador;
            Console.WriteLine("Escreva um numero: ");
            numero=int.Parse(Console.ReadLine());
            for (contador = 1; contador <= 10; contador++) 
            {
                resultado=numero*contador;
                Console.WriteLine(numero+ "X"+ contador+ "="+ resultado);
            }

        }
    }
}

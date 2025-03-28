using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado, contador = 1;
            Console.WriteLine("Escreva um numero");
            numero=int.Parse(Console.ReadLine());
            while (contador < 10)
            {
                contador = contador + 1;
                resultado = numero * contador;
                Console.WriteLine(numero + "X" + contador + "=" + resultado + "\n");
            }

                

        }
    }
}

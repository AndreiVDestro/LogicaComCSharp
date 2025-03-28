using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroSequancia
{
    internal class Program
    {
        static void Main(string[] args,
        {
            int numero;
            double m,b;
            Console.Write("Escreva seu numero: ");
            numero = Console.Read();
            b = (numero - 1);
            m = (numero + 1);
            Console.Write(b, numero, m);
        }
    }
}

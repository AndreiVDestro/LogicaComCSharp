using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peixe_peso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double sobra;
            Console.Write("digite o peso do pescado: ");
            peso=int.Parse(Console.ReadLine());
            sobra = (peso - 50) * 4;
            Console.Write(sobra);
        }
    }
}

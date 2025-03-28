using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomba_Enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 10;
            while (contador >0) 
            {
                Console.WriteLine("Detonaçao "+ contador+ "\n");
                contador = contador - 1;
            }
            Console.WriteLine("Boooommm");
        }
    }
}

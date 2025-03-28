using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinhação_enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, acertos, contador, advin;
            contador = 0;
            acertos = 0;
            Console.WriteLine("\n JOGADOR 1 Digite um numero de 1 a 10 \n");
            numero=int.Parse(Console.ReadLine());
            while (contador < 11) 
            {
                Console.WriteLine(" JOGADOR 2 Adivinhe o numero escolhido \n");
                advin=int.Parse(Console.ReadLine());
                contador=contador+1;
                if (advin == numero)
                {
                    acertos = acertos + 1;
                    Console.WriteLine(" VOCÊ ACERTOU O NUMERO " + advin + " NA TENTATIVA " + contador + "\n");

                }
            }
        }
    }
}

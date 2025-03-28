using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovOuRepro_Enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, reprovado, aprovado, estado;
            aprovado = 0;
            reprovado = 0;
            while(contador < 400)
            {
                Console.WriteLine("Peça: " + contador + "\n");
                Console.WriteLine("digite(1)APROVADO e (2)REPROVADO: ");
                estado=int.Parse(Console.ReadLine());
                contador++;
                if(estado == 1)
                {
                    aprovado++;
                }
                else if(estado== 2){
                    reprovado++;
                }
                else
                    {
                        Console.WriteLine("Estado invalido digite numero 1 ou 2");
                    }
                Console.WriteLine("Aprovados: " + aprovado + "\nReprovados: " + reprovado);
            }
        }
    }
}

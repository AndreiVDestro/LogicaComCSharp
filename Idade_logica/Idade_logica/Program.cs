using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano_nascimento, ano_atual, idade;
            //int= variavel inteiro
            Console.Write("Digite o ano de seu nascimento: ");
            //Console.Write=escreva
            ano_nascimento = int.Parse(Console.ReadLine());
            //int.Parse(Console.ReadLine()) converte texto em numero
            //int(Console.Read()) leia
            Console.Write("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());
            idade = ano_atual - ano_nascimento;
            Console.Write("sua idade é: " + idade + " anos");















        }
    }
}

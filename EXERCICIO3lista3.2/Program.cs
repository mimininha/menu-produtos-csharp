using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO3lista3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Biscoito");
            Console.WriteLine("2 - Chocolate");
            Console.WriteLine("3 - Pizza");
            Console.WriteLine("4 - Refrigerante");
            Console.WriteLine("5 - Água mineral");
            Console.WriteLine("6 - Vinho");
            Console.WriteLine("Digite uma opção:");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
            case 1:
                 Console.WriteLine("Produto: Biscoito");
                 Console.WriteLine("Valor unitário: R$ 2,50");
                 Console.WriteLine("Estoque: 50");
            break;
            case 2:
                 Console.WriteLine("Produto: Chocolate");
                 Console.WriteLine("Valor unitário: R$ 4,20");
                 Console.WriteLine("Estoque: 30");
            break;
            case 3:
                 Console.WriteLine("Produto: Pizza");
                 Console.WriteLine("Valor unitário: R$ 25,90");
                 Console.WriteLine("Estoque: 80");
            break;
            case 4:
                 Console.WriteLine("Produto: Refrigerante");
                 Console.WriteLine("Valor unitário: R$ 3,00");
                 Console.WriteLine("Estoque: 60");
            break;
            case 5:
                 Console.WriteLine("Produto: Água mineral");
                 Console.WriteLine("Valor unitário: R$ 1,80");
                 Console.WriteLine("Estoque: 100");
            break;
            case 6:
                 Console.WriteLine("Produto: Vinho");
                 Console.WriteLine("Valor unitário: R$ 23,10");
                 Console.WriteLine("Estoque: 19");
            break;
            default:
                 Console.WriteLine("Opção inválida.");
            break;
            }
        }
    }
}

using System;
using System.Drawing;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {

            short quantity = 0;

            short count = 0;
            float total = 0;
            float acumaldorDoTotal = 0;


            bool next = false;
            while (!next == true)
            {
                menu();
                short select = short.Parse(Console.ReadLine());
                while (select < 0 || select > 5)
                {
                    Console.WriteLine("Por favor, selecione uma opção valida:");
                    select = short.Parse(Console.ReadLine());
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("Número de tentativas excedidas");
                        System.Environment.Exit(0);
                    }
                }
                switch (select)
                {


                    case 1:
                        Console.WriteLine("Deseja quantos itens?");
                        quantity = short.Parse(Console.ReadLine());
                        total = acumaldorDoTotal + (quantity * 4.00f);
                        acumaldorDoTotal = total;
                        quantity = 0;
                        break;

                    case 2:
                        Console.WriteLine("Deseja quantos itens?");
                        quantity = short.Parse(Console.ReadLine());
                        total = acumaldorDoTotal + (quantity * 4.50f);
                        acumaldorDoTotal = total;
                        quantity = 0;
                        break;


                    case 3:
                        Console.WriteLine("Deseja quantos itens?");
                        quantity = short.Parse(Console.ReadLine());
                        total = acumaldorDoTotal + (quantity * 5.00f);
                        acumaldorDoTotal = total;
                        quantity = 0;
                        break;

                    case 4:
                        Console.WriteLine("Deseja quantos itens?");
                        quantity = short.Parse(Console.ReadLine());
                        total = acumaldorDoTotal + (quantity * 2f);
                        acumaldorDoTotal = total;
                        quantity = 0;
                        break;

                    case 5:
                        Console.WriteLine("Deseja quantos itens?");
                        quantity = short.Parse(Console.ReadLine());
                        total = acumaldorDoTotal + (quantity * 1.50f);
                        acumaldorDoTotal = total;
                        quantity = 0;
                        break;

                    default:
                        System.Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Deseja selecionar mais itens?");
                Console.WriteLine("Selecione: 1 - Sim      2 - Não");
                short moreItens = short.Parse(Console.ReadLine());
                if (moreItens == 2)
                {
                    next = true;
                }
            }
            Console.Write($"Total: R${Math.Round(total, 2)} ");


        }
        static void menu()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("OPÇÕES");
            Console.WriteLine("================================");
            Console.WriteLine("1 - Cachorro Quente....R$ 4.00");
            Console.WriteLine("2 - X-Salada...........R$ 4.50");
            Console.WriteLine("3 - X-Bacon............R$ 5.00");
            Console.WriteLine("4 - Torrada simples....R$ 2.00");
            Console.WriteLine("5 - Refrigerante.......R$ 1.50");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("================================");
            Console.WriteLine("Digite o código do produto que seja consumir:");
        }
    }
}
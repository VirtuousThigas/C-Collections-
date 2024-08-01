using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<String> filaDecolagem = new Queue<String>(5);
            
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Listar a quantidade de avioes que estao aguardando na fila de decolagem.");
                Console.WriteLine("2.Autorizar a decolagem do primeiro aviao da fila de decolagem.");
                Console.WriteLine("3.Adicionar um aviao na fila de colagem.");
                Console.WriteLine("4.Listar todos os avioes que estao na fila de colagem.");
                Console.WriteLine("5.Exibir o primeiro aviao da fila de colagem.");
                Console.WriteLine("6.Sair");
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Quantidade de avioes: {0}.", filaDecolagem.Count);
                        break;
                    case 2:
                        string aviaoDesenfileirado =filaDecolagem.Dequeue();
                        Console.WriteLine("O aviao " + aviaoDesenfileirado+ " decolou.");
                     break;
                    case 3:
                        Console.WriteLine("Digite o indentificador do aviao:");
                        string nomeAviao = Console.ReadLine();
                        filaDecolagem.Enqueue(nomeAviao);
                        break;
                    case 4:
                        Console.WriteLine("Fila de decolagem:");
                        foreach (string aviao in filaDecolagem)
                        {
                            Console.WriteLine(aviao);
                        }
                        break;
                    case 5:
                        string proximoAviao = filaDecolagem.Peek();
                        if (proximoAviao != null)
                        {
                            Console.WriteLine("Primeiro aviao da fila: " + proximoAviao);
                         }
                        else
                        {
                            Console.WriteLine("A fila de decolagem está vazia.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("O programa será encerrado!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                break;
                }
            }
        }
    }
}

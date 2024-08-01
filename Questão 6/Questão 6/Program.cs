using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> musicas = new LinkedList<string>();
            bool saida = false;
            int escolha;
            while (saida == false)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Inserir uma musica no final da lista.");
                Console.WriteLine("2.Inserir uma musica no inicio da lista.");
                Console.WriteLine("3.Inserir uma musica depois de outra.");
                Console.WriteLine("4.Remover a musica do inicio da lista.");
                Console.WriteLine("5.Remover a musica do final da lista.");
                Console.WriteLine("6.Remover uma musica especifica.");
                Console.WriteLine("7.Listar todas as musicas da lista.");
                Console.WriteLine("8.Pesquisar se uma musica consta na lista.");
                Console.WriteLine("9.Encerrar o programa.");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Digite o nome da musica a ser inserida:");
                        string musicaFim = Console.ReadLine();
                        musicas.AddLast(musicaFim);
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome da musica a ser inserida");
                        string musicaInicio = Console.ReadLine();
                        musicas.AddFirst(musicaInicio);
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome da musica a ser inserida:");
                        string musicaEscolhida = Console.ReadLine();
                        Console.WriteLine("Digite o nome da musica que consta na lista:");
                        string musicaConstada = Console.ReadLine();
                        LinkedListNode<string> aux = musicas.Find(musicaConstada);
                        musicas.AddAfter(aux, musicaEscolhida);
                        break;
                    case 4:
                        musicas.RemoveFirst();
                        break;
                    case 5:
                        musicas.RemoveLast();
                        break;
                    case 6:
                        Console.WriteLine("Digite o nome da musica a ser removida:");
                        string musicaRemovidaParam = Console.ReadLine();
                        musicas.Remove(musicaRemovidaParam);
                        break;
                    case 7:
                        Console.WriteLine("Lista de musicas:");
                        foreach (var item in musicas)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 8:
                        Console.WriteLine("Digite o nome da musica a ser pesquisada:");
                        string musicaPesquisada = Console.ReadLine();
                        if (musicas.Contains(musicaPesquisada) == true)
                        {
                            Console.WriteLine("A musica esta na lista.");
                        }
                        else
                        {
                            Console.WriteLine("A musica nao esta na lista.");
                        }
                        break;
                    case 9:
                        Console.WriteLine("O programa sera encerrado!");
                        saida = true;
                        break;

                }
            }
        }
    }
}

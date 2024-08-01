using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> tempos = new List<double>();
            bool saida = false;
            int escolha;
            while(saida==false)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1) Inserir um tempo no inicio da lista.");
                Console.WriteLine("2) Inserir um tempo no final da lista.");
                Console.WriteLine("3) Inserir um tempo numa posicao especifica da lista.");
                Console.WriteLine("4) Remover o primeiro tempo da lista.");
                Console.WriteLine("5) Remover o ultimo tempo da lista.");
                Console.WriteLine("6) Remover um tempo de uma posicao especifica na lista.");
                Console.WriteLine("7) Remover um tempo especifico da lista.");
                Console.WriteLine("8) Pesquisar quantas vezes um determinado tempo consta na lista.");
                Console.WriteLine("9) Mostrar todos os tempos da lista.");
                Console.WriteLine("10) Mostrar todos os tempos da lista em ordem crescente.");
                Console.WriteLine("11) Mostrar todos os tempos da lista em ordem decrescente.");
                Console.WriteLine("12) Encerrar o programa.");
                escolha=int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Informe o tempo:");
                        double tempo;
                        tempo=double.Parse(Console.ReadLine());
                        tempos.Insert(0, tempo);
                        break;
                    case 2:
                        Console.WriteLine("Informe o tempo:");
                        double tempofim;
                        tempofim=double.Parse(Console.ReadLine());
                        tempos.Add(tempofim);
                        break; 
                    case 3:
                        Console.WriteLine("Informe o tempo:");
                        double tempoespecifico;
                        tempoespecifico=double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a posição:");
                        int posicao;
                        posicao= int.Parse(Console.ReadLine());
                        tempos.Insert(posicao, tempoespecifico);
                        break;
                    case 4:
                        double primeirotempo= tempos.First();
                        Console.WriteLine("Tempo removido: " + primeirotempo+".");
                        tempos.RemoveAt(0);
                        break;
                    case 5:
                        double ultimotempo=tempos.Last();
                        Console.WriteLine("Tempo removido: "+ ultimotempo+".");
                        tempos.RemoveAt(tempos.Count - 1);
                        break;
                    case 6:
                        Console.WriteLine("Informe a posição:");
                        int posicaoescolhida = int.Parse(Console.ReadLine());
                        double elementoescolhido = tempos.ElementAt(posicaoescolhida);
                        Console.WriteLine("Tempo Removido: " + elementoescolhido + ".");
                        tempos.RemoveAt(posicaoescolhida);
                        break;
                    case 7:
                        Console.WriteLine("Informe o tempo:");
                        double tempoinformado = double.Parse(Console.ReadLine());
                        tempos.Remove(tempoinformado);
                        Console.WriteLine("Tempo removido: " + tempoinformado + ".");
                        break;
                    case 8:
                        Console.WriteLine("Informe o tempo:");
                        int contagem = 0;
                        double tempoquant= double.Parse(Console.ReadLine());
                        for(int i = 0; i < tempos.Count; i++)
                        {
                            if (tempos[i] == tempoquant)
                            {
                                contagem++;
                            }
                        }
                        Console.WriteLine("Quantidade: " + contagem);
                        break; 
                    case 9:
                        Console.WriteLine("Lista:");
                        for (int i = 0; i < tempos.Count; i++)
                        {
                            Console.WriteLine(i + ": " + tempos[i] + "."); 
                        }
                        break; 
                    case 10:
                        Console.WriteLine("Lista:");
                        tempos.Sort();
                        for (int i = 0; i < tempos.Count; i++)
                        {
                            Console.WriteLine(i + ": " + tempos[i] + ".");
                        }
                        break; 
                    case 11:
                        Console.WriteLine("Lista:");
                        tempos.Sort();
                        tempos.Reverse();
                        for (int i = 0; i < tempos.Count; i++)
                        {
                            Console.WriteLine(i + ": " + tempos[i]+".");
                        }
                        break;
                    case 12:
                        Console.WriteLine("O programa será encerrado.");
                        saida = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

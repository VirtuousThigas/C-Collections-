using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Stack<double> Pilha1 = new Stack<double>();
                string notacao;
                Console.WriteLine("Informe uma expressao:");
                notacao = Console.ReadLine();
                double result = 0;

                foreach (char c in notacao)
                {

                    if (c == '+')
                    {
                        result = Pilha1.Pop() + Pilha1.Pop();
                        Pilha1.Push(result);
                    }
                    else if (c == '-')
                    {
                        double temp = Pilha1.Pop();
                        result = Pilha1.Pop() - temp;
                        Pilha1.Push(result);
                    }
                    else if (c == '*')
                    {
                        result = Pilha1.Pop() * Pilha1.Pop();
                        Pilha1.Push(result);
                    }
                    else if (c == '/')
                    {
                        double divisor = Pilha1.Pop();
                        double dividendo = Pilha1.Pop();
                        result = dividendo / divisor;
                        Pilha1.Push(result);
                    }
                    else
                    {
                        Pilha1.Push(Char.GetNumericValue(c));

                    }
                }

                Console.WriteLine("Resultado: " + result);
                Console.ReadLine();
            }
        }
    }
}

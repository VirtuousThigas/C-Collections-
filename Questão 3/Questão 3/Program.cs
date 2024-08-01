using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{

    internal class Program
    {
        public static bool FormacaoSequencia(string sequencia)
        {
            Stack<char> pilha = new Stack<char>();
            for (int i = 0; i < sequencia.Length; i++)
            {
                char s = sequencia[i];
                if (s == ')' || s == ']')
                {
                    if (pilha.Count == 0 || !Validador(pilha.Peek(), s))
                    {
                        return false;
                    }
                    pilha.Pop();
                }
                else if (s == '(' || s == '[')
                {
                    pilha.Push(s);
                }
            }
            return pilha.Count == 0;
        }

        public static bool Validador(char aberto, char fechado)
        {
            return (aberto == '(' && fechado == ')') || (aberto == '[' && fechado == ']');
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sequencia:");
            string sequencia = Console.ReadLine();
            bool resultado = FormacaoSequencia(sequencia);
            Console.WriteLine(resultado ? "Sequencia bem formada!" : "Sequencia mal formada");
            Console.ReadLine();
        }
    }
}

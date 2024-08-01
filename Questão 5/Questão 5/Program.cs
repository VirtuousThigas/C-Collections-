using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Frase:");
            string frase = Console.ReadLine();
            frase = frase.ToLower();
            string[] palavras = frase.Split(' ');
            Dictionary<string, int> frutas = new Dictionary<string, int>();
            foreach (string palavra in palavras)
            {
                if (frutas.ContainsKey(palavra))
                {
                    frutas[palavra]++;
                }
                else
                {
                    frutas[palavra] = 1;
                }
            }
            foreach (var par in frutas)
            {
                Console.WriteLine($"{par.Key}: {par.Value} ocorrencia(s).");
            }
        }
    }
}

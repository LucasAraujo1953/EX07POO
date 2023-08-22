using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Numero calculadora = new Numero();
            int maiorValor = calculadora.ObterMaiorValor(valor1, valor2);

            Console.WriteLine("O maior valor é: " + maiorValor);
        }
    }
}

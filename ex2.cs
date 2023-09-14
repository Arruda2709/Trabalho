using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            Console.WriteLine("Digite o valor para ser multiplicado");
            int c = int.Parse(Console.ReadLine());
            for (int t = 0; t< n.Length; t++)
            {
                Console.WriteLine("Digite os valores");
                n[t] = int.Parse(Console.ReadLine());
                Console.WriteLine("O resultado é " +c * n[t]);
            }

          
        }
    }
}

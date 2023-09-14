using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int t = 0; t < a.Length; t++)
            {
                Console.WriteLine("Digite os valores do primeiro vetor");
                a[t] = int.Parse(Console.ReadLine());
               
            }

            int[] b = new int[10];
            for (int r = 0; r < b.Length; r++)
            {
                Console.WriteLine("Digite os valores do segundo vetor");
                b[r] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("O resultado da multiplicação é: " + a[0] * b[0]);
            Console.WriteLine("O resultado da multiplicação é: " + a[1] * b[1]);
            Console.WriteLine("O resultado da multiplicação é: " + a[2] * b[2]);
            Console.WriteLine("O resultado da multiplicação é: " + a[3] * b[3]);
            Console.WriteLine("O resultado da multiplicação é: " + a[4] * b[4]);
            Console.WriteLine("O resultado da multiplicação é: " + a[5] * b[5]);
            Console.WriteLine("O resultado da multiplicação é: " + a[6] * b[6]);
            Console.WriteLine("O resultado da multiplicação é: " + a[7] * b[7]);
            Console.WriteLine("O resultado da multiplicação é: " + a[8] * b[8]);
            Console.WriteLine("O resultado da multiplicação é: " + a[9] * b[9]);
            

        }
    }
}

using System;

namespace vet19
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0;
            int negativos = 0;
            int pares = 0;
            int impares = 0;
            int[] n = new int[10];
            for (int t = 0; t < n.Length; t++)
            {
                
                Console.WriteLine("Digite os valores:");
                n[t] = int.Parse(Console.ReadLine());
            }

            for (int i=0; i<10; i++)
            {
                if (n[i]>= 0)
                {
                    positivos++;
                }

                else
                {
                    negativos++;
                }

                if (n[i]%2 == 0)
                {
                    pares++;
                }

                else
                {
                    impares++;
                }
            }
            Console.WriteLine(" Positivos:" +positivos);
            Console.WriteLine(" Negativos:" +negativos);
            Console.WriteLine(" Pares:" +pares);
            Console.WriteLine(" Impares:" + impares);



        }
    }
}
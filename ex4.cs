using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mes = new string[13];
            mes[0] = "Não há mês 0";
            mes[1] = "Janeiro";
            mes[2] = "Fevereiro";
            mes[3] = "Março";
            mes[4] = "Abril";
            mes[5] = "Maio";
            mes[6] = "Junho";
            mes[7] = "Julho";
            mes[8] = "Agosto";
            mes[9] = "Setembro";
            mes[10] = "Outubro";
            mes[11] = "Novembro";
            mes[12] = "Dezembro";


            {
                Console.WriteLine("Digite o número do mês desejado");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("O número do mês digitado é: " + mes[m]);
               
            }
        }
    }
}

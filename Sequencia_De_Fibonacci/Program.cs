using System;

namespace Sequencia_De_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, i, f1 = 0, f2 = 1, f3;

            Console.WriteLine("\nDigite um numero inteiro : ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nA sequencia fibonacci de " + numero +" eh : ");
            for (i = 0; i < numero; i++)
            {
                if(i == numero-1)
                {
                    Console.Write(f1 );
                }
                else
                {
                    Console.Write( f1+"," );
                }
               
                if (i < 2)
                {
                    for (i = 0; i < 2; i++)
                    {
                        f1 = 1;
                        Console.Write(f1 +",");
                    }
                }

                f3 = f1 + f2;
                f2 = f1;
                f1 = f3;

            }

        }
    }
}

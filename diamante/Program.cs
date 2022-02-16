using System;

namespace diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Digite um número ímpar: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 != 0)
                {
                    int comprimento = (num - 1) / 2;

                    for (int i = 1; i < num; i += 2)
                    {
                        string espaço = new string(' ', comprimento--);
                        string x = new string('x', i);
                        Console.WriteLine($"{espaço} {x}");
                    }

                    comprimento = 0;
                    for (int i = num; i > 0; i -= 2)
                    {
                        string espaço = new string(' ', comprimento++);
                        string x = new string('x', i);
                        Console.WriteLine($"{espaço} {x}");
                    }
                }
                else
                {
                    Console.WriteLine("\nValor inválido!!!\n");
                    Console.Write("Aperte qualquer tecla para continuar.");
                    Console.ReadLine();
                    Console.Clear();
                }
                continue;
            }

        }
    }
}

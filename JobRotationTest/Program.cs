using System;

public class Program
{
    public static void Main()
    {
        int numAnterior = 0;
        int numAtual = 1;
        int[] fib = { numAnterior, numAtual };

        Console.Write("Digite um número inteiro para realizar a sequência de Fibonacci: ");
        int valor = int.Parse(Console.ReadLine());

        //condição para garantir que o número seja positivo
        if (valor <= 0)
        {
            Console.WriteLine("O valor deve ser maior que zero!");
        }
        else
        {
            while (valor > numAtual)
            {
                int x = numAtual;
                numAtual = numAnterior + numAtual;
                numAnterior = x;
                Array.Resize(ref fib, fib.Length + 1);
                fib[fib.Length - 1] = numAtual;

            }
        }
        if (Array.IndexOf(fib, valor) == -1)
        {
            Console.WriteLine();
            Console.WriteLine($"{valor} não faz parte da sequência de Fibonacci.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.Write($"A sequência de Fibonacci para {valor} é: ");
            foreach (int n in fib)
            {
                Console.Write(n + " ");

            }
            Console.WriteLine();
        }
    }
}




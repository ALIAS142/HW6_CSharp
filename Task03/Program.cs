// Задача 44:выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8

// Метод вывода чисел Фибоначчи

// int Fibonacci (int n)
// {
//     if (n == 0) return 0;
//     if (n == 1) return 1;
//     else return Fibonacci (n -1) + Fibonacci (n -2);
// }
// for (int i = 0; i < 10; i++)
// {
// // System.Console.WriteLine(Fibonacci(i));
// System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }

// // Метод вывода первых N чисел Фибоначчи

System.Console.WriteLine("Enter number N:");
PrintFibonacci(int.Parse(Console.ReadLine()));

int Fibonacci(int N)
{
    return N > 1 ? Fibonacci(N - 1) + Fibonacci(N - 2) : N;
}

int PrintFibonacci(int N) 
{
    for (int i = 0; i < N; i++)
    {
        System.Console.WriteLine(Fibonacci(i));
    }
    return Fibonacci(N);
}

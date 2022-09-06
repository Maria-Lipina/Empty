using static System.Console;
using static System.Convert;

WriteLine("45. Показать числа Фибоначчи");

double Fibonacci (int n)
{
    if(n == 1 || n == 0) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 0; i < 40; i++)
{
    WriteLine(Fibonacci(i));
}
using static System.Console;
using static System.Convert;


WriteLine();
WriteLine("70. Найти сумму цифр числа");

int SumDig (int n)
{
    int dig = n % 10;
    n = n / 10;
    if (n != 0) return dig + SumDig(n);
    else return 1;
}

WriteLine(SumDig(123456789));

using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("26. Возведите число А в натуральную степень B используя цикл");

int Power (int A, int B)
{int result = A;
for (int i = 1; i < B+1; i++)
{
    result = result * A;
}
return result;
}

WriteLine("A = ");
int A1 = ToInt32(ReadLine());
WriteLine("B = ");
int B = ToInt32(ReadLine());
WriteLine(Power(A1,B));

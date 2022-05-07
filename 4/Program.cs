using static System.Console;
using static System.Convert;

WriteLine("4. Найти максимальное из 3 чисел");

int num = ToInt32(ReadLine());
int num1 = ToInt32(ReadLine());
int num2 = ToInt32(ReadLine());

int max = num;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
WriteLine(max);

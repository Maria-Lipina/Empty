using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("9. Показать третью цифру трёхзначного числа");

void SelectDigit(string? number, int index)
{
    int check = Convert.ToInt32(number);
    if(99 < check && check < 1000) Write(number [index]);
    else {WriteLine("Не трехзначное число"); }
}

SelectDigit(ReadLine(), 0);

WriteLine();
WriteLine("10. Показать вторую цифру трёхзначного числа");

SelectDigit(ReadLine(), 1);


WriteLine();
WriteLine("11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа. (ради интереся числа генерируются рандомно)");

int DigCompare(int n)
{
WriteLine (n);
int ten = n / 10;
int unit = n % 10;
if (ten > unit) return ten;
else return unit;
}

WriteLine(DigCompare(new Random().Next(10,99)));

WriteLine();
WriteLine("14. Найти третью цифру числа или сообщить, что её нет");

string? number1 = ReadLine();
int check = ToInt32(number1);
if (check > 999) WriteLine(number1, 0);
else {SelectDigit(number1, 0);}
using static System.Console;
using static System.Convert;

WriteLine("1. По двум заданным числам проверять является ли первое квадратом второго");

bool IsSquare(int square, int number)
{
if (Math.Sqrt(square) == number) return true;
else return false;
}

WriteLine(IsSquare(ToInt32(ReadLine()),ToInt32(ReadLine())));
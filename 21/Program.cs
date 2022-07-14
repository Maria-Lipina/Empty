using static System.Console;
using static System.Convert;

WriteLine("21. Программа проверяет пятизначное число на палиндром."); //черновой вариант
WriteLine();

bool Palindrome (int [] digits)
{
bool compare1 = digits[0] == digits[digits.Length-1];
bool compare2 = digits[1] == digits[digits.Length-2];

return compare1 && compare2;
}

int [] Digits(int n)
{
    int [] result = new int [Convert.ToString(n).Length];
    if (n == 0) result [0] = n;
    else
    {
        for (int i = 0; i < result.Length; i++)
        {
            int o = n % 10;
            result[i] =+ o;
            n /= 10;
        }
    }
    return result;
}


int tocheck = 12321;
int [] digits = Digits(tocheck);
WriteLine(Palindrome(digits));
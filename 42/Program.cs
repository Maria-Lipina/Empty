using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("42. Определить сколько чисел больше 0 введено с клавиатуры");

int[] FindIndex(string N, string[] array)
{
    int foundLength = 0;
    int[] found = new int[foundLength];
    int[] notfound = { -1 };

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == N && array[i].Length == 1)
        {
            foundLength = foundLength + 1;
            Array.Resize(ref found, foundLength);
            found[found.Length - 1] = i;
        }
    }
    if (foundLength == 0) return notfound;
    else return found;
}

int [] ExtractIntNums (string txt)
{
string digits = string.Empty;
for (int i = 0; i < txt.Length; i++)
{
    if (Char.IsDigit(txt[i])) digits = $"{digits}{txt[i].ToString()}";
    if (txt[i] == '-') digits = $"{digits}|{txt[i].ToString()}";
    if (!(txt[i] == '-') && !Char.IsDigit(txt[i])) digits = $"{digits}|";
}

var numstxt = digits.Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

string tofind = "-";
int[] minusInd = FindIndex(tofind, numstxt);

if (minusInd[0] != -1)
{
for (int j = 0; j < minusInd.Length; j++)
{
    minusInd[j] = minusInd[j] - j;
    numstxt[minusInd[j]] = numstxt[minusInd[j]] + $"{numstxt[minusInd[j] + 1]}";

    int newLength = numstxt.Length - 1;
    for (int i = 1; i < newLength - minusInd[j]; i++)
    {
        numstxt[minusInd[j] + i] = numstxt[minusInd[j] + i + 1];
    }
    Array.Resize(ref numstxt, newLength);
}
}
int[] nums = new int[numstxt.Length];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = int.Parse(numstxt[i]);
}
return nums;
}

int CountPositives (int [] array)
{
int countPositives = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) countPositives++;
}
return countPositives;
}

string txt = ReadLine()!;
int [] numbers = ExtractIntNums(txt);
WriteLine($"В текстовой строке {CountPositives(numbers)} положительных чисел");

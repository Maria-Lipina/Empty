using static System.Console;
using static System.Convert;

int[] CreateMyArray(int length)
{
    return new int[length];
}

void FillMyArray(int[] collection, int minValue, int maxValue) // А тут войд можно и нужно, потому что метод только заполняет
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(minValue, maxValue + 1);
    }
}

string PrintMyArray(int[] collect)
{
    string outputString = String.Empty;
    for (int pos = 0; pos < collect.Length; pos++) outputString += $"{collect[pos]} ";
    return outputString;
}

int Find (int N, int [] array)
{
    int i = -1;
    while (i+1 < array.Length)
    {
    if (array [i+1] == N) break;
    else i++;
    }
return i+1;
}

WriteLine("35. Определить, присутствует ли в заданном массиве некоторое число");

int [] A5 = CreateMyArray(15);
FillMyArray(A5, 0, 5);
WriteLine(PrintMyArray(A5));
WriteLine();
int tofind = 3;
WriteLine($"Индекс искомого элемента ({tofind}) в массиве: {Find(tofind, A5)}");


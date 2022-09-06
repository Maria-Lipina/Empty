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

WriteLine("47. Написать программу копирования массива");

int [] cheat = CreateMyArray(15);
FillMyArray(cheat, 0, 50);
WriteLine(PrintMyArray(cheat));

int [] cheat1 = CreateMyArray(15);
Array.Copy(cheat, cheat1, cheat.Length);
WriteLine(PrintMyArray(cheat1));
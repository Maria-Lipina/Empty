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


WriteLine();
WriteLine("31. Задать массив из 8 элементов и вывести их на экран");
WriteLine("32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран ");


int[] arr1 = CreateMyArray(8);
FillMyArray(arr1, 0, 1);
WriteLine(PrintMyArray(arr1));
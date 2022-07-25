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

int [] ChangeSign(int [] array)
{
    int [] array1 = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array1[i] = -array[i];
    }
return array1;
}

WriteLine();
WriteLine("34. Написать программу замену элементов массива на противоположные");

int [] A4 = CreateMyArray(10);
FillMyArray(A4, 0, 100);
WriteLine(PrintMyArray(A4));
WriteLine();
int [] B4 = ChangeSign(A4);
WriteLine(PrintMyArray(B4));

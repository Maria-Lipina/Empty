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

int Count(int [] array, int criterion) // criterion == 1 для нечетных и == 2 для четных, 1099 для входящих в диапазон 10-99 
{
    int result = 0;
    int i = 0;
    for (i = 0; i < array.Length; i++)
    {
    if (criterion == 1 && array[i] % 2 != 0) result++;
    if (criterion == 2 && array[i] % 2 == 0) result++;
    if ((criterion == 1099) & (array[i] > 9) & (array[i] < 100)) result++;
    }
return result;
}

WriteLine("36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных и четных чисел");
int [] A6 = CreateMyArray(15);
FillMyArray(A6, 100, 999);
WriteLine(PrintMyArray(A6));
WriteLine(Count(A6, 2));
WriteLine(Count(A6, 1));

WriteLine();
WriteLine("37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");

int [] A7 = CreateMyArray(123);
FillMyArray(A7, 0, 130);
WriteLine(PrintMyArray(A7));
WriteLine(Count(A7, 1099));
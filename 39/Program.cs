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

int [] PairsProd (int [] array)
{
    int mid = array.Length / 2;
    int [] result = new int [mid];
    for (int i =0; i < mid; i++)
    {
    result[i] = array[i] * array[array.Length-1-i];
    }
return result;
}

WriteLine("39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
int [] A9 = CreateMyArray(16);
FillMyArray(A9, 0, 10);
WriteLine(PrintMyArray(A9));
int [] B9 = PairsProd(A9);
WriteLine(PrintMyArray(B9));
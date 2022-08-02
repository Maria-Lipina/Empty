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

int [] OddIndex (int [] array)
{
    int [] result = new int [array.Length];
    int len = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result[len] = array[i];
        len++;
    }
Array.Resize(ref result, len);
return result;
}

int ArraySum (int[] A)
{int sum = 1;
for (int i = 1; i < A.Length; i++)
{
    sum = sum + A[i];
}
return sum;
}

WriteLine("38. Найти сумму чисел одномерного массива стоящих на нечетной позиции");
int [] A8 = CreateMyArray(16);
FillMyArray(A8, 0, 50);
WriteLine(PrintMyArray(A8));
int [] B8 = OddIndex (A8);
WriteLine(PrintMyArray(B8));
WriteLine(ArraySum(B8));
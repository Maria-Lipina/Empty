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

int[] SelectBySign (int[] array, int sign)
{
//int [] selection = sign switch
int [] result = new int [array.Length];
int len = 0;
switch (sign)
{
case < 0:
for (int i = 0; i<= result.Length; i++)
{
    if (array[i] < 0)
    {
    result [len] = array[i];
    len++;
    }
}
Array.Resize(ref result, len);
return result;

case > 0:
    for (int i = 0; i<= result.Length; i++)
{
    if (array[i] > 0)
    {
    result [len] = array[i];
    len++;
    }
}
Array.Resize(ref result, len);
return result;

case 0:
return array;
};
}

WriteLine();
WriteLine("33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива");

int[] arr2 = CreateMyArray(12);
FillMyArray(arr, -9, 9);
WriteLine(PrintMyArray(arr2));

int [] signed = SelectBySign(arr2, -1);
WriteLine(PrintMyArray(signed));
int [] unsigned = SelectBySign(arr2, +1);
WriteLine(PrintMyArray(unsigned));

int SignedSum = ArraySum(signed);
WriteLine(SignedSum);
int UnsignedSum = ArraySum(unsigned);
WriteLine(UnsignedSum);

using static System.Console;
using static System.Convert;

WriteLine("59. В прямоугольной матрице найти строку с наименьшей суммой элементов.");

void Fill2DArray(int[,] collection, int minValue, int maxValue)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
}

string Print2DArray(int[,] collection)
{
    string outputString = String.Empty;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            outputString += $"{collection[i, j]} | ";
        }
        outputString += "\n";
    }
    return outputString;
}

int LineWithMinSumElems(int[,] arr)
{
    int minSum = int.MaxValue;
    int lineNo = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            lineNo = i;
        }
    }
    return lineNo;
}


var arr = new int[5, 5];
Fill2DArray(arr, 0, 30);
WriteLine(Print2DArray(arr));
WriteLine(LineWithMinSumElems(arr));

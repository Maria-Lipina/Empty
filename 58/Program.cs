using static System.Console;
using static System.Convert;

WriteLine("58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).");


int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

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

int [,] Transpose (int [,] array)
{
    if (array.GetLength(0) != array.GetLength(1)) return new int [,] {{-1}, {-1}};
    else 
    {
        int [,] result = new int [array.GetLength(0),array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result[j,i] = array[i, j];
            }
        }
    return result;
    }
}

int [,] jk = Create2DArray(5, 5);
Fill2DArray(jk, 0, 100);
WriteLine(Print2DArray(jk));

int [,] kj = Transpose(jk);
WriteLine(Print2DArray(kj));


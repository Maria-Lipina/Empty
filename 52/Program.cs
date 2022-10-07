using static System.Console;
using static System.Convert;

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
        for (int j = 0; j < collection.GetLength(1); j++) // И помни, что длина строки определяется количеством столбцов. И наоборот длина столбца определяется количеством строк.
        {
            outputString += $"{collection[i, j]} | ";
        }
        outputString += "\n";
    }
    return outputString;
}

WriteLine();
WriteLine("52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");

int [,] EvenIndQuadrat (int [,] array)
{
for (int i = 0; i < array.GetLength(0); i+=2)
{
    for (int j = 0; j < array.GetLength(1); j+=2)
    {
        array [i,j] = array [i,j] * array [i,j];
    }
}
return array;
}

WriteLine("Изначальный массив");
int [,] ln = Create2DArray(7, 11);
Fill2DArray(ln, 0, 20);
WriteLine(Print2DArray(ln));

WriteLine("Измененный массив");
int [,] nl = EvenIndQuadrat(ln);
WriteLine(Print2DArray(nl));

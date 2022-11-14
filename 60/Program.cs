using System.Linq;
using static System.Console;
using static System.Convert;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("60. Cоставить частотный словарь элементов двумерного массива. ");

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
            string outputString = string.Empty;
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

        Dictionary<int, int> FrequencyAnalysis(int[,] input)
        {
        var dict = new Dictionary<int, int>();
        foreach (var item in input)
        {
         if (!dict.ContainsKey(item))
         {
            dict.Add(item, 1);
         }
         else
         {
            dict[item]++;
         }
        }
        return dict;   
        }

        int[,] input = new int[5, 7];
        Fill2DArray(input, 0, 20);
        WriteLine(Print2DArray(input));

        var result = FrequencyAnalysis(input);
       
        foreach (var item in result)
        {
            Write($"{item}  ");
        }

    }
}
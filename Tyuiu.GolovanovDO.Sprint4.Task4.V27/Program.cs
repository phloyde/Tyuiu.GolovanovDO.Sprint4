using System.Data;
using Tyuiu.GolovanovDO.Sprint4.Task4.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Write("Введите количество строк в массиве: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов в массиве: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] Array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Введите {i}, {j} элемент массива: ");
                Array[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nМассив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0;j < cols; j++)
            {
                Console.Write($"{Array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        int res = ds.Calculate(Array);
        Console.WriteLine("Результат: " + res);
        Console.ReadKey();

    }
}
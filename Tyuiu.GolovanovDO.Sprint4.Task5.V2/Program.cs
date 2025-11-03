using Tyuiu.GolovanovDO.Sprint4.Task5.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.Write("Введите количество строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] Array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Array[i, j] = rnd.Next(-7, 6);
             
            }
        }
        Console.WriteLine();
        Console.WriteLine("\nМассив: ");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; (j < cols); j++)
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
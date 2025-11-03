using Tyuiu.GolovanovDO.Sprint4.Task2.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();
        Console.WriteLine("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            numsArray[i] = rnd.Next(4, 10);
        }
        Console.WriteLine();
        Console.Write("Массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }

        Console.WriteLine();
        Console.WriteLine("Результат: ");

        int res = ds.Calculate(numsArray);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
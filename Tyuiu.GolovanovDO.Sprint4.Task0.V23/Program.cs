using Tyuiu.GolovanovDO.Sprint4.Task0.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
        int res = ds.GetMultOddArrEl(array);
        Console.WriteLine(res);

        Console.ReadLine();
    }
}
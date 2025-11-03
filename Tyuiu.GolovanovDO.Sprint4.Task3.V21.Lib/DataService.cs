using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GolovanovDO.Sprint4.Task3.V21.Lib
{
    public class DataService : ISprint4Task3V21
    {
        public int Calculate(int[,] array)
        {
            int p = 1;

            int rows = array.GetUpperBound(0) + 1; //кол-во строк
            int cols = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 4)
                    {
                        p = p * array[i, 4];
                    }
                }
            }
            return p;

        }
    }
}

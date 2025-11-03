using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GolovanovDO.Sprint4.Task7.V27.Lib
{
    public class DataService : ISprint4Task7V27
    {
        public int Calculate(int rows, int cols, string value)
        {
            int[,] mtrx = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mtrx[i,j] = int.Parse(value.Substring(i * cols + j, 1));
                }
            }
            int cnt = 0;
            for (int i = 0; i < rows;  ++i)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }
}

using System.Runtime.Intrinsics.X86;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GolovanovDO.Sprint4.Task4.V27.Lib
{
    public class DataService : ISprint4Task4V27
    {
        public int Calculate(int[,] matrix)
        {

            int cnt = 0;

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] %2 != 0)
                    {
                        cnt = cnt + matrix[i, j];
                    }
                }
            }
            return cnt;
        }
    }
}

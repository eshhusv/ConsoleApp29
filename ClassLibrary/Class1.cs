namespace ClassLibrary
{
    public class Class1
    {
        public static double[] maxPair(double[,] mas)
        {
            int rows = mas.GetUpperBound(0)+1;
            int cols = mas.Length / rows;
            double[] res = new double[cols];
            double max = mas[0, 0];
            int index=-1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if(mas[i, j] > max)
                    {
                        max = mas[i, j];
                        index = j;
                    }
                }
            }
        }
    }
}
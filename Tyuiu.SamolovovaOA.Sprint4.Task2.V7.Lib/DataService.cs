using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SamolovovaOA.Sprint4.Task2.V7.Lib
{
    public class DataService : ISprint4Task2V7
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) 
                {
                    sum += array[i];
                }
            }

            return sum;
        }
    }
}

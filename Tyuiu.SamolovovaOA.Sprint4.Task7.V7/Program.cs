using Tyuiu.SamolovovaOA.Sprint4.Task7.V7.Lib;

namespace Tyuiu.SamolovovaOA.Sprint4.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            int n = 4;
            int m = 2;
            string value = "31415926";

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine();

            Console.WriteLine("Матрица:");
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(value[index] + "\t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            int res = ds.Calculate(n, m, value);

            Console.WriteLine("Количество нечетных элементов = " + res);

            Console.ReadKey();
        }
    }
}

using Tyuiu.SamolovovaOA.Sprint4.Task5.V3.Lib;

namespace Tyuiu.SpirinIS.Sprint4.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.WriteLine("******************************");
            Console.WriteLine("*       ИСХОДНЫЕ ДАННЫЕ      *");
            Console.WriteLine("******************************");
            Console.WriteLine();

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, cols];

            Console.WriteLine();
            Console.WriteLine("******************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mtrx[i, j] = rnd.Next(-5, 5);
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("*         РЕЗУЛЬТАТ          *");
            Console.WriteLine("******************************");
            Console.WriteLine();

            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{res[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
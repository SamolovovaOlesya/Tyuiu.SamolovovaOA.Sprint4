using Tyuiu.SamolovovaOA.Sprint4.Task3.V15.Lib;
namespace Tyuiu.SamolovovaOA.Sprint4.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();

            int[,] array =
            {
                { 7, 4, 2, 5, 3 },
                { 4, 3, 2, 5, 6 },
                { 6, 3, 4, 7, 5 },
                { 5, 7, 4, 3, 8 },
                { 7, 8, 8, 5, 6 }
            };

            // печать матрицы (по шаблону обычно показывают массив)
            Console.WriteLine("Матрица 5x5:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }

            int result = ds.Calculate(array);
            Console.WriteLine($"\nКоличество нечётных элементов = {result}");
            Console.ReadKey();
        }
    }
}
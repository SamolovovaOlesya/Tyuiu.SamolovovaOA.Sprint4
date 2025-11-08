using Tyuiu.SamolovovaOA.Sprint4.Task4.V25.Lib;

namespace Tyuiu.SpirinIS.Sprint4.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************");
            Console.WriteLine("*       ИСХОДНЫЕ ДАННЫЕ     *");
            Console.WriteLine("*****************************");
            Console.WriteLine();

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine();
            Console.WriteLine("*****************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите ({i},{j}) элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.WriteLine("*        МАССИВ:            *");
            Console.WriteLine("*****************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.WriteLine("*        РЕЗУЛЬТАТ:         *");
            Console.WriteLine("*****************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine($"Сумма четных элементов массива = {res}");

            Console.ReadKey();
        }
    }
}

using Tyuiu.SamolovovaOA.Sprint4.Task6.V18.Lib;

namespace Tyuiu.SamolovovaOA.Sprint4.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************************");
            Console.WriteLine("*              ИСХОДНЫЕ ДАННЫЕ            *");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            string[] animals = { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

            Console.WriteLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine("*                 РЕЗУЛЬТАТ               *");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            string[] result = ds.Calculate(animals);

            Console.WriteLine("Элементы длиной больше 6:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
        }
    }
}
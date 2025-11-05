using Tyuiu.SamolovovaOA.Sprint4.Task1.V26.Lib;
namespace Tyuiu.SamolovovaOA.Sprint4.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[10];

            Console.WriteLine("Введите 10 чисел от 0 до 8:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = ds.Calculate(array);
            Console.WriteLine($"Сумма нечетных элементов массива = {result}");

            Console.ReadKey();
        }
    }
}
using Tyuiu.SamolovovaOA.Sprint4.Task2.V7.Lib;
namespace Tyuiu.SamolovovaOA.Sprint4.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rand = new Random();

            int[] array = new int[12];

            Console.WriteLine("Массив:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(4, 10); 
                Console.Write(array[i] + " ");
            }

            int result = ds.Calculate(array);

            Console.WriteLine("\nСумма чётных элементов = " + result);
            Console.ReadKey();
        }
    }
}
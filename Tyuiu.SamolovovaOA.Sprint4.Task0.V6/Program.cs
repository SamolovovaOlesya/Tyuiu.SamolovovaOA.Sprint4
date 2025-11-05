using Tyuiu.SamolovovaOA.Sprint4.Task0.V6.Lib;
namespace Tyuli.SamolovoaOA.Sprint4.Task0.V6.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };

            Console.WriteLine("****************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                    *");
            Console.WriteLine("****************************************");
            Console.WriteLine("Массив: [1, 6, 3, 7, 5, 4, 2, 7, 8, 9]");
            Console.WriteLine("****************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                          *");
            Console.WriteLine("****************************************");
            Console.WriteLine("Сумма нечётных элементов: " + ds.GetSumOddArrEl(array));
            Console.ReadKey();
        }
    }
}
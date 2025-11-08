using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SamolovovaOA.Sprint4.Task6.V18.Lib
{
    public class DataService : ISprint4Task6V18
    {
        public string[] Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, x => x.Length > 6);
            return result;
        }
    }
}

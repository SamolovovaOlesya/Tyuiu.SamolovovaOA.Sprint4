using Tyuiu.SamolovovaOA.Sprint4.Task6.V18.Lib;

namespace Tyuiu.SamolovovaOA.Sprint4.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string[] animals = new string[]
            {
                "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха"
            };

            string[] res = ds.Calculate(animals);
            string[] wait = { "Попугай", "Черепаха" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}

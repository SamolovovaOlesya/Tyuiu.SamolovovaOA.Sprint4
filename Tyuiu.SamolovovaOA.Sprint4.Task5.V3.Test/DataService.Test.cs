using Tyuiu.SamolovovaOA.Sprint4.Task5.V3.Lib;

namespace Tyuiu.SamolovovaOA.Sprint4.Task5.V3.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] input = new int[3, 3]
            {
                { -1, 3, 0 },
                { -5, 2, -1 },
                { 4, -2, 1 }
            };

            int[,] expected = new int[3, 3]
            {
                { 0, 3, 0 },
                { 0, 2, 0 },
                { 4, 0, 1 }
            };

            int[,] result = ds.Calculate(input);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}

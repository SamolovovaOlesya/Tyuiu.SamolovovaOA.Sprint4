using Tyuiu.SamolovovaOA.Sprint4.Task4.V25.Lib;

namespace Tyuiu.SamolovovaOA.Sprint4.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas = new int[3, 3]
            {
                { 2, 3, 4 },
                { 5, 6, 2 },
                { 1, 2, 6 }
            };

            // Четные: 2 + 4 + 6 + 2 + 2 + 6 = 22
            int wait = 22;

            int res = ds.Calculate(mas);

            Assert.AreEqual(wait, res);
        }
    }
}

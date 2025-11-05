using Tyuiu.SamolovovaOA.Sprint4.Task2.V7.Lib;

namespace Tyuiu.SamolovovaOA.Sprint4.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 5, 6, 7, 8, 9, 4, 4, 6, 5, 8, 9 };

            int result = ds.Calculate(array);

            int wait = 4 + 6 + 8 + 4 + 4 + 6 + 8; 
            Assert.AreEqual(wait, result);
        }
    }
}

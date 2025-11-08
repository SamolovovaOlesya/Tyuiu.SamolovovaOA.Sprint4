using Tyuiu.SamolovovaOA.Sprint4.Task7.V7.Lib;

namespace Tyuiu.SamolovovaOA.Sprint4.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 4;
            int m = 2;
            string value = "31415926";

            DataService ds = new DataService();

            int res = ds.Calculate(n, m, value);
            int wait = 5; // (3,1,5,9,1 из второй строки)

            Assert.AreEqual(wait, res);
        }
    }
}

using System.Security.Cryptography;
using Tyuiu.SamolovovaOA.Sprint4.Task0.V6.Lib;

namespace Tyuiu.SamolovovaOA.Sprint4.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = {0, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int res = ds.GetSumOddArrEl(array);
            int wait = 31;
            Assert.AreEqual(wait, res);

        }
    }
}

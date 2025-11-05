using Tyuiu.SamolovovaOA.Sprint4.Task1.V26.Lib;
namespace Tyuiu.SamolovovaOA.Sprint4.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

               int[] array = { 7, 7, 8, 8, 2, 6, 3, 3, 1, 1 };

               int result = ds.Calculate(array);

               int wait = 22; 

               Assert.AreEqual(wait, result);
            

        }
    }
}

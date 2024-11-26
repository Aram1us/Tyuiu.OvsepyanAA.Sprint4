using Tyuiu.OvsepyanAA.Sprint4.Task7.V3.Lib;

namespace Tyuiu.OvsepyanAA.Sprint4.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 4;
            int columns = 2;
            int[,] mtrx = new int[rows, columns];
            string str = "27182818";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
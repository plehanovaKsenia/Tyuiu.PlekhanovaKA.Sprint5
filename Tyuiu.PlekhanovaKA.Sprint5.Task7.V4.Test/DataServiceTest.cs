using Tyuiu.PlekhanovaKA.Sprint5.Task7.V4.Lib;

namespace Tyuiu.PlekhanovaKA.Sprint5.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            string path = @"С:\DataSprint5\InPutDataFileTask7V4.txt";
            DataService ds = new DataService();
            var res = ds.LoadDataAndSave(path);
            string wait = "######, World! This ### ###### #########.";
            Assert.AreEqual(wait, res);

        }
    }
}

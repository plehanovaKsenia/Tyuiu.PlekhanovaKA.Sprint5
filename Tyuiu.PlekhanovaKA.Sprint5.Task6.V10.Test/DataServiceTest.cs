using Tyuiu.PlekhanovaKA.Sprint5.Task6.V10.Lib;
namespace Tyuiu.PlekhanovaKA.Sprint5.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]

        public void ValidCalc()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V10.txt";
            DataService ds = new DataService();
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);

        }
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V10.txt";
            DataService ds = new DataService();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}

using Tyuiu.PlekhanovaKA.Sprint5.Task4.V21.Lib;

namespace Tyuiu.PlekhanovaKA.Sprint5.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V21.txt";
            DataService ds = new DataService();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
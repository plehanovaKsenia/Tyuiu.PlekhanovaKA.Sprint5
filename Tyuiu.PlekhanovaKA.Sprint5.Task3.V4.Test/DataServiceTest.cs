
using Tyuiu.PlekhanovaKA.Sprint5.Task3.V4.Lib;

namespace Tyuiu.PlekhanovaKA.Sprint5.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            DataService ds = new DataService();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}

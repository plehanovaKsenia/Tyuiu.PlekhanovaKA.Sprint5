using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PlekhanovaKA.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists; 
            if (fileExists)
            {
                File.Delete(path);
            }
            double y = Math.Round(Math.Log((double)(x + 1) / (double)(x + 2)), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path,FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;

        }
    }
}

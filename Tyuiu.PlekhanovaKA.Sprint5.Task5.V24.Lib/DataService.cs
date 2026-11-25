
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PlekhanovaKA.Sprint5.Task5.V24.Lib
{
    public class DataService : ISprint5Task5V24
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double x = Convert.ToDouble(line.Replace('.',','));
                    if (x-Convert.ToInt32(x)==0 && x/10>0)
                    res += x;
                }
            }
            return res;
        }
    }
}


using System.IO;
using System.Reflection.PortableExecutable;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PlekhanovaKA.Sprint5.Task5.V24.Lib
{
    public class DataService : ISprint5Task5V24
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            string[] line =File.ReadAllText(path).Split(' ');
            foreach(string str in line)
            {
                double x = Convert.ToDouble(str.Replace('.', ','));
                if (x - Convert.ToInt32(x) == 0 && x / 10 > 0)
                {
                    res += x;
                }

            }
            return res;
        }
    }
}

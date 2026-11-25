using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PlekhanovaKA.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble(File.ReadAllText(path));
            double res = Math.Round(Math.Pow(x, 3) * Math.Cos(x) + 2 * x, 3);
            return res;
        }
    }
}

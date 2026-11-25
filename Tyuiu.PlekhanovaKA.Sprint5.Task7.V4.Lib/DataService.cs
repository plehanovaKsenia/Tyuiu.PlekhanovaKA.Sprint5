using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PlekhanovaKA.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string res = "";
            string text = File.ReadAllText(path);
            string rusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            foreach (char s in text)
            {

                if (rusAlphabet.Contains(s))
                {
                    res += "#";
                }
                else
                {
                    res += s;
                }

            }
            File.AppendAllText(@"С:\\DataSprint5\\OutPutDataFileTask7V4.txt", res);
            return res;
        }
    }
}

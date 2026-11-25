using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PlekhanovaKA.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            string text = File.ReadAllText(path);
            string word = "";
            List<string> words = new List<string>();
            foreach (char s in text)
            {
                
                if (char.IsLetter(s))
                {
                    word += s;
                }
                else
                {
                    words.Add(word);
                    word = "";
                }

            }
            for(int i = 0; i<words.Count;i++)
            {
                if (words[i].Length==4)
                {
                    res++;
                }
            }
            return res;
        }
    }
}

using Tyuiu.PlekhanovaKA.Sprint5.Task7.V4.Lib;

namespace Tyuiu.PlekhanovaKA.Sprint5.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Плеханова К. А. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание#7                                                               *");
            Console.WriteLine("* Вариант#4                                                               *");
            Console.WriteLine("* Выполнила: Плеханова Ксения Анатольевна | СМАРТб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V4.txt, в котором есть      *");
            Console.WriteLine("* набор символьных данных.Заменить все русские буквы на #.                *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V4.txt.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"С:\DataSprint5\InPutDataFileTask7V4.txt";
            Console.WriteLine("Данные находятся в файле" + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(res);
        }
    }
}

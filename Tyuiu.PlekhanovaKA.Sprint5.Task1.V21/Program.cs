using Tyuiu.PlekhanovaKA.Sprint5.Task1.V21.Lib;
namespace Tyuiu.PlekhanovaKA.Sprint5.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Плеханова К. А. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание#1                                                               *");
            Console.WriteLine("* Вариант#21                                                              *");
            Console.WriteLine("* Выполнила: Плеханова Ксения Анатольевна | СМАРТб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция f(x)=(2x-3)/(cosx-2x)+5x-sinx                              *");
            Console.WriteLine("* на заданном диапазоне [-5;5] с шагом 1.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);
            string[] lines = File.ReadAllLines(res);
            int i = 0;
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Результат: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("|          x          |          f(x)          |");
            for (int x = startValue; x < stopValue; x++)
            {
                Console.WriteLine("+---------------------+------------------------+");
                Console.WriteLine($"|{x,11:d}          |{lines[i],15:f2}         |");
                i++;
            }
            Console.WriteLine("------------------------------------------------");
        }
    }
}

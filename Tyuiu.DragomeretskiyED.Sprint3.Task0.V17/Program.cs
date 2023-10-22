using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DragomeretskiyED.Sprint3.Task0.V17.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint3.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Драгомерецкий Е.Д. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл for                                                          *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Драгомерецкий Егор Дмитриевич | СМАРТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* сумму ряда по формуле                                                   *");
            Console.WriteLine("*    10            1                                                      *");
            Console.WriteLine("* S= ---  cos i * ---                                                     *");
            Console.WriteLine("*    i=1           2                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int v1 = 1;
            int v2 = 10;

            Console.WriteLine("Старт шага = " + v1);
            Console.WriteLine("Конец шага = " + v2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                                ");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSeries(v1, v2);
            Console.WriteLine("Сумма ряда = " + res);


            Console.ReadKey();
        }
    }
}

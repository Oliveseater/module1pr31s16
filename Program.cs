using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;


namespace block1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите данные для базового класса и класса потомка");
            string LastName = Console.ReadLine();
            double CountProg = Convert.ToDouble(Console.ReadLine());
            double Language = Convert.ToDouble(Console.ReadLine());
            double CountWorksProg = Convert.ToDouble(Console.ReadLine());
            
            MainClass mc = new MainClass(LastName, CountProg, Language);
            DopClass dc = new DopClass(LastName, CountProg, Language, CountWorksProg);

            Console.WriteLine(mc.Q_answer(CountProg, Language)+"\n"+dc.Q_answer(CountWorksProg, CountProg));
            Console.ReadKey();
        }
    }
}

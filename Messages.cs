using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Messages
    {
        static public void MenuMessage()
        {
            Console.Write(new string(' ', 10));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Меню");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(new string('-', 28));

            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 0");
            Console.ResetColor();
            Console.WriteLine(", чтобы закрыть меню");

            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 1");
            Console.ResetColor();
            Console.Write(", чтобы просмотреть список доступных ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("контрактов");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 2");
            Console.ResetColor();
            Console.Write(", чтобы просмотреть список доступных ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("филиалов");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 3");
            Console.ResetColor();
            Console.Write(", чтобы просмотреть список доступных ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("агентов");
            Console.ResetColor();
            Console.WriteLine(";");

        }

        static public void CompanyMessage()
        {
            Console.WriteLine(new string('-', 28));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Страховая компания ");
            Console.ResetColor();
            Console.Write("<<");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Сокол");
            Console.ResetColor();
            Console.WriteLine(">> ");
            Console.WriteLine(new string ('-', 28));
            Console.WriteLine();
        }
        static public void EndOfProgramm()
        {
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(new string('-', 28));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Программа завершила свою работу.");
        }





        //Агенты
        static public void AgentsChosenMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Список доступных агентов:\n");
            Console.ResetColor();
        }
        static public void BranchChosenMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Список филиалов:\n");
            Console.ResetColor();
        }
    }
}

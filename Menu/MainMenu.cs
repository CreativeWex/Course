using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class MainMenu
    {
        static public void General()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Меню]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [1]");
            Console.ResetColor();
            Console.Write(", для ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[Работа с данными]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(", для информации об");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [Авторе]");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [0]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[Выйти из программы]");
            Console.ResetColor();
        }
        public static void Data()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Считывание данных]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [1]");
            Console.ResetColor();
            Console.Write(", для работы со вкладкой ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[договоры]");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(", для работы со вкладкой ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[филиалы]");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [3]");
            Console.ResetColor();
            Console.Write(", для работы со вкладкой ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[агенты]");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [4]");
            Console.ResetColor();
            Console.Write(", для работы со вкладкой ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[виды страхования]");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [0]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[вернуться]");
            Console.ResetColor();

        }
        static public void CompanyMessage()
        {
            Console.WriteLine(new string('-', 32));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  Страховая компания ");
            Console.ResetColor();
            Console.Write("<<");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Сокол");
            Console.ResetColor();
            Console.WriteLine(">> ");
            Console.WriteLine(new string('-', 32));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       .---.        .-----------");
            Console.WriteLine("      /    \\  __  /    ------");
            Console.WriteLine("     / /    \\(  )/    -----");
            Console.WriteLine("    //////   '\\/ `   ---");
            Console.WriteLine("   //// / // :    : ---");
            Console.WriteLine("  //         //..\\\\");
            Console.WriteLine("        ====UU====UU====");
            Console.WriteLine("            '//||\\\\`");
            Console.WriteLine("              ''``");

        }

        static public void AuthorMenu()
        {
            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [0]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("вернуться");
            Console.ResetColor();
        }
        static public void EndOfProgramm()
        {
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[Программа завершила свою работу]");
        }
        static public void AuthorInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(" _____                                _____ _ _   _ _      ");
            Console.WriteLine("| __  |___ ___ ___ ___ ___ ___ _ _   |   | |_| |_|_| |_ ___ ");
            Console.WriteLine("| __ -| -_|  _| -_|- _|   | -_| | |  | | | | | '_| |  _| .'|");
            Console.WriteLine("|_____|___|_| |___|___|_|_|___|\\_/   |_|___|_|_,_|_|_| |__,|");

            Console.WriteLine();

            Console.WriteLine("             _       ___       ___ ___ ");
            Console.WriteLine(" ___ ___ _ _| |_ ___|_  |  ___|_  |   |");
            Console.WriteLine("| . | . | | |  _|___|_| |_|___|  _| | |");
            Console.WriteLine("|  _|___|\\_/|_|     |_____|   |___|___|");
            Console.WriteLine("|_|");

            Console.WriteLine();
            Console.ResetColor();

        }
    }
}

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
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[Считать данные]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[Записать новые данные]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [3]");
            Console.ResetColor();
            Console.Write(", чтобы рассчитать");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[Заработную плату]");
            Console.ResetColor();
            Console.WriteLine(" сотрудникам");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [9]");
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
            Console.WriteLine("[Закрыть меню]");
            Console.ResetColor();
        }
        static public void GeneralLocked()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Меню]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [1]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[Считать данные]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" [Записать новые данные]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" [3]");
            Console.ResetColor();
            Console.Write(", чтобы рассчитать");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("[Заработную плату]");
            Console.ResetColor();
            Console.WriteLine(" сотрудникам");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [9]");
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
            Console.WriteLine("[Закрыть меню]");
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
            Console.Write(", чтобы просмотреть список доступных ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("договоров");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(", чтобы просмотреть список доступных ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("филиалов");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [3]");
            Console.ResetColor();
            Console.Write(", чтобы просмотреть список доступных ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("агентов");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [0]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("вернуться");
            Console.ResetColor();

        }
        public static void ReadFile()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Считывание файла]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [1]");
            Console.ResetColor();
            Console.Write(", считать информацию о ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("договорах");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(", считать информацию о ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("филиалах");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [3]");
            Console.ResetColor();
            Console.Write(", считать информацию о ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("агентах");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [0]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("вернуться");
            Console.ResetColor();
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
            Console.WriteLine(new string('-', 28));
            Console.WriteLine();
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
        static public void SalaryInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Рассчет заработной платы]\n");
            Console.ResetColor();
        }
        static public void IsntUnlocked()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: не все данные были считаны");
            Console.ResetColor();
        }
    }
}

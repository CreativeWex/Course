﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Messages
    {
        //-------------------------------------------------------------------------Меню---------------------------------------------------------------------------------
        static public void MenuMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Меню]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 0");
            Console.ResetColor();
            Console.WriteLine(", чтобы закрыть меню");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 1");
            Console.ResetColor();
            Console.Write(", чтобы просмотреть список доступных ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("договоров");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 2");
            Console.ResetColor();
            Console.Write(", чтобы просмотреть список доступных ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("филиалов");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 3");
            Console.ResetColor();
            Console.Write(", чтобы просмотреть список доступных ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("агентов");
            Console.ResetColor();
            Console.WriteLine(";");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 9");
            Console.ResetColor();
            Console.Write(", для информации об");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Авторе");
            Console.ResetColor();
            Console.WriteLine(";");

        }

        //--------------------------------------------------------------------------------Прочее------------------------------------------------------------   
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
        //-----------------------------------------------------------------------Выбор пункта в меню----------------------------------------------------------------------------
        static public void ChosenAgentsMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Список доступных агентов:\n");
            Console.ResetColor();
        }
        static public void ChosenBranchMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Список филиалов:\n");
            Console.ResetColor();
        }

        static public void ChosenContractMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Список контрактов:\n");
            Console.ResetColor();
        }

        //-------------------------------------------------------------------------------Ошибки---------------------------------------------------------------------------------------------------
        static public void ErrorString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка: неверный формат строк(и)\n");
            Console.ResetColor();
        }

        static public void ErrorBranchName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате кода филиала\n");
            Console.ResetColor();
        }

        static public void ErrorPhoneNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате номера телефона\n");
            Console.ResetColor();
        }

        static public void ErrorDate()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате даты\n");
            Console.ResetColor();
        }

        static public void ErrorContractNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате номера договора\n");
            Console.ResetColor();
        }

        static public void ErrorTariffRate()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате Тарифной ставки\n");
            Console.ResetColor();
        }

        static public void ErrorSumm()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате Cтраховой суммы\n");
            Console.ResetColor();
        }

        static public void ErrorInsuranceType()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате Вида страхования\n");
            Console.ResetColor();
        }
    }
}

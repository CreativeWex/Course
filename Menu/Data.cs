using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class DataMenu
    {
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
        static public void ChosenInsuranceType()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Список типов страхования:\n");
            Console.ResetColor();
        }
        static public void Readed()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[Данные считаны]");
        }
    }
    class ContractActions
    {
        public static void Options()
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
            Console.WriteLine("[Отсортировать список]");
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[Добавить запись]");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [3]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[Удалить запись]");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [4]");
            Console.ResetColor();
            Console.Write(", чтобы просмотреть ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[Примечание]");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [5]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[Сохранить данные]");
            Console.ResetColor();
            Console.WriteLine("в файл");
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
        public static void SortMessages()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите поля, по которому нужно отсортировать: ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [1]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Номер договора]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Дата заключения]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [3]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Страховая сумма]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [4]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Тарифная ставка]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [5]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Код филиала]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [6]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Вид страхования]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [7]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Имя Агента]");
        }
        public static void Note()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Данные должны заполняться по слдующему примеру: ");
            Console.ResetColor();

            Console.WriteLine("Дата заключения");
            Console.WriteLine("Страховая сумма");
            Console.WriteLine("Тарифная ставка");
            Console.WriteLine("Код филиала");
            Console.WriteLine("Вид страхования");
            Console.WriteLine("Имя Агента");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-',32));
            Console.WriteLine("601100");
            Console.WriteLine("14.09.2015");
            Console.WriteLine("175000");
            Console.WriteLine("40,1");
            Console.WriteLine("01");
            Console.WriteLine("Медицинское страхование");
            Console.WriteLine("Горбачёв Аким Онисимович");
            Console.WriteLine(new string('-', 32));
            Console.WriteLine();
            Console.ResetColor();
        }
        public static void ContractMaster(BuildContractList objectContract)
        {
            int submenu = 10;

            Options();
            while (submenu != 0)
            {
                Program.TryCatch(ref submenu);

                if (submenu == 0)
                {
                    Console.Clear();
                    MainMenu.Data();
                    break;
                }
                else if (submenu == 1)
                {
                    Console.Clear();
                    objectContract.Sort();
                    objectContract.Display();
                    Options();
                }
                else if (submenu == 2)
                {
                    Console.Clear();
                    objectContract.Add();
                    Options();
                }
                else if (submenu == 3)
                {
                    Console.Clear();
                    objectContract.Remove();
                    Options();
                    objectContract.Display();
                }
                else if (submenu == 4)
                {
                    Console.Clear();
                    ContractActions.Note();
                    objectContract.Display();
                    Options();
                }

                else if (submenu == 5)
                {
                    Console.Clear();
                    objectContract.Save();
                    Options();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: неверный пункт меню");
                    Console.ResetColor();
                }
            }
        }
    }
}
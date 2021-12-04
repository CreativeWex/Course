using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class BranchActions
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
        public static void Note()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Данные должны заполняться по следующему примеру: ");
            Console.ResetColor();

            Console.WriteLine("Название филиала");
            Console.WriteLine("Код филиала");
            Console.WriteLine("Адрес");
            Console.WriteLine("Номер телефона");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 32));
            Console.WriteLine("Щит");
            Console.WriteLine("2");
            Console.WriteLine("352471, г. Клявлино, ул. Столяров пер, дом 160, квартира 301");
            Console.WriteLine("+7 (902) 305-09-96");
            Console.WriteLine("01");
            Console.WriteLine(new string('-', 32));
            Console.WriteLine();
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
            Console.WriteLine("[Филиал]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Код филиала]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [3]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Адресс]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [4]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Телефон]");

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [0]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[Закрыть меню]");
            Console.ResetColor();
        }
        public static void BranchMaster(BuildBranchList objectBranch)
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
                    objectBranch.Sort();
                    objectBranch.Display();
                    Options();
                }
                else if (submenu == 2)
                {
                    Console.Clear();
                    objectBranch.Add();
                    objectBranch.Display();
                    Options();
                }
                else if (submenu == 3)
                {
                    Console.Clear();
                    objectBranch.Remove();
                    Options();
                    objectBranch.Display();
                }
                else if (submenu == 4)
                {
                    Console.Clear();
                    BranchActions.Note();
                    objectBranch.Display();
                    Options();
                }

                else if (submenu == 5)
                {
                    Console.Clear();
                    objectBranch.Save();
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

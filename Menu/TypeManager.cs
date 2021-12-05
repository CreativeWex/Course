using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class TypeActions
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

            Console.WriteLine("Код страхования)Вид страхования");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 32));
            Console.WriteLine("1)Страхование от несчастных случаев и болезней");
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
            Console.WriteLine("[Код страхования]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Вид страхования]");
        }
        public  static void TypeMaster(BuildInsuranceTypeList objectType)
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
                    objectType.Sort();
                    objectType.Display();
                    Options();
                }
                else if (submenu == 2)
                {
                    Console.Clear();
                    objectType.Add();
                    objectType.Display();
                    Options();
                }
                else if (submenu == 3)
                {
                    Console.Clear();
                    objectType.Remove();
                    Options();
                    objectType.Display();
                }
                else if (submenu == 4)
                {
                    Console.Clear();
                    Note();
                    objectType.Display();
                    Options();
                }

                else if (submenu == 5)
                {
                    Console.Clear();
                    objectType.Save();
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

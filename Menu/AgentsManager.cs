using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class AgentsActions
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

            Console.WriteLine("Имя");
            Console.WriteLine("Код филиала");
            Console.WriteLine("Адрес");
            Console.WriteLine("Номер телефона");
            Console.WriteLine("Дата рождения");    
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 32));
            Console.WriteLine("Горбачёв Аким Онисимович");
            Console.WriteLine("01");
            Console.WriteLine("г. Клявлино, ул. Балластная 80, 62");
            Console.WriteLine("89786478095");
            Console.WriteLine("01.01.1986");
            Console.WriteLine(new string('-', 32));
            Console.WriteLine();
            Console.ResetColor();
        }
        public static void AgentsMaster(BuildAgentsList objectAgents)
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
                    objectAgents.Sort();
                    objectAgents.DisplayAgentsInfo();
                    Options();
                }
                else if (submenu == 2)
                {
                    Console.Clear();
                    objectAgents.Add();
                    objectAgents.DisplayAgentsInfo();
                    Options();
                }
                else if (submenu == 3)
                {
                    Console.Clear();
                    objectAgents.Remove();
                    Options();
                    objectAgents.DisplayAgentsInfo();
                }
                else if (submenu == 4)
                {
                    Console.Clear();
                    Note();
                    objectAgents.DisplayAgentsInfo();
                    Options();
                }

                else if (submenu == 5)
                {
                    Console.Clear();
                    objectAgents.Save();
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
        public static void SortMessages()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите поля, по которому нужно отсортировать: ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [1]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Имя агента]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [2]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Код филиала]");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [3]");
            Console.ResetColor();
            Console.Write(" - ");
            Console.WriteLine("[Адрес]");

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
            Console.WriteLine("[Дата рождения]");
            Console.ResetColor();
        }
    }
}

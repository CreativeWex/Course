using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class AgentsActions
    {
        public void WrongOption()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: неверный пункт меню");
            Console.ResetColor();
        }
        public virtual void Options()
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" [6]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[Рассчитать зарплату]");
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
        public virtual void Note()
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
        public virtual void SortMessages()
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
        public void AgentsMaster(BuildAgentsList objectAgents)
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
                else if (submenu == 6)
                {
                    Console.Clear();
                    BuildSalary ob = new BuildSalary();
                }
                else
                {
                    WrongOption();
                }
            }
        }
    }
    class BranchActions : AgentsActions
    {
        public override void Options()
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
        public override void Note()
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
        public override void SortMessages()
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
        public void BranchMaster(BuildBranchList objectBranch)
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
                    Note();
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
                    WrongOption();
                }
            }
        }
    }
    class TypeActions : AgentsActions
    {
        public override void Options()
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" [6]");
            Console.ResetColor();
            Console.Write(", подробнее рассмотреть ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[Виды страхования]");
            Console.WriteLine();
            Console.ResetColor();

            Console.Write(" Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [0]");
            Console.ResetColor();
            Console.Write(", чтобы ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[Закрыть меню]");
            Console.ResetColor();
        }
        public override void Note()
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
        public override void SortMessages()
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
        public void Info()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 237));

            Console.Write("Страхование от несчастных случаев");
            Console.ResetColor();
            Console.WriteLine(" – это один из действительных современных финансовых инструментов," +
                " с помощью которого граждане могут защитить свои экономические интересы в случае непредвиденных затрат, возникающих при заболевании, травме или гибели человека.\n");

            Console.Write("Цель ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("медицинского страхования ");
            Console.ResetColor();
            Console.WriteLine(" - гарантировать гражданам при возникновении страхового случая" +
                " получение медицинской помощи за счет накопленных средств и финансировать профилактические мероприятия. Медицинское" +
                " страхование осуществляется в двух видах: обязательном и добровольном.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nСтрахование средств наземного транспорта");
            Console.ResetColor();
            Console.WriteLine(" представляет собой совокупность видов страхования," +
                " предусматривающих обязанности страховщика по страховым выплатам в размере полной или частичной компенсации ущерба, нанесенного объекту страхования.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nДоговор страхования средств железнодорожного транспорта");
            Console.ResetColor();
            Console.WriteLine(" – это защита от широкого спектра страховых событий, таких как крушение, хищение, авария, пожар или взрыв.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nСтрахование грузов");
            Console.ResetColor();
            Console.WriteLine(" — один из видов имущественного страхования, имеющий целью защиту имущественных интересов владельцев грузов на случай" +
                " наступления убытков, вызванных различного рода происшествиями в процессе транспортировки груза.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nСтрахование имущества юридических лиц");
            Console.ResetColor();
            Console.WriteLine(" - это гарантия быстрого получения средств на проведение восстановительных работ при наступлении" +
                " страхового случая, источник финансирования текущих расходов на время перерыва в процессе производства и защита предприятия.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nСтрахование имущества");
            Console.ResetColor();
            Console.WriteLine(" - вид страхования, в котором в качестве объекта страхования выступает имущественный интерес, связанный с владением, пользованием и распоряжением имуществом. \n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nСтрахование гражданской ответственности владельцев автотранспортных средств");
            Console.ResetColor();
            Console.WriteLine(" - объектом страхования являются имущественные интересы, связанные с риском гражданской ответственности владельца" +
                " транспортного средства по обязательствам, возникающим вследствие причинения вреда жизни, здоровью или имуществу потерпевших при использовании транспортного средства. \n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nСтрахование финансовых рисков");
            Console.ResetColor();
            Console.WriteLine(" представляет собой защиту имущественных интересов предприятия при наступлении страхового события\n");
            Console.WriteLine(new string('-', 237));
            Console.WriteLine();
            Console.ResetColor();
        }
        public void TypeMaster(BuildInsuranceTypeList objectType)
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
                else if (submenu == 6)
                {
                    Console.Clear();
                    Info();
                    Options();
                }
                else
                {
                    WrongOption();
                }
            }
        }
    }
    class ContractActions : AgentsActions
    {
        public override void Options()
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
        public override void SortMessages()
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
        public override void Note()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Данные должны заполняться по следующему примеру: ");
            Console.ResetColor();

            Console.WriteLine("Дата заключения");
            Console.WriteLine("Страховая сумма");
            Console.WriteLine("Тарифная ставка");
            Console.WriteLine("Код филиала");
            Console.WriteLine("Вид страхования");
            Console.WriteLine("Имя Агента");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 32));
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
        public void ContractMaster(BuildContractList objectContract)
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
                    Note();
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
                    WrongOption();
                }
            }
        }
    }
}

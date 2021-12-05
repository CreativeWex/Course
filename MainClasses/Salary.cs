using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace Course
{
    class BuildSalary
    {
        int size;
        public BuildSalary()
        {
            Console.WriteLine("Путь данных о договорах:");
            BuildContractList contract = new BuildContractList();
            List<Salary> agentSalary = new List<Salary>();
            size = contract.List_Contract.Count;

            double[] fee = new double[size];

            var table = new ConsoleTable("Сотрудник", "Стоимость контракта, руб.", "Номер контракта", "Вид страхования");

            for (int i = 0; i < size; i++)
            {
                fee[i] = contract.List_Contract[i].Summ * contract.List_Contract[i].TariffRate;
                agentSalary.Add(new Salary(contract.List_Contract[i].Name, fee[i]));
                table.AddRow(contract.List_Contract[i].Name, fee[i], contract.List_Contract[i].NumberOfContract, contract.List_Contract[i].Type);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[Информация по закрытым контрактам]");
            Console.ResetColor();
            table.Write();
            Console.WriteLine();
            Summary(agentSalary, contract);
        }
        static double CountPercent(string type)
        {
            if (type == "Страхование от несчастных случаев и болезней")
            {
                return 0.13;
            }
            if (type == "Медицинское страхование")
            {
                return 0.15;
            }
            if (type == "Страхование средств наземного транспорта")
            {
                return 0.20;
            }
            if (type == "Страхование средств железнодорожного транспорта")
            {
                return 0.14;
            }
            if (type == "Страхование грузов")
            {
                return 0.18;
            }
            if (type == "Страхование имущества юридических лиц")
            {
                return 0.13;
            }
            if (type == "Страхование имущества граждан")
            {
                return 0.17;
            }
            if (type == "Сельскохозяйственное страхование")
            {
                return 0.24;
            }
            if (type == "Страхование средств водного транспорта")
            {
                return 0.18;
            }
            if (type == "Страхование средств воздушного транспорта")
            {
                return 0.24;
            }
            if (type == "Страхование средств наземного транспорта")
            {
                return 0.11;
            }
            if (type == "Страхование гражданской ответственности владельцев автотранспортных средств")
            {
                return 0.10;
            }
            else return 0.24;
        }
        static void Summary(List<Salary> agentSalary, BuildContractList contract)
        {
            try
            {
                List<Salary> Final = new List<Salary>();
                int k = 0;
                agentSalary =
                        (from index in agentSalary
                         orderby index.Name
                         select index).ToList();

                Final.Add(new Salary(agentSalary[0].Name, agentSalary[0].InsuranceFee * CountPercent(contract.List_Contract[0].Type)));
                var table = new ConsoleTable("Сотрудник", "Заработная плата");
                for (int i = 0; i < agentSalary.Count; i++)
                {
                    if (agentSalary[i].Name == Final[k].Name)
                    {
                        Final[k].InsuranceFee += agentSalary[i].InsuranceFee * CountPercent(contract.List_Contract[i].Type);
                    }
                    else
                    {
                        k++;
                        Final.Add(new Salary(agentSalary[i].Name, agentSalary[i].InsuranceFee * CountPercent(contract.List_Contract[i].Type)));
                    }
                }
                for (int i = 0; i < Final.Count; i++)
                {
                    table.AddRow(Final[i].Name, Final[i].InsuranceFee);
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Заработная плата сотрудников в соответствии с закрытыми контрактами");
                Console.ResetColor();
                table.Write();
                Console.Write(" Введите");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" [0]");
                Console.ResetColor();
                Console.Write(", чтобы ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[Вернуться]");
                Console.ResetColor();
            }
            
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {e}");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" Введите");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" [0]");
                Console.ResetColor();
                Console.Write(", чтобы ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[Вернуться]");
                Console.ResetColor();
            }
        }
    }
}

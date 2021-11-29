using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        public static void Data(int errorFlag)
        {
            Console.Clear();
            MainMenu.Data();
            int submenu = 10;

            while (submenu != 0)
            {
                Console.Write("> ");
                try
                {
                    submenu = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: " + e.Message);
                    Console.ResetColor();
                }

                if (submenu == 0)
                {
                    Console.Clear();
                    MainMenu.General();
                    break;
                }

                else if (submenu == 1)
                {
                    Console.Clear();
                    DataMenu.ChosenContractMessage();

                    BuildContractList objectContract = new BuildContractList(ref errorFlag);

                    if (errorFlag == 1)
                        break;
                    objectContract.DisplayContractInfo();
                    MainMenu.Data();

                }

                else if (submenu == 2)
                {
                    Console.Clear();
                    DataMenu.ChosenBranchMessage();

                    BuildBranchList objectBranch = new BuildBranchList(ref errorFlag);

                    if (errorFlag == 1)
                        break;

                    objectBranch.DisplayBranchInfo();
                    MainMenu.Data();

                }

                else if (submenu == 3)
                {
                    Console.Clear();
                    DataMenu.ChosenAgentsMessage();

                    BuildAgentsList objectAgents = new BuildAgentsList(ref errorFlag);

                    if (errorFlag == 1)
                        break;

                    objectAgents.DisplayAgentsInfo();
                    MainMenu.Data();
                }
            }
        }

        public static void Salary(int errorFlag)
        {
            Console.Clear();
            MainMenu.SalaryInfo();

            BuildContractList source = new BuildContractList(ref errorFlag);
            BuildSalary ob = new BuildSalary();
        }

        static void Main(string[] args)
        {
            int menu = 10;
            int errorFlag = 0;

            MainMenu.CompanyMessage();
            MainMenu.General();

            while (menu != 0)
            {
                Console.Write("> ");
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: " + e.Message);
                    Console.ResetColor();
                }

                if (menu == 1)
                {
                    Data(errorFlag);
                }

                if (menu == 3)
                {
;                    Salary(errorFlag);
                }

                else if (menu == 9)  // АВТОР
                {
                    Console.Clear();
                    MainMenu.AuthorInfo();
                    MainMenu.General();

                } //АВТОР

            }
            MainMenu.EndOfProgramm();
            Console.ReadKey();
        }
    }

}
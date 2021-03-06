using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        public static void TryCatch(ref int menu)
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
        } 
        public static void Data()
        {
            int submenu = 10;

            Console.Clear();
            MainMenu.Data();
            while (submenu != 0)
            {
                TryCatch(ref submenu);

                if (submenu == 0)
                {
                    Console.Clear();
                    MainMenu.CompanyMessage();
                    MainMenu.General();
                    break;
                }
                else if (submenu == 1)
                {
                    Console.Clear();
                    DataMenu.ChosenContractMessage();
                    BuildContractList objectContract = new BuildContractList();
                    objectContract.Display();
                    ContractActions ob = new ContractActions();
                    ob.ContractMaster(objectContract);
                }
                else if (submenu == 2)
                {
                    Console.Clear();
                    DataMenu.ChosenBranchMessage();
                    BuildBranchList objectBranch = new BuildBranchList();
                    objectBranch.Display();
                    BranchActions ob = new BranchActions();
                    ob.BranchMaster(objectBranch);
                }
                else if (submenu == 3)
                {
                    Console.Clear();
                    DataMenu.ChosenAgentsMessage();
                    BuildAgentsList objectAgents = new BuildAgentsList();
                    objectAgents.DisplayAgentsInfo();
                    AgentsActions ob = new AgentsActions();
                    ob.AgentsMaster(objectAgents);
                }
                else if (submenu == 4)
                {
                    Console.Clear();
                    DataMenu.ChosenInsuranceType();
                    BuildInsuranceTypeList objectType = new BuildInsuranceTypeList();
                    objectType.Display();
                    TypeActions ob = new TypeActions();
                    ob.TypeMaster(objectType);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: неверный пункт меню");
                    Console.ResetColor();
                }
            }
        }
        public static void Author()
        {
            Console.Clear();
            MainMenu.AuthorInfo();
            MainMenu.AuthorMenu();
            int submenu = 10;
            while (submenu != 0)
            {
                TryCatch(ref submenu);
                if (submenu == 0)
                {
                    Console.Clear();
                    MainMenu.CompanyMessage();
                    MainMenu.General();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: неверный пункт меню");
                    Console.ResetColor();
                }
            }
        }
        static void Main()
        {
            int menu = 10;

            MainMenu.CompanyMessage();
            MainMenu.General();

            while (menu != 0)
            {
                TryCatch(ref menu);

                if (menu == 1)
                {
                    Data();
                }

                if (menu == 2)
                {
                    Author();
                }

                if (menu != 1 && menu != 2 && menu != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: неверный пункт меню");
                    Console.ResetColor();
                }
            }

            MainMenu.EndOfProgramm();
            Console.ReadKey();
        }
    }
}
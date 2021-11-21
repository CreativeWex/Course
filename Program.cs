using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 10;
            int errorFlag = 0;

            Messages.CompanyMessage();
            Messages.MenuMessage();

            while (menu != 0)
            {
                Console.Write("> ");
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: " + e.Message);
                    Console.ResetColor();
                    break;

                }


                if (menu == 1)
                {
                    Console.Clear();
                    Messages.ChosenContractMessage();

                    BuildContractList objectContract = new BuildContractList(ref errorFlag);

                    if (errorFlag == 1)
                        break;

                    objectContract.DisplayContractInfo();
                    Messages.MenuMessage();

                }

                else if (menu == 2)
                {
                    Console.Clear();
                    Messages.ChosenBranchMessage();

                    BuildBranchList objectBranch = new BuildBranchList(ref errorFlag);

                    if (errorFlag == 1)
                        break;

                    objectBranch.DisplayBranchInfo();
                    Messages.MenuMessage();

                }

                else if (menu == 3)
                {
                    Console.Clear();
                    Messages.ChosenAgentsMessage();

                    BuildAgentsList objectAgents = new BuildAgentsList(ref errorFlag);

                    if (errorFlag == 1)
                        break;

                    objectAgents.DisplayAgentsInfo();
                    Messages.MenuMessage();

                }
            }

            Messages.EndOfProgramm();
            Console.ReadKey();
        }
    }
}

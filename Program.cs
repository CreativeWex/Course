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

            Messages.CompanyMessage();
            Messages.MenuMessage();

            while (true)
            {
                Console.Write(">");
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
                    BuildContractList objectContract = new BuildContractList();
                    objectContract.DisplayContractInfo();


                }

                else if (menu == 2)
                {
                    Messages.BranchChosenMessage();
                    BuildBranchList objectBranch = new BuildBranchList();
                    objectBranch.DisplayBranchInfo();




                }

                else if (menu == 3)
                {
                    Messages.AgentsChosenMessage();
                    BuildAgentsList objectAgents = new BuildAgentsList();
                    objectAgents.DisplayAgentsInfo();



                }


                else if (menu == 0)
                    break;
            }


            Messages.EndOfProgramm();
            Console.ReadKey();
        }
    }
}

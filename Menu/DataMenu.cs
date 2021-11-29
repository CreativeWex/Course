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
        static public void Exit(bool unlockContract, bool unlockBranch, bool unlockAgents)
        {
            Console.Clear();
            if (unlockContract == false || unlockBranch == false || unlockAgents == false)
            {
                MainMenu.GeneralLocked();
                return;
            }
                
            MainMenu.General();
        }
        static public bool Contract()
        {
            int errorFlag = 0;

            Console.Clear();
            DataMenu.ChosenContractMessage();
            BuildContractList objectContract = new BuildContractList(ref errorFlag);
            objectContract.DisplayContractInfo();
            MainMenu.Data();

            if (errorFlag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool Branch()
        {
            int errorFlag = 0;

            Console.Clear();
            DataMenu.ChosenBranchMessage();
            BuildBranchList objectBranch = new BuildBranchList(ref errorFlag);
            objectBranch.DisplayBranchInfo();
            MainMenu.Data();

            if (errorFlag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool Agents()
        {
            int errorFlag = 0;

            Console.Clear();
            DataMenu.ChosenBranchMessage();
            BuildAgentsList objectAgents = new BuildAgentsList(ref errorFlag);
            objectAgents.DisplayAgentsInfo();
            MainMenu.Data();

            if (errorFlag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

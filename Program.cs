using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static bool unlockContract = false;
        static bool unlockBranch = false;
        static bool unlockAgents = false;

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
        public static void Data(ref bool unlocked)
        {
            int submenu = 10;

            Console.Clear();
            MainMenu.Data();
            while (submenu != 0)
            {
                TryCatch(ref submenu);

                if (submenu == 0)
                {
                    DataMenu.Exit(unlockContract, unlockBranch, unlockAgents);
                    if (unlockContract == true && unlockBranch == true && unlockAgents == true)
                    {
                        unlocked = true;
                    }
                    break;
                }

                else if (submenu == 1)
                {
                    unlockContract = true;
                    if (DataMenu.Contract())
                        break;
                }

                else if (submenu == 2)
                {
                    unlockBranch = true;
                    if (DataMenu.Branch())
                        break;
                }

                else if (submenu == 3)
                {
                    unlockAgents = true;
                    if (DataMenu.Agents())
                        break;
                }
            }
        }
        public static void Salary()
        {
            int errorFlag = 0;

            Console.Clear();
            MainMenu.SalaryInfo();
            BuildContractList source = new BuildContractList(ref errorFlag);
            BuildSalary ob = new BuildSalary();
        }
        public static void Author()
        {
            Console.Clear();
            MainMenu.AuthorInfo();
            MainMenu.General();
        }
        static void Main(string[] args)
        {
            int menu = 10;
            bool unlocked = false;

            MainMenu.CompanyMessage();
            MainMenu.GeneralLocked();

            while (menu != 0)
            {
                TryCatch(ref menu);

                if (menu == 1)
                {
                    Data(ref unlocked);
                }

                else if (menu == 3 && unlocked == false)
                {
                    MainMenu.IsntUnlocked();
                }

                else if (menu == 3)
                {
                    Salary();
                }

                else if (menu == 9)
                {
                    Author();
                }
            }

            MainMenu.EndOfProgramm();
            Console.ReadKey();
        }
    }
}
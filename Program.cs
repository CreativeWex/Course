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
                Console.Write("menu: ");
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
                    

                }




                if (menu == 0)
                    break;
            }


            Messages.EndOfProgramm();
            Console.ReadKey();
        }
    }
}

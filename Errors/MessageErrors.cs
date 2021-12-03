using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class MessageErrors
    {
        static public void ErrorString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка: неверный формат строк(и)\n");
            Console.ResetColor();
        }

        static public void ErrorBranchName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате кода филиала\n");
            Console.ResetColor();
        }

        static public void ErrorPhoneNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате номера телефона\n");
            Console.ResetColor();
        }

        static public void ErrorDate()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате даты\n");
            Console.ResetColor();
        }

        static public void ErrorContractNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате номера договора\n");
            Console.ResetColor();
        }

        static public void ErrorTariffRate()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате Тарифной ставки\n");
            Console.ResetColor();
        }

        static public void ErrorSumm()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате Cтраховой суммы\n");
            Console.ResetColor();
        }

        static public void BuildListType(string type)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] Ошибка: неверно задан вид страхования: {type}\n");
            Console.ResetColor();
        }
        static public void ContractError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] Ошибка: неверно заданы параметры договора \n");
            Console.ResetColor();
        }
        static public void ContractError(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] Ошибка: неверно задан параметр {str} \n");
            Console.ResetColor();
        }
        static public void ContractError(int str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] Ошибка: неверно задан параметр {str} \n");
            Console.ResetColor();
        }
    }
}

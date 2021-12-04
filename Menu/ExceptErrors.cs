using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        static public void ViewError(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] Ошибка: неверно задан параметр {str} \n");
            Console.ResetColor();
        }
        static public void ViewError(int str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] Ошибка: неверно задан параметр {str} \n");
            Console.ResetColor();
        }
        static public void ViewError(double str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] Ошибка: неверно задан параметр {str} \n");
            Console.ResetColor();
        }
        static public void BranchError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] Ошибка: неверно заданы параметры филиалов \n");
            Console.ResetColor();
        }
        static public void AgentsError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] Ошибка: неверно заданы параметры агентов \n");
            Console.ResetColor();
        }
    }
    class Errors
    {
        public static bool StrHasOnlyNums(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] <= '0' && str[i] >= '9')
                {
                    return false;
                }
            }
            return true;
        }
        public static bool StrHasOnlyLetters(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] <= 'a' && str[i] >= 'z') || (str[i] <= 'A' && str[i] >= 'Z'))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool FileHasErrors(string filename, ref bool errors) // Проверка на открытие файла
        {
            try { StreamReader test = new StreamReader(filename); }

            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: " + e.Message);
                Console.ResetColor();
                errors = true;
                return true;
            }
            return false;
        }
        public static bool IsNegative(int num) // //Проверка поступающих чисел
        {
            if (num < 0)
                return true;

            return false;
        }
        public static bool IsNegative(double num) // //Проверка поступающих чисел
        {
            if (num < 0)
                return true;

            return false;
        }
        public static bool BuildHasErrors(string type) //InsuranceType
        {
            if (type == "Страхование от несчастных случаев и болезней" || type == "Медицинское страхование" || type == "трахование средств наземного транспорта"
                || type == "Страхование средств железнодорожного транспорта" || type == "Страхование грузов" || type == "Страхование имущества юридических лиц"
                || type == "Страхование имущества граждан" || type == "Сельскохозяйственное страхование" || type == "Страхование средств водного транспорта"
                || type == "Страхование средств воздушного транспорта" || type == "Страхование средств наземного транспорта" || type == "Страхование гражданской ответственности владельцев автотранспортных средств"
                || type == "Страхование финансовых рисков" || type == "Страхование гражданской ответственности за причинение вреда третьим лицам")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool BuildHasErrors(string numberOfContract, string date, string readedSum, string readedTariffRate) // Contract
        {
            bool numberOfContractCorrect = true;
            bool dateCorrect = true;
            bool summCorrect = true;
            bool tariffRateCorrect = true;
            int summ;
            double tariffRate;

            if (StrHasOnlyNums(numberOfContract) == false || numberOfContract.Length != 6)
            {
                numberOfContractCorrect = false;
            }

            if (Date(date) == false)
            {
                dateCorrect = false;
            }

            if (!Int32.TryParse(readedSum, out summ) || IsNegative(summ) == true)
            {
                summCorrect = false;
            }

            if (!Int32.TryParse(readedSum, out summ) || IsNegative(summ) == true)
            {
                summCorrect = false;
            }

            if (!Double.TryParse(readedTariffRate, out tariffRate) || IsNegative(tariffRate) == true || tariffRate > 100)
            {
                summCorrect = false;
            }

            if (numberOfContractCorrect == false)
            {
                MessageErrors.ViewError(numberOfContract);
            }

            if (dateCorrect == false)
            {
                MessageErrors.ViewError(date);
            }

            if (summCorrect == false)
            {
                MessageErrors.ViewError(summ);
            }

            if (tariffRateCorrect == false)
            {
                MessageErrors.ViewError(tariffRate);
            }

            if (numberOfContractCorrect == true && dateCorrect == true && summCorrect == true && tariffRateCorrect == true)
            {
                return false;
            }
            return true;
        }
        public static bool BuildHasErrors(string name, string readedCode, string adress, string phoneNumber, string birthday)
        {
            bool nameCorrect = true;
            bool codeCorrect = true;
            bool phoneNumberCorrect = true;
            bool birthdayCorrect = true;
            int code;

            if (StrHasOnlyLetters(name) == false)
            {
                nameCorrect = false;
            }

            if (!Int32.TryParse(readedCode, out code))
            {
                codeCorrect = false;
                MessageErrors.ErrorBranchName();
            }
            if (Errors.IsNegative(code))
            {
                codeCorrect = false;
                MessageErrors.ErrorBranchName();
            }

            if (Errors.CheckPhoneNumber(phoneNumber))
            {
                phoneNumberCorrect = false;
                MessageErrors.ErrorPhoneNumber();
            }
            if (Date(birthday) == false)
            {
                birthdayCorrect = false;
            }

            if (nameCorrect == false)
            {
                MessageErrors.ViewError(name);
            }
            if (codeCorrect == false)
            {
                MessageErrors.ViewError(code);
            }
            if (phoneNumberCorrect == false)
            {
                MessageErrors.ViewError(phoneNumber);
            }
            if (birthdayCorrect == false)
            {
                MessageErrors.ViewError(birthday);
            }

            if (nameCorrect == true && codeCorrect == true && phoneNumberCorrect == true && birthdayCorrect == true)
            {
                return false;
            }

            return true;
        } //Agents
        public static bool BranchHasErrors(string name, string readedCode, string adress, string phoneNumber) //Branch
        {
            bool nameCorrect = true;
            bool codeCorrect = true;
            bool adressCorrect = true;
            bool phoneNumberCorrect = true;
            int code;

            if (StrHasOnlyLetters(name) == false)
            {
                nameCorrect = false;
            }

            if (!Int32.TryParse(readedCode, out code))
            {
                codeCorrect = false;
                MessageErrors.ErrorBranchName();
            }
            if (Errors.IsNegative(code))
            {
                codeCorrect = false;
                MessageErrors.ErrorBranchName();
            }

            if (Errors.CheckPhoneNumber(phoneNumber))
            {
                phoneNumberCorrect = false;
                MessageErrors.ErrorPhoneNumber();
            }
            if (nameCorrect == true && codeCorrect == true && adressCorrect == true && phoneNumberCorrect == true)
            {
                return false;
            }

            return true;
        }
        public static bool CheckName(string str) //Проверка поступающих строк
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    return true;
                }
            }

            if (str.Length > 256)
            {
                return true;
            }

            return false;
        }
        public static bool CheckPhoneNumber(string str) //телефон
        {
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    return true;
                }
            }

            if (str.Length != 11)
            {
                return true;
            }

            return false;
        }
        public static bool CheckContractNumber(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] <= 0 && str[i] >= 9))
                {
                    return true;
                }
            }

            if (str.Length != 6)
            {
                return true;
            }

            return false;
        }
        public static bool Date(string str)
        {
            int dotCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.')
                {
                    dotCount++;
                }
                if ((str[i] >= 'a' && str[i] <= 'A') || (str[i] >= 'a' && str[i] <= 'A'))
                {
                    return false;
                }
            }
            if (dotCount != 2)
            {
                return false;
            }
            if (str.Length < 10)
            {
                return false;
            }
            string[] arr = str.Split('.');
            if (Convert.ToInt32(arr[0]) > 31 || Convert.ToInt32(arr[0]) <= 0)
            {
                return false;
            }
            if (Convert.ToInt32(arr[1]) > 12 || Convert.ToInt32(arr[0]) <= 0)
            {
                return false;
            }
            return true;
        }
    }
}

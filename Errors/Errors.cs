using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Course
{
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

            if (numberOfContractCorrect == true && dateCorrect == true && summCorrect == true && tariffRateCorrect == true)
            {
                return false;
            }
            return true;
        }
        //public static bool BuildHasErrors(string name, int code, string adress, string phoneNumber)
        //{
        //    if (CatchErrors.CheckName(name))
        //    {
        //        MessageErrors.ErrorString();
        //    }

        //    if (!Int32.TryParse(input.ReadLine(), out code))
        //    {
        //        MessageErrors.ErrorBranchName();
        //    }
        //    if (CatchErrors.IsNegative(code))
        //    {
        //        MessageErrors.ErrorBranchName();
        //    }

        //    if (CatchErrors.CheckPhoneNumber(phoneNumber))
        //    {
        //        MessageErrors.ErrorPhoneNumber();
        //    }

        //    return true;
        //}

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

            if (str.Length != 18)
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
                    Console.WriteLine("1");
                    return false;
                }
            }
            if (dotCount != 2)
            {
                Console.WriteLine("2");
                return false;
            }

            if (str.Length < 10)
            {
                Console.WriteLine("3");
                return false;
            }

            string[] arr = str.Split('.');
            if (Convert.ToInt32(arr[0]) > 31 || Convert.ToInt32(arr[0]) <= 0)
            {
                Console.WriteLine("4");
                return false;
            }
            if (Convert.ToInt32(arr[1]) > 12 || Convert.ToInt32(arr[0]) <= 0)
            {
                Console.WriteLine("5");
                return false;
            }

            return true;
        }
    }
}

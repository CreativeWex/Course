using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Course
{
    class CatchErrors
    {
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
        public static bool CheckFile(string filename) // Проверка на открытие файла
        {
            try
            {
                StreamReader test = new StreamReader(filename);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: " + e.Message);
                Console.ResetColor();
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

            if (str.Length != 18)
            {
                return true;
            }    

            return false;
        }

        public static bool CheckDate(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    return true;
                }
            }

            if (str.Length != 9 && str.Length != 10)
            {
                return true;
            }

            return false;
        }

        public static bool CheckContractNumber(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] >= 0 && str[i] <= 9))
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
    }
}

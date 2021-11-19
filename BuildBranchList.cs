using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Course
{
    class BuildBranchList
    {
        List<Branch> BuildedContract = new List<Branch>();
        int listSize;
        string filename = "SourceBranch.txt";

        public bool CheckFile() // Проверка на открытие файла
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

        public BuildBranchList()
        {
            string name = "";
            int code = 0; ;
            string adress = "";
            string phoneNumber = "";

            CheckFile();
            StreamReader input = new StreamReader(filename);
            while (!(input.EndOfStream))
            {
                name = input.ReadLine();
                //проверить имя

                //if (!Int32.TryParse(input.ReadLine(), out code))                                       
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("Ошибка в коде филиала");
                //    Console.ResetColor();
                //    break;
                //}
                Int32.TryParse(input.ReadLine(), out code);
                //проверить

                adress = input.ReadLine();
                //проверка

                phoneNumber = input.ReadLine();
                //проверка
                BuildedContract.Add(new Branch(name, code, adress, phoneNumber));
            }
            input.Close();
            listSize = BuildedContract.Count;
        }//конец конструктора

        public void DisplayBranchInfo()
        {
            for (int i = 0; i < listSize; i++)
                BuildedContract[i].Display();
        }








    }//Конец класса
}

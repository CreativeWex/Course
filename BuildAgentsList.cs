using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleTables;

namespace Course
{
    class BuildAgentsList
    {
        List<Agents> BuildedAgends = new List<Agents>();
        int listSize;
        string filename = "SourceAgents.txt";

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

        public BuildAgentsList()
        {
            string name = "";
            int code = 0; ;
            string adress = "";
            string phoneNumber = "";
            string birthday = "";

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

                birthday = input.ReadLine();
                //проверка

                BuildedAgends.Add(new Agents(name, code, adress, phoneNumber, birthday));
            }
            input.Close();
            listSize = BuildedAgends.Count;
        }//конец конструктора

        public void DisplayAgentsInfo()
        {
            var table = new ConsoleTable("Имя", "Номер телефона", "Адрес", "Код филиала", "Дата рождения");
            for (int i = 0; i < listSize; i++)
            {
                table.AddRow(BuildedAgends[i].Name, BuildedAgends[i].PhoneNumber, BuildedAgends[i].Adress, BuildedAgends[i].Code, BuildedAgends[i].Birthday);
            }
            table.Write(Format.Default);
            Console.WriteLine();
        }






    }//Конец класса
}

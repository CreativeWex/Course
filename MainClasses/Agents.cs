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
        public List<Agents> listAgents = new List<Agents>();
        string filename;
        string name;
        int code;
        string adress;
        string phoneNumber;
        string birthday;

        public BuildAgentsList()
        {
            
            bool errors = false;
            string readedCode;
            Console.WriteLine("Файл для считывания (по умолчанию SourceAgents.txt):");
            Console.Write("> ");
            filename = Console.ReadLine();
            if (Errors.FileHasErrors(filename, ref errors))
                return;
            StreamReader input = new StreamReader(filename);

            while (!(input.EndOfStream))
            {
                name = input.ReadLine();
                readedCode = input.ReadLine();
                adress = input.ReadLine();
                phoneNumber = input.ReadLine();
                birthday = input.ReadLine();

                if (Errors.BuildHasErrors(name, readedCode, adress, phoneNumber, birthday) == true || errors)
                {
                    MessageErrors.AgentsError();
                    break;
                }
                code = Convert.ToInt32(readedCode);
                listAgents.Add(new Agents(name, code, adress, phoneNumber, birthday));
            }
            input.Close();
        }
        public string Name
        {
            get { return name; }
        }
        public int Code
        {
            get { return code; }
        }
        public string Adress
        {
            get { return adress; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
        public string Birthday
        {
            get { return birthday; }
        }
        public void DisplayAgentsInfo()
        {
            var table = new ConsoleTable("Имя", "Номер телефона", "Адрес", "Код филиала", "Дата рождения");

            for (int i = 0; i < listAgents.Count; i++)
            {
                table.AddRow(listAgents[i].Name, listAgents[i].PhoneNumber, listAgents[i].Adress, listAgents[i].Code, listAgents[i].Birthday);
            }

            table.Write(Format.Default);
            Console.WriteLine();
        }
        public void Add()
        {
            string readedCode;

            Console.Write("ФИО сотрудника: ");
            name = Console.ReadLine();
            Console.Write("Код филиала: ");
            readedCode = Console.ReadLine();
            Console.Write("Адрес: ");
            adress = Console.ReadLine();
            Console.Write("Телефон: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Дата рождения: ");
            birthday = Console.ReadLine();

            if (Errors.BranchHasErrors(name, readedCode, adress, phoneNumber) == true)
            {
                MessageErrors.BranchError();
                return;
            }
            code = Convert.ToInt32(readedCode);
            listAgents.Add(new Agents(name, code, adress, phoneNumber, birthday));
        }
        public void Remove()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите пункт для удаления: ");
            Console.ResetColor();

            int i = Convert.ToInt32(Console.ReadLine());

            if (i > listAgents.Count || i < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: заданные данные отсутствуют");
                Console.ResetColor();
            }
            else
            {
                listAgents.RemoveAt(i - 1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[Запись успешно удалена]");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        public void Sort()
        {
            AgentsActions sorting = new AgentsActions();
            sorting.SortMessages();
            Console.Write(">");
            string param = Console.ReadLine();
            Console.Clear();
            if (param == "1")
            {
                listAgents =
                    (from index in listAgents
                     orderby index.Name
                     select index).ToList();
            }
            else if (param == "2")
            {
                listAgents =
                    (from index in listAgents
                     orderby index.Code
                     select index).ToList();
            }
            else if (param == "3")
            {
                listAgents =
                    (from index in listAgents
                     orderby index.Adress
                     select index).ToList();
            }
            else if (param == "4")
            {
                listAgents =
                    (from index in listAgents
                     orderby index.PhoneNumber
                     select index).ToList();
            }
            else if (param == "5")
            {
                listAgents =
                    (from index in listAgents
                     orderby index.Birthday
                     select index).ToList();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка ввода параметра сортировки");
                Console.ResetColor();
            }
        }
        public void Save()
        {
            string saveFile;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Сохранение данных]");
            Console.ResetColor();

            Console.WriteLine("Введите название файла для сохранения");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Внимание! Данные в выбранном файле будут перезаписаны!");
            Console.ResetColor();
            Console.Write("> ");
            saveFile = Console.ReadLine();

            StreamWriter input = new StreamWriter(saveFile);
            for (int i = 0; i < listAgents.Count; i++)
            {
                input.WriteLine(listAgents[i].Name);
                input.WriteLine(listAgents[i].Code);
                input.WriteLine(listAgents[i].Adress);
                input.WriteLine(listAgents[i].PhoneNumber);
                input.WriteLine(listAgents[i].Birthday);
            }
            input.Close();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Данные успешно сохранены в ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(saveFile);
            Console.ResetColor();
        }
    }//Конец класса
}

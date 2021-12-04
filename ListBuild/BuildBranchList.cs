using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleTables;

namespace Course
{
    class BuildBranchList
    {
        public List<Branch> list_Branch = new List<Branch>();
        string filename = "SourceBranch.txt";
        string name;
        int code;
        string adress;
        string phoneNumber;

        public BuildBranchList()
        {
            bool errors = false;
            string readedCode;
            Errors.FileHasErrors(filename, ref errors);
            StreamReader input = new StreamReader(filename);

            while (!(input.EndOfStream))
            {
                name = input.ReadLine();
                readedCode = input.ReadLine();
                adress = input.ReadLine();
                phoneNumber = input.ReadLine();

                if (Errors.BranchHasErrors(name, readedCode, adress, phoneNumber) == true || errors)
                {
                    MessageErrors.BranchError();
                    break;
                }
                code = Convert.ToInt32(readedCode);
                list_Branch.Add(new Branch(name, code, adress, phoneNumber));
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

        public List<Branch> ListBranch
        {
            get { return list_Branch; }
        }

        public void Display()
        {
            var table = new ConsoleTable("Филиал", "Код филиала", "Адрес", "Телефон");

            for (int i = 0; i < list_Branch.Count; i++)
            {
                table.AddRow(list_Branch[i].Name, list_Branch[i].Code, list_Branch[i].Adress, list_Branch[i].PhoneNumber);
            }

            table.Write(Format.Default);
            Console.WriteLine();
        }
        public void Add()
        {
            string readedCode;

            Console.Write("Филиал: ");
            name = Console.ReadLine();
            Console.Write("Код филиала: ");
            readedCode = Console.ReadLine();
            Console.Write("Адрес: ");
            adress = Console.ReadLine();
            Console.Write("Телефон: ");
            phoneNumber = Console.ReadLine();

            if (Errors.BranchHasErrors(name, readedCode, adress, phoneNumber) == true)
            {
                MessageErrors.BranchError();
                return;
            }
            code = Convert.ToInt32(readedCode);
            list_Branch.Add(new Branch(name, code, adress, phoneNumber));
        }

        public void Remove()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите пункт для удаления: ");
            Console.ResetColor();

            int i = Convert.ToInt32(Console.ReadLine());

            if (i > list_Branch.Count || i < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: заданные данные отсутствуют");
                Console.ResetColor();
            }
            else
            {
                list_Branch.RemoveAt(i - 1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[Запись успешно удалена]");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        public void Sort()
        {
            BranchActions.SortMessages();
            Console.Write(">");
            string param = Console.ReadLine();
            Console.Clear();
            if (param == "1")
            {
                list_Branch =
                    (from index in list_Branch
                     orderby index.Name
                     select index).ToList();
            }
            else if (param == "2")
            {
                list_Branch =
                    (from index in list_Branch
                     orderby index.Code
                     select index).ToList();
            }
            else if (param == "3")
            {
                list_Branch =
                    (from index in list_Branch
                     orderby index.Adress
                     select index).ToList();
            }
            else if (param == "4")
            {
                list_Branch =
                    (from index in list_Branch
                     orderby index.PhoneNumber
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
            for (int i = 0; i < list_Branch.Count; i++)
            {
                input.WriteLine(list_Branch[i].Name);
                input.WriteLine(list_Branch[i].Code);
                input.WriteLine(list_Branch[i].Adress);
                input.WriteLine(list_Branch[i].PhoneNumber);
            }
            input.Close();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Данные успешно сохранены в ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(saveFile);
            Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleTables;

namespace Course
{
    class BuildInsuranceTypeList
    {
        public List<InsuranceType> list_InsuranceType = new List<InsuranceType>();
        string filename = "SourceType.txt";
        string name;
        string type;
        public BuildInsuranceTypeList()
        {
            bool errors = false;
            Errors.FileHasErrors(filename, ref errors);
            StreamReader input = new StreamReader(filename);

            while (!(input.EndOfStream))
            {
                string[] readed = input.ReadLine().Split(')');
                name = readed[0];
                type = readed[1];

                if (Errors.BuildHasErrors(type) || errors)
                {
                    MessageErrors.BuildListType(type);
                    break;
                }
                list_InsuranceType.Add(new InsuranceType(name, type));
            }
            input.Close();
        }

        public string Name
        {
            get { return name; }
        }
        public string Type
        {
            get { return type; }
        }
        public void Display()
        {
            var table = new ConsoleTable("Код страхования", "Вид страхования");
            for (int i = 0; i < list_InsuranceType.Count; i++)
            {
                table.AddRow(list_InsuranceType[i].Name, list_InsuranceType[i].Type);
            }
            table.Write();
        }
        public void Add()
        {
            Console.Write("Код страхования: ");
            name = Console.ReadLine();
            Console.Write("Вид страхования: ");
            type = Console.ReadLine();

            if (Errors.BuildHasErrors(type) == true)
            {
                MessageErrors.BranchError();
                return;
            }
            list_InsuranceType.Add(new InsuranceType(name, type));
        }
        public void Remove()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите пункт для удаления: ");
            Console.ResetColor();

            int i = Convert.ToInt32(Console.ReadLine());

            if (i > list_InsuranceType.Count || i < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: заданные данные отсутствуют");
                Console.ResetColor();
            }
            else
            {
                list_InsuranceType.RemoveAt(i - 1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[Запись успешно удалена]");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        public void Sort()
        {
            TypeActions.SortMessages();
            Console.Write(">");
            string param = Console.ReadLine();
            Console.Clear();
            if (param == "1")
            {
                list_InsuranceType =
                    (from index in list_InsuranceType
                     orderby index.Name
                     select index).ToList();
            }
            else if (param == "2")
            {
                list_InsuranceType =
                    (from index in list_InsuranceType
                     orderby index.Type
                     select index).ToList();
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
            for (int i = 0; i < list_InsuranceType.Count; i++)
            {
                input.WriteLine($"{list_InsuranceType[i].Name}){list_InsuranceType[i].Type}");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleTables;

namespace Course
{
    class BuildContractList
    {
        public List<Contract> list_Contract = new List<Contract>();
        string filename = "SourceContract.txt";
        string numberOfContract; //Номер договора
        string date; // Дата заключения
        int summ; // Страховая сумма
        double tariffRate; // Тарифная ставка
        int branch; // Филиал
        string type;
        string name;
        public BuildContractList()
        {

            bool errors = false;
            string readedSum;
            string readedTariffRate;
            string readedBranch;
            Errors.FileHasErrors(filename, ref errors);
            StreamReader input = new StreamReader(filename);

            while (!(input.EndOfStream))
            {
                numberOfContract = input.ReadLine();
                date = input.ReadLine();
                readedSum = input.ReadLine();
                readedTariffRate = input.ReadLine();
                readedBranch = input.ReadLine();
                type = input.ReadLine();
                name = input.ReadLine(); 

                if (Errors.BuildHasErrors(numberOfContract, date, readedSum, readedTariffRate) == true || errors)
                {
                    MessageErrors.ContractError();
                    break;
                }
                summ = Convert.ToInt32(readedSum);
                tariffRate = Convert.ToDouble(readedTariffRate);
                branch = Convert.ToInt32(readedBranch);

                list_Contract.Add(new Contract(name, type, numberOfContract, date, summ, tariffRate, branch));
            }
            input.Close();
        } // конец конструктора

        public string NumberOfContract
        {
            get { return numberOfContract; }
        }
        public string Date
        {
            get { return date; }
        }
        public int Summ
        {
            get { return summ; }
        }
        public double TariffRate
        {
            get { return tariffRate; }
        }
        public int Branch
        {
            get { return branch; }
        }
        public string Type
        {
            get { return type; }
        }
        public string Name
        {
            get { return name; }
        }

        public void Add()
        {
            string numberOfContract; //Номер договора
            string date; // Дата заключения
            int summ; // Страховая сумма
            double tariffRate; // Тарифная ставка
            int branch; // Филиал
            string type;
            string name;
            string readedSum;
            string readedTariffRate;
            string readedBranch;

            Console.Write("Номер договора: ");
            numberOfContract = Console.ReadLine();
            Console.Write("Дата заключения: ");
            date = Console.ReadLine();
            Console.Write("Страховая сумма: ");
            readedSum = Console.ReadLine();
            Console.Write("Тарифная ставка: ");
            readedTariffRate = Console.ReadLine();
            Console.Write("Код филиала: ");
            readedBranch = Console.ReadLine();
            Console.Write("Вид страхования: ");
            type = Console.ReadLine();
            Console.Write("Имя Агента: ");
            name = Console.ReadLine();

            if (Errors.BuildHasErrors(numberOfContract, date, readedSum, readedTariffRate) == true)
            {
                MessageErrors.ContractError();
                return;
            }
            summ = Convert.ToInt32(readedSum);
            tariffRate = Convert.ToDouble(readedTariffRate);
            branch = Convert.ToInt32(readedBranch);

            list_Contract.Add(new Contract(name, type, numberOfContract, date, summ, tariffRate, branch));
        }

        public void Remove()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите пункт для удаления: ");
            Console.ResetColor();

            int i = Convert.ToInt32(Console.ReadLine());

            if (i > list_Contract.Count || i < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: заданные данные отсутствуют");
                Console.ResetColor();
            }
            else
            {
                list_Contract.RemoveAt(i - 1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[Запись успешно удалена]");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        public void Display()
        {
            var table = new ConsoleTable("Номер договора", "Дата заключения", "Страховая сумма", "Тарифная ставка", "Код филиала", "Вид страхования", "Имя Агента");
            for (int i = 0; i < list_Contract.Count; i++)
            {
                table.AddRow(list_Contract[i].NumberOfContract, list_Contract[i].Date, list_Contract[i].Summ, list_Contract[i].TariffRate, list_Contract[i].Branch, list_Contract[i].Type, list_Contract[i].Name);
            }
            table.Write(Format.Default);
            Console.WriteLine();
        }
        public void Sort()
        {
            ContractActions.SortMessages();
            Console.WriteLine(">");
            string param = Console.ReadLine();
            Console.Clear();
            if (param == "1")
            {
                list_Contract =
                    (from index in list_Contract
                     orderby index.NumberOfContract
                     select index).ToList();
            }
            else if (param == "2")
            {
                list_Contract =
                    (from index in list_Contract
                     orderby index.Date
                     select index).ToList();
            }
            else if (param == "3")
            {
                list_Contract =
                    (from index in list_Contract
                     orderby index.Summ
                     select index).ToList();
            }
            else if (param == "4")
            {
                list_Contract =
                    (from index in list_Contract
                     orderby index.TariffRate
                     select index).ToList();
            }
            else if (param == "5")
            {
                list_Contract =
                    (from index in list_Contract
                     orderby index.Branch
                     select index).ToList();
            }
            else if (param == "6")
            {
                list_Contract =
                    (from index in list_Contract
                     orderby index.Type
                     select index).ToList();
            }
            else if (param == "7")
            {
                list_Contract =
                    (from index in list_Contract
                     orderby index.Name
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
            Console.Write(">");
            saveFile = Console.ReadLine();

            StreamWriter input = new StreamWriter(saveFile);
            for (int i = 0; i < list_Contract.Count; i++)
            {
                input.WriteLine(list_Contract[i].NumberOfContract);
                input.WriteLine(list_Contract[i].Date);
                input.WriteLine(list_Contract[i].Summ);
                input.WriteLine(list_Contract[i].TariffRate);
                input.WriteLine(list_Contract[i].Branch);
                input.WriteLine(list_Contract[i].Type);
                input.WriteLine(list_Contract[i].Name);
            }
            input.Close();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Данные успешно сохранены в");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(saveFile);
            Console.ResetColor();
        }
    }
}

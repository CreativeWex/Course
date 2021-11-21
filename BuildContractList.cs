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
        List<Contract> BuildedContract = new List<Contract>();
        int listSize;
        string filename = "SourceContract.txt";

        public BuildContractList(ref int errorFlag)
        {
            string numberOfContract; //Номер договора
            string date; // Дата заключения
            int summ; // Страховая сумма
            double tariffRate; // Тарифная ставка
            string branch; // Филиал
            string insuranceType; //Вид страхования
            string name; // Имя Клиента

            CatchErrors.CheckFile(filename);
            StreamReader input = new StreamReader(filename);

            while (!(input.EndOfStream))
            {
                numberOfContract = input.ReadLine();
                if (CatchErrors.CheckContractNumber(numberOfContract))
                {
                    Messages.ErrorContractNumber();
                    errorFlag = 1;
                    break;
                }

                date = input.ReadLine();
                if (CatchErrors.CheckDate(date))
                {
                    Messages.ErrorDate();
                    errorFlag = 1;
                    break;
                }


                if (!Int32.TryParse(input.ReadLine(), out summ))
                {
                    Messages.ErrorSumm();
                    errorFlag = 1;
                    break;
                }
                if (CatchErrors.IsNegative(summ))
                {
                    Messages.ErrorSumm();
                    errorFlag = 1;
                    break;
                }


                if (!Double.TryParse(input.ReadLine(), out tariffRate))
                {
                    Messages.ErrorTariffRate();
                    errorFlag = 1;
                    break;
                }
                if (CatchErrors.IsNegative(tariffRate) || tariffRate > 100)
                {
                    Messages.ErrorTariffRate();
                    errorFlag = 1;
                    break;
                }

                branch = input.ReadLine();                                                                               
                if (CatchErrors.CheckName(branch))
                {
                    Messages.ErrorString();
                    errorFlag = 1;
                    break;
                }

                insuranceType = input.ReadLine();              //------------------------------------------------СДеЛАТЬ ПРОВЕРКУ

                name = input.ReadLine();
                if (CatchErrors.CheckName(name))
                {
                    Messages.ErrorString();
                    errorFlag = 1;
                    break;
                }

                BuildedContract.Add(new Contract(name, insuranceType, numberOfContract, date, summ, tariffRate, branch));                                                          
            }

            input.Close();
            listSize = BuildedContract.Count;

        } // конец конструктора

        public void DisplayContractInfo()
        {
            var table = new ConsoleTable("Номер договора", "Дата заключения", "Страховая сумма", "Тарифная ставка", "Филиал", "Вид страхования", "Имя Клиента");
            for (int i = 0; i < listSize; i++)
            {
                table.AddRow(BuildedContract[i].NumberOfContract, BuildedContract[i].Date, BuildedContract[i].Summ, BuildedContract[i].TariffRate, BuildedContract[i].Branch, BuildedContract[i].Type, BuildedContract[i].Name);
            }
            table.Write(Format.Default);
            Console.WriteLine();
        }

    }// Конец класса
}
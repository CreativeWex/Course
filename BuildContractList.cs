using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Course
{
    class BuildContractList //КАК Я ХОЧУ СДОХНУТЬ
    {
        List<Contract> BuildedContract = new List<Contract>();
        int listSize;
        string filename = "SourceContract.txt";

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

        //public bool checkSurname(string surname) // Правильно ли введена фамилия
        //{
        //    int error = 0;

        //    if (surname == null)
        //        error++;
        //    for (int i = 0; i < surname.Length; i++)
        //        if (Char.IsDigit(surname[i]))
        //            error++;
        //    if (error == 0)
        //        return false;
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Error in surname");
        //        Console.ResetColor();
        //        return true;
        //    }
        //}
        public BuildContractList()
        {
            int numberOfContract; //Номер договора
            string date; // Дата заключения
            int summ; // Страховая сумма
            double tariffRate; // Тарифная ставка
            string branch; // Филиал
            string insuranceType; //Вид страхования
            string name; // Имя Клиента

            CheckFile();
            StreamReader input = new StreamReader(filename);

            while (!(input.EndOfStream))
            {
                //if (!Int32.TryParse(input.ReadLine(), out numberOfContract))                                            //Номер договора
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("Ошибка в номере договора");
                //    Console.ResetColor();
                //    break;
                //}
                Int32.TryParse(input.ReadLine(), out numberOfContract);

                date = input.ReadLine();                                                                            //Дата заключения

                if (!Int32.TryParse(input.ReadLine(), out summ))                                            //Страховая сумма
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка в номере договора");
                    Console.ResetColor();
                    break;
                }
                Int32.TryParse(input.ReadLine(), out summ);

                if (!Double.TryParse(input.ReadLine(), out tariffRate))                                            //Тарифная ставка
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка в номере договора");
                    Console.ResetColor();
                    break;
                }
                Double.TryParse(input.ReadLine(), out tariffRate);

                branch = input.ReadLine();                                                                                //Филиал

                insuranceType = input.ReadLine();                                                                       //Вид страхования

                name = input.ReadLine();


                BuildedContract.Add(new Contract(name, insuranceType, numberOfContract, date, summ, tariffRate, branch));                                                          //создание элемента списка
            }
            input.Close();
            listSize = BuildedContract.Count;
        } // конец конструктора

        //public void DisplayContractInfo()
        //{
        //    for (int i = 0; i < listSize; i++)
        //    {
        //        Console.WriteLine($"Тип страхования = {BuildedContract[i].InsuranceType}")
        //    }
        //}

    }// Конец класса



}

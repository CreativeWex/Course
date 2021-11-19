using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Course
{
    //class BuildContractList
    //{
    //    List<Contract> template = new List<Contract>();
    //    int listSize;
    //    string filename = "Contracts.txt";

    //    public bool CheckFile()
    //    {
    //        try
    //        {
    //            StreamReader test = new StreamReader(filename);
    //        }
    //        catch (Exception e) 
    //        {
    //            Console.ForegroundColor = ConsoleColor.Red;
    //            Console.WriteLine("Ошибка: " + e.Message);
    //            Console.ResetColor();
    //            return false;
    //        }
    //        return true;
    //    }

    //    //public bool checkSurname(string surname)
    //    //{
    //    //    int error = 0;

    //    //    if (surname == null)
    //    //        error++;
    //    //    for (int i = 0; i < surname.Length; i++)
    //    //        if (Char.IsDigit(surname[i]))
    //    //            error++;
    //    //    if (error == 0)
    //    //        return false;
    //    //    else
    //    //    {
    //    //        Console.ForegroundColor = ConsoleColor.Red;
    //    //        Console.WriteLine("Error in surname");
    //    //        Console.ResetColor();
    //    //        return true;
    //    //    }
    //    //}

    //    public BuildContractList()
    //    {
    //        int numberOfContract; //Номер договора
    //        string date; // Дата заключения
    //        double summ; // Страховая сумма
    //        double tariffRate; // Тарифная ставка
    //        string branch; // Филиал
    //        string insuranceType; //Вид страхования

    //        CheckFile();
    //        StreamReader input = new StreamReader(filename);

    //        while (!(input.EndOfStream))
    //        {
    //            //if (!Int32.TryParse(input.ReadLine(), out numberOfContract))
    //            //{
    //            //    Console.ForegroundColor = ConsoleColor.Red;
    //            //    Console.WriteLine("Ошибка в номере договора");
    //            //    Console.ResetColor();
    //            //    break;
    //            //}

    //            Int32.TryParse(input.ReadLine(), out numberOfContract);


    //            //marks = input.ReadLine();
    //            //string[] marksArray = marks.Split(' ');
    //            //for (int i = 0; i < marksArray.Length; i++)
    //            //    Int32.TryParse(marksArray[i], out progress[i]);

    //            //int[] copyprg = new int[progress.Length];
    //            //Array.Copy(progress, copyprg, progress.Length);
    //            date = ""; summ = 0; tariffRate = 1; branch = ""; insuranceType = "";                                  //Затычка
    //            template.Add(new Contract(numberOfContract, date, summ, tariffRate, branch, insuranceType));                                                          //создание элемента списка
    //        }
    //        input.Close();
    //        listSize = template.Count;
    //    }

    //    public void Print()
    //    {
    //        for (int i = 0; i < template.Count; i++)
    //            template[i].Display();
    //    }
    //    //public double CountAverage(int[] a)
    //    //{
    //    //    double avg = 0;

    //    //    for (int i = 0; i < size; i++)
    //    //        avg += a[i];
    //    //    return (avg / size);
    //    //}
    //    //public void ShowAverage()
    //    //{
    //    //    int flag = 0;
    //    //    for (int i = 0; i < listSize; i++)
    //    //    {
    //    //        if (CountAverage(classmate[i].Progress) > 4)
    //    //        {
    //    //            Console.WriteLine($"| {classmate[i].surname,10} | {classmate[i].group,1} group |");
    //    //            flag++;
    //    //        }
    //    //    }
    //    //    if (flag == 0)
    //    //        Console.WriteLine("No such students");
    //    //}
    //    //public void Sort()
    //    //{
    //    //    STUDENT insert;
    //    //    for (int next = 1; next < listSize; next++)
    //    //    {
    //    //        insert = classmate[next];
    //    //        int moveItem = next;
    //    //        while (moveItem > 0 && classmate[moveItem - 1].group > insert.group)
    //    //            moveItem--;
    //    //        classmate.RemoveAt(next);
    //    //        classmate.Insert(moveItem, insert);
    //    //    }
    //    //}
    //}//класс

}

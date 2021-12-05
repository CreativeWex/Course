using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace Course
{
    class BuildSalary
    {
        //static int size;
        //public BuildSalary()
        //{
        //    int errorFlag = 0;
        //    BuildContractList ob = new BuildContractList(ref errorFlag);
        //    size = ob.BuildedContract.Count;

        //    List<Salary> AgentSalary = new List<Salary>();
        //    double[] fee = new double[size];

        //    var table = new ConsoleTable("Сотрудник", "Стоимость контракта, руб.", "Номер контракта");

        //    for (int i = 0; i < size; i++)
        //    {
        //        fee[i] = ob.BuildedContract[i].Summ * ob.BuildedContract[i].TariffRate;
        //        AgentSalary.Add(new Salary(ob.BuildedContract[i].Name, fee[i]));
        //        table.AddRow(ob.BuildedContract[i].Name, fee[i], ob.BuildedContract[i].NumberOfContract);
        //    }

        //    table.Write();
        //    Console.WriteLine();
        //    //Summary(AgentSalary);
        //    MainMenu.General();
        //}
        //static void Summary(List<Salary> AgentSalary)
        //{
        //    var table = new ConsoleTable("Имя сотрудника", "Доход");
        //    List<Salary> Final = new List<Salary>();

        //    for (int i = 0; i < size; i++)
        //    {
        //        for (int j = 0; j < size - 1; j++)
        //        {
        //            if ((AgentSalary[i].Name) == AgentSalary[j].Name && i != j)
        //            {
        //                AgentSalary[i].InsuranceFee += AgentSalary[j].InsuranceFee;
        //            }

        //        }
        //    }
        //    table.Write();

        //}
    }
}

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
        
        public BuildSalary()
        {
            int errorFlag = 0;
            BuildContractList ob = new BuildContractList(ref errorFlag);
            int size = ob._BuildedContract.Count;

            List <Salary> AgentSalary = new List <Salary>();
            double[] fee = new double[size];

            var table = new ConsoleTable("Сотрудник","Стоимость контракта, руб.", "Номер контракта");

            for (int i = 0; i < size; i++)
            {
                fee[i] = ob._BuildedContract[i].Summ * ob._BuildedContract[i].TariffRate;
                table.AddRow(ob._BuildedContract[i].Name, fee[i], ob._BuildedContract[i].NumberOfContract);
            }

            table.Write();
            Console.WriteLine();
            MainMenu.General();
        }
    }
}
 
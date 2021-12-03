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

        }
    }
}

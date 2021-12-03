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

                if (Errors.BuildHasErrors(name, readedCode, adress, phoneNumber) || errors)
                {
                    //MessageErrors.BuildListType(type);
                }
                code = Convert.ToInt32(readedCode);
                list_Branch.Add(new Branch(name, code, adress, phoneNumber));
            }
            input.Close();
        }

        public List<Branch> ListBranch
        {
            get { return list_Branch; }
        }

        public void DisplayBranchInfo()
        {
            var table = new ConsoleTable("Филиал", "Код филиала", "Адрес", "Телефон");

            for (int i = 0; i < list_Branch.Count; i++)
            {
                table.AddRow(list_Branch[i].Name, list_Branch[i].Code, list_Branch[i].Adress, list_Branch[i].PhoneNumber);
            }

            table.Write(Format.Default);
            Console.WriteLine();
        }
    }
}

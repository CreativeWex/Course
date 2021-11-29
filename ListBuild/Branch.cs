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
        public List<Branch> BuildedBranch = new List<Branch>();
        int listSize;
        string filename = "SourceBranch.txt";

        public BuildBranchList(ref int errorFlag)
        {
            string name = "";
            int code = 0; ;
            string adress = "";
            string phoneNumber = "";

            CatchErrors.CheckFile(filename);
            StreamReader input = new StreamReader(filename);

            while (!(input.EndOfStream))
            {
                name = input.ReadLine();
                if (CatchErrors.CheckName(name))
                {
                    MessageErrors.ErrorString();
                    errorFlag = 1;
                    break;
                }

                if (!Int32.TryParse(input.ReadLine(), out code))
                {
                    MessageErrors.ErrorBranchName();
                    errorFlag = 1;
                    break;
                }
                if (CatchErrors.IsNegative(code))
                {
                    MessageErrors.ErrorBranchName();
                    errorFlag = 1;
                    break;
                }

                adress = input.ReadLine();

                phoneNumber = input.ReadLine();
                if (CatchErrors.CheckPhoneNumber(phoneNumber))
                {
                    MessageErrors.ErrorPhoneNumber();
                    errorFlag = 1;
                    break;
                }

                BuildedBranch.Add(new Branch(name, code, adress, phoneNumber));
            }
            input.Close();
            listSize = BuildedBranch.Count;
        }

        public List<Branch> Branch
        {
            get
            {
                return BuildedBranch;
            }
        }

        public void DisplayBranchInfo()
        {
            var table = new ConsoleTable("Филиал", "Код филиала", "Адрес", "Телефон");

            for (int i = 0; i < listSize; i++)
            {
                table.AddRow(BuildedBranch[i].Name, BuildedBranch[i].Code, BuildedBranch[i].Adress, BuildedBranch[i].PhoneNumber);
            }

            table.Write(Format.Default);
            Console.WriteLine();
        }

    }
}

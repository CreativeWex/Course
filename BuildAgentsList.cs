using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleTables;

namespace Course
{
    class BuildAgentsList
    {
        List<Agents> BuildedAgends = new List<Agents>();
        int listSize;
        string filename = "SourceAgents.txt";

        public BuildAgentsList(ref int errorFlag)
        {
            string name;
            int code;
            string adress;
            string phoneNumber;
            string birthday;

            CatchErrors.CheckFile(filename);
            StreamReader input = new StreamReader(filename);

            while (!(input.EndOfStream))
            {
                name = input.ReadLine();
                if (CatchErrors.CheckName(name))
                {
                    Messages.ErrorString();
                    errorFlag = 1;
                    break;
                }

                if (!Int32.TryParse(input.ReadLine(), out code))
                {
                    Messages.ErrorBranchName();
                    errorFlag = 1;
                    break;
                }
                if (CatchErrors.IsNegative(code))
                {
                    Messages.ErrorBranchName();
                    errorFlag = 1;
                    break;
                }

                adress = input.ReadLine();

                phoneNumber = input.ReadLine();
                if (CatchErrors.CheckPhoneNumber(phoneNumber))
                {
                    Messages.ErrorPhoneNumber();
                    errorFlag = 1;
                    break;
                }

                birthday = input.ReadLine();
                if (CatchErrors.CheckDate(birthday))
                {
                    Messages.ErrorDate();
                    errorFlag = 1;
                    break;
                }

                BuildedAgends.Add(new Agents(name, code, adress, phoneNumber, birthday));
            }

            input.Close();
            listSize = BuildedAgends.Count;
        }

        public void DisplayAgentsInfo()
        {
            var table = new ConsoleTable("Имя", "Номер телефона", "Адрес", "Код филиала", "Дата рождения");

            for (int i = 0; i < listSize; i++)
            {
                table.AddRow(BuildedAgends[i].Name, BuildedAgends[i].PhoneNumber, BuildedAgends[i].Adress, BuildedAgends[i].Code, BuildedAgends[i].Birthday);
            }

            table.Write(Format.Default);
            Console.WriteLine();
        }
    }//Конец класса
}

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
        public List<Agents> listAgents = new List<Agents>();
        string filename = "SourceAgents.txt";

        public BuildAgentsList()
        {
            string name;
            int code;
            string adress;
            string phoneNumber;
            string birthday;
            bool errors = false;

            Errors.FileHasErrors(filename, ref errors);
            StreamReader input = new StreamReader(filename);

            while (!(input.EndOfStream))
            {
                name = input.ReadLine();
                if (Errors.CheckName(name))
                {
                    MessageErrors.ErrorString();
                    errors = true;
                    break;
                }

                if (!Int32.TryParse(input.ReadLine(), out code))
                {
                    MessageErrors.ErrorBranchName();
                    errors = true;
                    break;
                }
                if (Errors.IsNegative(code))
                {
                    MessageErrors.ErrorBranchName();
                    errors = true;
                    break;
                }

                adress = input.ReadLine();

                phoneNumber = input.ReadLine();
                if (Errors.CheckPhoneNumber(phoneNumber))
                {
                    MessageErrors.ErrorPhoneNumber();
                    errors = true;
                    break;
                }

                birthday = input.ReadLine();
                if (!Errors.Date(birthday))
                {
                    MessageErrors.ErrorDate();
                    errors = true;
                    break;
                }

                listAgents.Add(new Agents(name, code, adress, phoneNumber, birthday));
            }
            input.Close();
        }

        public void DisplayAgentsInfo()
        {
            var table = new ConsoleTable("Имя", "Номер телефона", "Адрес", "Код филиала", "Дата рождения");

            for (int i = 0; i < listAgents.Count; i++)
            {
                table.AddRow(listAgents[i].Name, listAgents[i].PhoneNumber, listAgents[i].Adress, listAgents[i].Code, listAgents[i].Birthday);
            }

            table.Write(Format.Default);
            Console.WriteLine();
        }
    }//Конец класса
}

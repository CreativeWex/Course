using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Sorting
    {
        private void Message(string type)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[Список отсортирован по параметру {type}]");
            Console.ResetColor();
        }
        public void Contract(List<Contract> BuildedContract, string parameter)
        {
            BuildedContract =
                (from i in BuildedContract
                 orderby i.Name
                 select i).ToList();

            Message("Сортировка по алфавиту");
        }
    }
}

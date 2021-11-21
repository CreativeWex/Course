using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Sorts
    {
        int CompareString(string str1, string str2)
        {
            int i = 0;

            while (str1[i] != '0' || str2[i] != '0')
            {
                if (str1[i] != str2[i])
                {
                    return (str1[i] - str2[i]);
                }
            }
            return 0;
        }

        public static void Sort(List<Branch> list, int chosen)
        {
            Branch insert;
            //name, code, adress, phoneNumber

            if (chosen == 1) // код филиала
            {
                for (int next = 1; next < list.Count; next++)
                {
                    insert = list[next];
                    int moveItem = next;
                    while (moveItem > 0 && list[moveItem - 1].Code > insert.Code)
                    {
                        moveItem--;
                    }
                    list.RemoveAt(next);
                    list.Insert(moveItem, insert);
                }
            }
        }
    }
}

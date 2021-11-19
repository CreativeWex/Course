using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Ancestor // Для наследования всех классов кроме Contracts
    {
        string name; //Наименование

        public Ancestor(string name)
        {
            this.name = name;
        }
    }

    class Branch:Ancestor // Класс филиал
    {
        int code; // Код филиала
        // Наименование филиала наследуется
        string adress;
        string phoneNumber;

        public Branch(string name, int code, string adress, string phoneNumber) : base (name)
        {
            this.code = code;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
        }
    }

    class Branch : Ancestor // Класс филиал
    {
        int code; // Код филиала
        // Наименование филиала наследуется
        string adress;
        string phoneNumber;

        public Branch(string name, int code, string adress, string phoneNumber) : base(name)
        {
            this.code = code;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
        }
    }

}

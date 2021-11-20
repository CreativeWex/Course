using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Ancestor
    {
        protected string name; //Наименование

        public Ancestor(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }





    class Branch:Ancestor // Класс филиал
    {
        protected int code; // Код филиала
        // Наименование филиала наследуется
        protected string adress;
        protected string phoneNumber;

        public Branch(string name, int code, string adress, string phoneNumber) : base (name)
        {
            this.code = code;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
        }


        public int Code
        {
            get{ return code; }
        }

        public string Adress
        {
            get{ return adress; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
    }





    class Agents : Branch // Класс агенты
    {
        //Имя от родителя
        //Телефон от родителя
        //Адрес от родителя
        //Номер филиала от родителя
        protected string birthday;

        public Agents(string name, int code, string adress, string phoneNumber, string birthday) : base(name, code, adress, phoneNumber)
        {
            this.birthday = birthday;
        }

        public string Birthday
        {
            get { return birthday; }
        }
    }





    class InsuranceType : Ancestor // Вид страхования
    {
        protected string type; // Тип страхования
        // Наименование филиала наследуется

        public InsuranceType(string name, string type) : base(name)
        {
            this.type = type;
        }

        public string Type
        {
            get { return type; }
        }
    }





    class Contract : InsuranceType // Контракт
    {
        int numberOfContract; //Номер договора
        string date; // Дата заключения
        int summ; // Страховая сумма
        double tariffRate; // Тарифная ставка
        string branch; // Филиал
        //Вид страхования наследуется
        //Имя клиента наследуется

        public Contract(string name, string type, int numberOfContract, string date, int summ, double tariffRate, string branch) : base(name,type)
        {
            this.type = type;
        }

        public int NumberOfContract
        {
            get { return numberOfContract; }
        }

        public string Date
        {
            get { return date; }
        }

        public int Summ
        {
            get { return summ; }
        }

        public double TariffRate
        {
            get { return tariffRate; }
        }
        public string Branch
        {
            get { return branch; }
        }
    }
}

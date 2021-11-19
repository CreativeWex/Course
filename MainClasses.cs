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

        public string Name
        {
            get { return name; }
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
        public void Display()
        {
            Console.Write($"|Филиал = {name}, Код = {code}, Адрес = {adress}, Телефон = {phoneNumber} |");
            Console.WriteLine();
        }
    }





    class Agents : Branch // Класс агенты
    {
        //Имя от родителя
        //Телефон от родителя
        //Адрес от родителя
        //Номер филиала от родителя
        protected string surname;
        protected string fatherName;

        public Agents(string name, int code, string adress, string phoneNumber, string surname, string fatherName) : base(name, code, adress, phoneNumber)
        {
            this.surname = surname;
            this.fatherName = fatherName;
        }

        public string Surname
        {
            get { return surname; }
        }

        public string FatherName
        {
            get { return fatherName; }
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
            set { type = value; }
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

        public void Display()
        {
            Console.WriteLine($"|Номер договора: {numberOfContract}, дата заключения договора: {date}, страховая сумма: {summ}, тарифная ставка {tariffRate}, филиал {branch}, вид страхования {type} |");
        }
    }
}

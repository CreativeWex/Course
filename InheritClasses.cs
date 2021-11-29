using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Branch // Класс филиал
    {
        public string name;
        protected int code; // Код филиала
        protected string adress;
        protected string phoneNumber;

        public Branch(string name, int code, string adress, string phoneNumber)
        {
            this.name = name;
            this.code = code;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Code
        {
            get
            {
                return code;
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
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
    class InsuranceType // Вид страхования
    {
        protected string type; // Тип страхования
        public string name;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public InsuranceType(string name, string type)
        {
            this.type = type;
            this.name = name;
        }
        public string Type
        {
            get
            {
                return type;
            }
        }
    }
    class Contract : InsuranceType // Контракт
    {
        string numberOfContract; //Номер договора
        string date; // Дата заключения
        int summ; // Страховая сумма
        double tariffRate; // Тарифная ставка
        int branch; // Филиал

        public Contract(string name, string type, string numberOfContract, string date, int summ, double tariffRate, int branch) : base(name,type)
        {
            this.numberOfContract = numberOfContract;
            this.date = date;
            this.summ = summ;
            this.tariffRate = tariffRate;
            this.branch = branch;
        }
        public string NumberOfContract
        {
            get
            {
                return numberOfContract;
            }
        }
        public string Date
        {
            get
            {
                return date;
            }
        }
        public int Summ
        {
            get
            {
                return summ;
            }
        }
        public double TariffRate
        {
            get
            {
                return tariffRate;
            }
        }
        public int Branch
        {
            get
            {
                return branch;
            }
        }
    }
    class Salary
    {
        double insuranceFee;
        string name;

        public Salary(string name, double insuranceFee)
        {
            this.insuranceFee = insuranceFee;
            this.name = name;
        }

        public double InsuranceFee
        {
            get
            {
                return insuranceFee;
            }
            set
            {
                insuranceFee = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}

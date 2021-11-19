﻿using System;
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
    }

    class InsuranceType : Ancestor // Вид страхования
    {
        protected string type; // Тип страхования
        // Наименование филиала наследуется

        public InsuranceType(string name, string type) : base(name)
        {
            this.type = type;
        }
    }

    class Contract : InsuranceType // Контракт
    {
        int numberOfContract; //Номер договора
        string date; // Дата заключения
        double summ; // Страховая сумма
        double tariffRate; // Тарифная ставка
        string branch; // Филиал
        //Вид страхования наследуется
        //Имя клиента наследуется

        public Contract(string name, string type) : base(name,type)
        {
            this.type = type;
        }
    }
}

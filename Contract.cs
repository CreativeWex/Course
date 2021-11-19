using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Course
{
	class Contract
	{
		int numberOfContract; //Номер договора
		string date; // Дата заключения
		double summ; // Страховая сумма
		double tariffRate; // Тарифная ставка
		string branch; // Филиал
		string insuranceType; //Вид страхования

		public Contract(int numberOfContract, string date, double summ, double tariffRate, string branch, string insuranceType)
		{
			this.numberOfContract = numberOfContract;
			this.date = date;
			this.summ = summ;
			this.tariffRate = tariffRate;
			this.branch = branch;
			this.insuranceType = insuranceType;
		}
		public int NUMBER_OF_CONTRACT
		{
			get { return numberOfContract; }
		}

		public string DATE
		{
			get { return date; }
		}

		public double SUMM
		{
			get { return summ; }
		}

		public double TARIFF_RATE
		{
			get { return tariffRate; }
		}

		public string BRANCH
		{
			get { return branch; }
		}

		public string INSURANCE_TYPE
		{
			get { return insuranceType; }
		}

		public void Display()
		{
			Console.WriteLine($"|Номер договора: {numberOfContract}, дата заключения договора: {date}, страховая сумма: {summ}, тарифная ставка {tariffRate}, филиал {branch}, вид страхования {insuranceType} |");
		}
	}
}

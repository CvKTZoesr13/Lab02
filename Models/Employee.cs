using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02.Models
{
	public class Employee
	{
		public string id { get; set; }
		public string name { get; set; }
		public int amount { get; set; }
		public double salary { get; set; }
		public double bonus
		{
			get
			{
				if (amount > 27)
					return salary*0.1;
				else if (amount >=24) return salary*0.05;
				else return 0;
			}
			set { }
		}
		public double total
		{
			get
			{
				return salary + bonus;
			}

			set { }
		}
		public Employee()
		{

		}
		public Employee(string id, string name, int amount, double salary)
		{
			this.id = id;
			this.name = name;
			this.amount = amount;
			this.salary = salary;
		}
		public Employee(string id, string name, int amount, double salary, double bonus, double total)
		{
			this.id=id;
			this.name=name;
			this.amount=amount;
			this.salary=salary;
			this.bonus=bonus;
			this.total=total;
		}
	}
}
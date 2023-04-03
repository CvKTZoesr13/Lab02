using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02.Models
{
	public class Staff
	{
		public int Id { get; set; }
		public double SalaryLevel { get; set; }
		public int Amount { get; set; }
		public int Position { get; set; }
		public string Gender { get; set; }
		public string Languages { get; set; }
		public double NCTL { get {
			if(Amount < 25)
				{
					return Amount;
				} else
				{
					return (Amount - 25) * 2 + 25;
				}
			} set { } }

		public double Allowance { get {
				if (Position == 1)
				{
					return 500000;
				}
				else if (Position == 2)
				{
					return 300000;
				}
				else return 0;
			} }
		public double TotalSalary { get {
				return SalaryLevel*650000*NCTL + Allowance;	
			} set { } }
	}
}
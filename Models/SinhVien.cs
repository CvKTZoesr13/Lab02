using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02.Models
{
	public class SinhVien
	{
		public string id { get; set; }
		public string name { get; set; }
		public float marks { get; set; }
		
		public SinhVien() { }
		public SinhVien(string id, string name, float marks)
		{
			this.id=id;
			this.name=name;
			this.marks=marks;
		}
	}
}
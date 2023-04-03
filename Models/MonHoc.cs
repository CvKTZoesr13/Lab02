using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02.Models
{
	public class MonHoc
	{
		public string id { get; set; }
		public string name { get; set; }
		public MonHoc()
		{

		}
		public MonHoc(string id, string name)
		{
			this.id=id;
			this.name=name;
		}
	}
}
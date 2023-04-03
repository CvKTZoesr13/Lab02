using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02.Models
{
	public class KhoaHoc
	{
		public MonHoc MonHoc { get; set; }
		public List<SinhVien> list { get; set; }
		public KhoaHoc() { }
		public KhoaHoc(MonHoc monHoc, List<SinhVien> list)
		{
			MonHoc=monHoc;
			this.list=list;
		}
	}
}
using Lab02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}
		public ActionResult Detail(SinhVien sv)
		{
			sv.id = "SV001";
			sv.name = "Nguyễn Anh Tú";
			sv.marks = 100;
			return View(sv);
		}
		public ActionResult DetailsListSinhVien()
		{
			List<SinhVien> list = new List<SinhVien>();
			for(int i = 0; i < 6; i++)
			{
				list.Add(new SinhVien($"{i}",$"Nguyen Van A {i}",3+i));
			}
			return View(list);
		}

		public ActionResult DetailsKhoaHoc()
		{
			KhoaHoc kh = new KhoaHoc();
			MonHoc mh = new 
				MonHoc("1", "Java");
			List<SinhVien> list = new List<SinhVien>();
			for (int i = 0; i < 6; i++)
			{
				list.Add(new SinhVien($"{i}", $"Nguyen Van A {i}", 3+i));
			}
			kh.MonHoc = mh;
			kh.list = list;

			ViewBag.Message = "This is a simple message from DetailsKhoaHoc Method!";
			return View(kh);

		}
		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
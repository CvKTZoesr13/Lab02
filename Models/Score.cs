using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02.Models
{
	public class Score
	{
		public string name { get; set; }
		public int area { get; set; }
		public int areaScore { get
			{
				if (area == 1) { return 1; }
				else if (area== 2) {return 2;}
				else{  return 3;}
			} set { } }
		public float math { get; set; }
		public float physic { get; set; }
		public float chemistry { get; set; }
		public bool isSpecial { get; set; }
		public int specialScore { get {
				if (isSpecial) return 1;
				else return 0;
			} set { } }
		public float totalScore { get {
				return math + physic + chemistry + (float) specialScore + (float) areaScore;
			} set { } }
		public string result { get
			{
				if (totalScore >= 20) return "Đỗ đại học";
				else if (totalScore >= 15) return "Đỗ cao đẳng";
				else if (totalScore >= 10) return "Đỗ trung cấp";
				else return "Thi trượt";
			} set { } }


		// constructors
		public Score()
		{
				
		}
		public Score(string name, int area, int areaScore,
			float math, float physic, float chemistry,
			bool isSpecial) { 
			this.name = name;	
			this.area = area;
			this.areaScore = areaScore;
			this.math = math;
			this.physic = physic;
			this.chemistry = chemistry;
			this.isSpecial = isSpecial;
		}
		public Score(string name, int area,
			int areaScore, float math, float physic, float chemistry,
			bool isSpecial, int specialScore, float totalScore, string result)
		{
			this.name=name;
			this.area=area;
			this.areaScore=areaScore;
			this.math=math;
			this.physic=physic;
			this.chemistry=chemistry;
			this.isSpecial=isSpecial;
			this.specialScore=specialScore;
			this.totalScore=totalScore;
			this.result=result;
		}
	}
}
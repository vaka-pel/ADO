using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy.Models
{
	 class Teacher : Human
	 {
		public Teacher
			(
			int id,
			string last_name, string first_name, string middle_name, string birth_date, string email, string phone, Image photo
			) : base(id, last_name, first_name, middle_name, birth_date, email, phone, photo)
		{ 
			
		}

		//public override string GetNames()
		//{
		//	return base.GetNames();
		//}
		//public override string GetValues()
		//{
		//	return $"{base.GetValues()}";
		//}
		//public override string GetCondition()
		//{
		//	return base.GetCondition();
		//}
		
	}
}

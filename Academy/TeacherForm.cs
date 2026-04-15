using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Academy.Models;

namespace Academy
{
	public partial class TeacherForm : HumanForm
	{
		internal Models.Teacher teacher;
		public TeacherForm()
		{
			InitializeComponent();
		}

		public TeacherForm(int id) : this()
		{
			DataTable data = DataBase.Connector.Select("*", "Teachers", $"teacher_id={id}");
			teacher = new Models.Teacher(data.Rows[0].ItemArray);
			human = teacher;
			Extract();
			dtpWorkSince.Value = DateTime.Parse(teacher.work_since);
			tbRate.Text = teacher.rate.ToString();
			pbPhoto.Image = DataBase.Connector.DownLoadPhoto("Teachers", "photo", teacher.id);
		}
		protected override void buttonOk_Click(object sender, EventArgs e)
		{
			base.buttonOk_Click(sender, e);
			teacher = new Models.Teacher
				(
				human,
				dtpWorkSince.Value.ToString("yyyy-MM-dd"),
				Convert.ToDecimal(tbRate.Text)
				);
			if (teacher.id == 0) teacher.id = Convert.ToInt32
				(
				DataBase.Connector.Scalar($"INSERT Teachers({teacher.GetNames()}) VALUES ({teacher.GetValues()});SELECT SCOPE_IDENTITY()")

				);
			else
				DataBase.Connector.Update($"UPDATE Teachers SET {teacher.GetUpdateString()} WHERE teacher_id={teacher.id}");

			if (teacher.photo != null)
			{
				DataBase.Connector.UploadPhoto(teacher.SeriaLizePhoto(), teacher.id, "photo", "teachers");
			}
		}

				
	}
}

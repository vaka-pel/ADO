using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public  abstract partial class HumanForm : Form
	{
		//static protected DBTools.Connector connector;
		public HumanForm()
		{
			InitializeComponent();
		}

		protected abstract void buttonOk_Click(object sender, EventArgs e);
		
	}
}

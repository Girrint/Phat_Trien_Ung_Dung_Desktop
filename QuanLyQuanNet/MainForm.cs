using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.Text = "Quản lý quán Net";
		}

		private void tsbQLMayTinh_Click(object sender, EventArgs e)
		{
			foreach (Form frm in Application.OpenForms)
			{
				if(frm != this)
				{
					frm.WindowState = FormWindowState.Minimized;
				}
			}

			Form formMay = Application.OpenForms["frmQLMayTinh"];
			if(formMay == null)
			{
				frmQLMayTinh f = new frmQLMayTinh();
				f.MdiParent = this;
				f.WindowState = FormWindowState.Maximized;
				f.Show();
			}
			else
			{
				formMay.WindowState = FormWindowState.Normal;
				formMay.BringToFront();
			}
		}

		private void tsbQLTaiKhoan_Click(object sender, EventArgs e)
		{
			foreach (Form frm in Application.OpenForms)
			{
				if (frm != this)
				{
					frm.WindowState = FormWindowState.Minimized;
				}
			}

			Form formTaiKhoan = Application.OpenForms["frmQLTaiKhoan"];
			if (formTaiKhoan == null)
			{
				frmQLTaiKhoan f = new frmQLTaiKhoan();
				f.MdiParent = this;
				f.WindowState = FormWindowState.Maximized;
				f.Show();
			}
			else
			{
				formTaiKhoan.WindowState = FormWindowState.Normal;
				formTaiKhoan.BringToFront();
			}
		}

		private void tsbQLOrder_Click(object sender, EventArgs e)
		{
			foreach (Form frm in Application.OpenForms)
			{
				if (frm != this)
				{
					frm.WindowState = FormWindowState.Minimized;
				}
			}

			Form formO = Application.OpenForms["frmQLOrder"];
			if (formO == null)
			{
				frmQLOrder f = new frmQLOrder();
				f.MdiParent = this;
				f.WindowState = FormWindowState.Maximized;
				f.Show();
			}
			else
			{
				formO.WindowState = FormWindowState.Normal;
				formO.BringToFront();
			}
		}

		private void tsbExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}

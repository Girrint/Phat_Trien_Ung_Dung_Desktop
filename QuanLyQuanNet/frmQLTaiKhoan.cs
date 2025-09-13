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
	public partial class frmQLTaiKhoan : Form
	{
		List<TaiKhoan> dsTaiKhoan = new List<TaiKhoan>();
		public frmQLTaiKhoan()
		{
			InitializeComponent();
		}

		private void frmQLTaiKhoan_Load(object sender, EventArgs e)
		{
			HienThiDanhSach();
		}

		private void HienThiDanhSach()
		{
			dgvTaiKhoan.DataSource = null;
			dgvTaiKhoan.DataSource = dsTaiKhoan;
		}

		private void btnThemTK_Click(object sender, EventArgs e)
		{
			dsTaiKhoan.Add(new TaiKhoan { Ten = txtTenTK.Text, Loai = txtLoaiTK.Text});
			HienThiDanhSach();
		}

		private void btnXoaTK_Click(object sender, EventArgs e)
		{
			if(dgvTaiKhoan.SelectedRows.Count > 0)
			{
				dsTaiKhoan.RemoveAt(dgvTaiKhoan.SelectedRows[0].Index);
				HienThiDanhSach();
			}
		}

		private void btnSuaTK_Click(object sender, EventArgs e)
		{
			if(dgvTaiKhoan.SelectedRows.Count > 0)
			{
				int index = dgvTaiKhoan.SelectedRows[0].Index;
				dsTaiKhoan[index].Ten = txtTenTK.Text;
				dsTaiKhoan[index].Loai = txtLoaiTK.Text;
				HienThiDanhSach();
			}
		}

	}
}

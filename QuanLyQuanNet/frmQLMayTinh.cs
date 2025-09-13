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
	public partial class frmQLMayTinh : Form
	{
		List<MayTinh> dsMay = new List<MayTinh> { };
		public frmQLMayTinh()
		{
			InitializeComponent();
		}

		private void frmQLMayTinh_Load(object sender, EventArgs e)
		{
			HienThiDanhSach();
		}

		private void HienThiDanhSach()
		{
			dgvMay.DataSource = null;
			dgvMay.DataSource = dsMay;
		}

		private void btnThemMT_Click(object sender, EventArgs e)
		{
			dsMay.Add(new MayTinh { TenMay = txtTenMay.Text, TrangThai = txtTrangThai.Text });
			HienThiDanhSach();
		}

		private void btnXoaMT_Click(object sender, EventArgs e)
		{
			if (dgvMay.SelectedRows.Count > 0)
			{
				dsMay.RemoveAt(dgvMay.SelectedRows[0].Index);
				HienThiDanhSach();
			}
		}

		private void btnSuaMT_Click(object sender, EventArgs e)
		{
			if(dgvMay.SelectedRows.Count > 0)
			{
				int index = dgvMay.SelectedRows[0].Index;
				dsMay[index].TenMay = txtTenMay.Text;
				dsMay[index].TrangThai = txtTrangThai.Text;
				HienThiDanhSach();
			}
		}

	}
}

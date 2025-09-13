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
	public partial class frmQLOrder : Form
	{
		List<Order> dsOrder = new List<Order>();
		public frmQLOrder()
		{
			InitializeComponent();
		}

		private void frmQLOrder_Load(object sender, EventArgs e)
		{
			cbMayTinh.Items.Clear();
			cbTKKhach.Items.Clear();

			HienThiDanhSach();
		}

		private void HienThiDanhSach()
		{
			dgvOrder.DataSource = null;
			dgvOrder.DataSource = dgvOrder;
		}

		private double TinhTien(DateTime gioBatDau, DateTime gioKetThuc, double giaTienGio = 10000)
		{
			if(gioKetThuc <= gioBatDau)
			{
				MessageBox.Show("Thời gian không hợp lệ!", "Thông báo");
			}
			TimeSpan thoiGian = dtpKetThuc.Value - dtpBatDau.Value;
			return thoiGian.TotalHours * giaTienGio;
		}
		private void btnThemOrder_Click(object sender, EventArgs e)
		{
			if(cbMayTinh.SelectedItem == null || cbTKKhach.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn máy tính và tài khoản khách!", "Thông báo");
				return;
			}

			double thanhTien = TinhTien(dtpBatDau.Value, dtpKetThuc.Value);


			dsOrder.Add(new Order
			{
				May = cbMayTinh.SelectedItem.ToString(),
				Khach = cbTKKhach.SelectedItem.ToString(),
				GioBatDau = dtpBatDau.Value,
				GioKetThuc = dtpKetThuc.Value,
				ThanhTien = thanhTien
			});

			HienThiDanhSach();
		}

		private void btnXoaOrder_Click(object sender, EventArgs e)
		{
			if(dgvOrder.SelectedRows.Count > 0)
			{
				dsOrder.RemoveAt(dgvOrder.SelectedRows[0].Index);
				HienThiDanhSach();
			}
		}

		private void btnSuaOrder_Click(object sender, EventArgs e)
		{
			if(dgvOrder.SelectedRows.Count > 0)
			{
				int index = dgvOrder.SelectedRows[0].Index;

				if(cbMayTinh.SelectedItem == null || cbTKKhach.SelectedItem == null)
				{
					MessageBox.Show("Vui lòng chọn máy tính và tài khoản khách!", "Thông báo");
					return;
				}

				double thanhTien = TinhTien(dtpBatDau.Value, dtpKetThuc.Value);

				dsOrder[index].May = cbMayTinh.SelectedItem.ToString();
				dsOrder[index].Khach = cbTKKhach.SelectedItem.ToString();
				dsOrder[index].GioBatDau = dtpBatDau.Value;
				dsOrder[index].GioKetThuc = dtpKetThuc.Value;
				dsOrder[index].ThanhTien = thanhTien;

				HienThiDanhSach();
			}
		}

	}
}

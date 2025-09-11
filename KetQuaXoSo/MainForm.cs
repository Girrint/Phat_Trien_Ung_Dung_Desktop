using System;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetQuaXoSo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			dtpNgayQuay.Format = DateTimePickerFormat.Custom;
			dtpNgayQuay.CustomFormat = "dd/MM/yyyy";
			dtpNgayQuay.Value = DateTime.Now;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			string[] provinces = 
			{
		"Miền Bắc","An Giang","Bình Dương","Bình Định","Bạc Liêu","Bình Phước","Bến Tre","Bình Thuận",
		"Cà Mau","Cần Thơ","Đắk Lắk","Đồng Nai","Đà Nẵng","Đắk Nông","Đồng Tháp","Gia Lai","Hồ Chí Minh",
		"Hậu Giang","Kiên Giang","Khánh Hòa","Kon Tum","Long An","Lâm Đồng","Ninh Thuận","Phú Yên",
		"Quảng Bình","Quảng Ngãi","Quảng Nam","Quảng Trị","Sóc Trăng","Tiền Giang","Tây Ninh",
		"Thừa Thiên Huế","Trà Vinh","Vĩnh Long","Vũng Tàu"
			};

			cbTenDai.Items.AddRange(provinces);
		}

		private async void btnDoKetQua_Click(object sender, EventArgs e)
		{
			lbKetQua.Items.Clear();
			lblThongBao.Text = "";

			string dai = cbTenDai.Text;
			if (string.IsNullOrWhiteSpace(dai))
			{
				lbKetQua.Items.Add("Bạn chưa chọn đài!");
				return;
			}

			string rss = XoSoHelper.Program.CreateRSSLink(dai);
			var ketquas = await XoSoHelper.XoSoParser.ParseRss(rss);

			if (ketquas == null || ketquas.Count == 0)
			{
				lbKetQua.Items.Add("Không lấy được dữ liệu từ RSS!");
				return;
			}

			DateTime ngayChon = dtpNgayQuay.Value.Date;


			// tìm kết quả đúng ngày
			var kqNgay = ketquas.FirstOrDefault(k => k.NgayQuay.Date == ngayChon);

			if (kqNgay == null)
			{
				lbKetQua.Items.Add($"Không có kết quả ngày {ngayChon:dd/MM/yyyy}");
				return; // ⬅️ dừng hẳn, không in kết quả của ngày khác
			}

			// nếu có kết quả thì hiển thị các giải
			lbKetQua.Items.Add("Đặc biệt: " + kqNgay.DacBiet);
			lbKetQua.Items.Add("Giải 1: " + kqNgay.Giai1);
			lbKetQua.Items.Add("Giải 2: " + kqNgay.Giai2);
			lbKetQua.Items.Add("Giải 3: " + string.Join(", ", kqNgay.Giai3));
			lbKetQua.Items.Add("Giải 4: " + string.Join(", ", kqNgay.Giai4));
			lbKetQua.Items.Add("Giải 5: " + kqNgay.Giai5);
			lbKetQua.Items.Add("Giải 6: " + string.Join(", ", kqNgay.Giai6));
			lbKetQua.Items.Add("Giải 7: " + string.Join(", ", kqNgay.Giai7));
			if (kqNgay.CoGiai8)
				lbKetQua.Items.Add("Giải 8: " + kqNgay.Giai8);

			// dò vé số
			string ve = txtSoCanDo.Text.Trim();
			string ketqua = XoSoHelper.Program.KiemTraVeSo(ve, kqNgay);
			lblThongBao.Text = ketqua;

		}

	}
}

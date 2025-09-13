namespace QuanLyQuanNet
{
	partial class frmQLMayTinh
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTenMay = new System.Windows.Forms.Label();
			this.lblTrangThai = new System.Windows.Forms.Label();
			this.txtTenMay = new System.Windows.Forms.TextBox();
			this.txtTrangThai = new System.Windows.Forms.TextBox();
			this.btnThemMT = new System.Windows.Forms.Button();
			this.btnXoaMT = new System.Windows.Forms.Button();
			this.btnSuaMT = new System.Windows.Forms.Button();
			this.dgvMay = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvMay)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTenMay
			// 
			this.lblTenMay.AutoSize = true;
			this.lblTenMay.Location = new System.Drawing.Point(35, 23);
			this.lblTenMay.Name = "lblTenMay";
			this.lblTenMay.Size = new System.Drawing.Size(48, 13);
			this.lblTenMay.TabIndex = 0;
			this.lblTenMay.Text = "Tên máy";
			// 
			// lblTrangThai
			// 
			this.lblTrangThai.AutoSize = true;
			this.lblTrangThai.Location = new System.Drawing.Point(35, 86);
			this.lblTrangThai.Name = "lblTrangThai";
			this.lblTrangThai.Size = new System.Drawing.Size(55, 13);
			this.lblTrangThai.TabIndex = 1;
			this.lblTrangThai.Text = "Trạng thái";
			// 
			// txtTenMay
			// 
			this.txtTenMay.Location = new System.Drawing.Point(119, 16);
			this.txtTenMay.Name = "txtTenMay";
			this.txtTenMay.Size = new System.Drawing.Size(216, 20);
			this.txtTenMay.TabIndex = 2;
			// 
			// txtTrangThai
			// 
			this.txtTrangThai.Location = new System.Drawing.Point(119, 79);
			this.txtTrangThai.Name = "txtTrangThai";
			this.txtTrangThai.Size = new System.Drawing.Size(214, 20);
			this.txtTrangThai.TabIndex = 3;
			// 
			// btnThemMT
			// 
			this.btnThemMT.Location = new System.Drawing.Point(12, 147);
			this.btnThemMT.Name = "btnThemMT";
			this.btnThemMT.Size = new System.Drawing.Size(112, 63);
			this.btnThemMT.TabIndex = 4;
			this.btnThemMT.Text = "Thêm";
			this.btnThemMT.UseVisualStyleBackColor = true;
			this.btnThemMT.Click += new System.EventHandler(this.btnThemMT_Click);
			// 
			// btnXoaMT
			// 
			this.btnXoaMT.Location = new System.Drawing.Point(409, 147);
			this.btnXoaMT.Name = "btnXoaMT";
			this.btnXoaMT.Size = new System.Drawing.Size(124, 63);
			this.btnXoaMT.TabIndex = 5;
			this.btnXoaMT.Text = "Xoá";
			this.btnXoaMT.UseVisualStyleBackColor = true;
			this.btnXoaMT.Click += new System.EventHandler(this.btnXoaMT_Click);
			// 
			// btnSuaMT
			// 
			this.btnSuaMT.Location = new System.Drawing.Point(218, 147);
			this.btnSuaMT.Name = "btnSuaMT";
			this.btnSuaMT.Size = new System.Drawing.Size(115, 63);
			this.btnSuaMT.TabIndex = 6;
			this.btnSuaMT.Text = "Sửa";
			this.btnSuaMT.UseVisualStyleBackColor = true;
			this.btnSuaMT.Click += new System.EventHandler(this.btnSuaMT_Click);
			// 
			// dgvMay
			// 
			this.dgvMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMay.Location = new System.Drawing.Point(38, 274);
			this.dgvMay.Name = "dgvMay";
			this.dgvMay.Size = new System.Drawing.Size(478, 106);
			this.dgvMay.TabIndex = 7;
			// 
			// frmQLMayTinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvMay);
			this.Controls.Add(this.btnSuaMT);
			this.Controls.Add(this.btnXoaMT);
			this.Controls.Add(this.btnThemMT);
			this.Controls.Add(this.txtTrangThai);
			this.Controls.Add(this.txtTenMay);
			this.Controls.Add(this.lblTrangThai);
			this.Controls.Add(this.lblTenMay);
			this.Name = "frmQLMayTinh";
			this.Text = "Quản lý máy tính";
			this.Load += new System.EventHandler(this.frmQLMayTinh_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTenMay;
		private System.Windows.Forms.Label lblTrangThai;
		private System.Windows.Forms.TextBox txtTenMay;
		private System.Windows.Forms.TextBox txtTrangThai;
		private System.Windows.Forms.Button btnThemMT;
		private System.Windows.Forms.Button btnXoaMT;
		private System.Windows.Forms.Button btnSuaMT;
		private System.Windows.Forms.DataGridView dgvMay;
	}
}
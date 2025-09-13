namespace QuanLyQuanNet
{
	partial class frmQLTaiKhoan
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
			this.lblTenTK = new System.Windows.Forms.Label();
			this.lblLoaiTK = new System.Windows.Forms.Label();
			this.txtTenTK = new System.Windows.Forms.TextBox();
			this.txtLoaiTK = new System.Windows.Forms.TextBox();
			this.btnThemTK = new System.Windows.Forms.Button();
			this.btnSuaTK = new System.Windows.Forms.Button();
			this.btnXoaTK = new System.Windows.Forms.Button();
			this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTenTK
			// 
			this.lblTenTK.AutoSize = true;
			this.lblTenTK.Location = new System.Drawing.Point(50, 22);
			this.lblTenTK.Name = "lblTenTK";
			this.lblTenTK.Size = new System.Drawing.Size(73, 13);
			this.lblTenTK.TabIndex = 0;
			this.lblTenTK.Text = "Tên tài khoản";
			// 
			// lblLoaiTK
			// 
			this.lblLoaiTK.AutoSize = true;
			this.lblLoaiTK.Location = new System.Drawing.Point(50, 86);
			this.lblLoaiTK.Name = "lblLoaiTK";
			this.lblLoaiTK.Size = new System.Drawing.Size(74, 13);
			this.lblLoaiTK.TabIndex = 1;
			this.lblLoaiTK.Text = "Loại tài khoản";
			// 
			// txtTenTK
			// 
			this.txtTenTK.Location = new System.Drawing.Point(168, 15);
			this.txtTenTK.Name = "txtTenTK";
			this.txtTenTK.Size = new System.Drawing.Size(257, 20);
			this.txtTenTK.TabIndex = 2;
			// 
			// txtLoaiTK
			// 
			this.txtLoaiTK.Location = new System.Drawing.Point(168, 79);
			this.txtLoaiTK.Name = "txtLoaiTK";
			this.txtLoaiTK.Size = new System.Drawing.Size(257, 20);
			this.txtLoaiTK.TabIndex = 3;
			// 
			// btnThemTK
			// 
			this.btnThemTK.Location = new System.Drawing.Point(12, 138);
			this.btnThemTK.Name = "btnThemTK";
			this.btnThemTK.Size = new System.Drawing.Size(122, 58);
			this.btnThemTK.TabIndex = 4;
			this.btnThemTK.Text = "Thêm";
			this.btnThemTK.UseVisualStyleBackColor = true;
			this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
			// 
			// btnSuaTK
			// 
			this.btnSuaTK.Location = new System.Drawing.Point(202, 138);
			this.btnSuaTK.Name = "btnSuaTK";
			this.btnSuaTK.Size = new System.Drawing.Size(124, 58);
			this.btnSuaTK.TabIndex = 5;
			this.btnSuaTK.Text = "Sửa";
			this.btnSuaTK.UseVisualStyleBackColor = true;
			this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
			// 
			// btnXoaTK
			// 
			this.btnXoaTK.Location = new System.Drawing.Point(393, 138);
			this.btnXoaTK.Name = "btnXoaTK";
			this.btnXoaTK.Size = new System.Drawing.Size(123, 58);
			this.btnXoaTK.TabIndex = 6;
			this.btnXoaTK.Text = "Xoá";
			this.btnXoaTK.UseVisualStyleBackColor = true;
			this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
			// 
			// dgvTaiKhoan
			// 
			this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTaiKhoan.Location = new System.Drawing.Point(32, 256);
			this.dgvTaiKhoan.Name = "dgvTaiKhoan";
			this.dgvTaiKhoan.Size = new System.Drawing.Size(483, 164);
			this.dgvTaiKhoan.TabIndex = 7;
			// 
			// frmQLTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 450);
			this.Controls.Add(this.dgvTaiKhoan);
			this.Controls.Add(this.btnXoaTK);
			this.Controls.Add(this.btnSuaTK);
			this.Controls.Add(this.btnThemTK);
			this.Controls.Add(this.txtLoaiTK);
			this.Controls.Add(this.txtTenTK);
			this.Controls.Add(this.lblLoaiTK);
			this.Controls.Add(this.lblTenTK);
			this.Name = "frmQLTaiKhoan";
			this.Text = "Quản lý tài khoản";
			this.Load += new System.EventHandler(this.frmQLTaiKhoan_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTenTK;
		private System.Windows.Forms.Label lblLoaiTK;
		private System.Windows.Forms.TextBox txtTenTK;
		private System.Windows.Forms.TextBox txtLoaiTK;
		private System.Windows.Forms.Button btnThemTK;
		private System.Windows.Forms.Button btnSuaTK;
		private System.Windows.Forms.Button btnXoaTK;
		private System.Windows.Forms.DataGridView dgvTaiKhoan;
	}
}
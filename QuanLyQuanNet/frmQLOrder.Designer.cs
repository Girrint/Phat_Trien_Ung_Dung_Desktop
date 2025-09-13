namespace QuanLyQuanNet
{
	partial class frmQLOrder
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
			this.cbMayTinh = new System.Windows.Forms.ComboBox();
			this.cbTKKhach = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtThanhTien = new System.Windows.Forms.TextBox();
			this.btnThemOrder = new System.Windows.Forms.Button();
			this.btnSuaOrder = new System.Windows.Forms.Button();
			this.btnXoaOrder = new System.Windows.Forms.Button();
			this.dgvOrder = new System.Windows.Forms.DataGridView();
			this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
			this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
			this.SuspendLayout();
			// 
			// cbMayTinh
			// 
			this.cbMayTinh.FormattingEnabled = true;
			this.cbMayTinh.Location = new System.Drawing.Point(158, 11);
			this.cbMayTinh.Name = "cbMayTinh";
			this.cbMayTinh.Size = new System.Drawing.Size(229, 21);
			this.cbMayTinh.TabIndex = 0;
			// 
			// cbTKKhach
			// 
			this.cbTKKhach.FormattingEnabled = true;
			this.cbTKKhach.Location = new System.Drawing.Point(158, 63);
			this.cbTKKhach.Name = "cbTKKhach";
			this.cbTKKhach.Size = new System.Drawing.Size(229, 21);
			this.cbTKKhach.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Máy tính";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "TK Khách";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Giờ bắt đầu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(261, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Giờ kết thúc";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(41, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Thành tiền";
			// 
			// txtThanhTien
			// 
			this.txtThanhTien.Location = new System.Drawing.Point(158, 165);
			this.txtThanhTien.Name = "txtThanhTien";
			this.txtThanhTien.Size = new System.Drawing.Size(229, 20);
			this.txtThanhTien.TabIndex = 9;
			// 
			// btnThemOrder
			// 
			this.btnThemOrder.Location = new System.Drawing.Point(22, 200);
			this.btnThemOrder.Name = "btnThemOrder";
			this.btnThemOrder.Size = new System.Drawing.Size(96, 50);
			this.btnThemOrder.TabIndex = 10;
			this.btnThemOrder.Text = "Thêm";
			this.btnThemOrder.UseVisualStyleBackColor = true;
			this.btnThemOrder.Click += new System.EventHandler(this.btnThemOrder_Click);
			// 
			// btnSuaOrder
			// 
			this.btnSuaOrder.Location = new System.Drawing.Point(187, 200);
			this.btnSuaOrder.Name = "btnSuaOrder";
			this.btnSuaOrder.Size = new System.Drawing.Size(116, 50);
			this.btnSuaOrder.TabIndex = 11;
			this.btnSuaOrder.Text = "Sửa";
			this.btnSuaOrder.UseVisualStyleBackColor = true;
			this.btnSuaOrder.Click += new System.EventHandler(this.btnSuaOrder_Click);
			// 
			// btnXoaOrder
			// 
			this.btnXoaOrder.Location = new System.Drawing.Point(375, 200);
			this.btnXoaOrder.Name = "btnXoaOrder";
			this.btnXoaOrder.Size = new System.Drawing.Size(109, 51);
			this.btnXoaOrder.TabIndex = 12;
			this.btnXoaOrder.Text = "Xoá";
			this.btnXoaOrder.UseVisualStyleBackColor = true;
			this.btnXoaOrder.Click += new System.EventHandler(this.btnXoaOrder_Click);
			// 
			// dgvOrder
			// 
			this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrder.Location = new System.Drawing.Point(22, 272);
			this.dgvOrder.Name = "dgvOrder";
			this.dgvOrder.Size = new System.Drawing.Size(504, 163);
			this.dgvOrder.TabIndex = 13;
			// 
			// dtpBatDau
			// 
			this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpBatDau.Location = new System.Drawing.Point(110, 114);
			this.dtpBatDau.Name = "dtpBatDau";
			this.dtpBatDau.Size = new System.Drawing.Size(121, 20);
			this.dtpBatDau.TabIndex = 14;
			// 
			// dtpKetThuc
			// 
			this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpKetThuc.Location = new System.Drawing.Point(332, 119);
			this.dtpKetThuc.Name = "dtpKetThuc";
			this.dtpKetThuc.Size = new System.Drawing.Size(123, 20);
			this.dtpKetThuc.TabIndex = 15;
			// 
			// frmQLOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 450);
			this.Controls.Add(this.dtpKetThuc);
			this.Controls.Add(this.dtpBatDau);
			this.Controls.Add(this.dgvOrder);
			this.Controls.Add(this.btnXoaOrder);
			this.Controls.Add(this.btnSuaOrder);
			this.Controls.Add(this.btnThemOrder);
			this.Controls.Add(this.txtThanhTien);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbTKKhach);
			this.Controls.Add(this.cbMayTinh);
			this.Name = "frmQLOrder";
			this.Text = "Quản lý Order";
			this.Load += new System.EventHandler(this.frmQLOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbMayTinh;
		private System.Windows.Forms.ComboBox cbTKKhach;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtThanhTien;
		private System.Windows.Forms.Button btnThemOrder;
		private System.Windows.Forms.Button btnSuaOrder;
		private System.Windows.Forms.Button btnXoaOrder;
		private System.Windows.Forms.DataGridView dgvOrder;
		private System.Windows.Forms.DateTimePicker dtpBatDau;
		private System.Windows.Forms.DateTimePicker dtpKetThuc;
	}
}
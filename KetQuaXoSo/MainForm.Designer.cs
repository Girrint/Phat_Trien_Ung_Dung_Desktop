namespace KetQuaXoSo
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSoCanDo = new System.Windows.Forms.TextBox();
			this.dtpNgayQuay = new System.Windows.Forms.DateTimePicker();
			this.lbKetQua = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblThongBao = new System.Windows.Forms.Label();
			this.btnDoKetQua = new System.Windows.Forms.Button();
			this.cbTenDai = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(47, 296);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số cần dò:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên đài:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(47, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày quay:";
			// 
			// txtSoCanDo
			// 
			this.txtSoCanDo.Location = new System.Drawing.Point(158, 292);
			this.txtSoCanDo.Name = "txtSoCanDo";
			this.txtSoCanDo.Size = new System.Drawing.Size(159, 20);
			this.txtSoCanDo.TabIndex = 3;
			// 
			// dtpNgayQuay
			// 
			this.dtpNgayQuay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayQuay.Location = new System.Drawing.Point(158, 60);
			this.dtpNgayQuay.Name = "dtpNgayQuay";
			this.dtpNgayQuay.Size = new System.Drawing.Size(159, 20);
			this.dtpNgayQuay.TabIndex = 5;
			// 
			// lbKetQua
			// 
			this.lbKetQua.FormattingEnabled = true;
			this.lbKetQua.Location = new System.Drawing.Point(50, 102);
			this.lbKetQua.Name = "lbKetQua";
			this.lbKetQua.Size = new System.Drawing.Size(324, 173);
			this.lbKetQua.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(46, 408);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Kết quả:";
			// 
			// lblThongBao
			// 
			this.lblThongBao.AutoSize = true;
			this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblThongBao.ForeColor = System.Drawing.Color.Red;
			this.lblThongBao.Location = new System.Drawing.Point(154, 408);
			this.lblThongBao.Name = "lblThongBao";
			this.lblThongBao.Size = new System.Drawing.Size(14, 20);
			this.lblThongBao.TabIndex = 8;
			this.lblThongBao.Text = ".";
			// 
			// btnDoKetQua
			// 
			this.btnDoKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoKetQua.ForeColor = System.Drawing.Color.Blue;
			this.btnDoKetQua.Location = new System.Drawing.Point(293, 338);
			this.btnDoKetQua.Name = "btnDoKetQua";
			this.btnDoKetQua.Size = new System.Drawing.Size(104, 42);
			this.btnDoKetQua.TabIndex = 9;
			this.btnDoKetQua.Text = "Bắt đầu";
			this.btnDoKetQua.UseVisualStyleBackColor = true;
			this.btnDoKetQua.Click += new System.EventHandler(this.btnDoKetQua_Click);
			// 
			// cbTenDai
			// 
			this.cbTenDai.FormattingEnabled = true;
			this.cbTenDai.Location = new System.Drawing.Point(158, 18);
			this.cbTenDai.Name = "cbTenDai";
			this.cbTenDai.Size = new System.Drawing.Size(159, 21);
			this.cbTenDai.TabIndex = 10;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 450);
			this.Controls.Add(this.cbTenDai);
			this.Controls.Add(this.btnDoKetQua);
			this.Controls.Add(this.lblThongBao);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbKetQua);
			this.Controls.Add(this.dtpNgayQuay);
			this.Controls.Add(this.txtSoCanDo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Kết quả xổ số";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoCanDo;
		private System.Windows.Forms.DateTimePicker dtpNgayQuay;
		private System.Windows.Forms.ListBox lbKetQua;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblThongBao;
		private System.Windows.Forms.Button btnDoKetQua;
		private System.Windows.Forms.ComboBox cbTenDai;
	}
}


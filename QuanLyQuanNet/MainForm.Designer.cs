namespace QuanLyQuanNet
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbQLMayTinh = new System.Windows.Forms.ToolStripButton();
			this.tsbQLTaiKhoan = new System.Windows.Forms.ToolStripButton();
			this.tsbQLOrder = new System.Windows.Forms.ToolStripButton();
			this.tsbExit = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(649, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQLMayTinh,
            this.tsbQLTaiKhoan,
            this.tsbQLOrder,
            this.tsbExit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(649, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbQLMayTinh
			// 
			this.tsbQLMayTinh.Image = global::QuanLyQuanNet.Properties.Resources.computer_solid_full;
			this.tsbQLMayTinh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbQLMayTinh.Name = "tsbQLMayTinh";
			this.tsbQLMayTinh.Size = new System.Drawing.Size(118, 22);
			this.tsbQLMayTinh.Text = "Quản lý máy tính";
			this.tsbQLMayTinh.Click += new System.EventHandler(this.tsbQLMayTinh_Click);
			// 
			// tsbQLTaiKhoan
			// 
			this.tsbQLTaiKhoan.Image = global::QuanLyQuanNet.Properties.Resources.user_solid_full;
			this.tsbQLTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbQLTaiKhoan.Name = "tsbQLTaiKhoan";
			this.tsbQLTaiKhoan.Size = new System.Drawing.Size(120, 22);
			this.tsbQLTaiKhoan.Text = "Quản lý tài khoản";
			this.tsbQLTaiKhoan.Click += new System.EventHandler(this.tsbQLTaiKhoan_Click);
			// 
			// tsbQLOrder
			// 
			this.tsbQLOrder.Image = global::QuanLyQuanNet.Properties.Resources.first_order_brands_solid_full;
			this.tsbQLOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbQLOrder.Name = "tsbQLOrder";
			this.tsbQLOrder.Size = new System.Drawing.Size(101, 22);
			this.tsbQLOrder.Text = "Quản lý Order";
			this.tsbQLOrder.Click += new System.EventHandler(this.tsbQLOrder_Click);
			// 
			// tsbExit
			// 
			this.tsbExit.Image = global::QuanLyQuanNet.Properties.Resources.circle_xmark_solid_full;
			this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbExit.Name = "tsbExit";
			this.tsbExit.Size = new System.Drawing.Size(45, 22);
			this.tsbExit.Text = "Exit";
			this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 555);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Quản Lý Quán Net";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbQLMayTinh;
		private System.Windows.Forms.ToolStripButton tsbQLTaiKhoan;
		private System.Windows.Forms.ToolStripButton tsbQLOrder;
		private System.Windows.Forms.ToolStripButton tsbExit;
	}
}


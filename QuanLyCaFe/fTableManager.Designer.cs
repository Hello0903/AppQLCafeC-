namespace QuanLyCaFe
{
    partial class fTableManager
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đangxuatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thongtincanhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttien = new System.Windows.Forms.TextBox();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.btnchuyenban = new System.Windows.Forms.Button();
            this.btnkhuyenmai = new System.Windows.Forms.Button();
            this.nudkhuyenmai = new System.Windows.Forms.NumericUpDown();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudThemmon = new System.Windows.Forms.NumericUpDown();
            this.btnthemmon = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudkhuyenmai)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThemmon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đangxuatToolStripMenuItem1,
            this.thongtincanhanToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đangxuatToolStripMenuItem1
            // 
            this.đangxuatToolStripMenuItem1.Name = "đangxuatToolStripMenuItem1";
            this.đangxuatToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.đangxuatToolStripMenuItem1.Text = "Đăng xuất";
            this.đangxuatToolStripMenuItem1.Click += new System.EventHandler(this.đangxuatToolStripMenuItem1_Click);
            // 
            // thongtincanhanToolStripMenuItem
            // 
            this.thongtincanhanToolStripMenuItem.Name = "thongtincanhanToolStripMenuItem";
            this.thongtincanhanToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thongtincanhanToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thongtincanhanToolStripMenuItem.Click += new System.EventHandler(this.thongtincanhanToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(390, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 189);
            this.panel2.TabIndex = 3;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(4, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(316, 183);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 59;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 51;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 67;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txttien);
            this.panel3.Controls.Add(this.cbChuyenBan);
            this.panel3.Controls.Add(this.btnchuyenban);
            this.panel3.Controls.Add(this.btnkhuyenmai);
            this.panel3.Controls.Add(this.nudkhuyenmai);
            this.panel3.Controls.Add(this.btnthanhtoan);
            this.panel3.Location = new System.Drawing.Point(390, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 49);
            this.panel3.TabIndex = 4;
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(165, 15);
            this.txttien.Name = "txttien";
            this.txttien.ReadOnly = true;
            this.txttien.Size = new System.Drawing.Size(77, 20);
            this.txttien.TabIndex = 8;
            this.txttien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(0, 27);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(74, 21);
            this.cbChuyenBan.TabIndex = 7;
            // 
            // btnchuyenban
            // 
            this.btnchuyenban.Location = new System.Drawing.Point(0, 0);
            this.btnchuyenban.Name = "btnchuyenban";
            this.btnchuyenban.Size = new System.Drawing.Size(74, 27);
            this.btnchuyenban.TabIndex = 6;
            this.btnchuyenban.Text = "Chuyển Bàn";
            this.btnchuyenban.UseVisualStyleBackColor = true;
            this.btnchuyenban.Click += new System.EventHandler(this.btnchuyenban_Click);
            // 
            // btnkhuyenmai
            // 
            this.btnkhuyenmai.Location = new System.Drawing.Point(80, 0);
            this.btnkhuyenmai.Name = "btnkhuyenmai";
            this.btnkhuyenmai.Size = new System.Drawing.Size(74, 27);
            this.btnkhuyenmai.TabIndex = 5;
            this.btnkhuyenmai.Text = "Khuyễn Mãi";
            this.btnkhuyenmai.UseVisualStyleBackColor = true;
            this.btnkhuyenmai.Click += new System.EventHandler(this.btnkhuyenmai_Click);
            // 
            // nudkhuyenmai
            // 
            this.nudkhuyenmai.Location = new System.Drawing.Point(80, 26);
            this.nudkhuyenmai.Name = "nudkhuyenmai";
            this.nudkhuyenmai.Size = new System.Drawing.Size(74, 20);
            this.nudkhuyenmai.TabIndex = 5;
            this.nudkhuyenmai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(248, 0);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(75, 49);
            this.btnthanhtoan.TabIndex = 3;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudThemmon);
            this.panel4.Controls.Add(this.btnthemmon);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Location = new System.Drawing.Point(390, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 53);
            this.panel4.TabIndex = 5;
            // 
            // nudThemmon
            // 
            this.nudThemmon.Location = new System.Drawing.Point(184, 17);
            this.nudThemmon.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudThemmon.Name = "nudThemmon";
            this.nudThemmon.Size = new System.Drawing.Size(38, 20);
            this.nudThemmon.TabIndex = 3;
            this.nudThemmon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnthemmon
            // 
            this.btnthemmon.Location = new System.Drawing.Point(244, 1);
            this.btnthemmon.Name = "btnthemmon";
            this.btnthemmon.Size = new System.Drawing.Size(76, 49);
            this.btnthemmon.TabIndex = 2;
            this.btnthemmon.Text = "Thêm Món";
            this.btnthemmon.UseVisualStyleBackColor = true;
            this.btnthemmon.Click += new System.EventHandler(this.btnthemmon_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(0, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.AllowDrop = true;
            this.flpTable.Location = new System.Drawing.Point(7, 26);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(377, 303);
            this.flpTable.TabIndex = 6;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 345);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fTableManager";
            this.Text = "Phần mềm quản lý quán Cafe";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudkhuyenmai)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudThemmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đangxuatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thongtincanhanToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnkhuyenmai;
        private System.Windows.Forms.NumericUpDown nudkhuyenmai;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.NumericUpDown nudThemmon;
        private System.Windows.Forms.Button btnthemmon;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private System.Windows.Forms.Button btnchuyenban;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txttien;
    }
}
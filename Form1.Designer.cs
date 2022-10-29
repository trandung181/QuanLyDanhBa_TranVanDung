namespace QuanLyDanhBaSInhVien
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthemnhom = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoanhom = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnthemlienlac = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnxoalienlac = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.nhomLienLacdataGridView = new System.Windows.Forms.DataGridView();
            this.lienLacdataGridView = new System.Windows.Forms.DataGridView();
            this.lbtengoi = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tenGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lienLacViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomLienLacViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomLienLacdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lienLacdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lienLacViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomLienLacViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthemnhom,
            this.toolStripLabel1,
            this.btnxoanhom,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.btnthemlienlac,
            this.toolStripLabel3,
            this.btnxoalienlac,
            this.toolStripLabel4,
            this.toolStripTextBox1,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnthemnhom
            // 
            this.btnthemnhom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnthemnhom.Image = ((System.Drawing.Image)(resources.GetObject("btnthemnhom.Image")));
            this.btnthemnhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthemnhom.Name = "btnthemnhom";
            this.btnthemnhom.Size = new System.Drawing.Size(23, 22);
            this.btnthemnhom.Text = "toolStripButton1";
            this.btnthemnhom.Click += new System.EventHandler(this.btnthemnhom_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel1.Text = "Thêm nhóm";
            // 
            // btnxoanhom
            // 
            this.btnxoanhom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnxoanhom.Image = ((System.Drawing.Image)(resources.GetObject("btnxoanhom.Image")));
            this.btnxoanhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoanhom.Name = "btnxoanhom";
            this.btnxoanhom.Size = new System.Drawing.Size(23, 22);
            this.btnxoanhom.Text = "toolStripButton2";
            this.btnxoanhom.Click += new System.EventHandler(this.btnxoanhom_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(62, 22);
            this.toolStripLabel2.Text = "Xóa nhóm";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnthemlienlac
            // 
            this.btnthemlienlac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnthemlienlac.Image = ((System.Drawing.Image)(resources.GetObject("btnthemlienlac.Image")));
            this.btnthemlienlac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthemlienlac.Name = "btnthemlienlac";
            this.btnthemlienlac.Size = new System.Drawing.Size(23, 22);
            this.btnthemlienlac.Text = "toolStripButton3";
            this.btnthemlienlac.Click += new System.EventHandler(this.btnthemlienlac_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel3.Text = "Thêm liên lạc";
            // 
            // btnxoalienlac
            // 
            this.btnxoalienlac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnxoalienlac.Image = ((System.Drawing.Image)(resources.GetObject("btnxoalienlac.Image")));
            this.btnxoalienlac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoalienlac.Name = "btnxoalienlac";
            this.btnxoalienlac.Size = new System.Drawing.Size(23, 22);
            this.btnxoalienlac.Text = "toolStripButton4";
            this.btnxoalienlac.Click += new System.EventHandler(this.btnxoalienlac_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel4.Text = "Xóa liên lạc";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(220, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel5.Text = "Nhập từ cần tìm";
            // 
            // nhomLienLacdataGridView
            // 
            this.nhomLienLacdataGridView.AllowUserToAddRows = false;
            this.nhomLienLacdataGridView.AllowUserToDeleteRows = false;
            this.nhomLienLacdataGridView.AutoGenerateColumns = false;
            this.nhomLienLacdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomLienLacdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomDataGridViewTextBoxColumn});
            this.nhomLienLacdataGridView.DataSource = this.nhomLienLacViewModelBindingSource;
            this.nhomLienLacdataGridView.Location = new System.Drawing.Point(0, 29);
            this.nhomLienLacdataGridView.Name = "nhomLienLacdataGridView";
            this.nhomLienLacdataGridView.ReadOnly = true;
            this.nhomLienLacdataGridView.Size = new System.Drawing.Size(240, 409);
            this.nhomLienLacdataGridView.TabIndex = 1;
            this.nhomLienLacdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhomLienLacdataGridView_CellContentClick);
            // 
            // lienLacdataGridView
            // 
            this.lienLacdataGridView.AllowUserToAddRows = false;
            this.lienLacdataGridView.AllowUserToDeleteRows = false;
            this.lienLacdataGridView.AutoGenerateColumns = false;
            this.lienLacdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lienLacdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenGoiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn});
            this.lienLacdataGridView.DataSource = this.lienLacViewModelBindingSource;
            this.lienLacdataGridView.Location = new System.Drawing.Point(246, 29);
            this.lienLacdataGridView.Name = "lienLacdataGridView";
            this.lienLacdataGridView.ReadOnly = true;
            this.lienLacdataGridView.Size = new System.Drawing.Size(554, 229);
            this.lienLacdataGridView.TabIndex = 2;
            this.lienLacdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lienLacdataGridView_CellContentClick);
            // 
            // lbtengoi
            // 
            this.lbtengoi.AutoSize = true;
            this.lbtengoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtengoi.Location = new System.Drawing.Point(280, 277);
            this.lbtengoi.Name = "lbtengoi";
            this.lbtengoi.Size = new System.Drawing.Size(66, 19);
            this.lbtengoi.TabIndex = 3;
            this.lbtengoi.Text = "Tên gọi";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(281, 322);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(46, 13);
            this.lbdiachi.TabIndex = 4;
            this.lbdiachi.Text = "Địa chỉ :";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(281, 359);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(38, 13);
            this.lbemail.TabIndex = 5;
            this.lbemail.Text = "Email :";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(281, 396);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(76, 13);
            this.lbsdt.TabIndex = 6;
            this.lbsdt.Text = "Số điện thoại :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "...............................................................................";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tenGoiDataGridViewTextBoxColumn
            // 
            this.tenGoiDataGridViewTextBoxColumn.DataPropertyName = "TenGoi";
            this.tenGoiDataGridViewTextBoxColumn.HeaderText = "Tên gọi";
            this.tenGoiDataGridViewTextBoxColumn.Name = "tenGoiDataGridViewTextBoxColumn";
            this.tenGoiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenGoiDataGridViewTextBoxColumn.Width = 130;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 260;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDienThoaiDataGridViewTextBoxColumn.Width = 120;
            // 
            // lienLacViewModelBindingSource
            // 
            this.lienLacViewModelBindingSource.DataSource = typeof(QuanLyDanhBaSInhVien.ViewModel.LienLacViewModel);
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "Tên nhóm";
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            this.tenNhomDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNhomDataGridViewTextBoxColumn.Width = 195;
            // 
            // nhomLienLacViewModelBindingSource
            // 
            this.nhomLienLacViewModelBindingSource.DataSource = typeof(QuanLyDanhBaSInhVien.ViewModel.NhomLienLacViewModel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbtengoi);
            this.Controls.Add(this.lienLacdataGridView);
            this.Controls.Add(this.nhomLienLacdataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - Trần Văn Dũng - 19T1021046";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomLienLacdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lienLacdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lienLacViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomLienLacViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView nhomLienLacdataGridView;
        private System.Windows.Forms.DataGridView lienLacdataGridView;
        private System.Windows.Forms.ToolStripButton btnthemnhom;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnxoanhom;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnthemlienlac;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnxoalienlac;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.Label lbtengoi;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource lienLacViewModelBindingSource;
        private System.Windows.Forms.BindingSource nhomLienLacViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
    }
}


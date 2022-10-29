using QuanLyDanhBaSInhVien.Service;
using QuanLyDanhBaSInhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDanhBaSInhVien
{
    public partial class FrmThemlienlac : Form
    {
        NhomLienLacViewModel nhomlienlac;
        public FrmThemlienlac( NhomLienLacViewModel nhomLienLac=null)
        {
            InitializeComponent();
            this.nhomlienlac = nhomLienLac;
            if(nhomlienlac != null)
            {
                txttennhom.Text = nhomlienlac.TenNhom;
            }
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttengoi = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttennhom = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên gọi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên nhóm";
            // 
            // txttengoi
            // 
            this.txttengoi.Location = new System.Drawing.Point(163, 29);
            this.txttengoi.Name = "txttengoi";
            this.txttengoi.Size = new System.Drawing.Size(100, 20);
            this.txttengoi.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(163, 65);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 6;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(163, 120);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 20);
            this.txtsdt.TabIndex = 7;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(163, 167);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(100, 20);
            this.txtdiachi.TabIndex = 8;
            // 
            // txttennhom
            // 
            this.txttennhom.Location = new System.Drawing.Point(163, 208);
            this.txttennhom.Name = "txttennhom";
            this.txttennhom.Size = new System.Drawing.Size(100, 20);
            this.txttennhom.TabIndex = 9;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(77, 275);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(186, 23);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // FrmThemlienlac
            // 
            this.ClientSize = new System.Drawing.Size(337, 332);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txttennhom);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttengoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThemlienlac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var ct = new Model.LienLac
            {
                MaLienLac = nhomlienlac.MaNhom,
                TenGoi = txttengoi.Text,
                DiaChi = txtdiachi.Text,
                SoDienThoai = txtsdt.Text,
                Email = txtemail.Text,
            };
            LienLacService.AddLienLac(ct);
            DialogResult = DialogResult.OK;

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsLienLac();
            NapDsNhomLienLac();
            
        }
        void NapDsNhomLienLac()
        {
            var ls = NhomLienLacService.getList();
            nhomLienLacViewModelBindingSource.DataSource = ls;
            nhomLienLacdataGridView.DataSource = nhomLienLacViewModelBindingSource;
        }

        void NapDsLienLac()
        {
            var ls = LienLacService.getList();
            if (selectedNhomLienLac != null)
            {
                ls = LienLacService.getList(selectedNhomLienLac.MaNhom);
            }
        }
        NhomLienLacViewModel selectedNhomLienLac
        {

            get
            {
                return nhomLienLacViewModelBindingSource.Current as NhomLienLacViewModel;
            }
        }
        LienLacViewModel selectedLienlac
        {

            get
            {
                return lienLacViewModelBindingSource.Current as LienLacViewModel;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lienLacdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var LienLac = selectedLienlac;
            lbtengoi.Text = $"{LienLac.TenGoi}";
            lbemail.Text = $"Email: {LienLac.Email}";
            lbdiachi.Text = $"Địa chỉ: {LienLac.DiaChi}";
            lbsdt.Text = $"Số điện thoại: {LienLac.SoDienThoai}";
        }

        private void nhomLienLacdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDsLienLac();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnthemnhom_Click(object sender, EventArgs e)
        {
            var f = new Frmthemnhom();
            f.ShowDialog();
            NapDsNhomLienLac();
        }

        private void btnthemlienlac_Click(object sender, EventArgs e)
        {
            var f = new FrmThemlienlac(selectedNhomLienLac);
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                MessageBox.Show("Đã thêm thành công");
                NapDsLienLac();
            }
        }

        private void btnxoanhom_Click(object sender, EventArgs e)
        {
            if (selectedNhomLienLac == null)
            {
                MessageBox.Show("Chon nhom");
            }
            else
            {
                var kq = NhomLienLacService.DeleteNhopLienLac(selectedNhomLienLac);
                if (kq == NhomLienLacService.Ketqua.t)
                {
                    NapDsNhomLienLac();
                    MessageBox.Show(" xoa thanh cong");
                }
                else
                {
                    MessageBox.Show(" xoa khong thanh cong");
                }
            }
        }

        private void btnxoalienlac_Click(object sender, EventArgs e)
        {
            if (selectedLienlac == null)
            {
                MessageBox.Show("chon lien lac");
            }
            else
            {
                LienLacService.DeleteLienLac(selectedLienlac);
                NapDsLienLac();
                MessageBox.Show("xoa thanh cong");
            }
        }
    }
}

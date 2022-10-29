using QuanLyDanhBaSInhVien.Service;
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
    public partial class Frmthemnhom : Form
    {
        public Frmthemnhom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nll = new Model.NhomLienLac
            {
                TenNhom = txttennhom.Text,
            };
            NhomLienLacService.AddNhomLienLac(nll);
            DialogResult = DialogResult.OK;
        }
    }
}

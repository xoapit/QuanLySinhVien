using DATN.BLL;
using DATN.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN
{
    public partial class FormAdd : Form
    {
        public delegate void DelegateAdd();
        public static DelegateAdd dlgAdd;
        private HuongNghienCuuBLL huongNCBLL= new HuongNghienCuuBLL();
        private GVHDBLL gvhdBLL = new GVHDBLL();
        private DoAnTotNghiepBLL datnBLL= new DoAnTotNghiepBLL();

        public FormAdd()
        {
            InitializeComponent();
            loadHuongNghienCuu();
            loadGVHD();
            loadNamBaoVe();
        }

        private void loadNamBaoVe()
        {
            for(int i = 2010; i < 2017; i++)
            {
                comboBoxNamBaoVe.Items.Add(i);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string maDATN = txtMaDATN.Text;
            string tenDATN = txtTenDATN.Text;
            string sinhvienTH = txtTenSVTH.Text;
            string huongNC = comboBoxHuongNC.Text;

            bool tinhtrang;
            if (rbChuaBaoVe.Checked) tinhtrang = false;
            else tinhtrang = true;
            int nambaove = Int32.Parse(comboBoxNamBaoVe.Text);

            var arr = (gvhdBLL.getListGVHD()).Join(huongNCBLL.getListHuongNC(),p=>p.MaHuongNC, q=>q.MaHuongNC,           
                (p,q)=>new
                {
                    p.MaHuongNC, p.TenGiangVien, q.TenHuongNC
                });

            string mahuongNC="";
            foreach(var a in arr)
            {
                if (a.TenGiangVien == comboBoxGVHD.Text && (a.TenHuongNC == huongNC)) mahuongNC = a.MaHuongNC;
            }

            DoAnTotNghiep datn = new DoAnTotNghiep
            {
                MaDoAn = maDATN,
                TenDoAn = tenDATN,
                TenSinhVienTH = sinhvienTH,
                NamThucHien = nambaove,
                TinhTrang = tinhtrang,
                MaHuongNC = mahuongNC
            };
      
            datnBLL.addDATN(datn);        
            dlgAdd();
            this.Close();
            this.Dispose();
        }

        private void loadHuongNghienCuu()
        {
            var listHuongNC = huongNCBLL.getListHuongNC();
            foreach (var huongnc in listHuongNC)
            {
                if (!comboBoxHuongNC.Items.Contains(huongnc.TenHuongNC))
                    comboBoxHuongNC.Items.Add(huongnc.TenHuongNC);
            }           
        }

        private void loadGVHD()
        {
            string huongNC = "";
            var gvhds = gvhdBLL.getListGVHD();
            foreach (var gvhd in gvhds)
            {
                if (!comboBoxGVHD.Items.Contains(gvhd.TenGiangVien))
                    comboBoxGVHD.Items.Add(gvhd.TenGiangVien);
            }            
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbsdf_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbDaBaoVe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbChuaBaoVe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHuongNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGVHD();
        }

        private void comboBoxNamBaoVe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGVHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSVTH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDATN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDATN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

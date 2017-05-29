using QuanLySinhVien3.BLL;
using QuanLySinhVien3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien3
{
    public partial class Form_EditSV : Form
    {
        private LopBLL lopBLL = new LopBLL();
        private SinhVienBLL sinhvienBLL = new SinhVienBLL();
        public delegate bool EditSV(SINHVIEN sv);
        public static EditSV edtSV;
        public Form_EditSV(SINHVIEN sinhvien)
        {
            InitializeComponent();
            LoadData(sinhvien);
            txtMSSV.Enabled = false;
        }

        public void LoadData(SINHVIEN sv)
        {
            txtMSSV.Text = sv.MSSV;
            txtHoTen.Text = sv.Name;
            dateTimePicker1.Text = sv.Birthday.ToString();
            if (sv.Gender) rbNam.Checked = true;
            else rbNu.Checked = true;
            txtDiaChi.Text = sv.Address;
            txtDienThoai.Text = sv.Mobile;
            foreach(LOP lop in lopBLL.getListLop())
            {
                comboBoxLop.Items.Add(lop.Ten_Class);
            }

            foreach (LOP lop in lopBLL.getListLop())
            {
                if (sv.ID_Class.Equals(lop.ID_Class))
                {
                    comboBoxLop.Text = lop.Ten_Class;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool gender = false;
            if (rbNam.Checked) gender = true;
            String idClass = "";
            String tenClass = comboBoxLop.Text;
            foreach (LOP lop in lopBLL.getListLop())
                if (tenClass.Equals(lop.Ten_Class)) idClass = lop.ID_Class;

            SINHVIEN sv = new SINHVIEN
            {
                MSSV = txtMSSV.Text,
                Name = txtHoTen.Text,
                Birthday = dateTimePicker1.Value.Date,
                Gender = gender,
                Address = txtDiaChi.Text,
                Mobile = txtDienThoai.Text,
                ID_Class = idClass
            };        
            edtSV(sv);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

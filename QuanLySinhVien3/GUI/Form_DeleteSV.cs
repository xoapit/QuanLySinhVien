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

namespace QuanLySinhVien3.GUI
{
    public partial class Form_DeleteSV : Form
    {
        private LopBLL lopBLL = new LopBLL();
        public delegate void DelegateDelete(SINHVIEN sv);
        public static DelegateDelete dlgDelete;
        private SINHVIEN sv;

        public Form_DeleteSV(SINHVIEN sv)
        {
            InitializeComponent();
            LoadData(sv);
            this.sv = sv;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dlgDelete(sv);
            this.Close();
            this.Dispose();
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
            foreach (LOP lop in lopBLL.getListLop())
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

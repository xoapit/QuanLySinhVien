using QuanLySinhVien3.BLL;
using QuanLySinhVien3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien3
{
    public partial class Form_AddSV : Form
    {
        private LopBLL lopBLL = new LopBLL();
        public delegate void ADD_SEND(SINHVIEN sv);
        public static ADD_SEND addSend;

        public Form_AddSV()
        {
            InitializeComponent();
            LoadLop();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AddSV();
            this.Dispose();
        }
        public void AddSV()
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

            //call to AddSV in Main form
            addSend(sv);
        }
        public void LoadLop()
        {
            var lops = lopBLL.getListLop();

            comboBoxLop.Items.Clear();
            foreach(LOP lop in lops)
            {
                comboBoxLop.Items.Add(lop.Ten_Class);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

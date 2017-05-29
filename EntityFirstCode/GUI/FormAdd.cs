using DATN.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFirstCode.GUI
{
    public partial class FormAdd : Form
    {
        public delegate void DelegateAdd();
        public static DelegateAdd dlgAdd;
        SinhVienBLL sinhvienBLL = new SinhVienBLL();
        KhoaBLL khoaBLL = new KhoaBLL();
        public FormAdd()
        {
            InitializeComponent();
            init();
        }

        public void addSinhVien(SinhVien sinhvien)
        {
            //datnBLL.addDATN(datn);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            try
            {
                SinhVienBLL sinhvienBLL = new SinhVienBLL();
                bool rbGioiTinh;
                if (radioButtonMale.Checked)
                {
                    rbGioiTinh = true;
                }
                else
                {
                    rbGioiTinh = false;
                }

                SinhVien sinhvien = new SinhVien()
                {
                    maSinhVien = txtMaSinhVien.Text.ToString(),
                    tenSinhVien = txtTenSinhVien.Text.ToString(),
                    ngaySinh = Convert.ToDateTime(dateTimePickerNgaySinh.Text.ToString()),
                    queQuan = comboBoxQueQuan.Text.ToString(),
                    hoKhau = txtHoKhau.Text.ToString(),
                    diemTrungBinhTL = (float)Convert.ToDouble(txtDiemTrungBinhTL.Text.ToString()),
                    maKhoa = comboBoxKhoa.SelectedValue.ToString(),
                    gioiTinh = rbGioiTinh
                };

                sinhvienBLL.addSinhVien(sinhvien);
                dlgAdd();
                Dispose();
            }catch(Exception e1)
            {
                MessageBox.Show("Ma Sinh Vien Da Ton Tai Hoac Du Lieu Ban Nhap Vao Khong Le");
            }
        }

        public void init()
        {
            var sinhviens = sinhvienBLL.getListSinhVien().Select(p => p);
            List<String> quequans = new List<string>();
            foreach (SinhVien sinhvien in sinhviens.ToList())
            {
                if (!quequans.Contains(sinhvien.queQuan))
                {
                    comboBoxQueQuan.Items.Add(sinhvien.queQuan);
                    quequans.Add(sinhvien.queQuan);
                }
            }

            var khoas = khoaBLL.getListKhoa().Select(p => p);
            comboBoxKhoa.ValueMember = "maKhoa";
            comboBoxKhoa.DisplayMember = "tenKhoa";
            comboBoxKhoa.DataSource = khoas.ToList();

        }
    }
}

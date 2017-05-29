using DATN.BLL;
using EntityFirstCode.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EntityFirstCode.SinhVien;

namespace EntityFirstCode
{
    public partial class Main : Form
    {

        SinhVienBLL sinhvienBLL = new SinhVienBLL();
        KhoaBLL khoaBLL = new KhoaBLL();
        FirstCode db = new FirstCode();

        public Main()
        {
            InitializeComponent();
            init();
            FormAdd.dlgAdd = new FormAdd.DelegateAdd(loadSinhVien);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd fa = new FormAdd();
            fa.Show();
        }

        public void init()
        {
            comboBoxSort.Items.Add("Mã sinh viên");
            comboBoxSort.Items.Add("Họ và tên");
            comboBoxSort.Items.Add("Tên Khoa");
            comboBoxSort.Items.Add("Điểm trung bình tích lũy");

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




        private void btnSearch_Click(object sender, EventArgs e)
        {
            string content = txtTimKiem.Text;
            viewResult(content);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check = false;
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    check = true;
                    string maSinhVien = dataGridView1.Rows[row.Index].Cells["maSinhVien"].Value.ToString();
                    SinhVien sinhvien = sinhvienBLL.getListSinhVien().Where(p => p.maSinhVien == maSinhVien).ElementAtOrDefault(0);
                    sinhvienBLL.deleteSinhVien(sinhvien);
                }
                loadSinhVien();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            if (!check)
            {
                MessageBox.Show("Ban Chua Chon Dong Nao De Xoa");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.Text.Equals(""))
            {
                MessageBox.Show("Ban Chua Chon Doi Tuong Nao De Update");
                return;
            }
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

            sinhvienBLL.updateSinhVien(sinhvien);
            loadSinhVien();

            txtDiemTrungBinhTL.Text = "";
            txtMaSinhVien.Text = "";
            txtHoKhau.Text = "";
            txtTenSinhVien.Text = "";
            txtTimKiem.Text = "";
        }

        public void loadSinhVien()
        {
            SinhVienBLL sinhvienBLL = new SinhVienBLL();

            var sinhviens = sinhvienBLL.getListSinhVien().Select(p => new { p.maSinhVien, p.tenSinhVien, p.ngaySinh, p.gioiTinh, p.diemTrungBinhTL, p.khoa.tenKhoa });
            dataGridView1.DataSource = sinhviens.ToList();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["stt"].Value = (i + 1).ToString();
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            loadSinhVien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.CurrentRow.Index;
            string maSinhVien = dataGridView1.Rows[currentRow].Cells["maSinhVien"].Value.ToString();
            SinhVien sinhvien = sinhvienBLL.getListSinhVien().Select(p => p).Where(p => p.maSinhVien == maSinhVien).ToList().First();
            showSinhVien(sinhvien);
        }

        private void showSinhVien(SinhVien sinhvien)
        {
            txtMaSinhVien.ReadOnly = true;
            txtMaSinhVien.Text = sinhvien.maSinhVien;
            txtTenSinhVien.Text = sinhvien.tenSinhVien;
            dateTimePickerNgaySinh.Text = sinhvien.ngaySinh.ToString();
            comboBoxQueQuan.Text = sinhvien.queQuan;
            txtHoKhau.Text = sinhvien.hoKhau;
            txtDiemTrungBinhTL.Text = sinhvien.diemTrungBinhTL.ToString();
            comboBoxKhoa.Text = sinhvien.khoa.tenKhoa;
            if (sinhvien.gioiTinh)
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SinhVienBLL sinhvienBLL = new SinhVienBLL();
            String content = comboBoxSort.Text;
            List<SinhVien> dssv= sinhvienBLL.sortSinhVien(content);
  
            var sinhviens = dssv.Select(p => new { p.maSinhVien, p.tenSinhVien, p.ngaySinh, p.gioiTinh, p.diemTrungBinhTL, p.khoa.tenKhoa });
            dataGridView1.DataSource = sinhviens.ToList();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["stt"].Value = (i + 1).ToString();
            }
        }

        public void viewResult(string content)
        {
            SinhVienBLL sinhvienBLL = new SinhVienBLL();

            var sinhviens = sinhvienBLL.getListSinhVien().Select(p => new { p.maSinhVien, p.tenSinhVien, p.ngaySinh, p.gioiTinh, p.diemTrungBinhTL, p.khoa.tenKhoa }).Where(p => p.maSinhVien.Contains(content) || p.tenSinhVien.Contains(content));
            dataGridView1.DataSource = sinhviens.ToList();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["stt"].Value = (i + 1).ToString();
            }
        }
    }
}

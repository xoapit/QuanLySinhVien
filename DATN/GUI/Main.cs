using DATN.BLL;
using DATN.DAL;
using DATN.GUI;
using System;
using System.Collections;
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
    public partial class Main : Form
    {
        private DoAnTotNghiepBLL datnBLL = new DoAnTotNghiepBLL();
        private GVHDBLL gvhdBLL = new GVHDBLL();
        private HuongNghienCuuBLL huongNCBLL = new HuongNghienCuuBLL();
        private int currentRow=0;

        public Main()
        {
            InitializeComponent();
            FormAdd.dlgAdd = new FormAdd.DelegateAdd(Load);

            Load();
            //LoadData("All","All","All");
            loadHuongNghienCuu();
            loadTinhTrang();
            loadGVHD();
        }

        private void loadGVHD()
        {
            var gvhds = gvhdBLL.getListGVHD();
            foreach (var gvhd in gvhds)
            {
                if (!comboBoxGVHD.Items.Contains(gvhd.TenGiangVien))
                    comboBoxGVHD.Items.Add(gvhd.TenGiangVien);
            }
            comboBoxGVHD.Items.Add("All");
            comboBoxGVHD.SelectedItem = "All";
        }

        private void loadTinhTrang()
        {
            var datns = datnBLL.getListDATN();
            foreach (var datn in datns)
            {
                if (!comboBoxTinhTrang.Items.Contains(datn.TinhTrang))
                    comboBoxTinhTrang.Items.Add(datn.TinhTrang);
            }
            comboBoxTinhTrang.Items.Add("All");
            comboBoxTinhTrang.SelectedItem = "All";
        }

        private void loadHuongNghienCuu()
        {
            var listHuongNC = huongNCBLL.getListHuongNC();
            foreach (var huongnc in listHuongNC)
            {
                if (!comboBoxHuongNC.Items.Contains(huongnc.TenHuongNC))
                    comboBoxHuongNC.Items.Add(huongnc.TenHuongNC);
            }
            comboBoxHuongNC.Items.Add("All");
            comboBoxHuongNC.SelectedItem = "All";
        }



        private void LoadData(string tenhuongnghiencuu, string tinhtrangthamso, string giaovienhuongdan)
        {

            List<DoAnTotNghiep> datn = datnBLL.getListDATN();
            List<GVHD> gvhd = gvhdBLL.getListGVHD();
            List<HuongNghienCuu> huongNC = huongNCBLL.getListHuongNC();

            if (tenhuongnghiencuu == "All")
                tenhuongnghiencuu = "";
            if (giaovienhuongdan == "All")
                giaovienhuongdan = "";
            bool tinhtrang=true;
            if (tinhtrangthamso == "True"||tinhtrangthamso=="False")
            {
                MessageBox.Show(tinhtrangthamso);
                tinhtrang = Convert.ToBoolean(tinhtrangthamso);
            }
            var s = huongNC.Join(datn, p => new { p.MaHuongNC }, q => new { q.MaHuongNC }, (p, q) => new
            {
                q.TenDoAn,
                q.TenSinhVienTH,
                p.TenHuongNC,
                p.MaHuongNC,
                q.TinhTrang,
                q.NamThucHien,
                p.MaGiangVien,
            }).Join(gvhd, k => new { k.MaHuongNC, k.MaGiangVien }, r => new { r.MaHuongNC, r.MaGiangVien }, (k, r) => new
            {
                k.TenDoAn,
                k.TenSinhVienTH,
                k.TenHuongNC,
                k.TinhTrang,
                k.NamThucHien,
                r.TenGiangVien,
            }).Where(p => p.TenHuongNC == tenhuongnghiencuu && p.TinhTrang==tinhtrang&&p.TenGiangVien==giaovienhuongdan);

            dataGridView1.DataSource = s.ToList();
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = Convert.ToString(i++);
                dataGridView1.Visible = false;
                dataGridView1.Visible = true;
            }
        }

        private void Load()
        {
            List<DoAnTotNghiep> datn = datnBLL.getListDATN();
            List<GVHD> gvhd = gvhdBLL.getListGVHD();
            List<HuongNghienCuu> huongNC = huongNCBLL.getListHuongNC();

            var s = huongNC.Join(datn, p => new { p.MaHuongNC }, q => new { q.MaHuongNC }, (p, q) => new
            {
                q.TenDoAn,
                q.TenSinhVienTH,
                p.TenHuongNC,
                p.MaHuongNC,
                q.TinhTrang,
                q.NamThucHien,
                p.MaGiangVien,
            }).Join(gvhd, k => new { k.MaHuongNC, k.MaGiangVien }, r => new { r.MaHuongNC, r.MaGiangVien }, (k, r) => new
            {
                k.TenDoAn,
                k.TenSinhVienTH,
                k.TenHuongNC,
                k.TinhTrang,
                k.NamThucHien,
                r.TenGiangVien,
            });

            dataGridView1.DataSource = s.ToList();
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = Convert.ToString(i++);
                dataGridView1.Visible = false;
                dataGridView1.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadData(comboBoxHuongNC.Text, comboBoxTinhTrang.Text, comboBoxGVHD.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            add.Show();
        }

        private void comboBoxHuongNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadData(comboBoxHuongNC.Text, comboBoxTinhTrang.Text, comboBoxGVHD.Text);
        }

        private void comboBoxTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadData(comboBoxHuongNC.Text, comboBoxTinhTrang.Text, comboBoxGVHD.Text);
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox box;
            DialogResult result = MessageBox.Show("Do you want to delete this DATN?", "Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                
                //datnBLL.deleteDATN();
            }
            if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRow = dataGridView1.CurrentRow.Index;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = currentRow;

            //FormEdit edt = new FormEdit(datn);
            //edt.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search(txtTimKiem.Text);
         
        }

        private void search(string thamso)
        {

            List<DoAnTotNghiep> datn = datnBLL.getListDATN();
            List<GVHD> gvhd = gvhdBLL.getListGVHD();
            List<HuongNghienCuu> huongNC = huongNCBLL.getListHuongNC();
            var s = huongNC.Join(datn, p => new { p.MaHuongNC }, q => new { q.MaHuongNC }, (p, q) => new
            {
                q.TenDoAn,
                q.TenSinhVienTH,
                p.TenHuongNC,
                p.MaHuongNC,
                q.TinhTrang,
                q.NamThucHien,
                p.MaGiangVien,
            }).Join(gvhd, k => new { k.MaHuongNC, k.MaGiangVien }, r => new { r.MaHuongNC, r.MaGiangVien }, (k, r) => new
            {
                k.TenDoAn,
                k.TenSinhVienTH,
                k.TenHuongNC,
                k.TinhTrang,
                k.NamThucHien,
                r.TenGiangVien,
            }).Where(p => p.TenHuongNC.Contains( thamso )|| p.TenSinhVienTH.Contains(thamso)|| p.TenGiangVien.Contains(thamso));

            dataGridView1.DataSource = s.ToList();
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = Convert.ToString(i++);
                dataGridView1.Visible = false;
                dataGridView1.Visible = true;
            }
        }
    }
}

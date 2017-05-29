using QuanLySinhVien3.BLL;
using QuanLySinhVien3.DAL;
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

namespace QuanLySinhVien3.GUI
{
    public partial class Form_SearchSV : Form
    {
        private SinhVienBLL sinhvienBLL = new SinhVienBLL();
        private LopBLL lopBLL = new LopBLL();

        private String txtTimKiem;
        public Form_SearchSV(String s)
        {
            this.txtTimKiem = s;
            InitializeComponent();
            LoadKetQua(s);
        }

        public void LoadKetQua(String s)
        {
            var sv = sinhvienBLL.getListSV().Where(p => (p.MSSV.Contains(s) == true)||(p.Name.Contains(s) || (p.Address.Contains(s)))).Select(p => p);
            var lop = lopBLL.getListLop();

            List<SINHVIEN> a = new List<SINHVIEN>();
            List<LOP> b = new List<LOP>();
            a = sv.ToList();
            b = lop.ToList();
            var kq = a.Join(b,
                p => p.ID_Class,
                q => q.ID_Class,
                (p, q) => new
                {
                    MSSV=p.MSSV,
                    NAME= p.Name,
                    Birthday =p.Birthday,
                    Gender =p.Gender,
                    Address =p.Address,
                    Mobile =p.Mobile,
                    ClassName =q.Ten_Class
                });

            dataGridView1.DataSource = kq.ToList();
        }
    }
}

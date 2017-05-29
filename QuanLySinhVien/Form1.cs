using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        private dbDotNetEntities db = new dbDotNetEntities();
        public Form1()
        {
            InitializeComponent();
            Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void Show()
        {
            
            var sv = from p in db.SINHVIENs select new { p.MaSo, p.HoTen, p.NgaySinh, p.NienKhoa, p.DienThoai, p.DiaChi, p.LOP.Ten_lop };

            
            foreach(var s1 in sv)
            {
                bool temp=false;
                foreach(var s2 in sv)
                {
                    if (s1 == s2)
                    {
                        temp = true;
                    }
                }
            }

            dataGridView1.DataSource = sv.ToList();    
        }


    }
}

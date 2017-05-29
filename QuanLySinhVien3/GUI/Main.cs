using QuanLySinhVien3.BLL;
using QuanLySinhVien3.DAL;
using QuanLySinhVien3.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien3
{
    public partial class Main : Form
    {
        private static SqlConnection conn;
        private int currentRow=0;
        private SinhVienBLL sinhvienBLL= new SinhVienBLL();
        private LopBLL lopBLL = new LopBLL();

        public Main()
        {
            InitializeComponent();
            Load();
            Form_AddSV.addSend = new Form_AddSV.ADD_SEND(AddSV);
            Form_EditSV.edtSV = new Form_EditSV.EditSV(UpdateSV);
            Form_DeleteSV.dlgDelete = new Form_DeleteSV.DelegateDelete(deleteSV);
        }       

        private void btnThem_Click(object sender, EventArgs e)
        {
            new Form_AddSV().Show();
        }

        public void AddSV(SINHVIEN sv)
        {
            sinhvienBLL.AddSV(sv);
            Load();
        }

        public bool UpdateSV(SINHVIEN sv)
        {
            try
            {
                sinhvienBLL.updateSV(sv);
                Load();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Load()
        {
            /*
            SINHVIEN[] listSV = sinhvienBLL.getListSV();
            LOP[] listLOP = lopBLL.getListLop();
            dataGridView1.DataSource = listSV;
 
            for (int i=0; i < listSV.Length; i++)
            {
                for(int j = 0; j <listLOP.Length; j++)
                {
                    if (listSV.ElementAt(i).ID_Class == listLOP.ElementAt(j).ID_Class)
                        dataGridView1.Rows[i].Cells[6].Value = listLOP.ElementAt(j).Ten_Class;
                }                
            }
            dataGridView1.Columns[6].HeaderText = "Class";    
            */
            LINQdbDataContext db = new LINQdbDataContext();
            //ISingleResult<getListSVResult> listsv = db.getListSV();
            ISingleResult<getListLOPResult> listsv = db.getListLOP();
            dataGridView1.DataSource = listsv;
    }
        
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRow = dataGridView1.CurrentRow.Index;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (currentRow != 0)
            { 
                Form_EditSV formEditSV = new Form_EditSV(sinhvienBLL.getListSV().ElementAt(currentRow));
                formEditSV.Show();
            }           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentRow != 0)
            {
                SINHVIEN sv=sinhvienBLL.getListSV().ElementAt(currentRow);
                Form_DeleteSV form = new Form_DeleteSV(sv);
                form.Show();               
            }
        }

        private void deleteSV(SINHVIEN sv)
        {
            sinhvienBLL.DeleteSV(sv);
            Load();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form_SearchSV formSearchSV = new Form_SearchSV(txtTimKiem.Text);
            formSearchSV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load();
        }
    }
}

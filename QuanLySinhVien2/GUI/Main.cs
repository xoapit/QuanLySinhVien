using QuanLySinhVien2.BLL;
using QuanLySinhVien2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien2
{
    public partial class Form1 : Form
    {
        private StudentBLL bll = new StudentBLL();
        public Form1()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            Student[] students = bll.getList();
            
            DataTable table = new DataTable();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.AutoGenerateColumns = false;
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < students.Length; i++)
                {
                    dataGridView1.Rows.Add(new object[] { students[i].Name.ToString(), students[i].Address.ToString() });
                }
            }catch(Exception e)
            {                
                //throw new Exception(e.Message);
            }          
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bll.Add(new Student(txtName.Text, txtAddress.Text));
            Load();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            bll.Remove(txtName.Text);
            Load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bll.Update(new Student(txtName.Text, txtAddress.Text));
            Load();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = dataGridView1.CurrentRow.Index;
                string name = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();
                string address = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
                txtName.Text = name;
                txtAddress.Text = address;
            }catch(Exception e2)
            {
                
            }
        }
    }
}

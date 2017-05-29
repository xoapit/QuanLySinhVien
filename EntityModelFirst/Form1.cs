using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityModelFirst
{
    public partial class Form1 : Form
    {

        ModelFirstContainer db = new ModelFirstContainer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author a = new Author() { Name = "Yin Yang", Email = "yinyang.itATgmailDOTcom"};
            db.Authors.Add(a);
            
            Book b = new Book
            {
                Title = "chao ban"                
            };

            b.Author =a;
            db.Books.Add(b);
            db.SaveChanges();
            var sv = from p in db.Authors select new { p.Name, p.Email};
            dataGridView1.DataSource = sv.ToList();
        }
    }
}

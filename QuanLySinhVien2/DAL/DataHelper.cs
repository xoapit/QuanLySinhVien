using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace QuanLySinhVien2.DAL
{
    class DataHelper
    {
        private SqlConnection conn=null;
        
        public DataHelper()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                conn = new SqlConnection();
                conn.ConnectionString=connectionString;  
        }

        public DataTable ExecuteQuery(string query)
        {
            SqlDataAdapter da;
            DataSet ds= new DataSet();
            DataTable table= new DataTable();
            try
            {
                conn.Open();
                da = new SqlDataAdapter(query, conn);
                da.Fill(table);
                
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
            }            
            return table;
        }

        public void ExecuteNonQuery(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                throw new Exception(e.Message);          
            }
            finally
            {
                conn.Close();
            }            
        }
    }
}

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

namespace products
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hELLO WORDobject sender, EventArgs eobject sender, EventArgs e
        }

        SqlConnection dbCon = new SqlConnection();

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           dbCon = new SqlConnection(
     "Server=localhost\\SQLEXPRESS; " +
     "Database=products; " +
     "Integrated Security=true");
            dbCon.Open();

        }



        private void button1_Click(object sender, EventArgs e)
        {
       
            using (dbCon)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT COUNT(*) FROM creams", dbCon);

                
                //123
                //string statement = "INSERT INTO passport (passport_id, passport) Values (1, 'Maria');";
                //using (SqlCommand command1 = new SqlCommand(statement, dbCon))
                //{
                //    command1.ExecuteNonQuery();
                //}
            }
        }
    }
}

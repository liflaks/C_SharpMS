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

namespace deze
{
    public partial class Insert2 : Form
    {
        public Insert2()
        {
            InitializeComponent();
        }

        private void Insert2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=207-2; Initial Catalog=test;Integrated Security=True";
            string sqlExpression = "INSERT operations (opername, amount, operTime, isAcvtive) VALUES('" + textBox4.Text + "', '" + Convert.ToInt32(textBox1.Text) + "', '" + textBox2.Text + "', '" + Convert.ToInt32(textBox3.Text) + "')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                sqlCommand.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DZ dZ = new DZ();
            dZ.Show();
        }
    }
}

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
    public partial class Insert1 : Form
    {
        public Insert1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DZ dZ = new DZ();
            dZ.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=207-2; Initial Catalog=test;Integrated Security=True";
            string sqlExpression = "INSERT doctors (name, qualification, isAcvtive) VALUES('" + textBox4.Text + "', '" + textBox3.Text + "', '" + Convert.ToInt32(textBox2.Text) + "')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

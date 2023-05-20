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
using deze;

namespace deze
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
            string connectionString = @"Data Source=207-2; Initial Catalog=test;Integrated Security=True";
        
            string sqlExpression = $"SELECT * FROM doctors, doctorsOperations, operations";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    object d = reader.GetValue(0);
                    object dop = reader.GetValue(1);
                    object o = reader.GetValue(2);

                    richTextBox1.Text += $"{d} + {dop} + {o}\n";
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DZ dZ = new DZ();
            dZ.Show();
        }
    }
}

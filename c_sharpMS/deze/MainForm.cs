using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deze
{
    public partial class DZ : Form
    {
        public DZ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert1 insert1 = new Insert1();
            this.Hide();
            insert1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert2 insert2 = new Insert2();
            this.Hide();
            insert2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            this.Hide();
            selectForm.Show();
        }
    }
}

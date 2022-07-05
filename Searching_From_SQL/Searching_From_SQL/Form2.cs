using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Searching_From_SQL
{
    public partial class Form2 : Form
    {
        public Form2(string found_User)
        {
            InitializeComponent();
            Fill_Label(found_User);
        }
        public void Fill_Label(string found_User)
        {
            label1.Text = "Welcome Back " + found_User;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

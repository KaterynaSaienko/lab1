using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_OK_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Kate")
                label_ok_1.BackColor = Color.Green;
            else
                label_ok_1.BackColor = Color.Red;
            if (textBox_password.Text == "1234")
                label_ok_2.BackColor = Color.Green;
            else
                label_ok_2.BackColor = Color.Red;

            if (textBox_login.Text == "Kate" && textBox_password.Text == "1234")
            {


                MessageBox.Show("Hello, Kate");
            }
            else
            {


                MessageBox.Show("Error login or passwrod");
            }
        }
    }
}





using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionAPP
{
    public partial class Form1 : Form
    {
        Data dataconn = new Data();
        public Form1()
        {
            InitializeComponent();
            dataconn.OpenConnection();
        }

        private void Form1_Load(object sender, EventArgs e)

        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader msreader = dataconn.GetDataReader("Select * FROM livres");
            while (msreader.Read()) {
                MessageBox.Show(msreader["titre"].ToString());
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("bienvenue");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        '

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}

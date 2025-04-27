

using GestionApp;
//using MySql.Data.MySqlClient;
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
using System.Drawing.Drawing2D;

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
            //MySqlDataReader msreader = dataconn.GetDataReader("Select * FROM livres");
            //while (msreader.Read())
            //{
            //    MessageBox.Show(msreader["titre"].ToString());
            //}
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


        private void connexion_Click(object sender, EventArgs e)
        {
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)

        {

        }


        private void Inscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormInscription formInscription = new FormInscription();
            formInscription.Show(); //Affiche le formulaire d'inscription
            this.Hide(); //cache le formulaire Form1
        }

        private void Form1_load(object sender, EventArgs e)
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
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void connexion_Click_1(object sender, EventArgs e)
        {
            // Créer une instance du Dashboard
            DashboardForm dashboard = new DashboardForm();

            // Masquer le formulaire actuel (Form1)
            this.Hide();

            // Afficher le dashboard
            dashboard.ShowDialog();

            // Fermer Form1 une fois que le dashboard est fermé
            this.Close();

        }

        private void Inscription_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Inscp_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        public void ArrondirControles(Control crtl, int rayon)
        {
            GraphicsPath patht = new GraphicsPath();
            patht.AddArc(0, 0, rayon, rayon, 180, 90);
            patht.AddArc(crtl.Width - rayon, 0, rayon, rayon, 270, 90);
            patht.AddArc(crtl.Width - rayon, crtl.Height - rayon, rayon, rayon, 0, 90);
            patht.AddArc(0, crtl.Height - rayon, rayon, rayon, 90, 90);
            patht.CloseAllFigures();

            crtl.Region = new Region(patht);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Veux-tu vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

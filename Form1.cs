

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
            string nom = Nom.Text;
            string adresse = Adresse.Text;
            string telephone = Tel.Text;
            string motDePasse = MDP.Text;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StockAppDB.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM Utilisateurs 
                         WHERE Nom = @Nom AND Adresse = @Adresse 
                         AND Telephone = @Telephone AND MotDePasse = @MotDePasse";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Adresse", adresse);
                    cmd.Parameters.AddWithValue("@Telephone", telephone);
                    cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Connexion réussie !");
                        // Ouvre l'interface principale ici
                    }
                    else
                    {
                        MessageBox.Show("Informations incorrectes.");
                    }
                }
            }

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

    }
}

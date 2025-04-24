using gestionAPP;
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

namespace GestionApp
{
    public partial class FormInscription : Form
    {
        public FormInscription()
        {
            InitializeComponent();
        }

        private void connexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fconnexion = new Form1();
            fconnexion.Show();
            this.Close();
        }

        private void inscrp_Click(object sender, EventArgs e)
        {
            string nom = Nom.Text;
            string telephone = Tel.Text;
            string adresse = Adresse.Text;
            string nomCommerce = Commerce.Text;
            string descriptionCommerce = Decrpt.Text;
            string motDePasse = MDP.Text;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StockAppDB.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Utilisateurs (Nom, Telephone, Adresse, NomCommerce, DescriptionCommerce, MotDePasse) " +
                               "VALUES (@Nom, @Telephone, @Adresse, @NomCommerce, @DescriptionCommerce, @MotDePasse)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Telephone", telephone);
                    cmd.Parameters.AddWithValue("@Adresse", adresse);
                    cmd.Parameters.AddWithValue("@NomCommerce", nomCommerce);
                    cmd.Parameters.AddWithValue("@DescriptionCommerce", descriptionCommerce);
                    cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Inscription réussie !");

        }

        private void connexion_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

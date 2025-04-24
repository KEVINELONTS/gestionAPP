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
    public partial class FormProduits : Form
    {
        public FormProduits()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = Nom.Text;
            int quantite = int.Parse(Qte.Text);
            string description = descrp.Text;
            string mesure = mesures.Text;
            decimal prix = decimal.Parse(prixU.Text);
            int seuil = int.Parse(Seuil.Text);
            string categorie = categ.Text;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StockAppDB.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Produits (Nom, Quantite, Description, Mesure, PrixUnitaire, SeuilAlerte, Categorie) " +
                               "VALUES (@Nom, @Quantite, @Description, @Mesure, @PrixUnitaire, @SeuilAlerte, @Categorie)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Quantite", quantite);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Mesure", mesure);
                    cmd.Parameters.AddWithValue("@PrixUnitaire", prix);
                    cmd.Parameters.AddWithValue("@SeuilAlerte", seuil);
                    cmd.Parameters.AddWithValue("@Categorie", categorie);

                    cmd.ExecuteNonQuery();
                }
            }

    // Appeler la méthode de rafraîchissement du DataGridView dans FormGestionProduits
       //((FormGestionProduits)this.Owner).ChargerProduits(); // Assure-toi d'avoir cette méthode là-bas

            this.Close(); // Ferme le formulaire après ajout

        }
    }
}

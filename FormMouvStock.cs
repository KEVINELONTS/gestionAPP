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
    public partial class FormMouvStock : Form
    {
        public FormMouvStock()
        {
            InitializeComponent();
        }

        private void enrg_Click(object sender, EventArgs e)
        {
            string typeMouvement = Type.Text;
            int quantite = int.Parse(Qte.Text);
            DateTime dateMouvement = dateTimePicker1.Value;
            string observation = observ.Text;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StockAppDB.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Mouvements (TypeMouvement, Quantite, DateMouvement, Observation) " +
                               "VALUES (@TypeMouvement, @Quantite, @DateMouvement, @Observation)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TypeMouvement", typeMouvement);
                    cmd.Parameters.AddWithValue("@Quantite", quantite);
                    cmd.Parameters.AddWithValue("@DateMouvement", dateMouvement);
                    cmd.Parameters.AddWithValue("@Observation", observation);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Mouvement enregistré avec succès !");

        }
    }
}

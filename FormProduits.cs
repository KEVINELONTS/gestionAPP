using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }

        private void FormProduits_Load(object sender, EventArgs e)
        {
            ArrondirControles(ajouter, 20);
            ArrondirControles(textBox1, 20);
            ArrondirControles(textBox2, 20);
            ArrondirControles(textBox3, 20);
            
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

        private void categ_Click(object sender, EventArgs e)
        {

        }

        private void Nom_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using Mysqlx.Crud;
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
          
        }

        private void FormMouvStock_Load(object sender, EventArgs e)
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
    }
}

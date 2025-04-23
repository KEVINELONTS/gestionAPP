using gestionAPP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}

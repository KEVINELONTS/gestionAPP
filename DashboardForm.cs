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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Titre_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stats_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void LoadUserControl(UserControlProduit userControl_P)
        {
            panelContent.Controls.Clear(); // Supprimer tout ce qui est déjà dedans
            userControl_P.Dock = DockStyle.Fill; // Pour qu’il prenne tout l’espace
            panelContent.Controls.Add(userControl_P); // Ajouter le nouveau contrôle
        }

        private void produit_Click(object sender, EventArgs e)
        {
            UserControlProduit ucProduits = new UserControlProduit();
            LoadUserControl(ucProduits);

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            //notification
            notif.BackgroundImage = Properties.Resources.notification;
            notif.BackgroundImageLayout = ImageLayout.Zoom;

            //parametre
            param.BackgroundImage = Properties.Resources.parametres_cog;
            param.BackgroundImageLayout = ImageLayout.Zoom;

            //image
            panelimg.BackgroundImage = Properties.Resources.accord;
            panelimg.BackgroundImageLayout = ImageLayout.Zoom;

            //user
            utils.BackgroundImage = Properties.Resources.utilisateur;
            utils.BackgroundImageLayout = ImageLayout.Zoom;

            //welcome
            panelwel.BackgroundImage = Properties.Resources.accueillir;
            panelwel.BackgroundImageLayout = ImageLayout.Zoom;

        }
    }
}

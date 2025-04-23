namespace GestionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void connexion_Click(object sender, EventArgs e)
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
    }
}

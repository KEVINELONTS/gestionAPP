namespace GestionApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nom = new Label();
            Adresse = new Label();
            Tel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            connexion = new Button();
            MDP = new Label();
            textBox4 = new TextBox();
            Inscription = new LinkLabel();
            Inscp = new Label();
            SuspendLayout();
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(147, 47);
            Nom.Name = "Nom";
            Nom.Size = new Size(47, 17);
            Nom.TabIndex = 0;
            Nom.Text = "Nom :";
            Nom.Click += label1_Click;
            // 
            // Adresse
            // 
            Adresse.AutoSize = true;
            Adresse.Location = new Point(147, 119);
            Adresse.Name = "Adresse";
            Adresse.Size = new Size(70, 17);
            Adresse.TabIndex = 1;
            Adresse.Text = "Adresse :";
            // 
            // Tel
            // 
            Tel.AutoSize = true;
            Tel.Location = new Point(147, 175);
            Tel.Name = "Tel";
            Tel.Size = new Size(34, 17);
            Tel.TabIndex = 2;
            Tel.Text = "Tel :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 25);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(362, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 25);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(362, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 25);
            textBox3.TabIndex = 5;
            // 
            // connexion
            // 
            connexion.Location = new Point(311, 301);
            connexion.Name = "connexion";
            connexion.Size = new Size(150, 39);
            connexion.TabIndex = 6;
            connexion.Text = "Se connecter";
            connexion.UseVisualStyleBackColor = true;
            connexion.Click += connexion_Click;
            // 
            // MDP
            // 
            MDP.AutoSize = true;
            MDP.Location = new Point(147, 242);
            MDP.Name = "MDP";
            MDP.Size = new Size(103, 17);
            MDP.TabIndex = 8;
            MDP.Text = "Mot de passe :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(362, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 25);
            textBox4.TabIndex = 9;
            textBox4.UseSystemPasswordChar = true;
            // 
            // Inscription
            // 
            Inscription.AutoSize = true;
            Inscription.Location = new Point(450, 399);
            Inscription.Name = "Inscription";
            Inscription.Size = new Size(107, 17);
            Inscription.TabIndex = 10;
            Inscription.TabStop = true;
            Inscription.Text = "Inscrivez-vous!";
            Inscription.LinkClicked += Inscription_LinkClicked;
            // 
            // Inscp
            // 
            Inscp.AutoSize = true;
            Inscp.Location = new Point(187, 399);
            Inscp.Name = "Inscp";
            Inscp.Size = new Size(243, 17);
            Inscp.TabIndex = 11;
            Inscp.Text = "vous n'avez pas encore de compte?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Inscp);
            Controls.Add(Inscription);
            Controls.Add(textBox4);
            Controls.Add(MDP);
            Controls.Add(connexion);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Tel);
            Controls.Add(Adresse);
            Controls.Add(Nom);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nom;
        private Label Adresse;
        private Label Tel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button connexion;
        private Label MDP;
        private TextBox textBox4;
        private LinkLabel Inscription;
        private Label Inscp;
    }
}

using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionApp
{
    partial class FormInscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nom = new Label();
            Commerce = new Label();
            Decrpt = new Label();
            Adresse = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Tel = new Label();
            textBox5 = new TextBox();
            titre = new Label();
            inscrp = new Button();
            MDP = new Label();
            textBox6 = new TextBox();
            texte = new Label();
            connexion = new LinkLabel();
            SuspendLayout();
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(212, 85);
            Nom.Name = "Nom";
            Nom.Size = new Size(47, 17);
            Nom.TabIndex = 0;
            Nom.Text = "Nom :";
            // 
            // Commerce
            // 
            Commerce.AutoSize = true;
            Commerce.Location = new Point(212, 171);
            Commerce.Name = "Commerce";
            Commerce.Size = new Size(142, 17);
            Commerce.TabIndex = 1;
            Commerce.Text = "Nom du commerce :";
            // 
            // Decrpt
            // 
            Decrpt.AutoSize = true;
            Decrpt.Location = new Point(212, 225);
            Decrpt.Name = "Decrpt";
            Decrpt.Size = new Size(185, 17);
            Decrpt.TabIndex = 2;
            Decrpt.Text = "Description du commerce :";
            // 
            // Adresse
            // 
            Adresse.AutoSize = true;
            Adresse.Location = new Point(212, 271);
            Adresse.Name = "Adresse";
            Adresse.Size = new Size(70, 17);
            Adresse.TabIndex = 3;
            Adresse.Text = "Adresse :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(427, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 25);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(427, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 25);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(427, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 25);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(427, 222);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(228, 25);
            textBox4.TabIndex = 7;
            // 
            // Tel
            // 
            Tel.AutoSize = true;
            Tel.Location = new Point(212, 130);
            Tel.Name = "Tel";
            Tel.Size = new Size(34, 17);
            Tel.TabIndex = 8;
            Tel.Text = "Tel :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(427, 263);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(228, 25);
            textBox5.TabIndex = 9;
            // 
            // titre
            // 
            titre.AutoSize = true;
            titre.Location = new Point(367, 22);
            titre.Name = "titre";
            titre.Size = new Size(100, 17);
            titre.TabIndex = 10;
            titre.Text = "INSCRIPTION";
            // 
            // inscrp
            // 
            inscrp.Location = new Point(367, 363);
            inscrp.Name = "inscrp";
            inscrp.Size = new Size(122, 37);
            inscrp.TabIndex = 11;
            inscrp.Text = "S'inscrire";
            inscrp.UseVisualStyleBackColor = true;
            // 
            // MDP
            // 
            MDP.AutoSize = true;
            MDP.Location = new Point(212, 323);
            MDP.Name = "MDP";
            MDP.Size = new Size(103, 17);
            MDP.TabIndex = 12;
            MDP.Text = "Mot de passe :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(427, 315);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(228, 25);
            textBox6.TabIndex = 13;
            textBox6.UseSystemPasswordChar = true;
            // 
            // texte
            // 
            texte.AutoSize = true;
            texte.Location = new Point(212, 424);
            texte.Name = "texte";
            texte.Size = new Size(191, 17);
            texte.TabIndex = 14;
            texte.Text = "Vous avez deja un compte ?";
            // 
            // connexion
            // 
            connexion.AutoSize = true;
            connexion.Location = new Point(409, 424);
            connexion.Name = "connexion";
            connexion.Size = new Size(115, 17);
            connexion.TabIndex = 15;
            connexion.TabStop = true;
            connexion.Text = "Connectez-vous";
            connexion.LinkClicked += connexion_LinkClicked;
            // 
            // FormInscription
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(connexion);
            Controls.Add(texte);
            Controls.Add(textBox6);
            Controls.Add(MDP);
            Controls.Add(inscrp);
            Controls.Add(titre);
            Controls.Add(textBox5);
            Controls.Add(Tel);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Adresse);
            Controls.Add(Decrpt);
            Controls.Add(Commerce);
            Controls.Add(Nom);
            Name = "FormInscription";
            Text = "FormInscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nom;
        private Label Commerce;
        private Label Decrpt;
        private Label Adresse;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label Tel;
        private TextBox textBox5;
        private Label titre;
        private Button inscrp;
        private Label MDP;
        private TextBox textBox6;
        private Label texte;
        private LinkLabel connexion;
    }
}
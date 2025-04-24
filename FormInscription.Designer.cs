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
            this.Nom = new System.Windows.Forms.Label();
            this.Commerce = new System.Windows.Forms.Label();
            this.Decrpt = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.titre = new System.Windows.Forms.Label();
            this.inscrp = new System.Windows.Forms.Button();
            this.MDP = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.texte = new System.Windows.Forms.Label();
            this.connexion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(212, 80);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(42, 16);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom :";
            // 
            // Commerce
            // 
            this.Commerce.AutoSize = true;
            this.Commerce.Location = new System.Drawing.Point(212, 161);
            this.Commerce.Name = "Commerce";
            this.Commerce.Size = new System.Drawing.Size(127, 16);
            this.Commerce.TabIndex = 1;
            this.Commerce.Text = "Nom du commerce :";
            // 
            // Decrpt
            // 
            this.Decrpt.AutoSize = true;
            this.Decrpt.Location = new System.Drawing.Point(212, 212);
            this.Decrpt.Name = "Decrpt";
            this.Decrpt.Size = new System.Drawing.Size(166, 16);
            this.Decrpt.TabIndex = 2;
            this.Decrpt.Text = "Description du commerce :";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(212, 255);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(64, 16);
            this.Adresse.TabIndex = 3;
            this.Adresse.Text = "Adresse :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(427, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(427, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(427, 209);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 24);
            this.textBox4.TabIndex = 7;
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(212, 122);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(33, 16);
            this.Tel.TabIndex = 8;
            this.Tel.Text = "Tel :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(427, 248);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(228, 22);
            this.textBox5.TabIndex = 9;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Location = new System.Drawing.Point(367, 21);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(92, 16);
            this.titre.TabIndex = 10;
            this.titre.Text = "INSCRIPTION";
            // 
            // inscrp
            // 
            this.inscrp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.inscrp.Location = new System.Drawing.Point(348, 338);
            this.inscrp.Name = "inscrp";
            this.inscrp.Size = new System.Drawing.Size(111, 41);
            this.inscrp.TabIndex = 11;
            this.inscrp.Text = "S\'inscrire";
            this.inscrp.UseVisualStyleBackColor = false;
            this.inscrp.Click += new System.EventHandler(this.inscrp_Click);
            // 
            // MDP
            // 
            this.MDP.AutoSize = true;
            this.MDP.Location = new System.Drawing.Point(212, 304);
            this.MDP.Name = "MDP";
            this.MDP.Size = new System.Drawing.Size(95, 16);
            this.MDP.TabIndex = 12;
            this.MDP.Text = "Mot de passe :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(427, 296);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(228, 22);
            this.textBox6.TabIndex = 13;
            this.textBox6.UseSystemPasswordChar = true;
            // 
            // texte
            // 
            this.texte.AutoSize = true;
            this.texte.Location = new System.Drawing.Point(212, 399);
            this.texte.Name = "texte";
            this.texte.Size = new System.Drawing.Size(175, 16);
            this.texte.TabIndex = 14;
            this.texte.Text = "Vous avez deja un compte ?";
            // 
            // connexion
            // 
            this.connexion.AutoSize = true;
            this.connexion.Location = new System.Drawing.Point(393, 399);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(103, 16);
            this.connexion.TabIndex = 15;
            this.connexion.TabStop = true;
            this.connexion.Text = "Connectez-vous";
            this.connexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.connexion_LinkClicked_1);
            // 
            // FormInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.connexion);
            this.Controls.Add(this.texte);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.MDP);
            this.Controls.Add(this.inscrp);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Decrpt);
            this.Controls.Add(this.Commerce);
            this.Controls.Add(this.Nom);
            this.Name = "FormInscription";
            this.Text = "FormInscription";
            this.ResumeLayout(false);
            this.PerformLayout();

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
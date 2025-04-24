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
    partial class FormProduits
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
            this.Produit = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Qte = new System.Windows.Forms.Label();
            this.mesures = new System.Windows.Forms.Label();
            this.descrp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.choix = new System.Windows.Forms.ComboBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.prixU = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Seuil = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.categ = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Produit
            // 
            this.Produit.AutoSize = true;
            this.Produit.Location = new System.Drawing.Point(366, 25);
            this.Produit.Name = "Produit";
            this.Produit.Size = new System.Drawing.Size(77, 16);
            this.Produit.TabIndex = 0;
            this.Produit.Text = "PRODUITS";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(150, 77);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(101, 16);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom du produit:";
            // 
            // Qte
            // 
            this.Qte.AutoSize = true;
            this.Qte.Location = new System.Drawing.Point(150, 122);
            this.Qte.Name = "Qte";
            this.Qte.Size = new System.Drawing.Size(62, 16);
            this.Qte.TabIndex = 2;
            this.Qte.Text = "Quantite :";
            // 
            // mesures
            // 
            this.mesures.AutoSize = true;
            this.mesures.Location = new System.Drawing.Point(150, 213);
            this.mesures.Name = "mesures";
            this.mesures.Size = new System.Drawing.Size(58, 16);
            this.mesures.TabIndex = 3;
            this.mesures.Text = "Mesure :";
            // 
            // descrp
            // 
            this.descrp.AutoSize = true;
            this.descrp.Location = new System.Drawing.Point(150, 167);
            this.descrp.Name = "descrp";
            this.descrp.Size = new System.Drawing.Size(81, 16);
            this.descrp.TabIndex = 4;
            this.descrp.Text = "Description :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(352, 159);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 24);
            this.textBox3.TabIndex = 7;
            // 
            // choix
            // 
            this.choix.FormattingEnabled = true;
            this.choix.Items.AddRange(new object[] {
            "Litre",
            "Morceaux",
            "Gramme",
            "kilos",
            "autres"});
            this.choix.Location = new System.Drawing.Point(352, 205);
            this.choix.Name = "choix";
            this.choix.Size = new System.Drawing.Size(239, 24);
            this.choix.TabIndex = 8;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(292, 367);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(151, 45);
            this.ajouter.TabIndex = 9;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // prixU
            // 
            this.prixU.AutoSize = true;
            this.prixU.Location = new System.Drawing.Point(150, 251);
            this.prixU.Name = "prixU";
            this.prixU.Size = new System.Drawing.Size(81, 16);
            this.prixU.TabIndex = 10;
            this.prixU.Text = "Prix unitaire :";
            this.prixU.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(352, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 22);
            this.textBox4.TabIndex = 11;
            // 
            // Seuil
            // 
            this.Seuil.AutoSize = true;
            this.Seuil.Location = new System.Drawing.Point(150, 290);
            this.Seuil.Name = "Seuil";
            this.Seuil.Size = new System.Drawing.Size(91, 16);
            this.Seuil.TabIndex = 12;
            this.Seuil.Text = "Seuil d\'alerte :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(352, 284);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 22);
            this.textBox5.TabIndex = 13;
            // 
            // categ
            // 
            this.categ.AutoSize = true;
            this.categ.Location = new System.Drawing.Point(150, 324);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(72, 16);
            this.categ.TabIndex = 14;
            this.categ.Text = "Categorie :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(352, 321);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(239, 22);
            this.textBox6.TabIndex = 15;
            // 
            // FormProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.categ);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Seuil);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.prixU);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.choix);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.descrp);
            this.Controls.Add(this.mesures);
            this.Controls.Add(this.Qte);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Produit);
            this.Name = "FormProduits";
            this.Text = "FormProduits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Produit;
        private Label Nom;
        private Label Qte;
        private Label mesures;
        private Label descrp;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox choix;
        private Button ajouter;
        private Label prixU;
        private TextBox textBox4;
        private Label Seuil;
        private TextBox textBox5;
        private Label categ;
        private TextBox textBox6;
    }
}
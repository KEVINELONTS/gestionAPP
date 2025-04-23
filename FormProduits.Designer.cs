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
            Produit = new Label();
            Nom = new Label();
            Qte = new Label();
            mesure = new Label();
            descrp = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            choix = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Produit
            // 
            Produit.AutoSize = true;
            Produit.Location = new Point(366, 27);
            Produit.Name = "Produit";
            Produit.Size = new Size(84, 17);
            Produit.TabIndex = 0;
            Produit.Text = "PRODUITS";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(150, 82);
            Nom.Name = "Nom";
            Nom.Size = new Size(111, 17);
            Nom.TabIndex = 1;
            Nom.Text = "Nom du produit:";
            Nom.Click += label2_Click;
            // 
            // Qte
            // 
            Qte.AutoSize = true;
            Qte.Location = new Point(150, 155);
            Qte.Name = "Qte";
            Qte.Size = new Size(71, 17);
            Qte.TabIndex = 2;
            Qte.Text = "Quantite :";
            // 
            // mesure
            // 
            mesure.AutoSize = true;
            mesure.Location = new Point(150, 291);
            mesure.Name = "mesure";
            mesure.Size = new Size(64, 17);
            mesure.TabIndex = 3;
            mesure.Text = "Mesure :";
            // 
            // descrp
            // 
            descrp.AutoSize = true;
            descrp.Location = new Point(150, 227);
            descrp.Name = "descrp";
            descrp.Size = new Size(90, 17);
            descrp.TabIndex = 4;
            descrp.Text = "Description :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 25);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(352, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 25);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(352, 219);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 25);
            textBox3.TabIndex = 7;
            // 
            // choix
            // 
            choix.FormattingEnabled = true;
            choix.Items.AddRange(new object[] { "Litre", "Morceaux", "Gramme", "kilos", "autres" });
            choix.Location = new Point(352, 291);
            choix.Name = "choix";
            choix.Size = new Size(239, 25);
            choix.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(299, 360);
            button1.Name = "button1";
            button1.Size = new Size(151, 48);
            button1.TabIndex = 9;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormProduits
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(choix);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(descrp);
            Controls.Add(mesure);
            Controls.Add(Qte);
            Controls.Add(Nom);
            Controls.Add(Produit);
            Name = "FormProduits";
            Text = "FormProduits";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Produit;
        private Label Nom;
        private Label Qte;
        private Label mesure;
        private Label descrp;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox choix;
        private Button button1;
    }
}
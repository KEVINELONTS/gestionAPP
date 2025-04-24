using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace gestionAPP

{
    partial class Form1
    {
        /// <summary>

        ///  Required designer variable.

        /// Variable nécessaire au concepteur.

        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>

        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        /// Nettoyage des ressources utilisées.
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


        //#region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nom = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.connexion = new System.Windows.Forms.Button();
            this.MDP = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Inscription = new System.Windows.Forms.LinkLabel();
            this.Inscp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(147, 44);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(42, 16);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom :";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(147, 112);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(64, 16);
            this.Adresse.TabIndex = 1;
            this.Adresse.Text = "Adresse :";
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(147, 165);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(33, 16);
            this.Tel.TabIndex = 2;
            this.Tel.Text = "Tel :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(362, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(362, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 22);
            this.textBox3.TabIndex = 5;
            // 
            // connexion
            // 
            this.connexion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.connexion.Location = new System.Drawing.Point(311, 283);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(150, 37);
            this.connexion.TabIndex = 6;
            this.connexion.Text = "Se connecter";
            this.connexion.UseVisualStyleBackColor = false;
            // 
            // MDP
            // 
            this.MDP.AutoSize = true;
            this.MDP.Location = new System.Drawing.Point(147, 228);
            this.MDP.Name = "MDP";
            this.MDP.Size = new System.Drawing.Size(95, 16);
            this.MDP.TabIndex = 8;
            this.MDP.Text = "Mot de passe :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(362, 212);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // Inscription
            // 
            this.Inscription.AutoSize = true;
            this.Inscription.Location = new System.Drawing.Point(450, 376);
            this.Inscription.Name = "Inscription";
            this.Inscription.Size = new System.Drawing.Size(95, 16);
            this.Inscription.TabIndex = 10;
            this.Inscription.TabStop = true;
            this.Inscription.Text = "Inscrivez-vous!";
            // 
            // Inscp
            // 
            this.Inscp.AutoSize = true;
            this.Inscp.Location = new System.Drawing.Point(187, 376);
            this.Inscp.Name = "Inscp";
            this.Inscp.Size = new System.Drawing.Size(223, 16);
            this.Inscp.TabIndex = 11;
            this.Inscp.Text = "vous n\'avez pas encore de compte?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.Inscp);
            this.Controls.Add(this.Inscription);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.MDP);
            this.Controls.Add(this.connexion);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Nom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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
        private Label Inscp; } }

//#region Code généré par le Concepteur Windows Form

///// <summary>
///// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
///// le contenu de cette méthode avec l'éditeur de code.
///// </summary>
//private void InitializeComponent()
//    { }
//        this.Nom = new System.Windows.Forms.Label();
//        this.Adresse = new System.Windows.Forms.Label();
//        this.Tel = new System.Windows.Forms.Label();
//        this.MDP = new System.Windows.Forms.Label();
//        this.Inscp = new System.Windows.Forms.Label();
//        this.textBox1 = new System.Windows.Forms.TextBox();
//        this.textBox2 = new System.Windows.Forms.TextBox();
//        this.textBox3 = new System.Windows.Forms.TextBox();
//        this.textBox4 = new System.Windows.Forms.TextBox();
//        this.connexion = new System.Windows.Forms.Button();
//        //this. = new System.Windows.Forms.Label();
//        //this.label7 = new System.Windows.Forms.Label();
//        this.Inscription = new System.Windows.Forms.LinkLabel();
//        this.SuspendLayout();
//        // 
//        // label1
//        // 
//        this.Nom.AutoSize = true;
//        this.Nom.Location = new System.Drawing.Point(130, 43);
//        this.Nom.Name = "label1";
//        this.Nom.Size = new System.Drawing.Size(39, 16);
//        this.Nom.TabIndex = 0;
//        this.Nom.Text = "Nom:";
//        this.Nom.Click += new System.EventHandler(this.label1_Click);
//        // 
//        // label2
//        // 
//        this.Adresse.AutoSize = true;
//        this.Adresse.Location = new System.Drawing.Point(130, 107);
//        this.Adresse.Name = "label2";
//        this.Adresse.Size = new System.Drawing.Size(61, 16);
//        this.Adresse.TabIndex = 1;
//        this.Adresse.Text = "Adresse:";
//        this.Adresse.Click += new System.EventHandler(this.label2_Click);
//        // 
//        // label3
//        // 
//        this.Tel.AutoSize = true;
//        this.Tel.Location = new System.Drawing.Point(130, 182);
//        this.Tel.Name = "label3";
//        this.Tel.Size = new System.Drawing.Size(30, 16);
//        this.Tel.TabIndex = 2;
//        this.Tel.Text = "Tel:";
//        this.Tel.Click += new System.EventHandler(this.label3_Click);
//        // 
//        // label4
//        // 
//        this.MDP.AutoSize = true;
//        this.MDP.Location = new System.Drawing.Point(304, 269);
//        this.MDP.Name = "label4";
//        this.MDP.Size = new System.Drawing.Size(0, 16);
//        this.MDP.TabIndex = 5;
//        // 
//        // label5
//        // 
//        //this.Inscp.AutoSize = true;
//        //this.Inscp.Location = new System.Drawing.Point(130, 263);
//        //this.Inscp.Name = "label5";
//        //this.Inscp.Size = new System.Drawing.Size(75, 16);
//        //this.Inscp.TabIndex = 9;
//        //this.Inscp.Text = "Passeword";
//        //this.Inscp.Click += new System.EventHandler(this.label5_Click);
//        // 
//        // textBox1
//        // 
//        this.textBox1.Location = new System.Drawing.Point(388, 37);
//        this.textBox1.Name = "textBox1";
//        this.textBox1.Size = new System.Drawing.Size(280, 22);
//        this.textBox1.TabIndex = 10;
//        this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
//        // 
//        // textBox2
//        // 
//        this.textBox2.Location = new System.Drawing.Point(388, 107);
//        this.textBox2.Name = "textBox2";
//        this.textBox2.Size = new System.Drawing.Size(280, 22);
//        this.textBox2.TabIndex = 11;
//        this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
//        // 
//        // textBox3
//        // 
//        this.textBox3.Location = new System.Drawing.Point(388, 182);
//        this.textBox3.Name = "textBox3";
//        this.textBox3.Size = new System.Drawing.Size(280, 22);
//        this.textBox3.TabIndex = 12;
//        this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
//        // 
//        // textBox4
//        // 
//        this.textBox4.Location = new System.Drawing.Point(388, 263);
//        this.textBox4.Name = "textBox4";
//        this.textBox4.Size = new System.Drawing.Size(290, 22);
//        this.textBox4.TabIndex = 13;
//        this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
//        // 
//        // button1
//        // 
//        this.connexion.Location = new System.Drawing.Point(218, 327);
//        this.connexion.Name = "button1";
//        this.connexion.Size = new System.Drawing.Size(167, 28);
//        this.connexion.TabIndex = 14;
//        this.connexion.Text = "Se connecter";
//        this.connexion.UseVisualStyleBackColor = true;
//        this.connexion.Click += new System.EventHandler(this.button1_Click_1);
//        // 
//        // label6
//        // 
//        //this.label6.AutoSize = true;
//        //this.label6.Location = new System.Drawing.Point(0, 0);
//        //this.label6.Name = "label6";
//        //this.label6.Size = new System.Drawing.Size(44, 16);
//        //this.label6.TabIndex = 15;
//        //this.label6.Text = "label6";
//        // 
//        // label7
//        // 
//        this.Inscp.AutoSize = true;
//        this.Inscp.Location = new System.Drawing.Point(79, 399);
//        this.Inscp.Name = "label7";
//        this.Inscp.Size = new System.Drawing.Size(225, 16);
//        this.Inscp.TabIndex = 16;
//        this.Inscp.Text = "vous  n avez pas encors de compte?";
//        // 
//        // linkLabel1
//        // 
//        this.Inscription.AutoSize = true;
//        this.Inscription.Location = new System.Drawing.Point(372, 384);
//        this.Inscription.Name = "linkLabel1";
//        this.Inscription.Size = new System.Drawing.Size(95, 48);
//        this.Inscription.TabIndex = 17;
//        this.Inscription.TabStop = true;
//        this.Inscription.Text = "inscrivez-vous!\r\n\r\n\r\n";
//        // 
//        // Form1
//        // 
//        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//        this.ClientSize = new System.Drawing.Size(800, 450);
//        this.Controls.Add(this.Inscription);
//        this.Controls.Add(this.Inscp);
//        //this.Controls.Add(this.label6);
//        this.Controls.Add(this.connexion);
//        this.Controls.Add(this.textBox4);
//        this.Controls.Add(this.textBox3);
//        this.Controls.Add(this.textBox2);
//        this.Controls.Add(this.textBox1);
//        //this.Controls.Add(this.label5);
//        this.Controls.Add(this.MDP);
//        this.Controls.Add(this.Tel);
//        this.Controls.Add(this.Adresse);
//        this.Controls.Add(this.Nom);
//        this.Name = "Form1";
//        this.Text = "Form1";
//        this.Load += new System.EventHandler(this.Form1_Load);
//        this.ResumeLayout(false);
//        this.PerformLayout();
//}



//    #endregion





//private System.Windows.Forms.Label label1;
//private System.Windows.Forms.Label label2;
//private System.Windows.Forms.Label label3;
//private System.Windows.Forms.Label label4;
//private System.Windows.Forms.Label label5;
//private System.Windows.Forms.TextBox textBox1;
//private System.Windows.Forms.TextBox textBox2;
//private System.Windows.Forms.TextBox textBox3;
//private System.Windows.Forms.TextBox textBox4;
//private System.Windows.Forms.Button button1;
//private System.Windows.Forms.Label label6;
//private System.Windows.Forms.Label label7;
//private System.Windows.Forms.LinkLabel linkLabel1;


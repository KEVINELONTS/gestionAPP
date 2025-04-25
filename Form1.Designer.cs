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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.connexion = new System.Windows.Forms.Button();
            this.conn = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(81, 162);
            this.Nom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(62, 21);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(70, 187);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 56);
            this.textBox1.TabIndex = 3;
            // 
            // connexion
            // 
            this.connexion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.connexion.FlatAppearance.BorderSize = 0;
            this.connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connexion.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.connexion.Location = new System.Drawing.Point(112, 396);
            this.connexion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(263, 63);
            this.connexion.TabIndex = 6;
            this.connexion.Text = "Se connecter";
            this.connexion.UseVisualStyleBackColor = false;
            this.connexion.Click += new System.EventHandler(this.connexion_Click_1);
            // 
            // conn
            // 
            this.conn.AutoSize = true;
            this.conn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.conn.Location = new System.Drawing.Point(142, 61);
            this.conn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.conn.Name = "conn";
            this.conn.Size = new System.Drawing.Size(233, 47);
            this.conn.TabIndex = 12;
            this.conn.Text = "Connexion";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(70, 300);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 57);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de Passe :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::gestionAPP.Properties.Resources.croix_icone;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(426, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 60);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(524, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.conn);
            this.Controls.Add(this.connexion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nom);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label Nom;
        private TextBox textBox1;
        private Button connexion;
        private Label conn;
        private PageSetupDialog pageSetupDialog1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
    } }

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


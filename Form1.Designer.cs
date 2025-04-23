<<<<<<< HEAD
﻿namespace GestionApp
=======
﻿namespace gestionAPP
>>>>>>> ca5613df8715ea781f773535092be433e3f4a76b
{
    partial class Form1
    {
        /// <summary>
<<<<<<< HEAD
        ///  Required designer variable.
=======
        /// Variable nécessaire au concepteur.
>>>>>>> ca5613df8715ea781f773535092be433e3f4a76b
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
<<<<<<< HEAD
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
=======
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
>>>>>>> ca5613df8715ea781f773535092be433e3f4a76b
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

<<<<<<< HEAD
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
=======
        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Passeword";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(388, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(388, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(280, 22);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(388, 263);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(290, 22);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "vous  n avez pas encors de compte?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(372, 384);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 48);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "inscrivez-vous!\r\n\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

>>>>>>> ca5613df8715ea781f773535092be433e3f4a76b
        }

        #endregion

<<<<<<< HEAD
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
=======
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

>>>>>>> ca5613df8715ea781f773535092be433e3f4a76b

namespace gestionAPP
{
    partial class DashboardForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.deconex = new System.Windows.Forms.Button();
            this.stats = new System.Windows.Forms.Button();
            this.produit = new System.Windows.Forms.Button();
            this.mouv = new System.Windows.Forms.Button();
            this.util = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.panelMenu.Controls.Add(this.util);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.deconex);
            this.panelMenu.Controls.Add(this.stats);
            this.panelMenu.Controls.Add(this.produit);
            this.panelMenu.Controls.Add(this.mouv);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 544);
            this.panelMenu.TabIndex = 0;
            // 
            // deconex
            // 
            this.deconex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.deconex.FlatAppearance.BorderSize = 0;
            this.deconex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deconex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deconex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deconex.Location = new System.Drawing.Point(25, 278);
            this.deconex.Name = "deconex";
            this.deconex.Size = new System.Drawing.Size(146, 34);
            this.deconex.TabIndex = 5;
            this.deconex.Text = "Categories";
            this.deconex.UseVisualStyleBackColor = false;
            this.deconex.Click += new System.EventHandler(this.deconex_Click);
            // 
            // stats
            // 
            this.stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.stats.FlatAppearance.BorderSize = 0;
            this.stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stats.Location = new System.Drawing.Point(25, 419);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(146, 34);
            this.stats.TabIndex = 4;
            this.stats.Text = "Statistiques";
            this.stats.UseVisualStyleBackColor = false;
            this.stats.Click += new System.EventHandler(this.stats_Click);
            // 
            // produit
            // 
            this.produit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.produit.FlatAppearance.BorderSize = 0;
            this.produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produit.Location = new System.Drawing.Point(25, 138);
            this.produit.Name = "produit";
            this.produit.Size = new System.Drawing.Size(146, 34);
            this.produit.TabIndex = 3;
            this.produit.Text = "Produits";
            this.produit.UseVisualStyleBackColor = false;
            this.produit.Click += new System.EventHandler(this.produit_Click);
            // 
            // mouv
            // 
            this.mouv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.mouv.FlatAppearance.BorderSize = 0;
            this.mouv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mouv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mouv.Location = new System.Drawing.Point(25, 203);
            this.mouv.Name = "mouv";
            this.mouv.Size = new System.Drawing.Size(146, 34);
            this.mouv.TabIndex = 2;
            this.mouv.Text = "Mouvements";
            this.mouv.UseVisualStyleBackColor = false;
            // 
            // util
            // 
            this.util.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.util.FlatAppearance.BorderSize = 0;
            this.util.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.util.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.util.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.util.Location = new System.Drawing.Point(25, 485);
            this.util.Name = "util";
            this.util.Size = new System.Drawing.Size(146, 34);
            this.util.TabIndex = 0;
            this.util.Text = "Utilisateurs";
            this.util.UseVisualStyleBackColor = false;
            this.util.Click += new System.EventHandler(this.util_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContent.Location = new System.Drawing.Point(210, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(867, 444);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(156)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.titre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(210, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.White;
            this.titre.Location = new System.Drawing.Point(250, 18);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(354, 47);
            this.titre.TabIndex = 0;
            this.titre.Text = "Gestion De Stock";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(25, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Operations";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::gestionAPP.Properties.Resources.setting_2;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(18, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 58);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::gestionAPP.Properties.Resources.notif_1;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(753, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 47);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::gestionAPP.Properties.Resources.power2;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(805, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 58);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button util;
        private System.Windows.Forms.Button mouv;
        private System.Windows.Forms.Button deconex;
        private System.Windows.Forms.Button stats;
        private System.Windows.Forms.Button produit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
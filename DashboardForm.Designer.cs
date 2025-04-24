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
            this.panelContent = new System.Windows.Forms.Panel();
            this.util = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Label();
            this.mouv = new System.Windows.Forms.Button();
            this.produit = new System.Windows.Forms.Button();
            this.stats = new System.Windows.Forms.Button();
            this.deconex = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.Titre = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.deconn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notif = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMenu.Controls.Add(this.deconn);
            this.panelMenu.Controls.Add(this.user);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.deconex);
            this.panelMenu.Controls.Add(this.stats);
            this.panelMenu.Controls.Add(this.produit);
            this.panelMenu.Controls.Add(this.mouv);
            this.panelMenu.Controls.Add(this.menu);
            this.panelMenu.Controls.Add(this.util);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 390);
            this.panelMenu.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.panel4);
            this.panelContent.Controls.Add(this.panel3);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContent.Location = new System.Drawing.Point(200, 60);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(600, 390);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // util
            // 
            this.util.BackColor = System.Drawing.SystemColors.Highlight;
            this.util.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.util.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.util.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.util.Location = new System.Drawing.Point(25, 113);
            this.util.Name = "util";
            this.util.Size = new System.Drawing.Size(146, 34);
            this.util.TabIndex = 0;
            this.util.Text = "Utilisateurs";
            this.util.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.Location = new System.Drawing.Point(34, 54);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(103, 41);
            this.menu.TabIndex = 1;
            this.menu.Text = "MENU :";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // mouv
            // 
            this.mouv.BackColor = System.Drawing.SystemColors.Highlight;
            this.mouv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mouv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mouv.Location = new System.Drawing.Point(25, 170);
            this.mouv.Name = "mouv";
            this.mouv.Size = new System.Drawing.Size(146, 34);
            this.mouv.TabIndex = 2;
            this.mouv.Text = "Mouvements";
            this.mouv.UseVisualStyleBackColor = false;
            // 
            // produit
            // 
            this.produit.BackColor = System.Drawing.SystemColors.Highlight;
            this.produit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produit.Location = new System.Drawing.Point(25, 233);
            this.produit.Name = "produit";
            this.produit.Size = new System.Drawing.Size(146, 34);
            this.produit.TabIndex = 3;
            this.produit.Text = "Produits";
            this.produit.UseVisualStyleBackColor = false;
            this.produit.Click += new System.EventHandler(this.produit_Click);
            // 
            // stats
            // 
            this.stats.BackColor = System.Drawing.SystemColors.Highlight;
            this.stats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stats.Location = new System.Drawing.Point(25, 293);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(146, 34);
            this.stats.TabIndex = 4;
            this.stats.Text = "Statistiques";
            this.stats.UseVisualStyleBackColor = false;
            this.stats.Click += new System.EventHandler(this.stats_Click);
            // 
            // deconex
            // 
            this.deconex.BackColor = System.Drawing.SystemColors.Highlight;
            this.deconex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deconex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deconex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deconex.Location = new System.Drawing.Point(25, 404);
            this.deconex.Name = "deconex";
            this.deconex.Size = new System.Drawing.Size(146, 34);
            this.deconex.TabIndex = 5;
            this.deconex.Text = "Deconnection";
            this.deconex.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.notif);
            this.panelHeader.Controls.Add(this.Titre);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 60);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Titre.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Titre.Location = new System.Drawing.Point(3, 12);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(148, 31);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Gestion APP";
            this.Titre.Click += new System.EventHandler(this.Titre_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.user.Location = new System.Drawing.Point(49, 20);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(52, 21);
            this.user.TabIndex = 7;
            this.user.Text = "User";
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // deconn
            // 
            this.deconn.BackColor = System.Drawing.SystemColors.Highlight;
            this.deconn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deconn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deconn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deconn.Location = new System.Drawing.Point(25, 351);
            this.deconn.Name = "deconn";
            this.deconn.Size = new System.Drawing.Size(146, 34);
            this.deconn.TabIndex = 8;
            this.deconn.Text = "Deconnection";
            this.deconn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::gestionAPP.Properties.Resources.accueillir;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(108, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 141);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::gestionAPP.Properties.Resources.accord;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(108, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 233);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::gestionAPP.Properties.Resources.utilisateur;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(11, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 30);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::gestionAPP.Properties.Resources.parametres_cog;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(763, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 30);
            this.panel1.TabIndex = 2;
            // 
            // notif
            // 
            this.notif.BackColor = System.Drawing.SystemColors.MenuBar;
            this.notif.BackgroundImage = global::gestionAPP.Properties.Resources.notification;
            this.notif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notif.Location = new System.Drawing.Point(719, 12);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(27, 30);
            this.notif.TabIndex = 1;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Button util;
        private System.Windows.Forms.Button mouv;
        private System.Windows.Forms.Button deconex;
        private System.Windows.Forms.Button stats;
        private System.Windows.Forms.Button produit;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Panel notif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button deconn;
    }
}
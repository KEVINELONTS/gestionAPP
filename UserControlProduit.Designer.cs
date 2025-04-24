namespace gestionAPP
{
    partial class UserControlProduit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ajt = new System.Windows.Forms.Button();
            this.supr = new System.Windows.Forms.Button();
            this.modif = new System.Windows.Forms.Button();
            this.act = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ajt
            // 
            this.ajt.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajt.Location = new System.Drawing.Point(37, 40);
            this.ajt.Name = "ajt";
            this.ajt.Size = new System.Drawing.Size(113, 49);
            this.ajt.TabIndex = 1;
            this.ajt.Text = "Ajouter";
            this.ajt.UseVisualStyleBackColor = true;
            // 
            // supr
            // 
            this.supr.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supr.Location = new System.Drawing.Point(237, 40);
            this.supr.Name = "supr";
            this.supr.Size = new System.Drawing.Size(113, 49);
            this.supr.TabIndex = 2;
            this.supr.Text = "Supprimer";
            this.supr.UseVisualStyleBackColor = true;
            // 
            // modif
            // 
            this.modif.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modif.Location = new System.Drawing.Point(453, 40);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(113, 49);
            this.modif.TabIndex = 3;
            this.modif.Text = "Update";
            this.modif.UseVisualStyleBackColor = true;
            // 
            // act
            // 
            this.act.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.act.Location = new System.Drawing.Point(654, 40);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(113, 49);
            this.act.TabIndex = 4;
            this.act.Text = "Actualiser";
            this.act.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 146);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1281, 410);
            this.dataGridView2.TabIndex = 6;
            // 
            // UserControlProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.act);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.supr);
            this.Controls.Add(this.ajt);
            this.Name = "UserControlProduit";
            this.Size = new System.Drawing.Size(1281, 556);
            this.Load += new System.EventHandler(this.UserControlProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ajt;
        private System.Windows.Forms.Button supr;
        private System.Windows.Forms.Button modif;
        private System.Windows.Forms.Button act;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

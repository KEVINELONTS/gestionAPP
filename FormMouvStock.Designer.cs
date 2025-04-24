namespace gestionAPP
{
    partial class FormMouvStock
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
            this.Type = new System.Windows.Forms.Label();
            this.Qte = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.observ = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mouv = new System.Windows.Forms.Label();
            this.enrg = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(107, 89);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(137, 16);
            this.Type.TabIndex = 0;
            this.Type.Text = "Type de mouvement :";
            // 
            // Qte
            // 
            this.Qte.AutoSize = true;
            this.Qte.Location = new System.Drawing.Point(107, 150);
            this.Qte.Name = "Qte";
            this.Qte.Size = new System.Drawing.Size(56, 16);
            this.Qte.TabIndex = 1;
            this.Qte.Text = "Quantite";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sortie",
            "Entree"});
            this.comboBox1.Location = new System.Drawing.Point(368, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(368, 148);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(239, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // observ
            // 
            this.observ.AutoSize = true;
            this.observ.Location = new System.Drawing.Point(107, 279);
            this.observ.Name = "observ";
            this.observ.Size = new System.Drawing.Size(86, 16);
            this.observ.TabIndex = 4;
            this.observ.Text = "Observation :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 273);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 22);
            this.textBox1.TabIndex = 5;
            // 
            // mouv
            // 
            this.mouv.AutoSize = true;
            this.mouv.Location = new System.Drawing.Point(296, 25);
            this.mouv.Name = "mouv";
            this.mouv.Size = new System.Drawing.Size(165, 16);
            this.mouv.TabIndex = 6;
            this.mouv.Text = "MOUVEMENT DE STOCK";
            // 
            // enrg
            // 
            this.enrg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.enrg.Location = new System.Drawing.Point(299, 353);
            this.enrg.Name = "enrg";
            this.enrg.Size = new System.Drawing.Size(117, 49);
            this.enrg.TabIndex = 7;
            this.enrg.Text = "Effectuer";
            this.enrg.UseVisualStyleBackColor = false;
            this.enrg.Click += new System.EventHandler(this.enrg_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(107, 209);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 16);
            this.date.TabIndex = 8;
            this.date.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(368, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // FormMouvStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.enrg);
            this.Controls.Add(this.mouv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.observ);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Qte);
            this.Controls.Add(this.Type);
            this.Name = "FormMouvStock";
            this.Text = "FormMouvStock";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Qte;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label observ;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label mouv;
        private System.Windows.Forms.Button enrg;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
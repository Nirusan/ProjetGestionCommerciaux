namespace GestionCommerciaux
{
    partial class frmAjoutNoteFrais
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
            this.grpBoxCommerciaux = new System.Windows.Forms.GroupBox();
            this.lstBoxCommerciaux = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpBoxNote = new System.Windows.Forms.GroupBox();
            this.rdbNuitee = new System.Windows.Forms.RadioButton();
            this.rdbRepas = new System.Windows.Forms.RadioButton();
            this.rdbTransport = new System.Windows.Forms.RadioButton();
            this.DateTPDate = new System.Windows.Forms.DateTimePicker();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grpBoxBonus = new System.Windows.Forms.GroupBox();
            this.txtBonus2 = new System.Windows.Forms.TextBox();
            this.txtBonus1 = new System.Windows.Forms.TextBox();
            this.grpBoxCommerciaux.SuspendLayout();
            this.grpBoxNote.SuspendLayout();
            this.grpBoxBonus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxCommerciaux
            // 
            this.grpBoxCommerciaux.Controls.Add(this.lstBoxCommerciaux);
            this.grpBoxCommerciaux.Location = new System.Drawing.Point(0, 0);
            this.grpBoxCommerciaux.Name = "grpBoxCommerciaux";
            this.grpBoxCommerciaux.Size = new System.Drawing.Size(286, 83);
            this.grpBoxCommerciaux.TabIndex = 0;
            this.grpBoxCommerciaux.TabStop = false;
            this.grpBoxCommerciaux.Text = "Commerciaux";
            // 
            // lstBoxCommerciaux
            // 
            this.lstBoxCommerciaux.FormattingEnabled = true;
            this.lstBoxCommerciaux.Location = new System.Drawing.Point(6, 27);
            this.lstBoxCommerciaux.Name = "lstBoxCommerciaux";
            this.lstBoxCommerciaux.Size = new System.Drawing.Size(274, 56);
            this.lstBoxCommerciaux.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(36, 100);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // grpBoxNote
            // 
            this.grpBoxNote.Controls.Add(this.rdbNuitee);
            this.grpBoxNote.Controls.Add(this.rdbRepas);
            this.grpBoxNote.Controls.Add(this.rdbTransport);
            this.grpBoxNote.Location = new System.Drawing.Point(6, 131);
            this.grpBoxNote.Name = "grpBoxNote";
            this.grpBoxNote.Size = new System.Drawing.Size(272, 47);
            this.grpBoxNote.TabIndex = 2;
            this.grpBoxNote.TabStop = false;
            this.grpBoxNote.Text = "Type de Note";
            // 
            // rdbNuitee
            // 
            this.rdbNuitee.AutoSize = true;
            this.rdbNuitee.Location = new System.Drawing.Point(181, 16);
            this.rdbNuitee.Name = "rdbNuitee";
            this.rdbNuitee.Size = new System.Drawing.Size(56, 17);
            this.rdbNuitee.TabIndex = 2;
            this.rdbNuitee.Text = "Nuitée";
            this.rdbNuitee.UseVisualStyleBackColor = true;
            this.rdbNuitee.CheckedChanged += new System.EventHandler(this.rdbNuitee_CheckedChanged);
            // 
            // rdbRepas
            // 
            this.rdbRepas.AutoSize = true;
            this.rdbRepas.Location = new System.Drawing.Point(85, 16);
            this.rdbRepas.Name = "rdbRepas";
            this.rdbRepas.Size = new System.Drawing.Size(56, 17);
            this.rdbRepas.TabIndex = 1;
            this.rdbRepas.Text = "Repas";
            this.rdbRepas.UseVisualStyleBackColor = true;
            this.rdbRepas.CheckedChanged += new System.EventHandler(this.rdbRepas_CheckedChanged);
            // 
            // rdbTransport
            // 
            this.rdbTransport.AutoSize = true;
            this.rdbTransport.Checked = true;
            this.rdbTransport.Location = new System.Drawing.Point(3, 16);
            this.rdbTransport.Name = "rdbTransport";
            this.rdbTransport.Size = new System.Drawing.Size(70, 17);
            this.rdbTransport.TabIndex = 0;
            this.rdbTransport.TabStop = true;
            this.rdbTransport.Text = "Transport";
            this.rdbTransport.UseVisualStyleBackColor = true;
            this.rdbTransport.CheckedChanged += new System.EventHandler(this.rdbTransport_CheckedChanged);
            // 
            // DateTPDate
            // 
            this.DateTPDate.Location = new System.Drawing.Point(72, 93);
            this.DateTPDate.Name = "DateTPDate";
            this.DateTPDate.Size = new System.Drawing.Size(200, 20);
            this.DateTPDate.TabIndex = 3;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(49, 226);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(155, 226);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // grpBoxBonus
            // 
            this.grpBoxBonus.Controls.Add(this.txtBonus2);
            this.grpBoxBonus.Controls.Add(this.txtBonus1);
            this.grpBoxBonus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpBoxBonus.Location = new System.Drawing.Point(6, 184);
            this.grpBoxBonus.Name = "grpBoxBonus";
            this.grpBoxBonus.Size = new System.Drawing.Size(280, 38);
            this.grpBoxBonus.TabIndex = 6;
            this.grpBoxBonus.TabStop = false;
            this.grpBoxBonus.Text = "Kilométrage";
            // 
            // txtBonus2
            // 
            this.txtBonus2.Location = new System.Drawing.Point(162, 12);
            this.txtBonus2.Name = "txtBonus2";
            this.txtBonus2.Size = new System.Drawing.Size(75, 20);
            this.txtBonus2.TabIndex = 1;
            this.txtBonus2.TextChanged += new System.EventHandler(this.txtBonus2_TextChanged);
            // 
            // txtBonus1
            // 
            this.txtBonus1.Location = new System.Drawing.Point(66, 12);
            this.txtBonus1.Name = "txtBonus1";
            this.txtBonus1.Size = new System.Drawing.Size(75, 20);
            this.txtBonus1.TabIndex = 0;
            // 
            // frmAjoutNoteFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 298);
            this.Controls.Add(this.grpBoxBonus);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.DateTPDate);
            this.Controls.Add(this.grpBoxNote);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grpBoxCommerciaux);
            this.Name = "frmAjoutNoteFrais";
            this.Text = "Ajouter des Notes de Frais";
            this.Load += new System.EventHandler(this.frmAjoutNoteFrais_Load);
            this.grpBoxCommerciaux.ResumeLayout(false);
            this.grpBoxNote.ResumeLayout(false);
            this.grpBoxNote.PerformLayout();
            this.grpBoxBonus.ResumeLayout(false);
            this.grpBoxBonus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCommerciaux;
        private System.Windows.Forms.ListBox lstBoxCommerciaux;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpBoxNote;
        private System.Windows.Forms.RadioButton rdbNuitee;
        private System.Windows.Forms.RadioButton rdbRepas;
        private System.Windows.Forms.RadioButton rdbTransport;
        private System.Windows.Forms.DateTimePicker DateTPDate;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox grpBoxBonus;
        private System.Windows.Forms.TextBox txtBonus2;
        private System.Windows.Forms.TextBox txtBonus1;
    }
}
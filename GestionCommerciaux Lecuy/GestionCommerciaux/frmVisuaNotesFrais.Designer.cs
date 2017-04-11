namespace GestionCommerciaux
{
    partial class frmVisuaNotesFrais
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
            this.grpCommerciaux = new System.Windows.Forms.GroupBox();
            this.lstCommerciaux = new System.Windows.Forms.ListBox();
            this.grpNotesFrais = new System.Windows.Forms.GroupBox();
            this.lstNotesFrais = new System.Windows.Forms.ListBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnSupprCom = new System.Windows.Forms.Button();
            this.grpCommerciaux.SuspendLayout();
            this.grpNotesFrais.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCommerciaux
            // 
            this.grpCommerciaux.Controls.Add(this.lstCommerciaux);
            this.grpCommerciaux.Location = new System.Drawing.Point(73, 23);
            this.grpCommerciaux.Name = "grpCommerciaux";
            this.grpCommerciaux.Size = new System.Drawing.Size(362, 62);
            this.grpCommerciaux.TabIndex = 0;
            this.grpCommerciaux.TabStop = false;
            this.grpCommerciaux.Text = "Commerciaux";
            // 
            // lstCommerciaux
            // 
            this.lstCommerciaux.FormattingEnabled = true;
            this.lstCommerciaux.Location = new System.Drawing.Point(6, 13);
            this.lstCommerciaux.Name = "lstCommerciaux";
            this.lstCommerciaux.Size = new System.Drawing.Size(349, 43);
            this.lstCommerciaux.TabIndex = 1;
            this.lstCommerciaux.SelectedIndexChanged += new System.EventHandler(this.lstCommerciaux_SelectedIndexChanged);
            // 
            // grpNotesFrais
            // 
            this.grpNotesFrais.Controls.Add(this.lstNotesFrais);
            this.grpNotesFrais.Location = new System.Drawing.Point(73, 104);
            this.grpNotesFrais.Name = "grpNotesFrais";
            this.grpNotesFrais.Size = new System.Drawing.Size(362, 254);
            this.grpNotesFrais.TabIndex = 1;
            this.grpNotesFrais.TabStop = false;
            this.grpNotesFrais.Text = "Notes de Frais";
            // 
            // lstNotesFrais
            // 
            this.lstNotesFrais.FormattingEnabled = true;
            this.lstNotesFrais.Location = new System.Drawing.Point(6, 26);
            this.lstNotesFrais.Name = "lstNotesFrais";
            this.lstNotesFrais.Size = new System.Drawing.Size(349, 225);
            this.lstNotesFrais.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(296, 364);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(84, 42);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(79, 364);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(89, 42);
            this.btnSuppr.TabIndex = 3;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnSupprCom
            // 
            this.btnSupprCom.Location = new System.Drawing.Point(482, 36);
            this.btnSupprCom.Name = "btnSupprCom";
            this.btnSupprCom.Size = new System.Drawing.Size(89, 42);
            this.btnSupprCom.TabIndex = 4;
            this.btnSupprCom.Text = "Supprimer Commercial";
            this.btnSupprCom.UseVisualStyleBackColor = true;
            this.btnSupprCom.Click += new System.EventHandler(this.btnSupprCom_Click);
            // 
            // frmVisuaNotesFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 557);
            this.Controls.Add(this.btnSupprCom);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpNotesFrais);
            this.Controls.Add(this.grpCommerciaux);
            this.Name = "frmVisuaNotesFrais";
            this.Text = "Notes de Frais";
            this.Load += new System.EventHandler(this.frmVisuaNotesFrais_Load);
            this.grpCommerciaux.ResumeLayout(false);
            this.grpNotesFrais.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCommerciaux;
        private System.Windows.Forms.GroupBox grpNotesFrais;
        private System.Windows.Forms.ListBox lstNotesFrais;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ListBox lstCommerciaux;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnSupprCom;
    }
}
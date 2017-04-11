namespace GestionCommerciaux
{
    partial class frmAjoutCommercial
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblPuissanceVoiture = new System.Windows.Forms.Label();
            this.grboxCategorie = new System.Windows.Forms.GroupBox();
            this.RdbtnCatB = new System.Windows.Forms.RadioButton();
            this.RdbtnCatC = new System.Windows.Forms.RadioButton();
            this.rdBtnCatA = new System.Windows.Forms.RadioButton();
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.txtbPrenom = new System.Windows.Forms.TextBox();
            this.LstPuissance = new System.Windows.Forms.ListBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.grboxCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(22, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(22, 33);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblPuissanceVoiture
            // 
            this.lblPuissanceVoiture.AutoSize = true;
            this.lblPuissanceVoiture.Location = new System.Drawing.Point(22, 59);
            this.lblPuissanceVoiture.Name = "lblPuissanceVoiture";
            this.lblPuissanceVoiture.Size = new System.Drawing.Size(92, 13);
            this.lblPuissanceVoiture.TabIndex = 2;
            this.lblPuissanceVoiture.Text = "Puissance Voiture";
            // 
            // grboxCategorie
            // 
            this.grboxCategorie.Controls.Add(this.RdbtnCatB);
            this.grboxCategorie.Controls.Add(this.RdbtnCatC);
            this.grboxCategorie.Controls.Add(this.rdBtnCatA);
            this.grboxCategorie.Location = new System.Drawing.Point(25, 93);
            this.grboxCategorie.Name = "grboxCategorie";
            this.grboxCategorie.Size = new System.Drawing.Size(89, 101);
            this.grboxCategorie.TabIndex = 3;
            this.grboxCategorie.TabStop = false;
            this.grboxCategorie.Text = "Categorie";
            // 
            // RdbtnCatB
            // 
            this.RdbtnCatB.AutoSize = true;
            this.RdbtnCatB.Location = new System.Drawing.Point(6, 42);
            this.RdbtnCatB.Name = "RdbtnCatB";
            this.RdbtnCatB.Size = new System.Drawing.Size(32, 17);
            this.RdbtnCatB.TabIndex = 7;
            this.RdbtnCatB.TabStop = true;
            this.RdbtnCatB.Text = "B";
            this.RdbtnCatB.UseVisualStyleBackColor = true;
            // 
            // RdbtnCatC
            // 
            this.RdbtnCatC.AutoSize = true;
            this.RdbtnCatC.Location = new System.Drawing.Point(6, 65);
            this.RdbtnCatC.Name = "RdbtnCatC";
            this.RdbtnCatC.Size = new System.Drawing.Size(32, 17);
            this.RdbtnCatC.TabIndex = 6;
            this.RdbtnCatC.TabStop = true;
            this.RdbtnCatC.Text = "C";
            this.RdbtnCatC.UseVisualStyleBackColor = true;
            // 
            // rdBtnCatA
            // 
            this.rdBtnCatA.AutoSize = true;
            this.rdBtnCatA.Location = new System.Drawing.Point(6, 19);
            this.rdBtnCatA.Name = "rdBtnCatA";
            this.rdBtnCatA.Size = new System.Drawing.Size(32, 17);
            this.rdBtnCatA.TabIndex = 8;
            this.rdBtnCatA.TabStop = true;
            this.rdBtnCatA.Text = "A";
            this.rdBtnCatA.UseVisualStyleBackColor = true;
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(63, 9);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(100, 20);
            this.txtbNom.TabIndex = 0;
            // 
            // txtbPrenom
            // 
            this.txtbPrenom.Location = new System.Drawing.Point(63, 33);
            this.txtbPrenom.Name = "txtbPrenom";
            this.txtbPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtbPrenom.TabIndex = 4;
            // 
            // LstPuissance
            // 
            this.LstPuissance.FormattingEnabled = true;
            this.LstPuissance.Location = new System.Drawing.Point(138, 59);
            this.LstPuissance.Name = "LstPuissance";
            this.LstPuissance.Size = new System.Drawing.Size(98, 108);
            this.LstPuissance.TabIndex = 5;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(161, 226);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(63, 226);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAjoutCommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 260);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.LstPuissance);
            this.Controls.Add(this.txtbPrenom);
            this.Controls.Add(this.txtbNom);
            this.Controls.Add(this.grboxCategorie);
            this.Controls.Add(this.lblPuissanceVoiture);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "frmAjoutCommercial";
            this.Text = "Ajout Commercial";
            this.Load += new System.EventHandler(this.AjouterCommercial_Load);
            this.grboxCategorie.ResumeLayout(false);
            this.grboxCategorie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblPuissanceVoiture;
        private System.Windows.Forms.GroupBox grboxCategorie;
        private System.Windows.Forms.TextBox txtbNom;
        private System.Windows.Forms.TextBox txtbPrenom;
        private System.Windows.Forms.ListBox LstPuissance;
        private System.Windows.Forms.RadioButton RdbtnCatB;
        private System.Windows.Forms.RadioButton RdbtnCatC;
        private System.Windows.Forms.RadioButton rdBtnCatA;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValider;
    }
}
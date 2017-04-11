using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommerciaux
{
    public partial class Form1 : Form
    {
        private ServiceCommercial leService = new ServiceCommercial();
        private string nomFichier;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leService = new ServiceCommercial();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            nomFichier = o.FileName;
            leService = (ServiceCommercial)Serial.charger(nomFichier);
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serial.sauvegarder("Sauvegarde", leService);
        }

        private void nouveauCommercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutCommercial f = new frmAjoutCommercial(leService);
            f.MdiParent = this;
            f.Show();
        }

        private void ajouterNoteDeFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutNoteFrais f = new frmAjoutNoteFrais(leService);
            f.MdiParent = this;
            f.Show();
        }

        private void visualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisuaNotesFrais f = new frmVisuaNotesFrais(leService);
            f.MdiParent= this;
            f.Show();
        }



    }
}

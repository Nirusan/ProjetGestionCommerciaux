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
    partial class frmVisuaNotesFrais : Form
    {
        ServiceCommercial leService;

        public frmVisuaNotesFrais(ServiceCommercial sc)
        {
            this.leService = sc;
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmVisuaNotesFrais_Load(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < leService.getNbrListe(); i++)
            {
                lstCommerciaux.Items.Add(leService.getServiceCommerciaux(i));
            }
        }


        private void lstCommerciaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstNotesFrais.Items.Clear();
            Commercial leCommercial = (Commercial)lstCommerciaux.SelectedItem;
            int i = 0;
            for (i = 0; i < leCommercial.getMesNotes(); i++)
            {
                lstNotesFrais.Items.Add(leCommercial.getNotesFrais(i));
            }
        }

        

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            NoteFrais nf = (NoteFrais)lstNotesFrais.SelectedItem;
            Commercial c = (Commercial)lstCommerciaux.SelectedItem;
            if (lstCommerciaux.SelectedItem == null)
            {
                MessageBox.Show("La liste doit contenir un commercial et il doit etre sélectionné");
            }
            else
            {
                c.MesNotes.Remove(nf);
                lstNotesFrais.Items.Clear();
                Commercial leCommercial = (Commercial)lstCommerciaux.SelectedItem;
                int i = 0;
                for (i = 0; i < leCommercial.getMesNotes(); i++)
                {
                    lstNotesFrais.Items.Add(leCommercial.getNotesFrais(i));
                }
            }
            
            

            /*Commercial c = (Commercial)lstCommerciaux.SelectedItem;
            int indice = lstNotesFrais.SelectedIndex;
            c.suppr(indice);
            lstNotesFrais.Refresh();*/
            /*lstNotesFrais.Items.Remove(lstNotesFrais.SelectedItem);
            lstNotesFrais.SelectedItem.*/

            
        }

        private void btnSupprCom_Click(object sender, EventArgs e)
        {

            leService.suppr((Commercial)lstCommerciaux.SelectedItem);
            lstCommerciaux.Items.Clear();
            Commercial leCommercial = (Commercial)lstCommerciaux.SelectedItem;
            int i = 0;
            for (i = 0; i < leService.getNbrListe(); i++)
            {
                lstCommerciaux.Items.Add(leService.getServiceCommerciaux(i));
            }
            lstNotesFrais.Items.Clear();
        }     
    }
}

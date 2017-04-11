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
    partial class frmAjoutNoteFrais : Form
    {
        ServiceCommercial leService;
        public frmAjoutNoteFrais(ServiceCommercial sc)
        {
            this.leService = sc;
            InitializeComponent();
        }


        private void rdbTransport_CheckedChanged(object sender, EventArgs e)
        {
                grpBoxBonus.Text = "Kilométrage";
                txtBonus2.Visible = false;
                txtBonus1.Visible = true;
        }

        private void frmAjoutNoteFrais_Load(object sender, EventArgs e)
        {
            txtBonus2.Visible = false;
            int i = 0;
            for (i = 0; i <leService.getNbrListe(); i++)
            {
                lstBoxCommerciaux.Items.Add(leService.getServiceCommerciaux(i));
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbRepas_CheckedChanged(object sender, EventArgs e)
        {       
                grpBoxBonus.Text = "Frais de Repas";
                txtBonus2.Visible = false;
                txtBonus1.Visible = true;   
        }

        private void rdbNuitee_CheckedChanged(object sender, EventArgs e)
        {
                grpBoxBonus.Text = "Montant a rembourser";
                txtBonus2.Visible = true;
                txtBonus1.Visible = true;    
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (lstBoxCommerciaux.Text != "" && txtBonus1.Text != "")
            {
                Commercial leCommercial = (Commercial)lstBoxCommerciaux.SelectedItem;
                if (rdbTransport.Checked == true)
                {
                    leCommercial.ajouterNote(Convert.ToInt16(txtBonus1.Text), DateTPDate.Value);
                    MessageBox.Show("Note de frais ajouté !");
                }
                else
                    if(rdbRepas.Checked == true)
                    {
                        leCommercial.ajouterNote(DateTPDate.Value, Convert.ToInt16(txtBonus1.Text));
                        MessageBox.Show("Note de frais ajouté !");
                    }
                    else
                        if (rdbNuitee.Checked == true && txtBonus2.GetType() == typeof(char))
                        {
                            leCommercial.ajouterNote(DateTPDate.Value, Convert.ToInt16(txtBonus1.Text), Convert.ToChar(txtBonus2.Text));
                            MessageBox.Show("Note de frais ajouté !");
                            
                        }
                        else
                        {
                            MessageBox.Show("La deuxième boite de texte n'accepte qu'un caractère, vérifiez aussi qu'elle soit bien remplie");
                        }
                
                }
            else
            {
                MessageBox.Show("Il faut au préalable renseigner un commercial et remplir les champs");
            }
            /*}
            Commercial leCommercial = (Commercial)lstBoxCommerciaux.SelectedItem;
            if (rdbTransport.Checked == true)
            {
                leCommercial.ajouterNote(Convert.ToInt16(txtBonus1.Text), DateTPDate.Value);
            }
            else
                if(rdbRepas.Checked == true)
                {
                    leCommercial.ajouterNote(DateTPDate.Value, Convert.ToInt16(txtBonus1.Text));
                }
                else
                    if (rdbNuitee.Checked == true)
                    {
                        leCommercial.ajouterNote(DateTPDate.Value, Convert.ToInt16(txtBonus1.Text), Convert.ToChar(txtBonus2.Text));
                    }
            MessageBox.Show("Note de frais ajouté !");*/
        }

        private void txtBonus2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

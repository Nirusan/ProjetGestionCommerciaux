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
    partial class frmAjoutCommercial : Form
    {
        ServiceCommercial leService;
         
        public frmAjoutCommercial(ServiceCommercial sc)
        {
            this.leService = sc;
            InitializeComponent(); 
        }
       

        private void AjouterCommercial_Load(object sender, EventArgs e)
        {
            int i=5;
            for (i=1;i <20;i++ )
            {
                LstPuissance.Items.Add(i);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            

                if (txtbNom.Text == "" || txtbPrenom.Text == "" || LstPuissance.Text == "")
                {
                    MessageBox.Show("Remplissez les champs !");
                }
                else
                {
                    if (rdBtnCatA.Checked || RdbtnCatB.Checked|| RdbtnCatC.Checked)
                    {
                        string lePrenom = txtbPrenom.Text, leNom = txtbNom.Text;
                        char laCat = 'A';
                        int laPuissanceVoiture = Convert.ToInt16(LstPuissance.SelectedItem);
                        if (rdBtnCatA.Checked)
                            laCat = 'A';
                        else
                            if (RdbtnCatB.Checked )
                                laCat = 'B';
                            else
                                if (RdbtnCatC.Checked )
                                    laCat = 'C';
                        Commercial c = new Commercial(laPuissanceVoiture, laCat, leNom, lePrenom);
                        leService.ajouterCommercial(c);

                        txtbNom.Text = "";
                        txtbPrenom.Text = "";
                        MessageBox.Show("Commercial ajouté !");
                    }
                    else
                    {
                        MessageBox.Show("Remplissez les champs !");
                    }
                }
                
            
           

            /*if (txtbNom.Text != null && txtbPrenom.Text != null && LstPuissance.Text != null && (rdBtnCatA.Checked == true || RdbtnCatB.Checked == true || RdbtnCatC.Checked == true))
            {
                string lePrenom = txtbPrenom.Text, leNom = txtbNom.Text;
                char laCat = 'A';
                int laPuissanceVoiture = Convert.ToInt16(LstPuissance.SelectedItem);
                if (rdBtnCatA.Checked == true)
                    laCat = 'A';
                else
                    if (RdbtnCatB.Checked == true)
                        laCat = 'B';
                    else
                        if (RdbtnCatC.Checked == true)
                            laCat = 'C';
                Commercial c = new Commercial(laPuissanceVoiture,laCat,leNom,lePrenom);
                leService.ajouterCommercial(c);

                txtbNom.Text = "";
                txtbPrenom.Text = "";
                MessageBox.Show("Commercial ajouté !");
            }
            else
            {
                MessageBox.Show("Remplissez les champs !");
            }*/
            
                
            

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommerciaux
{
    [Serializable]
    public class Commercial
    {
        protected int puissanceVoiture;
        protected char categorie;
        protected string nom, prenom;
        private List<NoteFrais> mesNotes;

        public List<NoteFrais> MesNotes
        {
            get { return mesNotes; }
        }

        //accesseur

        public int PuissanceVoiture
        {
            get { return this.puissanceVoiture; }
            set { this.puissanceVoiture = value; }
        }
        public char CategorieCo
        {
            get { return this.categorie;}
            set { categorie = value; }
        }
        public string NomCo
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public int getMesNotes()
        {
            return mesNotes.Count;
        }
        public string PrenomCo
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public virtual NoteFrais getNotesFrais(int nbr)
        {
            return mesNotes[nbr];
        }

        public void suppr(int x)
        {
            mesNotes.RemoveAt(x);
        }



        public int num = 0;



        //Constructeur

        public Commercial(int puissanceVo, char catégorie,string nom,string prenom)
        {
            this.puissanceVoiture = puissanceVo;
            this.categorie = catégorie;
            this.nom = nom;
            this.prenom = prenom;
            this.mesNotes =new List<NoteFrais>();
        }
        
       //Methodes
        public override string ToString()
        {
            string str;
            return str =("Nom : " + this.nom + " - Prénom : " + this.prenom + " - Puissance voiture : " + this.puissanceVoiture + " - Catégorie : " + this.categorie);
            /*return mesNotes.ToString();*/
        }

        public void ajouterNote( int km,DateTime d)  //Transport
        {
            FraisTransport ft = new FraisTransport(num,d,this,100);
            mesNotes.Add(ft);
            num += 1;

        }

        public void ajouterNote(DateTime d, double prix)  //repas
        {
            RepasMidi rpm = new RepasMidi(num, d, this, prix);
            mesNotes.Add(rpm);
            num += 1;
        }
        
        public void ajouterNote(DateTime d, int prix, char region)  //midi
        {
            Nuitee nu = new Nuitee(num, d, this, prix, region);
            mesNotes.Add(nu);
            num += 1;
        }

        
    }
}       

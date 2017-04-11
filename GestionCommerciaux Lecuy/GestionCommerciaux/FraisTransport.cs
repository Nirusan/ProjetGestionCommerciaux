using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommerciaux
{
    [Serializable]
    class FraisTransport : NoteFrais
    {
        protected int kilometrage;


        //accesseur
        public int Kilometrage
        {
            set { this.kilometrage = value; }
            get { return this.kilometrage; }
        }
        //Constructeur
        public FraisTransport(int num, DateTime date, Commercial com, int kil)
        {
            this.numero = num;
            this.date = date;
            this.leCommercial = com;
            this.kilometrage = kil;
        }
        //methode

        public override double calculMontantARembourser()
        {
            double montant,multpti;

            if (this.leCommercial.PuissanceVoiture < 6)
                multpti = 0.7;
            if (this.leCommercial.PuissanceVoiture >5 && this.leCommercial.PuissanceVoiture< 11)
                multpti = 0.8;
            else 
                multpti = 0.9;

            return montant = this.kilometrage*multpti;
        }
        public override string ToString()
        {
            return "T - " + base.ToString() + " - " + this.kilometrage + "km";
        }
    }
}

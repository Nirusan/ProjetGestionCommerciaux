using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommerciaux
{
    [Serializable]
    public class NoteFrais
    {
        protected int numero;
        protected DateTime date;
        protected Commercial leCommercial;
        protected double montantARembourser = 0;
        protected bool estRembourse;
        

        //Accesseur

        public int Numero
        {
            set { this.numero = value; }
            get {return this.numero;}
        }
        public DateTime Date
        {
            set { this.date = value; }
            get { return this.date; }
        }
        public Commercial LeCommercial
        {
            set { this.leCommercial = value; }
            get { return leCommercial; }
        }
        public void setMontantARembourser()
        {
            this.montantARembourser = calculMontantARembourser();
        } 
        public void setRembourse()
        {
            this.estRembourse = true;
        }
        //Constructeur
        public NoteFrais(int num,DateTime ladate,Commercial unCommercial)
        {
            this.numero = num;
            this.date = ladate;
            this.leCommercial = unCommercial;
        }

        public NoteFrais()
        {

        }
        //Methode
        public override string ToString()
        {
            string remboursement;
            if (estRembourse == true)
                remboursement = "R";
            else
                remboursement = "NR";
            string str=(this.numero + " - "+this.date.ToShortDateString()+" - "+ calculMontantARembourser()+"E - "+remboursement);
            return str;
        }
        public virtual double calculMontantARembourser()
        {
            double no=0;
            return no;
        }
       


        
    }
}

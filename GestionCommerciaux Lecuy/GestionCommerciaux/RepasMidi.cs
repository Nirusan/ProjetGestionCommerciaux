using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommerciaux
{
    [Serializable]
    class RepasMidi : NoteFrais
    {


        public override string ToString()
        {
            string str = "R - " + base.ToString() + " - Payé: " + this.montantARembourser;
            return str;
        }
        public override double calculMontantARembourser()
        {
           double maxRembourse;
           if (this.leCommercial.CategorieCo =='A')
               maxRembourse = 25;
           if (this.leCommercial.CategorieCo == 'B')
               maxRembourse = 22;
           else
               maxRembourse = 20;

           return maxRembourse;

        }
        public RepasMidi(int num,DateTime date,Commercial c,double paye)
        {
            this.numero = num;
            this.date = date;
            this.leCommercial = c;
            this.montantARembourser = paye;
        }
    }
}

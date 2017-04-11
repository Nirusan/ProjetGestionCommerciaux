using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommerciaux
{
    [Serializable]
    class Nuitee : NoteFrais
    {
        char region;
        public Nuitee(int num, DateTime date,Commercial c,int aRembourser, char region)
        {
            this.numero = num;
            this.date = date;
            this.leCommercial = c;
            this.montantARembourser = aRembourser;
            this.region = region;
        }

        public override string ToString()
        {
            return "N - "+base.ToString()+" - Payé : "+montantARembourser+" - Région : "+this.region;
        }
        public override double calculMontantARembourser()
        {
            double maxRembourse,multi,total,remboursé;
            if (this.leCommercial.CategorieCo == 'A')
                maxRembourse = 65;
            if (this.leCommercial.CategorieCo == 'B')
                maxRembourse = 55;
            else
                maxRembourse = 50;
            total = maxRembourse;
            if (this.region == '1')
                multi = 0.9;
            if (this.region == '2')
                multi = 1;
            else
                multi = 1.15;
            
            maxRembourse *= multi;
            
            if (total > maxRembourse)
                remboursé = 0;
            else
                remboursé = maxRembourse;
            return remboursé;


                    
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommerciaux
{
    [Serializable]
    public class ServiceCommercial
    {
        public List<Commercial> lesCommerciaux;

        public ServiceCommercial()
        {
            lesCommerciaux = new List<Commercial>();
        }

        public void ajouterCommercial(Commercial c)
        {
            lesCommerciaux.Add(c);
        } 
        public void ajouterNote(string prenom,string nom,DateTime d, int km)
        {
            foreach(Commercial c in lesCommerciaux)
                if (c.PrenomCo == nom && c.NomCo == prenom)
                {
                    c.ajouterNote(km,d);
                }
        }
         //ft
        public void ajouterNote(string p,string n, DateTime d, double prix)
        {
         foreach(Commercial c in lesCommerciaux)
            {
                if (c.PrenomCo == n && c.NomCo == p)
                {
                    c.ajouterNote(d,prix);
                }
            }
        } //fr
        public void ajouterNote(string p, string n, DateTime d, int prix, char region)
        {
         foreach(Commercial c in lesCommerciaux)
            if (c.PrenomCo == n && c.NomCo == p)
                {
                    c.ajouterNote(d,prix);
                }
        }
        
        public Commercial getServiceCommerciaux(int x)
        {
            return lesCommerciaux[x];
        }
        public int getNbrListe()
        {
            return lesCommerciaux.Count;
        }

        public void suppr(Commercial c)
        {
            lesCommerciaux.Remove(c);
        }
        

    }
}

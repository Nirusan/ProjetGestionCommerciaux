using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestionCommerciaux
{
    [Serializable]
    class Serial
    {
        public static void sauvegarder(string nomFichier, Object o)
        {
            FileStream f = new FileStream(nomFichier,FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, o);
            f.Close();
        }

        public static Object charger(string nomFichier)
        {
            Object o;
            FileStream f = new FileStream(nomFichier, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            o = bf.Deserialize(f);
            f.Close();
            return o;
        }
    }
}

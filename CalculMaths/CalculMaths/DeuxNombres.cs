using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculMaths
{
    class DeuxNombres
    {
        //Attributs
        private int nb1;
        private int nb2;

        //Constructeur
        public DeuxNombres(int nb1, int nb2)
        {
            this.nb1 = nb1;
            this.nb2 = nb2;
        }

        // Méthodes
        public int Somme()
        {
            return nb1+nb2;
        }
        public int Produit()
        {
            return nb1 * nb2;
        }
        public int PGCD()
        {
            int nombre1 = nb1;
            int nombre2 = nb2;
            int reste = nb1 % nb2;
            while (reste != 0)
            {
                nb1 = nb2;
                nb2 = reste;
                reste = nb1 % nb2;
            }
            nb1 = nombre1;
            nb2 = nombre2;
            return nb2;
        }
        public int PPCM() // non encore implémentée
        {
            int ppcm = nb1;
            while (ppcm % nb2 != 0)
            {
                ppcm = ppcm + nb1;
            }
            return ppcm;
        }
    }
}

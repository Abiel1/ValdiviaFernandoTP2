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
            int reste = nombre1 % nombre2;
            while (reste != 0)
            {
                nombre1 = nombre2;
                nombre2 = reste;
                reste = nombre1 % nombre2;
            }
            return nombre2;
        }

        public int PPCM() 
        {
            return Produit() / PGCD();
        }

        public int MaxDeuxNombres(int nb1, int nb2)
        {
            if (nb1 > nb2)
                return nb1;

            return nb2;
        }

        public int MinDeuxNombres(int nb1, int nb2)
        {
            if (nb1 < nb2)
                return nb1;

            return nb2;
        }
    }
}

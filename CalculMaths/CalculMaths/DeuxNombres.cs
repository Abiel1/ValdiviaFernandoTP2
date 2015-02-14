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
            int reste = nb1 % nb2;
            while (reste !=0)
            {
               nb1=nb2;
               nb2=reste;
               reste=nb1 % nb2;
            }
            return nb2;
        }
        public int PPCM() // non encore implémentée
        {
            return 1;
        }
    }
}

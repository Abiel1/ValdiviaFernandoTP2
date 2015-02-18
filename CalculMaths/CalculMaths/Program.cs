using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            DeuxNombres mesDeuxNombres = new DeuxNombres(45, 75);
            Console.WriteLine("La somme est : " + mesDeuxNombres.Somme());
            Console.WriteLine("Le produit est : " + mesDeuxNombres.Produit());
            Console.WriteLine("Le PGCD est : " + mesDeuxNombres.PGCD());
            Console.WriteLine("Le PPCM est : " + mesDeuxNombres.PPCM());
            Console.WriteLine("Le nombre plus petit est : " + mesDeuxNombres.MinDeuxNombres(16, 21));
            Console.WriteLine("Appuyez sur une touche pour continuer ...");
            Console.ReadKey();
        }
    }
}

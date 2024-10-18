using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbres
{
    class Program
    {
        static ArbreBinaire ArbreBinaireTest()
        {
            ArbreBinaire ab = new ArbreBinaire();
            ab.AssocierRacine(1); //créer la racine de l'AB
                                  //sous arbre droite     
            Noeud n1 = new Noeud(2);
            n1.AssocierNoeudFilsDroite(new Noeud(4));
            n1.AssocierNoeudFilsGauche(new Noeud(5));

            //sous arbre gauche
            Noeud n2 = new Noeud(3);
            n2.AssocierNoeudFilsGauche(new Noeud(6));
            n2.AssocierNoeudFilsDroite(new Noeud(7));

            //assemblage final avec la racine
            ab.AssocierFilsDroite(ab.Racine, n2);
            ab.AssocierFilsGauche(ab.Racine, n1);

            return ab;
        }
        static void Exercice1()
        {
            //Etape 1 : mise en place de l'arbre binaire 
            ArbreBinaire x = ArbreBinaireTest();
            /*
           //Etape 2 :Parcours et affichage de l'arbre
            Console.WriteLine("Affichage Prefixe");
            x.AffichagePrefixe(x.Racine);
            Console.WriteLine("Affichage Postfixe");
            x.AffichagePostfixe(x.Racine);
            Console.WriteLine("Affichage Infixe");
            x.AffichageInfixe(x.Racine);

            //Etape 3 : affichage arborescence
            x.AffichageArborescence(x.Racine, 0);
            Console.WriteLine("\n");

            //Etape 4 : comptage des noeuds

            Console.WriteLine("Le nombre d'éléments dans l'arbre " + x.TailleArbre(x.Racine));
            Console.WriteLine("le nombre de feuilles de l'arbre " + x.NombreFeuilles(x.Racine));
            Console.WriteLine("La hauteur de l'arbre est " + x.Hauteur(x.Racine));
            */
         
        }

   
        static void Main(string[] args)
        {
            Exercice1(); 
           
            Console.ReadKey();
        }
    }
}

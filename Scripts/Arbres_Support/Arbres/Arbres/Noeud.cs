using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbres
{
    class Noeud
    {

        int valeur;
        Noeud filsDroit;
        Noeud filsGauche;

        public Noeud()
        {
            this.valeur = 0;
            this.filsDroit = null;
            this.filsGauche = null;
        }
        public Noeud(int v )
        {
            this.valeur = v;
            this.filsDroit = null;
            this.filsGauche = null;
        }

        public Noeud(int v, Noeud x, Noeud y)
        {
            this.valeur = v;
            this.filsDroit = x;
            this.filsGauche = y;
        }

        public int Valeur
        {
            get { return this.valeur; }
            set { this.valeur = value; }
        }

        public Noeud FilsDroit
        {
            get { return this.filsDroit; }
            set { this.filsDroit = value; }
        }
        public Noeud FilsGauche
        {
            get { return this.filsGauche; }
            set { this.filsGauche = value; }
        }

      

        public bool AssocierNoeudFilsGauche(Noeud enfant)
        {
            bool ok = false;
            if (this != null)
            {
                //  Noeud enfant = new Noeud(v);

                //si pas déjà de fils gauche et si paramètre non null
                if (this.FilsGauche == null && enfant != null)
                {
                    this.FilsGauche = enfant;
                    ok = true;
                }
            }
            return ok;
        }

        public bool AssocierNoeudFilsDroite(Noeud enfant)
        {
            bool ok = false;
            if (this != null)
            {
                //si pas déjà de fils droite et si paramètre non null
                if (this.FilsDroit == null && enfant != null)
                {
                    this.FilsDroit = enfant;
                    ok = true;
                }
            }
            return ok;
        }



        //vérifier si un noeud est une feuille
        public bool EstFeuille()
        {
            return this.FilsGauche == null && this.FilsDroit == null;
        }


        //méthode qui retourne le nombre d'enfants du noeud courant >>> au max un noeud a deux enfants
        public int NombreEnfants()
        {   
            int count = 0;
            if (this.FilsGauche != null)
            {
                count++;
            }
            if (this.FilsDroit != null)
            {
                count++;
            }
            return count;
        }

        public void AffichagePrefixe(Noeud n)
        {
            if (n != null)
            {
                Console.WriteLine(n.Valeur); // Afficher la valeur du nœud courant
                AffichagePrefixe(n.FilsGauche); // Afficher la partie gauche de l'arbre
                AffichagePrefixe(n.FilsDroit); // Afficher la partie droite de l'arbre
            }
        }

        public void AffichageInfixe(Noeud n)
        {
            if (n != null)
            {
                AffichageInfixe(n.FilsGauche); // Afficher la partie gauche de l'arbre
                Console.WriteLine(n.Valeur); // Afficher la valeur du nœud courant
                AffichageInfixe(n.FilsDroit); // Afficher la partie droite de l'arbre
            }
        }

        public void AffichagePostfixe(Noeud n)
        {
            if (n != null)
            {
                AffichagePostfixe(n.FilsGauche); // Afficher la partie gauche de l'arbre
                AffichagePostfixe(n.FilsDroit); // Afficher la partie droite de l'arbre
                Console.WriteLine(n.Valeur); // Afficher la valeur du nœud courant
            }
        }
    }
}

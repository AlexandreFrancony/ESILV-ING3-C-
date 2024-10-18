using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbres
{
    class ArbreBinaire
    {
        Noeud racine;

        public ArbreBinaire()
        {
            this.racine = new Noeud();
        }

        public ArbreBinaire(Noeud n)
        {
            this.racine = n;
        }
        public Noeud Racine
        {
            set { this.racine = value; }
            get { return this.racine; }
        }

        #region associer les noeuds
        public bool AssocierRacine(int valeur)
        {
            bool ok = false;
              //si arbre vide et si paramètre non null
                if (this.EstArbreVide() )
                {
                    Noeud n = new Noeud(valeur);
                    this.racine = n;
                    ok = true;
                }
            
            return ok;
        }
        public bool AssocierFilsGauche(Noeud parent, Noeud enfant)
        {
            bool ok = false;
            if (parent != null)
            {
                 
                //si pas déjà de fils gauche et si paramètre non null
                if(parent.FilsGauche == null && enfant != null)
                {
                    parent.FilsGauche = enfant;
                    ok = true;
                }
            }
            return ok;
        }

        public bool AssocierFilsDroite(Noeud parent, Noeud enfant)
        {
            bool ok = false;
            if (parent != null)
            {
                
                //si pas déjà de fils droite et si paramètre non null
                if (parent.FilsDroit == null && enfant != null)
                {
                    parent.FilsDroit = enfant;
                    ok = true;
                }
            }
           
            return ok;
        }

        public bool EstArbreVide()
        {
            return this.racine == null;
        }

#endregion
     
        #region parcours en profondeur  A FAIRE
        // Exo 2 - Les parcours en profondeur + affichage
         
#endregion
      
        //  Afficher en arborescence un arbre binaire
 
    }
}
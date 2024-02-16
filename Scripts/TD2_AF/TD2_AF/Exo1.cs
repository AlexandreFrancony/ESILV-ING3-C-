using System;
using System.Collections.Generic;

public class ListeChainee<T>
{
    private class Noeud
    {
        public T Element { get; set; }
        public Noeud Suivant { get; set; }
    }

    private Noeud tete;

    public void AddHead(T element)
    {
        Noeud nouveauNoeud = new Noeud { Element = element, Suivant = tete };
        tete = nouveauNoeud;
    }

    public void AddQueue(T element)
    {
        Noeud nouveauNoeud = new Noeud { Element = element, Suivant = null };
        if (tete == null)
        {
            tete = nouveauNoeud;
        }
        else
        {
            Noeud courant = tete;
            while (courant.Suivant != null)
            {
                courant = courant.Suivant;
            }
            courant.Suivant = nouveauNoeud;
        }
    }

    public void Insert(T element, int position)
    {
        if (position < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(position));
        }

        if (position == 0)
        {
            AddHead(element);
        }
        else
        {
            Noeud courant = tete;
            for (int i = 0; i < position - 1; i++)
            {
                if (courant == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(position));
                }
                courant = courant.Suivant;
            }

            Noeud nouveauNoeud = new Noeud { Element = element, Suivant = courant.Suivant };
            courant.Suivant = nouveauNoeud;
        }
    }

    public void Affiche()
    {
        Noeud courant = tete;
        while (courant != null)
        {
            Console.Write(courant.Element + " ");
            courant = courant.Suivant;
        }
        Console.WriteLine();
    }
}

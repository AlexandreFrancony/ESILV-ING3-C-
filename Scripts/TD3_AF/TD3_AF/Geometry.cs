using System;

public abstract class Figure
{
    public abstract double Aire();
    public abstract double Perimetre();
}

public class Rectangle : Figure
{
    private double longueur;
    private double largeur;

    public Rectangle(double longueur, double largeur)
    {
        this.longueur = longueur;
        this.largeur = largeur;
    }

    public override double Aire()
    {
        return longueur * largeur;
    }

    public override double Perimetre()
    {
        return 2 * (longueur + largeur);
    }
}

public class Cercle : Figure
{
    private double rayon;

    public Cercle(double rayon)
    {
        this.rayon = rayon;
    }

    public override double Aire()
    {
        return Math.PI * rayon * rayon;
    }

    public override double Perimetre()
    {
        return 2 * Math.PI * rayon;
    }
}


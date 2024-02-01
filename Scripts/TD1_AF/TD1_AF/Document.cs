namespace TD1_AF
{
    public class Document
    {
        public string NumeroEnregistrement { get; set; }
        public string Titre { get; set; }
        public int NombrePages { get; set; }
        public string Editeur { get; set; }

        // Constructor
        public Document(string numeroEnregistrement, string titre, int nombrePages, string editeur)
        {
            NumeroEnregistrement = numeroEnregistrement;
            Titre = titre;
            NombrePages = nombrePages;
            Editeur = editeur;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"NumeroEnregistrement: {NumeroEnregistrement}, Titre: {Titre}, NombrePages: {NombrePages}, Editeur: {Editeur}";
        }
    }

    public class Revue : Document
    {
        public int Mois { get; set; }
        public int Annee { get; set; }

        // Constructor
        public Revue(string numeroEnregistrement, string titre, int nombrePages, string editeur, int mois, int annee)
            : base(numeroEnregistrement, titre, nombrePages, editeur)
        {
            Mois = mois;
            Annee = annee;
        }

        // Override ToString method
        public override string ToString()
        {
            return base.ToString() + $", Mois: {Mois}, Annee: {Annee}";
        }
    }

    public class Livre : Document
    {
        public string Auteur { get; set; }

        // Constructor
        public Livre(string numeroEnregistrement, string titre, int nombrePages, string editeur, string auteur)
            : base(numeroEnregistrement, titre, nombrePages, editeur)
        {
            Auteur = auteur;
        }

        // Override ToString method
        public override string ToString()
        {
            return base.ToString() + $", Auteur: {Auteur}";
        }
    }

    public class Roman : Livre
    {
        public string PrixLitteraire { get; set; }

        // Constructor
        public Roman(string numeroEnregistrement, string titre, int nombrePages, string editeur, string auteur, string prixLitteraire)
            : base(numeroEnregistrement, titre, nombrePages, editeur, auteur)
        {
            PrixLitteraire = prixLitteraire;
        }

        // Override ToString method
        public override string ToString()
        {
            return base.ToString() + $", PrixLitteraire: {PrixLitteraire}";
        }
    }

    public class Manuel : Livre
    {
        public int NiveauScolaire { get; set; }

        // Constructor
        public Manuel(string numeroEnregistrement, string titre, int nombrePages, string editeur, string auteur, int niveauScolaire)
            : base(numeroEnregistrement, titre, nombrePages, editeur, auteur)
        {
            NiveauScolaire = niveauScolaire;
        }

        // Override ToString method
        public override string ToString()
        {
            return base.ToString() + $", NiveauScolaire: {NiveauScolaire}";
        }
    }
}
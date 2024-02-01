namespace TD1_AF
{
    public class Bibliotheque
    {
        private List<Etagere> etageres;

        // Constructor
        public Bibliotheque()
        {
            etageres = new List<Etagere>();
        }

        // Method to add a shelf
        public void AjouterEtagere(Etagere etagere)
        {
            etageres.Add(etagere);
        }

        // Method to add a book
        public bool AjouterDocument(Document doc)
        {
            foreach (Etagere etagere in etageres)
            {
                if (etagere.AjouterDocument(doc))
                {
                    return true;
                }
            }
            return false;
        }

        // Method to find a book by author
        public Livre TrouverLivreParAuteur(string auteur)
        {
            foreach (Etagere etagere in etageres)
            {
                Livre livre = etagere.TrouverLivreParAuteur(auteur);
                if (livre != null)
                {
                    return livre;
                }
            }
            return null;
        }
    }
}
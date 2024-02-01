namespace TD1_AF
{
    public class Etagere
    {
        private List<Document> documents;
        private int capaciteMax;

        // Constructor
        public Etagere(int capacite)
        {
            documents = new List<Document>();
            capaciteMax = capacite;
        }

        // Method to add a document
        public bool AjouterDocument(Document doc)
        {
            if (documents.Count < capaciteMax)
            {
                documents.Add(doc);
                return true;
            }
            return false;
        }

        // Method to list all documents
        public void ListerDocuments()
        {
            foreach (Document doc in documents)
            {
                Console.WriteLine(doc.ToString());
            }
        }

        // Method to find a book by author
        public Livre TrouverLivreParAuteur(string auteur)
        {
            foreach (Document doc in documents)
            {
                if (doc is Livre livre && livre.Auteur == auteur)
                {
                    return livre;
                }
            }
            return null;
        }
    }
}
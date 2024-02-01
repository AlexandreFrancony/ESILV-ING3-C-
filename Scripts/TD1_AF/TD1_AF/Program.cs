namespace TD1_AF
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("123", "Mon Document", 100, "Mon Editeur");
            Console.WriteLine($"#2 : NumeroEnregistrement: {doc.NumeroEnregistrement}, Titre: {doc.Titre}, NombrePages: {doc.NombrePages}, Editeur: {doc.Editeur}");
            Console.WriteLine($"#3 : {doc.ToString()}");
            Revue rev = new Revue("123", "Mon Document", 100, "Mon Editeur", 1, 2020);
            Console.WriteLine($"#4 : {rev.ToString()}");
            Roman rom = new Roman("123", "Mon Document", 100, "Mon Editeur", "Mon Auteur", "Mon Genre");
            Console.WriteLine($"#5a : {rom.ToString()}");
            Manuel man = new Manuel("123", "Mon Document", 100, "Mon Editeur", "Mon Auteur", 1);
            Console.WriteLine($"#5b : {man.ToString()}");

            Etagere etagere = new Etagere(1);

            Livre livre1 = new Livre("123", "Mon Livre", 100, "Mon Editeur", "Mon Auteur");
            Livre livre2 = new Livre("456", "Mon Autre Livre", 200, "Mon Autre Editeur", "Mon Autre Auteur");

            etagere.AjouterDocument(livre1);
            etagere.AjouterDocument(livre2);

            Console.WriteLine($"#6 :");

            etagere.ListerDocuments();

            Livre livreTrouve = etagere.TrouverLivreParAuteur("Mon Auteur");

            if (livreTrouve != null)
            {
                Console.WriteLine("#7 : Livre trouvé : " + livreTrouve.ToString());
            }
            else
            {
                Console.WriteLine("#7 : Aucun livre trouvé pour cet auteur.");
            }

            Bibliotheque bibliotheque = new Bibliotheque();

            Etagere etagere1 = new Etagere(2);
            Etagere etagere2 = new Etagere(2);

            bibliotheque.AjouterEtagere(etagere1);
            bibliotheque.AjouterEtagere(etagere2);

            Livre livre3 = new Livre("007", "James Bond", 100, "Hachette", "Daniel Craig");
            Livre livre4 = new Livre("987", "Pokemon", 200, "Pika-Edition", "Sacha du Bourg-Palette");

            bibliotheque.AjouterDocument(livre1);
            bibliotheque.AjouterDocument(livre2);

            Livre livreTrouveV2 = bibliotheque.TrouverLivreParAuteur("Mon Auteur");

            if (livreTrouveV2 != null)
            {
                Console.WriteLine("#8 : Livre trouvé : " + livreTrouveV2.ToString());
            }
            else
            {
                Console.WriteLine("#8 : Aucun livre trouvé pour cet auteur.");
            }
        }
    }
}
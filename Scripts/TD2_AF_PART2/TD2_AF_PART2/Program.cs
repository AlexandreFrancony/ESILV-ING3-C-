namespace TD2_AF
{
    class Program
    {
        static void Main(string[] args)
        {
            Entreprise entreprise = new Entreprise();
            // Manipulate the content of Entreprise.cs here

            // Exemple de manipulation : 
            entreprise.Nom = "Ma nouvelle entreprise";
            entreprise.Adresse = "Nouvelle adresse";
            entreprise.Telephone = "1234567890";

            // Afficher les informations de l'entreprise
            Console.WriteLine("Nom de l'entreprise : " + entreprise.Nom);
            Console.WriteLine("Adresse de l'entreprise : " + entreprise.Adresse);
            Console.WriteLine("Téléphone de l'entreprise : " + entreprise.Telephone);

            // Autres manipulations possibles...

            // Attendre une saisie de l'utilisateur avant de fermer la console
            Console.ReadLine();
        }
    }
}
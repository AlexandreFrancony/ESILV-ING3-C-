namespace TD1_AF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemple d'utilisation
            Rectangle rectangle = new Rectangle(5, 3);
            Cercle cercle = new Cercle(4);

            Console.WriteLine("Rectangle :");
            Console.WriteLine("Aire : " + rectangle.Aire());
            Console.WriteLine("Périmètre : " + rectangle.Perimetre());

            Console.WriteLine("Cercle :");
            Console.WriteLine("Aire : " + cercle.Aire());
            Console.WriteLine("Périmètre : " + cercle.Perimetre());
        }
    }
}
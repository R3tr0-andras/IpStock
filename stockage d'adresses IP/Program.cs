namespace stockage_d_adresses_IP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;

            while (continuer)
            {
                AfficherMenu();
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        GestionAdressesIP.AjouteAdresseIP();
                        break;
                    case "2":
                        Console.WriteLine("Entrez le nom associé à l'adresse IP :");
                        string nom = Console.ReadLine();
                        GestionAdressesIP.AjouteNom(nom);
                        break;
                    case "3":
                        Console.WriteLine(GestionAdressesIP.ConcateneTout());
                        break;
                    case "stop":
                        continuer = false;
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        break;
                }
            }
        }

        static void AfficherMenu()
        {
            Console.WriteLine("=== Gestion des Adresses IP ===");
            Console.WriteLine("1. Ajouter une adresse IP");
            Console.WriteLine("2. Ajouter un nom à une adresse IP");
            Console.WriteLine("3. Afficher toutes les adresses IP avec leurs noms");
            Console.WriteLine("Tapez 'stop' pour quitter et afficher les résultats");
            Console.Write("Choix : ");
        }
    }
}
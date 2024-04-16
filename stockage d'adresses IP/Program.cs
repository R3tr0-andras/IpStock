namespace stockage_d_adresses_IP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionAdressesIP gestionAdressesIP = new GestionAdressesIP();

            bool continuer = true;

            while (continuer)
            {
                AfficherMenu();
                // je ne sais pas à quoi sert le "?" derrière le type mais ça règle mes problèmes, penser à demander à madame Baudson
                string? choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        gestionAdressesIP.AjouteAdresseIP();
                        break;
                    case "2":
                        Console.WriteLine(gestionAdressesIP.ConcateneTout());
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
            Console.WriteLine("1. Ajouter une adresse IP et un nom à une adresse IP");
            Console.WriteLine("2. Afficher toutes les adresses IP avec leurs noms");
            Console.WriteLine("Tapez 'stop' pour quitter et afficher les résultats");
            Console.Write("Choix : ");
        }
    }
}
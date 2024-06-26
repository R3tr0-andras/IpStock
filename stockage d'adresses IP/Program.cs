﻿namespace stockage_d_adresses_IP
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
                string? choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        Console.Clear();
                        gestionAdressesIP.AjouteAdresseIP();
                        break;
                    case "2":
                        Console.Clear();
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
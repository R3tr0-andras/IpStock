using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockage_d_adresses_IP
{
    public struct GestionAdressesIP
    {
        private const int MAX_ADRESSES = 20;
        private const int MAX_NOMS = 20;
        private static int[,] adressesIP = new int[MAX_ADRESSES, 4];
        private static string[] noms = new string[MAX_NOMS];
        private static int nbAdresses = 0;
        private static int nbNoms = 0;

        public static bool LireOctet(out int octet)
        {
            octet = 0;
            Console.Write("Entrez un nombre entre 0 et 255 : ");
            if (int.TryParse(Console.ReadLine(), out octet) && octet >= 0 && octet <= 255)
            {
                return true;
            }
            return false;
        }

        public static void LireAdresseIP()
        {
            if (nbAdresses < MAX_ADRESSES)
            {
                int[] adresse = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    int octet;
                    do
                    {
                        Console.WriteLine($"Entrez l'octet {i + 1} de l'adresse IP :");
                    } while (!LireOctet(out octet));
                    adresse[i] = octet;
                }
                for (int i = 0; i < 4; i++)
                {
                    adressesIP[nbAdresses, i] = adresse[i];
                }
                nbAdresses++;
            }
            else
            {
                Console.WriteLine("La matrice est pleine, impossible d'ajouter une nouvelle adresse.");
            }
        }

        public static bool AjouteAdresseIP()
        {
            if (nbAdresses < MAX_ADRESSES)
            {
                LireAdresseIP();
                return true;
            }
            return false;
        }

        public static bool AjouteNom(string nom)
        {
            if (nbNoms < MAX_NOMS)
            {
                noms[nbNoms] = nom;
                nbNoms++;
                return true;
            }
            return false;
        }

        public static string ConcateneAdresse(int ligne)
        {
            string adresseConcatenee = "";

            for (int i = 0; i < 4; i++)
            {
                adresseConcatenee += adressesIP[ligne, i];

                if (i < 3)
                {
                    adresseConcatenee += ".";
                }
            }

            return adresseConcatenee;
        }

        public static string ConcateneTout()
        {
            string result = "";

            for (int i = 0; i < nbNoms; i++)
            {
                string adresse = ConcateneAdresse(i);
                result += $"{noms[i]} : {adresse}\n";
            }

            return result;
        }
    }
}

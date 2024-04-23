using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockage_d_adresses_IP
{
    public struct GestionAdressesIP
    {
        InfosIp[] listingIP;
        int compteur;

        public GestionAdressesIP()
        {
            listingIP = new InfosIp[20];
            compteur = 0;
        }

        public bool AjouteAdresseIP()
        {
            if (compteur < 20)
            {
                LireAdresseIP();
                return true;
            }
            else
            {
                return false;
                Console.WriteLine("La matrice est pleine, impossible d'ajouter une nouvelle adresse.");
            }
        }

        public void LireAdresseIP()
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

            Console.WriteLine("Entrez le nom associé à l'adresse IP :");
            string? nom = Console.ReadLine();
            listingIP[compteur].adress = adresse;
            listingIP[compteur].nom = nom;
            compteur++;
        }

        public bool LireOctet(out int octet)
        {
            octet = 0;
            Console.Write("Entrez un nombre entre 0 et 255 : ");
            if (int.TryParse(Console.ReadLine(), out octet) && octet >= 0 && octet <= 255)
            {
                return true;
            }
            return false;
        }

        public string ConcateneTout()
        {
            string result = "";

            for (int i = 0; i < compteur; i++)
            {
                string adresse = ConcateneAdresse(listingIP[i].adress);
                result += $"{listingIP[i].nom} : {adresse}\n";
            }
            return result;
        }

        public string ConcateneAdresse(int[] adresse)
        {
            return LireOctets(adresse);
        }

        public string LireOctets(int[] octets)
        {
            string octetsConcatenes = "";

            for (int i = 0; i < octets.Length; i++)
            {
                octetsConcatenes += octets[i];

                if (i < octets.Length - 1)
                {
                    octetsConcatenes += ".";
                }
            }

            return octetsConcatenes;
        }
    }
    public struct InfosIp
    {
        public int[] adress;
        public string nom;
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class GestionnaireCapteur
    {
        Queue<Capteur> fileCapteurs = new Queue<Capteur>(); //Déclare une file de Capteurs (utilisation d'une file)

        string fichierCapteurs = "Capteurs_file.txt";
        string fichierMesures = "Capteurs_mesures.txt";

        public GestionnaireCapteur()
        {
            chargerCapteurDepuisFichier();
        }

        public void chargerCapteurDepuisFichier()
        {
            if (!File.Exists(fichierCapteurs)) return; // Verifie si le fichier existe. Termine le programme si le fichier n'existe pas
            //Dans le cas ou le fichier existe
            string[]lignes = File.ReadAllLines(fichierCapteurs);
            foreach (string line in lignes)
            {
                string[] elements = line.Split(';');
                if (elements.Length >= 3)
                {
                    int id = int.Parse(elements[0]);
                    string nom = elements[1];

                    if (nom.Contains("Température"))//Vérifie si la chaîne nom, contient la chaine ou la sous-chaîne de caractère "Température"
                    { 
                        fileCapteurs.Enqueue(new CapteurTemperature(id));
                    }
                    else if (nom.Contains("Pression"))
                    {
                        fileCapteurs.Enqueue(new CapteurPression(id));
                    }
                    
                }
            }

        }

        //Ajouter un capteur
        public void ajouterCapteur(Capteur capteur)
        {
            fileCapteurs.Enqueue(capteur);//Ajoute le capteur à la fin de la liste
            //Ajout du capteur dans le fichier
            File.AppendAllText(fichierCapteurs, capteur.Conversion() + Environment.NewLine);
            //Ajoute le retour de la fonction de la méthode Conversion() à la fin du fichier FichierCapteurs
            //Environnement.NewLine => faire un retour à la ligne
        }


        //Afficher un Capteur
        public void AfficherCapteur()
        {
            if(fileCapteurs.Count == 0)
            {
                Console.WriteLine("Aucun capteur enregistré!");
                return;
            }
            Console.WriteLine("Capteur en attente de traitement...");
            foreach (string line in fileCapteurs)
            {
                Console.WriteLine(capteur);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal abstract class Capteur
    {
        public int Id { get; set; }
        public string nom {  get; set; }
        public string uniteMesure { get; set; }
        public double valeurActuelle { get; protected set; }

        public Capteur(int id,string Nom, string Unite)
        {
            Id = id;
            nom = Nom;
            uniteMesure = Unite;
        }

        //Méthode abstraite pour lire une valeur
        public abstract void LireValeur();

        //Redéfinition de la méthode ToString()
        public override string ToString()
        {
            return $"{nom}(ID:{Id})-Dernière valeur:{valeurActuelle} {uniteMesure}";
        }

        //Convertir l'affichage selon le format désiré
        public string Conversion()
        {
            return $"{Id};{nom};{uniteMesure};{valeurActuelle}";
        }

    }
}

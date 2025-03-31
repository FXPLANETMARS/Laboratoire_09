using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class CapteurPression:Capteur
    {
        static Random random = new Random();

        public CapteurPression(int id) : base(id, "Capteur de pression", "pa")
        {

        }

        //Redéfinition de la méthode LireValeur()
        public override void LireValeur()
        {
            valeurActuelle = random.Next(900, 1100) + random.NextDouble();
            //random.Next(900, 1100) => un nombre entier entre 900 et 1100 puis un nombre décimal entre (0.0 et 1.0)
            //On obtient un nombre décimal
        }

    }
}

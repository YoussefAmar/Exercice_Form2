using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Appli4
{
    class Animal
    {
        #region attributs 

        public int identifiant;
        public string nom;
        public string race;
        public int age;
        public int poids;

        #endregion

        #region constructeur

        public Animal(int identifiant, string nom, string race,
            int age, int poids)
        {
            this.identifiant = identifiant;
            this.nom = nom;
            this.race = race;
            this.age = age;
            this.poids = poids;
        }

        #endregion

        #region méthode

        public override string ToString()
        {
            return (nom + " - " + race.ToString());
        }

        public string affiche()
        {
            return (identifiant.ToString() + "-" + nom + "-" + race +
                "-" + age.ToString() + " ans");
        }

        public void vieillit(int nombre)
        {
            this.age += nombre;

        }

        #endregion 
    }
}

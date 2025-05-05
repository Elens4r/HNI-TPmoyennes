using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNI_TPmoyennes
{
    internal class Classe
    {
        public string nomClasse;
        public List<Eleve> eleves;
        public List<string> matieres;

        public Classe(string nom)
        {
            this.nomClasse = nom;
            eleves = new List<Eleve>();
            matieres = new List<string>();
        }

        public void ajouterEleve(string nom,string prenom)
        {
            eleves.Add(new Eleve(nom, prenom));
        }

        public void ajouterMatiere(string matiere)
        {
            matieres.Add(matiere);
        }

        public double moyenneMatiere(int i)
        {
            double tot = 0.0;

            foreach (Eleve eleve in this.eleves)
            {
                tot += eleve.moyenneMatiere(i);
            }

            return double.Round(tot/eleves.Count, 2);

        }

        public double moyenneGeneral()
        {
            double tot = 0.0;

            foreach (Eleve eleve in eleves)
            {
                tot += eleve.moyenneGeneral();
            }

            return double.Round(tot/eleves.Count, 2);
        }
    }
}

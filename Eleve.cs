using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HNI_TPmoyennes;

namespace HNI_TPmoyennes
{
    internal class Eleve
    {
        public string prenom;
        public string nom;
        public List<Note> notes;

        public Eleve(string prenom, string nom)
        {
            this.prenom = prenom;
            this.nom = nom;
            notes = new List<Note>();
        }

        public void ajouterNote(Note note)
        {
            notes.Add(note);
        }

        public double moyenneMatiere(int matiere)
        {
            int nb = 0;
            double tot=0.0;
            foreach(Note note in notes)
            {
                if (note.matiere == matiere)
                {
                    nb++;
                    tot += note.note;
                }
            }
            return double.Round(tot / nb, 2);
        }

        public double moyenneGeneral()
        {
            List<int> matieresEleve = new List<int>();
            foreach (Note note in notes)
            {
                if (!matieresEleve.Contains(note.matiere))
                {
                    matieresEleve.Add(note.matiere);
                }
            }

            double tot = 0.0;
            foreach(int matiere in matieresEleve)
            {
                tot += moyenneMatiere(matiere);
            }

            return double.Round(tot/matieresEleve.Count, 2);
        }
    }
}

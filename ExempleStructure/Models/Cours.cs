using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleStructure.Models
{
    public class Cours
    {
        public Cours(string nom)
        {
            Nom = nom;
        }
        public string Nom { get; set; }
        List<Etudiant> EtudiantList { get; set; } = new List<Etudiant>();

        public void AjoutEtudiant(Etudiant etudiant)
        {
            EtudiantList.Add(etudiant);
        }


    }
}

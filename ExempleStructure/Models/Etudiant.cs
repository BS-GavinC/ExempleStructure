using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleStructure.Models
{
    public class Etudiant
    {
        public Etudiant(string nom)
        {
            Nom = nom;
        }

        public string Nom { get; set; }
    }
}

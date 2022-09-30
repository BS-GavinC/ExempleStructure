using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleStructure.Models
{
    public class Salle
    {
        public Salle(string nom)
        {
            Nom = nom;
        }
        public Salle(string nom, int cap)
        {
            Nom = nom;
            Capacite = cap;
        }

        public string Nom { get; set; }
        public int Capacite { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleStructure.Models
{
    public class Session
    {
        
        public Session( DateTime debut, DateTime fin, Prof professeur, Salle salleUtilise, Cours coursDonne)
        {
            Nom = coursDonne.Nom.Substring(0, 2).ToUpper() +
                salleUtilise.Nom.Substring(0, 2).ToUpper() +
                professeur.Nom.Substring(0, 2).ToUpper()+
                debut.Day + debut.Month + debut.Year;
                
            Debut = debut;
            Fin = fin;
            Professeur = professeur;
            SalleUtilise = salleUtilise;
            CoursDonne = coursDonne;
        }

        public string Nom { get;  }
        public DateTime Debut { get; private set; }
        public DateTime Fin { get; private set; }
        public Prof Professeur { get; private set; }
        public Salle SalleUtilise { get; private set; }
        public Cours CoursDonne { get; private set; }
    }
}

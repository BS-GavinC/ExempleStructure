using ExempleStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleStructure
{
    public static class PlanningManager
    {
        public static List<Session> sessions = new List<Session>();
        public static Etudiant CreerEtudiant(string nom)
        {
            return new Etudiant(nom);
        }

        public static Prof CreerProfesseur(string nom)
        {
            return new Prof(nom);
        }

        public static Salle CreerSalle(string nom) 
        { 
            return new Salle(nom); 
        }

        public static Cours CreerCours(string nom)
        {
            return new Cours(nom);
        }

        public static Cours AjouterEtudiant(Cours cours, Etudiant etudiant)
        {
            cours.AjoutEtudiant(etudiant);
            return cours;
        }

        public static Session? AjouterSession(DateTime debut, DateTime fin, Prof prof,Salle salle, Cours cours)
        {
            foreach (var session in sessions)
            {
                if (
                    (session.Debut > debut && session.Debut < fin)
                    ||
                    (session.Fin > debut && session.Fin < fin)
                    ||
                    (debut > session.Debut && debut < session.Fin)
                    ||
                    (fin > session.Debut && fin < session.Fin))
                {

                    if (prof == session.Professeur || salle == session.SalleUtilise || cours == session.CoursDonne)
                    {
                        return null;
                    }
                }
            }

            Session maSession = new Session(debut, fin, prof, salle, cours);
            sessions.Add(maSession);
            return maSession;


            
        }
    }
}

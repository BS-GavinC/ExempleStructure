using ExempleStructure;
using ExempleStructure.Models;

Etudiant Etudiant = PlanningManager.CreerEtudiant("Popol");

Prof professeur = PlanningManager.CreerProfesseur("Khun");

Prof professeur2 = PlanningManager.CreerProfesseur("Aude");

Salle salle = PlanningManager.CreerSalle("Digital");

Salle salle2 = PlanningManager.CreerSalle("Cafet");

Cours cours = PlanningManager.CreerCours("CSHARP POO");

Cours cours2 = PlanningManager.CreerCours("CSHARP ALGO");

PlanningManager.AjouterEtudiant(cours, Etudiant);

Session? session = PlanningManager.AjouterSession(DateTime.Now, DateTime.Now.AddHours(8), professeur, salle, cours);

if (session != null)
{
    Console.WriteLine(session.Nom);
}

Session? session2 = PlanningManager.AjouterSession(DateTime.Now.AddHours(24), DateTime.Now.AddHours(32), professeur, salle2, cours);

if (session2 == null)
{
    Console.WriteLine("Session 2 ne peut pas etre créée");
}
else
{
    Console.WriteLine(session2.Nom);
}



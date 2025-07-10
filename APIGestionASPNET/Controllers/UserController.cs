using APIGestionASPNET.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Data.Entity;


namespace APIGestionASPNET.Controllers
{
    public class UserController : ApiController
    {
        bdappartement1Entities db = new bdappartement1Entities();
        public List<Personne> getAllUsers()
        {

            return db.Personne.ToList();

        }

        public bool AddUsers(Personne p)
        {
            try
            {
                db.Personne.Add(p);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return false;
            }
        }

        
        [HttpPost]
        [Route("api/User/UpdateUsers")]
        public bool UpdateUsers([FromBody] Personne p)
        {
            try
            {
                var personInDb = db.Personne.Include(x => x.Utilisateur).FirstOrDefault(x => x.IdPersonne == p.IdPersonne);
                if (personInDb == null)
                    return false;

                // Mise à jour des champs de Personne
                personInDb.NomPrenom = p.NomPrenom;
                personInDb.Telephone = p.Telephone;
                personInDb.Email = p.Email;
                personInDb.CNI = p.CNI;

                // Mise à jour de la propriété Utilisateur liée
                if (personInDb.Utilisateur != null && p.Utilisateur != null)
                {
                    personInDb.Utilisateur.Identifiant = p.Utilisateur.Identifiant;
                    personInDb.Utilisateur.MotDePasse = p.Utilisateur.MotDePasse;
                    personInDb.Utilisateur.Statut = p.Utilisateur.Statut;
                }
                else if (personInDb.Utilisateur == null && p.Utilisateur != null)
                {
                    // Créer un Utilisateur si pas existant
                    personInDb.Utilisateur = p.Utilisateur;
                }

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }




        public bool DeleteUsers(int id)
        {
            try
            {
                var user = db.Personne.Find(id);
                if (user != null)
                {
                    db.Personne.Remove(user);
                    db.SaveChanges();
                    return true;
                }
                return false; // User not found
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return false;
            }


        }
    }
}

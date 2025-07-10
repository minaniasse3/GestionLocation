using MetierGestionLocation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MetierGestionLocation.Utils;
using System.Data.Entity;

namespace MetierGestionLocation
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        BdAppartementContext db = new BdAppartementContext();
        Helper helper = new Helper();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        /// <summary>
        /// cette methode permet d'enregistrer un nouveau appartement
        /// </summary>
        /// <param name="appartement">un appartement</param>
        /// <returns>true si fais sinon false</returns>
        public bool AddAppartement(Appartement appartement)
        {
            try
            {
                db.appartements.Add(appartement);
                db.SaveChanges();
            }catch(Exception ex)
            {
                helper.WriteDataError("Service1-AddAppartement", ex.ToString());
                return false;
            }
            return true;
        }


        /// <summary>
        /// Mise a jour d'un appartement
        /// </summary>
        /// <param name="appartement">Objet Appartement</param>
        /// <returns>Oui, si fait </returns>
        public bool UpdateAppartement(Appartement appartement)
        {
            try
            {
                db.Entry(appartement).State=EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-UpdateAppartement", ex.ToString());
                return false;
            }
            return true;
        }


        /// <summary>
        /// Methode pour supprimer un appartement
        /// </summary>
        /// <param name="appartement">Objet appartement</param>
        /// <returns>true , si fait</returns>
        public bool DeleteAppartement(Appartement appartement)
        {
            try
            {
                db.Entry(appartement).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-DeleteAppartement", ex.ToString());
                return false;
            }
            return true;
        }


        /// <summary>
        /// cette methode permet de recuperer le liste des appartement
        /// </summary>
        /// <param name="adresse">Adresse de recherche</param>
        /// <param name="capacite">Capacite de recherche</param>
        /// <param name="disponible">Disponibilite de recherche</param>
        /// <returns>retourne lieste des appartement respectant les critères</returns>
        public List<Appartement> GetListeAppartement(string adresse , float? capacite, bool? disponible)
        {
            
            var liste = db.appartements.ToList();
            if (!string.IsNullOrEmpty(adresse))
            {
                liste =liste.Where(a=>a.AdresseAppartement.ToLower().Contains(adresse.ToLower())).ToList();
            }

            if (capacite != null)
            {
                liste = liste.Where(a => a.Capacite==capacite).ToList();
            }

            if (disponible != null)
            {
                liste = liste.Where(a => a.Disponible == disponible).ToList();
            }
            return liste;
        }

        /// <summary>
        /// cette methode permet de recuperer un appartement
        /// </summary>
        /// <param name="id">identifiant appartement</param>
        /// <returns>objet appartement</returns>
        public Appartement GetAppartementById(int? id )
        {
            return db.appartements.Find(id);
        }




        /// <summary>
        /// CETTE METHODE PERMENT DE D'ENREGISTRER UN locataire
        /// </summary>
        /// <param name="locataire">un locataire</param>
        /// <returns>true si fais sinon false</returns>
        public bool AddLocataire(Locataire locataire)
        {
            try
            {
                db.locataires.Add(locataire);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-AddLocataire", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// cette methode permet de modifier un locataire
        /// </summary>
        /// <param name="locataire">Objet locataire</param>
        /// <returns>Oui, si fait </returns>
        public bool UpdateLocataire(Locataire locataire)
        {
            try
            {
                db.Entry(locataire).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-UpdateLocataire", ex.ToString());
                return false;
            }
            return true;
        }



        /// <summary>
        /// Cette methode permet de supprimer un locataire
        /// </summary>
        /// <param name="locataire">Objet Locataire</param>
        /// <returns>true , si fait</returns>
        public bool DeleteLocataire(Locataire locataire)
        {
            try
            {
                db.Entry(locataire).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-DeleteLocataire", ex.ToString());
                return false;
            }
            return true;
        }


        /// <summary>
        /// cette methode permet de recuperer un locataire
        /// </summary>
        /// <param name="id">identifiant Locataire</param>
        /// <returns>object Locataire</returns>
        public Locataire GetLocataireById(int? id)
        {
            return db.locataires.Find(id);
        }





       /// <summary>
       /// 
       /// </summary>
       /// <param name="proprietaire"></param>
       /// <returns></returns>
        public bool AddProprietaire(Proprietaire proprietaire)
        {
            try
            {
                db.proprietaires.Add(proprietaire);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-AddLocataire", ex.ToString());
                return false;
            }
            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="proprietaire"></param>
        /// <returns></returns>
        public bool UpdateProprietaire(Proprietaire proprietaire)
        {
            try
            {
                db.Entry(proprietaire).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-UpdateProprietaire", ex.ToString());
                return false;
            }
            return true;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="proprietaire"></param>
        /// <returns></returns>
        public bool DeleteProprietaire(Proprietaire proprietaire)
        {
            try
            {
                db.Entry(proprietaire).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-DeleteProprietaire", ex.ToString());
                return false;
            }
            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Proprietaire GetProprietaireById(int? id)
        {
            return db.proprietaires.Find(id);
        }

        /// <summary>
        /// Ajoute un nouveau mode de paiement
        /// </summary>
        public bool AddModePaiement(ModePaiement mode)
        {
            try
            {
                db.ModePaiements.Add(mode);
                db.SaveChanges();
                
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-AddModePaiement", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Récupère un mode de paiement par son ID
        /// </summary>
        public ModePaiement GetModePaiementById(int? id)
        {
            return db.ModePaiements.Find(id);
        }
        /// <summary>
        /// Met à jour un mode de paiement existant
        /// </summary>
        public bool UpdateModePaiement(ModePaiement mode)
        {
            try
            {
                db.Entry(mode).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-UpdateModePaiement", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Supprime un mode de paiement
        /// </summary>
        public bool DeleteModePaiement(ModePaiement mode)
        {
            try
            {
                db.Entry(mode).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-DeleteModePaiement", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Ajoute un contrat de location
        /// </summary>
        /// <param name="contrat">Objet ContratLocation</param>
        /// <returns>true si réussi, false sinon</returns>
        public bool AddContratLocation(ContratLocation contrat)
        {
            try
            {
                contrat.DateCreation = DateTime.Now;
                db.ContratLocations.Add(contrat);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-AddContratLocation", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Met à jour un contrat de location existant
        /// </summary>
        public bool UpdateContratLocation(ContratLocation contrat)
        {
            try
            {
                db.Entry(contrat).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-UpdateContratLocation", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Supprime un contrat de location
        /// </summary>
        public bool DeleteContratLocation(ContratLocation contrat)
        {
            try
            {
                db.Entry(contrat).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-DeleteContratLocation", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Récupère un contrat de location par ID
        /// </summary>
        public ContratLocation GetContratLocationById(int? id)
        {
            return db.ContratLocations.Find(id);
        }

        /// <summary>
        /// Récupère la liste des contrats de location avec option de filtre par statut
        /// </summary>
        public List<ContratLocation> GetListeContratLocation(string statut = null)
        {
            var query = db.ContratLocations.Include(c => c.Appartement).Include(c => c.Locataire).AsQueryable();

            if (!string.IsNullOrEmpty(statut))
            {
                query = query.Where(c => c.Statut.ToLower() == statut.ToLower());
            }

            return query.ToList();
        }

        /// <summary>
        /// Récupère la liste de tous les propriétaires
        /// </summary>
        public List<Proprietaire> GetListeProprietaires()
        {
            return db.proprietaires.ToList();
        }

        /// <summary>
        /// Récupère la liste de tous les locataires
        /// </summary>
        public List<Locataire> GetListeLocataires()
        {
            return db.locataires.ToList();
        }

        /// <summary>
        /// Récupère la liste de tous les modes de paiement
        /// </summary>
        public List<ModePaiement> GetListeModePaiements()
        {
            return db.ModePaiements.ToList();
        }

        /// <summary>
        /// Ajoute un nouveau paiement
        /// </summary>
        public bool AddPaiement(Paiement paiement)
        {
            try
            {
                paiement.DatePaiment = DateTime.Now;
                db.Paiements.Add(paiement);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-AddPaiement", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Met à jour un paiement existant
        /// </summary>
        public bool UpdatePaiement(Paiement paiement)
        {
            try
            {
                db.Entry(paiement).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-UpdatePaiement", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Supprime un paiement
        /// </summary>
        public bool DeletePaiement(Paiement paiement)
        {
            try
            {
                db.Entry(paiement).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-DeletePaiement", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Récupère un paiement par ID
        /// </summary>
        public Paiement GetPaiementById(int? id)
        {
            return db.Paiements.Find(id);
        }

        /// <summary>
        /// Récupère la liste des paiements avec filtres optionnels
        /// </summary>
        public List<Paiement> GetListePaiements(DateTime? dateDebut, DateTime? dateFin, int? idContrat)
        {
            var query = db.Paiements.Include(p => p.ContratLocation).AsQueryable();

            if (dateDebut.HasValue)
            {
                query = query.Where(p => p.DatePaiment >= dateDebut.Value);
            }

            if (dateFin.HasValue)
            {
                query = query.Where(p => p.DatePaiment <= dateFin.Value);
            }

            if (idContrat.HasValue)
            {
                query = query.Where(p => p.IdContrat == idContrat.Value);
            }

            return query.OrderByDescending(p => p.DatePaiment).ToList();
        }

        /// <summary>
        /// Ajoute un nouvel utilisateur
        /// </summary>
        public bool AddUtilisateur(Utilisateur utilisateur)
        {
            try
            {
                // Vérifier si l'identifiant existe déjà
                var existingUser = db.Utilisateurs.FirstOrDefault(u => u.Identifiant.ToLower() == utilisateur.Identifiant.ToLower());
                if (existingUser != null)
                {
                    return false; // Identifiant déjà existant
                }

                db.Utilisateurs.Add(utilisateur);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-AddUtilisateur", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Met à jour un utilisateur existant
        /// </summary>
        public bool UpdateUtilisateur(Utilisateur utilisateur)
        {
            try
            {
                db.Entry(utilisateur).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-UpdateUtilisateur", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Supprime un utilisateur
        /// </summary>
        public bool DeleteUtilisateur(Utilisateur utilisateur)
        {
            try
            {
                db.Entry(utilisateur).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-DeleteUtilisateur", ex.ToString());
                return false;
            }
            return true;
        }

        /// <summary>
        /// Récupère un utilisateur par ID
        /// </summary>
        public Utilisateur GetUtilisateurById(int? id)
        {
            return db.Utilisateurs.Find(id);
        }

        /// <summary>
        /// Authentifie un utilisateur
        /// </summary>
        public Utilisateur AuthenticateUser(string identifiant, string motDePasse)
        {
            try
            {
                var utilisateur = db.Utilisateurs.FirstOrDefault(u => u.Identifiant.ToLower() == identifiant.ToLower());
                
                if (utilisateur != null)
                {
                    // Vérifier le mot de passe (logique similaire à Form1.cs)
                    bool motDePasseValide = false;

                    if (utilisateur.MotDePasse == null)
                    {
                        motDePasseValide = true;
                    }
                    else
                    {
                        // Vérifier si le mot de passe est hashé (32 caractères hexadécimaux)
                        if (utilisateur.MotDePasse.Length == 32 && IsHexString(utilisateur.MotDePasse))
                        {
                            // Le mot de passe est hashé, vérifier avec MD5
                            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
                            {
                                motDePasseValide = CryptApp.VerifyMd5Hash(md5Hash, motDePasse, utilisateur.MotDePasse);
                            }
                        }
                        else
                        {
                            // Le mot de passe n'est pas hashé, comparer en clair
                            motDePasseValide = (utilisateur.MotDePasse == motDePasse);
                        }
                    }

                    if (motDePasseValide && utilisateur.Statut == "Enabled")
                    {
                        return utilisateur;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                helper.WriteDataError("Service1-AuthenticateUser", ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Récupère la liste de tous les utilisateurs
        /// </summary>
        public List<Utilisateur> GetListeUtilisateurs()
        {
            return db.Utilisateurs.ToList();
        }

        /// <summary>
        /// Vérifie si une chaîne est hexadécimale
        /// </summary>
        private bool IsHexString(string input)
        {
            return input.All(c => "0123456789ABCDEFabcdef".Contains(c));
        }

    }
}

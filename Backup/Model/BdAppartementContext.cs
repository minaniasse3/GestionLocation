using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace MetierGestionLocation.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class BdAppartementContext:DbContext
    {
        public BdAppartementContext():base("bdAppartementContext")
        { }
        public DbSet<Appartement> appartements { get; set; }
        public DbSet<Proprietaire> proprietaires { get; set; }
        public DbSet<Locataire > locataires  { get; set; }
        public DbSet<Personne> personnes  { get; set; }
        public DbSet<TypeAppartement> typeAppartements { get; set; }

        public DbSet<ContratLocation> ContratLocations { get; set; }

        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DbSet<Gestionnaire> Gestionnaires { get; set; }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<ModePaiement> ModePaiements { get; set; }
        public DbSet<Td_Erreur> Td_Erreurs { get; set; }





    }


}

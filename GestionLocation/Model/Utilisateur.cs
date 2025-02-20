using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLocation.Model
{
    public class Utilisateur : Personne
    {
        [Required, MaxLength(20)]

        public string Identiant { get; set; }

        [Required, MaxLength(512)]

        public string MotDePasse{ get; set; }

        [Required, MaxLength(20)]

        public string Statut { get; set; }
    }
}

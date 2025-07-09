using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MetierGestionLocation.Model
{
    public class Gestionnaire:Utilisateur
    {
        [Required, MaxLength(20)]
        public string Ninea { get; set; }

        [Required, MaxLength(20)]
        public string Rccm { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MetierGestionLocation.Model
{
    [DataContract]
    public class Gestionnaire:Utilisateur
    {
        [Required, MaxLength(20)]
        [DataMember]
        public string Ninea { get; set; }

        [Required, MaxLength(20)]
        [DataMember]
        public string Rccm { get; set; } 
    }
}

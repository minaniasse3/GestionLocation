using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MetierGestionLocation.Model
{
    [DataContract]
    public class Utilisateur : Personne
    {
        [MaxLength(20)]
        [DataMember]
        public string Identifiant { get; set; }

        [MaxLength(512)]
        [DataMember]
        public string MotDePasse{ get; set; }

        [MaxLength(20)]
        [DataMember]
        public string Statut { get; set; }
    }
}

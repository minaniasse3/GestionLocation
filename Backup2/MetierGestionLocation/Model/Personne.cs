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
    [KnownType(typeof(Proprietaire))]
    [KnownType(typeof(Locataire))]
    [KnownType(typeof(Utilisateur))]
    [KnownType(typeof(Gestionnaire))]
    [KnownType(typeof(Admin))]
    public class Personne
    {
        [Key] 
        [DataMember]
        public int IdPersonne { get; set; }

        [MaxLength(160)]
        [DataMember]
        public string NomPrenom { get; set; }

        [MaxLength(20)]
        [DataMember]
        public string Telephone  { get; set; }

        [MaxLength(80),DataType(DataType.EmailAddress)]
        [DataMember]
        public string Email  { get; set; }

        [MaxLength(20)]
        [DataMember]
        public string CNI { get; set; }

    }
}

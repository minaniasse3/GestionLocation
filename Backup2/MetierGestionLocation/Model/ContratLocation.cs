using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MetierGestionLocation.Model
{
    [DataContract]
    public class ContratLocation
    {
        [Key]
        [DataMember]
        public int IdContrat { get; set; }
        
        [MaxLength(20)]
        [DataMember]
        public string Numero { get; set; }
        
        [DataMember]
        public DateTime? DateDebut {  get; set; }
        
        [DataMember]
        public DateTime? DateFin { get; set; }
        
        [DataMember]
        public DateTime? DateCreation { get; set; }
        
        [DataMember]
        public float? Montant {  get; set; }
        
        [MaxLength(20)]
        [DataMember]
        public string Statut {  get; set; }

        [DataMember]
        public int? IdAppartement { get; set; }
        
        [ForeignKey("IdAppartement")]
        [IgnoreDataMember]
        public virtual Appartement Appartement { get; set; }

        [DataMember]
        public int? IdLocataire { get; set; }
        
        [ForeignKey("IdLocataire")]
        [IgnoreDataMember]
        public virtual Locataire Locataire { get; set; }

        [DataMember]
        public int? IdPaiement { get; set; }
        
        [ForeignKey("IdPaiement")]
        [IgnoreDataMember]
        public virtual Paiement Paiement { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Paiement> Paiements { get; set; }
    }
}

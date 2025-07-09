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
    public class Paiement
    {
        [Key]
        [DataMember]
        public int IdPaiement {  get; set; }
        
        [DataMember]
        public DateTime? DatePaiment {  get; set; }
        
        [DataMember]
        public float? Montant {  get; set; }
        
        [MaxLength(20)]
        [DataMember]
        public string NumeroFacture { get; set; }

        [DataMember]
        public int? IdModePaiement { get; set; }
        
        [ForeignKey("IdModePaiement")]
        [IgnoreDataMember]
        public virtual ModePaiement ModePaiement { get; set; }

        [DataMember]
        public int? IdContrat { get; set; }
        
        [ForeignKey("IdContrat")]
        [IgnoreDataMember]
        public virtual ContratLocation ContratLocation { get; set; }
    }
}

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
    public class ModePaiement
    {
        [Key]
        [DataMember]
        public int IdModePaiement {  get; set; }
        
        [MaxLength(40)]
        [DataMember]
        public string LibelleModePaiement { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Paiement> Paiements { get; set; }
    }
}

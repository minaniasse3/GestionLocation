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
    public class TypeAppartement
    {
        [Key]
        [DataMember]
        public int IdTypeAppartement { get; set; }

        [Required, MaxLength(80)]
        [DataMember]
        public string LibelleTypeAppartement { get; set; }
        
        [IgnoreDataMember]
        public virtual ICollection<Appartement> Appartements { get; set; }
    }
}

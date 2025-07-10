using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace MetierGestionLocation.Model
{
    [DataContract]
    public class Appartement
    {
        [Key]
        [DataMember]
        public int IdAppartement { get; set; }

        [Required, MaxLength(100)]
        [DataMember]
        public string AdresseAppartement { get; set; }

        [DataMember]
        public float? Surface { get; set; }

        [DataMember]
        public float? Capacite { get; set; }

        [DataMember]
        public int? NombrePiece { get; set; }

        [DataMember]
        public bool Disponible { get; set; }

        [DataMember]
        public int? IdPropriataire { get; set; }

        [ForeignKey("IdPropriataire")]
        [IgnoreDataMember]
        public virtual Proprietaire Proprietaire { get; set; }

        [DataMember]
        public int? IdTypeAppartement { get; set; }

        [ForeignKey("IdTypeAppartement")]
        [IgnoreDataMember]
        public virtual TypeAppartement TypeAppartement { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<ContratLocation> ContratLocation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MetierGestionLocation.Model
{
    public class Appartement
    {
        [Key]
        public int IdAppartement { get; set; }

        [Required, MaxLength(100)]
        public string AdresseAppartement { get; set; }

        public float? Surface { get; set; }

        public float? Capacite { get; set; }

        public int? NombrePiece { get; set; }

        public bool Disponible { get; set; }

        public int? IdPropriataire { get; set; }

        [ForeignKey("IdPropriataire")]
        public virtual Proprietaire Proprietaire { get; set; }

        public int? IdTypeAppartement { get; set; }

        [ForeignKey("IdTypeAppartement")]
        public virtual TypeAppartement TypeAppartement { get; set; }

        public virtual ICollection<ContratLocation> ContratLocation { get; set; }



    }
}

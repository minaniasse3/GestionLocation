using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierGestionLocation.Model
{
    public class Paiement
    {
        [Key]
        public int IdPaiement {  get; set; }
        public DateTime? DatePaiment {  get; set; }
        public float? Montant {  get; set; }
        [MaxLength(20)]
        public string NumeroFacture { get; set; }

        public int? IdModePaiement { get; set; }
        [ForeignKey("IdModePaiement")]
        public virtual ModePaiement ModePaiement { get; set; }



        public int? IdContrat { get; set; }
        [ForeignKey("IdContrat")]
        public virtual ContratLocation ContratLocation { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLocation.Model
{
    public class TypeAppartement
    {
        [Key]
        public int IdTypeAppartement { get; set; }

        [Required, MaxLength(80)]
        public string LibelleTypeAppartement { get; set; }
        public virtual ICollection<Appartement> Appartements { get; set; }
    }
}

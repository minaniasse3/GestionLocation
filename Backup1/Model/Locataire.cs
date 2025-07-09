using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierGestionLocation.Model
{
    public class Locataire:Personne
    {
        public virtual ICollection<ContratLocation> ContratLocations { get; set; }
    }
}

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
    public class Locataire:Personne
    {
        [IgnoreDataMember]
        public virtual ICollection<ContratLocation> ContratLocations { get; set; }
    }
}

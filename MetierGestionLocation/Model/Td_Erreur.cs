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
    public class Td_Erreur
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime DateErreur { get; set; } = DateTime.Now;
        [MaxLength(2000)]
        [DataMember]
        public string DescriptionErreur { get; set; }
        [MaxLength(200)]
        [DataMember]
        public string TitreErreur { get; set; }
    }
}

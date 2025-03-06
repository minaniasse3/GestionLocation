using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestionLocation.Model
{
    public class Personne
    {
        [Key] 
        public int IdPersonne { get; set; }

        [ MaxLength(160)]
        public string NomPrenom { get; set; }

        [ MaxLength(20)]
        public string Telephone  { get; set; }

        [ MaxLength(80),DataType(DataType.EmailAddress)]
        public string Email  { get; set; }

        [MaxLength(20)]
        public string CNI { get; set; }

    }
}

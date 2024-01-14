using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class RechnerModel
    {
        [Required]
        public string Beschreibung {  get; set; }
        [Required]
        [Range(typeof(decimal),"-1","100000",ErrorMessage ="sie können nur einen Betrag von 1 - 100000 Nehmen")]
        public decimal Betrag { get; set; }
    }
}

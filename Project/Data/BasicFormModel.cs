using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class BasicFormModel
    {
        [Required]
        [MinLength(18, ErrorMessage = "Der Benutzer Name kann nicht kleiner als 18 Zeichen sein"), MaxLength(25, ErrorMessage = "Der Benuter Name kann nicht grösser als 25 Zeichen sein")]
        public string Name { get; set; }
        [Required]
        [Range(typeof(int), "100000", "10000000", ErrorMessage = "Die Fiasko Nummer muss midestens 6 stellig sein und darf maximal 8 stellig sein.")]
        public int FiaskoNummer { get; set; }
        [Required]
        public DateTime AblaufDatum { get; set; } = DateTime.Now;

        
    }
}

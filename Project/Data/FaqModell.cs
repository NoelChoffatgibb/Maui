using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class FaqModell
    {
        [Required]
        [EmailAddress(ErrorMessage ="Ungültige Email Addresse")]
        public String Email { get; set; }
        [Required]
        public String News {  get; set; }

    }
}

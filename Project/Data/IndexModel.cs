using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class IndexModel
    {
        [Required]
        public CheckBox Radio {  get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpgaveUge3.Models
{
    public class Vurdering
    {
        [Required()]
        public string Navn { get; set; }
        [Required()]
        public string Produkt { get; set; }
        [Required(), DataType(DataType.MultilineText)]
        public string Beskrivelse { get; set; }
        [Required()]
        public int Karakter { get; set; }

    }
}

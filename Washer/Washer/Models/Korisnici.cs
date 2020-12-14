using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washer.Models
{
    public class Korisnici
    {
        public int Id { get; set; }
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrLicne { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }

}

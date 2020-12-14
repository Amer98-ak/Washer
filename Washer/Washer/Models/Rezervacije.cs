using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washer.Models
{
    public class Rezervacije
    {
        public int Id { get; set; }
        public Korisnici Korisnik  { get; set; }
        public string DatumOd  { get; set; }
        public string DatumDo  { get; set; }
        public float Cijena  { get; set; }


    }
}

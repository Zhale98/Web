using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Rezervaciq
    {
        [Key]
        public int Id { get; set; }
        public string Smqna_Id { get; set; }
        public string Kategoriq { get; set; }
        public int Dni { get; set; }
        public DateTime Ot { get; set; }
        public DateTime Do { get; set; }
        public string Ime { get; set; }
        public string Familiq { get; set; }
        public int Bungala { get; set; }
        public int Cena { get; set; }
        public int Dete_7 { get; set; }
        public int Dete_10 { get; set; }
        public int Dete_12 { get; set; }
        public List<Smqna> Smeni { get; set; }
        public object Bungalo { get; internal set; }
    }
}

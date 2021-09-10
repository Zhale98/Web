﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Smqna
    {
        [Key]
        public int Id { get; set; }
        public string Smeni { get; set; }
        public DateTime Ot { get; set; }
        public DateTime Do { get; set; }
        public string Nomer { get; set; }
        public int Dni { get; set; }
        public int Bungalo { get; set; }
        public string Kategoriq { get; set; }
        public int Dete_7 { get; set; }
        public int Dete_10 { get; set; }
        public int Dete_12 { get; set; }
    }
}

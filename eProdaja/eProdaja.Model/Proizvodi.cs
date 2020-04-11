using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
    public partial class Proizvodi
    {
        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public int VrstaId { get; set; }
        public int JedinicaMjereId { get; set; }
        public byte[] Slika { get; set; }
        public bool? Status { get; set; }

        public virtual JediniceMjere JedinicaMjere { get; set; }
        public virtual VrsteProizvoda Vrsta { get; set; }
    }
}

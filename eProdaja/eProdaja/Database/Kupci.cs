using System;
using System.Collections.Generic;

namespace eProdaja.Database
{
    public partial class Kupci
    {
        public Kupci()
        {
            Narudzbe = new HashSet<Narudzbe>();
            Ocjene = new HashSet<Ocjene>();
        }

        public int KupacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Narudzbe> Narudzbe { get; set; }
        public virtual ICollection<Ocjene> Ocjene { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace eProdaja.Database
{
    public partial class Izlazi
    {
        public Izlazi()
        {
            IzlazStavke = new HashSet<IzlazStavke>();
        }

        public int IzlazId { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
        public bool Zakljucen { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int? NarudzbaId { get; set; }
        public int SkladisteId { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual Narudzbe Narudzba { get; set; }
        public virtual Skladista Skladiste { get; set; }
        public virtual ICollection<IzlazStavke> IzlazStavke { get; set; }
    }
}

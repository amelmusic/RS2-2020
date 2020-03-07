using System;
using System.Collections.Generic;

namespace eProdaja
{
    public partial class Skladista
    {
        public Skladista()
        {
            Izlazi = new HashSet<Izlazi>();
            Ulazi = new HashSet<Ulazi>();
        }

        public int SkladisteId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Izlazi> Izlazi { get; set; }
        public virtual ICollection<Ulazi> Ulazi { get; set; }
    }
}

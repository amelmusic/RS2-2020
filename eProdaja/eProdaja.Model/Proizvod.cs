using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
    public class Proizvod
    {
        public int Id { get; set; }
        public string Barkod { get; set; }
        public string Naziv { get; set; }

        public string KratkiNaziv { get; set; }
    }
}

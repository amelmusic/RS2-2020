using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        static List<Proizvod> Proizvodi { get; set; }

        static ProizvodController()
        {
            Proizvodi = new List<Proizvod>()
            {
                new Proizvod()
                {
                    Id = 1,
                    Naziv = "Janjetina",
                    KratkiNaziv = "Janje"
                },
                new Proizvod()
                {
                    Id = 2,
                    Naziv = "Laptop",
                    KratkiNaziv = "Lapt."
                }
            };
        }

        // GET: api/Proizvod
        [HttpGet]
        public IEnumerable<Proizvod> Get()
        {
            return Proizvodi;
        }

        // GET: api/Proizvod/5
        [HttpGet("{id}", Name = "Get")]
        public Proizvod Get(int id)
        {
            return Proizvodi.SingleOrDefault(x => x.Id == id);
        }

        // POST: api/Proizvod
        [HttpPost]
        public void Post([FromBody] Proizvod value)
        {
            Proizvodi.Add(value);
        }

        // PUT: api/Proizvod/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Proizvod value)
        {
            var old = Get(id);
            old.Naziv = value.Naziv;
            old.KratkiNaziv = value.KratkiNaziv;
        }

        
    }
}

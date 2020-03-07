using AutoMapper;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : IKorisniciService
    {
        protected eProdajaContext _context;
        protected IMapper _mapper;
        public KorisniciService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<Model.Korisnici> GetAll()
        {
            var entities = _context.Korisnici.ToList();
            //List<Model.Korisnici> result = new List<Model.Korisnici>();
            //entities
            //    .Where(x  => !string.IsNullOrEmpty(x.Email)).ToList()
            //    .ForEach(x => result.Add(new Model.Korisnici()
            //{
            //    Email = x.Email,
            //    Ime = x.Ime,
            //    KorisnickoIme = x.KorisnickoIme,
            //    KorisnikId = x.KorisnikId,
            //    Prezime = x.Ime,
            //    Status = x.Status,
            //    Telefon = x.Telefon,
            //    Index = 1000
            //}));

            var result = _mapper.Map<IList<Model.Korisnici>>(entities.Where(x => 1 == 1));


            return result;
        }

        public Korisnici GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Korisnici>(request);
            _context.Add(entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Korisnici Update(int id, Korisnici korisnici)
        {
            throw new NotImplementedException();
        }
    }
}

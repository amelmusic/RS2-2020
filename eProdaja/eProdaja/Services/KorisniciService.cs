using AutoMapper;
using eProdaja.Database;
using eProdaja.Filters;
using eProdaja.Model;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        public IList<Model.Korisnici> GetAll(KorisniciSearchRequest search)
        {
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime == search.Ime);
            }

            if (!string.IsNullOrWhiteSpace(search?.PrezimeFilter))
            {
                query = query.Where(x => x.Prezime == search.PrezimeFilter);
            }

            var entities = query.ToList();
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

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);
            _context.Add(entity);

            if(request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Password i potvrda se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        {
            //doboavljanje iz baze
            var entity = _context.Korisnici.Find(id);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Login(KorisniciLoginRequest request)
        {
            var entity = _context.Korisnici.FirstOrDefault(x => x.KorisnickoIme == request.Username);

            if(entity == null)
            {
                throw new UserException("Pogrešan username ili password");
            }

            var hash = GenerateHash(entity.LozinkaSalt, request.Password);

            if (hash != entity.LozinkaHash)
            {
                throw new UserException("Pogrešan username ili password");
            }

            return _mapper.Map<Model.Korisnici>(entity);
        }
    }
}

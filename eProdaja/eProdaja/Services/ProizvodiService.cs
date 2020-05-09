using AutoMapper;
using eProdaja.Database;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : BaseCRUDService<Model.Proizvodi, ProizvodiSearchRequest, ProizvodiInsertRequest, ProizvodUpdateRequest, Database.Proizvodi>, IProizvodiService
    {
        public ProizvodiService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IList<Model.Proizvodi> GetAll(ProizvodiSearchRequest search = null)
        {
            var query = _context.Set<Proizvodi>().AsQueryable();

            if (search?.VrstaId.HasValue == true)
            {
                query = query.Where(x => x.VrstaId == search.VrstaId);
            }

            if (!string.IsNullOrWhiteSpace(search?.Sadrzaj))
            {
                query = query.Where(x => x.Naziv.Contains(search.Sadrzaj) || x.Vrsta.Naziv.Contains(search.Sadrzaj));
            }

            query = query.OrderBy(x => x.Naziv);

            var list = query.ToList();

            return _mapper.Map<List<Model.Proizvodi>>(list);
        }
    }
}

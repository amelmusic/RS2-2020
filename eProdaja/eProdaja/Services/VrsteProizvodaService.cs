using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class VrsteProizvodaService : IVrsteProizvodaService
    {
        protected eProdajaContext _context;
        protected IMapper _mapper;
        public VrsteProizvodaService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<Model.VrsteProizvoda> GetAll(object search = null)
        {
            var result = _context.VrsteProizvoda.ToList();
            return _mapper.Map<IList<Model.VrsteProizvoda>>(result);
        }

        public Model.VrsteProizvoda GetById(int id)
        {
            var entity = _context.VrsteProizvoda.Find(id);
            return _mapper.Map<Model.VrsteProizvoda>(entity);
        }
    }
}

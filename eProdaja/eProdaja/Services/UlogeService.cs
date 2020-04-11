using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class UlogeService : IUlogeService
    {
        protected eProdajaContext _context;
        protected IMapper _mapper;
        public UlogeService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<Model.Uloge> GetAll(object search = null)
        {
            var result = _context.Uloge.ToList();
            return _mapper.Map<IList<Model.Uloge>>(result);
        }

        public Model.Uloge GetById(int id)
        {
            var entity = _context.Uloge.Find(id);
            return _mapper.Map<Model.Uloge>(entity);
        }
    }
}

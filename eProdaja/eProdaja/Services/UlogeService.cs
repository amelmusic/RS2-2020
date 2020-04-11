using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class UlogeService : BaseService<Model.Uloge, object, Database.Uloge>, IUlogeService
    {
        public UlogeService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

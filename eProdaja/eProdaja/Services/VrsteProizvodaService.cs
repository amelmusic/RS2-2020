using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class VrsteProizvodaService : BaseService<Model.VrsteProizvoda, object, Database.VrsteProizvoda> , IVrsteProizvodaService
    {
        public VrsteProizvodaService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

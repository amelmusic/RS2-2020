using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IVrsteProizvodaService
    {
        IList<Model.VrsteProizvoda> GetAll(object search = null);

        Model.VrsteProizvoda GetById(int id);
    }
}

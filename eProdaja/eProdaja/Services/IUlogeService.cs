using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IUlogeService
    {
        IList<Model.Uloge> GetAll(object search = null);

        Model.Uloge GetById(int id);
    }
}

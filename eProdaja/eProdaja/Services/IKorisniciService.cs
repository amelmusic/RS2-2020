using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IKorisniciService
    {
        IList<Model.Korisnici> GetAll();

        Korisnici GetById(int id);

        Model.Korisnici Insert(KorisniciInsertRequest korisnici);

        Korisnici Update(int id, Korisnici korisnici);
    }
}

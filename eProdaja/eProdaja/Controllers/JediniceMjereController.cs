using eProdaja.Model;
using eProdaja.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class JediniceMjereController : BaseController<Model.JediniceMjere, object>
    {
        public JediniceMjereController(IService<JediniceMjere, object> service) : base(service)
        {
        }
    }
}

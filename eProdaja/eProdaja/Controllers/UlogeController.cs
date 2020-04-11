using eProdaja.Model;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class UlogeController : BaseController<Model.Uloge, object>
    {
        public UlogeController(IUlogeService service) : base(service)
        {
        }
    }
}

using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogeController : ControllerBase
    {
        protected IUlogeService _service;

        public UlogeController(IUlogeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IList<Model.Uloge> GetAll([FromQuery]object request = null)
        {
            return _service.GetAll(request);
        }

        [HttpGet("{id}")]
        public Model.Uloge GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}

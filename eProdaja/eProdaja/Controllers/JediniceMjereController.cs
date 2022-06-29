using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JediniceMjereController : Controller
    {
        private readonly IJedniceMjereService _service;
        public JediniceMjereController(IJedniceMjereService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Model.JediniceMjere> Get()
        {
            return _service.Get();
        }
        [HttpGet("{ID}")]
        public Model.JediniceMjere GetById(int ID)
        {
            return _service.GetById(ID);
        }

    }
}

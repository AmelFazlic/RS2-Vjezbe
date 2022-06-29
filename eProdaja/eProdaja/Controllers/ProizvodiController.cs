using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : Controller
    {
        private readonly IProizvodiService _proizvodiService;
        public ProizvodiController(IProizvodiService proizvodiService)
        {
            _proizvodiService = proizvodiService;
        }

        [HttpGet]
        public IEnumerable<Proizvodi> Get()
        {
            return _proizvodiService.Get();
        }
        [HttpGet("{ID}")]
        public Proizvodi GetById(int ID)
        {
            return _proizvodiService.GetById(ID);
        }
        
    }
}

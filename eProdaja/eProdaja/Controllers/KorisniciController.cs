using eProdaja.Services;
using eProdaja.Services.Database;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : Controller
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService korisniciService)
        {
            _service = korisniciService;
        }
        [HttpGet]

        public IEnumerable<Model.Korisnici> GetAll()
        {
            return _service.Get();
        }
    }
}

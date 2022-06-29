using eProdaja.Services;
using eProdaja.Services.Database;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : Controller
    {
        private readonly IKorisniciService _korisniciService;
        public KorisniciController(IKorisniciService korisniciService)
        {
            _korisniciService = korisniciService;
        }
        [HttpGet]

        public IEnumerable<Model.Korisnici> GetAll()
        {
            return _korisniciService.Get();
        }
    }
}

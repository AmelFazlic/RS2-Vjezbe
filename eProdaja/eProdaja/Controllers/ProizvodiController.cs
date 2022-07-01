using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController] 
    [Route("[controller]")]
    public class ProizvodiController : BaseCRUDController<Model.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
        //private readonly IService<Model.Proizvodi> _service;
        public ProizvodiController(IProizvodiService service)
        : base(service){
            //_service = service;
        }

        //[HttpGet]
        //public IEnumerable<Model.Proizvodi> Get()
        //{
        //    return _service.Get();
        //}
        //[HttpGet("{ID}")]
        //public Model.Proizvodi GetById(int ID)
        //{
        //    return _service.GetById(ID);
        //}

    }
}

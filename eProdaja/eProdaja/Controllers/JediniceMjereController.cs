using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class JediniceMjereController : BaseCRUDController<Model.JediniceMjere, JediniceMjereSearchObject, JediniceMjereUpsertRequest, JediniceMjereUpsertRequest>
    {
        //private readonly IService<Model.JediniceMjere> _service;
        public JediniceMjereController(IJedniceMjereService service)
        : base (service){
        }

        //[HttpGet]
        //public IEnumerable<Model.JediniceMjere> Get()
        //{
        //    return _service.Get();
        //}
        //[HttpGet("{ID}")]
        //public Model.JediniceMjere GetById(int ID)
        //{
        //    return _service.GetById(ID);
        //}

    }
}

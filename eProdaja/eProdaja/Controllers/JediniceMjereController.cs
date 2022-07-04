using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class JediniceMjereController : BaseCRUDController<Model.JediniceMjere, JediniceMjereSearchObject, JediniceMjereUpsertRequest, JediniceMjereUpsertRequest>
    {
        //private readonly IService<Model.JediniceMjere> _service;
        public JediniceMjereController(IJedniceMjereService service)
        : base (service){
        }
        [AllowAnonymous]
        public override IEnumerable<JediniceMjere> Get([FromQuery] JediniceMjereSearchObject search)
        {
            return base.Get(search);
        }
        [AllowAnonymous]
        public override JediniceMjere GetById(int ID)
        {
            return base.GetById(ID);
        }
    }
}

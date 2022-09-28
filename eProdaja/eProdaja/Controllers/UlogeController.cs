using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class UlogeController : BaseController<Model.Uloge, BaseSearchObject>
    {
        //private readonly IService<Model.JediniceMjere> _service;
        public UlogeController(IService<Model.Uloge, BaseSearchObject> service)
        : base (service){
        }

    }
}

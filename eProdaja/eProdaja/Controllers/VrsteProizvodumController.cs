using eProdaja.Model.SearchObjects;
using eProdaja.Model.Request;
using Microsoft.AspNetCore.Mvc;
using eProdaja.Services;
using eProdaja.Model;

namespace eProdaja.Controllers
{
    public class VrsteProizvodumController : BaseCRUDController<Model.VrsteProizvodum, VrsteProizvodumSearchObject, VrsteProizvodumUpsertRequest, VrsteProizvodumUpsertRequest>
    {
        public VrsteProizvodumController(IVrsteProizvodumService service) : base(service)
        {
        }
    }
}

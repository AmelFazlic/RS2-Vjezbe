using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{

    public class ProizvodiController : BaseCRUDController<Model.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
        public IProizvodiService _service { get; set; }
        public ProizvodiController(IProizvodiService service)
        : base(service)
        {
            _service = service;
        }
        [HttpPut("{Id}/Activate")]
        public Model.Proizvodi Activate(int Id)
        {
            var result = _service.Activate(Id);
            return result;
        }
        [HttpPut("{Id}/Hide")]
        public Model.Proizvodi Hide(int Id)
        {
            var result = _service.Hide(Id);
            return result;
        }
        [HttpPut("{Id}/AllowedActions")]
        public List<string> AllowedActions(int Id)
        {
            var result = _service.AllowedActions(Id);
            return result;
        }

    }
}

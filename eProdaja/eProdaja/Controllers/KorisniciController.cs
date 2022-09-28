using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using eProdaja.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace eProdaja.Controllers
{
    public class KorisniciController : BaseCRUDController<Korisnici, KorisniciSearchObject, KorisniciInsertRequest, KorisniciUpdateRequest>
    {
        public KorisniciController(IKorisniciService service) : base(service)
        {
        }

        [Authorize(Roles = "Administrator")]
        public override Korisnici Insert([FromBody] KorisniciInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Administrator")]
        public override Korisnici Update(int Id, [FromBody] KorisniciUpdateRequest update)
        {
            return base.Update(Id, update);
        }
    }
}

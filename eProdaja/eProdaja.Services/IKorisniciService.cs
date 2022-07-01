using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IKorisniciService : ICRUDService<Model.Korisnici,KorisniciSearchObject, KorisniciInsertRequest, KorisniciUpdateRequest>
    {
    }
}

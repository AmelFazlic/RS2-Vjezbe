using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;

namespace eProdaja.Services
{
    public interface IJedniceMjereService : ICRUDService<Model.JediniceMjere, JediniceMjereSearchObject, JediniceMjereUpsertRequest, JediniceMjereUpsertRequest>
    { 
    }
}

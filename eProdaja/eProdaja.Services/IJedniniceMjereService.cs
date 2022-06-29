using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IJedniceMjereService
    {
        IEnumerable<Model.JediniceMjere> Get();
        Model.JediniceMjere GetById(int id);
    }
}

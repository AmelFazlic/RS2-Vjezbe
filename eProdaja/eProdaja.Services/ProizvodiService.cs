using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : IProizvodiService
    {
        public List<Proizvodi> ProizvodiList = new List<Proizvodi> { new Proizvodi { Id = 1, Name = "Televizor" }, new Proizvodi { Id = 2, Name = "Frizider" } };
        public IEnumerable<Proizvodi> Get()
        {
            return ProizvodiList;
        }

        public Proizvodi GetById(int id)
        {
            Proizvodi proizvodi = ProizvodiList.FirstOrDefault(x => x.Id == id);
            return proizvodi;
        }
    }
}

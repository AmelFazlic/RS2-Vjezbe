using AutoMapper;
using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class VrsteProizvodumService : BaseCRUDService<Model.VrsteProizvodum, Database.VrsteProizvodum, VrsteProizvodumSearchObject, VrsteProizvodumUpsertRequest, VrsteProizvodumUpsertRequest>, IVrsteProizvodumService
    {
        public VrsteProizvodumService(IMapper mapper, eProdajaContext context) : base(mapper, context)
        { 
        }

        public override IQueryable<VrsteProizvodum> AddFilter(IQueryable<VrsteProizvodum> query, VrsteProizvodumSearchObject search)
        {
            var filterQuery =  base.AddFilter(query, search);

            if(!string.IsNullOrWhiteSpace(search?.NazivGT))
            {
                filterQuery = filterQuery.Where(x => x.Naziv.Contains(search.NazivGT));
            }

            return filterQuery;
        }
    }
}

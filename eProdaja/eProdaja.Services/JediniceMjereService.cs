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
    public class JediniceMjereService : BaseCRUDService<Model.JediniceMjere, JediniceMjere, JediniceMjereSearchObject, JediniceMjereUpsertRequest, JediniceMjereUpsertRequest>, IJedniceMjereService
    {
        //public eProdajaContext _context { get; set; }
        //public IMapper _mapper { get; set; }
        public JediniceMjereService(IMapper mapper, eProdajaContext context)   
        : base(mapper, context){
            //_mapper = mapper;
            //_context = context;
        }
        //public List<Model.Proizvodi> ProizvodiList = new List<Model.Proizvodi> { new Model.Proizvodi { ProizvodId = 1, Naziv = "Televizor" }, new Model.Proizvodi { ProizvodId = 2, Naziv = "Frizider" } };

        public override IQueryable<JediniceMjere> AddFilter(IQueryable<JediniceMjere> query, JediniceMjereSearchObject search)
        {
            var filterQuery = base.AddFilter(query, search);
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                filterQuery = filterQuery.Where(x => x.Naziv == search.Naziv);
            }
            if (search?.JedinicaMjereId.HasValue == true)
            {
                filterQuery = filterQuery.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);
            }
       
            return filterQuery;
        }







        //public IEnumerable<Model.JediniceMjere> Get()
        //{
        //    var lista = _context.JediniceMjeres.ToList();
        //    return _mapper.Map<List<Model.JediniceMjere>>(lista);
        //}

        //public Model.JediniceMjere GetById(int JedinicaMjereId)
        //{
        //    JediniceMjere proizvodi = _context.JediniceMjeres.Find(JedinicaMjereId);
        //    return _mapper.Map<Model.JediniceMjere>(proizvodi);
        //}
    }
}

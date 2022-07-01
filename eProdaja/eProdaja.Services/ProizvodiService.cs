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
    public class ProizvodiService 
        : BaseCRUDService<Model.Proizvodi, Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>, 
        IProizvodiService
    {
        //public eProdajaContext _context { get; set; }
        //public IMapper _mapper { get; set; }
        public ProizvodiService(IMapper mapper, eProdajaContext context)   
        :base(mapper, context){
            //_mapper = mapper;
            //_context = context;
        }
        //public override IEnumerable<Model.Proizvodi> Get (ProizvodiSearchObject search = null)
        //{
        //    return base.Get(search);
        //}

        public override IQueryable<Proizvodi> AddFilter(IQueryable<Proizvodi> query, ProizvodiSearchObject search)
        {
            var filterQuery = base.AddFilter(query, search);
            if (!string.IsNullOrWhiteSpace(search?.Sifra))
            {
                filterQuery = filterQuery.Where(x=> x.Sifra == search.Sifra);
            }
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                filterQuery = filterQuery.Where(x => x.Naziv.Contains(search.Naziv));
            }

            return filterQuery;
        }


        //public IEnumerable<Model.Proizvodi> Get()
        //{
        //    var lista = _context.Proizvodis.ToList();
        //    return _mapper.Map<List<Model.Proizvodi>>(lista);
        //}

        //public Model.Proizvodi GetById(int ProizvodId)
        //{
        //    Proizvodi proizvodi = _context.Proizvodis.Find(ProizvodId);
        //    return _mapper.Map<Model.Proizvodi>(proizvodi);
        //}
    }
}

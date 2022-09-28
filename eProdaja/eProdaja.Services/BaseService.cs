using AutoMapper;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseService<T, TDb, TSearch> 
        : IService<T, TSearch> where T : class where TDb : class where TSearch : BaseSearchObject
    {
        public eProdajaContext _context { get; set; }
        public IMapper _mapper { get; set; }
        public BaseService(IMapper mapper, eProdajaContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        //public List<Model.Proizvodi> ProizvodiList = new List<Model.Proizvodi> { new Model.Proizvodi { ProizvodId = 1, Naziv = "Televizor" }, new Model.Proizvodi { ProizvodId = 2, Naziv = "Frizider" } };
        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var lista = _context.Set<TDb>().AsQueryable();

            lista = AddFilter(lista, search);
            lista = AddInclude(lista, search);

            if (search.Page.HasValue == true)
            {
                lista = lista.Take(search.PageSize.Value).Skip(search.Page.Value);
            }

            return _mapper.Map<IList<T>>(lista);
        }

        public virtual IQueryable<TDb> AddInclude(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }
        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }
        public T GetById(int id)
        {
            var set = _context.Set<TDb>().Find(id);
            return _mapper.Map<T>(set);
        }

    }
}

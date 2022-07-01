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
    public class BaseCRUDService<T,TDb, TSearch, TInsert, TUpdate> 
        :BaseService <T, TDb, TSearch>, 
         ICRUDService <T, TSearch, TInsert, TUpdate> where T : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class where TDb : class
    {
        public eProdajaContext _context { get; set; }
        public IMapper _mapper { get; set; }
        public BaseCRUDService(IMapper mapper, eProdajaContext context)
        : base(mapper, context){
            _mapper = mapper;
            _context = context;
        }

        public T Insert(TInsert obj)
        {
            var set = _context.Set<TDb>();
            
            TDb newObj = _mapper.Map<TDb>(obj);

            set.Add(newObj);
            _context.SaveChanges();

            return _mapper.Map<T>(newObj);
        }

        public T Update(int Id, TUpdate obj)
        {
            var set = _context.Set<TDb>();

            var entity = set.Find(Id);

            if(entity != null)
            {
                _mapper.Map(obj,entity);
            }
            else
            {
                return null;
            }
            _context.SaveChanges();
            return _mapper.Map<T>(entity);
        }
    }
}
